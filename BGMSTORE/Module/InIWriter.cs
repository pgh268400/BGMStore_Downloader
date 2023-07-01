using System.Runtime.InteropServices;
using System.Text;

namespace BGMSTORE
{


    class InIWriter
    {

        private string _Path = "";

        [DllImport("kernel32")]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        [DllImport("kernel32")]
        private static extern int GetPrivateProfileString(string section, string key, string def, System.Text.StringBuilder retVal,
                                                        int size, string filePath);
        //INI 저장을 위한 Dll 불러오기

        public InIWriter(string path)
        {
            _Path = path;
        }

        public void Write(string section, string key, string val)
        {
            WritePrivateProfileString(section, key, val, _Path);
            /*Example
             * 
             * [secion]
             * key = val
             * 
             * 
             */
        }

        public string Read(string section, string key)
        {
            StringBuilder stringBuilder = new StringBuilder();
            GetPrivateProfileString(section, key, "(NONE)", stringBuilder, 32, _Path);

            return stringBuilder.ToString();
        }

    }
}
