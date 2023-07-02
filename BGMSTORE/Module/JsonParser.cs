
using Microsoft.WindowsAPICodePack.Dialogs;

using Newtonsoft.Json.Linq;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;


namespace BGMSTORE
{
    public delegate void set_progress_bar(int progess_val);
    internal class JsonParser
    {
        public List<string> list = new List<string>(); //메인리스트의 코드를 담을 리스트 ex) /view/abcde
        public Dictionary<string, string> title_id = new Dictionary<string, string>();  //브금의 제목과 KeyVal을 담을 딕셔너리
        public List<string> favorite_list = new List<string>();  //서브리스트의 코드를 담을 리스트
        private WebClient webclient = new WebClient();

        private static string config_path = Path.Combine(Application.StartupPath, "Configuration.ini");
        InIWriter iniwriter = new InIWriter(config_path);

        int load_count = 1; //다음(Next) 불러오기 Page 카운트 변수


        // 일괄재생, 다운로드 설정
        public bool download = false;
        public bool play = false;
        public bool is_player_stop = false;
        public bool is_downloader_stop = false;


        public int count = 0;


        public event set_progress_bar SProgress;

        public JsonParser()
        {
            webclient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(WebClient_DownloadProgressChanged1);
            webclient.DownloadFileCompleted += new AsyncCompletedEventHandler(WebClient_DownloadFileCompleted);
        }
        private void WebClient_DownloadProgressChanged1(object sender, DownloadProgressChangedEventArgs e)
        {
            SProgress(e.ProgressPercentage);
        }
        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            download = false;
        }

        static public string get_json(string url)
        {
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(AcceptAllCertifications);
            string result = "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "GET";
            request.Timeout = 30 * 1000;
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36";
            request.ContentType = "application/json";
            request.Referer = "https://bgmstore.net";

            var httpResponse = request.GetResponse();
            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return result;
        }

        static public string post_json(string url, string post_data)
        {
            ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(AcceptAllCertifications);
            string result = "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "POST";
            request.Timeout = 30 * 1000;
            request.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36";
            request.ContentType = "application/json";
            request.Referer = "https://bgmstore.net";

            // POST 데이터 전송
            using (var stream_writer = new StreamWriter(request.GetRequestStream()))
            {
                stream_writer.Write(post_data);
                stream_writer.Flush();
                stream_writer.Close();
            }

            var response = request.GetResponse();
            using (var stream_reader = new StreamReader(response.GetResponseStream()))
            {
                result = stream_reader.ReadToEnd();
            }

            return result;
        }

        private static bool AcceptAllCertifications(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        public void get_bgm_data(ListView lv)
        {
            load_count = 1; //로드카운트 초기화

            //새로운 BGM
            string NEW = iniwriter.Read("BGM", "NEWEST");
            string NEWCOMPOSITION = iniwriter.Read("BGM", "NEWEST_COMPOSITION");
            string NEWVOTE = iniwriter.Read("BGM", "NEWEST_VOTED");
            string RAND = iniwriter.Read("BGM", "RANDOM");
            string WEEK = iniwriter.Read("BGM", "WEEKLY_BEST_COMPOSITION");

            title_id.Clear();

            string song_result = get_json("https://bgmstore.net/_next/data/NRby6RQn-S2B-4dIMnJZC/index.json");
            JObject jobject = JObject.Parse(song_result); //문자를 객체화
            JToken jtoken = jobject["pageProps"]["bgmDocuments"]; //result 의 값 가져오기

            lv.BeginUpdate(); //리스트뷰 업데이트 시작
            lv.Items.Clear();
            foreach (JToken jt in jtoken)
            {
                string category = jt["category"].ToString();
                string title = jt["title"].ToString();

                //107.4 (origin) -> 1:40(duration) 형태로 변환
                string origin_duration = jt["duration"].ToString();
                double seconds = double.Parse(origin_duration);
                var time_span = TimeSpan.FromSeconds(seconds);
                string duration = $"{time_span.Minutes}:{time_span.Seconds}";


                string vote_cnt = jt["upVoteCnt"].ToString();

                string[] items = { category, title, duration, vote_cnt };
                ListViewItem listViewItem = new ListViewItem(items);

                listViewItem.ForeColor = ColorTranslator.FromHtml("#4285F4");
                listViewItem.SubItems[2].ForeColor = ColorTranslator.FromHtml("#4285F4");
                listViewItem.UseItemStyleForSubItems = false;

                if (find_item(lv, items[1]) == false)
                {
                    title_id.Add(jt["title"].ToString(), jt["keyVal"].ToString());
                    lv.Items.Add(listViewItem);
                }
            }
            lv.EndUpdate(); //리스트뷰 업데이트 완료
        }
        public string get_play_list()
        {
            //새로운 BGM
            string EVER_BEST = "{\"operationName\":\"getPlaylists\",\"variables\":{\"seperator\":\"EVER_BEST\",\"cnt\":18,\"page\":0},\"query\":\"query getPlaylists($seperator: String!, $cnt: Int, $page: Int) {\n  getPlaylists(seperator: $seperator, cnt: $cnt, page: $page) {\n    _id\n    title\n    content\n    documents {\n      _id\n      documentNum\n      keyVal\n      user {\n        _id\n        member_num\n        nickname\n        __typename\n      }\n      title\n      content\n      tags\n      filename\n      category\n      voteCnt\n      votedIp\n      commentCnt\n      downloadCnt\n      isValid\n      fileHashMp3\n      fileHashMp4\n      hasAlbumart\n      isComposition\n      copyrightInfo {\n        ownComposition\n        ownLicense\n        isPublicLicense\n        __typename\n      }\n      duration\n      bgmSource\n      ipAddr\n      updatedAt\n      createdAt\n      __typename\n    }\n    user {\n      _id\n      email\n      nickname\n      profileImagePath\n      profileIconPath\n      signature\n      point\n      level\n      isValid\n      ipAddr\n      followsCnt\n      followersCnt\n      token\n      updatedAt\n      createdAt\n      __typename\n    }\n    voteCnt\n    commentCnt\n    isPublic\n    updatedAt\n    createdAt\n    __typename\n  }\n}\n\"}";
            string Result = "";

            string json_bgm = get_json("https://bgmstore.net/v1");
            JObject jobject = JObject.Parse(json_bgm); //문자를 객체화
            JToken jtoken = jobject["data"]["getPlaylists"];

            return json_bgm; //JSON 자체를 넘긴다.
        }
        public bool find_item(ListView lv, string text)
        {
            if (lv.Items.Count == 0)
            {
                return false;

            }
            else
            {
                if (lv.FindItemWithText(text, true, 0) != null)
                {
                    return true;
                }

                return false;
            }
        }

        public void find_bgm(ListView lv, string keyword, string mode)
        {
            load_count = 1; //로드카운트 초기화

            try
            {

                lv.BeginUpdate();
                lv.Items.Clear();

                string[] mode_array = mode.Split('|');

                string str1 = "";
                string str2 = "";

                if (mode_array[0] == "제목")
                    str1 = "title";
                else if (mode_array[0] == "주소")
                    str1 = "url";
                else if (mode_array[0] == "닉네임")
                    str1 = "nickname";
                if (mode_array[1] == "일반검색")
                    str2 = "general";
                else if (mode_array[1] == "단어로 검색")
                    str2 = "word";
                else if (mode_array[1] == "완전일치")
                    str2 = "strict";


                title_id.Clear(); //검색시 리스트 초기화

                string encoded_keyword = HttpUtility.UrlEncode(keyword);

                string post_data = @"
                    {""operationName"": ""bgmDocuments"",
                        ""variables"": {
                            ""separator"": ""SEARCH"",
                            ""limit"": 20,
                            ""searchQuery"": ""SEARCHQUERY"",
                            ""searchQueryType"": ""total"",
                            ""page"": 0
                        },
                        ""query"": ""query bgmDocuments($separator: String!, $category: String, $limit: Int!, $page: Int!, $searchQuery: String, $searchQueryType: String, $userId: String, $isComposition: Boolean, $sortBy: String, $sortOrder: Int) {\n  bgmDocuments(\n    separator: $separator\n    category: $category\n    limit: $limit\n    page: $page\n    searchQuery: $searchQuery\n    searchQueryType: $searchQueryType\n    userId: $userId\n    isComposition: $isComposition\n    sortBy: $sortBy\n    sortOrder: $sortOrder\n  ) {\n    _id\n    keyVal\n    user {\n      _id\n      email\n      nickname\n      signature\n      point\n      profileImageUrl\n      profileIconUrl\n      __typename\n    }\n    title\n    content\n    filename\n    category\n    upVoteCnt\n    commentCnt\n    isProcessing\n    queueJobProgress\n    albumartImageUrl\n    isComposition\n    ccl\n    duration\n    __typename\n  }\n}""
                    }".Replace("SEARCHQUERY", keyword);

                Console.WriteLine(post_data);

                string json_bgm = post_json("https://api.bgmstore.net/graphql", post_data);
                Console.WriteLine(json_bgm);

                JObject jobject = JObject.Parse(json_bgm); //문자를 객체화
                JToken jtoken = jobject["data"]["bgmDocuments"]; //result 의 값 가져오기


                foreach (JToken jt in jtoken)
                {
                    string category = jt["category"].ToString();
                    string title = jt["title"].ToString();

                    //107.4 (origin) -> 1:40(duration) 형태로 변환
                    string origin_duration = jt["duration"].ToString();
                    double seconds = double.Parse(origin_duration);
                    var time_span = TimeSpan.FromSeconds(seconds);
                    string duration = $"{time_span.Minutes}:{time_span.Seconds}";


                    string vote_cnt = jt["upVoteCnt"].ToString();

                    string[] items = { category, title, duration, vote_cnt };
                    ListViewItem listViewItem = new ListViewItem(items);

                    listViewItem.ForeColor = ColorTranslator.FromHtml("#4285F4");
                    listViewItem.SubItems[2].ForeColor = ColorTranslator.FromHtml("#4285F4");
                    listViewItem.UseItemStyleForSubItems = false;

                    if (find_item(lv, items[1]) == false)
                    {
                        title_id.Add(jt["title"].ToString(), jt["keyVal"].ToString());
                        lv.Items.Add(listViewItem);
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("오류가 발생하였습니다" + Environment.NewLine + ex.ToString(), "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                lv.EndUpdate();
            }
        }
        public void more_load(string Mode, ListView lv, string sw)
        {
            try
            {


                lv.BeginUpdate();

                /*
                string[] strArray = Mode.Split('|');

                string str1 = "";
                string str2 = "";
                if (strArray[0] == "제목")
                    str1 = "title";
                else if (strArray[0] == "주소")
                    str1 = "url";
                else if (strArray[0] == "닉네임")
                    str1 = "nickname";
                if (strArray[1] == "일반검색")
                    str2 = "general";
                else if (strArray[1] == "단어로 검색")
                    str2 = "word";
                else if (strArray[1] == "완전일치")
                    str2 = "strict";
                    */

                string json_search = "{\"operationName\":\"getDocuments\",\"variables\":{\"seperator\":\"SEARCH\",\"cnt\":30,\"searchQuery\":\"" + sw + "\",\"searchQueryType\":\"general\",\"page\":" + load_count + "},\"query\":\"query getDocuments($seperator: String!, $cnt: Int, $searchQuery: String, $searchQueryType: String, $page: Int, $userId: String, $_id: String, $documents: String) {\n  getDocuments(seperator: $seperator, cnt: $cnt, searchQuery: $searchQuery, searchQueryType: $searchQueryType, page: $page, userId: $userId, _id: $_id, documents: $documents) {\n    _id\n    documentNum\n    keyVal\n    user {\n      _id\n      member_num\n      nickname\n      __typename\n    }\n    title\n    content\n    tags\n    filename\n    category\n    voteCnt\n    votedIp\n    commentCnt\n    downloadCnt\n    isValid\n    fileHashMp3\n    fileHashMp4\n    hasAlbumart\n    isComposition\n    copyrightInfo {\n      ownComposition\n      ownLicense\n      isPublicLicense\n      __typename\n    }\n    duration\n    bgmSource\n    ipAddr\n    updatedAt\n    createdAt\n    __typename\n  }\n}\n\"}";
                string jsonbgm = get_json("https://bgmstore.net/v1");
                JObject jObject = JObject.Parse(jsonbgm); //문자를 객체화
                JToken jToken = jObject["data"]["getDocuments"]; //result 의 값 가져오기

                int i = 0;

                foreach (JToken jt in jToken)
                {
                    string[] items = new string[4];
                    items[0] = jt["category"].ToString();
                    items[1] = jt["title"].ToString();
                    items[2] = jt["duration"].ToString();
                    items[3] = jt["voteCnt"].ToString().Replace("+", "");



                    ListViewItem listViewItem = new ListViewItem(items);

                    listViewItem.ForeColor = ColorTranslator.FromHtml("#4285F4");
                    listViewItem.SubItems[2].ForeColor = ColorTranslator.FromHtml("#4285F4");
                    listViewItem.UseItemStyleForSubItems = false;

                    if (find_item(lv, items[1]) == false)
                    {

                        title_id.Add(jt["title"].ToString(), jt["keyVal"].ToString());
                        lv.Items.Add(listViewItem);


                    }

                    i++;

                }
                lv.Refresh();
                load_count++;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            finally
            {
                lv.EndUpdate();
            }
        }
        public async void download_bgm_async(int[] url, string[] title, Label lb)
        {
            count = 0;

            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true
            };

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                string selected = dialog.FileName;
                try
                {
                    int[] num_array = url; //C#에서도 얕은 복사?
                    for (int index = 0; index < num_array.Length; ++index)
                    {
                        int i = num_array[count];
                        lb.Text = count.ToString() + "/" + url.Length.ToString();
                        download = true;

                        string download_url = "https://media1.bgmstore.net/mp3/" + title_id[title[index]] + ".mp3";

                        string download_mode = ".mp3"; //default(ini 파일이 없는 오류방지)

                        InIWriter iniwriter = new InIWriter(Application.StartupPath + "\\Configuration.ini");

                        if (iniwriter.Read("설정", "다운로드") == "Mp3")
                        {
                            download_mode = ".mp3";
                        }
                        else //Mp4면
                        {
                            download_mode = ".mp4";
                        }

                        webclient.DownloadFileAsync(new Uri(download_url), selected + "\\" + title[count] + download_mode);
                        download = true;
                        while (download)
                        {
                            await Task.Delay(1000);
                        }
                        count++;
                        if (url.Length == count)
                        {
                            lb.Text = count.ToString() + "/" + url.Length.ToString();
                            int num2 = (int)MessageBox.Show("다운로드가 완료되었습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "알림", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
            else
            {
                MessageBox.Show("취소되었습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void download_cancle()
        {
            webclient.Dispose();
            download = false;
            SProgress(0);
            is_downloader_stop = true;
        }


        public void check_all(ListView lv, bool val)
        {
            if (val)
            {
                for (int index = 0; index <= lv.Items.Count - 1; ++index)
                {
                    if (!lv.Items[index].Checked)
                        lv.Items[index].Checked = true;
                }
            }
            else
            {
                for (int index = 0; index <= lv.Items.Count - 1; ++index)
                {
                    if (lv.Items[index].Checked)
                        lv.Items[index].Checked = false;
                }
            }
        }
        public async void play_bgm_async(AxWMPLib.AxWindowsMediaPlayer wmp)

        {
            int count = 0;

            foreach (string i in favorite_list)
            {
                InIWriter inIWriter = new InIWriter(Application.StartupPath + "\\Configuration.ini");

                string download_mode = "/mp3/Untitled1";
                if (inIWriter.Read("설정", "미리듣기") == "Mp3")
                {
                    download_mode = "/mp3/Untitled1";
                }
                else //Mp4면
                {
                    download_mode = "/mp4/Untitled1";
                }


                string url = "http://dl.bgms.kr/download/" + i.Replace("/view/", "") + download_mode;
                wmp.URL = url;
                play = true;


                while (play) // Play = true
                {
                    if (is_player_stop == true)
                    {
                        break;
                    }
                    else
                    {
                        await Task.Delay(1000);
                    }


                }


                if (is_player_stop == true)
                {
                    wmp.Ctlcontrols.stop();
                    play = false;
                    is_player_stop = false;
                    break;
                }

                count++;

                if (favorite_list.Count == count)
                {
                    MessageBox.Show("재생이 끝났습니다");
                    play = false;

                }
            }

        }
        public void stop_bgm()
        {
            is_player_stop = true; //일괄재생 종료
        }
    }
}
