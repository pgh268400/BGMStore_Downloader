using System;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace BGMSTORE
{
    class FTP
    {
        public string download()
        {
            string ftpPath = "FTP";
            string user = "USER";  // FTP 익명 로그인시. 아니면 로그인/암호 지정.
            string pwd = "PW";

            // WebRequest.Create로 Http,Ftp,File Request 객체를 모두 생성할 수 있다.
            FtpWebRequest req = (FtpWebRequest)WebRequest.Create(ftpPath);
            // FTP 다운로드한다는 것을 표시
            req.Method = WebRequestMethods.Ftp.DownloadFile;
            // 익명 로그인이 아닌 경우 로그인/암호를 제공해야
            req.Credentials = new NetworkCredential(user, pwd);

            // FTP Request 결과를 가져온다.
            using (FtpWebResponse resp = (FtpWebResponse)req.GetResponse())
            {
                // FTP 결과 스트림
                Stream stream = resp.GetResponseStream();

                // 결과를 문자열로 읽기 (바이너리로 읽을 수도 있다)
                string data;
                using (StreamReader reader = new StreamReader(stream))
                {
                    data = reader.ReadToEnd();
                    return data;
                }
            }
        }

        public void upload(string file_name, string text)
        {
            // 코드 단순화를 위해 하드코드함
            string ftpPath = "FTP" + file_name;
            string user = "USER";  // FTP 익명 로그인시. 아니면 로그인/암호 지정.
            string pwd = "PW";
            //string inputFile = directory;

            // WebRequest.Create로 Http,Ftp,File Request 객체를 모두 생성할 수 있다.
            FtpWebRequest req = (FtpWebRequest)WebRequest.Create(ftpPath);
            // FTP 업로드한다는 것을 표시
            req.Method = WebRequestMethods.Ftp.UploadFile;
            // 쓰기 권한이 있는 FTP 사용자 로그인 지정
            req.Credentials = new NetworkCredential(user, pwd);

            // 입력파일을 바이트 배열로 읽음
            byte[] data = Encoding.UTF8.GetBytes(text);
            // using (StreamReader reader = new StreamReader(inputFile))
            // {
            //     data = Encoding.UTF8.GetBytes(reader.ReadToEnd());
            // }

            // RequestStream에 데이타를 쓴다
            req.ContentLength = data.Length;

            using (Stream reqStream = req.GetRequestStream())
            {


                reqStream.Write(data, 0, data.Length);
            }

            // FTP Upload 실행
            using (FtpWebResponse resp = (FtpWebResponse)req.GetResponse())
            {
                // FTP 결과 상태 출력
                Console.WriteLine("Upload: {0}", resp.StatusDescription);

                MessageBox.Show("업로드 완료되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
