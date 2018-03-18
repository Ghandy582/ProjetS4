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
            this.NoteP_Box = new System.Windows.Forms.TextBox();
            this.Note_Box = new System.Windows.Forms.TextBox();
            this.BoolDate_Box = new System.Windows.Forms.TextBox();
            this.Date_Box = new System.Windows.Forms.TextBox();
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
            this.Groupe_BTN = new System.Windows.Forms.Button();
            this.Cours_BTN = new System.Windows.Forms.Button();
            this.Groupe_text = new System.Windows.Forms.Label();
            this.Groupe_CB = new System.Windows.Forms.ComboBox();
            this.Calendrier = new System.Windows.Forms.MonthCalendar();
            this.Cours_CB = new System.Windows.Forms.ComboBox();
            this.PanelGestion = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_GridView)).BeginInit();
            this.PanelAdd.SuspendLayout();
            this.PanelGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // NoteP_Box
            // 
            this.NoteP_Box.Location = new System.Drawing.Point(172, 171);
            this.NoteP_Box.Multiline = true;
            this.NoteP_Box.Name = "NoteP_Box";
            this.NoteP_Box.Size = new System.Drawing.Size(264, 49);
            this.NoteP_Box.TabIndex = 18;
            // 
            // Note_Box
            // 
            this.Note_Box.Location = new System.Drawing.Point(172, 86);
            this.Note_Box.Multiline = true;
            this.Note_Box.Name = "Note_Box";
            this.Note_Box.Size = new System.Drawing.Size(264, 79);
            this.Note_Box.TabIndex = 17;
            // 
            // BoolDate_Box
            // 
            this.BoolDate_Box.Location = new System.Drawing.Point(172, 59);
            this.BoolDate_Box.Name = "BoolDate_Box";
            this.BoolDate_Box.Size = new System.Drawing.Size(264, 20);
            this.BoolDate_Box.TabIndex = 16;
            // 
            // Date_Box
            // 
            this.Date_Box.Location = new System.Drawing.Point(172, 31);
            this.Date_Box.Name = "Date_Box";
            this.Date_Box.Size = new System.Drawing.Size(264, 20);
            this.Date_Box.TabIndex = 15;
            // 
            // Cours_Label
            // 
            this.Cours_Label.AutoSize = true;
            this.Cours_Label.Location = new System.Drawing.Point(12, 232);
            this.Cours_Label.Name = "Cours_Label";
            this.Cours_Label.Size = new System.Drawing.Size(104, 13);
            this.Cours_Label.TabIndex = 12;
            this.Cours_Label.Text = "Cours de la séance :";
            // 
            // NoteP_Label
            // 
            this.NoteP_Label.AutoSize = true;
            this.NoteP_Label.Location = new System.Drawing.Point(12, 174);
            this.NoteP_Label.Name = "NoteP_Label";
            this.NoteP_Label.Size = new System.Drawing.Size(129, 13);
            this.NoteP_Label.TabIndex = 11;
            this.NoteP_Label.Text = "Note personnel de cours :";
            // 
            // Note_Label
            // 
            this.Note_Label.AutoSize = true;
            this.Note_Label.Location = new System.Drawing.Point(12, 86);
            this.Note_Label.Name = "Note_Label";
            this.Note_Label.Size = new System.Drawing.Size(80, 13);
            this.Note_Label.TabIndex = 10;
            this.Note_Label.Text = "Note de cours :";
            // 
            // DateF_Label
            // 
            this.DateF_Label.AutoSize = true;
            this.DateF_Label.Location = new System.Drawing.Point(12, 62);
            this.DateF_Label.Name = "DateF_Label";
            this.DateF_Label.Size = new System.Drawing.Size(95, 13);
            this.DateF_Label.TabIndex = 9;
            this.DateF_Label.Text = "Début de journée :";
            // 
            // DateD_Label
            // 
            this.DateD_Label.AutoSize = true;
            this.DateD_Label.Location = new System.Drawing.Point(12, 34);
            this.DateD_Label.Name = "DateD_Label";
            this.DateD_Label.Size = new System.Drawing.Size(89, 13);
            this.DateD_Label.TabIndex = 8;
            this.DateD_Label.Text = "Date de séance :";
            // 
            // Enter_Button
            // 
            this.Enter_Button.Location = new System.Drawing.Point(538, 236);
            this.Enter_Button.Name = "Enter_Button";
            this.Enter_Button.Size = new System.Drawing.Size(149, 41);
            this.Enter_Button.TabIndex = 7;
            this.Enter_Button.Text = "Entrer";
            this.Enter_Button.UseVisualStyleBackColor = true;
            this.Enter_Button.Click += new System.EventHandler(this.Enter_Button_Click);
            // 
            // SQLentrer_Button
            // 
            this.SQLentrer_Button.Location = new System.Drawing.Point(185, 577);
            this.SQLentrer_Button.Name = "SQLentrer_Button";
            this.SQLentrer_Button.Size = new System.Drawing.Size(149, 41);
            this.SQLentrer_Button.TabIndex = 15;
            this.SQLentrer_Button.Text = "Entrer";
            this.SQLentrer_Button.UseVisualStyleBackColor = true;
            this.SQLentrer_Button.Click += new System.EventHandler(this.SQLentrer_Button_Click);
            // 
            // SupprimerButton
            // 
            this.SupprimerButton.Location = new System.Drawing.Point(179, 368);
            this.SupprimerButton.Name = "SupprimerButton";
            this.SupprimerButton.Size = new System.Drawing.Size(155, 23);
            this.SupprimerButton.TabIndex = 12;
            this.SupprimerButton.Text = "Supprimer";
            this.SupprimerButton.UseVisualStyleBackColor = true;
            this.SupprimerButton.Click += new System.EventHandler(this.SupprimerButton_Click);
            // 
            // AjouterButton
            // 
            this.AjouterButton.Location = new System.Drawing.Point(13, 368);
            this.AjouterButton.Name = "AjouterButton";
            this.AjouterButton.Size = new System.Drawing.Size(155, 23);
            this.AjouterButton.TabIndex = 11;
            this.AjouterButton.Text = "Ajouter";
            this.AjouterButton.UseVisualStyleBackColor = true;
            this.AjouterButton.Click += new System.EventHandler(this.AjouterButton_Click);
            // 
            // SQL_TB
            // 
            this.SQL_TB.Location = new System.Drawing.Point(13, 399);
            this.SQL_TB.Multiline = true;
            this.SQL_TB.Name = "SQL_TB";
            this.SQL_TB.Size = new System.Drawing.Size(321, 160);
            this.SQL_TB.TabIndex = 10;
            // 
            // ClicDroitSupprimer
            // 
            this.ClicDroitSupprimer.Name = "ClicDroitSupprimer";
            this.ClicDroitSupprimer.Size = new System.Drawing.Size(129, 22);
            this.ClicDroitSupprimer.Text = "Supprimer";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClicDroitSupprimer});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 26);
            // 
            // Gestion_GridView
            // 
            this.Gestion_GridView.AllowUserToAddRows = false;
            this.Gestion_GridView.AllowUserToOrderColumns = true;
            this.Gestion_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gestion_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gestion_GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gestion_GridView.Location = new System.Drawing.Point(0, 0);
            this.Gestion_GridView.Name = "Gestion_GridView";
            this.Gestion_GridView.Size = new System.Drawing.Size(1040, 270);
            this.Gestion_GridView.TabIndex = 0;
            this.Gestion_GridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GestionCellMouseUp);
            // 
            // PanelAdd
            // 
            this.PanelAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanelAdd.Controls.Add(this.label5);
            this.PanelAdd.Controls.Add(this.Groupe_BTN);
            this.PanelAdd.Controls.Add(this.Cours_BTN);
            this.PanelAdd.Controls.Add(this.Groupe_text);
            this.PanelAdd.Controls.Add(this.Groupe_CB);
            this.PanelAdd.Controls.Add(this.Calendrier);
            this.PanelAdd.Controls.Add(this.Cours_CB);
            this.PanelAdd.Controls.Add(this.NoteP_Box);
            this.PanelAdd.Controls.Add(this.Note_Box);
            this.PanelAdd.Controls.Add(this.BoolDate_Box);
            this.PanelAdd.Controls.Add(this.Date_Box);
            this.PanelAdd.Controls.Add(this.Cours_Label);
            this.PanelAdd.Controls.Add(this.NoteP_Label);
            this.PanelAdd.Controls.Add(this.Note_Label);
            this.PanelAdd.Controls.Add(this.DateF_Label);
            this.PanelAdd.Controls.Add(this.DateD_Label);
            this.PanelAdd.Controls.Add(this.Enter_Button);
            this.PanelAdd.Location = new System.Drawing.Point(351, 337);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(690, 301);
            this.PanelAdd.TabIndex = 16;
            // 
            // Groupe_BTN
            // 
            this.Groupe_BTN.Location = new System.Drawing.Point(442, 256);
            this.Groupe_BTN.Name = "Groupe_BTN";
            this.Groupe_BTN.Size = new System.Drawing.Size(20, 21);
            this.Groupe_BTN.TabIndex = 24;
            this.Groupe_BTN.Text = "?";
            this.Groupe_BTN.UseVisualStyleBackColor = true;
            // 
            // Cours_BTN
            // 
            this.Cours_BTN.Location = new System.Drawing.Point(442, 229);
            this.Cours_BTN.Name = "Cours_BTN";
            this.Cours_BTN.Size = new System.Drawing.Size(20, 21);
            this.Cours_BTN.TabIndex = 23;
            this.Cours_BTN.Text = "?";
            this.Cours_BTN.UseVisualStyleBackColor = true;
            // 
            // Groupe_text
            // 
            this.Groupe_text.AutoSize = true;
            this.Groupe_text.Location = new System.Drawing.Point(12, 260);
            this.Groupe_text.Name = "Groupe_text";
            this.Groupe_text.Size = new System.Drawing.Size(48, 13);
            this.Groupe_text.TabIndex = 22;
            this.Groupe_text.Text = "Groupe :";
            // 
            // Groupe_CB
            // 
            this.Groupe_CB.FormattingEnabled = true;
            this.Groupe_CB.Location = new System.Drawing.Point(172, 256);
            this.Groupe_CB.Name = "Groupe_CB";
            this.Groupe_CB.Size = new System.Drawing.Size(264, 21);
            this.Groupe_CB.TabIndex = 21;
            // 
            // Calendrier
            // 
            this.Calendrier.Location = new System.Drawing.Point(448, 34);
            this.Calendrier.Name = "Calendrier";
            this.Calendrier.TabIndex = 20;
            this.Calendrier.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Calendrier_DateChanged);
            // 
            // Cours_CB
            // 
            this.Cours_CB.FormattingEnabled = true;
            this.Cours_CB.Location = new System.Drawing.Point(172, 229);
            this.Cours_CB.Name = "Cours_CB";
            this.Cours_CB.Size = new System.Drawing.Size(264, 21);
            this.Cours_CB.TabIndex = 19;
            // 
            // PanelGestion
            // 
            this.PanelGestion.Controls.Add(this.Gestion_GridView);
            this.PanelGestion.Location = new System.Drawing.Point(1, 3);
            this.PanelGestion.Name = "PanelGestion";
            this.PanelGestion.Size = new System.Drawing.Size(1040, 270);
            this.PanelGestion.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(313, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(413, 29);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ajouter un nouvelle séance de cours :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Commande SQL :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Insérer données :";
            // 
            // Form_AdminGestionSeance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1040, 630);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SQLentrer_Button);
            this.Controls.Add(this.SupprimerButton);
            this.Controls.Add(this.AjouterButton);
            this.Controls.Add(this.SQL_TB);
            this.Controls.Add(this.PanelAdd);
            this.Controls.Add(this.PanelGestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.TextBox NoteP_Box;
        private System.Windows.Forms.TextBox Note_Box;
        private System.Windows.Forms.TextBox BoolDate_Box;
        private System.Windows.Forms.TextBox Date_Box;
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
        private System.Windows.Forms.ComboBox Cours_CB;
        private System.Windows.Forms.Label Groupe_text;
        private System.Windows.Forms.ComboBox Groupe_CB;
        private System.Windows.Forms.Button Groupe_BTN;
        private System.Windows.Forms.Button Cours_BTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}