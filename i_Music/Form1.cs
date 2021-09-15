using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace i_Music
{
    public partial class Form1 : Form
    {
        //为解决歌词遮挡问题定义歌词下标为全局变量
        private int time_index = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //记录鼠标按下坐标
        private Point old_point;

        private void panel_win_MouseDown(object sender, MouseEventArgs e)
        {
            old_point = e.Location;
            panel_win.Tag = "1";
        }

        private void panel_win_MouseMove(object sender, MouseEventArgs e)
        {
            if (panel_win.Tag.ToString() == "1")
            {
                this.Location = new Point(this.Location.X + (e.X - old_point.X), this.Location.Y + (e.Y - old_point.Y));
            }
        }

        private void panel_win_MouseUp(object sender, MouseEventArgs e)
        {
            panel_win.Tag = "0";
        }

        private void pic_close_MouseLeave(object sender, EventArgs e)
        {
            pic_close.BackColor = Color.Transparent;
        }

        private void pic_close_MouseEnter(object sender, EventArgs e)
        {
            pic_close.BackColor = Color.Red;
        }
        //关闭
        private void pic_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //最小化
        private void pic_mini_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 重绘ListView表头
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            int index = e.ColumnIndex;
            e.Graphics.FillRectangle(new SolidBrush(Color.FromArgb(27, 27, 27)), e.Bounds);
            TextRenderer.DrawText(e.Graphics, listView1.Columns[index].Text, new Font("微软雅黑", 10),
                e.Bounds, Color.Gray, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            Pen pen = new Pen(Color.FromArgb(34, 35, 39), 2);
            Point p = new Point(e.Bounds.Left - 1, e.Bounds.Top + 1);
            Size s = new Size(e.Bounds.Width, e.Bounds.Height - 2);
            Rectangle r = new Rectangle(p, s);
            e.Graphics.DrawRectangle(pen, r);
        }

        /// <summary>
        /// 重绘ListView SubItem
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listView1_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            int index = e.ItemIndex;
            if (index == -1)
                return;
            //间隔颜色
            if (index % 2 == 0)
            {
                e.SubItem.BackColor = Color.FromArgb(185, 227, 217);
                e.DrawBackground();
            }
            else
            {
                e.SubItem.BackColor = Color.FromArgb(175, 216, 238);
                e.DrawBackground();
            }

            if (e.ColumnIndex == 1)
                e.SubItem.ForeColor = Color.FromArgb(35, 31, 32);
            else
                e.SubItem.ForeColor = Color.Gray;

            if (e.Item.Selected)
            {
                using (SolidBrush brush = new SolidBrush(Color.FromArgb(173, 195, 192)))
                {
                    e.Graphics.FillRectangle(brush, e.Bounds);
                }
            }

            if (!string.IsNullOrWhiteSpace(e.SubItem.Text))
            {
                TextRenderer.DrawText(e.Graphics, e.SubItem.Text, new Font("微软雅黑", 10), e.Bounds
                    , e.SubItem.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }
        }

        //列表展开/隐藏
        private void pic_up_Click(object sender, EventArgs e)
        {
            if (pic_up.Tag.ToString() == "0")
            {
                listView1.Visible = true;
                panel_list.Visible = true;
                freshList(axWindowsMediaPlayer, listView1);
                pic_up.Tag = "1";
            }
            else
            {
                listView1.Visible = false;
                panel_list.Visible = false;
                pic_up.Tag = "0";
            }
        }

        //保存单行歌词
        private List<string> list_lyrics = new List<string>();
        //保存时间
        private List<string> list_time = new List<string>();
        //保存文件路径
        private List<string> list_path = new List<string>();
        /// <summary>
        /// 添加歌单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pic_add_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择音乐文件哟亲(づ￣3￣)づ╭❤～  (支持多选)";
            ofd.Filter = "MP3文件|*.mp3|WAV文件|*.wav|所有文件|*.*";
            ofd.Multiselect = true;
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                int count = axWindowsMediaPlayer.currentPlaylist.count;

                string[] path = ofd.FileNames;

                for (int i = 0; i < path.Length; i++)
                {
                    if (list_path.Contains(path[i]))
                        continue;

                    list_path.Add(path[i]);
                    WMPLib.IWMPMedia new_media = axWindowsMediaPlayer.newMedia(path[i]);
                    axWindowsMediaPlayer.currentPlaylist.appendItem(new_media);
                    
                }
                if (count == 0)
                    axWindowsMediaPlayer.Ctlcontrols.play();
            }
            freshList(axWindowsMediaPlayer, listView1);
        }

        /// <summary>
        /// 刷新歌单列表
        /// </summary>
        /// <param name="media">当前媒体播放控件</param>
        /// <param name="listView">添加到的列表</param>
        private void freshList(AxWMPLib.AxWindowsMediaPlayer media, ListView listView)
        {
            listView.Items.Clear();
            if (axWindowsMediaPlayer.currentPlaylist.count == 0)
                return;
            for (int i = 0; i < media.currentPlaylist.count; i++)
            {
                listView.Items.Add((i + 1).ToString());
                string name = media.currentPlaylist.Item[i].getItemInfo("Title");
                string author = media.currentPlaylist.Item[i].getItemInfo("Author");
                string time = media.currentPlaylist.Item[i].durationString;
                string type = media.currentPlaylist.Item[i].getItemInfo("FileType");
                listView.Items[i].SubItems.Add(name);
                listView.Items[i].SubItems.Add(author);                
                listView.Items[i].SubItems.Add(time);
                listView.Items[i].SubItems.Add(type);
            }            
            string source_url = axWindowsMediaPlayer.currentMedia.sourceURL;
            int index = list_path.IndexOf(source_url);
            listView1.Items[index].Selected = true;
        }

        //删除选中歌曲
        private void pic_delete_Click(object sender, EventArgs e)
        {
            for (int i = listView1.Items.Count - 1; i >= 0; i--)
            {
                if (listView1.Items[i].Selected)
                {
                    listView1.Items.RemoveAt(i);
                    list_path.RemoveAt(i);
                    WMPLib.IWMPMedia media = axWindowsMediaPlayer.currentPlaylist.Item[i];
                    axWindowsMediaPlayer.currentPlaylist.removeItem(media);
                }
            }
            freshList(axWindowsMediaPlayer, listView1);
        }

        //双击列表播放音乐
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            int index = 0;
            foreach (ListViewItem item in listView1.Items)
            {
                if (item.Selected == true)
                {
                    axWindowsMediaPlayer.Ctlcontrols.playItem(axWindowsMediaPlayer.currentPlaylist.Item[index]);
                    break;
                }
                index++;
            }
            pic_draw.Refresh();
        }

        //播放与暂停
        private void pic_play_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer.currentPlaylist.count == 0)
                return;
            if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
            else if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer.Ctlcontrols.pause();
            }
            else if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsReady)
            {
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
            else if(axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                axWindowsMediaPlayer.Ctlcontrols.play();
            }
        }

        //下一曲
        private void pic_next_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer.currentPlaylist.count == 0)
                return;
            axWindowsMediaPlayer.Ctlcontrols.next();
            freshList(axWindowsMediaPlayer, listView1);
            pic_draw.Refresh();
        }

        //上一曲
        private void pic_last_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer.currentPlaylist.count == 0)
                return;
            axWindowsMediaPlayer.Ctlcontrols.previous();
            freshList(axWindowsMediaPlayer, listView1);
            pic_draw.Refresh();
        }

        /// <summary>
        /// 加载歌词
        /// </summary>
        /// <param name="path">歌曲路径</param>
        /// <param name="lyrics">存储歌词的list</param>
        /// <param name="timeOfLyrics">存储歌词时间的list</param>
        private bool loadLrc(string path, List<string> lyrics, List<string> timeOfLyrics)
        {
            if (axWindowsMediaPlayer.currentPlaylist.count == 0)
                return false;

            lyrics.Clear();
            timeOfLyrics.Clear();
            string path_lrc = path.Split('.')[0] + ".lrc";
            try
            {
                lyrics.Add("");
                lyrics.Add("");
                lyrics.Add("");
                using (StreamReader sr = new StreamReader(path_lrc, Encoding.GetEncoding("GB2312")))
                {
                    string line;
                    while (!sr.EndOfStream)
                    {
                        line = sr.ReadLine();
                        if (line == "")
                        {
                            continue;
                        }
                        string[] info = line.Split('[', '.', ']');
                        lyrics.Add(info[3]);
                        timeOfLyrics.Add(info[1]);                        
                    }
                }
                lyrics.Add("");
                lyrics.Add("");
                lyrics.Add("");
                return true;
            }
            catch (FileNotFoundException)
            {
                return false;
            }
        }

        /// <summary>
        /// 绘制歌词
        /// </summary>
        /// <param name="sender">所绘控件</param>
        /// <param name="e">PaintEventArgs</param>
        private void pic_draw_Paint(object sender, PaintEventArgs e)
        {
            if (axWindowsMediaPlayer.currentPlaylist.count == 0)
                return;

            if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPaused)
                return;

            if(axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                pic_draw.Refresh();
                return;
            }

            e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
            float x = pic_draw.Width / 2;
            float y = 25.0f;
            Font font = new Font("宋体", 14);
            Font font_now = new Font("宋体", 17);
            StringFormat format = new StringFormat();
            format.Alignment = StringAlignment.Center;//文本居中对齐
            SolidBrush brush = new SolidBrush(Color.White);
            SolidBrush brush_now = new SolidBrush(Color.LightPink);
            Rectangle rectangle1 = new Rectangle(0, 15, 380, 110);
            Rectangle rectangle2 = new Rectangle(0, 130, 380, 110);
            LinearGradientBrush lgb1 = new LinearGradientBrush(rectangle1, Color.FromArgb(212, 212, 212), Color.SkyBlue,
                LinearGradientMode.Vertical);
            LinearGradientBrush lgb2 = new LinearGradientBrush(rectangle2, Color.SkyBlue, Color.FromArgb(212, 212, 212), 
                LinearGradientMode.Vertical);

            if (!loadLrc(axWindowsMediaPlayer.currentMedia.sourceURL, list_lyrics, list_time))
            {
                string str = "无法找到本地歌词\n请将歌曲与歌词放在同一文件夹下";
                e.Graphics.DrawString(str, font, brush, x, pic_draw.Height / 2 - 20, format);
                return;
            }

            string current_position = axWindowsMediaPlayer.Ctlcontrols.currentPositionString;

            
            if (list_time.IndexOf(current_position) != -1)
            {
                pic_draw.Refresh();
                time_index = list_time.IndexOf(current_position);
            }

            for (int i = 0; i < 7; i++)
            {
                //当前歌词高亮
                if (i == 3)
                    e.Graphics.DrawString(list_lyrics[i + time_index], font_now, brush_now, x, y, format);
                
                //绘制渐变色
                else if(i<3)
                    e.Graphics.DrawString(list_lyrics[i + time_index], font, lgb1, x, y, format);
                else
                    e.Graphics.DrawString(list_lyrics[i + time_index], font, lgb2, x, y, format);
                    
                y += 30;
            }

            if (time_index > 5)
            {
                string title = axWindowsMediaPlayer.currentMedia.getItemInfo("Title");
                string author = axWindowsMediaPlayer.currentMedia.getItemInfo("Author");
                e.Graphics.DrawString(title, font_now, brush, x, y+60, format);
                e.Graphics.DrawString(author, font, brush, x, y + 90, format);
            }

            //释放非托管资源                
            font.Dispose();
            font_now.Dispose();
            lgb1.Dispose();
            lgb2.Dispose();
            format.Dispose();
            brush.Dispose();
            brush_now.Dispose();
        }

        private void axWindowsMediaPlayer_MediaChange(object sender, AxWMPLib._WMPOCXEvents_MediaChangeEvent e)
        {
            
            time_index = 0;
        }

        //循环模式
        private void pic_mode_Click(object sender, EventArgs e)
        {
            if (pic_mode.Tag.ToString() == "顺序播放")
            {
                axWindowsMediaPlayer.settings.setMode("shuffle", true);
                pic_mode.Tag = "随机播放";
            }
                
            else if (pic_mode.Tag.ToString() == "随机播放")
            {
                axWindowsMediaPlayer.settings.setMode("loop", true);
                pic_mode.Tag = "循环播放";                
            }

            else
            {
                axWindowsMediaPlayer.settings.setMode("shuffle", false);
                pic_mode.Tag = "顺序播放";
            }
        }

        //控制歌词滚动、图标变化、提示词变化
        private void timer_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                toolTip1.SetToolTip(pic_play, "暂停");
                pic_play.BackgroundImage = Properties.Resources.pause;
            }
            else
            {
                toolTip1.SetToolTip(pic_play, "播放");
                pic_play.BackgroundImage = Properties.Resources.play;
            }
            
            using (PaintEventArgs paintEvent = new PaintEventArgs(pic_draw.CreateGraphics(), pic_draw.Bounds))
            {
                pic_draw_Paint(sender, paintEvent);
            }

            if(axWindowsMediaPlayer.currentPlaylist.count == 0)
            {
                label_time.Text = "00:00 / 00:00";
            }
            else
            {
                string now_time = axWindowsMediaPlayer.Ctlcontrols.currentPositionString;
                label_time.Text = now_time + " / " + axWindowsMediaPlayer.currentMedia.durationString;
            }

            if (pic_mode.Tag.ToString() == "循环播放")
            {
                pic_mode.BackgroundImage = Properties.Resources.loop;
            }
            else if (pic_mode.Tag.ToString() == "随机播放")
            {
                pic_mode.BackgroundImage = Properties.Resources.suiji;
            }
            else
            {
                pic_mode.BackgroundImage = Properties.Resources.shunxu;
            }
            toolTip1.SetToolTip(pic_mode, pic_mode.Tag.ToString());

            if (pic_up.Tag.ToString() == "0")
                toolTip1.SetToolTip(pic_up, "展开歌单列表");
            else
                toolTip1.SetToolTip(pic_up, "收起歌单列表");
        }
        
        private void pic_draw_Click(object sender, EventArgs e)
        {
            panel_list.Visible = false;
            listView1.Visible = false;
            pic_up.Tag = "0";
        }

        //主窗体事件
        private void Form1_Load(object sender, EventArgs e)
        {
            //初始化播放方式
            axWindowsMediaPlayer.settings.setMode("loop", true);
            axWindowsMediaPlayer.settings.volume = 100;
        }
    }
}