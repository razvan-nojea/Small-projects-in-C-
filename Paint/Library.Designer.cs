namespace Paint
{
    partial class Library
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
            this.picCanvas = new System.Windows.Forms.PictureBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.cmbDrawings = new System.Windows.Forms.ComboBox();
            this.lblDraw = new System.Windows.Forms.Label();
            this.lblNoDraw = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).BeginInit();
            this.SuspendLayout();
            // 
            // picCanvas
            // 
            this.picCanvas.BackColor = System.Drawing.Color.White;
            this.picCanvas.Location = new System.Drawing.Point(214, 13);
            this.picCanvas.Name = "picCanvas";
            this.picCanvas.Size = new System.Drawing.Size(574, 425);
            this.picCanvas.TabIndex = 10;
            this.picCanvas.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(6, 412);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(87, 32);
            this.btnBack.TabIndex = 11;
            this.btnBack.Text = "\"BACK\"";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // cmbDrawings
            // 
            this.cmbDrawings.FormattingEnabled = true;
            this.cmbDrawings.Location = new System.Drawing.Point(13, 132);
            this.cmbDrawings.Name = "cmbDrawings";
            this.cmbDrawings.Size = new System.Drawing.Size(195, 24);
            this.cmbDrawings.TabIndex = 12;
            this.cmbDrawings.SelectedIndexChanged += new System.EventHandler(this.cmbDrawings_SelectedIndexChanged);
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.Location = new System.Drawing.Point(12, 102);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(184, 16);
            this.lblDraw.TabIndex = 13;
            this.lblDraw.Text = "\"CHOOSE YOUR DRAWING\"";
            // 
            // lblNoDraw
            // 
            this.lblNoDraw.AutoSize = true;
            this.lblNoDraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoDraw.Location = new System.Drawing.Point(102, 159);
            this.lblNoDraw.Name = "lblNoDraw";
            this.lblNoDraw.Size = new System.Drawing.Size(591, 54);
            this.lblNoDraw.TabIndex = 14;
            this.lblNoDraw.Text = "\"NO DRAWINGS FOUND.\"";
            this.lblNoDraw.Visible = false;
            // 
            // Library
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNoDraw);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.cmbDrawings);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.picCanvas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Library";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\"YOUR LIBRARY\"";
            ((System.ComponentModel.ISupportInitialize)(this.picCanvas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picCanvas;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox cmbDrawings;
        private System.Windows.Forms.Label lblDraw;
        private System.Windows.Forms.Label lblNoDraw;
    }
}