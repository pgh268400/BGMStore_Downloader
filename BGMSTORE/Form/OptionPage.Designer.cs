namespace BGMSTORE
{
    partial class OptionPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.pn_dbl = new MetroFramework.Controls.MetroPanel();
            this.dbl_Preview = new MetroFramework.Controls.MetroRadioButton();
            this.dbl_Site = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.pn_download = new MetroFramework.Controls.MetroPanel();
            this.dbl_downloadmp4 = new MetroFramework.Controls.MetroRadioButton();
            this.dbl_downloadmp3 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.pn_randombgm = new MetroFramework.Controls.MetroPanel();
            this.metroTextBox4 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox3 = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox2 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pn_prev = new MetroFramework.Controls.MetroPanel();
            this.dbl_pmp3 = new MetroFramework.Controls.MetroRadioButton();
            this.dbl_pmp4 = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.WEEKLY_BEST_COMPOSITION = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.RANDOM = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.NEWEST_VOTED = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.NEWEST_COMPOSITION = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.NEWEST = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.pn_dbl.SuspendLayout();
            this.pn_download.SuspendLayout();
            this.pn_randombgm.SuspendLayout();
            this.pn_prev.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(29, 300);
            this.metroTile1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(287, 42);
            this.metroTile1.TabIndex = 11;
            this.metroTile1.Text = "저장";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // pn_dbl
            // 
            this.pn_dbl.Controls.Add(this.dbl_Preview);
            this.pn_dbl.Controls.Add(this.dbl_Site);
            this.pn_dbl.Controls.Add(this.metroLabel2);
            this.pn_dbl.HorizontalScrollbarBarColor = true;
            this.pn_dbl.HorizontalScrollbarHighlightOnWheel = false;
            this.pn_dbl.HorizontalScrollbarSize = 8;
            this.pn_dbl.Location = new System.Drawing.Point(29, 59);
            this.pn_dbl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_dbl.Name = "pn_dbl";
            this.pn_dbl.Size = new System.Drawing.Size(287, 48);
            this.pn_dbl.TabIndex = 10;
            this.pn_dbl.VerticalScrollbarBarColor = true;
            this.pn_dbl.VerticalScrollbarHighlightOnWheel = false;
            this.pn_dbl.VerticalScrollbarSize = 9;
            // 
            // dbl_Preview
            // 
            this.dbl_Preview.AutoSize = true;
            this.dbl_Preview.Checked = true;
            this.dbl_Preview.Location = new System.Drawing.Point(151, 27);
            this.dbl_Preview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dbl_Preview.Name = "dbl_Preview";
            this.dbl_Preview.Size = new System.Drawing.Size(98, 15);
            this.dbl_Preview.TabIndex = 1;
            this.dbl_Preview.TabStop = true;
            this.dbl_Preview.Text = "음악 미리듣기";
            this.dbl_Preview.UseSelectable = true;
            this.dbl_Preview.CheckedChanged += new System.EventHandler(this.dbl_Preview_CheckedChanged);
            // 
            // dbl_Site
            // 
            this.dbl_Site.AutoSize = true;
            this.dbl_Site.Location = new System.Drawing.Point(20, 27);
            this.dbl_Site.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dbl_Site.Name = "dbl_Site";
            this.dbl_Site.Size = new System.Drawing.Size(98, 15);
            this.dbl_Site.TabIndex = 0;
            this.dbl_Site.Text = "사이트로 이동";
            this.dbl_Site.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(10, 9);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "더블클릭";
            // 
            // pn_download
            // 
            this.pn_download.Controls.Add(this.dbl_downloadmp4);
            this.pn_download.Controls.Add(this.dbl_downloadmp3);
            this.pn_download.Controls.Add(this.metroLabel1);
            this.pn_download.HorizontalScrollbarBarColor = true;
            this.pn_download.HorizontalScrollbarHighlightOnWheel = false;
            this.pn_download.HorizontalScrollbarSize = 8;
            this.pn_download.Location = new System.Drawing.Point(372, 409);
            this.pn_download.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_download.Name = "pn_download";
            this.pn_download.Size = new System.Drawing.Size(287, 48);
            this.pn_download.TabIndex = 9;
            this.pn_download.VerticalScrollbarBarColor = true;
            this.pn_download.VerticalScrollbarHighlightOnWheel = false;
            this.pn_download.VerticalScrollbarSize = 9;
            // 
            // dbl_downloadmp4
            // 
            this.dbl_downloadmp4.AutoSize = true;
            this.dbl_downloadmp4.Enabled = false;
            this.dbl_downloadmp4.Location = new System.Drawing.Point(151, 27);
            this.dbl_downloadmp4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dbl_downloadmp4.Name = "dbl_downloadmp4";
            this.dbl_downloadmp4.Size = new System.Drawing.Size(110, 15);
            this.dbl_downloadmp4.TabIndex = 1;
            this.dbl_downloadmp4.Text = "Mp4로 다운로드";
            this.dbl_downloadmp4.UseSelectable = true;
            // 
            // dbl_downloadmp3
            // 
            this.dbl_downloadmp3.AutoSize = true;
            this.dbl_downloadmp3.Checked = true;
            this.dbl_downloadmp3.Location = new System.Drawing.Point(20, 27);
            this.dbl_downloadmp3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dbl_downloadmp3.Name = "dbl_downloadmp3";
            this.dbl_downloadmp3.Size = new System.Drawing.Size(110, 15);
            this.dbl_downloadmp3.TabIndex = 0;
            this.dbl_downloadmp3.TabStop = true;
            this.dbl_downloadmp3.Text = "Mp3로 다운로드";
            this.dbl_downloadmp3.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(10, 9);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "다운로드";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Items.AddRange(new object[] {
            "미분류",
            "유머",
            "공포",
            "엽기"});
            this.metroComboBox1.Location = new System.Drawing.Point(20, 51);
            this.metroComboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(154, 29);
            this.metroComboBox1.TabIndex = 3;
            this.metroComboBox1.UseSelectable = true;
            // 
            // pn_randombgm
            // 
            this.pn_randombgm.Controls.Add(this.metroTextBox4);
            this.pn_randombgm.Controls.Add(this.metroLabel8);
            this.pn_randombgm.Controls.Add(this.metroTextBox3);
            this.pn_randombgm.Controls.Add(this.metroTextBox2);
            this.pn_randombgm.Controls.Add(this.metroLabel7);
            this.pn_randombgm.Controls.Add(this.metroTextBox1);
            this.pn_randombgm.Controls.Add(this.metroLabel6);
            this.pn_randombgm.Controls.Add(this.metroLabel5);
            this.pn_randombgm.Controls.Add(this.metroLabel4);
            this.pn_randombgm.Controls.Add(this.metroComboBox1);
            this.pn_randombgm.Controls.Add(this.metroLabel3);
            this.pn_randombgm.HorizontalScrollbarBarColor = true;
            this.pn_randombgm.HorizontalScrollbarHighlightOnWheel = false;
            this.pn_randombgm.HorizontalScrollbarSize = 8;
            this.pn_randombgm.Location = new System.Drawing.Point(322, 59);
            this.pn_randombgm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_randombgm.Name = "pn_randombgm";
            this.pn_randombgm.Size = new System.Drawing.Size(287, 205);
            this.pn_randombgm.TabIndex = 10;
            this.pn_randombgm.VerticalScrollbarBarColor = true;
            this.pn_randombgm.VerticalScrollbarHighlightOnWheel = false;
            this.pn_randombgm.VerticalScrollbarSize = 9;
            this.pn_randombgm.Paint += new System.Windows.Forms.PaintEventHandler(this.metroPanel3_Paint);
            // 
            // metroTextBox4
            // 
            // 
            // 
            // 
            this.metroTextBox4.CustomButton.Image = null;
            this.metroTextBox4.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.metroTextBox4.CustomButton.Name = "";
            this.metroTextBox4.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox4.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox4.CustomButton.TabIndex = 1;
            this.metroTextBox4.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox4.CustomButton.UseSelectable = true;
            this.metroTextBox4.CustomButton.Visible = false;
            this.metroTextBox4.Lines = new string[] {
        "0"};
            this.metroTextBox4.Location = new System.Drawing.Point(130, 169);
            this.metroTextBox4.MaxLength = 32767;
            this.metroTextBox4.Name = "metroTextBox4";
            this.metroTextBox4.PasswordChar = '\0';
            this.metroTextBox4.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox4.SelectedText = "";
            this.metroTextBox4.SelectionLength = 0;
            this.metroTextBox4.SelectionStart = 0;
            this.metroTextBox4.ShortcutsEnabled = true;
            this.metroTextBox4.Size = new System.Drawing.Size(80, 23);
            this.metroTextBox4.TabIndex = 13;
            this.metroTextBox4.Text = "0";
            this.metroTextBox4.UseSelectable = true;
            this.metroTextBox4.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox4.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(106, 169);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(18, 19);
            this.metroLabel8.TabIndex = 12;
            this.metroLabel8.Text = "~";
            // 
            // metroTextBox3
            // 
            // 
            // 
            // 
            this.metroTextBox3.CustomButton.Image = null;
            this.metroTextBox3.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.metroTextBox3.CustomButton.Name = "";
            this.metroTextBox3.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox3.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox3.CustomButton.TabIndex = 1;
            this.metroTextBox3.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox3.CustomButton.UseSelectable = true;
            this.metroTextBox3.CustomButton.Visible = false;
            this.metroTextBox3.Lines = new string[] {
        "0"};
            this.metroTextBox3.Location = new System.Drawing.Point(20, 169);
            this.metroTextBox3.MaxLength = 32767;
            this.metroTextBox3.Name = "metroTextBox3";
            this.metroTextBox3.PasswordChar = '\0';
            this.metroTextBox3.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox3.SelectedText = "";
            this.metroTextBox3.SelectionLength = 0;
            this.metroTextBox3.SelectionStart = 0;
            this.metroTextBox3.ShortcutsEnabled = true;
            this.metroTextBox3.Size = new System.Drawing.Size(80, 23);
            this.metroTextBox3.TabIndex = 11;
            this.metroTextBox3.Text = "0";
            this.metroTextBox3.UseSelectable = true;
            this.metroTextBox3.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox3.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox2
            // 
            // 
            // 
            // 
            this.metroTextBox2.CustomButton.Image = null;
            this.metroTextBox2.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.metroTextBox2.CustomButton.Name = "";
            this.metroTextBox2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox2.CustomButton.TabIndex = 1;
            this.metroTextBox2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox2.CustomButton.UseSelectable = true;
            this.metroTextBox2.CustomButton.Visible = false;
            this.metroTextBox2.Lines = new string[] {
        "0"};
            this.metroTextBox2.Location = new System.Drawing.Point(130, 108);
            this.metroTextBox2.MaxLength = 32767;
            this.metroTextBox2.Name = "metroTextBox2";
            this.metroTextBox2.PasswordChar = '\0';
            this.metroTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox2.SelectedText = "";
            this.metroTextBox2.SelectionLength = 0;
            this.metroTextBox2.SelectionStart = 0;
            this.metroTextBox2.ShortcutsEnabled = true;
            this.metroTextBox2.Size = new System.Drawing.Size(80, 23);
            this.metroTextBox2.TabIndex = 10;
            this.metroTextBox2.Text = "0";
            this.metroTextBox2.UseSelectable = true;
            this.metroTextBox2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(106, 108);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(18, 19);
            this.metroLabel7.TabIndex = 9;
            this.metroLabel7.Text = "~";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[] {
        "0"};
            this.metroTextBox1.Location = new System.Drawing.Point(20, 108);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(80, 23);
            this.metroTextBox1.TabIndex = 8;
            this.metroTextBox1.Text = "0";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(10, 138);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(122, 19);
            this.metroLabel6.TabIndex = 7;
            this.metroLabel6.Text = "댓글수 [MAX 1000]";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(90, 9);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(120, 19);
            this.metroLabel5.TabIndex = 5;
            this.metroLabel5.Text = "랜덤BGM [준비중]";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(10, 86);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(122, 19);
            this.metroLabel4.TabIndex = 4;
            this.metroLabel4.Text = "추천수 [MAX 1000]";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(10, 33);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(37, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "장르";
            // 
            // pn_prev
            // 
            this.pn_prev.Controls.Add(this.dbl_pmp3);
            this.pn_prev.Controls.Add(this.dbl_pmp4);
            this.pn_prev.Controls.Add(this.metroLabel9);
            this.pn_prev.HorizontalScrollbarBarColor = true;
            this.pn_prev.HorizontalScrollbarHighlightOnWheel = false;
            this.pn_prev.HorizontalScrollbarSize = 8;
            this.pn_prev.Location = new System.Drawing.Point(372, 357);
            this.pn_prev.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_prev.Name = "pn_prev";
            this.pn_prev.Size = new System.Drawing.Size(287, 48);
            this.pn_prev.TabIndex = 11;
            this.pn_prev.VerticalScrollbarBarColor = true;
            this.pn_prev.VerticalScrollbarHighlightOnWheel = false;
            this.pn_prev.VerticalScrollbarSize = 9;
            // 
            // dbl_pmp3
            // 
            this.dbl_pmp3.AutoSize = true;
            this.dbl_pmp3.Checked = true;
            this.dbl_pmp3.Location = new System.Drawing.Point(151, 27);
            this.dbl_pmp3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dbl_pmp3.Name = "dbl_pmp3";
            this.dbl_pmp3.Size = new System.Drawing.Size(118, 15);
            this.dbl_pmp3.TabIndex = 1;
            this.dbl_pmp3.TabStop = true;
            this.dbl_pmp3.Text = "mp3로 재생[음악]";
            this.dbl_pmp3.UseSelectable = true;
            // 
            // dbl_pmp4
            // 
            this.dbl_pmp4.AutoSize = true;
            this.dbl_pmp4.Enabled = false;
            this.dbl_pmp4.Location = new System.Drawing.Point(20, 27);
            this.dbl_pmp4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dbl_pmp4.Name = "dbl_pmp4";
            this.dbl_pmp4.Size = new System.Drawing.Size(121, 15);
            this.dbl_pmp4.TabIndex = 0;
            this.dbl_pmp4.Text = "mp4로 재생 [영상]";
            this.dbl_pmp4.UseSelectable = true;
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(10, 9);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(65, 19);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "미리듣기";
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.WEEKLY_BEST_COMPOSITION);
            this.metroPanel1.Controls.Add(this.metroLabel15);
            this.metroPanel1.Controls.Add(this.RANDOM);
            this.metroPanel1.Controls.Add(this.metroLabel14);
            this.metroPanel1.Controls.Add(this.NEWEST_VOTED);
            this.metroPanel1.Controls.Add(this.metroLabel13);
            this.metroPanel1.Controls.Add(this.NEWEST_COMPOSITION);
            this.metroPanel1.Controls.Add(this.metroLabel12);
            this.metroPanel1.Controls.Add(this.metroLabel11);
            this.metroPanel1.Controls.Add(this.NEWEST);
            this.metroPanel1.Controls.Add(this.metroLabel10);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 8;
            this.metroPanel1.Location = new System.Drawing.Point(29, 111);
            this.metroPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(287, 185);
            this.metroPanel1.TabIndex = 10;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 9;
            // 
            // WEEKLY_BEST_COMPOSITION
            // 
            // 
            // 
            // 
            this.WEEKLY_BEST_COMPOSITION.CustomButton.Image = null;
            this.WEEKLY_BEST_COMPOSITION.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.WEEKLY_BEST_COMPOSITION.CustomButton.Name = "";
            this.WEEKLY_BEST_COMPOSITION.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.WEEKLY_BEST_COMPOSITION.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.WEEKLY_BEST_COMPOSITION.CustomButton.TabIndex = 1;
            this.WEEKLY_BEST_COMPOSITION.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.WEEKLY_BEST_COMPOSITION.CustomButton.UseSelectable = true;
            this.WEEKLY_BEST_COMPOSITION.CustomButton.Visible = false;
            this.WEEKLY_BEST_COMPOSITION.Lines = new string[] {
        "20"};
            this.WEEKLY_BEST_COMPOSITION.Location = new System.Drawing.Point(182, 147);
            this.WEEKLY_BEST_COMPOSITION.MaxLength = 32767;
            this.WEEKLY_BEST_COMPOSITION.Name = "WEEKLY_BEST_COMPOSITION";
            this.WEEKLY_BEST_COMPOSITION.PasswordChar = '\0';
            this.WEEKLY_BEST_COMPOSITION.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.WEEKLY_BEST_COMPOSITION.SelectedText = "";
            this.WEEKLY_BEST_COMPOSITION.SelectionLength = 0;
            this.WEEKLY_BEST_COMPOSITION.SelectionStart = 0;
            this.WEEKLY_BEST_COMPOSITION.ShortcutsEnabled = true;
            this.WEEKLY_BEST_COMPOSITION.Size = new System.Drawing.Size(80, 23);
            this.WEEKLY_BEST_COMPOSITION.TabIndex = 22;
            this.WEEKLY_BEST_COMPOSITION.Text = "20";
            this.WEEKLY_BEST_COMPOSITION.UseSelectable = true;
            this.WEEKLY_BEST_COMPOSITION.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.WEEKLY_BEST_COMPOSITION.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.WEEKLY_BEST_COMPOSITION.Click += new System.EventHandler(this.metroTextBox9_Click);
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(19, 147);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(162, 19);
            this.metroLabel15.TabIndex = 21;
            this.metroLabel15.Text = "주간 베스트 자작곡 BGM";
            // 
            // RANDOM
            // 
            // 
            // 
            // 
            this.RANDOM.CustomButton.Image = null;
            this.RANDOM.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.RANDOM.CustomButton.Name = "";
            this.RANDOM.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.RANDOM.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.RANDOM.CustomButton.TabIndex = 1;
            this.RANDOM.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.RANDOM.CustomButton.UseSelectable = true;
            this.RANDOM.CustomButton.Visible = false;
            this.RANDOM.Lines = new string[] {
        "5"};
            this.RANDOM.Location = new System.Drawing.Point(182, 118);
            this.RANDOM.MaxLength = 32767;
            this.RANDOM.Name = "RANDOM";
            this.RANDOM.PasswordChar = '\0';
            this.RANDOM.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.RANDOM.SelectedText = "";
            this.RANDOM.SelectionLength = 0;
            this.RANDOM.SelectionStart = 0;
            this.RANDOM.ShortcutsEnabled = true;
            this.RANDOM.Size = new System.Drawing.Size(80, 23);
            this.RANDOM.TabIndex = 20;
            this.RANDOM.Text = "5";
            this.RANDOM.UseSelectable = true;
            this.RANDOM.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.RANDOM.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.RANDOM.Click += new System.EventHandler(this.metroTextBox8_Click);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(19, 118);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(70, 19);
            this.metroLabel14.TabIndex = 19;
            this.metroLabel14.Text = "랜덤 BGM";
            // 
            // NEWEST_VOTED
            // 
            // 
            // 
            // 
            this.NEWEST_VOTED.CustomButton.Image = null;
            this.NEWEST_VOTED.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.NEWEST_VOTED.CustomButton.Name = "";
            this.NEWEST_VOTED.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NEWEST_VOTED.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NEWEST_VOTED.CustomButton.TabIndex = 1;
            this.NEWEST_VOTED.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NEWEST_VOTED.CustomButton.UseSelectable = true;
            this.NEWEST_VOTED.CustomButton.Visible = false;
            this.NEWEST_VOTED.Lines = new string[] {
        "5"};
            this.NEWEST_VOTED.Location = new System.Drawing.Point(182, 89);
            this.NEWEST_VOTED.MaxLength = 32767;
            this.NEWEST_VOTED.Name = "NEWEST_VOTED";
            this.NEWEST_VOTED.PasswordChar = '\0';
            this.NEWEST_VOTED.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NEWEST_VOTED.SelectedText = "";
            this.NEWEST_VOTED.SelectionLength = 0;
            this.NEWEST_VOTED.SelectionStart = 0;
            this.NEWEST_VOTED.ShortcutsEnabled = true;
            this.NEWEST_VOTED.Size = new System.Drawing.Size(80, 23);
            this.NEWEST_VOTED.TabIndex = 18;
            this.NEWEST_VOTED.Text = "5";
            this.NEWEST_VOTED.UseSelectable = true;
            this.NEWEST_VOTED.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NEWEST_VOTED.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.NEWEST_VOTED.Click += new System.EventHandler(this.metroTextBox7_Click);
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(19, 89);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(116, 19);
            this.metroLabel13.TabIndex = 17;
            this.metroLabel13.Text = "최근 추천된 BGM";
            // 
            // NEWEST_COMPOSITION
            // 
            // 
            // 
            // 
            this.NEWEST_COMPOSITION.CustomButton.Image = null;
            this.NEWEST_COMPOSITION.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.NEWEST_COMPOSITION.CustomButton.Name = "";
            this.NEWEST_COMPOSITION.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NEWEST_COMPOSITION.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NEWEST_COMPOSITION.CustomButton.TabIndex = 1;
            this.NEWEST_COMPOSITION.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NEWEST_COMPOSITION.CustomButton.UseSelectable = true;
            this.NEWEST_COMPOSITION.CustomButton.Visible = false;
            this.NEWEST_COMPOSITION.Lines = new string[] {
        "5"};
            this.NEWEST_COMPOSITION.Location = new System.Drawing.Point(182, 60);
            this.NEWEST_COMPOSITION.MaxLength = 32767;
            this.NEWEST_COMPOSITION.Name = "NEWEST_COMPOSITION";
            this.NEWEST_COMPOSITION.PasswordChar = '\0';
            this.NEWEST_COMPOSITION.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NEWEST_COMPOSITION.SelectedText = "";
            this.NEWEST_COMPOSITION.SelectionLength = 0;
            this.NEWEST_COMPOSITION.SelectionStart = 0;
            this.NEWEST_COMPOSITION.ShortcutsEnabled = true;
            this.NEWEST_COMPOSITION.Size = new System.Drawing.Size(80, 23);
            this.NEWEST_COMPOSITION.TabIndex = 16;
            this.NEWEST_COMPOSITION.Text = "5";
            this.NEWEST_COMPOSITION.UseSelectable = true;
            this.NEWEST_COMPOSITION.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NEWEST_COMPOSITION.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.NEWEST_COMPOSITION.Click += new System.EventHandler(this.metroTextBox6_Click);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(19, 62);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(130, 19);
            this.metroLabel12.TabIndex = 15;
            this.metroLabel12.Text = "새로운 자작곡 BGM";
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(20, 31);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(84, 19);
            this.metroLabel11.TabIndex = 14;
            this.metroLabel11.Text = "새로운 BGM";
            // 
            // NEWEST
            // 
            // 
            // 
            // 
            this.NEWEST.CustomButton.Image = null;
            this.NEWEST.CustomButton.Location = new System.Drawing.Point(58, 1);
            this.NEWEST.CustomButton.Name = "";
            this.NEWEST.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.NEWEST.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.NEWEST.CustomButton.TabIndex = 1;
            this.NEWEST.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.NEWEST.CustomButton.UseSelectable = true;
            this.NEWEST.CustomButton.Visible = false;
            this.NEWEST.Lines = new string[] {
        "5"};
            this.NEWEST.Location = new System.Drawing.Point(182, 30);
            this.NEWEST.MaxLength = 32767;
            this.NEWEST.Name = "NEWEST";
            this.NEWEST.PasswordChar = '\0';
            this.NEWEST.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.NEWEST.SelectedText = "";
            this.NEWEST.SelectionLength = 0;
            this.NEWEST.SelectionStart = 0;
            this.NEWEST.ShortcutsEnabled = true;
            this.NEWEST.Size = new System.Drawing.Size(80, 23);
            this.NEWEST.TabIndex = 14;
            this.NEWEST.Text = "5";
            this.NEWEST.UseSelectable = true;
            this.NEWEST.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.NEWEST.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.NEWEST.Click += new System.EventHandler(this.metroTextBox5_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(10, 9);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(101, 19);
            this.metroLabel10.TabIndex = 2;
            this.metroLabel10.Text = "브금 로드 갯수";
            // 
            // OptionPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 353);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.pn_prev);
            this.Controls.Add(this.pn_randombgm);
            this.Controls.Add(this.metroTile1);
            this.Controls.Add(this.pn_dbl);
            this.Controls.Add(this.pn_download);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "OptionPage";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 16);
            this.Resizable = false;
            this.Text = "OptionPage";
            this.Load += new System.EventHandler(this.OptionPage_Load);
            this.pn_dbl.ResumeLayout(false);
            this.pn_dbl.PerformLayout();
            this.pn_download.ResumeLayout(false);
            this.pn_download.PerformLayout();
            this.pn_randombgm.ResumeLayout(false);
            this.pn_randombgm.PerformLayout();
            this.pn_prev.ResumeLayout(false);
            this.pn_prev.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroPanel pn_dbl;
        private MetroFramework.Controls.MetroRadioButton dbl_Preview;
        private MetroFramework.Controls.MetroRadioButton dbl_Site;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroPanel pn_download;
        private MetroFramework.Controls.MetroRadioButton dbl_downloadmp4;
        private MetroFramework.Controls.MetroRadioButton dbl_downloadmp3;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private MetroFramework.Controls.MetroPanel pn_randombgm;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox metroTextBox4;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroTextBox metroTextBox3;
        private MetroFramework.Controls.MetroTextBox metroTextBox2;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroPanel pn_prev;
        private MetroFramework.Controls.MetroRadioButton dbl_pmp3;
        private MetroFramework.Controls.MetroRadioButton dbl_pmp4;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroTextBox WEEKLY_BEST_COMPOSITION;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private MetroFramework.Controls.MetroTextBox RANDOM;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroTextBox NEWEST_VOTED;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroTextBox NEWEST_COMPOSITION;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroTextBox NEWEST;
        private MetroFramework.Controls.MetroLabel metroLabel10;
    }
}