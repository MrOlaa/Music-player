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
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Main));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_openfiels = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.btn_min = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_max = new Bunifu.UI.WinForms.BunifuImageButton();
            this.btn_close = new Bunifu.UI.WinForms.BunifuImageButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2VProgressBar1 = new Guna.UI2.WinForms.Guna2VProgressBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Controls.Add(this.btn_openfiels);
            this.panel1.Controls.Add(this.btn_min);
            this.panel1.Controls.Add(this.btn_max);
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 712);
            this.panel1.TabIndex = 0;
            // 
            // btn_openfiels
            // 
            this.btn_openfiels.AllowAnimations = true;
            this.btn_openfiels.AllowMouseEffects = true;
            this.btn_openfiels.AllowToggling = false;
            this.btn_openfiels.AnimationSpeed = 200;
            this.btn_openfiels.AutoGenerateColors = false;
            this.btn_openfiels.AutoRoundBorders = false;
            this.btn_openfiels.AutoSizeLeftIcon = true;
            this.btn_openfiels.AutoSizeRightIcon = true;
            this.btn_openfiels.BackColor = System.Drawing.Color.Transparent;
            this.btn_openfiels.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.btn_openfiels.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_openfiels.BackgroundImage")));
            this.btn_openfiels.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_openfiels.ButtonText = "Open Files";
            this.btn_openfiels.ButtonTextMarginLeft = 0;
            this.btn_openfiels.ColorContrastOnClick = 45;
            this.btn_openfiels.ColorContrastOnHover = 45;
            this.btn_openfiels.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btn_openfiels.CustomizableEdges = borderEdges2;
            this.btn_openfiels.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_openfiels.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_openfiels.DisabledFillColor = System.Drawing.Color.Empty;
            this.btn_openfiels.DisabledForecolor = System.Drawing.Color.Empty;
            this.btn_openfiels.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.btn_openfiels.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_openfiels.ForeColor = System.Drawing.Color.White;
            this.btn_openfiels.IconLeft = null;
            this.btn_openfiels.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_openfiels.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.btn_openfiels.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.btn_openfiels.IconMarginLeft = 11;
            this.btn_openfiels.IconPadding = 10;
            this.btn_openfiels.IconRight = null;
            this.btn_openfiels.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_openfiels.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.btn_openfiels.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.btn_openfiels.IconSize = 25;
            this.btn_openfiels.IdleBorderColor = System.Drawing.Color.Empty;
            this.btn_openfiels.IdleBorderRadius = 0;
            this.btn_openfiels.IdleBorderThickness = 0;
            this.btn_openfiels.IdleFillColor = System.Drawing.Color.Empty;
            this.btn_openfiels.IdleIconLeftImage = null;
            this.btn_openfiels.IdleIconRightImage = null;
            this.btn_openfiels.IndicateFocus = false;
            this.btn_openfiels.Location = new System.Drawing.Point(12, 361);
            this.btn_openfiels.Name = "btn_openfiels";
            this.btn_openfiels.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.btn_openfiels.OnDisabledState.BorderRadius = 1;
            this.btn_openfiels.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_openfiels.OnDisabledState.BorderThickness = 1;
            this.btn_openfiels.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btn_openfiels.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.btn_openfiels.OnDisabledState.IconLeftImage = null;
            this.btn_openfiels.OnDisabledState.IconRightImage = null;
            this.btn_openfiels.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_openfiels.onHoverState.BorderRadius = 1;
            this.btn_openfiels.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_openfiels.onHoverState.BorderThickness = 1;
            this.btn_openfiels.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.btn_openfiels.onHoverState.ForeColor = System.Drawing.Color.White;
            this.btn_openfiels.onHoverState.IconLeftImage = null;
            this.btn_openfiels.onHoverState.IconRightImage = null;
            this.btn_openfiels.OnIdleState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btn_openfiels.OnIdleState.BorderRadius = 1;
            this.btn_openfiels.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_openfiels.OnIdleState.BorderThickness = 1;
            this.btn_openfiels.OnIdleState.FillColor = System.Drawing.Color.DodgerBlue;
            this.btn_openfiels.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.btn_openfiels.OnIdleState.IconLeftImage = null;
            this.btn_openfiels.OnIdleState.IconRightImage = null;
            this.btn_openfiels.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_openfiels.OnPressedState.BorderRadius = 1;
            this.btn_openfiels.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.btn_openfiels.OnPressedState.BorderThickness = 1;
            this.btn_openfiels.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            this.btn_openfiels.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.btn_openfiels.OnPressedState.IconLeftImage = null;
            this.btn_openfiels.OnPressedState.IconRightImage = null;
            this.btn_openfiels.Size = new System.Drawing.Size(202, 39);
            this.btn_openfiels.TabIndex = 30;
            this.btn_openfiels.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_openfiels.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_openfiels.TextMarginLeft = 0;
            this.btn_openfiels.TextPadding = new System.Windows.Forms.Padding(0);
            this.btn_openfiels.UseDefaultRadiusAndThickness = true;
            this.btn_openfiels.Click += new System.EventHandler(this.btn_openfiels_Click);
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
            this.btn_min.Location = new System.Drawing.Point(57, 12);
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
            this.btn_max.Location = new System.Drawing.Point(103, 12);
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
            this.btn_close.Location = new System.Drawing.Point(11, 12);
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
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(226, 620);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(912, 92);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(226, 435);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(174, 185);
            this.panel4.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(14)))), ((int)(((byte)(14)))));
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(400, 435);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(738, 185);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // guna2VProgressBar1
            // 
            this.guna2VProgressBar1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.guna2VProgressBar1.Location = new System.Drawing.Point(0, 0);
            this.guna2VProgressBar1.Name = "guna2VProgressBar1";
            this.guna2VProgressBar1.ShadowDecoration.Parent = this.guna2VProgressBar1;
            this.guna2VProgressBar1.Size = new System.Drawing.Size(30, 300);
            this.guna2VProgressBar1.TabIndex = 0;
            this.guna2VProgressBar1.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(226, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(912, 435);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::Music_player.Properties.Resources.Z23N;
            this.pictureBox1.Location = new System.Drawing.Point(36, 166);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1138, 712);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "F_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuImageButton btn_close;
        private Bunifu.UI.WinForms.BunifuImageButton btn_min;
        private Bunifu.UI.WinForms.BunifuImageButton btn_max;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton btn_openfiels;
        private Guna.UI2.WinForms.Guna2VProgressBar guna2VProgressBar1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

