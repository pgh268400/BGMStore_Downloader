using BGMSTORE.Module;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace BGMSTORE
{
    public partial class PlayList : MetroFramework.Forms.MetroForm
    {
        BGMManager jsonParser = new BGMManager();
        Main main;
        public static Dictionary<string, string> titleid = new Dictionary<string, string>();  //브금의 제목과 KeyVal을 담을 딕셔너리
        List<string> name = new List<string>(); //JSON 읽기
        public static string CurrentPlay = ""; //다음곡 데이터
        public int idx = 0;

        private bool load = false;

        public PlayList()
        {
            InitializeComponent();
        }
        public PlayList(Main m)
        {
            InitializeComponent();
            main = m;
        }

        public static bool is_play = false;





        private void PlayList_Load(object sender, EventArgs e)
        {
            if (load != true)
            {
                get();
                load = true;
            }

            if (plist.Items.Count == 0) //내 플레이리스트에 하나도없으면
            {
                this.metroTabControl1.SelectedTab = this.metroTabPage1; // 기본탭 페이지 1번페이지로 설정

            }
            else // 있으면
            {
                this.metroTabControl1.SelectedTab = this.metroTabPage2; // 기본탭 페이지 2번페이지로 설정
            }


            //comboBox1.SelectedIndex = 0;

            get_json_list();

            //FTP ftp = new FTP();
            //ftp.Upload("MusicList\\02년 추억의 BGM.json");
            //ftp.Download();




        }



        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }



        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }



        private async void get()
        {


            JObject jObject = JObject.Parse(jsonParser.get_play_list()); //문자를 객체화
            JToken jToken = jObject["data"]["getPlaylists"];

            int i = 0;
            string[] items = new string[4];
            foreach (JToken jt in jToken)
            {

                items[0] = jt["title"].ToString(); //제목
                items[1] = ((JArray)jt["documents"]).Count.ToString(); //곡개수
                items[2] = jt["user"]["nickname"].ToString(); //user
                items[3] = jt["voteCnt"].ToString(); //추천수



                ListViewItem listViewItem = new ListViewItem(items);

                //listViewItem.ForeColor = ColorTranslator.FromHtml("#4285F4");
                listViewItem.SubItems[1].ForeColor = ColorTranslator.FromHtml("#4285F4");
                listViewItem.SubItems[3].ForeColor = ColorTranslator.FromHtml("#4285F4");
                listViewItem.UseItemStyleForSubItems = false;
                userlist.Items.Add(listViewItem);

            }


        }


        private async void get_user_list()
        {

            JObject jObject = JObject.Parse(jsonParser.get_play_list()); //문자를 객체화
            JToken jToken = jObject["data"]["getPlaylists"];

            int i = 0;
            string[] items = new string[4];
            foreach (JToken jt in jToken)
            {

                items[0] = jt["title"].ToString(); //제목
                items[1] = ((JArray)jt["documents"]).Count.ToString(); //곡개수
                items[2] = jt["user"]["nickname"].ToString(); //user
                items[3] = jt["voteCnt"].ToString(); //추천수



                ListViewItem listViewItem = new ListViewItem(items);

                //listViewItem.ForeColor = ColorTranslator.FromHtml("#4285F4");
                listViewItem.SubItems[1].ForeColor = ColorTranslator.FromHtml("#4285F4");
                listViewItem.SubItems[3].ForeColor = ColorTranslator.FromHtml("#4285F4");
                listViewItem.UseItemStyleForSubItems = false;
                userlist.Items.Add(listViewItem);
            }
        }

        public string next_play()
        {
            try
            {
                idx += 1;
                CurrentPlay = plist.Items[idx].SubItems[1].Text;

                string url = "https://mp31.bgms.kr/pds/mp3/" + titleid[CurrentPlay] + ".mp3";
                return url;
            }
            catch
            {
                //인덱스 초과시
                return "finish";
            }


        }


        public void get_json_list()
        {
            pcombo.Items.Clear();
            string dirPath = Application.StartupPath + "\\MusicList\\";
            if (Directory.Exists(dirPath))
            {
                DirectoryInfo di = new DirectoryInfo(dirPath);
                foreach (var item in di.GetFiles())
                {

                    pcombo.Items.Add(item.Name.Replace(".json", ""));
                }
            }
        }

        private async void add_play_list(string text)
        {
            BGMManager jsonParser = new BGMManager();
            JObject jObject = JObject.Parse(jsonParser.get_play_list()); //문자를 객체화
            JToken jToken = jObject["data"]["getPlaylists"];

            int i = 0;


            foreach (JToken jt in jToken)
            {
                if (jt["title"].ToString() == text) //Json 값의 Title값 검색 성공하면
                {
                    foreach (JToken jts in jt["documents"])
                    {
                        string[] items = new string[4];
                        items[0] = jts["category"].ToString();
                        items[1] = jts["title"].ToString();
                        items[2] = jts["duration"].ToString();
                        items[3] = jts["voteCnt"].ToString();



                        ListViewItem listViewItem = new ListViewItem(items);

                        listViewItem.ForeColor = ColorTranslator.FromHtml("#4285F4");
                        listViewItem.SubItems[2].ForeColor = ColorTranslator.FromHtml("#4285F4");
                        listViewItem.UseItemStyleForSubItems = false;

                        if (Utility.find_item(plist, items[1]) == false)
                        {
                            plist.Items.Add(listViewItem);
                            titleid[items[1]] = jts["keyVal"].ToString(); //딕셔너리 추가
                        }



                        i++;

                    }



                }
            }



            Console.ReadLine();
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            if (userlist.SelectedItems.Count > 0)
            {
                string data = userlist.SelectedItems[0].Text;
                add_play_list(data);

                MessageBox.Show("나의 플레이리스트에 곡이 추가되었습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }


        private void listView2_DoubleClick(object sender, EventArgs e)
        {
            if (plist.SelectedItems.Count > 0)
            {


                string data = titleid[plist.SelectedItems[0].SubItems[1].Text];
                string url = "https://mp31.bgms.kr/pds/mp3/" + data + ".mp3";

                main.play_mp3_from_url(url, plist.SelectedItems[0].SubItems[1].Text);
                is_play = true;

                idx = plist.SelectedIndices[0];
                CurrentPlay = plist.Items[idx].SubItems[1].Text;

            }

        }





        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btn_Moreload_Click(sender, e);

        }

        private void SaveJson()
        {
            JArray musiclist = new JArray(); //Jarray 객체 생성
            JObject musicdata = new JObject();
            foreach (ListViewItem ld in plist.Items) //플레이리스트 항목만큼 반복
            {
                musicdata =
                new JObject(
                            new JProperty("category", ld.Text),
                            new JProperty("title", ld.SubItems[1].Text),
                            new JProperty("duration", ld.SubItems[2].Text),
                            new JProperty("voteCnt", ld.SubItems[3].Text),
                            new JProperty("keyVal", titleid[ld.SubItems[1].Text]));
                musiclist.Add(musicdata);

            }

            using (StreamWriter file = File.CreateText(Application.StartupPath + "\\MusicList\\" + pcombo.Text + ".json"))
            {
                using (JsonTextWriter writer = new JsonTextWriter(file))
                {
                    musiclist.WriteTo(writer);
                }
            }
            MessageBox.Show("저장이 완료되었습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            get_json_list();
        }



        private void metroButton1_Click(object sender, EventArgs e) //플레이 리스트 저장하기
        {

            if (!String.IsNullOrEmpty(pcombo.Text)) //콤보박스 내용이 비지않았으면
            {

                if (plist.Items.Count > 0)
                {
                    SaveJson();
                }
            }



        }




        private void timer1_Tick(object sender, EventArgs e)
        {

            CurrentPlay = plist.Items[idx].SubItems[1].Text;

        }

        private void btn_AllCheck_Click(object sender, EventArgs e)
        {
            //jsonParser.check_all_data_listview(plist, true);
        }

        private void btn_NoCheck_Click(object sender, EventArgs e)
        {
            //jsonParser.check_all_data_listview(plist, false);
        }

        private void btn_Moreload_Click(object sender, EventArgs e)
        {
            if (plist.CheckedItems.Count > 0)
            {
                foreach (ListViewItem ld in plist.CheckedItems)
                {
                    plist.Items.Remove(ld);

                    foreach (var key in titleid.Keys.ToList())
                    {
                        titleid.Remove(ld.SubItems[1].Text);
                    }

                }
            }
        }

        private void PlayList_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; //폼 종료 막기
            this.Hide(); //폼 숨기기
        }

        private void PlayList_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void listView2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (plist.FocusedItem.Bounds.Contains(e.Location) == true)
                {
                    _playlist.Show(Cursor.Position);
                }
            }
        }

        private void _playlist_Opening(object sender, CancelEventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            plist.Items.Clear();
            titleid.Clear(); //딕셔너리, 리스트 초기화
            if (!String.IsNullOrEmpty(pcombo.Text)) //콤보박스 내용이 비지않았으면
            {
                using (StreamReader r = new StreamReader(Application.StartupPath + "\\MusicList\\" + pcombo.Text + ".json"))
                {
                    string json = r.ReadToEnd();
                    //JObject jObject = JObject.Parse(json); //문자를 객체화
                    JArray jObject = JArray.Parse(json);
                    JToken jToken = jObject; //Jtoken 으로 변경


                    foreach (JToken jt in jToken)
                    {

                        string[] items = new string[5];
                        items[0] = jt["category"].ToString();
                        items[1] = jt["title"].ToString();
                        items[2] = jt["duration"].ToString();
                        items[3] = jt["voteCnt"].ToString().Replace("+", "");
                        items[4] = jt["keyVal"].ToString();
                        ListViewItem listViewItem = new ListViewItem(items);

                        listViewItem.ForeColor = ColorTranslator.FromHtml("#4285F4");
                        listViewItem.SubItems[2].ForeColor = ColorTranslator.FromHtml("#4285F4");
                        listViewItem.UseItemStyleForSubItems = false;

                        if (Utility.find_item(plist, items[1]) == false)
                        {
                            titleid.Add(items[1], items[4]);
                            plist.Items.Add(listViewItem);
                        }

                    }



                }
            }

        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

            get_json_list();
        }

        private void metroButton4_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(pcombo.Text)) //콤보박스 내용이 비지않았으면
            {
                FileInfo file = new FileInfo(Application.StartupPath + "\\MusicList\\" + pcombo.Text + ".json");
                file.Delete();

                pcombo.Items.Remove(pcombo.Text);
                pcombo.Text = "";

                MessageBox.Show("삭제 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                get_json_list();
            }
        }

        private void metroButton5_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroTabControl1_Click(object sender, EventArgs e)
        {


        }

        private void pcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            int count = 0;
            using (StreamReader r = new StreamReader(Application.StartupPath + "\\MusicList\\" + pcombo.Text + ".json"))
            {
                string json = r.ReadToEnd();
                //JObject jObject = JObject.Parse(json); //문자를 객체화
                JArray jObject = JArray.Parse(json);
                JToken jToken = jObject; //Jtoken 으로 변경


                foreach (JToken jt in jToken)
                {
                    count++;
                }
            }
            selectt.Text = pcombo.Text;
            pcount.Text = count.ToString();
        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {
            if (nick.Text == "익명의 닝겐")
            {
                nick.Clear();
            }
        }

        private void metroTextBox2_Click(object sender, EventArgs e)
        {
            if (title.Text == "익명의 BGM")
            {
                title.Clear();

            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {


            FTP ftp = new FTP();

            using (StreamReader r = new StreamReader(Application.StartupPath + "\\MusicList\\" + selectt.Text + ".json"))
            {
                string json = r.ReadToEnd();
                JArray jObject = JArray.Parse(json);
                JToken jToken = jObject; //Jtoken 으로 변경


                JArray musiclist = new JArray(); //Jarray 객체 생성
                JObject musicdata = new JObject();

                foreach (JToken jt in jToken) // 읽은 JSON 만큼 반복하기
                {

                    musicdata =
                    new JObject(
                                new JProperty("category", jt["category"].ToString()),
                                new JProperty("title", jt["title"].ToString()), //곡명
                                new JProperty("duration", jt["duration"].ToString()),
                                new JProperty("voteCnt", jt["voteCnt"].ToString()),
                                new JProperty("keyVal", jt["keyVal"].ToString()));

                    musiclist.Add(musicdata);
                }

                string title = selectt.Text;
                JObject BaseData =
                    new JObject(
                        new JProperty("data",
                            new JObject(
                                new JProperty("getPlaylists",
                                    new JObject(
                                        new JProperty("title", title),
                                            new JProperty("documents", musiclist),
                                            new JProperty("user",
                                                new JObject(
                                                    new JProperty("nickname", nick.Text),
                                                    new JProperty("password", password.Text),
                                                    new JProperty("ipAddr", null)
                                                    )))))));




                JObject origin = JObject.Parse(ftp.download());
                JArray musiclist2 = new JArray();


                JToken JTOKEN = origin["data"]["getPlaylists"]; //FTP 에있는 데이터 가져오기
                JToken JTOKEN2 = BaseData["data"]["getPlaylists"]; //방금생성한 Json 가져오기

                foreach (var str in JTOKEN)
                {
                    MessageBox.Show(str.ToString());
                }
                musiclist2.Add(JTOKEN);
                musiclist2.Add(JTOKEN2); //musiclist2에 추가


                ftp.upload("music.json", musiclist2.ToString());
            }




        }

        private void metroTextBox3_Click(object sender, EventArgs e)
        {
            if (password.Text == "익명의 BGM")
            {
                password.Clear();
            }
        }
    }
}
