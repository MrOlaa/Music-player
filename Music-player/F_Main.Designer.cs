namespace Music_player
{
    partial class F_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Main));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.guna2VProgressBar1 = new Guna.UI2.WinForms.Guna2VProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_end = new System.Windows.Forms.Label();
            this.lb_start = new System.Windows.Forms.Label();
            this.lb_author = new System.Windows.Forms.Label();
            this.lb_songName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scroll_bar = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.thumbnail = new System.Windows.Forms.PictureBox();
            this.p_volume = new Bunifu.UI.WinForms.BunifuHSlider();
            this.btn_volume = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_next = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_preview = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_playing = new Bunifu.UI.WinForms.BunifuImageButton();
            this.img_art = new System.Windows.Forms.PictureBox();
            this.p_barTime = new Bunifu.UI.WinForms.BunifuProgressBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.btn_openfiles = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuImageButton3 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton2 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_min = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_max = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_close = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_art)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.panel1.Controls.Add(this.guna2Button2);
            this.panel1.Controls.Add(this.guna2Button1);
            this.panel1.Controls.Add(this.btn_openfiles);
            this.panel1.Controls.Add(this.bunifuImageButton3);
            this.panel1.Controls.Add(this.bunifuImageButton2);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.btn_min);
            this.panel1.Controls.Add(this.btn_max);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 1102);
            this.panel1.TabIndex = 0;
            // 
            // guna2VProgressBar1
            // 
            this.guna2VProgressBar1.Location = new System.Drawing.Point(0, 0);
            this.guna2VProgressBar1.Name = "guna2VProgressBar1";
            this.guna2VProgressBar1.Size = new System.Drawing.Size(30, 300);
            this.guna2VProgressBar1.TabIndex = 0;
            this.guna2VProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.scroll_bar);
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(226, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(983, 1102);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(292, 414);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(691, 579);
            this.flowLayoutPanel1.TabIndex = 4;
            this.flowLayoutPanel1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.flowLayoutPanel1_Scroll);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel4.Controls.Add(this.thumbnail);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 414);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(292, 579);
            this.panel4.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Controls.Add(this.p_volume);
            this.panel3.Controls.Add(this.btn_volume);
            this.panel3.Controls.Add(this.btn_next);
            this.panel3.Controls.Add(this.btn_preview);
            this.panel3.Controls.Add(this.btn_playing);
            this.panel3.Controls.Add(this.img_art);
            this.panel3.Controls.Add(this.lb_end);
            this.panel3.Controls.Add(this.lb_start);
            this.panel3.Controls.Add(this.lb_author);
            this.panel3.Controls.Add(this.lb_songName);
            this.panel3.Controls.Add(this.p_barTime);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 993);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(983, 109);
            this.panel3.TabIndex = 7;
            // 
            // lb_end
            // 
            this.lb_end.AutoSize = true;
            this.lb_end.Font = new System.Drawing.Font("Segoe UI", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_end.ForeColor = System.Drawing.Color.Silver;
            this.lb_end.Location = new System.Drawing.Point(876, 12);
            this.lb_end.Name = "lb_end";
            this.lb_end.Size = new System.Drawing.Size(0, 12);
            this.lb_end.TabIndex = 8;
            // 
            // lb_start
            // 
            this.lb_start.AutoSize = true;
            this.lb_start.Font = new System.Drawing.Font("Segoe UI", 4.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_start.ForeColor = System.Drawing.Color.Silver;
            this.lb_start.Location = new System.Drawing.Point(121, 12);
            this.lb_start.Name = "lb_start";
            this.lb_start.Size = new System.Drawing.Size(0, 12);
            this.lb_start.TabIndex = 7;
            // 
            // lb_author
            // 
            this.lb_author.AutoEllipsis = true;
            this.lb_author.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lb_author.ForeColor = System.Drawing.Color.Silver;
            this.lb_author.Location = new System.Drawing.Point(126, 71);
            this.lb_author.Name = "lb_author";
            this.lb_author.Size = new System.Drawing.Size(242, 19);
            this.lb_author.TabIndex = 6;
            this.lb_author.Text = "Son Tung MTP";
            this.lb_author.Visible = false;
            // 
            // lb_songName
            // 
            this.lb_songName.AutoEllipsis = true;
            this.lb_songName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_songName.ForeColor = System.Drawing.Color.White;
            this.lb_songName.Location = new System.Drawing.Point(122, 42);
            this.lb_songName.Name = "lb_songName";
            this.lb_songName.Size = new System.Drawing.Size(261, 23);
            this.lb_songName.TabIndex = 5;
            this.lb_songName.Text = "Em Cua Ngay Hom Qua";
            this.lb_songName.Visible = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // scroll_bar
            // 
            this.scroll_bar.AllowCursorChanges = true;
            this.scroll_bar.AllowHomeEndKeysDetection = false;
            this.scroll_bar.AllowIncrementalClickMoves = true;
            this.scroll_bar.AllowMouseDownEffects = true;
            this.scroll_bar.AllowMouseHoverEffects = true;
            this.scroll_bar.AllowScrollingAnimations = true;
            this.scroll_bar.AllowScrollKeysDetection = true;
            this.scroll_bar.AllowScrollOptionsMenu = true;
            this.scroll_bar.AllowShrinkingOnFocusLost = false;
            this.scroll_bar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.scroll_bar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("scroll_bar.BackgroundImage")));
            this.scroll_bar.BindingContainer = null;
            this.scroll_bar.BorderColor = System.Drawing.Color.Transparent;
            this.scroll_bar.BorderRadius = 10;
            this.scroll_bar.BorderThickness = 1;
            this.scroll_bar.Dock = System.Windows.Forms.DockStyle.Right;
            this.scroll_bar.DurationBeforeShrink = 2000;
            this.scroll_bar.LargeChange = 10;
            this.scroll_bar.Location = new System.Drawing.Point(961, 414);
            this.scroll_bar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.scroll_bar.Maximum = 100;
            this.scroll_bar.Minimum = 0;
            this.scroll_bar.MinimumThumbLength = 18;
            this.scroll_bar.Name = "scroll_bar";
            this.scroll_bar.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.scroll_bar.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.scroll_bar.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.scroll_bar.ScrollBarBorderColor = System.Drawing.Color.Transparent;
            this.scroll_bar.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.scroll_bar.ShrinkSizeLimit = 3;
            this.scroll_bar.Size = new System.Drawing.Size(22, 579);
            this.scroll_bar.SmallChange = 1;
            this.scroll_bar.TabIndex = 5;
            this.scroll_bar.ThumbColor = System.Drawing.Color.Gray;
            this.scroll_bar.ThumbLength = 57;
            this.scroll_bar.ThumbMargin = 1;
            this.scroll_bar.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Inset;
            this.scroll_bar.Value = 0;
            // 
            // thumbnail
            // 
            this.thumbnail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.thumbnail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.thumbnail.Location = new System.Drawing.Point(0, 0);
            this.thumbnail.Name = "thumbnail";
            this.thumbnail.Size = new System.Drawing.Size(292, 579);
            this.thumbnail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.thumbnail.TabIndex = 4;
            this.thumbnail.TabStop = false;
            // 
            // p_volume
            // 
            this.p_volume.AllowCursorChanges = true;
            this.p_volume.AllowHomeEndKeysDetection = false;
            this.p_volume.AllowIncrementalClickMoves = true;
            this.p_volume.AllowMouseDownEffects = false;
            this.p_volume.AllowMouseHoverEffects = false;
            this.p_volume.AllowScrollingAnimations = true;
            this.p_volume.AllowScrollKeysDetection = true;
            this.p_volume.AllowScrollOptionsMenu = true;
            this.p_volume.AllowShrinkingOnFocusLost = false;
            this.p_volume.BackColor = System.Drawing.Color.Transparent;
            this.p_volume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p_volume.BackgroundImage")));
            this.p_volume.BindingContainer = null;
            this.p_volume.BorderRadius = 2;
            this.p_volume.BorderThickness = 1;
            this.p_volume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.p_volume.DrawThickBorder = true;
            this.p_volume.DurationBeforeShrink = 2000;
            this.p_volume.ElapsedColor = System.Drawing.Color.Green;
            this.p_volume.LargeChange = 10;
            this.p_volume.Location = new System.Drawing.Point(812, 57);
            this.p_volume.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.p_volume.Maximum = 100;
            this.p_volume.Minimum = 0;
            this.p_volume.MinimumSize = new System.Drawing.Size(0, 31);
            this.p_volume.MinimumThumbLength = 18;
            this.p_volume.Name = "p_volume";
            this.p_volume.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.p_volume.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.p_volume.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.p_volume.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.p_volume.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.p_volume.ShrinkSizeLimit = 3;
            this.p_volume.Size = new System.Drawing.Size(119, 31);
            this.p_volume.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.p_volume.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thick;
            this.p_volume.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.p_volume.SmallChange = 1;
            this.p_volume.TabIndex = 15;
            this.p_volume.ThumbColor = System.Drawing.Color.Green;
            this.p_volume.ThumbFillColor = System.Drawing.Color.Green;
            this.p_volume.ThumbLength = 18;
            this.p_volume.ThumbMargin = 1;
            this.p_volume.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.p_volume.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.p_volume.Value = 100;
            this.p_volume.Visible = false;
            this.p_volume.Scroll += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.ScrollEventArgs>(this.p_volume_Scroll);
            // 
            // btn_volume
            // 
            this.btn_volume.ActiveImage = null;
            this.btn_volume.AllowAnimations = true;
            this.btn_volume.AllowBuffering = false;
            this.btn_volume.AllowToggling = false;
            this.btn_volume.AllowZooming = true;
            this.btn_volume.AllowZoomingOnFocus = false;
            this.btn_volume.BackColor = System.Drawing.Color.Transparent;
            this.btn_volume.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_volume.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_volume.ErrorImage")));
            this.btn_volume.FadeWhenInactive = false;
            this.btn_volume.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_volume.Image = global::Music_player.Properties.Resources.voice_50px;
            this.btn_volume.ImageActive = null;
            this.btn_volume.ImageLocation = null;
            this.btn_volume.ImageMargin = 0;
            this.btn_volume.ImageSize = new System.Drawing.Size(34, 35);
            this.btn_volume.ImageZoomSize = new System.Drawing.Size(35, 36);
            this.btn_volume.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_volume.InitialImage")));
            this.btn_volume.Location = new System.Drawing.Point(766, 54);
            this.btn_volume.Name = "btn_volume";
            this.btn_volume.Rotation = 0;
            this.btn_volume.ShowActiveImage = true;
            this.btn_volume.ShowCursorChanges = true;
            this.btn_volume.ShowImageBorders = true;
            this.btn_volume.ShowSizeMarkers = false;
            this.btn_volume.Size = new System.Drawing.Size(35, 36);
            this.btn_volume.TabIndex = 13;
            this.btn_volume.ToolTipText = "";
            this.btn_volume.Visible = false;
            this.btn_volume.WaitOnLoad = false;
            this.btn_volume.Zoom = 0;
            this.btn_volume.ZoomSpeed = 10;
            this.btn_volume.Click += new System.EventHandler(this.btn_volume_Click);
            // 
            // btn_next
            // 
            this.btn_next.ActiveImage = null;
            this.btn_next.AllowAnimations = true;
            this.btn_next.AllowBuffering = false;
            this.btn_next.AllowToggling = false;
            this.btn_next.AllowZooming = true;
            this.btn_next.AllowZoomingOnFocus = false;
            this.btn_next.BackColor = System.Drawing.Color.Transparent;
            this.btn_next.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_next.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_next.ErrorImage")));
            this.btn_next.FadeWhenInactive = false;
            this.btn_next.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_next.Image = global::Music_player.Properties.Resources.forward_50px;
            this.btn_next.ImageActive = null;
            this.btn_next.ImageLocation = null;
            this.btn_next.ImageMargin = 0;
            this.btn_next.ImageSize = new System.Drawing.Size(43, 47);
            this.btn_next.ImageZoomSize = new System.Drawing.Size(44, 48);
            this.btn_next.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_next.InitialImage")));
            this.btn_next.Location = new System.Drawing.Point(524, 42);
            this.btn_next.Name = "btn_next";
            this.btn_next.Rotation = 0;
            this.btn_next.ShowActiveImage = true;
            this.btn_next.ShowCursorChanges = true;
            this.btn_next.ShowImageBorders = true;
            this.btn_next.ShowSizeMarkers = false;
            this.btn_next.Size = new System.Drawing.Size(44, 48);
            this.btn_next.TabIndex = 12;
            this.btn_next.ToolTipText = "";
            this.btn_next.Visible = false;
            this.btn_next.WaitOnLoad = false;
            this.btn_next.Zoom = 0;
            this.btn_next.ZoomSpeed = 10;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_preview
            // 
            this.btn_preview.ActiveImage = null;
            this.btn_preview.AllowAnimations = true;
            this.btn_preview.AllowBuffering = false;
            this.btn_preview.AllowToggling = false;
            this.btn_preview.AllowZooming = true;
            this.btn_preview.AllowZoomingOnFocus = false;
            this.btn_preview.BackColor = System.Drawing.Color.Transparent;
            this.btn_preview.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_preview.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_preview.ErrorImage")));
            this.btn_preview.FadeWhenInactive = false;
            this.btn_preview.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_preview.Image = global::Music_player.Properties.Resources.back_50px;
            this.btn_preview.ImageActive = null;
            this.btn_preview.ImageLocation = null;
            this.btn_preview.ImageMargin = 0;
            this.btn_preview.ImageSize = new System.Drawing.Size(45, 47);
            this.btn_preview.ImageZoomSize = new System.Drawing.Size(46, 48);
            this.btn_preview.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_preview.InitialImage")));
            this.btn_preview.Location = new System.Drawing.Point(389, 42);
            this.btn_preview.Name = "btn_preview";
            this.btn_preview.Rotation = 0;
            this.btn_preview.ShowActiveImage = true;
            this.btn_preview.ShowCursorChanges = true;
            this.btn_preview.ShowImageBorders = true;
            this.btn_preview.ShowSizeMarkers = false;
            this.btn_preview.Size = new System.Drawing.Size(46, 48);
            this.btn_preview.TabIndex = 11;
            this.btn_preview.ToolTipText = "";
            this.btn_preview.Visible = false;
            this.btn_preview.WaitOnLoad = false;
            this.btn_preview.Zoom = 0;
            this.btn_preview.ZoomSpeed = 10;
            this.btn_preview.Click += new System.EventHandler(this.btn_preview_Click);
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
            this.btn_playing.Image = global::Music_player.Properties.Resources.play_50px;
            this.btn_playing.ImageActive = null;
            this.btn_playing.ImageLocation = null;
            this.btn_playing.ImageMargin = 0;
            this.btn_playing.ImageSize = new System.Drawing.Size(48, 47);
            this.btn_playing.ImageZoomSize = new System.Drawing.Size(49, 48);
            this.btn_playing.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_playing.InitialImage")));
            this.btn_playing.Location = new System.Drawing.Point(455, 42);
            this.btn_playing.Name = "btn_playing";
            this.btn_playing.Rotation = 0;
            this.btn_playing.ShowActiveImage = true;
            this.btn_playing.ShowCursorChanges = true;
            this.btn_playing.ShowImageBorders = true;
            this.btn_playing.ShowSizeMarkers = false;
            this.btn_playing.Size = new System.Drawing.Size(49, 48);
            this.btn_playing.TabIndex = 10;
            this.btn_playing.ToolTipText = "";
            this.btn_playing.Visible = false;
            this.btn_playing.WaitOnLoad = false;
            this.btn_playing.Zoom = 0;
            this.btn_playing.ZoomSpeed = 10;
            this.btn_playing.Click += new System.EventHandler(this.btn_playing_Click);
            // 
            // img_art
            // 
            this.img_art.Dock = System.Windows.Forms.DockStyle.Left;
            this.img_art.Location = new System.Drawing.Point(0, 0);
            this.img_art.Name = "img_art";
            this.img_art.Size = new System.Drawing.Size(115, 109);
            this.img_art.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.img_art.TabIndex = 9;
            this.img_art.TabStop = false;
            // 
            // p_barTime
            // 
            this.p_barTime.AllowAnimations = false;
            this.p_barTime.Animation = 0;
            this.p_barTime.AnimationSpeed = 220;
            this.p_barTime.AnimationStep = 10;
            this.p_barTime.BackColor = System.Drawing.Color.LightGray;
            this.p_barTime.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("p_barTime.BackgroundImage")));
            this.p_barTime.BorderColor = System.Drawing.Color.Transparent;
            this.p_barTime.BorderRadius = 3;
            this.p_barTime.BorderThickness = 1;
            this.p_barTime.Location = new System.Drawing.Point(155, 14);
            this.p_barTime.Maximum = 100;
            this.p_barTime.MaximumValue = 100;
            this.p_barTime.Minimum = 0;
            this.p_barTime.MinimumValue = 0;
            this.p_barTime.Name = "p_barTime";
            this.p_barTime.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.p_barTime.ProgressBackColor = System.Drawing.Color.LightGray;
            this.p_barTime.ProgressColorLeft = System.Drawing.Color.Green;
            this.p_barTime.ProgressColorRight = System.Drawing.Color.Green;
            this.p_barTime.Size = new System.Drawing.Size(710, 10);
            this.p_barTime.TabIndex = 0;
            this.p_barTime.Value = 0;
            this.p_barTime.ValueByTransition = 0;
            this.p_barTime.Visible = false;
            this.p_barTime.MouseDown += new System.Windows.Forms.MouseEventHandler(this.p_barTime_MouseDown);
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(983, 414);
            this.panel5.TabIndex = 6;
            // 
            // guna2Button2
            // 
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = global::Music_player.Properties.Resources.music_record_24px;
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button2.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button2.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button2.Location = new System.Drawing.Point(0, 554);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(226, 64);
            this.guna2Button2.TabIndex = 303;
            this.guna2Button2.Text = "Albums";
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.guna2Button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = global::Music_player.Properties.Resources.musical_notes_30px;
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageOffset = new System.Drawing.Point(10, 0);
            this.guna2Button1.ImageSize = new System.Drawing.Size(25, 25);
            this.guna2Button1.Location = new System.Drawing.Point(-3, 484);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(226, 64);
            this.guna2Button1.TabIndex = 302;
            this.guna2Button1.Text = "Songs";
            // 
            // btn_openfiles
            // 
            this.btn_openfiles.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_openfiles.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_openfiles.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_openfiles.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_openfiles.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btn_openfiles.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_openfiles.ForeColor = System.Drawing.Color.White;
            this.btn_openfiles.Image = global::Music_player.Properties.Resources.music_library_30px;
            this.btn_openfiles.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn_openfiles.ImageOffset = new System.Drawing.Point(10, 0);
            this.btn_openfiles.ImageSize = new System.Drawing.Size(25, 25);
            this.btn_openfiles.Location = new System.Drawing.Point(0, 414);
            this.btn_openfiles.Name = "btn_openfiles";
            this.btn_openfiles.Size = new System.Drawing.Size(226, 48);
            this.btn_openfiles.TabIndex = 301;
            this.btn_openfiles.Text = "Open Files";
            this.btn_openfiles.Click += new System.EventHandler(this.btn_openfiles_Click);
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.ActiveImage = null;
            this.bunifuImageButton3.AllowAnimations = true;
            this.bunifuImageButton3.AllowBuffering = false;
            this.bunifuImageButton3.AllowToggling = false;
            this.bunifuImageButton3.AllowZooming = true;
            this.bunifuImageButton3.AllowZoomingOnFocus = false;
            this.bunifuImageButton3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton3.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.ErrorImage")));
            this.bunifuImageButton3.FadeWhenInactive = false;
            this.bunifuImageButton3.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton3.Image = global::Music_player.Properties.Resources.twitter_48px;
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.ImageLocation = null;
            this.bunifuImageButton3.ImageMargin = 0;
            this.bunifuImageButton3.ImageSize = new System.Drawing.Size(39, 39);
            this.bunifuImageButton3.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.bunifuImageButton3.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.InitialImage")));
            this.bunifuImageButton3.Location = new System.Drawing.Point(138, 801);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Rotation = 0;
            this.bunifuImageButton3.ShowActiveImage = true;
            this.bunifuImageButton3.ShowCursorChanges = true;
            this.bunifuImageButton3.ShowImageBorders = true;
            this.bunifuImageButton3.ShowSizeMarkers = false;
            this.bunifuImageButton3.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton3.TabIndex = 33;
            this.bunifuImageButton3.ToolTipText = "";
            this.bunifuImageButton3.WaitOnLoad = false;
            this.bunifuImageButton3.Zoom = 0;
            this.bunifuImageButton3.ZoomSpeed = 10;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.ActiveImage = null;
            this.bunifuImageButton2.AllowAnimations = true;
            this.bunifuImageButton2.AllowBuffering = false;
            this.bunifuImageButton2.AllowToggling = false;
            this.bunifuImageButton2.AllowZooming = true;
            this.bunifuImageButton2.AllowZoomingOnFocus = false;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.FadeWhenInactive = false;
            this.bunifuImageButton2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton2.Image = global::Music_player.Properties.Resources.instagram_48px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.ImageLocation = null;
            this.bunifuImageButton2.ImageMargin = 0;
            this.bunifuImageButton2.ImageSize = new System.Drawing.Size(39, 39);
            this.bunifuImageButton2.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.bunifuImageButton2.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.InitialImage")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(92, 801);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Rotation = 0;
            this.bunifuImageButton2.ShowActiveImage = true;
            this.bunifuImageButton2.ShowCursorChanges = true;
            this.bunifuImageButton2.ShowImageBorders = true;
            this.bunifuImageButton2.ShowSizeMarkers = false;
            this.bunifuImageButton2.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton2.TabIndex = 32;
            this.bunifuImageButton2.ToolTipText = "";
            this.bunifuImageButton2.WaitOnLoad = false;
            this.bunifuImageButton2.Zoom = 0;
            this.bunifuImageButton2.ZoomSpeed = 10;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowToggling = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.AllowZoomingOnFocus = false;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = global::Music_player.Properties.Resources.facebook_48px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 0;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(39, 39);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(46, 801);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(40, 40);
            this.bunifuImageButton1.TabIndex = 31;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 0;
            this.bunifuImageButton1.ZoomSpeed = 10;
            // 
            // btn_min
            // 
            this.btn_min.ActiveImage = null;
            this.btn_min.AllowAnimations = true;
            this.btn_min.AllowBuffering = false;
            this.btn_min.AllowToggling = false;
            this.btn_min.AllowZooming = true;
            this.btn_min.AllowZoomingOnFocus = false;
            this.btn_min.BackColor = System.Drawing.Color.Transparent;
            this.btn_min.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_min.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_min.ErrorImage")));
            this.btn_min.FadeWhenInactive = false;
            this.btn_min.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_min.Image = ((System.Drawing.Image)(resources.GetObject("btn_min.Image")));
            this.btn_min.ImageActive = null;
            this.btn_min.ImageLocation = null;
            this.btn_min.ImageMargin = 0;
            this.btn_min.ImageSize = new System.Drawing.Size(39, 39);
            this.btn_min.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btn_min.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_min.InitialImage")));
            this.btn_min.Location = new System.Drawing.Point(92, 12);
            this.btn_min.Name = "btn_min";
            this.btn_min.Rotation = 0;
            this.btn_min.ShowActiveImage = true;
            this.btn_min.ShowCursorChanges = true;
            this.btn_min.ShowImageBorders = true;
            this.btn_min.ShowSizeMarkers = false;
            this.btn_min.Size = new System.Drawing.Size(40, 40);
            this.btn_min.TabIndex = 2;
            this.btn_min.ToolTipText = "";
            this.btn_min.WaitOnLoad = false;
            this.btn_min.Zoom = 0;
            this.btn_min.ZoomSpeed = 10;
            this.btn_min.Click += new System.EventHandler(this.btn_min_Click);
            // 
            // btn_max
            // 
            this.btn_max.ActiveImage = null;
            this.btn_max.AllowAnimations = true;
            this.btn_max.AllowBuffering = false;
            this.btn_max.AllowToggling = false;
            this.btn_max.AllowZooming = true;
            this.btn_max.AllowZoomingOnFocus = false;
            this.btn_max.BackColor = System.Drawing.Color.Transparent;
            this.btn_max.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_max.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_max.ErrorImage")));
            this.btn_max.FadeWhenInactive = false;
            this.btn_max.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_max.Image = ((System.Drawing.Image)(resources.GetObject("btn_max.Image")));
            this.btn_max.ImageActive = null;
            this.btn_max.ImageLocation = null;
            this.btn_max.ImageMargin = 0;
            this.btn_max.ImageSize = new System.Drawing.Size(39, 39);
            this.btn_max.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btn_max.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_max.InitialImage")));
            this.btn_max.Location = new System.Drawing.Point(138, 12);
            this.btn_max.Name = "btn_max";
            this.btn_max.Rotation = 0;
            this.btn_max.ShowActiveImage = true;
            this.btn_max.ShowCursorChanges = true;
            this.btn_max.ShowImageBorders = true;
            this.btn_max.ShowSizeMarkers = false;
            this.btn_max.Size = new System.Drawing.Size(40, 40);
            this.btn_max.TabIndex = 1;
            this.btn_max.ToolTipText = "";
            this.btn_max.WaitOnLoad = false;
            this.btn_max.Zoom = 0;
            this.btn_max.ZoomSpeed = 10;
            this.btn_max.Click += new System.EventHandler(this.btn_max_Click);
            // 
            // btn_close
            // 
            this.btn_close.ActiveImage = null;
            this.btn_close.AllowAnimations = true;
            this.btn_close.AllowBuffering = false;
            this.btn_close.AllowToggling = false;
            this.btn_close.AllowZooming = true;
            this.btn_close.AllowZoomingOnFocus = false;
            this.btn_close.BackColor = System.Drawing.Color.Transparent;
            this.btn_close.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_close.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btn_close.ErrorImage")));
            this.btn_close.FadeWhenInactive = false;
            this.btn_close.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageActive = null;
            this.btn_close.ImageLocation = null;
            this.btn_close.ImageMargin = 0;
            this.btn_close.ImageSize = new System.Drawing.Size(39, 39);
            this.btn_close.ImageZoomSize = new System.Drawing.Size(40, 40);
            this.btn_close.InitialImage = ((System.Drawing.Image)(resources.GetObject("btn_close.InitialImage")));
            this.btn_close.Location = new System.Drawing.Point(46, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Rotation = 0;
            this.btn_close.ShowActiveImage = true;
            this.btn_close.ShowCursorChanges = true;
            this.btn_close.ShowImageBorders = true;
            this.btn_close.ShowSizeMarkers = false;
            this.btn_close.Size = new System.Drawing.Size(40, 40);
            this.btn_close.TabIndex = 0;
            this.btn_close.ToolTipText = "";
            this.btn_close.WaitOnLoad = false;
            this.btn_close.Zoom = 0;
            this.btn_close.ZoomSpeed = 10;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.ClientSize = new System.Drawing.Size(1209, 1102);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Music-Player";
            this.Load += new System.EventHandler(this.F_Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.thumbnail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_art)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuImageButton btn_close;
        private Bunifu.UI.WinForms.BunifuImageButton btn_min;
        private Bunifu.UI.WinForms.BunifuImageButton btn_max;
        private Guna.UI2.WinForms.Guna2VProgressBar guna2VProgressBar1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.UI.WinForms.BunifuVScrollBar scroll_bar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private Bunifu.UI.WinForms.BunifuProgressBar p_barTime;
        private System.Windows.Forms.Label lb_songName;
        private System.Windows.Forms.Label lb_author;
        private System.Windows.Forms.Label lb_end;
        private System.Windows.Forms.Label lb_start;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox img_art;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.UI.WinForms.BunifuImageButton btn_playing;
        private Bunifu.UI.WinForms.BunifuImageButton btn_next;
        private Bunifu.UI.WinForms.BunifuImageButton btn_preview;
        private Bunifu.UI.WinForms.BunifuImageButton btn_volume;
        private System.Windows.Forms.PictureBox thumbnail;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton3;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton2;
        private Bunifu.UI.WinForms.BunifuHSlider p_volume;
        private Guna.UI2.WinForms.Guna2Button btn_openfiles;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
    }
}

