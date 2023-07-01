namespace BGMSTORE
{
    partial class PlayList
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
            this.components = new System.ComponentModel.Container();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.userlist = new System.Windows.Forms.ListView();
            this.장르 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroRadioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.btn_Moreload = new MetroFramework.Controls.MetroTile();
            this.btn_AllCheck = new MetroFramework.Controls.MetroTile();
            this.btn_NoCheck = new MetroFramework.Controls.MetroTile();
            this.plist = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.제목 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.재생시간 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.추천수 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.password = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.pcount = new MetroFramework.Controls.MetroLabel();
            this.selectt = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.title = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.nick = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.upload = new MetroFramework.Controls.MetroLabel();
            this.pnum = new MetroFramework.Controls.MetroLabel();
            this.select = new MetroFramework.Controls.MetroLabel();
            this._playlist = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.사이트열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pcombo = new System.Windows.Forms.ComboBox();
            this.metroButton4 = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this._playlist.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(267, 67);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(63, 25);
            this.metroButton1.TabIndex = 22;
            this.metroButton1.Text = "저장";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(336, 67);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(67, 25);
            this.metroButton2.TabIndex = 23;
            this.metroButton2.Text = "불러오기";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage3);
            this.metroTabControl1.Location = new System.Drawing.Point(34, 98);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(630, 510);
            this.metroTabControl1.TabIndex = 25;
            this.metroTabControl1.UseSelectable = true;
            this.metroTabControl1.Click += new System.EventHandler(this.metroTabControl1_Click);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.userlist);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(622, 468);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "유저 리스트";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            this.metroTabPage1.Click += new System.EventHandler(this.metroTabPage1_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(212, 433);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(379, 19);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "플레이리스트에 추가를 원하시면 항목을 더블클릭 해주세요";
            // 
            // userlist
            // 
            this.userlist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.장르,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.userlist.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.userlist.Location = new System.Drawing.Point(13, 15);
            this.userlist.Name = "userlist";
            this.userlist.Size = new System.Drawing.Size(578, 406);
            this.userlist.TabIndex = 23;
            this.userlist.UseCompatibleStateImageBehavior = false;
            this.userlist.View = System.Windows.Forms.View.Details;
            this.userlist.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            this.userlist.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // 장르
            // 
            this.장르.Text = "제목";
            this.장르.Width = 330;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "곡개수";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "User";
            this.columnHeader2.Width = 80;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "추천수";
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroRadioButton2);
            this.metroTabPage2.Controls.Add(this.metroRadioButton1);
            this.metroTabPage2.Controls.Add(this.metroCheckBox1);
            this.metroTabPage2.Controls.Add(this.btn_Moreload);
            this.metroTabPage2.Controls.Add(this.btn_AllCheck);
            this.metroTabPage2.Controls.Add(this.btn_NoCheck);
            this.metroTabPage2.Controls.Add(this.plist);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(622, 468);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "나의 플레이리스트";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            this.metroTabPage2.Click += new System.EventHandler(this.metroTabPage2_Click);
            // 
            // metroRadioButton2
            // 
            this.metroRadioButton2.AutoSize = true;
            this.metroRadioButton2.Location = new System.Drawing.Point(485, 449);
            this.metroRadioButton2.Name = "metroRadioButton2";
            this.metroRadioButton2.Size = new System.Drawing.Size(98, 15);
            this.metroRadioButton2.TabIndex = 38;
            this.metroRadioButton2.Text = "랜덤 셔플재생";
            this.metroRadioButton2.UseSelectable = true;
            // 
            // metroRadioButton1
            // 
            this.metroRadioButton1.AutoSize = true;
            this.metroRadioButton1.Checked = true;
            this.metroRadioButton1.Location = new System.Drawing.Point(404, 449);
            this.metroRadioButton1.Name = "metroRadioButton1";
            this.metroRadioButton1.Size = new System.Drawing.Size(74, 15);
            this.metroRadioButton1.TabIndex = 37;
            this.metroRadioButton1.TabStop = true;
            this.metroRadioButton1.Text = "일괄 재생";
            this.metroRadioButton1.UseSelectable = true;
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.Checked = true;
            this.metroCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBox1.Enabled = false;
            this.metroCheckBox1.Location = new System.Drawing.Point(404, 426);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(191, 15);
            this.metroCheckBox1.TabIndex = 36;
            this.metroCheckBox1.Text = "한곡이 끝나면 다음곡 자동 재생";
            this.metroCheckBox1.UseSelectable = true;
            // 
            // btn_Moreload
            // 
            this.btn_Moreload.ActiveControl = null;
            this.btn_Moreload.Location = new System.Drawing.Point(231, 426);
            this.btn_Moreload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Moreload.Name = "btn_Moreload";
            this.btn_Moreload.Size = new System.Drawing.Size(105, 46);
            this.btn_Moreload.TabIndex = 33;
            this.btn_Moreload.Text = "삭제";
            this.btn_Moreload.UseSelectable = true;
            this.btn_Moreload.Click += new System.EventHandler(this.btn_Moreload_Click);
            // 
            // btn_AllCheck
            // 
            this.btn_AllCheck.ActiveControl = null;
            this.btn_AllCheck.Location = new System.Drawing.Point(12, 426);
            this.btn_AllCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AllCheck.Name = "btn_AllCheck";
            this.btn_AllCheck.Size = new System.Drawing.Size(104, 46);
            this.btn_AllCheck.TabIndex = 34;
            this.btn_AllCheck.Text = "모두체크";
            this.btn_AllCheck.UseSelectable = true;
            this.btn_AllCheck.Click += new System.EventHandler(this.btn_AllCheck_Click);
            // 
            // btn_NoCheck
            // 
            this.btn_NoCheck.ActiveControl = null;
            this.btn_NoCheck.Location = new System.Drawing.Point(122, 426);
            this.btn_NoCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NoCheck.Name = "btn_NoCheck";
            this.btn_NoCheck.Size = new System.Drawing.Size(103, 46);
            this.btn_NoCheck.TabIndex = 35;
            this.btn_NoCheck.Text = "모두체크해제";
            this.btn_NoCheck.UseSelectable = true;
            this.btn_NoCheck.Click += new System.EventHandler(this.btn_NoCheck_Click);
            // 
            // plist
            // 
            this.plist.CheckBoxes = true;
            this.plist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.제목,
            this.재생시간,
            this.추천수});
            this.plist.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.plist.Location = new System.Drawing.Point(12, 19);
            this.plist.Name = "plist";
            this.plist.Size = new System.Drawing.Size(583, 399);
            this.plist.TabIndex = 23;
            this.plist.UseCompatibleStateImageBehavior = false;
            this.plist.View = System.Windows.Forms.View.Details;
            this.plist.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            this.plist.DoubleClick += new System.EventHandler(this.listView2_DoubleClick);
            this.plist.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView2_MouseClick);
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "장르";
            this.columnHeader4.Width = 75;
            // 
            // 제목
            // 
            this.제목.Text = "제목";
            this.제목.Width = 330;
            // 
            // 재생시간
            // 
            this.재생시간.Text = "재생시간";
            this.재생시간.Width = 75;
            // 
            // 추천수
            // 
            this.추천수.Tag = "Numeric";
            this.추천수.Text = "추천수";
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.password);
            this.metroTabPage3.Controls.Add(this.metroLabel4);
            this.metroTabPage3.Controls.Add(this.metroLabel3);
            this.metroTabPage3.Controls.Add(this.pcount);
            this.metroTabPage3.Controls.Add(this.selectt);
            this.metroTabPage3.Controls.Add(this.metroLabel7);
            this.metroTabPage3.Controls.Add(this.title);
            this.metroTabPage3.Controls.Add(this.metroLabel6);
            this.metroTabPage3.Controls.Add(this.nick);
            this.metroTabPage3.Controls.Add(this.metroLabel5);
            this.metroTabPage3.Controls.Add(this.metroTile1);
            this.metroTabPage3.Controls.Add(this.upload);
            this.metroTabPage3.Controls.Add(this.pnum);
            this.metroTabPage3.Controls.Add(this.select);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(622, 468);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "온라인 업로드";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            this.metroTabPage3.Click += new System.EventHandler(this.metroTabPage3_Click);
            // 
            // password
            // 
            // 
            // 
            // 
            this.password.CustomButton.Image = null;
            this.password.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.password.CustomButton.Name = "";
            this.password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.password.CustomButton.TabIndex = 1;
            this.password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.password.CustomButton.UseSelectable = true;
            this.password.CustomButton.Visible = false;
            this.password.Lines = new string[] {
        "익명의 BGM"};
            this.password.Location = new System.Drawing.Point(172, 152);
            this.password.MaxLength = 32767;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.password.SelectedText = "";
            this.password.SelectionLength = 0;
            this.password.SelectionStart = 0;
            this.password.ShortcutsEnabled = true;
            this.password.Size = new System.Drawing.Size(111, 23);
            this.password.TabIndex = 15;
            this.password.Text = "익명의 BGM";
            this.password.UseSelectable = true;
            this.password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.password.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.password.Click += new System.EventHandler(this.metroTextBox3_Click);
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(56, 153);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(111, 19);
            this.metroLabel4.TabIndex = 14;
            this.metroLabel4.Text = "업로드 비밀번호";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(473, 164);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(16, 19);
            this.metroLabel3.TabIndex = 13;
            this.metroLabel3.Text = "3";
            // 
            // pcount
            // 
            this.pcount.AutoSize = true;
            this.pcount.Location = new System.Drawing.Point(459, 121);
            this.pcount.Name = "pcount";
            this.pcount.Size = new System.Drawing.Size(16, 19);
            this.pcount.TabIndex = 12;
            this.pcount.Text = "0";
            // 
            // selectt
            // 
            this.selectt.AutoSize = true;
            this.selectt.Location = new System.Drawing.Point(445, 80);
            this.selectt.Name = "selectt";
            this.selectt.Size = new System.Drawing.Size(41, 19);
            this.selectt.TabIndex = 11;
            this.selectt.Text = "None";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(56, 118);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(37, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "제목";
            // 
            // title
            // 
            // 
            // 
            // 
            this.title.CustomButton.Image = null;
            this.title.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.title.CustomButton.Name = "";
            this.title.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.title.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.title.CustomButton.TabIndex = 1;
            this.title.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.title.CustomButton.UseSelectable = true;
            this.title.CustomButton.Visible = false;
            this.title.Lines = new string[] {
        "익명의 BGM"};
            this.title.Location = new System.Drawing.Point(113, 117);
            this.title.MaxLength = 32767;
            this.title.Name = "title";
            this.title.PasswordChar = '\0';
            this.title.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.title.SelectedText = "";
            this.title.SelectionLength = 0;
            this.title.SelectionStart = 0;
            this.title.ShortcutsEnabled = true;
            this.title.Size = new System.Drawing.Size(111, 23);
            this.title.TabIndex = 9;
            this.title.Text = "익명의 BGM";
            this.title.UseSelectable = true;
            this.title.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.title.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.title.Click += new System.EventHandler(this.metroTextBox2_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(56, 81);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(51, 19);
            this.metroLabel6.TabIndex = 8;
            this.metroLabel6.Text = "닉네임";
            // 
            // nick
            // 
            // 
            // 
            // 
            this.nick.CustomButton.Image = null;
            this.nick.CustomButton.Location = new System.Drawing.Point(89, 1);
            this.nick.CustomButton.Name = "";
            this.nick.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nick.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nick.CustomButton.TabIndex = 1;
            this.nick.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nick.CustomButton.UseSelectable = true;
            this.nick.CustomButton.Visible = false;
            this.nick.Lines = new string[] {
        "익명의 닝겐"};
            this.nick.Location = new System.Drawing.Point(113, 80);
            this.nick.MaxLength = 32767;
            this.nick.Name = "nick";
            this.nick.PasswordChar = '\0';
            this.nick.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nick.SelectedText = "";
            this.nick.SelectionLength = 0;
            this.nick.SelectionStart = 0;
            this.nick.ShortcutsEnabled = true;
            this.nick.Size = new System.Drawing.Size(111, 23);
            this.nick.TabIndex = 7;
            this.nick.Text = "익명의 닝겐";
            this.nick.UseSelectable = true;
            this.nick.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nick.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.nick.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(56, 314);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(522, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "주의! 미풍양속에 위반한 제목을 선정할 경우 관련법에 의해 처벌 받을 수 있습니다.";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(56, 249);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(415, 45);
            this.metroTile1.TabIndex = 5;
            this.metroTile1.Text = "업로드";
            this.metroTile1.UseSelectable = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // upload
            // 
            this.upload.AutoSize = true;
            this.upload.Location = new System.Drawing.Point(321, 164);
            this.upload.Name = "upload";
            this.upload.Size = new System.Drawing.Size(150, 19);
            this.upload.TabIndex = 4;
            this.upload.Text = "오늘남은 업로드 횟수 :";
            // 
            // pnum
            // 
            this.pnum.AutoSize = true;
            this.pnum.Location = new System.Drawing.Point(321, 120);
            this.pnum.Name = "pnum";
            this.pnum.Size = new System.Drawing.Size(132, 19);
            this.pnum.TabIndex = 3;
            this.pnum.Text = "플레이리스트 개수 :";
            this.pnum.Click += new System.EventHandler(this.metroLabel3_Click);
            // 
            // select
            // 
            this.select.AutoSize = true;
            this.select.Location = new System.Drawing.Point(321, 79);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(123, 19);
            this.select.TabIndex = 2;
            this.select.Text = "현재 선택된 BGM :";
            this.select.Click += new System.EventHandler(this.metroLabel2_Click);
            // 
            // _playlist
            // 
            this._playlist.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._playlist.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.사이트열기ToolStripMenuItem});
            this._playlist.Name = "metroContextMenu1";
            this._playlist.Size = new System.Drawing.Size(139, 48);
            this._playlist.Text = "test";
            this._playlist.Opening += new System.ComponentModel.CancelEventHandler(this._playlist_Opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(138, 22);
            this.toolStripMenuItem1.Text = "삭제";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 사이트열기ToolStripMenuItem
            // 
            this.사이트열기ToolStripMenuItem.Name = "사이트열기ToolStripMenuItem";
            this.사이트열기ToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.사이트열기ToolStripMenuItem.Text = "사이트 열기";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pcombo
            // 
            this.pcombo.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pcombo.FormattingEnabled = true;
            this.pcombo.Location = new System.Drawing.Point(44, 67);
            this.pcombo.Name = "pcombo";
            this.pcombo.Size = new System.Drawing.Size(217, 25);
            this.pcombo.TabIndex = 26;
            this.pcombo.SelectedIndexChanged += new System.EventHandler(this.pcombo_SelectedIndexChanged);
            // 
            // metroButton4
            // 
            this.metroButton4.Location = new System.Drawing.Point(409, 67);
            this.metroButton4.Name = "metroButton4";
            this.metroButton4.Size = new System.Drawing.Size(63, 25);
            this.metroButton4.TabIndex = 28;
            this.metroButton4.Text = "삭제";
            this.metroButton4.UseSelectable = true;
            this.metroButton4.Click += new System.EventHandler(this.metroButton4_Click);
            // 
            // PlayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 654);
            this.Controls.Add(this.metroButton4);
            this.Controls.Add(this.pcombo);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.metroButton1);
            this.Name = "PlayList";
            this.Text = "PlayList";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlayList_FormClosing);
            this.Load += new System.EventHandler(this.PlayList_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PlayList_MouseClick);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this._playlist.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.ListView userlist;
        private System.Windows.Forms.ColumnHeader 장르;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader 제목;
        private System.Windows.Forms.ColumnHeader 재생시간;
        private System.Windows.Forms.ColumnHeader 추천수;
        private MetroFramework.Controls.MetroTile btn_Moreload;
        private MetroFramework.Controls.MetroTile btn_AllCheck;
        private MetroFramework.Controls.MetroTile btn_NoCheck;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton2;
        private MetroFramework.Controls.MetroRadioButton metroRadioButton1;
        private MetroFramework.Controls.MetroCheckBox metroCheckBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroContextMenu _playlist;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 사이트열기ToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.ListView plist;
        private System.Windows.Forms.ComboBox pcombo;
        private MetroFramework.Controls.MetroButton metroButton4;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroLabel pnum;
        private MetroFramework.Controls.MetroLabel select;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox title;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox nick;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroLabel upload;
        private MetroFramework.Controls.MetroLabel selectt;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel pcount;
        private MetroFramework.Controls.MetroTextBox password;
        private MetroFramework.Controls.MetroLabel metroLabel4;
    }
}