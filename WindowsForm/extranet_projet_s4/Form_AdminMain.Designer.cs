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
            this.Personalisation_DialogBox = new System.Windows.Forms.ColorDialog();
            this.button1 = new System.Windows.Forms.Button();
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
            this.Menu_Main.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Menu_Main.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.Menu_Main.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Menu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Gestion,
            this.assignerToolStripMenuItem});
            this.Menu_Main.Location = new System.Drawing.Point(0, 0);
            this.Menu_Main.Name = "Menu_Main";
            this.Menu_Main.Size = new System.Drawing.Size(1098, 24);
            this.Menu_Main.TabIndex = 2;
            this.Menu_Main.Text = "Menu_Main";
            // 
            // assignerToolStripMenuItem
            // 
            this.assignerToolStripMenuItem.Name = "assignerToolStripMenuItem";
            this.assignerToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.assignerToolStripMenuItem.Text = "Assigner";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(22, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 118);
            this.button1.TabIndex = 3;
            this.button1.Text = "Personnalisation";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Form_AdminMain
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1098, 563);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Menu_Main);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_AdminMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.TransparencyKey = System.Drawing.Color.White;
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
        private System.Windows.Forms.ToolStripMenuItem Menu_Gestion_User;
        private System.Windows.Forms.ToolStripMenuItem Menu_Gestion_Groupe;
        private System.Windows.Forms.ToolStripMenuItem Menu_Gestion_Cours;
        private System.Windows.Forms.ToolStripMenuItem Menu_Gestion_Sceance;
        private System.Windows.Forms.ToolStripMenuItem assignerToolStripMenuItem;
        private System.Windows.Forms.Button button1;
    }
}