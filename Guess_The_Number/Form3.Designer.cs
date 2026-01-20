namespace Guess_The_Number
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.label1 = new System.Windows.Forms.Label();
            this.tbRasp = new System.Windows.Forms.TextBox();
            this.btnVerif = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnRetry = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTry = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(205, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(372, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ghiceste numarul si castiga premiul cel mare!";
            // 
            // tbRasp
            // 
            this.tbRasp.Location = new System.Drawing.Point(254, 215);
            this.tbRasp.Name = "tbRasp";
            this.tbRasp.Size = new System.Drawing.Size(260, 26);
            this.tbRasp.TabIndex = 1;
            this.tbRasp.TextChanged += new System.EventHandler(this.tbRasp_TextChanged);
            // 
            // btnVerif
            // 
            this.btnVerif.Location = new System.Drawing.Point(320, 296);
            this.btnVerif.Name = "btnVerif";
            this.btnVerif.Size = new System.Drawing.Size(120, 50);
            this.btnVerif.TabIndex = 2;
            this.btnVerif.Text = "Verifica";
            this.btnVerif.UseVisualStyleBackColor = true;
            this.btnVerif.Click += new System.EventHandler(this.btnVerif_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(320, 379);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(120, 54);
            this.btnReturn.TabIndex = 3;
            this.btnReturn.Text = "Renunta";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnRetry
            // 
            this.btnRetry.Location = new System.Drawing.Point(320, 296);
            this.btnRetry.Name = "btnRetry";
            this.btnRetry.Size = new System.Drawing.Size(120, 50);
            this.btnRetry.TabIndex = 4;
            this.btnRetry.Text = "Incearca din nou!";
            this.btnRetry.UseVisualStyleBackColor = true;
            this.btnRetry.Click += new System.EventHandler(this.btnRetry_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Location = new System.Drawing.Point(320, 379);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(120, 54);
            this.btnMainMenu.TabIndex = 5;
            this.btnMainMenu.Text = "Du-te inapoi la meniu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Incercari";
            // 
            // txtTry
            // 
            this.txtTry.AutoSize = true;
            this.txtTry.Location = new System.Drawing.Point(77, 66);
            this.txtTry.Name = "txtTry";
            this.txtTry.Size = new System.Drawing.Size(19, 20);
            this.txtTry.TabIndex = 7;
            this.txtTry.Text = "0";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(762, 462);
            this.Controls.Add(this.txtTry);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnVerif);
            this.Controls.Add(this.tbRasp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRetry);
            this.Controls.Add(this.btnMainMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "Form3";
            this.Text = "Esti sau nu norocos?";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbRasp;
        private System.Windows.Forms.Button btnVerif;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnRetry;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtTry;
    }
}