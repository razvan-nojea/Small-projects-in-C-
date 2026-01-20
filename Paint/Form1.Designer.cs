namespace Paint
{
    partial class Form1
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
            this.picRed = new System.Windows.Forms.PictureBox();
            this.picYellow = new System.Windows.Forms.PictureBox();
            this.picGreen = new System.Windows.Forms.PictureBox();
            this.picBlue = new System.Windows.Forms.PictureBox();
            this.picOrange = new System.Windows.Forms.PictureBox();
            this.picBlack = new System.Windows.Forms.PictureBox();
            this.picWhite = new System.Windows.Forms.PictureBox();
            this.picPurple = new System.Windows.Forms.PictureBox();
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.save = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrange)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPurple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picRed
            // 
            this.picRed.BackColor = System.Drawing.Color.Red;
            this.picRed.Location = new System.Drawing.Point(12, 12);
            this.picRed.Name = "picRed";
            this.picRed.Size = new System.Drawing.Size(29, 29);
            this.picRed.TabIndex = 0;
            this.picRed.TabStop = false;
            this.picRed.Click += new System.EventHandler(this.colorChanged);
            // 
            // picYellow
            // 
            this.picYellow.BackColor = System.Drawing.Color.Yellow;
            this.picYellow.Location = new System.Drawing.Point(151, 12);
            this.picYellow.Name = "picYellow";
            this.picYellow.Size = new System.Drawing.Size(29, 29);
            this.picYellow.TabIndex = 2;
            this.picYellow.TabStop = false;
            this.picYellow.Click += new System.EventHandler(this.colorChanged);
            // 
            // picGreen
            // 
            this.picGreen.BackColor = System.Drawing.Color.Green;
            this.picGreen.Location = new System.Drawing.Point(106, 12);
            this.picGreen.Name = "picGreen";
            this.picGreen.Size = new System.Drawing.Size(29, 29);
            this.picGreen.TabIndex = 3;
            this.picGreen.TabStop = false;
            this.picGreen.Click += new System.EventHandler(this.colorChanged);
            // 
            // picBlue
            // 
            this.picBlue.BackColor = System.Drawing.Color.Blue;
            this.picBlue.Location = new System.Drawing.Point(59, 12);
            this.picBlue.Name = "picBlue";
            this.picBlue.Size = new System.Drawing.Size(29, 29);
            this.picBlue.TabIndex = 4;
            this.picBlue.TabStop = false;
            this.picBlue.Click += new System.EventHandler(this.colorChanged);
            // 
            // picOrange
            // 
            this.picOrange.BackColor = System.Drawing.Color.Orange;
            this.picOrange.Location = new System.Drawing.Point(59, 47);
            this.picOrange.Name = "picOrange";
            this.picOrange.Size = new System.Drawing.Size(29, 29);
            this.picOrange.TabIndex = 8;
            this.picOrange.TabStop = false;
            this.picOrange.Click += new System.EventHandler(this.colorChanged);
            // 
            // picBlack
            // 
            this.picBlack.BackColor = System.Drawing.Color.Black;
            this.picBlack.Location = new System.Drawing.Point(106, 47);
            this.picBlack.Name = "picBlack";
            this.picBlack.Size = new System.Drawing.Size(29, 29);
            this.picBlack.TabIndex = 7;
            this.picBlack.TabStop = false;
            this.picBlack.Click += new System.EventHandler(this.colorChanged);
            // 
            // picWhite
            // 
            this.picWhite.BackColor = System.Drawing.Color.White;
            this.picWhite.Location = new System.Drawing.Point(151, 47);
            this.picWhite.Name = "picWhite";
            this.picWhite.Size = new System.Drawing.Size(29, 29);
            this.picWhite.TabIndex = 6;
            this.picWhite.TabStop = false;
            this.picWhite.Click += new System.EventHandler(this.colorChanged);
            // 
            // picPurple
            // 
            this.picPurple.BackColor = System.Drawing.Color.Purple;
            this.picPurple.Location = new System.Drawing.Point(12, 47);
            this.picPurple.Name = "picPurple";
            this.picPurple.Size = new System.Drawing.Size(29, 29);
            this.picPurple.TabIndex = 5;
            this.picPurple.TabStop = false;
            this.picPurple.Click += new System.EventHandler(this.colorChanged);
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.Location = new System.Drawing.Point(214, 13);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(574, 425);
            this.picCanvas.TabIndex = 9;
            this.picCanvas.TabStop = false;
            this.picCanvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseDown);
            this.picCanvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseMove);
            this.picCanvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picCanvas_MouseUp);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(6, 412);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(87, 32);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "\"EXIT\"";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(13, 150);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(131, 43);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "\"CLEAR\"";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(14, 211);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 43);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "\"SAVE\"";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.Enabled = false;
            this.btnLibrary.Location = new System.Drawing.Point(13, 273);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Size = new System.Drawing.Size(131, 43);
            this.btnLibrary.TabIndex = 13;
            this.btnLibrary.Text = "\"YOUR LIBRARY\"";
            this.btnLibrary.UseVisualStyleBackColor = true;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLibrary);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picCanvas);
            this.Controls.Add(this.picOrange);
            this.Controls.Add(this.picBlack);
            this.Controls.Add(this.picWhite);
            this.Controls.Add(this.picPurple);
            this.Controls.Add(this.picBlue);
            this.Controls.Add(this.picGreen);
            this.Controls.Add(this.picYellow);
            this.Controls.Add(this.picRed);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\"TITLE\"";
            ((System.ComponentModel.ISupportInitialize)(this.picRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picYellow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOrange)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBlack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWhite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPurple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picRed;
        private System.Windows.Forms.PictureBox picYellow;
        private System.Windows.Forms.PictureBox picGreen;
        private System.Windows.Forms.PictureBox picBlue;
        private System.Windows.Forms.PictureBox picOrange;
        private System.Windows.Forms.PictureBox picBlack;
        private System.Windows.Forms.PictureBox picWhite;
        private System.Windows.Forms.PictureBox picPurple;
        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLibrary;
        private System.Windows.Forms.SaveFileDialog save;
    }
}

