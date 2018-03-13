namespace extranet_projet_s4
{
    partial class GestionUser
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
            this.PanelGestion = new System.Windows.Forms.Panel();
            this.Gestion_GridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClicDroitSupprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.SQL_TB = new System.Windows.Forms.TextBox();
            this.AjouterButton = new System.Windows.Forms.Button();
            this.SupprimerButton = new System.Windows.Forms.Button();
            this.SQL_Label = new System.Windows.Forms.Label();
            this.SQLpwd_TB = new System.Windows.Forms.TextBox();
            this.SQLentrer_Button = new System.Windows.Forms.Button();
            this.PanelAdd = new System.Windows.Forms.Panel();
            this.Groupe_CB = new System.Windows.Forms.ComboBox();
            this.Nom_Box = new System.Windows.Forms.TextBox();
            this.Prenom_Box = new System.Windows.Forms.TextBox();
            this.PWD_Box = new System.Windows.Forms.TextBox();
            this.Identity_Box = new System.Windows.Forms.TextBox();
            this.Role_CB = new System.Windows.Forms.ComboBox();
            this.Groupe_Label = new System.Windows.Forms.Label();
            this.Nom_Label = new System.Windows.Forms.Label();
            this.Prenom_Label = new System.Windows.Forms.Label();
            this.PWD_Label = new System.Windows.Forms.Label();
            this.Identity_Label = new System.Windows.Forms.Label();
            this.Role_Label = new System.Windows.Forms.Label();
            this.Enter_Button = new System.Windows.Forms.Button();
            this.PanelGestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_GridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.PanelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelGestion
            // 
            this.PanelGestion.Controls.Add(this.Gestion_GridView);
            this.PanelGestion.Location = new System.Drawing.Point(0, 0);
            this.PanelGestion.Name = "PanelGestion";
            this.PanelGestion.Size = new System.Drawing.Size(1206, 270);
            this.PanelGestion.TabIndex = 0;
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
            this.Gestion_GridView.Size = new System.Drawing.Size(1206, 270);
            this.Gestion_GridView.TabIndex = 0;
            this.Gestion_GridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GestionCellMouseUp);
            this.Gestion_GridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_DataGrid_RowValidated);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClicDroitSupprimer});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 26);
            // 
            // ClicDroitSupprimer
            // 
            this.ClicDroitSupprimer.Name = "ClicDroitSupprimer";
            this.ClicDroitSupprimer.Size = new System.Drawing.Size(129, 22);
            this.ClicDroitSupprimer.Text = "Supprimer";
            this.ClicDroitSupprimer.Click += new System.EventHandler(this.ClicDroitSupprimer_Click);
            // 
            // SQL_TB
            // 
            this.SQL_TB.Location = new System.Drawing.Point(12, 311);
            this.SQL_TB.Multiline = true;
            this.SQL_TB.Name = "SQL_TB";
            this.SQL_TB.Size = new System.Drawing.Size(459, 229);
            this.SQL_TB.TabIndex = 1;
            // 
            // AjouterButton
            // 
            this.AjouterButton.Location = new System.Drawing.Point(13, 282);
            this.AjouterButton.Name = "AjouterButton";
            this.AjouterButton.Size = new System.Drawing.Size(219, 23);
            this.AjouterButton.TabIndex = 2;
            this.AjouterButton.Text = "Ajouter";
            this.AjouterButton.UseVisualStyleBackColor = true;
            this.AjouterButton.Click += new System.EventHandler(this.AjouterButton_Click);
            // 
            // SupprimerButton
            // 
            this.SupprimerButton.Location = new System.Drawing.Point(238, 281);
            this.SupprimerButton.Name = "SupprimerButton";
            this.SupprimerButton.Size = new System.Drawing.Size(232, 23);
            this.SupprimerButton.TabIndex = 3;
            this.SupprimerButton.Text = "Supprimer";
            this.SupprimerButton.UseVisualStyleBackColor = true;
            this.SupprimerButton.Click += new System.EventHandler(this.SupprimerButton_Click);
            // 
            // SQL_Label
            // 
            this.SQL_Label.AutoSize = true;
            this.SQL_Label.Location = new System.Drawing.Point(10, 560);
            this.SQL_Label.Name = "SQL_Label";
            this.SQL_Label.Size = new System.Drawing.Size(78, 13);
            this.SQL_Label.TabIndex = 4;
            this.SQL_Label.Text = "Mot de Passe :";
            // 
            // SQLpwd_TB
            // 
            this.SQLpwd_TB.Location = new System.Drawing.Point(120, 557);
            this.SQLpwd_TB.Name = "SQLpwd_TB";
            this.SQLpwd_TB.Size = new System.Drawing.Size(350, 20);
            this.SQLpwd_TB.TabIndex = 5;
            // 
            // SQLentrer_Button
            // 
            this.SQLentrer_Button.Location = new System.Drawing.Point(321, 594);
            this.SQLentrer_Button.Name = "SQLentrer_Button";
            this.SQLentrer_Button.Size = new System.Drawing.Size(149, 41);
            this.SQLentrer_Button.TabIndex = 6;
            this.SQLentrer_Button.Text = "Entrer";
            this.SQLentrer_Button.UseVisualStyleBackColor = true;
            this.SQLentrer_Button.Click += new System.EventHandler(this.SQLentrer_Button_Click);
            // 
            // PanelAdd
            // 
            this.PanelAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanelAdd.Controls.Add(this.Groupe_CB);
            this.PanelAdd.Controls.Add(this.Nom_Box);
            this.PanelAdd.Controls.Add(this.Prenom_Box);
            this.PanelAdd.Controls.Add(this.PWD_Box);
            this.PanelAdd.Controls.Add(this.Identity_Box);
            this.PanelAdd.Controls.Add(this.Role_CB);
            this.PanelAdd.Controls.Add(this.Groupe_Label);
            this.PanelAdd.Controls.Add(this.Nom_Label);
            this.PanelAdd.Controls.Add(this.Prenom_Label);
            this.PanelAdd.Controls.Add(this.PWD_Label);
            this.PanelAdd.Controls.Add(this.Identity_Label);
            this.PanelAdd.Controls.Add(this.Role_Label);
            this.PanelAdd.Controls.Add(this.Enter_Button);
            this.PanelAdd.Location = new System.Drawing.Point(509, 282);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(686, 353);
            this.PanelAdd.TabIndex = 8;
            // 
            // Groupe_CB
            // 
            this.Groupe_CB.FormattingEnabled = true;
            this.Groupe_CB.Location = new System.Drawing.Point(172, 210);
            this.Groupe_CB.Name = "Groupe_CB";
            this.Groupe_CB.Size = new System.Drawing.Size(264, 21);
            this.Groupe_CB.TabIndex = 19;
            // 
            // Nom_Box
            // 
            this.Nom_Box.Location = new System.Drawing.Point(172, 170);
            this.Nom_Box.Name = "Nom_Box";
            this.Nom_Box.Size = new System.Drawing.Size(264, 20);
            this.Nom_Box.TabIndex = 18;
            // 
            // Prenom_Box
            // 
            this.Prenom_Box.Location = new System.Drawing.Point(172, 130);
            this.Prenom_Box.Name = "Prenom_Box";
            this.Prenom_Box.Size = new System.Drawing.Size(264, 20);
            this.Prenom_Box.TabIndex = 17;
            // 
            // PWD_Box
            // 
            this.PWD_Box.Location = new System.Drawing.Point(172, 90);
            this.PWD_Box.Name = "PWD_Box";
            this.PWD_Box.Size = new System.Drawing.Size(264, 20);
            this.PWD_Box.TabIndex = 16;
            // 
            // Identity_Box
            // 
            this.Identity_Box.Location = new System.Drawing.Point(172, 50);
            this.Identity_Box.Name = "Identity_Box";
            this.Identity_Box.Size = new System.Drawing.Size(264, 20);
            this.Identity_Box.TabIndex = 15;
            // 
            // Role_CB
            // 
            this.Role_CB.FormattingEnabled = true;
            this.Role_CB.Location = new System.Drawing.Point(172, 7);
            this.Role_CB.Name = "Role_CB";
            this.Role_CB.Size = new System.Drawing.Size(264, 21);
            this.Role_CB.TabIndex = 14;
            // 
            // Groupe_Label
            // 
            this.Groupe_Label.AutoSize = true;
            this.Groupe_Label.Location = new System.Drawing.Point(12, 210);
            this.Groupe_Label.Name = "Groupe_Label";
            this.Groupe_Label.Size = new System.Drawing.Size(114, 13);
            this.Groupe_Label.TabIndex = 13;
            this.Groupe_Label.Text = "Groupe de l\'utilisateur :";
            // 
            // Nom_Label
            // 
            this.Nom_Label.AutoSize = true;
            this.Nom_Label.Location = new System.Drawing.Point(12, 170);
            this.Nom_Label.Name = "Nom_Label";
            this.Nom_Label.Size = new System.Drawing.Size(101, 13);
            this.Nom_Label.TabIndex = 12;
            this.Nom_Label.Text = "Nom de l\'utilisateur :";
            // 
            // Prenom_Label
            // 
            this.Prenom_Label.AutoSize = true;
            this.Prenom_Label.Location = new System.Drawing.Point(12, 130);
            this.Prenom_Label.Name = "Prenom_Label";
            this.Prenom_Label.Size = new System.Drawing.Size(115, 13);
            this.Prenom_Label.TabIndex = 11;
            this.Prenom_Label.Text = "Prénom de l\'utilisateur :";
            // 
            // PWD_Label
            // 
            this.PWD_Label.AutoSize = true;
            this.PWD_Label.Location = new System.Drawing.Point(12, 90);
            this.PWD_Label.Name = "PWD_Label";
            this.PWD_Label.Size = new System.Drawing.Size(77, 13);
            this.PWD_Label.TabIndex = 10;
            this.PWD_Label.Text = "Mot de passe :";
            // 
            // Identity_Label
            // 
            this.Identity_Label.AutoSize = true;
            this.Identity_Label.Location = new System.Drawing.Point(12, 50);
            this.Identity_Label.Name = "Identity_Label";
            this.Identity_Label.Size = new System.Drawing.Size(119, 13);
            this.Identity_Label.TabIndex = 9;
            this.Identity_Label.Text = "Identité de connection :";
            // 
            // Role_Label
            // 
            this.Role_Label.AutoSize = true;
            this.Role_Label.Location = new System.Drawing.Point(12, 10);
            this.Role_Label.Name = "Role_Label";
            this.Role_Label.Size = new System.Drawing.Size(101, 13);
            this.Role_Label.TabIndex = 8;
            this.Role_Label.Text = "Role de l\'utilisateur :";
            // 
            // Enter_Button
            // 
            this.Enter_Button.Location = new System.Drawing.Point(523, 297);
            this.Enter_Button.Name = "Enter_Button";
            this.Enter_Button.Size = new System.Drawing.Size(149, 41);
            this.Enter_Button.TabIndex = 7;
            this.Enter_Button.Text = "Entrer";
            this.Enter_Button.UseVisualStyleBackColor = true;
            this.Enter_Button.Click += new System.EventHandler(this.Enter_Button_Click);
            // 
            // GestionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1199, 637);
            this.Controls.Add(this.PanelAdd);
            this.Controls.Add(this.SQLentrer_Button);
            this.Controls.Add(this.SQLpwd_TB);
            this.Controls.Add(this.SQL_Label);
            this.Controls.Add(this.SupprimerButton);
            this.Controls.Add(this.AjouterButton);
            this.Controls.Add(this.SQL_TB);
            this.Controls.Add(this.PanelGestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "GestionUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des utilisateurs";
            this.PanelGestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_GridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.PanelAdd.ResumeLayout(false);
            this.PanelAdd.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelGestion;
        private System.Windows.Forms.DataGridView Gestion_GridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ClicDroitSupprimer;
        private System.Windows.Forms.TextBox SQL_TB;
        private System.Windows.Forms.Button AjouterButton;
        private System.Windows.Forms.Button SupprimerButton;
        private System.Windows.Forms.Label SQL_Label;
        private System.Windows.Forms.TextBox SQLpwd_TB;
        private System.Windows.Forms.Button SQLentrer_Button;
        private System.Windows.Forms.Panel PanelAdd;
        private System.Windows.Forms.Button Enter_Button;
        private System.Windows.Forms.Label Nom_Label;
        private System.Windows.Forms.Label Prenom_Label;
        private System.Windows.Forms.Label PWD_Label;
        private System.Windows.Forms.Label Identity_Label;
        private System.Windows.Forms.Label Role_Label;
        private System.Windows.Forms.Label Groupe_Label;
        private System.Windows.Forms.ComboBox Role_CB;
        private System.Windows.Forms.ComboBox Groupe_CB;
        private System.Windows.Forms.TextBox Nom_Box;
        private System.Windows.Forms.TextBox Prenom_Box;
        private System.Windows.Forms.TextBox PWD_Box;
        private System.Windows.Forms.TextBox Identity_Box;
    }
}