﻿namespace extranet_projet_s4
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
            this.Personalisation_DialogBox = new System.Windows.Forms.ColorDialog();
            this.PhpMyAdmin = new System.Windows.Forms.WebBrowser();
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
            this.Menu_Gestion.Size = new System.Drawing.Size(153, 52);
            this.Menu_Gestion.Text = "Gestion";
            // 
            // Menu_Gestion_User
            // 
            this.Menu_Gestion_User.Name = "Menu_Gestion_User";
            this.Menu_Gestion_User.Size = new System.Drawing.Size(471, 54);
            this.Menu_Gestion_User.Text = "Gérer les utilisateurs";
            this.Menu_Gestion_User.Click += new System.EventHandler(this.Menu_User_Gestion_Click);
            // 
            // Menu_Gestion_Groupe
            // 
            this.Menu_Gestion_Groupe.Name = "Menu_Gestion_Groupe";
            this.Menu_Gestion_Groupe.Size = new System.Drawing.Size(471, 54);
            this.Menu_Gestion_Groupe.Text = "Gérer les groupes";
            this.Menu_Gestion_Groupe.Click += new System.EventHandler(this.Menu_Gestion_Groupe_Click);
            // 
            // Menu_Gestion_Cours
            // 
            this.Menu_Gestion_Cours.Name = "Menu_Gestion_Cours";
            this.Menu_Gestion_Cours.Size = new System.Drawing.Size(471, 54);
            this.Menu_Gestion_Cours.Text = "Gérer les cours";
            this.Menu_Gestion_Cours.Click += new System.EventHandler(this.Menu_Gestion_Cours_Click);
            // 
            // Menu_Gestion_Sceance
            // 
            this.Menu_Gestion_Sceance.Name = "Menu_Gestion_Sceance";
            this.Menu_Gestion_Sceance.Size = new System.Drawing.Size(471, 54);
            this.Menu_Gestion_Sceance.Text = "Gérer les séances";
            this.Menu_Gestion_Sceance.Click += new System.EventHandler(this.Menu_Gestion_Sceance_Click);
            // 
            // Menu_Main
            // 
            this.Menu_Main.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Menu_Main.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Menu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Gestion});
            this.Menu_Main.Location = new System.Drawing.Point(0, 0);
            this.Menu_Main.Name = "Menu_Main";
            this.Menu_Main.Padding = new System.Windows.Forms.Padding(19, 6, 0, 6);
            this.Menu_Main.Size = new System.Drawing.Size(3775, 64);
            this.Menu_Main.TabIndex = 2;
            this.Menu_Main.Text = "Menu_Main";
            // 
            // PhpMyAdmin
            // 
            this.PhpMyAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhpMyAdmin.Location = new System.Drawing.Point(0, 64);
            this.PhpMyAdmin.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.PhpMyAdmin.MinimumSize = new System.Drawing.Size(63, 57);
            this.PhpMyAdmin.Name = "PhpMyAdmin";
            this.PhpMyAdmin.Size = new System.Drawing.Size(3775, 1601);
            this.PhpMyAdmin.TabIndex = 3;
            this.PhpMyAdmin.Url = new System.Uri("http://localhost/phpmyadmin/#PMAURL-1:db_structure.php?db=projet4&table=&server=1" +
        "&target=&token=70d891510a56ec46ba98001cb80807be", System.UriKind.Absolute);
            // 
            // Form_AdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(3775, 1665);
            this.Controls.Add(this.PhpMyAdmin);
            this.Controls.Add(this.Menu_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form_AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
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
        private System.Windows.Forms.WebBrowser PhpMyAdmin;
        private System.Windows.Forms.ToolStripMenuItem Menu_Gestion_User;
        private System.Windows.Forms.ToolStripMenuItem Menu_Gestion_Groupe;
        private System.Windows.Forms.ToolStripMenuItem Menu_Gestion_Cours;
        private System.Windows.Forms.ToolStripMenuItem Menu_Gestion_Sceance;
    }
}