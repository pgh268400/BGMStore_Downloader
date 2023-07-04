using System;

namespace BGMSTORE
{
    public partial class About : MetroFramework.Forms.MetroForm
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)

        {
            System.Diagnostics.Process.Start("https://pgh268400.tistory.com/");

        }

        private void label6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://bgmstore.net");
        }
    }
}
