namespace ProjetS4
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
            this.Menu_User = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_User_Gestion = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Main = new System.Windows.Forms.MenuStrip();
            this.Personalisation_DialogBox = new System.Windows.Forms.ColorDialog();
            this.PhpMyAdmin = new System.Windows.Forms.WebBrowser();
            this.Menu_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu_User
            // 
            this.Menu_User.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_User_Gestion});
            this.Menu_User.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Menu_User.Name = "Menu_User";
            this.Menu_User.Size = new System.Drawing.Size(77, 20);
            this.Menu_User.Text = "Utilisateurs";
            // 
            // Menu_User_Gestion
            // 
            this.Menu_User_Gestion.Name = "Menu_User_Gestion";
            this.Menu_User_Gestion.Size = new System.Drawing.Size(152, 22);
            this.Menu_User_Gestion.Text = "Gérer ";
            this.Menu_User_Gestion.Click += new System.EventHandler(this.Menu_User_Gestion_Click);
            // 
            // Menu_Main
            // 
            this.Menu_Main.BackColor = System.Drawing.SystemColors.MenuBar;
            this.Menu_Main.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.Menu_Main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_User});
            this.Menu_Main.Location = new System.Drawing.Point(0, 0);
            this.Menu_Main.Name = "Menu_Main";
            this.Menu_Main.Size = new System.Drawing.Size(1192, 24);
            this.Menu_Main.TabIndex = 2;
            this.Menu_Main.Text = "Menu_Main";
            // 
            // PhpMyAdmin
            // 
            this.PhpMyAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PhpMyAdmin.Location = new System.Drawing.Point(0, 24);
            this.PhpMyAdmin.MinimumSize = new System.Drawing.Size(20, 20);
            this.PhpMyAdmin.Name = "PhpMyAdmin";
            this.PhpMyAdmin.Size = new System.Drawing.Size(1192, 561);
            this.PhpMyAdmin.TabIndex = 3;
            this.PhpMyAdmin.Url = new System.Uri("http://localhost/phpmyadmin/#PMAURL-1:db_structure.php?db=projet4&table=&server=1" +
        "&target=&token=70d891510a56ec46ba98001cb80807be", System.UriKind.Absolute);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(1192, 585);
            this.Controls.Add(this.PhpMyAdmin);
            this.Controls.Add(this.Menu_Main);
            this.Name = "Main";
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
        private System.Windows.Forms.ToolStripMenuItem Menu_User;
        private System.Windows.Forms.MenuStrip Menu_Main;
        private System.Windows.Forms.ColorDialog Personalisation_DialogBox;
        private System.Windows.Forms.WebBrowser PhpMyAdmin;
        private System.Windows.Forms.ToolStripMenuItem Menu_User_Gestion;
    }
}