using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
