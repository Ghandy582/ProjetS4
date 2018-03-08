namespace extranet_projet_s4
{
    partial class Form_AdminGestionSeance
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
            this.Nom_Box = new System.Windows.Forms.TextBox();
            this.Prenom_Box = new System.Windows.Forms.TextBox();
            this.PWD_Box = new System.Windows.Forms.TextBox();
            this.Identity_Box = new System.Windows.Forms.TextBox();
            this.Cours_Label = new System.Windows.Forms.Label();
            this.NoteP_Label = new System.Windows.Forms.Label();
            this.Note_Label = new System.Windows.Forms.Label();
            this.DateF_Label = new System.Windows.Forms.Label();
            this.DateD_Label = new System.Windows.Forms.Label();
            this.Enter_Button = new System.Windows.Forms.Button();
            this.SQLentrer_Button = new System.Windows.Forms.Button();
            this.SupprimerButton = new System.Windows.Forms.Button();
            this.AjouterButton = new System.Windows.Forms.Button();
            this.SQL_TB = new System.Windows.Forms.TextBox();
            this.ClicDroitSupprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Gestion_GridView = new System.Windows.Forms.DataGridView();
            this.PanelAdd = new System.Windows.Forms.Panel();
            this.Calendrier = new System.Windows.Forms.MonthCalendar();
            this.Groupe_CB = new System.Windows.Forms.ComboBox();
            this.PanelGestion = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_GridView)).BeginInit();
            this.PanelAdd.SuspendLayout();
            this.PanelGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // Nom_Box
            // 
            this.Nom_Box.Location = new System.Drawing.Point(545, 524);
            this.Nom_Box.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Nom_Box.Multiline = true;
            this.Nom_Box.Name = "Nom_Box";
            this.Nom_Box.Size = new System.Drawing.Size(827, 203);
            this.Nom_Box.TabIndex = 18;
            // 
            // Prenom_Box
            // 
            this.Prenom_Box.Location = new System.Drawing.Point(545, 256);
            this.Prenom_Box.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Prenom_Box.Multiline = true;
            this.Prenom_Box.Name = "Prenom_Box";
            this.Prenom_Box.Size = new System.Drawing.Size(827, 217);
            this.Prenom_Box.TabIndex = 17;
            // 
            // PWD_Box
            // 
            this.PWD_Box.Location = new System.Drawing.Point(545, 142);
            this.PWD_Box.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.PWD_Box.Name = "PWD_Box";
            this.PWD_Box.Size = new System.Drawing.Size(827, 44);
            this.PWD_Box.TabIndex = 16;
            // 
            // Identity_Box
            // 
            this.Identity_Box.Location = new System.Drawing.Point(545, 31);
            this.Identity_Box.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Identity_Box.Name = "Identity_Box";
            this.Identity_Box.Size = new System.Drawing.Size(827, 44);
            this.Identity_Box.TabIndex = 15;
            // 
            // Cours_Label
            // 
            this.Cours_Label.AutoSize = true;
            this.Cours_Label.Location = new System.Drawing.Point(38, 797);
            this.Cours_Label.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Cours_Label.Name = "Cours_Label";
            this.Cours_Label.Size = new System.Drawing.Size(310, 37);
            this.Cours_Label.TabIndex = 12;
            this.Cours_Label.Text = "Cours de la séance :";
            // 
            // NoteP_Label
            // 
            this.NoteP_Label.AutoSize = true;
            this.NoteP_Label.Location = new System.Drawing.Point(38, 524);
            this.NoteP_Label.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.NoteP_Label.Name = "NoteP_Label";
            this.NoteP_Label.Size = new System.Drawing.Size(384, 37);
            this.NoteP_Label.TabIndex = 11;
            this.NoteP_Label.Text = "Note personnel de cours :";
            // 
            // Note_Label
            // 
            this.Note_Label.AutoSize = true;
            this.Note_Label.Location = new System.Drawing.Point(38, 256);
            this.Note_Label.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Note_Label.Name = "Note_Label";
            this.Note_Label.Size = new System.Drawing.Size(235, 37);
            this.Note_Label.TabIndex = 10;
            this.Note_Label.Text = "Note de cours :";
            // 
            // DateF_Label
            // 
            this.DateF_Label.AutoSize = true;
            this.DateF_Label.Location = new System.Drawing.Point(38, 151);
            this.DateF_Label.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.DateF_Label.Name = "DateF_Label";
            this.DateF_Label.Size = new System.Drawing.Size(344, 37);
            this.DateF_Label.TabIndex = 9;
            this.DateF_Label.Text = "Date de fin de séance :";
            // 
            // DateD_Label
            // 
            this.DateD_Label.AutoSize = true;
            this.DateD_Label.Location = new System.Drawing.Point(38, 40);
            this.DateD_Label.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.DateD_Label.Name = "DateD_Label";
            this.DateD_Label.Size = new System.Drawing.Size(390, 37);
            this.DateD_Label.TabIndex = 8;
            this.DateD_Label.Text = "Date de début de séance :";
            // 
            // Enter_Button
            // 
            this.Enter_Button.Location = new System.Drawing.Point(1682, 797);
            this.Enter_Button.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Enter_Button.Name = "Enter_Button";
            this.Enter_Button.Size = new System.Drawing.Size(472, 117);
            this.Enter_Button.TabIndex = 7;
            this.Enter_Button.Text = "Entrer";
            this.Enter_Button.UseVisualStyleBackColor = true;
            // 
            // SQLentrer_Button
            // 
            this.SQLentrer_Button.Location = new System.Drawing.Point(586, 1608);
            this.SQLentrer_Button.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.SQLentrer_Button.Name = "SQLentrer_Button";
            this.SQLentrer_Button.Size = new System.Drawing.Size(472, 117);
            this.SQLentrer_Button.TabIndex = 15;
            this.SQLentrer_Button.Text = "Entrer";
            this.SQLentrer_Button.UseVisualStyleBackColor = true;
            // 
            // SupprimerButton
            // 
            this.SupprimerButton.Location = new System.Drawing.Point(567, 811);
            this.SupprimerButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.SupprimerButton.Name = "SupprimerButton";
            this.SupprimerButton.Size = new System.Drawing.Size(491, 65);
            this.SupprimerButton.TabIndex = 12;
            this.SupprimerButton.Text = "Supprimer";
            this.SupprimerButton.UseVisualStyleBackColor = true;
            this.SupprimerButton.Click += new System.EventHandler(this.SupprimerButton_Click);
            // 
            // AjouterButton
            // 
            this.AjouterButton.Location = new System.Drawing.Point(41, 811);
            this.AjouterButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.AjouterButton.Name = "AjouterButton";
            this.AjouterButton.Size = new System.Drawing.Size(491, 65);
            this.AjouterButton.TabIndex = 11;
            this.AjouterButton.Text = "Ajouter";
            this.AjouterButton.UseVisualStyleBackColor = true;
            this.AjouterButton.Click += new System.EventHandler(this.AjouterButton_Click);
            // 
            // SQL_TB
            // 
            this.SQL_TB.Location = new System.Drawing.Point(41, 894);
            this.SQL_TB.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.SQL_TB.Multiline = true;
            this.SQL_TB.Name = "SQL_TB";
            this.SQL_TB.Size = new System.Drawing.Size(1008, 690);
            this.SQL_TB.TabIndex = 10;
            // 
            // ClicDroitSupprimer
            // 
            this.ClicDroitSupprimer.Name = "ClicDroitSupprimer";
            this.ClicDroitSupprimer.Size = new System.Drawing.Size(266, 52);
            this.ClicDroitSupprimer.Text = "Supprimer";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClicDroitSupprimer});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(267, 56);
            // 
            // Gestion_GridView
            // 
            this.Gestion_GridView.AllowUserToAddRows = false;
            this.Gestion_GridView.AllowUserToOrderColumns = true;
            this.Gestion_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gestion_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gestion_GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gestion_GridView.Location = new System.Drawing.Point(0, 0);
            this.Gestion_GridView.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Gestion_GridView.Name = "Gestion_GridView";
            this.Gestion_GridView.Size = new System.Drawing.Size(3293, 768);
            this.Gestion_GridView.TabIndex = 0;
            // 
            // PanelAdd
            // 
            this.PanelAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanelAdd.Controls.Add(this.Calendrier);
            this.PanelAdd.Controls.Add(this.Groupe_CB);
            this.PanelAdd.Controls.Add(this.Nom_Box);
            this.PanelAdd.Controls.Add(this.Prenom_Box);
            this.PanelAdd.Controls.Add(this.PWD_Box);
            this.PanelAdd.Controls.Add(this.Identity_Box);
            this.PanelAdd.Controls.Add(this.Cours_Label);
            this.PanelAdd.Controls.Add(this.NoteP_Label);
            this.PanelAdd.Controls.Add(this.Note_Label);
            this.PanelAdd.Controls.Add(this.DateF_Label);
            this.PanelAdd.Controls.Add(this.DateD_Label);
            this.PanelAdd.Controls.Add(this.Enter_Button);
            this.PanelAdd.Location = new System.Drawing.Point(1112, 811);
            this.PanelAdd.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(2185, 1005);
            this.PanelAdd.TabIndex = 16;
            // 
            // Calendrier
            // 
            this.Calendrier.CalendarDimensions = new System.Drawing.Size(3, 3);
            this.Calendrier.Location = new System.Drawing.Point(1435, 142);
            this.Calendrier.Margin = new System.Windows.Forms.Padding(29, 26, 29, 26);
            this.Calendrier.Name = "Calendrier";
            this.Calendrier.TabIndex = 20;
            // 
            // Groupe_CB
            // 
            this.Groupe_CB.FormattingEnabled = true;
            this.Groupe_CB.Location = new System.Drawing.Point(545, 788);
            this.Groupe_CB.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Groupe_CB.Name = "Groupe_CB";
            this.Groupe_CB.Size = new System.Drawing.Size(827, 45);
            this.Groupe_CB.TabIndex = 19;
            // 
            // PanelGestion
            // 
            this.PanelGestion.Controls.Add(this.Gestion_GridView);
            this.PanelGestion.Location = new System.Drawing.Point(3, 9);
            this.PanelGestion.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.PanelGestion.Name = "PanelGestion";
            this.PanelGestion.Size = new System.Drawing.Size(3293, 768);
            this.PanelGestion.TabIndex = 9;
            // 
            // Form_AdminGestionSeance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3303, 1836);
            this.Controls.Add(this.SQLentrer_Button);
            this.Controls.Add(this.SupprimerButton);
            this.Controls.Add(this.AjouterButton);
            this.Controls.Add(this.SQL_TB);
            this.Controls.Add(this.PanelAdd);
            this.Controls.Add(this.PanelGestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form_AdminGestionSeance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AdminGestionSeance";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_GridView)).EndInit();
            this.PanelAdd.ResumeLayout(false);
            this.PanelAdd.PerformLayout();
            this.PanelGestion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Nom_Box;
        private System.Windows.Forms.TextBox Prenom_Box;
        private System.Windows.Forms.TextBox PWD_Box;
        private System.Windows.Forms.TextBox Identity_Box;
        private System.Windows.Forms.Label Cours_Label;
        private System.Windows.Forms.Label NoteP_Label;
        private System.Windows.Forms.Label Note_Label;
        private System.Windows.Forms.Label DateF_Label;
        private System.Windows.Forms.Label DateD_Label;
        private System.Windows.Forms.Button Enter_Button;
        private System.Windows.Forms.Button SQLentrer_Button;
        private System.Windows.Forms.Button SupprimerButton;
        private System.Windows.Forms.Button AjouterButton;
        private System.Windows.Forms.TextBox SQL_TB;
        private System.Windows.Forms.ToolStripMenuItem ClicDroitSupprimer;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridView Gestion_GridView;
        private System.Windows.Forms.Panel PanelAdd;
        private System.Windows.Forms.Panel PanelGestion;
        private System.Windows.Forms.MonthCalendar Calendrier;
        private System.Windows.Forms.ComboBox Groupe_CB;
    }
}