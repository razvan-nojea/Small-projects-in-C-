namespace datagridview
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
            this.components = new System.ComponentModel.Container();
            this.dataGV = new System.Windows.Forms.DataGridView();
            this.id_elev = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sterge = new System.Windows.Forms.DataGridViewButtonColumn();
            this.velociraptorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.velociraptorDataSet = new datagridview.velociraptorDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtClasa = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtPrenume = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.velociraptorDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.velociraptorDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGV
            // 
            this.dataGV.AllowUserToAddRows = false;
            this.dataGV.AllowUserToDeleteRows = false;
            this.dataGV.AutoGenerateColumns = false;
            this.dataGV.BackgroundColor = System.Drawing.Color.LightSeaGreen;
            this.dataGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_elev,
            this.nume,
            this.prenume,
            this.clasa,
            this.sterge});
            this.dataGV.DataSource = this.velociraptorDataSetBindingSource;
            this.dataGV.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGV.Location = new System.Drawing.Point(404, 44);
            this.dataGV.Margin = new System.Windows.Forms.Padding(4);
            this.dataGV.Name = "dataGV";
            this.dataGV.ReadOnly = true;
            this.dataGV.RowTemplate.Height = 30;
            this.dataGV.Size = new System.Drawing.Size(543, 338);
            this.dataGV.TabIndex = 0;
            this.dataGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGV_CellClick);
            // 
            // id_elev
            // 
            this.id_elev.DataPropertyName = "id_elev";
            this.id_elev.HeaderText = "Id Elev";
            this.id_elev.Name = "id_elev";
            this.id_elev.ReadOnly = true;
            this.id_elev.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nume
            // 
            this.nume.DataPropertyName = "nume";
            this.nume.HeaderText = "Nume";
            this.nume.Name = "nume";
            this.nume.ReadOnly = true;
            this.nume.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // prenume
            // 
            this.prenume.DataPropertyName = "prenume";
            this.prenume.HeaderText = "Prenume";
            this.prenume.Name = "prenume";
            this.prenume.ReadOnly = true;
            this.prenume.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clasa
            // 
            this.clasa.DataPropertyName = "clasa";
            this.clasa.HeaderText = "Clasa";
            this.clasa.Name = "clasa";
            this.clasa.ReadOnly = true;
            this.clasa.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // sterge
            // 
            this.sterge.HeaderText = "Sterge";
            this.sterge.Name = "sterge";
            this.sterge.ReadOnly = true;
            this.sterge.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sterge.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.sterge.Text = "sterge";
            this.sterge.UseColumnTextForButtonValue = true;
            // 
            // velociraptorDataSetBindingSource
            // 
            this.velociraptorDataSetBindingSource.DataSource = this.velociraptorDataSet;
            this.velociraptorDataSetBindingSource.Position = 0;
            // 
            // velociraptorDataSet
            // 
            this.velociraptorDataSet.DataSetName = "velociraptorDataSet";
            this.velociraptorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id Elev";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Prenume";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Clasa";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(91, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(199, 44);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Adauga";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.btnAdd_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtID.Location = new System.Drawing.Point(160, 44);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(198, 27);
            this.txtID.TabIndex = 7;
            // 
            // txtClasa
            // 
            this.txtClasa.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtClasa.Location = new System.Drawing.Point(160, 199);
            this.txtClasa.Name = "txtClasa";
            this.txtClasa.Size = new System.Drawing.Size(198, 27);
            this.txtClasa.TabIndex = 8;
            // 
            // txtNume
            // 
            this.txtNume.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtNume.Location = new System.Drawing.Point(160, 95);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(198, 27);
            this.txtNume.TabIndex = 9;
            // 
            // txtPrenume
            // 
            this.txtPrenume.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtPrenume.Location = new System.Drawing.Point(160, 148);
            this.txtPrenume.Name = "txtPrenume";
            this.txtPrenume.Size = new System.Drawing.Size(198, 27);
            this.txtPrenume.TabIndex = 10;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(961, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            this.exitToolStripMenuItem.MouseLeave += new System.EventHandler(this.exitToolStripMenuItem_MouseLeave);
            this.exitToolStripMenuItem.MouseHover += new System.EventHandler(this.exitToolStripMenuItem_MouseHover);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnUpdate.Location = new System.Drawing.Point(91, 307);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(199, 44);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            this.btnUpdate.MouseLeave += new System.EventHandler(this.btnUpdate_MouseLeave);
            this.btnUpdate.MouseHover += new System.EventHandler(this.btnUpdate_MouseHover);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(961, 395);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtPrenume);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.txtClasa);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGV);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalog? Evidenta elevi? Habar n-am...";
            ((System.ComponentModel.ISupportInitialize)(this.dataGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.velociraptorDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.velociraptorDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtClasa;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtPrenume;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.BindingSource velociraptorDataSetBindingSource;
        private velociraptorDataSet velociraptorDataSet;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_elev;
        private System.Windows.Forms.DataGridViewTextBoxColumn nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenume;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasa;
        private System.Windows.Forms.DataGridViewButtonColumn sterge;
    }
}

