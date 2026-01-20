namespace Guess_the_Country
{
    partial class game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(game));
            this.lblTara = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPoints = new System.Windows.Forms.Label();
            this.picBoxTara = new System.Windows.Forms.PictureBox();
            this.cmbBoxTara = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHint = new System.Windows.Forms.Button();
            this.btnVerify = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.lblRasp = new System.Windows.Forms.Label();
            this.picBoxCorrect = new System.Windows.Forms.PictureBox();
            this.lblHint = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCorrect)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTara
            // 
            this.lblTara.AutoSize = true;
            this.lblTara.BackColor = System.Drawing.Color.Transparent;
            this.lblTara.ForeColor = System.Drawing.Color.White;
            this.lblTara.Location = new System.Drawing.Point(12, 23);
            this.lblTara.Name = "lblTara";
            this.lblTara.Size = new System.Drawing.Size(60, 27);
            this.lblTara.TabIndex = 0;
            this.lblTara.Text = "Tara ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblPoints
            // 
            this.lblPoints.AutoSize = true;
            this.lblPoints.BackColor = System.Drawing.Color.Transparent;
            this.lblPoints.ForeColor = System.Drawing.Color.White;
            this.lblPoints.Location = new System.Drawing.Point(67, 64);
            this.lblPoints.Name = "lblPoints";
            this.lblPoints.Size = new System.Drawing.Size(32, 27);
            this.lblPoints.TabIndex = 2;
            this.lblPoints.Text = "X ";
            // 
            // picBoxTara
            // 
            this.picBoxTara.Location = new System.Drawing.Point(134, 66);
            this.picBoxTara.Name = "picBoxTara";
            this.picBoxTara.Size = new System.Drawing.Size(365, 295);
            this.picBoxTara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxTara.TabIndex = 3;
            this.picBoxTara.TabStop = false;
            // 
            // cmbBoxTara
            // 
            this.cmbBoxTara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmbBoxTara.FormattingEnabled = true;
            this.cmbBoxTara.Location = new System.Drawing.Point(201, 367);
            this.cmbBoxTara.Name = "cmbBoxTara";
            this.cmbBoxTara.Size = new System.Drawing.Size(226, 35);
            this.cmbBoxTara.TabIndex = 4;
            this.cmbBoxTara.Text = "- Alege -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 370);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ghiceste tara:";
            // 
            // btnHint
            // 
            this.btnHint.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnHint.Cursor = System.Windows.Forms.Cursors.Help;
            this.btnHint.ForeColor = System.Drawing.Color.White;
            this.btnHint.Location = new System.Drawing.Point(541, 75);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(69, 38);
            this.btnHint.TabIndex = 6;
            this.btnHint.Text = "Hint";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // btnVerify
            // 
            this.btnVerify.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnVerify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerify.ForeColor = System.Drawing.Color.White;
            this.btnVerify.Location = new System.Drawing.Point(463, 364);
            this.btnVerify.Name = "btnVerify";
            this.btnVerify.Size = new System.Drawing.Size(134, 38);
            this.btnVerify.TabIndex = 7;
            this.btnVerify.Text = "Verifica";
            this.btnVerify.UseVisualStyleBackColor = false;
            this.btnVerify.Click += new System.EventHandler(this.btnVerify_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(525, 448);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(85, 38);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Visible = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnHome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(494, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(116, 38);
            this.btnHome.TabIndex = 9;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // lblRasp
            // 
            this.lblRasp.AutoSize = true;
            this.lblRasp.BackColor = System.Drawing.Color.Transparent;
            this.lblRasp.ForeColor = System.Drawing.Color.White;
            this.lblRasp.Location = new System.Drawing.Point(217, 23);
            this.lblRasp.Name = "lblRasp";
            this.lblRasp.Size = new System.Drawing.Size(0, 27);
            this.lblRasp.TabIndex = 10;
            // 
            // picBoxCorrect
            // 
            this.picBoxCorrect.Location = new System.Drawing.Point(222, 370);
            this.picBoxCorrect.Name = "picBoxCorrect";
            this.picBoxCorrect.Size = new System.Drawing.Size(191, 122);
            this.picBoxCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCorrect.TabIndex = 11;
            this.picBoxCorrect.TabStop = false;
            this.picBoxCorrect.Visible = false;
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.BackColor = System.Drawing.Color.Transparent;
            this.lblHint.ForeColor = System.Drawing.Color.White;
            this.lblHint.Location = new System.Drawing.Point(505, 132);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(0, 27);
            this.lblHint.TabIndex = 12;
            this.lblHint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(632, 504);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.lblRasp);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnVerify);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxTara);
            this.Controls.Add(this.lblPoints);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTara);
            this.Controls.Add(this.picBoxCorrect);
            this.Controls.Add(this.picBoxTara);
            this.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Guess the Country - Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCorrect)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTara;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPoints;
        private System.Windows.Forms.PictureBox picBoxTara;
        private System.Windows.Forms.ComboBox cmbBoxTara;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Button btnVerify;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lblRasp;
        private System.Windows.Forms.PictureBox picBoxCorrect;
        private System.Windows.Forms.Label lblHint;
    }
}