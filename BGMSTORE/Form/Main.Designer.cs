namespace BGMSTORE
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this._menu = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this._listviewM = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.리스트추가ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.설정ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.사이트열기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.playctime = new MetroFramework.Controls.MetroLabel();
            this.pause = new System.Windows.Forms.Label();
            this.stop = new System.Windows.Forms.Label();
            this.play = new System.Windows.Forms.Label();
            this.playtime = new MetroFramework.Controls.MetroLabel();
            this.playtext = new MetroFramework.Controls.MetroLabel();
            this.playbar = new MetroFramework.Controls.MetroTrackBar();
            this.btn_Random = new MetroFramework.Controls.MetroTile();
            this.NowTime = new MetroFramework.Controls.MetroLabel();
            this.download_count = new System.Windows.Forms.Label();
            this.SearchOptionA = new MetroFramework.Controls.MetroComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.장르 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.제목 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.재생시간 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.추천수 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchOptionB = new MetroFramework.Controls.MetroComboBox();
            this.SearchTitle = new MetroFramework.Controls.MetroTextBox();
            this.btn_Search = new MetroFramework.Controls.MetroButton();
            this.btn_Moreload = new MetroFramework.Controls.MetroTile();
            this.btn_Download = new MetroFramework.Controls.MetroTile();
            this.btn_AllCheck = new MetroFramework.Controls.MetroTile();
            this.btn_NoCheck = new MetroFramework.Controls.MetroTile();
            this.progressBar1 = new MetroFramework.Controls.MetroProgressBar();
            this.MediaPlay = new System.Windows.Forms.Timer(this.components);
            this.slidedown = new System.Windows.Forms.Timer(this.components);
            this._menu.SuspendLayout();
            this._listviewM.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // _menu
            // 
            this._menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.설정ToolStripMenuItem,
            this.aboutToolStripMenuItem1});
            this._menu.Name = "metroContextMenu1";
            this._menu.Size = new System.Drawing.Size(108, 48);
            this._menu.Text = "test";
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.설정ToolStripMenuItem.Text = "설정";
            this.설정ToolStripMenuItem.Click += new System.EventHandler(this.설정ToolStripMenuItem_Click_1);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // _listviewM
            // 
            this._listviewM.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._listviewM.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.리스트추가ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.설정ToolStripMenuItem1,
            this.사이트열기ToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this._listviewM.Name = "metroContextMenu1";
            this._listviewM.Size = new System.Drawing.Size(175, 114);
            this._listviewM.Text = "test";
            // 
            // 리스트추가ToolStripMenuItem
            // 
            this.리스트추가ToolStripMenuItem.Name = "리스트추가ToolStripMenuItem";
            this.리스트추가ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.리스트추가ToolStripMenuItem.Text = "플레이리스트 추가";
            this.리스트추가ToolStripMenuItem.Click += new System.EventHandler(this.리스트추가ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.toolStripMenuItem1.Text = "다운로드";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // 설정ToolStripMenuItem1
            // 
            this.설정ToolStripMenuItem1.Name = "설정ToolStripMenuItem1";
            this.설정ToolStripMenuItem1.Size = new System.Drawing.Size(174, 22);
            this.설정ToolStripMenuItem1.Text = "설정";
            this.설정ToolStripMenuItem1.Click += new System.EventHandler(this.설정ToolStripMenuItem1_Click);
            // 
            // 사이트열기ToolStripMenuItem
            // 
            this.사이트열기ToolStripMenuItem.Name = "사이트열기ToolStripMenuItem";
            this.사이트열기ToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.사이트열기ToolStripMenuItem.Text = "사이트 열기";
            this.사이트열기ToolStripMenuItem.Click += new System.EventHandler(this.사이트열기ToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.MainPanel);
            this.panel1.Location = new System.Drawing.Point(20, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(913, 738);
            this.panel1.TabIndex = 39;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.webBrowser1);
            this.panel2.Location = new System.Drawing.Point(608, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(302, 392);
            this.panel2.TabIndex = 40;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(302, 392);
            this.webBrowser1.TabIndex = 39;
            this.webBrowser1.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.metroButton1);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.playctime);
            this.MainPanel.Controls.Add(this.pause);
            this.MainPanel.Controls.Add(this.stop);
            this.MainPanel.Controls.Add(this.play);
            this.MainPanel.Controls.Add(this.playtime);
            this.MainPanel.Controls.Add(this.playtext);
            this.MainPanel.Controls.Add(this.playbar);
            this.MainPanel.Controls.Add(this.btn_Random);
            this.MainPanel.Controls.Add(this.NowTime);
            this.MainPanel.Controls.Add(this.download_count);
            this.MainPanel.Controls.Add(this.SearchOptionA);
            this.MainPanel.Controls.Add(this.listView1);
            this.MainPanel.Controls.Add(this.SearchOptionB);
            this.MainPanel.Controls.Add(this.SearchTitle);
            this.MainPanel.Controls.Add(this.btn_Search);
            this.MainPanel.Controls.Add(this.btn_Moreload);
            this.MainPanel.Controls.Add(this.btn_Download);
            this.MainPanel.Controls.Add(this.btn_AllCheck);
            this.MainPanel.Controls.Add(this.btn_NoCheck);
            this.MainPanel.Controls.Add(this.progressBar1);
            this.MainPanel.Location = new System.Drawing.Point(3, 6);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(599, 720);
            this.MainPanel.TabIndex = 38;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(520, 683);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(36, 29);
            this.metroButton1.TabIndex = 41;
            this.metroButton1.Text = ">>";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Visible = false;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::BGMSTORE.Properties.Resources.plist;
            this.pictureBox1.Location = new System.Drawing.Point(438, 683);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // playctime
            // 
            this.playctime.AutoSize = true;
            this.playctime.Location = new System.Drawing.Point(212, 688);
            this.playctime.Name = "playctime";
            this.playctime.Size = new System.Drawing.Size(40, 19);
            this.playctime.TabIndex = 39;
            this.playctime.Text = "00:00";
            // 
            // pause
            // 
            this.pause.AutoSize = true;
            this.pause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pause.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.pause.Location = new System.Drawing.Point(182, 688);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(24, 21);
            this.pause.TabIndex = 38;
            this.pause.Text = "❚❚";
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // stop
            // 
            this.stop.AutoSize = true;
            this.stop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stop.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.stop.Location = new System.Drawing.Point(153, 688);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(28, 21);
            this.stop.TabIndex = 37;
            this.stop.Text = "■";
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // play
            // 
            this.play.AutoSize = true;
            this.play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.play.Font = new System.Drawing.Font("나눔고딕", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.play.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.play.Location = new System.Drawing.Point(127, 688);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(28, 21);
            this.play.TabIndex = 36;
            this.play.Text = "▶";
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // playtime
            // 
            this.playtime.AutoSize = true;
            this.playtime.Location = new System.Drawing.Point(434, 665);
            this.playtime.Name = "playtime";
            this.playtime.Size = new System.Drawing.Size(40, 19);
            this.playtime.TabIndex = 35;
            this.playtime.Text = "00:00";
            this.playtime.Click += new System.EventHandler(this.playtime_Click);
            // 
            // playtext
            // 
            this.playtext.AutoSize = true;
            this.playtext.ForeColor = System.Drawing.SystemColors.Highlight;
            this.playtext.Location = new System.Drawing.Point(136, 640);
            this.playtext.Name = "playtext";
            this.playtext.Size = new System.Drawing.Size(161, 19);
            this.playtext.TabIndex = 34;
            this.playtext.Text = "현재 재생중인 노래 없음";
            this.playtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.playtext.Click += new System.EventHandler(this.playtext_Click);
            // 
            // playbar
            // 
            this.playbar.BackColor = System.Drawing.Color.Transparent;
            this.playbar.Enabled = false;
            this.playbar.Location = new System.Drawing.Point(134, 664);
            this.playbar.Name = "playbar";
            this.playbar.Size = new System.Drawing.Size(293, 23);
            this.playbar.TabIndex = 33;
            this.playbar.Text = "metroTrackBar1";
            this.playbar.Value = 0;
            this.playbar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar1_Scroll);
            // 
            // btn_Random
            // 
            this.btn_Random.ActiveControl = null;
            this.btn_Random.Location = new System.Drawing.Point(454, 529);
            this.btn_Random.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Random.Name = "btn_Random";
            this.btn_Random.Size = new System.Drawing.Size(101, 46);
            this.btn_Random.TabIndex = 32;
            this.btn_Random.Text = "랜덤 BGM";
            this.btn_Random.UseSelectable = true;
            this.btn_Random.Click += new System.EventHandler(this.btn_Random_Click);
            // 
            // NowTime
            // 
            this.NowTime.AutoSize = true;
            this.NowTime.Location = new System.Drawing.Point(7, 619);
            this.NowTime.Name = "NowTime";
            this.NowTime.Size = new System.Drawing.Size(100, 19);
            this.NowTime.TabIndex = 31;
            this.NowTime.Text = "real_time_timer";
            this.NowTime.Click += new System.EventHandler(this.NowTime_Click);
            // 
            // Download_Count
            // 
            this.download_count.AutoSize = true;
            this.download_count.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.download_count.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.download_count.Location = new System.Drawing.Point(264, 593);
            this.download_count.Name = "download_count";
            this.download_count.Size = new System.Drawing.Size(28, 16);
            this.download_count.TabIndex = 25;
            this.download_count.Text = "0/0";
            // 
            // SearchOptionA
            // 
            this.SearchOptionA.Enabled = false;
            this.SearchOptionA.FormattingEnabled = true;
            this.SearchOptionA.ItemHeight = 23;
            this.SearchOptionA.Items.AddRange(new object[] {
            "제목",
            "주소"});
            this.SearchOptionA.Location = new System.Drawing.Point(7, 6);
            this.SearchOptionA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchOptionA.Name = "SearchOptionA";
            this.SearchOptionA.Size = new System.Drawing.Size(79, 29);
            this.SearchOptionA.TabIndex = 18;
            this.SearchOptionA.UseSelectable = true;
            // 
            // listView1
            // 
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.장르,
            this.제목,
            this.재생시간,
            this.추천수});
            this.listView1.Font = new System.Drawing.Font("나눔고딕", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(7, 36);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(583, 488);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged_1);
            this.listView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseClick);
            // 
            // 장르
            // 
            this.장르.Text = "장르";
            this.장르.Width = 75;
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
            // SearchOptionB
            // 
            this.SearchOptionB.Enabled = false;
            this.SearchOptionB.FormattingEnabled = true;
            this.SearchOptionB.ItemHeight = 23;
            this.SearchOptionB.Items.AddRange(new object[] {
            "일반검색",
            "단어로 검색",
            "완전일치"});
            this.SearchOptionB.Location = new System.Drawing.Point(91, 6);
            this.SearchOptionB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchOptionB.Name = "SearchOptionB";
            this.SearchOptionB.Size = new System.Drawing.Size(90, 29);
            this.SearchOptionB.TabIndex = 19;
            this.SearchOptionB.UseSelectable = true;
            // 
            // SearchTitle
            // 
            // 
            // 
            // 
            this.SearchTitle.CustomButton.Image = null;
            this.SearchTitle.CustomButton.Location = new System.Drawing.Point(264, 2);
            this.SearchTitle.CustomButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchTitle.CustomButton.Name = "";
            this.SearchTitle.CustomButton.Size = new System.Drawing.Size(19, 19);
            this.SearchTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.SearchTitle.CustomButton.TabIndex = 1;
            this.SearchTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.SearchTitle.CustomButton.UseSelectable = true;
            this.SearchTitle.CustomButton.Visible = false;
            this.SearchTitle.Lines = new string[0];
            this.SearchTitle.Location = new System.Drawing.Point(186, 6);
            this.SearchTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchTitle.MaxLength = 32767;
            this.SearchTitle.Name = "SearchTitle";
            this.SearchTitle.PasswordChar = '\0';
            this.SearchTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SearchTitle.SelectedText = "";
            this.SearchTitle.SelectionLength = 0;
            this.SearchTitle.SelectionStart = 0;
            this.SearchTitle.ShortcutsEnabled = true;
            this.SearchTitle.Size = new System.Drawing.Size(286, 24);
            this.SearchTitle.TabIndex = 20;
            this.SearchTitle.UseSelectable = true;
            this.SearchTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SearchTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.SearchTitle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTitle_KeyDown);
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(477, 6);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(78, 24);
            this.btn_Search.TabIndex = 21;
            this.btn_Search.Text = "검색";
            this.btn_Search.UseSelectable = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click_1);
            // 
            // btn_Moreload
            // 
            this.btn_Moreload.ActiveControl = null;
            this.btn_Moreload.Location = new System.Drawing.Point(7, 529);
            this.btn_Moreload.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Moreload.Name = "btn_Moreload";
            this.btn_Moreload.Size = new System.Drawing.Size(105, 46);
            this.btn_Moreload.TabIndex = 27;
            this.btn_Moreload.Text = "더보기(Next)";
            this.btn_Moreload.UseSelectable = true;
            this.btn_Moreload.Click += new System.EventHandler(this.btn_Moreload_Click);
            // 
            // btn_Download
            // 
            this.btn_Download.ActiveControl = null;
            this.btn_Download.Location = new System.Drawing.Point(342, 529);
            this.btn_Download.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Download.Name = "btn_Download";
            this.btn_Download.Size = new System.Drawing.Size(107, 46);
            this.btn_Download.TabIndex = 30;
            this.btn_Download.Text = "다운로드";
            this.btn_Download.UseSelectable = true;
            this.btn_Download.Click += new System.EventHandler(this.btn_Download_Click);
            // 
            // btn_AllCheck
            // 
            this.btn_AllCheck.ActiveControl = null;
            this.btn_AllCheck.Location = new System.Drawing.Point(119, 529);
            this.btn_AllCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_AllCheck.Name = "btn_AllCheck";
            this.btn_AllCheck.Size = new System.Drawing.Size(104, 46);
            this.btn_AllCheck.TabIndex = 28;
            this.btn_AllCheck.Text = "모두체크";
            this.btn_AllCheck.UseSelectable = true;
            this.btn_AllCheck.Click += new System.EventHandler(this.btn_AllCheck_Click);
            // 
            // btn_NoCheck
            // 
            this.btn_NoCheck.ActiveControl = null;
            this.btn_NoCheck.Location = new System.Drawing.Point(232, 529);
            this.btn_NoCheck.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NoCheck.Name = "btn_NoCheck";
            this.btn_NoCheck.Size = new System.Drawing.Size(103, 46);
            this.btn_NoCheck.TabIndex = 29;
            this.btn_NoCheck.Text = "모두체크해제";
            this.btn_NoCheck.UseSelectable = true;
            this.btn_NoCheck.Click += new System.EventHandler(this.btn_NoCheck_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(7, 585);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(549, 32);
            this.progressBar1.TabIndex = 26;
            // 
            // MediaPlay
            // 
            this.MediaPlay.Interval = 1000;
            this.MediaPlay.Tick += new System.EventHandler(this.MediaPlay_Tick);
            // 
            // slidedown
            // 
            this.slidedown.Interval = 1;
            this.slidedown.Tick += new System.EventHandler(this.slidedown_Tick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 796);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(18, 60, 18, 16);
            this.Resizable = false;
            this.Text = "BGMStore_Downloader";
            this.Load += new System.EventHandler(this.Main_Load);
            this._menu.ResumeLayout(false);
            this._listviewM.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroContextMenu _menu;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private MetroFramework.Controls.MetroContextMenu _listviewM;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 사이트열기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Timer MediaPlay;
        private System.Windows.Forms.Panel MainPanel;
        private MetroFramework.Controls.MetroLabel playctime;
        private System.Windows.Forms.Label pause;
        private System.Windows.Forms.Label stop;
        private System.Windows.Forms.Label play;
        private MetroFramework.Controls.MetroLabel playtime;
        private MetroFramework.Controls.MetroTrackBar playbar;
        private MetroFramework.Controls.MetroTile btn_Random;
        private MetroFramework.Controls.MetroLabel NowTime;
        private System.Windows.Forms.Label download_count;
        private MetroFramework.Controls.MetroComboBox SearchOptionA;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader 장르;
        private System.Windows.Forms.ColumnHeader 제목;
        private System.Windows.Forms.ColumnHeader 재생시간;
        private System.Windows.Forms.ColumnHeader 추천수;
        private MetroFramework.Controls.MetroComboBox SearchOptionB;
        private MetroFramework.Controls.MetroTextBox SearchTitle;
        private MetroFramework.Controls.MetroButton btn_Search;
        private MetroFramework.Controls.MetroTile btn_Moreload;
        private MetroFramework.Controls.MetroTile btn_Download;
        private MetroFramework.Controls.MetroTile btn_AllCheck;
        private MetroFramework.Controls.MetroTile btn_NoCheck;
        private MetroFramework.Controls.MetroProgressBar progressBar1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem 리스트추가ToolStripMenuItem;
        public MetroFramework.Controls.MetroLabel playtext;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel panel2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Timer slidedown;
    }
}