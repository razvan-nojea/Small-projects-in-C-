namespace Spanzuratoarea
{
    partial class Domenii
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Domenii));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpSubject = new System.Windows.Forms.GroupBox();
            this.chkCar = new System.Windows.Forms.CheckBox();
            this.chkRom = new System.Windows.Forms.CheckBox();
            this.chkBio = new System.Windows.Forms.CheckBox();
            this.chkMath = new System.Windows.Forms.CheckBox();
            this.chkInfo = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnStartGame = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.grpSubject.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(748, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToolStripMenuItem
            // 
            this.backToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.backToolStripMenuItem.Name = "backToolStripMenuItem";
            this.backToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.backToolStripMenuItem.Text = "back";
            this.backToolStripMenuItem.Click += new System.EventHandler(this.backToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // grpSubject
            // 
            this.grpSubject.Controls.Add(this.chkCar);
            this.grpSubject.Controls.Add(this.chkRom);
            this.grpSubject.Controls.Add(this.chkBio);
            this.grpSubject.Controls.Add(this.chkMath);
            this.grpSubject.Controls.Add(this.chkInfo);
            this.grpSubject.ForeColor = System.Drawing.Color.White;
            this.grpSubject.Location = new System.Drawing.Point(32, 54);
            this.grpSubject.Name = "grpSubject";
            this.grpSubject.Size = new System.Drawing.Size(306, 271);
            this.grpSubject.TabIndex = 1;
            this.grpSubject.TabStop = false;
            this.grpSubject.Text = "Subjects:";
            // 
            // chkCar
            // 
            this.chkCar.AutoSize = true;
            this.chkCar.Location = new System.Drawing.Point(28, 193);
            this.chkCar.Name = "chkCar";
            this.chkCar.Size = new System.Drawing.Size(84, 31);
            this.chkCar.TabIndex = 4;
            this.chkCar.Text = "Cars";
            this.chkCar.UseVisualStyleBackColor = true;
            // 
            // chkRom
            // 
            this.chkRom.AutoSize = true;
            this.chkRom.Location = new System.Drawing.Point(28, 156);
            this.chkRom.Name = "chkRom";
            this.chkRom.Size = new System.Drawing.Size(253, 31);
            this.chkRom.TabIndex = 3;
            this.chkRom.Text = "Romanian literature";
            this.chkRom.UseVisualStyleBackColor = true;
            // 
            // chkBio
            // 
            this.chkBio.AutoSize = true;
            this.chkBio.Location = new System.Drawing.Point(28, 119);
            this.chkBio.Name = "chkBio";
            this.chkBio.Size = new System.Drawing.Size(117, 31);
            this.chkBio.TabIndex = 2;
            this.chkBio.Text = "Biology";
            this.chkBio.UseVisualStyleBackColor = true;
            // 
            // chkMath
            // 
            this.chkMath.AutoSize = true;
            this.chkMath.Location = new System.Drawing.Point(28, 82);
            this.chkMath.Name = "chkMath";
            this.chkMath.Size = new System.Drawing.Size(181, 31);
            this.chkMath.TabIndex = 1;
            this.chkMath.Text = "Mathematics";
            this.chkMath.UseVisualStyleBackColor = true;
            // 
            // chkInfo
            // 
            this.chkInfo.AutoSize = true;
            this.chkInfo.Location = new System.Drawing.Point(28, 45);
            this.chkInfo.Name = "chkInfo";
            this.chkInfo.Size = new System.Drawing.Size(157, 31);
            this.chkInfo.TabIndex = 0;
            this.chkInfo.Text = "Informatics";
            this.chkInfo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "The words will be in romanian.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(364, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 56);
            this.label2.TabIndex = 3;
            this.label2.Text = "!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(595, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 208);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnStartGame
            // 
            this.btnStartGame.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStartGame.Location = new System.Drawing.Point(395, 173);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.Size = new System.Drawing.Size(146, 67);
            this.btnStartGame.TabIndex = 5;
            this.btnStartGame.Text = "Start the Game";
            this.btnStartGame.UseVisualStyleBackColor = false;
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // Domenii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 27F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(748, 353);
            this.Controls.Add(this.btnStartGame);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpSubject);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Domenii";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hangman   |   Choose subjects";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpSubject.ResumeLayout(false);
            this.grpSubject.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox grpSubject;
        private System.Windows.Forms.CheckBox chkMath;
        private System.Windows.Forms.CheckBox chkInfo;
        private System.Windows.Forms.CheckBox chkCar;
        private System.Windows.Forms.CheckBox chkRom;
        private System.Windows.Forms.CheckBox chkBio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnStartGame;
    }
}