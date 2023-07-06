using BGMSTORE.Module;
using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace BGMSTORE
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        //Member Variable-----------------------------------------------------------------------------
        BGMManager bgm_manager = new BGMManager();
        PlayList player_list = null;
        InIWriter ini_writer = new InIWriter(Utility.config_path);

        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        //----------------------------------------------------------------------------------------

        public Main()
        {
            InitializeComponent();
        }




        // 메인폼 실행시 업데이트 체크용도로 사용하는 함수
        private void update_check()
        {
            //pastebin 에 가서 요청을 보낸 후 응답 데이터를 string 값으로 저장
            var update_check_url = "https://pastebin.com/raw/mQBQX95E";
            var web_client = new WebClient();
            var html = web_client.DownloadString(update_check_url);

            var doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(html);

            //여기서 응답 데이터가 response에 담김
            string response = doc.DocumentNode.InnerText;

            if (!response.Contains(Utility.current_version))
            {
                if (MessageBox.Show("업데이트가 발견되었습니다 사이트로 이동하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    int a = response.IndexOf('"');
                    int b = response.IndexOf('|');

                    string version = response.Substring(a, b - a + 1);
                    version = version.Replace("|", "");
                    version = version.Replace("\"", "");


                    System.Diagnostics.Process.Start(version);
                    this.Close();
                }
                else
                {
                    this.Close();
                }
            }
        }


        //더블버퍼링을 위한 가상함수 덮어 쓰기
        protected virtual bool DoubleBuffered { get; set; }

        private async void Main_Load(object sender, EventArgs e)
        {
            //더블 버퍼링 활성화로 리스트뷰 깜빡임 최소화
            listView1.DoubleBuffered(true);


            //webBrowser1.Navigate("http://go.gagalive.kr/d/~~~new_musicmaster&fonttype=%EB%82%98%EB%88%94%EA%B3%A0%EB%94%95&fontcolor=00000&fontlarge=true&position=2");

            update_check(); //assert() 처럼 업데이트 조건이 만족되지 않으면 폼을 종료시키는 기능이 있다.
            write_default_ini(); //기본 INI 쓰기
            set_default_combobox(); //콤보박스 기본값 설정하기

            // 기본 이벤트 추가
            bgm_manager.sprogress += BGMMANAGER_SProgress;
            listView1.DoubleClick += ListView1_DoubleClick;
            player.PlayStateChange += Player_PlayStateChange;
            player.PositionChange += Player_PositionChange;
            //----------------------------------

            //데이터 불러오기
            await bgm_manager.get_main_data_async(listView1);

            timer1.Enabled = true;


            PatchLog patch = new PatchLog();
            patch.Show(); //패치로그창 열기


            //player_list = new PlayList(this);
            //player_list.Show();
            //player_list.Hide(); //열고 바로 숨김

        }

        private void write_default_ini()
        {
            if (File.Exists(Utility.config_path) == false)
            {
                ini_writer.Write("설정", "다운로드", "Mp3");
                ini_writer.Write("설정", "더블클릭", "music");
                ini_writer.Write("설정", "미리듣기", "Mp3");
                ini_writer.Write("BGM", "NEWEST", "5");
                ini_writer.Write("BGM", "NEWEST_COMPOSITION", "5");
                ini_writer.Write("BGM", "NEWEST_VOTED", "5");
                ini_writer.Write("BGM", "RANDOM", "5");
                ini_writer.Write("BGM", "WEEKLY_BEST_COMPOSITION", "20");
            }
        }

        private void set_default_combobox()
        {
            search_option_a.SelectedIndex = 0;
            search_option_b.SelectedIndex = 0;

            search_option_a.DropDownStyle = ComboBoxStyle.DropDownList;
            search_option_b.DropDownStyle = ComboBoxStyle.DropDownList;
            // 검색 초기 설정 [인덱스, 수정불가]
        }

        private void BGMMANAGER_SProgress(int progress_value)
        {
            this.progressBar1.Value = progress_value;
        }

        public void play_mp3_from_url(string url, string title)
        {
            player.URL = url;
            if (player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                player.close();
                player.controls.play();
            }
            else
            {
                player.controls.play();
            }

            // 특정 글자수 넘으면 잘라버리고 뒤는 ...으로 처리
            const int title_limit = 35;
            if (title.Length > title_limit)
            {
                title = title.Substring(0, title_limit);
                title += "...";
            }

            //UI 초기화
            playtext.Text = title;
            playctime.Text = "00:00";
        }

        private void Player_PositionChange(double oldPosition, double newPosition)
        {
            //playctime.Text = player.controls.currentPositionString;
        }

        private void Player_PlayStateChange(int new_state)
        {
            if ((WMPLib.WMPPlayState)new_state == WMPLib.WMPPlayState.wmppsStopped)
            {
                MediaPlay.Enabled = false;
                //StopPlay(); //재생 종료

                playbar.Value = playbar.Minimum;
                playtext.Text = "현재 재생중인 노래 없음";
                playtime.Text = "00:00";
                playctime.Text = "00:00";

                playbar.Enabled = false;

                if (PlayList.is_play)
                { //일괄재생 중이면

                    string url = player_list.next_play();
                    if (url != "finish")
                    {
                        player = new WMPLib.WindowsMediaPlayer
                        {
                            URL = url
                        };
                        player.controls.play();
                        playtext.Text = PlayList.CurrentPlay;


                        player.PlayStateChange += Player_PlayStateChange;
                        player.PositionChange += Player_PositionChange;
                    }
                    else
                    {
                        stop_play();
                    }
                }

            }
            else if ((WMPLib.WMPPlayState)new_state == WMPLib.WMPPlayState.wmppsPlaying)
            {
                playbar.Maximum = (int)player.currentMedia.duration;

                playbar.Enabled = true;
                MediaPlay.Enabled = true;
                playtime.Text = player.currentMedia.durationString;

                //playbar.Value = playbar.Minimum;

            }
        }




        private void ListView1_DoubleClick(object sender, EventArgs e)
        {
            // 더블클릭을 해도 선택한 아이템이 없으면 그냥 종료
            if (listView1.SelectedItems.Count <= 0)
                return;

            string data = bgm_manager.title_id[listView1.SelectedItems[0].SubItems[1].Text];

            if (ini_writer.Read("설정", "더블클릭") == "music")
            {
                if (!bgm_manager.is_play)
                {
                    if (ini_writer.Read("설정", "미리듣기") == "Mp3")
                    {
                        string url = "https://media1.bgmstore.net/mp3/" + data + ".mp3";
                        play_mp3_from_url(url, listView1.SelectedItems[0].SubItems[1].Text);
                    }
                    else //Mp4면
                    {
                        string url = "https://media1.bgmstore.net/mp4/" + data + "/mp4/Untitled1";
                        //WMP.URL = url;
                    }
                }
                else
                {
                    MessageBox.Show("일괄 재생중에는 미리듣기 기능을 활용할 수 없습니다." + Environment.NewLine + "일괄재생을 종료하신후 시도하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else //사이트 이동이면(site)
            {
                System.Diagnostics.Process.Start("https://bgmstore.net/" + data);
            }
        }

        private async void btn_Search_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_search.Text))
            {
                await bgm_manager.get_main_data_async(listView1);
            }
            else
            {
                await bgm_manager.search_bgm_async(listView1, txt_search.Text, search_option_a.Text + "|" + search_option_b.Text);
            }
        }

        private async void btn_Moreload_Click(object sender, EventArgs e)
        {
            btn_more_load.Enabled = false;

            // 검색어가 없는 상태서 더보기를 누르면 모든 카테고리를 불러오고 그 중 일부를 추가로 리스트에 추가함
            if (string.IsNullOrWhiteSpace(txt_search.Text))
            {
                await bgm_manager.more_load_async(Mode.Main, listView1, "None");
            }
            // 검색을 한 상태일 경우 (검색어가 입력된 상태일 경우) 검색어를 기준으로 더 불러옴
            else
            {
                await bgm_manager.more_load_async(Mode.Search, listView1, txt_search.Text);
            }

            btn_more_load.Enabled = true;
        }


        private void btn_AllCheck_Click(object sender, EventArgs e)
        {
            Utility.check_all_data(listView1, true);
        }

        private void btn_NoCheck_Click(object sender, EventArgs e)
        {
            Utility.check_all_data(listView1, false);
        }


        private void btn_Download_Click(object sender, EventArgs e)
        {
            music_download();
        }

        private void music_download()
        {
            //Early Return Pattern
            if (listView1.CheckedItems.Count == 0)
            {
                MessageBox.Show("다운로드할 음악을 선택해주세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("선택하신 음악은 " + listView1.CheckedItems.Count + "개 입니다." + Environment.NewLine + "다운로드를 진행하시겠습니까?", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                int idx = 0;
                int[] download_idxs = new int[listView1.CheckedItems.Count];
                string[] titles = new string[listView1.CheckedItems.Count];

                //체크된 항목들의 인덱스를 콜렉션으로 가져옴 == listView1.CheckedIndices
                foreach (int checked_idx in listView1.CheckedIndices)
                {
                    download_idxs[idx] = checked_idx; //리스트뷰 인덱스값을 i에 넘긴다
                    idx++;
                }

                idx = 0;
                foreach (ListViewItem item in listView1.CheckedItems)
                {
                    titles[idx] = item.SubItems[1].Text;
                    idx++;
                }

                /*
                foreach (var item in download_idxs)
                {
                    Console.WriteLine(item);
                }

                foreach (var item in titles)
                {
                    Console.WriteLine(item);
                }
                */

                bgm_manager.download_bgm_async(download_idxs, titles, download_count); // 인덱스값을 다시 DownloadBGM 메서드로 옮긴다.
            }

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            NowTime.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void 설정ToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (Utility.is_dup_form("OptionPage") == null)
            {
                OptionPage opt = new OptionPage();
                opt.Show();
            }
        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            music_download();

        }



        private void SearchTitle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_Search_Click_1(sender, e);
            }
        }



        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                _menu.Show(this, new Point(e.X, e.Y));
            }
        }





        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (listView1.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    _listviewM.Show(Cursor.Position);
                }
            }
        }

        private void 설정ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Utility.is_dup_form("OptionPage") == null)
            {
                OptionPage opt = new OptionPage();
                opt.Show();
            }
        }


        private void 사이트열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string url = "https://bgmstore.net/view/" + bgm_manager.title_id[listView1.SelectedItems[0].SubItems[1].Text];
            System.Diagnostics.Process.Start(url);

        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {

            if (listView1.Sorting == SortOrder.Descending)
                listView1.Sorting = SortOrder.Ascending;
            else
                listView1.Sorting = SortOrder.Descending;


            listView1.ListViewItemSorter = new Sorter();      // * 1
            Sorter s = (Sorter)listView1.ListViewItemSorter;
            s.Order = listView1.Sorting;
            s.Column = e.Column;
            listView1.Sort();



        }


        /*
        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            if (listView2.SelectedItems.Count != 0)
            {
                if (BGMMANAGER.play == false)
                {
                    int index = listView2.SelectedIndices[0];
                    listView2.Items.RemoveAt(index);
                    BGMMANAGER.FavoriteList.RemoveAt(index);
                }
               
            }
        }
        */

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {


        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Utility.is_dup_form("About") == null)
            {
                About sfrm = new About();
                sfrm.Show();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.is_dup_form("About") == null) //창이 이미 떠있지 않으면
            {
                About sfrm = new About();
                sfrm.Show();
            }
            else
            {

            }
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            Console.WriteLine(player.controls.currentPosition);
            try
            {
                MediaPlay.Enabled = false; //잠시 동기화 타이머를 멈춘다
                                           //Player.controls.pause(); // 재생하던 플레이어도 잠시 멈춘다

                player.controls.currentPosition = playbar.Value; //트랙바 클릭시 플레이어의 재생시간을 변경한다
                MediaPlay.Enabled = true;
                //Player.controls.play();
            }
            catch
            {
                // ignored
            }
        }

        private void MediaPlay_Tick(object sender, EventArgs e)
        {
            playbar.Value = (int)player.controls.currentPosition; //트랙바의 값과 플레이어의 재생시간을 일치 시킨다

            if (player.controls.currentPositionString.Trim() != "")
                playctime.Text = player.controls.currentPositionString;

        }

        private void pause_Click(object sender, EventArgs e)
        {
            player.controls.pause();
        }

        private void play_Click(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void stop_Click(object sender, EventArgs e)
        {

            if (PlayList.is_play)
            {

                PlayList.is_play = false;
                stop_play();
            }
            else
            {
                stop_play();
            }

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            //playList = new PlayList(this);*/
            try
            {
                player_list.Show(); //숨김 해재
            }
            catch
            {
                //ignore
            }




            //MessageBox.Show("준비중입니다.");
        }

        private void NowTime_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PING!");
        }

        private void playtext_Click(object sender, EventArgs e)
        {

        }

        public void stop_play()
        {
            player.controls.stop();
            player.close();
        }

        private void 리스트추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                foreach (ListViewItem ld in listView1.SelectedItems)
                {
                    string[] items = new string[4];

                    items[0] = ld.Text;   //카테고리
                    items[1] = ld.SubItems[1].Text; //제목
                    items[2] = ld.SubItems[2].Text; //재생시간
                    items[3] = ld.SubItems[3].Text; // 추천수

                    ListViewItem lv = new ListViewItem(items)
                    {
                        ForeColor = ColorTranslator.FromHtml("#4285F4")
                    };


                    lv.SubItems[2].ForeColor = ColorTranslator.FromHtml("#4285F4");
                    lv.UseItemStyleForSubItems = false;

                    if (Utility.find_item(player_list.plist, items[1]) == false)
                    {

                        player_list.plist.Items.Add(lv);
                        PlayList.titleid.Add(items[1], bgm_manager.title_id[items[1]]);

                    }
                    else
                    {
                        MessageBox.Show("이미 존재합니다");
                    }
                }
            }
        }

        private void btn_Random_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("미구현입니다.");
            var random_bgm = bgm_manager.get_random_bgm();
            string url = "https://media1.bgmstore.net/mp3/" + random_bgm.keyVal + ".mp3";
            string title = random_bgm.title;
            play_mp3_from_url(url, title);
        }

        private void playtime_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            slidedown.Enabled = true;
        }

        private void slidedown_Tick(object sender, EventArgs e)
        {
            if (this.Width >= 958) slidedown.Enabled = false;
            else this.Width += 30;
        }

        private void playbar_ValueChanged(object sender, EventArgs e)
        {
            //int value = playbar.Value;
            //Console.WriteLine("TrackBar Value: " + value);
        }
    }
}

