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

        bool playing = false;
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
        public EventHandler onAction = null;

        private void btn_playing_Click(object sender, EventArgs e)
        {
            isPlaying = !isPlaying;

            if(onAction != null)
            {
                onAction.Invoke(this, e);
            }
        }
    }
}
