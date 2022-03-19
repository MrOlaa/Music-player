using Music_player.Playlist;
using Music_player.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music_player
{
    public partial class F_Main : Form
    {
        public F_Main()
        {
            InitializeComponent();
        }
        private static string[] path;
        private static string pathLogfiles = @"E:\Project\Music-player\Music-player\Data\Logfiles.txt";
        private static bool isPlay, isVolume;

        private ItemPlayList item = new ItemPlayList();
        private List<string> album = File.ReadAllLines(pathLogfiles).ToList();

        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();

        [Obsolete]
        private void F_Main_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            
            foreach (var listalbum in album)
            {
                TagLib.File files = TagLib.File.Create(listalbum);

                item = new ItemPlayList();

                if(files.Tag.Title == null)
                {
                    item.SongName = files.Name;
                }
                else
                {
                    item.SongName = files.Tag.Title;
                }
                if (files.Tag.FirstArtist == null)
                {
                    item.AuthorName = "";
                }
                else
                {
                    item.AuthorName = files.Tag.FirstArtist;
                }
                if (files.Properties.Duration.Hours > 0)
                {
                    var time = files.Properties.Duration.ToString();
                    DateTime a = Convert.ToDateTime(time);
                    item.Time = a.ToString("hh:mm:ss");
                }
                else
                {
                    var time = files.Properties.Duration.ToString();
                    DateTime a = Convert.ToDateTime(time);
                    item.Time = a.ToString("mm:ss");
                }
               
                if (files.Tag.Pictures.Length >= 1)
                {
                    var bin = files.Tag.Pictures[0].Data.Data;
                    item.Thumbnail = Image.FromStream(new MemoryStream(bin));
                }
                else
                {
                    item.Thumbnail = Resources.bg_music;
                }
                

                item.onAction += new EventHandler(BtnPlayList_Click);
                item.Name = listalbum;

                
                flowLayoutPanel1.Controls.Add(item);
                flowLayoutPanel1.Refresh();
            }
            Bunifu.Utils.ScrollbarBinder.BindPanel(flowLayoutPanel1, scroll_bar);
        }

        [Obsolete]
        private void btn_openfiles_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Multiselect = true;

            if (openfile.ShowDialog() == DialogResult.OK)
            {
                path = openfile.FileNames;

                for (int i = 0; i < path.Length; i++)
                {
                    album.Add(path[i]);
                    File.WriteAllLines(pathLogfiles, album.Distinct().ToArray());
                }
                flowLayoutPanel1.Controls.Clear();
                F_Main_Load(sender, e);
            }
        }
        [Obsolete]
        private void BtnPlayList_Click(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is ItemPlayList)
                {
                    ((ItemPlayList)c).isPlaying = false;
                }
            }

            var action = (sender as ItemPlayList);
            var file = TagLib.File.Create(action.Name);
            action.isPlaying = !action.isPlaying;
            
            if (action.isPlaying == true)
            {
                isPlay = true;
                wplayer.URL = action.Name;

                panel3.Visible = true;
                btn_playing.Image = Resources.pause_50px;
                lb_songName.Visible = true;
                lb_author.Visible = true;
                p_barTime.Visible = true;
                btn_next.Visible = true;
                btn_playing.Visible = true;
                btn_preview.Visible = true;
                btn_volume.Visible = true;
                p_volume.Visible = true;

                lb_songName.Text = file.Tag.Title;
                lb_author.Text = file.Tag.FirstArtist;

                wplayer.controls.play();
            }
            else
            {
                isPlay = false;
                wplayer.controls.pause();

                action.isPlaying = false;
            }

            img_art.Visible = true;
            


            if (file.Tag.Pictures.Length >= 1)
            {
                var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                
                img_art.Image = Image.FromStream(new MemoryStream(bin));
                thumbnail.Image = Image.FromStream(new MemoryStream(bin));
            }
            else
            {
                img_art.Image = Resources.bg_music;
                thumbnail.Image = Resources.bg_music;
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_max_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if(this.WindowState == FormWindowState.Minimized)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        [Obsolete]
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(wplayer.playState == WMPLib.WMPPlayState.wmppsPlaying || wplayer.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                p_barTime.Maximum = (int)wplayer.controls.currentItem.duration;
                p_barTime.Value = (int)wplayer.controls.currentPosition;

                lb_start.Text = wplayer.controls.currentPositionString.ToString();
                lb_end.Text = wplayer.controls.currentItem.durationString.ToString();
            }
            if (wplayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                foreach (Control c in flowLayoutPanel1.Controls)
                {
                    if (c is ItemPlayList)
                    {
                        var pathname = ((ItemPlayList)c).Name;
                        var songName = ((ItemPlayList)c).SongName;

                        if (songName == lb_songName.Text)
                        {
                            for (int i = 0; i < album.Count; i++)
                            {
                                if (pathname == album[i])
                                {
                                    bool checkImg = false;
                                    foreach (Control d in flowLayoutPanel1.Controls)
                                    {
                                        if (d is ItemPlayList)
                                        {
                                            ((ItemPlayList)d).isPlaying = false;
                                            var fname = ((ItemPlayList)d).Name;
                                            try
                                            {
                                                if (fname == album[i + 1])
                                                {
                                                    ((ItemPlayList)d).isPlaying = true;

                                                    wplayer.URL = album[i + 1];
                                                    wplayer.controls.play();
                                                    break;
                                                }
                                            }
                                            catch
                                            {
                                                checkImg = true;
                                                if (fname == album[0])
                                                {
                                                    ((ItemPlayList)d).isPlaying = true;

                                                    wplayer.URL = album[0];
                                                    wplayer.controls.play();

                                                }
                                            }
                                        }
                                    }
                                    isPlay = true;

                                    panel3.Visible = true;
                                    btn_playing.Image = Resources.pause_50px;
                                    lb_songName.Visible = true;
                                    lb_author.Visible = true;
                                    img_art.Visible = true;

                                    

                                    try
                                    {
                                        var file = TagLib.File.Create(album[i]);

                                        if (checkImg == true)
                                        {
                                            file = TagLib.File.Create(album[0]);
                                        }
                                        else
                                        {
                                            file = TagLib.File.Create(album[i + 1]);
                                        }

                                        

                                        if (file.Tag.Pictures.Length >= 1)
                                        {
                                            var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                                            lb_songName.Text = file.Tag.Title;
                                            lb_author.Text = file.Tag.FirstArtist;
                                            img_art.Image = Image.FromStream(new MemoryStream(bin));
                                            thumbnail.Image = Image.FromStream(new MemoryStream(bin));
                                        }
                                        else
                                        {
                                            lb_songName.Text = file.Tag.Title;
                                            lb_author.Text = file.Tag.FirstArtist;
                                            img_art.Image = Resources.bg_music;
                                            thumbnail.Image = Resources.bg_music;
                                        }
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.ToString());
                                    }
                                    break;
                                }
                            }
                            break;
                        }
                    }
                }
            }
        }
        private void btn_playing_Click(object sender, EventArgs e)
        {
            loadPlaying();
        }
        private void loadPlaying()
        {
            if (isPlay == true)
            {
                btn_playing.Image = Resources.play_50px;
                isPlay = false;

                wplayer.controls.pause();
            }
            else
            {
                btn_playing.Image = Resources.pause_50px;
                isPlay = true;

                wplayer.controls.play();
            }
        }
        private void p_barTime_MouseDown(object sender, MouseEventArgs e)
        {
            wplayer.controls.currentPosition = wplayer.currentMedia.duration * e.X / p_barTime.Width;
        }

        [Obsolete]
        private void btn_next_Click(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is ItemPlayList)
                {               
                    var pathname = ((ItemPlayList)c).Name;
                    var songName = ((ItemPlayList)c).SongName;

                    if (songName == lb_songName.Text)
                    {
                        for (int i = 0; i < album.Count; i++)
                        {
                            if (pathname == album[i])
                            {
                                bool checkImg = false;
                                foreach (Control d in flowLayoutPanel1.Controls)
                                {
                                    if (d is ItemPlayList)
                                    {
                                        ((ItemPlayList)d).isPlaying = false;
                                        var fname = ((ItemPlayList)d).Name;
                                        try
                                        {
                                            if (fname == album[i + 1])
                                            {
                                                ((ItemPlayList)d).isPlaying = true;

                                                wplayer.URL = album[i + 1];
                                                wplayer.controls.play();
                                                break;
                                            }
                                        }
                                        catch
                                        {
                                            checkImg = true;
                                            if (fname == album[0])
                                            {
                                                ((ItemPlayList)d).isPlaying = true;

                                                wplayer.URL = album[0];
                                                wplayer.controls.play();
                                                
                                            }
                                        }
                                    }
                                }
                                isPlay = true;

                                panel3.Visible = true;
                                btn_playing.Image = Resources.pause_50px;
                                lb_songName.Visible = true;
                                lb_author.Visible = true;
                                img_art.Visible = true;

                                try
                                {
                                    var file = TagLib.File.Create(album[i]);
                                    
                                    if(checkImg == true)
                                    {
                                        file = TagLib.File.Create(album[0]);
                                    }
                                    else
                                    {
                                        file = TagLib.File.Create(album[i + 1]);
                                    }
                                    
                                   

                                    if (file.Tag.Pictures.Length >= 1)
                                    {
                                        var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                                        lb_songName.Text = file.Tag.Title;
                                        lb_author.Text = file.Tag.FirstArtist;
                                        img_art.Image = Image.FromStream(new MemoryStream(bin));
                                        thumbnail.Image = Image.FromStream(new MemoryStream(bin));
                                    }
                                    else
                                    {
                                        lb_songName.Text = file.Tag.Title;
                                        lb_author.Text = file.Tag.FirstArtist;
                                        img_art.Image = Resources.bg_music;
                                        thumbnail.Image = Resources.bg_music;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }
                                break;
                            }
                        }
                        break; 
                    }
                }
            }
        }

        [Obsolete]
        private void btn_preview_Click(object sender, EventArgs e)
        {
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                if (c is ItemPlayList)
                {
                    var pathname = ((ItemPlayList)c).Name;
                    var songName = ((ItemPlayList)c).SongName;

                    if (songName == lb_songName.Text)
                    {
                        for (int i = 0; i < album.Count; i++)
                        {
                            if (pathname == album[i])
                            {
                                bool checkImg = false;
                                foreach (Control d in flowLayoutPanel1.Controls)
                                {
                                    if (d is ItemPlayList)
                                    {
                                        ((ItemPlayList)d).isPlaying = false;
                                        var fname = ((ItemPlayList)d).Name;
                                        try
                                        {
                                            if (fname == album[i - 1])
                                            {
                                                ((ItemPlayList)d).isPlaying = true;

                                                wplayer.URL = album[i - 1];
                                                wplayer.controls.play();
                                            }
                                        }
                                        catch
                                        {
                                            checkImg = true;
                                            if (fname == album[album.Count - 1])
                                            {
                                                ((ItemPlayList)d).isPlaying = true;

                                                wplayer.URL = album[album.Count - 1];
                                                wplayer.controls.play();
                                            }
                                        }
                                    }
                                }
                                isPlay = true;

                                panel3.Visible = true;
                                btn_playing.Image = Resources.pause_50px;
                                lb_songName.Visible = true;
                                lb_author.Visible = true;
                                img_art.Visible = true;

                                try
                                {
                                    var file = TagLib.File.Create(album[i]);

                                    if (checkImg == true)
                                    {
                                        file = TagLib.File.Create(album[album.Count - 1]);
                                    }
                                    else
                                    {
                                        file = TagLib.File.Create(album[i - 1]);
                                    }

                                    

                                    if (file.Tag.Pictures.Length >= 1)
                                    {
                                        var bin = (byte[])(file.Tag.Pictures[0].Data.Data);
                                        lb_songName.Text = file.Tag.Title;
                                        lb_author.Text = file.Tag.FirstArtist;
                                        img_art.Image = Image.FromStream(new MemoryStream(bin));
                                        thumbnail.Image = Image.FromStream(new MemoryStream(bin));
                                    }
                                    else
                                    {
                                        lb_songName.Text = file.Tag.Title;
                                        lb_author.Text = file.Tag.FirstArtist;
                                        img_art.Image = Resources.bg_music;
                                        thumbnail.Image = Resources.bg_music;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());
                                }
                                break;
                            }
                        }
                        break;
                    }
                }
            }
        }

        private void p_volume_Scroll(object sender, Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs e)
        {
            wplayer.settings.volume = p_volume.Value;
            if (wplayer.settings.volume == 0)
            {

                wplayer.settings.volume = 0;
                p_volume.Value = 0;

                btn_volume.Image = Resources.mute_50px;

                isVolume = true;
            }
            else
            {
                btn_volume.Image = Resources.voice_50px;

                isVolume = false;
            }
        }

        private void flowLayoutPanel1_Scroll(object sender, ScrollEventArgs e)
        {
            Bunifu.Utils.ScrollbarBinder.BindPanel(flowLayoutPanel1, scroll_bar);
        }

        private void btn_volume_Click(object sender, EventArgs e)
        {
            if(isVolume == true)
            {
                p_volume.Value = 100;
                wplayer.settings.volume = p_volume.Value;

                btn_volume.Image = Resources.voice_50px;

                isVolume = false;
            }
            else
            {
                wplayer.settings.volume = 0;
                p_volume.Value = 0;

                btn_volume.Image = Resources.mute_50px;

                isVolume = true;
            }
        }
    }
}
