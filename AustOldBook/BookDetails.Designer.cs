namespace AustOldBook
{
    partial class BookDetails
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
            this.bookDetailsListener = new System.Windows.Forms.Button();
            this.bookPriceListener = new System.Windows.Forms.Label();
            this.bookAuthorListener = new System.Windows.Forms.Label();
            this.bookNameListener = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(22, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 315);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // bookDetailsListener
            // 
            this.bookDetailsListener.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookDetailsListener.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookDetailsListener.Location = new System.Drawing.Point(245, 310);
            this.bookDetailsListener.Name = "bookDetailsListener";
            this.bookDetailsListener.Size = new System.Drawing.Size(75, 33);
            this.bookDetailsListener.TabIndex = 8;
            this.bookDetailsListener.Text = "Details";
            this.bookDetailsListener.UseVisualStyleBackColor = true;
            // 
            // bookPriceListener
            // 
            this.bookPriceListener.AutoSize = true;
            this.bookPriceListener.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookPriceListener.Location = new System.Drawing.Point(241, 118);
            this.bookPriceListener.Name = "bookPriceListener";
            this.bookPriceListener.Size = new System.Drawing.Size(52, 21);
            this.bookPriceListener.TabIndex = 7;
            this.bookPriceListener.Text = "Price";
            // 
            // bookAuthorListener
            // 
            this.bookAuthorListener.AutoEllipsis = true;
            this.bookAuthorListener.AutoSize = true;
            this.bookAuthorListener.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookAuthorListener.Location = new System.Drawing.Point(241, 78);
            this.bookAuthorListener.Name = "bookAuthorListener";
            this.bookAuthorListener.Size = new System.Drawing.Size(120, 21);
            this.bookAuthorListener.TabIndex = 6;
            this.bookAuthorListener.Text = "Author name";
            // 
            // bookNameListener
            // 
            this.bookNameListener.AutoEllipsis = true;
            this.bookNameListener.AutoSize = true;
            this.bookNameListener.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookNameListener.Location = new System.Drawing.Point(241, 43);
            this.bookNameListener.Name = "bookNameListener";
            this.bookNameListener.Size = new System.Drawing.Size(95, 21);
            this.bookNameListener.TabIndex = 5;
            this.bookNameListener.Text = "BookName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 188);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Phn No";
            // 
            // addre
            // 
            this.addre.AutoSize = true;
            this.addre.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addre.Location = new System.Drawing.Point(244, 229);
            this.addre.Name = "addre";
            this.addre.Size = new System.Drawing.Size(75, 21);
            this.addre.TabIndex = 10;
            this.addre.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 21);
            this.label3.TabIndex = 11;
            this.label3.Text = "Email";
            // 
            // BookDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.addre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookDetailsListener);
            this.Controls.Add(this.bookPriceListener);
            this.Controls.Add(this.bookAuthorListener);
            this.Controls.Add(this.bookNameListener);
            this.Controls.Add(this.pictureBox1);
            this.Name = "BookDetails";
            this.Size = new System.Drawing.Size(612, 396);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bookDetailsListener;
        private System.Windows.Forms.Label bookPriceListener;
        private System.Windows.Forms.Label bookAuthorListener;
        private System.Windows.Forms.Label bookNameListener;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label addre;
        private System.Windows.Forms.Label label3;
    }
}
