namespace RGB
{
    partial class Browser
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.backToMainMenuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savedColorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSaveColor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.upRed = new System.Windows.Forms.NumericUpDown();
            this.upGreen = new System.Windows.Forms.NumericUpDown();
            this.upBlue = new System.Windows.Forms.NumericUpDown();
            this.tbarOpac = new System.Windows.Forms.TrackBar();
            this.label4 = new System.Windows.Forms.Label();
            this.picColor = new System.Windows.Forms.PictureBox();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.upBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarOpac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.SteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backToMainMenuToolStripMenuItem,
            this.savedColorsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // backToMainMenuToolStripMenuItem
            // 
            this.backToMainMenuToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToMainMenuToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.backToMainMenuToolStripMenuItem.Name = "backToMainMenuToolStripMenuItem";
            this.backToMainMenuToolStripMenuItem.Size = new System.Drawing.Size(132, 20);
            this.backToMainMenuToolStripMenuItem.Text = "back to main menu";
            this.backToMainMenuToolStripMenuItem.Click += new System.EventHandler(this.backToMainMenuToolStripMenuItem_Click);
            // 
            // savedColorsToolStripMenuItem
            // 
            this.savedColorsToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.savedColorsToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.savedColorsToolStripMenuItem.Name = "savedColorsToolStripMenuItem";
            this.savedColorsToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.savedColorsToolStripMenuItem.Text = "saved colors";
            this.savedColorsToolStripMenuItem.Click += new System.EventHandler(this.savedColorsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btnSaveColor
            // 
            this.btnSaveColor.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveColor.Location = new System.Drawing.Point(36, 376);
            this.btnSaveColor.Name = "btnSaveColor";
            this.btnSaveColor.Size = new System.Drawing.Size(142, 48);
            this.btnSaveColor.TabIndex = 15;
            this.btnSaveColor.Text = "Save color";
            this.btnSaveColor.UseVisualStyleBackColor = false;
            this.btnSaveColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 36);
            this.label1.TabIndex = 16;
            this.label1.Text = "Red";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Green;
            this.label2.Location = new System.Drawing.Point(5, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 36);
            this.label2.TabIndex = 17;
            this.label2.Text = "Green";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(16, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 36);
            this.label3.TabIndex = 18;
            this.label3.Text = "Blue";
            // 
            // upRed
            // 
            this.upRed.ForeColor = System.Drawing.Color.Red;
            this.upRed.Location = new System.Drawing.Point(124, 111);
            this.upRed.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.upRed.Name = "upRed";
            this.upRed.Size = new System.Drawing.Size(80, 31);
            this.upRed.TabIndex = 19;
            this.upRed.ValueChanged += new System.EventHandler(this.upRed_ValueChanged);
            // 
            // upGreen
            // 
            this.upGreen.ForeColor = System.Drawing.Color.Green;
            this.upGreen.Location = new System.Drawing.Point(124, 198);
            this.upGreen.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.upGreen.Name = "upGreen";
            this.upGreen.Size = new System.Drawing.Size(80, 31);
            this.upGreen.TabIndex = 20;
            this.upGreen.ValueChanged += new System.EventHandler(this.upGreen_ValueChanged);
            // 
            // upBlue
            // 
            this.upBlue.ForeColor = System.Drawing.Color.Blue;
            this.upBlue.Location = new System.Drawing.Point(124, 283);
            this.upBlue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.upBlue.Name = "upBlue";
            this.upBlue.Size = new System.Drawing.Size(80, 31);
            this.upBlue.TabIndex = 21;
            this.upBlue.ValueChanged += new System.EventHandler(this.upBlue_ValueChanged);
            // 
            // tbarOpac
            // 
            this.tbarOpac.Location = new System.Drawing.Point(215, 379);
            this.tbarOpac.Maximum = 100;
            this.tbarOpac.Name = "tbarOpac";
            this.tbarOpac.Size = new System.Drawing.Size(331, 45);
            this.tbarOpac.TabIndex = 22;
            this.tbarOpac.Scroll += new System.EventHandler(this.tbarOpac_Scroll);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(332, 348);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 28);
            this.label4.TabIndex = 23;
            this.label4.Text = "Opacity";
            // 
            // picColor
            // 
            this.picColor.Location = new System.Drawing.Point(215, 97);
            this.picColor.Name = "picColor";
            this.picColor.Size = new System.Drawing.Size(331, 248);
            this.picColor.TabIndex = 24;
            this.picColor.TabStop = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.Color.White;
            this.lblWelcome.Location = new System.Drawing.Point(31, 46);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(84, 28);
            this.lblWelcome.TabIndex = 25;
            this.lblWelcome.Text = "Hello, ";
            // 
            // Browser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(558, 430);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.picColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbarOpac);
            this.Controls.Add(this.upBlue);
            this.Controls.Add(this.upGreen);
            this.Controls.Add(this.upRed);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveColor);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Browser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RGB Browser";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.upRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.upBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarOpac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem backToMainMenuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnSaveColor;
        private System.Windows.Forms.ToolStripMenuItem savedColorsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown upRed;
        private System.Windows.Forms.NumericUpDown upGreen;
        private System.Windows.Forms.NumericUpDown upBlue;
        private System.Windows.Forms.TrackBar tbarOpac;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox picColor;
        private System.Windows.Forms.Label lblWelcome;
    }
}