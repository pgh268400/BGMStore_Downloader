using System.Reflection;
using System.Windows.Forms;

namespace BGMSTORE.Module
{
    public static class Extensions // 리스트뷰 깜박임 제거
    {
        public static void DoubleBuffered(this Control control, bool enabled)
        {
            var prop = control.GetType().GetProperty(
                "DoubleBuffered", BindingFlags.Instance | BindingFlags.NonPublic);

            prop.SetValue(control, enabled, null);
        }
    }

}
