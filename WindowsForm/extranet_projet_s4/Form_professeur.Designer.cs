namespace extranet_projet_s4
{
    partial class Form_professeur
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
            this.prof_menu = new System.Windows.Forms.MenuStrip();
            this.tâchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionDesTâchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accèsRapideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nouvelleTâcheToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.paramètresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prof_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // prof_menu
            // 
            this.prof_menu.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prof_menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.prof_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tâchesToolStripMenuItem});
            this.prof_menu.Location = new System.Drawing.Point(0, 0);
            this.prof_menu.Name = "prof_menu";
            this.prof_menu.Size = new System.Drawing.Size(1596, 32);
            this.prof_menu.TabIndex = 0;
            this.prof_menu.Text = "menuStrip1";
            // 
            // tâchesToolStripMenuItem
            // 
            this.tâchesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionDesTâchesToolStripMenuItem,
            this.accèsRapideToolStripMenuItem,
            this.nouvelleTâcheToolStripMenuItem,
            this.paramètresToolStripMenuItem});
            this.tâchesToolStripMenuItem.Name = "tâchesToolStripMenuItem";
            this.tâchesToolStripMenuItem.Size = new System.Drawing.Size(81, 28);
            this.tâchesToolStripMenuItem.Text = "Tâches";
            // 
            // gestionDesTâchesToolStripMenuItem
            // 
            this.gestionDesTâchesToolStripMenuItem.Name = "gestionDesTâchesToolStripMenuItem";
            this.gestionDesTâchesToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.gestionDesTâchesToolStripMenuItem.Text = "Gestion des tâches";
            this.gestionDesTâchesToolStripMenuItem.Click += new System.EventHandler(this.gestionDesTâchesToolStripMenuItem_Click);
            // 
            // accèsRapideToolStripMenuItem
            // 
            this.accèsRapideToolStripMenuItem.Name = "accèsRapideToolStripMenuItem";
            this.accèsRapideToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.accèsRapideToolStripMenuItem.Text = "Accès rapide";
            this.accèsRapideToolStripMenuItem.Click += new System.EventHandler(this.accèsRapideToolStripMenuItem_Click);
            // 
            // nouvelleTâcheToolStripMenuItem
            // 
            this.nouvelleTâcheToolStripMenuItem.Name = "nouvelleTâcheToolStripMenuItem";
            this.nouvelleTâcheToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.nouvelleTâcheToolStripMenuItem.Text = "Nouvelle tâche";
            this.nouvelleTâcheToolStripMenuItem.Click += new System.EventHandler(this.nouvelleTâcheToolStripMenuItem_Click);
            // 
            // paramètresToolStripMenuItem
            // 
            this.paramètresToolStripMenuItem.Name = "paramètresToolStripMenuItem";
            this.paramètresToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.paramètresToolStripMenuItem.Text = "Paramètres";
            this.paramètresToolStripMenuItem.Click += new System.EventHandler(this.paramètresToolStripMenuItem_Click);
            // 
            // Form_professeur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1596, 898);
            this.Controls.Add(this.prof_menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.prof_menu;
            this.Name = "Form_professeur";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page d\'acceuil";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_professeur_FormClosed);
            this.Load += new System.EventHandler(this.Form_professeur_Load);
            this.prof_menu.ResumeLayout(false);
            this.prof_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip prof_menu;
        private System.Windows.Forms.ToolStripMenuItem tâchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionDesTâchesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accèsRapideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nouvelleTâcheToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem paramètresToolStripMenuItem;
    }
}