namespace extranet_projet_s4
{
    partial class Form_AdminAssignerProf
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
            this.Panel_Prof = new System.Windows.Forms.Panel();
            this.Panel_Cours = new System.Windows.Forms.Panel();
            this.Prof_DataGrid = new System.Windows.Forms.DataGridView();
            this.Cours_DataGrid = new System.Windows.Forms.DataGridView();
            this.Panel_Grid = new System.Windows.Forms.Panel();
            this.Membre_Cours_Grid = new System.Windows.Forms.DataGridView();
            this.Prof_Text = new System.Windows.Forms.Label();
            this.Cours_Text = new System.Windows.Forms.Label();
            this.Liaison_Text = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BoolDate_Box = new System.Windows.Forms.TextBox();
            this.Date_Box = new System.Windows.Forms.TextBox();
            this.DateF_Label = new System.Windows.Forms.Label();
            this.DateD_Label = new System.Windows.Forms.Label();
            this.Panel_Prof.SuspendLayout();
            this.Panel_Cours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prof_DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cours_DataGrid)).BeginInit();
            this.Panel_Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Membre_Cours_Grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Prof
            // 
            this.Panel_Prof.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Panel_Prof.Controls.Add(this.Prof_DataGrid);
            this.Panel_Prof.Location = new System.Drawing.Point(0, 40);
            this.Panel_Prof.Name = "Panel_Prof";
            this.Panel_Prof.Size = new System.Drawing.Size(400, 400);
            this.Panel_Prof.TabIndex = 0;
            // 
            // Panel_Cours
            // 
            this.Panel_Cours.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Panel_Cours.Controls.Add(this.Cours_DataGrid);
            this.Panel_Cours.Location = new System.Drawing.Point(406, 40);
            this.Panel_Cours.Name = "Panel_Cours";
            this.Panel_Cours.Size = new System.Drawing.Size(400, 400);
            this.Panel_Cours.TabIndex = 1;
            // 
            // Prof_DataGrid
            // 
            this.Prof_DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Prof_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Prof_DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Prof_DataGrid.Location = new System.Drawing.Point(0, 0);
            this.Prof_DataGrid.Name = "Prof_DataGrid";
            this.Prof_DataGrid.Size = new System.Drawing.Size(400, 400);
            this.Prof_DataGrid.TabIndex = 0;
            // 
            // Cours_DataGrid
            // 
            this.Cours_DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Cours_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cours_DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cours_DataGrid.Location = new System.Drawing.Point(0, 0);
            this.Cours_DataGrid.Name = "Cours_DataGrid";
            this.Cours_DataGrid.Size = new System.Drawing.Size(400, 400);
            this.Cours_DataGrid.TabIndex = 0;
            // 
            // Panel_Grid
            // 
            this.Panel_Grid.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Panel_Grid.Controls.Add(this.Membre_Cours_Grid);
            this.Panel_Grid.Location = new System.Drawing.Point(913, 40);
            this.Panel_Grid.Name = "Panel_Grid";
            this.Panel_Grid.Size = new System.Drawing.Size(373, 609);
            this.Panel_Grid.TabIndex = 2;
            // 
            // Membre_Cours_Grid
            // 
            this.Membre_Cours_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Membre_Cours_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Membre_Cours_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Membre_Cours_Grid.Location = new System.Drawing.Point(0, 0);
            this.Membre_Cours_Grid.Name = "Membre_Cours_Grid";
            this.Membre_Cours_Grid.Size = new System.Drawing.Size(373, 609);
            this.Membre_Cours_Grid.TabIndex = 0;
            // 
            // Prof_Text
            // 
            this.Prof_Text.AutoSize = true;
            this.Prof_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prof_Text.Location = new System.Drawing.Point(12, 8);
            this.Prof_Text.Name = "Prof_Text";
            this.Prof_Text.Size = new System.Drawing.Size(154, 29);
            this.Prof_Text.TabIndex = 3;
            this.Prof_Text.Text = "Professeurs :";
            // 
            // Cours_Text
            // 
            this.Cours_Text.AutoSize = true;
            this.Cours_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cours_Text.Location = new System.Drawing.Point(401, 8);
            this.Cours_Text.Name = "Cours_Text";
            this.Cours_Text.Size = new System.Drawing.Size(89, 29);
            this.Cours_Text.TabIndex = 4;
            this.Cours_Text.Text = "Cours :";
            // 
            // Liaison_Text
            // 
            this.Liaison_Text.AutoSize = true;
            this.Liaison_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Liaison_Text.Location = new System.Drawing.Point(908, 8);
            this.Liaison_Text.Name = "Liaison_Text";
            this.Liaison_Text.Size = new System.Drawing.Size(102, 29);
            this.Liaison_Text.TabIndex = 5;
            this.Liaison_Text.Text = "Liaison :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.BoolDate_Box);
            this.panel1.Controls.Add(this.Date_Box);
            this.panel1.Controls.Add(this.DateF_Label);
            this.panel1.Controls.Add(this.DateD_Label);
            this.panel1.Location = new System.Drawing.Point(406, 446);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 203);
            this.panel1.TabIndex = 6;
            // 
            // BoolDate_Box
            // 
            this.BoolDate_Box.Location = new System.Drawing.Point(120, 55);
            this.BoolDate_Box.Name = "BoolDate_Box";
            this.BoolDate_Box.Size = new System.Drawing.Size(264, 20);
            this.BoolDate_Box.TabIndex = 20;
            // 
            // Date_Box
            // 
            this.Date_Box.Location = new System.Drawing.Point(120, 16);
            this.Date_Box.Name = "Date_Box";
            this.Date_Box.Size = new System.Drawing.Size(264, 20);
            this.Date_Box.TabIndex = 19;
            // 
            // DateF_Label
            // 
            this.DateF_Label.AutoSize = true;
            this.DateF_Label.Location = new System.Drawing.Point(12, 58);
            this.DateF_Label.Name = "DateF_Label";
            this.DateF_Label.Size = new System.Drawing.Size(95, 13);
            this.DateF_Label.TabIndex = 18;
            this.DateF_Label.Text = "Début de journée :";
            // 
            // DateD_Label
            // 
            this.DateD_Label.AutoSize = true;
            this.DateD_Label.Location = new System.Drawing.Point(12, 19);
            this.DateD_Label.Name = "DateD_Label";
            this.DateD_Label.Size = new System.Drawing.Size(89, 13);
            this.DateD_Label.TabIndex = 17;
            this.DateD_Label.Text = "Date de séance :";
            // 
            // Form_AdminAssignerProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Liaison_Text);
            this.Controls.Add(this.Cours_Text);
            this.Controls.Add(this.Prof_Text);
            this.Controls.Add(this.Panel_Grid);
            this.Controls.Add(this.Panel_Cours);
            this.Controls.Add(this.Panel_Prof);
            this.Name = "Form_AdminAssignerProf";
            this.Text = "Form_AdminAssignerProf";
            this.Panel_Prof.ResumeLayout(false);
            this.Panel_Cours.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Prof_DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cours_DataGrid)).EndInit();
            this.Panel_Grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Membre_Cours_Grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Prof;
        private System.Windows.Forms.Panel Panel_Cours;
        private System.Windows.Forms.DataGridView Prof_DataGrid;
        private System.Windows.Forms.DataGridView Cours_DataGrid;
        private System.Windows.Forms.Panel Panel_Grid;
        private System.Windows.Forms.DataGridView Membre_Cours_Grid;
        private System.Windows.Forms.Label Prof_Text;
        private System.Windows.Forms.Label Cours_Text;
        private System.Windows.Forms.Label Liaison_Text;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox BoolDate_Box;
        private System.Windows.Forms.TextBox Date_Box;
        private System.Windows.Forms.Label DateF_Label;
        private System.Windows.Forms.Label DateD_Label;
    }
}