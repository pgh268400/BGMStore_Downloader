
using BGMSTORE.Module;
using Microsoft.WindowsAPICodePack.Dialogs;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BGMSTORE
{
    public delegate void set_progress_bar(int progess_val);

    public enum Mode
    {
        Main,
        Search
    }

    //Json 파싱 후 반환할 데이터 타입
    public class BGMDocuments
    {
        // 프로퍼티 활용하여 Getter/Setter 구현하지 않아도
        // 자동으로 쉽게 동일한 기능 구현 가능
        public string category { get; }
        public string title { get; }
        public string duration { get; }
        public string vote_cnt { get; }
        public string keyVal { get; }

        public BGMDocuments(string category, string title, string duration, string vote_cnt, string keyVal)
        {
            this.category = category;
            this.title = title;
            this.duration = duration;
            this.vote_cnt = vote_cnt;
            this.keyVal = keyVal;
        }
    }

    public class BGMManager
    {
        public Dictionary<string, string> title_id = new Dictionary<string, string>(); //브금의 제목과 KeyVal을 담을 딕셔너리
        public List<string> favorite_list = new List<string>(); //서브리스트의 코드를 담을 리스트
        private WebClient web_client = new WebClient();


        // 일괄재생, 다운로드 설정
        public bool is_download = false; //다운로드가 진행중인지
        public bool is_play = false;
        public bool is_player_stop = false;
        public bool is_downloader_stop = false;

        // 현재 검색중인지, 메인 화면에 있는 상태인지 체크하는 프로퍼티 
        // (private 변수로 관리하고 setter, getter 을 만들어서 캡슐화로 관리할 수 있으나 이렇게 프로퍼티로 만들면 한줄만에 끝낼 수 있다.)
        //public bool is_main_window { get; set; } = false;


        public int count = 0;
        public event set_progress_bar sprogress;

        //Constructor
        public BGMManager()
        {
            web_client.DownloadProgressChanged += WebClient_DownloadProgressChanged1;
            web_client.DownloadFileCompleted += WebClient_DownloadFileCompleted;
        }

        private void WebClient_DownloadProgressChanged1(object sender, DownloadProgressChangedEventArgs e)
        {
            sprogress(e.ProgressPercentage);
        }

        private void WebClient_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            is_download = false;
        }

        public static string get_json(string url)
        {
            ServicePointManager.ServerCertificateValidationCallback = AcceptAllCertifications;
            string result = "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "GET";
            request.Timeout = 30 * 1000;
            request.UserAgent =
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36";
            request.ContentType = "application/json";
            request.Referer = "https://bgmstore.net";

            var http_response = request.GetResponse();
            using (var streamReader = new StreamReader(http_response.GetResponseStream()))
            {
                result = streamReader.ReadToEnd();
            }

            return result;
        }

        public static string post_json(string url, string post_data)
        {
            ServicePointManager.ServerCertificateValidationCallback = AcceptAllCertifications;
            string result = "";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);

            request.Method = "POST";
            request.Timeout = 30 * 1000;
            request.UserAgent =
                "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36";
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

        public static async Task<string> get_json_async(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                // 헤더 추가
                client.DefaultRequestHeaders.Add("User-Agent",
                    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36");
                client.DefaultRequestHeaders
                    .Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header

                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();

                string result = await response.Content.ReadAsStringAsync();
                return result;
            }
        }

        public static async Task<string> post_json_async(string url, string post_data)
        {
            using (HttpClient client = new HttpClient())
            {
                // 헤더 추가
                client.DefaultRequestHeaders.Add("User-Agent",
                    "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/71.0.3578.98 Safari/537.36");
                client.DefaultRequestHeaders
                    .Accept
                    .Add(new MediaTypeWithQualityHeaderValue("application/json"));//ACCEPT header

                StringContent content = new StringContent(post_data, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, content);
                response.EnsureSuccessStatusCode();

                string result = await response.Content.ReadAsStringAsync();
                return result;
            }
        }

        private static bool AcceptAllCertifications(object sender, X509Certificate certificate, X509Chain chain,
            SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        //async void = 실행하고 잊어버리는거
        //async task = 결과를 추적할 수 있고, await 로 기다릴 수 있는거
        public async Task get_main_data_async(ListView lv)
        {
            //새로운 BGM
            /*
            string NEW = iniwriter.Read("BGM", "NEWEST");
            string NEWCOMPOSITION = iniwriter.Read("BGM", "NEWEST_COMPOSITION");
            string NEWVOTE = iniwriter.Read("BGM", "NEWEST_VOTED");
            string RAND = iniwriter.Read("BGM", "RANDOM");
            string WEEK = iniwriter.Read("BGM", "WEEKLY_BEST_COMPOSITION");
            */

            title_id.Clear();
            lv.Items.Clear();

            //string json_data = get_json("https://bgmstore.net/_next/data/NRby6RQn-S2B-4dIMnJZC/index.json");

            string json_data = await get_json_async("https://bgmstore.net/_next/data/NRby6RQn-S2B-4dIMnJZC/index.json");

            var bgm_data = bgm_parse_from_json(json_data, Mode.Main);
            //받아온 데이터 리스트뷰에 삽입
            add_bgm_data_to_listview(bgm_data, lv);

        }



        public string get_play_list()
        {
            //새로운 BGM
            string EVER_BEST =
                "{\"operationName\":\"getPlaylists\",\"variables\":{\"seperator\":\"EVER_BEST\",\"cnt\":18,\"page\":0},\"query\":\"query getPlaylists($seperator: String!, $cnt: Int, $page: Int) {\n  getPlaylists(seperator: $seperator, cnt: $cnt, page: $page) {\n    _id\n    title\n    content\n    documents {\n      _id\n      documentNum\n      keyVal\n      user {\n        _id\n        member_num\n        nickname\n        __typename\n      }\n      title\n      content\n      tags\n      filename\n      category\n      voteCnt\n      votedIp\n      commentCnt\n      downloadCnt\n      isValid\n      fileHashMp3\n      fileHashMp4\n      hasAlbumart\n      isComposition\n      copyrightInfo {\n        ownComposition\n        ownLicense\n        isPublicLicense\n        __typename\n      }\n      duration\n      bgmSource\n      ipAddr\n      updatedAt\n      createdAt\n      __typename\n    }\n    user {\n      _id\n      email\n      nickname\n      profileImagePath\n      profileIconPath\n      signature\n      point\n      level\n      isValid\n      ipAddr\n      followsCnt\n      followersCnt\n      token\n      updatedAt\n      createdAt\n      __typename\n    }\n    voteCnt\n    commentCnt\n    isPublic\n    updatedAt\n    createdAt\n    __typename\n  }\n}\n\"}";
            string Result = "";

            string json_bgm = get_json("https://bgmstore.net/v1");
            JObject jobject = JObject.Parse(json_bgm); //문자를 객체화
            JToken jtoken = jobject["data"]["getPlaylists"];

            return json_bgm; //JSON 자체를 넘긴다.
        }




        //브금 저장소 API 요청시 응답으로 들어오는 json_data를 인자로 받아서 파싱 후 잘 포장해 반환
        private List<BGMDocuments> bgm_parse_from_json(string json_data, Mode mode)
        {
            JObject jobject = JObject.Parse(json_data); //문자를 객체화

            JToken jtoken = null;
            if (mode == Mode.Main)
                jtoken = jobject["pageProps"]["bgmDocuments"]; //브금 메인 데이터 가져오기
            else
                jtoken = jobject["data"]["bgmDocuments"];


            var result = new List<BGMDocuments>();
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
                string keyVal = jt["keyVal"].ToString();

                //string[] items = { category, title, duration, vote_cnt };
                result.Add(new BGMDocuments(category, title, duration, vote_cnt, keyVal));
            }

            return result;
        }

        public async Task<BGMDocuments> get_random_bgm_async()
        {
            PostData post_data = new PostData
            {
                operationName = "bgmDocuments",
                variables = new Variables
                {
                    separator = "RANDOM",
                    limit = 1, //API 활용하여 1개 랜덤으로 뽑아옴
                    page = 0,
                    isComposition = false
                }
            };

            // JSON으로 직렬화하여 저장, NullValue 는 null로 전송하는게 아니라 그냥 무시함.
            // 없는 데이터들은 같이 전송하지 않겠다는 뜻.
            string json_post_data = JsonConvert.SerializeObject(post_data, new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore
            });

            string json_data = await post_json_async("https://api.bgmstore.net/graphql", json_post_data);
            List<BGMDocuments> bgm_data = bgm_parse_from_json(json_data, Mode.Search);
            BGMDocuments bgm_item = bgm_data[0];
            return bgm_item;
        }

        public async Task search_bgm_async(ListView lv, string keyword, string mode)
        {
            try
            {
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

                current_page = 0;
                /*
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
                */

                PostData post_data = new PostData
                {
                    operationName = "bgmDocuments",
                    variables = new Variables
                    {
                        separator = "SEARCH",
                        limit = 20,
                        searchQuery = keyword,
                        searchQueryType = "total",
                        page = 0
                    }
                };

                // JSON으로 직렬화하여 저장, NullValue 는 null로 전송하는게 아니라 그냥 무시함.
                // 없는 데이터들은 같이 전송하지 않겠다는 뜻.
                string json_post_data = JsonConvert.SerializeObject(post_data, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });


                string json_data = await post_json_async("https://api.bgmstore.net/graphql", json_post_data);
                var bgm_data = bgm_parse_from_json(json_data, Mode.Search);
                //받아온 데이터 리스트뷰에 삽입
                add_bgm_data_to_listview(bgm_data, lv);
            }

            catch (Exception ex)
            {
                MessageBox.Show("오류가 발생하였습니다" + Environment.NewLine + ex.ToString(), "알림", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        //BGM 데이터를 ListView에 반복하면서 삽입해주는 함수
        //참고로 Class 는 설계 자체가 참조형이라 원본에 접근할 수 있다.
        //리스트뷰를 인자로 받아서 데이터를 원본에 직접 삽입할 수 있는것도 그 이유인듯. [ListView도 Class로 설계되어 있음]
        //List 타입도 마찬가지고. Class 자체가 객체 변수 복사시 포인터 변수를 복사해서
        //(객체를 같이 가리키고 있는) 얕은 복사가 이루어진다고 보면 된다.
        private void add_bgm_data_to_listview(List<BGMDocuments> bgm_data, ListView lv, bool is_begin_update = true)
        {
            if (is_begin_update)
                lv.BeginUpdate();

            foreach (var bgm in bgm_data)
            {
                string[] items = { bgm.category, bgm.title, bgm.duration, bgm.vote_cnt };
                ListViewItem listview_item = new ListViewItem(items)
                {
                    ForeColor = ColorTranslator.FromHtml("#4285F4")
                };

                listview_item.SubItems[2].ForeColor = ColorTranslator.FromHtml("#4285F4");
                listview_item.UseItemStyleForSubItems = false;

                if (Utility.find_item(lv, items[1]) == false)
                {
                    title_id.Add(bgm.title, bgm.keyVal);
                    lv.Items.Add(listview_item);
                }
            }

            if (is_begin_update)
                lv.EndUpdate();
        }


        //현재 검색 페이지를 기억하고 있는 멤버 변수
        private int current_page = 0;

        public async Task more_load_async(Mode mode, ListView lv, string keyword)
        {
            current_page += 1;
            if (mode == Mode.Search)
            {
                //MessageBox.Show("검색 더보기");
                Console.WriteLine("검색 더보기");
                try
                {
                    /*
                    string post_data = @"
                    {""operationName"": ""bgmDocuments"",
                        ""variables"": {
                            ""separator"": ""SEARCH"",
                            ""limit"": 20,
                            ""searchQuery"": ""SEARCHQUERY"",
                            ""searchQueryType"": ""total"",
                            ""page"": PAGE
                        },
                        ""query"": ""query bgmDocuments($separator: String!, $category: String, $limit: Int!, $page: Int!, $searchQuery: String, $searchQueryType: String, $userId: String, $isComposition: Boolean, $sortBy: String, $sortOrder: Int) {\n  bgmDocuments(\n    separator: $separator\n    category: $category\n    limit: $limit\n    page: $page\n    searchQuery: $searchQuery\n    searchQueryType: $searchQueryType\n    userId: $userId\n    isComposition: $isComposition\n    sortBy: $sortBy\n    sortOrder: $sortOrder\n  ) {\n    _id\n    keyVal\n    user {\n      _id\n      email\n      nickname\n      signature\n      point\n      profileImageUrl\n      profileIconUrl\n      __typename\n    }\n    title\n    content\n    filename\n    category\n    upVoteCnt\n    commentCnt\n    isProcessing\n    queueJobProgress\n    albumartImageUrl\n    isComposition\n    ccl\n    duration\n    __typename\n  }\n}""
                    }".Replace("SEARCHQUERY", keyword).Replace("PAGE", current_page.ToString());
                    */

                    PostData post_data = new PostData
                    {
                        operationName = "bgmDocuments",
                        variables = new Variables
                        {
                            separator = "SEARCH",
                            limit = 20,
                            searchQuery = keyword,
                            searchQueryType = "total",
                            page = current_page,
                        }
                    };

                    // JSON으로 직렬화하여 저장, NullValue 는 null로 전송하는게 아니라 그냥 무시함.
                    // 없는 데이터들은 같이 전송하지 않겠다는 뜻.
                    string json_post_data = JsonConvert.SerializeObject(post_data, new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                    string json_data = await post_json_async("https://api.bgmstore.net/graphql", json_post_data);
                    var bgm_data = bgm_parse_from_json(json_data, Mode.Search);
                    if (bgm_data.Count == 0)
                    {
                        MessageBox.Show("더 이상 불러올 수 없습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    //받아온 데이터 리스트뷰에 삽입
                    add_bgm_data_to_listview(bgm_data, lv);

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString(), "알림", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
            else if (mode == Mode.Main)
            {
                Console.WriteLine("메인 더보기");

                //API 활용하여 20개 랜덤으로 뽑아옴
                PostData post_data = new PostData
                {
                    operationName = "bgmDocuments",
                    variables = new Variables
                    {
                        separator = "RANDOM",
                        limit = 20,
                        page = 0,
                        isComposition = false
                    }
                };
                string json_post_data = JsonConvert.SerializeObject(post_data, new JsonSerializerSettings
                {
                    NullValueHandling = NullValueHandling.Ignore
                });

                string json_data = await post_json_async("https://api.bgmstore.net/graphql", json_post_data);
                var bgm_data = bgm_parse_from_json(json_data, Mode.Search);

                //받아온 데이터 리스트뷰에 삽입
                add_bgm_data_to_listview(bgm_data, lv);

            }
        }

        public async void download_bgm_async(int[] url, string[] title, Label lb)
        {
            count = 0;

            CommonOpenFileDialog dialog = new CommonOpenFileDialog
            {
                IsFolderPicker = true
            };

            if (dialog.ShowDialog() != CommonFileDialogResult.Ok)
            {
                MessageBox.Show("취소되었습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }


            string selected_file = dialog.FileName;

            try
            {
                for (int index = 0; index < url.Length; ++index)
                {
                    lb.Text = count.ToString() + "/" + url.Length.ToString();
                    is_download = true;

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

                    web_client.DownloadFileAsync(new Uri(download_url), selected_file + "\\" + title[count] + download_mode);
                    is_download = true;
                    while (is_download)
                    {
                        await Task.Delay(1000);
                    }

                    count++;
                    if (url.Length == count)
                    {
                        lb.Text = count.ToString() + "/" + url.Length.ToString();
                        MessageBox.Show("다운로드가 완료되었습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "알림", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
        }
    }
}
