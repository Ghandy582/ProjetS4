namespace extranet_projet_s4
{
    partial class Form_eleve
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
            this.eleve_menu = new System.Windows.Forms.MenuStrip();
            this.eleve_menu_taches = new System.Windows.Forms.ToolStripMenuItem();
            this.eleve_menu_gestion_taches = new System.Windows.Forms.ToolStripMenuItem();
            this.eleve_menu_acces_rapide_taches = new System.Windows.Forms.ToolStripMenuItem();
            this.eleve_menu_nouvelle_tache = new System.Windows.Forms.ToolStripMenuItem();
            this.eleve_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // eleve_menu
            // 
            this.eleve_menu.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eleve_menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.eleve_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eleve_menu_taches});
            this.eleve_menu.Location = new System.Drawing.Point(0, 0);
            this.eleve_menu.Name = "eleve_menu";
            this.eleve_menu.Padding = new System.Windows.Forms.Padding(13, 4, 0, 4);
            this.eleve_menu.Size = new System.Drawing.Size(3376, 65);
            this.eleve_menu.TabIndex = 0;
            this.eleve_menu.Text = "menuStrip1";
            // 
            // eleve_menu_taches
            // 
            this.eleve_menu_taches.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eleve_menu_gestion_taches,
            this.eleve_menu_acces_rapide_taches,
            this.eleve_menu_nouvelle_tache});
            this.eleve_menu_taches.Name = "eleve_menu_taches";
            this.eleve_menu_taches.Size = new System.Drawing.Size(149, 57);
            this.eleve_menu_taches.Text = "Tâches";
            // 
            // eleve_menu_gestion_taches
            // 
            this.eleve_menu_gestion_taches.Name = "eleve_menu_gestion_taches";
            this.eleve_menu_gestion_taches.Size = new System.Drawing.Size(464, 54);
            this.eleve_menu_gestion_taches.Text = "Gestion des tâches";
            this.eleve_menu_gestion_taches.Click += new System.EventHandler(this.eleve_menu_gestion_taches_Click);
            // 
            // eleve_menu_acces_rapide_taches
            // 
            this.eleve_menu_acces_rapide_taches.Name = "eleve_menu_acces_rapide_taches";
            this.eleve_menu_acces_rapide_taches.Size = new System.Drawing.Size(464, 54);
            this.eleve_menu_acces_rapide_taches.Text = "Accès rapide";
            this.eleve_menu_acces_rapide_taches.Click += new System.EventHandler(this.eleve_menu_acces_rapide_taches_Click);
            // 
            // eleve_menu_nouvelle_tache
            // 
            this.eleve_menu_nouvelle_tache.Name = "eleve_menu_nouvelle_tache";
            this.eleve_menu_nouvelle_tache.Size = new System.Drawing.Size(464, 54);
            this.eleve_menu_nouvelle_tache.Text = "Nouvelle tâche";
            this.eleve_menu_nouvelle_tache.Click += new System.EventHandler(this.eleve_menu_nouvelle_tache_Click);
            // 
            // Form_eleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(3376, 1650);
            this.Controls.Add(this.eleve_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.eleve_menu;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form_eleve";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page d\'acceuil";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_eleve_FormClosed);
            this.Load += new System.EventHandler(this.Form_eleve_Load);
            this.eleve_menu.ResumeLayout(false);
            this.eleve_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip eleve_menu;
        private System.Windows.Forms.ToolStripMenuItem eleve_menu_taches;
        private System.Windows.Forms.ToolStripMenuItem eleve_menu_gestion_taches;
        private System.Windows.Forms.ToolStripMenuItem eleve_menu_acces_rapide_taches;
        private System.Windows.Forms.ToolStripMenuItem eleve_menu_nouvelle_tache;
    }
}