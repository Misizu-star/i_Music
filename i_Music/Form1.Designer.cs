namespace i_Music
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel_win = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_mini = new System.Windows.Forms.PictureBox();
            this.pic_close = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.pic_mode = new System.Windows.Forms.PictureBox();
            this.pic_last = new System.Windows.Forms.PictureBox();
            this.pic_play = new System.Windows.Forms.PictureBox();
            this.pic_next = new System.Windows.Forms.PictureBox();
            this.pic_up = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.panel_list = new System.Windows.Forms.Panel();
            this.pic_add = new System.Windows.Forms.PictureBox();
            this.pic_delete = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pic_down = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pic_draw = new System.Windows.Forms.PictureBox();
            this.label_time = new System.Windows.Forms.Label();
            this.panel_win.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mini)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_last)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_play)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_next)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_up)).BeginInit();
            this.panel_list.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_add)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_delete)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_draw)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_win
            // 
            this.panel_win.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panel_win.Controls.Add(this.label1);
            this.panel_win.Controls.Add(this.pictureBox2);
            this.panel_win.Controls.Add(this.pic_mini);
            this.panel_win.Controls.Add(this.pic_close);
            this.panel_win.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_win.Location = new System.Drawing.Point(0, 0);
            this.panel_win.Name = "panel_win";
            this.panel_win.Size = new System.Drawing.Size(400, 30);
            this.panel_win.TabIndex = 0;
            this.panel_win.Tag = "0";
            this.panel_win.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_win_MouseDown);
            this.panel_win.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_win_MouseMove);
            this.panel_win.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_win_MouseUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(32, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 19);
            this.label1.TabIndex = 4;
            this.label1.Text = "i_Music";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::i_Music.Properties.Resources.i_music;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.pictureBox2, "最小化");
            // 
            // pic_mini
            // 
            this.pic_mini.BackColor = System.Drawing.Color.Transparent;
            this.pic_mini.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_mini.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_mini.Image = global::i_Music.Properties.Resources.mini;
            this.pic_mini.Location = new System.Drawing.Point(340, 0);
            this.pic_mini.Name = "pic_mini";
            this.pic_mini.Padding = new System.Windows.Forms.Padding(5);
            this.pic_mini.Size = new System.Drawing.Size(30, 30);
            this.pic_mini.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_mini.TabIndex = 2;
            this.pic_mini.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_mini, "最小化");
            this.pic_mini.Click += new System.EventHandler(this.pic_mini_Click);
            // 
            // pic_close
            // 
            this.pic_close.BackColor = System.Drawing.Color.Transparent;
            this.pic_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_close.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_close.Image = ((System.Drawing.Image)(resources.GetObject("pic_close.Image")));
            this.pic_close.Location = new System.Drawing.Point(370, 0);
            this.pic_close.Name = "pic_close";
            this.pic_close.Padding = new System.Windows.Forms.Padding(5);
            this.pic_close.Size = new System.Drawing.Size(30, 30);
            this.pic_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_close.TabIndex = 1;
            this.pic_close.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_close, "关闭");
            this.pic_close.Click += new System.EventHandler(this.pic_close_Click);
            this.pic_close.MouseEnter += new System.EventHandler(this.pic_close_MouseEnter);
            this.pic_close.MouseLeave += new System.EventHandler(this.pic_close_MouseLeave);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panel1.Controls.Add(this.label_time);
            this.panel1.Controls.Add(this.axWindowsMediaPlayer);
            this.panel1.Controls.Add(this.pic_mode);
            this.panel1.Controls.Add(this.pic_last);
            this.panel1.Controls.Add(this.pic_play);
            this.panel1.Controls.Add(this.pic_next);
            this.panel1.Controls.Add(this.pic_up);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 465);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 55);
            this.panel1.TabIndex = 1;
            // 
            // axWindowsMediaPlayer
            // 
            this.axWindowsMediaPlayer.Enabled = true;
            this.axWindowsMediaPlayer.Location = new System.Drawing.Point(125, 25);
            this.axWindowsMediaPlayer.Name = "axWindowsMediaPlayer";
            this.axWindowsMediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer.OcxState")));
            this.axWindowsMediaPlayer.Size = new System.Drawing.Size(200, 45);
            this.axWindowsMediaPlayer.TabIndex = 8;
            this.axWindowsMediaPlayer.TabStop = false;
            this.axWindowsMediaPlayer.MediaChange += new AxWMPLib._WMPOCXEvents_MediaChangeEventHandler(this.axWindowsMediaPlayer_MediaChange);
            // 
            // pic_mode
            // 
            this.pic_mode.BackColor = System.Drawing.Color.Transparent;
            this.pic_mode.BackgroundImage = global::i_Music.Properties.Resources.loop;
            this.pic_mode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_mode.Location = new System.Drawing.Point(335, 17);
            this.pic_mode.Name = "pic_mode";
            this.pic_mode.Size = new System.Drawing.Size(20, 20);
            this.pic_mode.TabIndex = 10;
            this.pic_mode.TabStop = false;
            this.pic_mode.Tag = "循环播放";
            this.toolTip1.SetToolTip(this.pic_mode, "循环播放");
            this.pic_mode.Click += new System.EventHandler(this.pic_mode_Click);
            // 
            // pic_last
            // 
            this.pic_last.BackColor = System.Drawing.Color.Transparent;
            this.pic_last.BackgroundImage = global::i_Music.Properties.Resources.last;
            this.pic_last.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_last.Location = new System.Drawing.Point(6, 12);
            this.pic_last.Name = "pic_last";
            this.pic_last.Size = new System.Drawing.Size(30, 30);
            this.pic_last.TabIndex = 9;
            this.pic_last.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_last, "上一曲");
            this.pic_last.Click += new System.EventHandler(this.pic_last_Click);
            // 
            // pic_play
            // 
            this.pic_play.BackColor = System.Drawing.Color.Transparent;
            this.pic_play.BackgroundImage = global::i_Music.Properties.Resources.play;
            this.pic_play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_play.Location = new System.Drawing.Point(44, 12);
            this.pic_play.Name = "pic_play";
            this.pic_play.Size = new System.Drawing.Size(30, 30);
            this.pic_play.TabIndex = 8;
            this.pic_play.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_play, "播放");
            this.pic_play.Click += new System.EventHandler(this.pic_play_Click);
            // 
            // pic_next
            // 
            this.pic_next.BackColor = System.Drawing.Color.Transparent;
            this.pic_next.BackgroundImage = global::i_Music.Properties.Resources.next;
            this.pic_next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_next.Location = new System.Drawing.Point(82, 12);
            this.pic_next.Name = "pic_next";
            this.pic_next.Size = new System.Drawing.Size(30, 30);
            this.pic_next.TabIndex = 7;
            this.pic_next.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_next, "下一曲");
            this.pic_next.Click += new System.EventHandler(this.pic_next_Click);
            // 
            // pic_up
            // 
            this.pic_up.BackColor = System.Drawing.Color.Transparent;
            this.pic_up.BackgroundImage = global::i_Music.Properties.Resources.list;
            this.pic_up.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_up.Location = new System.Drawing.Point(364, 13);
            this.pic_up.Name = "pic_up";
            this.pic_up.Size = new System.Drawing.Size(28, 28);
            this.pic_up.TabIndex = 2;
            this.pic_up.TabStop = false;
            this.pic_up.Tag = "0";
            this.toolTip1.SetToolTip(this.pic_up, "展开歌单列表");
            this.pic_up.Click += new System.EventHandler(this.pic_up_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 32);
            this.panel2.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.listView1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 240);
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Size = new System.Drawing.Size(400, 225);
            this.listView1.SmallImageList = this.imageList;
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Visible = false;
            this.listView1.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.listView1_DrawColumnHeader);
            this.listView1.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.listView1_DrawSubItem);
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "";
            this.columnHeader1.Width = 20;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "歌单列表";
            this.columnHeader2.Width = 160;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "作者";
            this.columnHeader3.Width = 120;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "时长";
            this.columnHeader4.Width = 55;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "格式";
            this.columnHeader5.Width = 50;
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 35);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // panel_list
            // 
            this.panel_list.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.panel_list.Controls.Add(this.pic_add);
            this.panel_list.Controls.Add(this.pic_delete);
            this.panel_list.Controls.Add(this.pictureBox4);
            this.panel_list.Controls.Add(this.pictureBox1);
            this.panel_list.Controls.Add(this.pic_down);
            this.panel_list.Location = new System.Drawing.Point(0, 215);
            this.panel_list.Name = "panel_list";
            this.panel_list.Size = new System.Drawing.Size(400, 25);
            this.panel_list.TabIndex = 7;
            this.panel_list.Visible = false;
            // 
            // pic_add
            // 
            this.pic_add.BackColor = System.Drawing.Color.Transparent;
            this.pic_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_add.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_add.Image = global::i_Music.Properties.Resources.add;
            this.pic_add.Location = new System.Drawing.Point(325, 0);
            this.pic_add.Name = "pic_add";
            this.pic_add.Padding = new System.Windows.Forms.Padding(1);
            this.pic_add.Size = new System.Drawing.Size(25, 25);
            this.pic_add.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_add.TabIndex = 6;
            this.pic_add.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_add, "添加歌曲");
            this.pic_add.Click += new System.EventHandler(this.pic_add_Click);
            // 
            // pic_delete
            // 
            this.pic_delete.BackColor = System.Drawing.Color.Transparent;
            this.pic_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_delete.Dock = System.Windows.Forms.DockStyle.Left;
            this.pic_delete.Image = global::i_Music.Properties.Resources.delete;
            this.pic_delete.Location = new System.Drawing.Point(25, 0);
            this.pic_delete.Name = "pic_delete";
            this.pic_delete.Padding = new System.Windows.Forms.Padding(2);
            this.pic_delete.Size = new System.Drawing.Size(28, 25);
            this.pic_delete.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_delete.TabIndex = 5;
            this.pic_delete.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_delete, "删除选中歌曲");
            this.pic_delete.Click += new System.EventHandler(this.pic_delete_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 25);
            this.pictureBox4.TabIndex = 4;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Location = new System.Drawing.Point(350, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 25);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pic_down
            // 
            this.pic_down.BackColor = System.Drawing.Color.Transparent;
            this.pic_down.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pic_down.Dock = System.Windows.Forms.DockStyle.Right;
            this.pic_down.Image = ((System.Drawing.Image)(resources.GetObject("pic_down.Image")));
            this.pic_down.Location = new System.Drawing.Point(375, 0);
            this.pic_down.Name = "pic_down";
            this.pic_down.Padding = new System.Windows.Forms.Padding(2);
            this.pic_down.Size = new System.Drawing.Size(25, 25);
            this.pic_down.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_down.TabIndex = 3;
            this.pic_down.TabStop = false;
            this.toolTip1.SetToolTip(this.pic_down, "收起列表");
            this.pic_down.Click += new System.EventHandler(this.pic_up_Click);
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 5000;
            this.toolTip1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.toolTip1.InitialDelay = 10;
            this.toolTip1.ReshowDelay = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.panel3.Location = new System.Drawing.Point(125, 503);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 17);
            this.panel3.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(10, 350);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pic_draw
            // 
            this.pic_draw.BackColor = System.Drawing.Color.Transparent;
            this.pic_draw.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_draw.Location = new System.Drawing.Point(0, 62);
            this.pic_draw.Name = "pic_draw";
            this.pic_draw.Size = new System.Drawing.Size(400, 371);
            this.pic_draw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_draw.TabIndex = 9;
            this.pic_draw.TabStop = false;
            this.pic_draw.Click += new System.EventHandler(this.pic_draw_Click);
            this.pic_draw.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_draw_Paint);
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.BackColor = System.Drawing.Color.Transparent;
            this.label_time.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label_time.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_time.ForeColor = System.Drawing.Color.White;
            this.label_time.Location = new System.Drawing.Point(121, 3);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(0, 17);
            this.label_time.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImage = global::i_Music.Properties.Resources.bg_1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(400, 520);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_list);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_draw);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel_win);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "i_Music";
            this.panel_win.ResumeLayout(false);
            this.panel_win.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mini)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_close)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_mode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_last)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_play)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_next)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_up)).EndInit();
            this.panel_list.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_add)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_delete)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_draw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_win;
        private System.Windows.Forms.PictureBox pic_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.PictureBox pic_mini;
        private System.Windows.Forms.PictureBox pic_last;
        private System.Windows.Forms.PictureBox pic_play;
        private System.Windows.Forms.PictureBox pic_next;
        private System.Windows.Forms.PictureBox pic_up;
        private System.Windows.Forms.Panel panel_list;
        private System.Windows.Forms.PictureBox pic_delete;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pic_down;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer;
        private System.Windows.Forms.PictureBox pic_add;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox pic_mode;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.PictureBox pic_draw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label_time;
    }
}

