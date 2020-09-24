namespace AustOldBook
{
    partial class ListIteams
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bookNameListener = new System.Windows.Forms.Label();
            this.bookAuthorListener = new System.Windows.Forms.Label();
            this.bookPriceListener = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.addressLabel = new System.Windows.Forms.Label();
            this.phnLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(18, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(144, 219);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bookNameListener
            // 
            this.bookNameListener.AutoEllipsis = true;
            this.bookNameListener.AutoSize = true;
            this.bookNameListener.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameListener.Location = new System.Drawing.Point(185, 24);
            this.bookNameListener.Name = "bookNameListener";
            this.bookNameListener.Size = new System.Drawing.Size(95, 21);
            this.bookNameListener.TabIndex = 1;
            this.bookNameListener.Text = "BookName";
            // 
            // bookAuthorListener
            // 
            this.bookAuthorListener.AutoEllipsis = true;
            this.bookAuthorListener.AutoSize = true;
            this.bookAuthorListener.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookAuthorListener.Location = new System.Drawing.Point(185, 59);
            this.bookAuthorListener.Name = "bookAuthorListener";
            this.bookAuthorListener.Size = new System.Drawing.Size(120, 21);
            this.bookAuthorListener.TabIndex = 2;
            this.bookAuthorListener.Text = "Author name";
            // 
            // bookPriceListener
            // 
            this.bookPriceListener.AutoSize = true;
            this.bookPriceListener.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookPriceListener.Location = new System.Drawing.Point(185, 99);
            this.bookPriceListener.Name = "bookPriceListener";
            this.bookPriceListener.Size = new System.Drawing.Size(52, 21);
            this.bookPriceListener.TabIndex = 3;
            this.bookPriceListener.Text = "Price";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 271);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(508, 11);
            this.panel1.TabIndex = 5;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressLabel.Location = new System.Drawing.Point(185, 210);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(75, 21);
            this.addressLabel.TabIndex = 8;
            this.addressLabel.Text = "Address";
            // 
            // phnLabel
            // 
            this.phnLabel.AutoEllipsis = true;
            this.phnLabel.AutoSize = true;
            this.phnLabel.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phnLabel.Location = new System.Drawing.Point(185, 170);
            this.phnLabel.Name = "phnLabel";
            this.phnLabel.Size = new System.Drawing.Size(74, 21);
            this.phnLabel.TabIndex = 7;
            this.phnLabel.Text = "Phn No";
            // 
            // emailLabel
            // 
            this.emailLabel.AutoEllipsis = true;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.Location = new System.Drawing.Point(185, 135);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(55, 21);
            this.emailLabel.TabIndex = 6;
            this.emailLabel.Text = "Email";
            // 
            // ListIteams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.phnLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bookPriceListener);
            this.Controls.Add(this.bookAuthorListener);
            this.Controls.Add(this.bookNameListener);
            this.Controls.Add(this.pictureBox1);
            this.Name = "ListIteams";
            this.Size = new System.Drawing.Size(508, 282);
            this.Load += new System.EventHandler(this.ListIteams_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label bookNameListener;
        private System.Windows.Forms.Label bookAuthorListener;
        private System.Windows.Forms.Label bookPriceListener;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label phnLabel;
        private System.Windows.Forms.Label emailLabel;
    }
}
