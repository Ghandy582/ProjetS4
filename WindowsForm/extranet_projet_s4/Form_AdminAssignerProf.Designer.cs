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
            this.components = new System.ComponentModel.Container();
            this.Panel_Prof = new System.Windows.Forms.Panel();
            this.Prof_DataGrid = new System.Windows.Forms.DataGridView();
            this.Panel_Cours = new System.Windows.Forms.Panel();
            this.Cours_DataGrid = new System.Windows.Forms.DataGridView();
            this.Panel_Grid = new System.Windows.Forms.Panel();
            this.Membre_Cours_Grid = new System.Windows.Forms.DataGridView();
            this.Prof_Text = new System.Windows.Forms.Label();
            this.Cours_Text = new System.Windows.Forms.Label();
            this.Liaison_Text = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cours_CB = new System.Windows.Forms.ComboBox();
            this.Prof_CB = new System.Windows.Forms.ComboBox();
            this.Entrer_BTN = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.IDCours_Label = new System.Windows.Forms.Label();
            this.IdProf_Label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Supprimer_BTN = new System.Windows.Forms.Button();
            this.Ajouter_BTN = new System.Windows.Forms.Button();
            this.SQL_Text = new System.Windows.Forms.TextBox();
            this.SQLEntrer_BTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClicDroit_Supprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel_Prof.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Prof_DataGrid)).BeginInit();
            this.Panel_Cours.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cours_DataGrid)).BeginInit();
            this.Panel_Grid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Membre_Cours_Grid)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
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
            // Prof_DataGrid
            // 
            this.Prof_DataGrid.AllowUserToAddRows = false;
            this.Prof_DataGrid.AllowUserToDeleteRows = false;
            this.Prof_DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Prof_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Prof_DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Prof_DataGrid.Location = new System.Drawing.Point(0, 0);
            this.Prof_DataGrid.Name = "Prof_DataGrid";
            this.Prof_DataGrid.ReadOnly = true;
            this.Prof_DataGrid.Size = new System.Drawing.Size(400, 400);
            this.Prof_DataGrid.TabIndex = 0;
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
            // Cours_DataGrid
            // 
            this.Cours_DataGrid.AllowUserToAddRows = false;
            this.Cours_DataGrid.AllowUserToDeleteRows = false;
            this.Cours_DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Cours_DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Cours_DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cours_DataGrid.Location = new System.Drawing.Point(0, 0);
            this.Cours_DataGrid.Name = "Cours_DataGrid";
            this.Cours_DataGrid.ReadOnly = true;
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
            this.Membre_Cours_Grid.AllowUserToAddRows = false;
            this.Membre_Cours_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Membre_Cours_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Membre_Cours_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Membre_Cours_Grid.Location = new System.Drawing.Point(0, 0);
            this.Membre_Cours_Grid.Name = "Membre_Cours_Grid";
            this.Membre_Cours_Grid.Size = new System.Drawing.Size(373, 609);
            this.Membre_Cours_Grid.TabIndex = 0;
            this.Membre_Cours_Grid.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GestionCellMouseUp);
            this.Membre_Cours_Grid.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_DataGrid_RowValidated);
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
            this.Liaison_Text.Size = new System.Drawing.Size(114, 29);
            this.Liaison_Text.TabIndex = 5;
            this.Liaison_Text.Text = "Liaisons :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.Cours_CB);
            this.panel1.Controls.Add(this.Prof_CB);
            this.panel1.Controls.Add(this.Entrer_BTN);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.IDCours_Label);
            this.panel1.Controls.Add(this.IdProf_Label);
            this.panel1.Location = new System.Drawing.Point(406, 482);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 167);
            this.panel1.TabIndex = 6;
            // 
            // Cours_CB
            // 
            this.Cours_CB.FormattingEnabled = true;
            this.Cours_CB.Location = new System.Drawing.Point(124, 75);
            this.Cours_CB.Name = "Cours_CB";
            this.Cours_CB.Size = new System.Drawing.Size(258, 21);
            this.Cours_CB.TabIndex = 24;
            // 
            // Prof_CB
            // 
            this.Prof_CB.FormattingEnabled = true;
            this.Prof_CB.Location = new System.Drawing.Point(124, 43);
            this.Prof_CB.Name = "Prof_CB";
            this.Prof_CB.Size = new System.Drawing.Size(258, 21);
            this.Prof_CB.TabIndex = 23;
            // 
            // Entrer_BTN
            // 
            this.Entrer_BTN.Location = new System.Drawing.Point(295, 120);
            this.Entrer_BTN.Name = "Entrer_BTN";
            this.Entrer_BTN.Size = new System.Drawing.Size(102, 44);
            this.Entrer_BTN.TabIndex = 22;
            this.Entrer_BTN.Text = "Entrer";
            this.Entrer_BTN.UseVisualStyleBackColor = true;
            this.Entrer_BTN.Click += new System.EventHandler(this.Entrer_BTN_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 24);
            this.label5.TabIndex = 21;
            this.label5.Text = "Insérer données :";
            // 
            // IDCours_Label
            // 
            this.IDCours_Label.AutoSize = true;
            this.IDCours_Label.Location = new System.Drawing.Point(5, 78);
            this.IDCours_Label.Name = "IDCours_Label";
            this.IDCours_Label.Size = new System.Drawing.Size(69, 13);
            this.IDCours_Label.TabIndex = 18;
            this.IDCours_Label.Text = "ID du Cours :";
            // 
            // IdProf_Label
            // 
            this.IdProf_Label.AutoSize = true;
            this.IdProf_Label.Location = new System.Drawing.Point(5, 46);
            this.IdProf_Label.Name = "IdProf_Label";
            this.IdProf_Label.Size = new System.Drawing.Size(92, 13);
            this.IdProf_Label.TabIndex = 17;
            this.IdProf_Label.Text = "ID du Professeur :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 443);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Assigner un Professeur à un cours :";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Controls.Add(this.Supprimer_BTN);
            this.panel2.Controls.Add(this.Ajouter_BTN);
            this.panel2.Controls.Add(this.SQL_Text);
            this.panel2.Controls.Add(this.SQLEntrer_BTN);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(0, 482);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 167);
            this.panel2.TabIndex = 19;
            // 
            // Supprimer_BTN
            // 
            this.Supprimer_BTN.Location = new System.Drawing.Point(295, 57);
            this.Supprimer_BTN.Name = "Supprimer_BTN";
            this.Supprimer_BTN.Size = new System.Drawing.Size(102, 23);
            this.Supprimer_BTN.TabIndex = 26;
            this.Supprimer_BTN.Text = "Supprimer";
            this.Supprimer_BTN.UseVisualStyleBackColor = true;
            this.Supprimer_BTN.Click += new System.EventHandler(this.Supprimer_BTN_Click);
            // 
            // Ajouter_BTN
            // 
            this.Ajouter_BTN.Location = new System.Drawing.Point(295, 28);
            this.Ajouter_BTN.Name = "Ajouter_BTN";
            this.Ajouter_BTN.Size = new System.Drawing.Size(102, 23);
            this.Ajouter_BTN.TabIndex = 25;
            this.Ajouter_BTN.Text = "Ajouter";
            this.Ajouter_BTN.UseVisualStyleBackColor = true;
            this.Ajouter_BTN.Click += new System.EventHandler(this.Ajouter_BTN_Click);
            // 
            // SQL_Text
            // 
            this.SQL_Text.Location = new System.Drawing.Point(5, 28);
            this.SQL_Text.Multiline = true;
            this.SQL_Text.Name = "SQL_Text";
            this.SQL_Text.Size = new System.Drawing.Size(284, 136);
            this.SQL_Text.TabIndex = 24;
            // 
            // SQLEntrer_BTN
            // 
            this.SQLEntrer_BTN.Location = new System.Drawing.Point(295, 120);
            this.SQLEntrer_BTN.Name = "SQLEntrer_BTN";
            this.SQLEntrer_BTN.Size = new System.Drawing.Size(102, 44);
            this.SQLEntrer_BTN.TabIndex = 23;
            this.SQLEntrer_BTN.Text = "Entrer";
            this.SQLEntrer_BTN.UseVisualStyleBackColor = true;
            this.SQLEntrer_BTN.Click += new System.EventHandler(this.SQLEntrer_BTN_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Commande SQL :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClicDroit_Supprimer});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 48);
            // 
            // ClicDroit_Supprimer
            // 
            this.ClicDroit_Supprimer.Name = "ClicDroit_Supprimer";
            this.ClicDroit_Supprimer.Size = new System.Drawing.Size(152, 22);
            this.ClicDroit_Supprimer.Text = "Supprimer";
            this.ClicDroit_Supprimer.Click += new System.EventHandler(this.ClicDroitSupprimer_Click);
            // 
            // Form_AdminAssignerProf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 661);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.Prof_DataGrid)).EndInit();
            this.Panel_Cours.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Cours_DataGrid)).EndInit();
            this.Panel_Grid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Membre_Cours_Grid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
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
        private System.Windows.Forms.Label IDCours_Label;
        private System.Windows.Forms.Label IdProf_Label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Cours_CB;
        private System.Windows.Forms.ComboBox Prof_CB;
        private System.Windows.Forms.Button Entrer_BTN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Supprimer_BTN;
        private System.Windows.Forms.Button Ajouter_BTN;
        private System.Windows.Forms.TextBox SQL_Text;
        private System.Windows.Forms.Button SQLEntrer_BTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ClicDroit_Supprimer;
    }
}