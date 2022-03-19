using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Music_player.Properties;

namespace Music_player.Playlist
{
    public partial class ItemPlayList : UserControl
    {
        public ItemPlayList()
        {
            InitializeComponent();
        }
        public Image Thumbnail
        {
            get { return thumbnail.Image; }
            set { thumbnail.Image = value; }
        }
        public static bool playing = false;
        public bool isPlaying
        {
            get { return playing; }
            set
            {
                playing = value;
                if(playing == true)
                {
                    btn_playing.Image = Resources.pause_button;
                }
                else
                {
                    btn_playing.Image = Resources.play_button;
                }
                this.BorderStyle = isPlaying ? BorderStyle.Fixed3D : BorderStyle.None;
            }
        }
        public string SongName
        {
            get { return lb_songName.Text; }
            set 
            {
                lb_songName.Text = value;
            }
        }
        public string AuthorName
        {
            get { return lb_author.Text; }
            set
            {
                lb_author.Text = value;
            }
        }
        public string Time
        {
            get { return lb_time.Text; }
            set
            {
                lb_time.Text = value;
            }
        }
        public event EventHandler onAction = null;

        public void btn_playing_Click(object sender, EventArgs e)
        {
            if(onAction != null)
            {
                onAction.Invoke(this, e);
            }
        }
    }
}
