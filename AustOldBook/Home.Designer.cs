namespace AustOldBook
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.semester = new System.Windows.Forms.ComboBox();
            this.dep_name = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.label5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.search_btn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.entityConnection1 = new System.Data.Entity.Core.EntityClient.EntityConnection();
            this.bunifuGradientPanel4 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuImageButton3 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuImageButton2 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuImageButton1 = new Bunifu.UI.WinForms.BunifuImageButton();
            this.bunifuGradientPanel6 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.bunifuGradientPanel4.SuspendLayout();
            this.bunifuGradientPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // semester
            // 
            this.semester.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.semester.FormattingEnabled = true;
            this.semester.Location = new System.Drawing.Point(3, 362);
            this.semester.Name = "semester";
            this.semester.Size = new System.Drawing.Size(163, 29);
            this.semester.TabIndex = 1;
            // 
            // dep_name
            // 
            this.dep_name.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dep_name.FormattingEnabled = true;
            this.dep_name.Location = new System.Drawing.Point(3, 317);
            this.dep_name.Name = "dep_name";
            this.dep_name.Size = new System.Drawing.Size(163, 29);
            this.dep_name.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(313, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(704, 539);
            this.panel1.TabIndex = 32;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 76);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(704, 463);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Controls.Add(this.bunifuLabel3);
            this.panel2.Controls.Add(this.bunifuPictureBox1);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.search_btn);
            this.panel2.Controls.Add(this.dep_name);
            this.panel2.Controls.Add(this.semester);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(214, 539);
            this.panel2.TabIndex = 33;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = true;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel3.Location = new System.Drawing.Point(3, 293);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(183, 18);
            this.bunifuLabel3.TabIndex = 0;
            this.bunifuLabel3.Text = "Select Semester depertment\r\n";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.BorderRadius = 50;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(9, 3);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(99, 99);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 34;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Square;
            this.bunifuPictureBox1.Click += new System.EventHandler(this.bunifuPictureBox1_Click);
            // 
            // label5
            // 
            this.label5.AutoEllipsis = false;
            this.label5.CursorType = null;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 126);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label5.Size = new System.Drawing.Size(96, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "bunifuLabel1";
            this.label5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.label5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.label5.Click += new System.EventHandler(this.bunifuLabel1_Click);
            // 
            // search_btn
            // 
            this.search_btn.AllowToggling = false;
            this.search_btn.AnimationSpeed = 200;
            this.search_btn.AutoGenerateColors = false;
            this.search_btn.BackColor = System.Drawing.Color.Transparent;
            this.search_btn.BackColor1 = System.Drawing.Color.DodgerBlue;
            this.search_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_btn.BackgroundImage")));
            this.search_btn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.search_btn.ButtonText = "Search";
            this.search_btn.ButtonTextMarginLeft = 0;
            this.search_btn.ColorContrastOnClick = 45;
            this.search_btn.ColorContrastOnHover = 45;
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.search_btn.CustomizableEdges = borderEdges1;
            this.search_btn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.search_btn.DisabledBorderColor = System.Drawing.Color.Empty;
            this.search_btn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.search_btn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.search_btn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.search_btn.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F);
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.IconMarginLeft = 11;
            this.search_btn.IconPadding = 10;
            this.search_btn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.IdleBorderColor = System.Drawing.Color.DodgerBlue;
            this.search_btn.IdleBorderRadius = 3;
            this.search_btn.IdleBorderThickness = 1;
            this.search_btn.IdleFillColor = System.Drawing.Color.DodgerBlue;
            this.search_btn.IdleIconLeftImage = null;
            this.search_btn.IdleIconRightImage = null;
            this.search_btn.IndicateFocus = false;
            this.search_btn.Location = new System.Drawing.Point(3, 404);
            this.search_btn.Name = "search_btn";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.BorderRadius = 3;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 1;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.search_btn.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 3;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.search_btn.OnPressedState = stateProperties2;
            this.search_btn.Size = new System.Drawing.Size(163, 45);
            this.search_btn.TabIndex = 0;
            this.search_btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.search_btn.TextMarginLeft = 0;
            this.search_btn.UseDefaultRadiusAndThickness = true;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // bunifuGradientPanel4
            // 
            this.bunifuGradientPanel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel4.BackgroundImage")));
            this.bunifuGradientPanel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel4.Controls.Add(this.bunifuLabel4);
            this.bunifuGradientPanel4.Controls.Add(this.bunifuImageButton3);
            this.bunifuGradientPanel4.Controls.Add(this.bunifuLabel2);
            this.bunifuGradientPanel4.Controls.Add(this.bunifuImageButton2);
            this.bunifuGradientPanel4.Controls.Add(this.bunifuLabel1);
            this.bunifuGradientPanel4.Controls.Add(this.bunifuImageButton1);
            this.bunifuGradientPanel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.bunifuGradientPanel4.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel4.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel4.Location = new System.Drawing.Point(214, 0);
            this.bunifuGradientPanel4.Name = "bunifuGradientPanel4";
            this.bunifuGradientPanel4.Quality = 10;
            this.bunifuGradientPanel4.Size = new System.Drawing.Size(99, 539);
            this.bunifuGradientPanel4.TabIndex = 34;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.Location = new System.Drawing.Point(20, 289);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(46, 22);
            this.bunifuLabel4.TabIndex = 5;
            this.bunifuLabel4.Text = "Home";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuImageButton3
            // 
            this.bunifuImageButton3.ActiveImage = null;
            this.bunifuImageButton3.AllowAnimations = true;
            this.bunifuImageButton3.AllowBuffering = false;
            this.bunifuImageButton3.AllowZooming = true;
            this.bunifuImageButton3.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton3.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.ErrorImage")));
            this.bunifuImageButton3.FadeWhenInactive = false;
            this.bunifuImageButton3.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.Image")));
            this.bunifuImageButton3.ImageActive = null;
            this.bunifuImageButton3.ImageLocation = null;
            this.bunifuImageButton3.ImageMargin = 40;
            this.bunifuImageButton3.ImageSize = new System.Drawing.Size(52, 49);
            this.bunifuImageButton3.ImageZoomSize = new System.Drawing.Size(92, 89);
            this.bunifuImageButton3.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton3.InitialImage")));
            this.bunifuImageButton3.Location = new System.Drawing.Point(0, 206);
            this.bunifuImageButton3.Margin = new System.Windows.Forms.Padding(8);
            this.bunifuImageButton3.Name = "bunifuImageButton3";
            this.bunifuImageButton3.Rotation = 0;
            this.bunifuImageButton3.ShowActiveImage = true;
            this.bunifuImageButton3.ShowCursorChanges = true;
            this.bunifuImageButton3.ShowImageBorders = true;
            this.bunifuImageButton3.ShowSizeMarkers = false;
            this.bunifuImageButton3.Size = new System.Drawing.Size(92, 89);
            this.bunifuImageButton3.TabIndex = 4;
            this.bunifuImageButton3.ToolTipText = "";
            this.bunifuImageButton3.WaitOnLoad = false;
            this.bunifuImageButton3.Zoom = 40;
            this.bunifuImageButton3.ZoomSpeed = 10;
            this.bunifuImageButton3.Click += new System.EventHandler(this.bunifuImageButton3_Click);
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(19, 446);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(58, 22);
            this.bunifuLabel2.TabIndex = 3;
            this.bunifuLabel2.Text = "Log out";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.ActiveImage = null;
            this.bunifuImageButton2.AllowAnimations = true;
            this.bunifuImageButton2.AllowBuffering = false;
            this.bunifuImageButton2.AllowZooming = true;
            this.bunifuImageButton2.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton2.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.ErrorImage")));
            this.bunifuImageButton2.FadeWhenInactive = false;
            this.bunifuImageButton2.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.Image")));
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.ImageLocation = null;
            this.bunifuImageButton2.ImageMargin = 40;
            this.bunifuImageButton2.ImageSize = new System.Drawing.Size(47, 47);
            this.bunifuImageButton2.ImageZoomSize = new System.Drawing.Size(87, 87);
            this.bunifuImageButton2.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton2.InitialImage")));
            this.bunifuImageButton2.Location = new System.Drawing.Point(5, 362);
            this.bunifuImageButton2.Margin = new System.Windows.Forms.Padding(22, 21, 22, 21);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Rotation = 0;
            this.bunifuImageButton2.ShowActiveImage = true;
            this.bunifuImageButton2.ShowCursorChanges = true;
            this.bunifuImageButton2.ShowImageBorders = true;
            this.bunifuImageButton2.ShowSizeMarkers = false;
            this.bunifuImageButton2.Size = new System.Drawing.Size(87, 87);
            this.bunifuImageButton2.TabIndex = 2;
            this.bunifuImageButton2.ToolTipText = "";
            this.bunifuImageButton2.WaitOnLoad = false;
            this.bunifuImageButton2.Zoom = 40;
            this.bunifuImageButton2.ZoomSpeed = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(20, 173);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(57, 22);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = "Upload";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.ActiveImage = null;
            this.bunifuImageButton1.AllowAnimations = true;
            this.bunifuImageButton1.AllowBuffering = false;
            this.bunifuImageButton1.AllowZooming = true;
            this.bunifuImageButton1.BackColor = System.Drawing.Color.White;
            this.bunifuImageButton1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.ErrorImage")));
            this.bunifuImageButton1.FadeWhenInactive = false;
            this.bunifuImageButton1.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.ImageLocation = null;
            this.bunifuImageButton1.ImageMargin = 40;
            this.bunifuImageButton1.ImageSize = new System.Drawing.Size(47, 42);
            this.bunifuImageButton1.ImageZoomSize = new System.Drawing.Size(87, 82);
            this.bunifuImageButton1.InitialImage = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.InitialImage")));
            this.bunifuImageButton1.Location = new System.Drawing.Point(5, 86);
            this.bunifuImageButton1.Margin = new System.Windows.Forms.Padding(13);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Rotation = 0;
            this.bunifuImageButton1.ShowActiveImage = true;
            this.bunifuImageButton1.ShowCursorChanges = true;
            this.bunifuImageButton1.ShowImageBorders = true;
            this.bunifuImageButton1.ShowSizeMarkers = false;
            this.bunifuImageButton1.Size = new System.Drawing.Size(87, 82);
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.ToolTipText = "";
            this.bunifuImageButton1.WaitOnLoad = false;
            this.bunifuImageButton1.Zoom = 40;
            this.bunifuImageButton1.ZoomSpeed = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuGradientPanel6
            // 
            this.bunifuGradientPanel6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuGradientPanel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel6.BackgroundImage")));
            this.bunifuGradientPanel6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel6.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel6.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel6.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel6.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel6.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel6.Location = new System.Drawing.Point(313, 0);
            this.bunifuGradientPanel6.Name = "bunifuGradientPanel6";
            this.bunifuGradientPanel6.Quality = 10;
            this.bunifuGradientPanel6.Size = new System.Drawing.Size(755, 70);
            this.bunifuGradientPanel6.TabIndex = 3;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(253, 9);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(150, 25);
            this.bunifuCustomLabel2.TabIndex = 0;
            this.bunifuCustomLabel2.Text = "Book for sales";
            // 
            // Home
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1017, 539);
            this.Controls.Add(this.bunifuGradientPanel6);
            this.Controls.Add(this.bunifuGradientPanel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home page";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.bunifuGradientPanel4.ResumeLayout(false);
            this.bunifuGradientPanel4.PerformLayout();
            this.bunifuGradientPanel6.ResumeLayout(false);
            this.bunifuGradientPanel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox semester;
        private System.Windows.Forms.ComboBox dep_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Data.Entity.Core.EntityClient.EntityConnection entityConnection1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton search_btn;
        private Bunifu.UI.WinForms.BunifuLabel label5;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel4;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel6;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuImageButton bunifuImageButton3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
    }
}

