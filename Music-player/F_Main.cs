using Music_player.Playlist;
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
        private static string[] path, file;
        private ItemPlayList item = new ItemPlayList();
        private void btn_openfiels_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfile = new OpenFileDialog();
            openfile.Multiselect = true;

            if(openfile.ShowDialog() == DialogResult.OK)
            {
                file = openfile.FileNames;
                path = openfile.FileNames;


                for(int i = 0; i < file.Length; i++)
                { 

                    item = new ItemPlayList();
                    item.SongName = i+1 +"."+" "+ file[i];
                    item.Click += BtnPlayList_Click;
                    item.Name = file[i];

                    flowLayoutPanel1.Controls.Add(item);
                    flowLayoutPanel1.Refresh();
                }
            }
        }
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        private void BtnPlayList_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Refresh();
            item = (sender as ItemPlayList);
            if (item.isPlaying == true)
            {
                wplayer.controls.pause();
                item.isPlaying = false;
            }
            else
            {
                wplayer.URL = item.Name;
                wplayer.controls.play();

                item.isPlaying = true;
            }
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
