namespace extranet_projet_s4
{
    partial class Form_AdminMain
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
            this.Menu_Gestion = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Gestion_User = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Gestion_Groupe = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Gestion_Cours = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Gestion_Sceance = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Main = new System.Windows.Forms.MenuStrip();
            this.assignerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Assigner_Prof = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Assigner_Note = new System.Windows.Forms.ToolStripMenuItem();
            this.Personalisation_DialogBox = new System.Windows.Forms.ColorDialog();
            this.Apropos_BTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Reglage_BTN = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.afficherToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Afficher_Note = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_Gestion
            // 
            this.Menu_Gestion.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Gestion_User,
            this.Menu_Gestion_Groupe,
            this.Menu_Gestion_Cours,
            this.Menu_Gestion_Sceance});
            this.Menu_Gestion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Menu_Gestion.Name = "Menu_Gestion";
            this.Menu_Gestion.Size = new System.Drawing.Size(59, 20);
            this.Menu_Gestion.Text = "Gestion";
            // 
            // Menu_Gestion_User
            // 
            this.Menu_Gestion_User.Name = "Menu_Gestion_User";
            this.Menu_Gestion_User.Size = new System.Drawing.Size(179, 22);
            this.Menu_Gestion_User.Text = "Gérer les utilisateurs";
            this.Menu_Gestion_User.Click += new System.EventHandler(this.Menu_User_Gestion_Click);
            // 
            // Menu_Gestion_Groupe
            // 
            this.Menu_Gestion_Groupe.Name = "Menu_Gestion_Groupe";
            this.Menu_Gestion_Groupe.Size = new System.Drawing.Size(179, 22);
            this.Menu_Gestion_Groupe.Text = "Gérer les groupes";
            this.Menu_Gestion_Groupe.Click += new System.EventHandler(this.Menu_Gestion_Groupe_Click);
            // 
            // Menu_Gestion_Cours
            // 
            this.Menu_Gestion_Cours.Name = "Menu_Gestion_Cours";
            this.Menu_Gestion_Cours.Size = new System.Drawing.Size(179, 22);
            this.Menu_Gestion_Cours.Text = "Gérer les cours";
            this.Menu_Gestion_Cours.Click += new System.EventHandler(this.Menu_Gestion_Cours_Click);
            // 
            // Menu_Gestion_Sceance
            // 
            this.Menu_Gestion_Sceance.Name = "Menu_Gestion_Sceance";
            this.Menu_Gestion_Sceance.Size = new System.Drawing.Size(179, 22);
            this.Menu_Gestion_Sceance.Text = "Gérer les séances";
            this.Menu_Gestion_Sceance.Click += new System.EventHandler(this.Menu_Gestion_Sceance_Click);
            // 
            // Menu_Main
            // 
            this.Menu_Main.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Menu_Main.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.Menu_Main.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Menu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Gestion,
            this.assignerToolStripMenuItem,
            this.afficherToolStripMenuItem});
            this.Menu_Main.Location = new System.Drawing.Point(0, 0);
            this.Menu_Main.Name = "Menu_Main";
            this.Menu_Main.Size = new System.Drawing.Size(1123, 24);
            this.Menu_Main.TabIndex = 2;
            this.Menu_Main.Text = "Menu_Main";
            // 
            // assignerToolStripMenuItem
            // 
            this.assignerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Assigner_Prof,
            this.Menu_Assigner_Note});
            this.assignerToolStripMenuItem.Name = "assignerToolStripMenuItem";
            this.assignerToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.assignerToolStripMenuItem.Text = "Assigner";
            // 
            // Menu_Assigner_Prof
            // 
            this.Menu_Assigner_Prof.Name = "Menu_Assigner_Prof";
            this.Menu_Assigner_Prof.Size = new System.Drawing.Size(152, 22);
            this.Menu_Assigner_Prof.Text = "Professeur";
            this.Menu_Assigner_Prof.Click += new System.EventHandler(this.Menu_Assigner_Prof_Click);
            // 
            // Menu_Assigner_Note
            // 
            this.Menu_Assigner_Note.Name = "Menu_Assigner_Note";
            this.Menu_Assigner_Note.Size = new System.Drawing.Size(152, 22);
            this.Menu_Assigner_Note.Text = "Note";
            this.Menu_Assigner_Note.Click += new System.EventHandler(this.Menu_Assigner_Note_Click);
            // 
            // Apropos_BTN
            // 
            this.Apropos_BTN.BackColor = System.Drawing.Color.RoyalBlue;
            this.Apropos_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Apropos_BTN.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Apropos_BTN.FlatAppearance.BorderSize = 0;
            this.Apropos_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Apropos_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Apropos_BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Apropos_BTN.Location = new System.Drawing.Point(980, 470);
            this.Apropos_BTN.Name = "Apropos_BTN";
            this.Apropos_BTN.Size = new System.Drawing.Size(131, 127);
            this.Apropos_BTN.TabIndex = 4;
            this.Apropos_BTN.Text = "À propos";
            this.Apropos_BTN.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Apropos_BTN.UseVisualStyleBackColor = false;
            this.Apropos_BTN.Click += new System.EventHandler(this.Apropos_BTN_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(980, 35);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 127);
            this.button1.TabIndex = 5;
            this.button1.Text = "SSH Support";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Reglage_BTN
            // 
            this.Reglage_BTN.BackColor = System.Drawing.Color.ForestGreen;
            this.Reglage_BTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Reglage_BTN.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.Reglage_BTN.FlatAppearance.BorderSize = 0;
            this.Reglage_BTN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reglage_BTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reglage_BTN.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Reglage_BTN.Location = new System.Drawing.Point(980, 325);
            this.Reglage_BTN.Name = "Reglage_BTN";
            this.Reglage_BTN.Size = new System.Drawing.Size(131, 127);
            this.Reglage_BTN.TabIndex = 6;
            this.Reglage_BTN.Text = "Réglage";
            this.Reglage_BTN.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Reglage_BTN.UseVisualStyleBackColor = false;
            this.Reglage_BTN.Click += new System.EventHandler(this.Reglage_BTN_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Orange;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.Location = new System.Drawing.Point(980, 180);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 127);
            this.button3.TabIndex = 7;
            this.button3.Text = "Fichier";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // afficherToolStripMenuItem
            // 
            this.afficherToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Afficher_Note});
            this.afficherToolStripMenuItem.Name = "afficherToolStripMenuItem";
            this.afficherToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.afficherToolStripMenuItem.Text = "Afficher";
            // 
            // Menu_Afficher_Note
            // 
            this.Menu_Afficher_Note.Name = "Menu_Afficher_Note";
            this.Menu_Afficher_Note.Size = new System.Drawing.Size(152, 22);
            this.Menu_Afficher_Note.Text = "Note";
            this.Menu_Afficher_Note.Click += new System.EventHandler(this.Menu_Afficher_Note_Click);
            // 
            // Form_AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1123, 606);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Reglage_BTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Apropos_BTN);
            this.Controls.Add(this.Menu_Main);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form_AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Console Administrateur";
            this.TransparencyKey = System.Drawing.Color.White;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_FormClosed);
            this.Menu_Main.ResumeLayout(false);
            this.Menu_Main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStripMenuItem Menu_Gestion;
        private System.Windows.Forms.MenuStrip Menu_Main;
        private System.Windows.Forms.ColorDialog Personalisation_DialogBox;
        private System.Windows.Forms.ToolStripMenuItem Menu_Gestion_User;
        private System.Windows.Forms.ToolStripMenuItem Menu_Gestion_Groupe;
        private System.Windows.Forms.ToolStripMenuItem Menu_Gestion_Cours;
        private System.Windows.Forms.ToolStripMenuItem Menu_Gestion_Sceance;
        private System.Windows.Forms.ToolStripMenuItem assignerToolStripMenuItem;
        private System.Windows.Forms.Button Apropos_BTN;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Reglage_BTN;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem Menu_Assigner_Prof;
        private System.Windows.Forms.ToolStripMenuItem Menu_Assigner_Note;
        private System.Windows.Forms.ToolStripMenuItem afficherToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_Afficher_Note;
    }
}