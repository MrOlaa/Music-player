namespace Music_player.Playlist
{
    partial class ItemPlayList
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ItemPlayList));
            this.lb_songName = new System.Windows.Forms.Label();
            this.lb_author = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.thumbnail = new System.Windows.Forms.PictureBox();
            this.btn_playing = new Bunifu.UI.WinForms.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_songName
            // 
            this.lb_songName.AutoEllipsis = true;
            this.lb_songName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_songName.ForeColor = System.Drawing.Color.White;
            this.lb_songName.Location = new System.Drawing.Point(123, 21);
            this.lb_songName.Name = "lb_songName";
            this.lb_songName.Size = new System.Drawing.Size(354, 23);
            this.lb_songName.TabIndex = 0;
            this.lb_songName.Text = "1. Em Cua Ngay Hom Qua";
            this.lb_songName.Click += new System.EventHandler(this.btn_playing_Click);
            // 
            // lb_author
            // 
            this.lb_author.AutoEllipsis = true;
            this.lb_author.Font = new System.Drawing.Font("Segoe UI", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_author.ForeColor = System.Drawing.Color.Silver;
            this.lb_author.Location = new System.Drawing.Point(472, 30);
            this.lb_author.Name = "lb_author";
            this.lb_author.Size = new System.Drawing.Size(92, 12);
            this.lb_author.TabIndex = 1;
            this.lb_author.Text = "Son Tung MTP";
            this.lb_author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_author.Click += new System.EventHandler(this.btn_playing_Click);
            // 
            // lb_time
            // 
            this.lb_time.AutoEllipsis = true;
            this.lb_time.Font = new System.Drawing.Font("Segoe UI", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.ForeColor = System.Drawing.Color.Silver;
            this.lb_time.Location = new System.Drawing.Point(600, 30);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(41, 12);
            this.lb_time.TabIndex = 4;
            this.lb_time.Text = "4:00";
            this.lb_time.Click += new System.EventHandler(this.btn_playing_Click);
            // 
            // thumbnail
            // 
            this.thumbnail.Image = global::Music_player.Properties.Resources.bg_music;
            this.thumbnail.Location = new System.Drawing.Point(3, 3);
            this.thumbnail.Name = "thumbnail";
            this.thumbnail.Size = new System.Drawing.Size(58, 64);
            this.thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thumbnail.TabIndex = 3;
            this.thumbnail.TabStop = false;
            this.thumbnail.Click += new System.EventHandler(this.btn_playing_Click);
            // 
            // btn_playing
            // 
            this.btn_playing.ActiveImage = null;
            this.btn_playing.AllowAnimations = true;
            this.btn_playing.AllowBuffering = false;
            this.btn_playing.AllowToggling = false;
            this.btn_playing.AllowZooming = true;
            this.btn_playing.AllowZoomingOnFocus = false;
            this.btn_playing.BackColor = System.Drawing.Color.Transparent;
            this.btn_playing.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_playing.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_playing.ErrorImage")));
            this.btn_playing.FadeWhenInactive = false;
            this.btn_playing.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_playing.Image = global::Music_player.Properties.Resources.play_button;
            this.btn_playing.ImageActive = null;
            this.btn_playing.ImageLocation = null;
            this.btn_playing.ImageMargin = 0;
            this.btn_playing.ImageSize = new System.Drawing.Size(29, 29);
            this.btn_playing.ImageZoomSize = new System.Drawing.Size(30, 30);
            this.btn_playing.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_playing.InitialImage")));
            this.btn_playing.Location = new System.Drawing.Point(77, 18);
            this.btn_playing.Name = "btn_playing";
            this.btn_playing.Rotation = 0;
            this.btn_playing.ShowActiveImage = true;
            this.btn_playing.ShowCursorChanges = true;
            this.btn_playing.ShowImageBorders = true;
            this.btn_playing.ShowSizeMarkers = false;
            this.btn_playing.Size = new System.Drawing.Size(30, 30);
            this.btn_playing.TabIndex = 5;
            this.btn_playing.ToolTipText = "";
            this.btn_playing.WaitOnLoad = false;
            this.btn_playing.Zoom = 0;
            this.btn_playing.ZoomSpeed = 10;
            this.btn_playing.Click += new System.EventHandler(this.btn_playing_Click);
            // 
            // ItemPlayList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.lb_songName);
            this.Controls.Add(this.btn_playing);
            this.Controls.Add(this.thumbnail);
            this.Controls.Add(this.lb_author);
            this.Controls.Add(this.lb_time);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ItemPlayList";
            this.Size = new System.Drawing.Size(666, 67);
            this.Click += new System.EventHandler(this.btn_playing_Click);
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_songName;
        private System.Windows.Forms.Label lb_author;
        private System.Windows.Forms.PictureBox thumbnail;
        private System.Windows.Forms.Label lb_time;
        private Bunifu.UI.WinForms.BunifuImageButton btn_playing;
    }
}
