using System.IO;
using System.Windows.Forms;

namespace BGMSTORE.Module
{
    // 유용하게 사용할만한 함수(=메서드), 데이터들을 모아놓은 클래스
    // 메인폼의 코드를 최대한 간소화 하고자 사용한다.
    class Utility
    {
        public static string config_path = Path.Combine(Application.StartupPath, "Configuration.ini");
        public static string current_version = "0.0.4";

        //리스트뷰 아이템 찾기
        public static bool find_item(ListView lv, string text)
        {
            if (lv.Items.Count == 0)
            {
                return false;
            }

            if (lv.FindItemWithText(text, true, 0) != null)
            {
                return true;
            }
            return false;
        }

        //리스트뷰 아이템 모두 선택 / 모두 해제
        public static void check_all_data(ListView lv, bool val)
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

        //현재 title에 해당하는 폼이 열려있는지 체크 (폼 열때 중복 체크 확인용)
        public static Form is_dup_form(string form_title)
        {
            foreach (Form frm in Application.OpenForms)
                if (frm.Name == form_title)
                    return frm;

            return null;
        }
    }
}
