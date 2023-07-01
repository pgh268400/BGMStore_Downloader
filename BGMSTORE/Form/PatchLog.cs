using System;

namespace BGMSTORE
{
    public partial class PatchLog : MetroFramework.Forms.MetroForm

    {
        public PatchLog()
        {
            InitializeComponent();
        }

        private void PatchLog_Load(object sender, EventArgs e)
        {
            this.TopMost = true;
            //최상단설정
        }
    }
}
