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
    public partial class OptionPage : MetroFramework.Forms.MetroForm
    {
        

        public OptionPage()
        {
            InitializeComponent();
        }


        private void OptionPage_Load(object sender, EventArgs e)
        {
            InIWriter inIWriter = new InIWriter(Application.StartupPath + "\\Configuration.ini");

            string NEW = inIWriter.Read("BGM", "NEWEST");
            string NEWCOMPOSITION = inIWriter.Read("BGM", "NEWEST_COMPOSITION");
            string NEWVOTE = inIWriter.Read("BGM", "NEWEST_VOTED");
            string RAND = inIWriter.Read("BGM", "RANDOM");
            string WEEK = inIWriter.Read("BGM", "WEEKLY_BEST_COMPOSITION");

            NEWEST.Text = NEW;
            NEWEST_COMPOSITION.Text = NEWCOMPOSITION;
            NEWEST_VOTED.Text = NEWVOTE;
            RANDOM.Text = RAND;
            WEEKLY_BEST_COMPOSITION.Text = WEEK;



           if (inIWriter.Read("설정", "다운로드") == "Mp3")
            {
                dbl_downloadmp3.Checked = true;
            } else //Mp4면
            {
                dbl_downloadmp4.Checked = true;
            }

            if (inIWriter.Read("설정", "더블클릭") == "music")
            {
                dbl_Preview.Checked = true;
            }
            else //사이트 이동이면(site)
            {
                dbl_Site.Checked = true;
            }

            if (inIWriter.Read("설정", "미리듣기") == "Mp3")
            {
                dbl_pmp3.Checked = true;
            }
            else //Mp4면
            {
                dbl_pmp4.Checked = true;
            }



        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            InIWriter inIWriter = new InIWriter(Application.StartupPath + "\\Configuration.ini");

            if (dbl_downloadmp3.Checked == true)
            {
                inIWriter.Write("설정", "다운로드", "Mp3");
            } else if(dbl_downloadmp4.Checked == true)
            {
                inIWriter.Write("설정", "다운로드", "Mp4");
            }

            if(dbl_Preview.Checked == true)
            {
                inIWriter.Write("설정", "더블클릭", "music");

            } else if(dbl_Site.Checked == true)
            {
                inIWriter.Write("설정", "더블클릭", "site");
            }

            if(dbl_pmp3.Checked == true)
            {
                inIWriter.Write("설정", "미리듣기", "Mp3");
            } else if(dbl_pmp4.Checked == true)
            {
                inIWriter.Write("설정", "미리듣기", "Mp4");
            }

            inIWriter.Write("BGM", "NEWEST", NEWEST.Text);
            inIWriter.Write("BGM", "NEWEST_COMPOSITION", NEWEST_COMPOSITION.Text);
            inIWriter.Write("BGM", "NEWEST_VOTED", NEWEST_VOTED.Text);
            inIWriter.Write("BGM", "RANDOM", RANDOM.Text);
            inIWriter.Write("BGM", "WEEKLY_BEST_COMPOSITION", WEEKLY_BEST_COMPOSITION.Text);

           



            MessageBox.Show("저장이 완료되었습니다", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void metroPanel3_Paint(object sender, PaintEventArgs e)
        {

        }


        private void dbl_Preview_CheckedChanged(object sender, EventArgs e)
        {
            if (dbl_Preview.Checked == true)
            {
                pn_prev.Enabled = true;
            } else
            {
                pn_prev.Enabled = false;
            }
        }

        private void metroTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox6_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox7_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox8_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox9_Click(object sender, EventArgs e)
        {

        }
    }
}
