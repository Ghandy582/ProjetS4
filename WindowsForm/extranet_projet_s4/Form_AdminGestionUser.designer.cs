﻿namespace extranet_projet_s4
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
            this.label5 = new System.Windows.Forms.Label();
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.PanelGestion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelGestion.Name = "PanelGestion";
            this.PanelGestion.Size = new System.Drawing.Size(1809, 405);
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
            this.Gestion_GridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Gestion_GridView.Name = "Gestion_GridView";
            this.Gestion_GridView.Size = new System.Drawing.Size(1809, 405);
            this.Gestion_GridView.TabIndex = 0;
            this.Gestion_GridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Gestion_GridView_CellContentClick);
            this.Gestion_GridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GestionCellMouseUp);
            this.Gestion_GridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_DataGrid_RowValidated);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClicDroitSupprimer});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 34);
            // 
            // ClicDroitSupprimer
            // 
            this.ClicDroitSupprimer.Name = "ClicDroitSupprimer";
            this.ClicDroitSupprimer.Size = new System.Drawing.Size(167, 30);
            this.ClicDroitSupprimer.Text = "Supprimer";
            this.ClicDroitSupprimer.Click += new System.EventHandler(this.ClicDroitSupprimer_Click);
            // 
            // SQL_TB
            // 
            this.SQL_TB.Location = new System.Drawing.Point(18, 588);
            this.SQL_TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SQL_TB.Multiline = true;
            this.SQL_TB.Name = "SQL_TB";
            this.SQL_TB.Size = new System.Drawing.Size(686, 220);
            this.SQL_TB.TabIndex = 1;
            // 
            // AjouterButton
            // 
            this.AjouterButton.Location = new System.Drawing.Point(21, 546);
            this.AjouterButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AjouterButton.Name = "AjouterButton";
            this.AjouterButton.Size = new System.Drawing.Size(328, 34);
            this.AjouterButton.TabIndex = 2;
            this.AjouterButton.Text = "Ajouter";
            this.AjouterButton.UseVisualStyleBackColor = true;
            this.AjouterButton.Click += new System.EventHandler(this.AjouterButton_Click);
            // 
            // SupprimerButton
            // 
            this.SupprimerButton.Location = new System.Drawing.Point(358, 544);
            this.SupprimerButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SupprimerButton.Name = "SupprimerButton";
            this.SupprimerButton.Size = new System.Drawing.Size(348, 34);
            this.SupprimerButton.TabIndex = 3;
            this.SupprimerButton.Text = "Supprimer";
            this.SupprimerButton.UseVisualStyleBackColor = true;
            this.SupprimerButton.Click += new System.EventHandler(this.SupprimerButton_Click);
            // 
            // SQL_Label
            // 
            this.SQL_Label.AutoSize = true;
            this.SQL_Label.Location = new System.Drawing.Point(15, 840);
            this.SQL_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.SQL_Label.Name = "SQL_Label";
            this.SQL_Label.Size = new System.Drawing.Size(114, 20);
            this.SQL_Label.TabIndex = 4;
            this.SQL_Label.Text = "Mot de Passe :";
            // 
            // SQLpwd_TB
            // 
            this.SQLpwd_TB.Location = new System.Drawing.Point(180, 836);
            this.SQLpwd_TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SQLpwd_TB.Name = "SQLpwd_TB";
            this.SQLpwd_TB.Size = new System.Drawing.Size(523, 26);
            this.SQLpwd_TB.TabIndex = 5;
            // 
            // SQLentrer_Button
            // 
            this.SQLentrer_Button.Location = new System.Drawing.Point(482, 891);
            this.SQLentrer_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.SQLentrer_Button.Name = "SQLentrer_Button";
            this.SQLentrer_Button.Size = new System.Drawing.Size(224, 62);
            this.SQLentrer_Button.TabIndex = 6;
            this.SQLentrer_Button.Text = "Entrer";
            this.SQLentrer_Button.UseVisualStyleBackColor = true;
            this.SQLentrer_Button.Click += new System.EventHandler(this.SQLentrer_Button_Click);
            // 
            // PanelAdd
            // 
            this.PanelAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanelAdd.Controls.Add(this.label5);
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
            this.PanelAdd.Location = new System.Drawing.Point(764, 498);
            this.PanelAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(1029, 454);
            this.PanelAdd.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 0);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(251, 32);
            this.label5.TabIndex = 22;
            this.label5.Text = "Insérer données :";
            // 
            // Groupe_CB
            // 
            this.Groupe_CB.FormattingEnabled = true;
            this.Groupe_CB.Location = new System.Drawing.Point(266, 394);
            this.Groupe_CB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Groupe_CB.Name = "Groupe_CB";
            this.Groupe_CB.Size = new System.Drawing.Size(394, 28);
            this.Groupe_CB.TabIndex = 19;
            // 
            // Nom_Box
            // 
            this.Nom_Box.Location = new System.Drawing.Point(266, 334);
            this.Nom_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nom_Box.Name = "Nom_Box";
            this.Nom_Box.Size = new System.Drawing.Size(394, 26);
            this.Nom_Box.TabIndex = 18;
            // 
            // Prenom_Box
            // 
            this.Prenom_Box.Location = new System.Drawing.Point(266, 274);
            this.Prenom_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Prenom_Box.Name = "Prenom_Box";
            this.Prenom_Box.Size = new System.Drawing.Size(394, 26);
            this.Prenom_Box.TabIndex = 17;
            // 
            // PWD_Box
            // 
            this.PWD_Box.Location = new System.Drawing.Point(266, 214);
            this.PWD_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PWD_Box.Name = "PWD_Box";
            this.PWD_Box.Size = new System.Drawing.Size(394, 26);
            this.PWD_Box.TabIndex = 16;
            // 
            // Identity_Box
            // 
            this.Identity_Box.Location = new System.Drawing.Point(266, 154);
            this.Identity_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Identity_Box.Name = "Identity_Box";
            this.Identity_Box.Size = new System.Drawing.Size(394, 26);
            this.Identity_Box.TabIndex = 15;
            // 
            // Role_CB
            // 
            this.Role_CB.FormattingEnabled = true;
            this.Role_CB.Location = new System.Drawing.Point(266, 90);
            this.Role_CB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Role_CB.Name = "Role_CB";
            this.Role_CB.Size = new System.Drawing.Size(394, 28);
            this.Role_CB.TabIndex = 14;
            // 
            // Groupe_Label
            // 
            this.Groupe_Label.AutoSize = true;
            this.Groupe_Label.Location = new System.Drawing.Point(26, 394);
            this.Groupe_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Groupe_Label.Name = "Groupe_Label";
            this.Groupe_Label.Size = new System.Drawing.Size(171, 20);
            this.Groupe_Label.TabIndex = 13;
            this.Groupe_Label.Text = "Groupe de l\'utilisateur :";
            // 
            // Nom_Label
            // 
            this.Nom_Label.AutoSize = true;
            this.Nom_Label.Location = new System.Drawing.Point(26, 334);
            this.Nom_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Nom_Label.Name = "Nom_Label";
            this.Nom_Label.Size = new System.Drawing.Size(150, 20);
            this.Nom_Label.TabIndex = 12;
            this.Nom_Label.Text = "Nom de l\'utilisateur :";
            // 
            // Prenom_Label
            // 
            this.Prenom_Label.AutoSize = true;
            this.Prenom_Label.Location = new System.Drawing.Point(26, 274);
            this.Prenom_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Prenom_Label.Name = "Prenom_Label";
            this.Prenom_Label.Size = new System.Drawing.Size(172, 20);
            this.Prenom_Label.TabIndex = 11;
            this.Prenom_Label.Text = "Prénom de l\'utilisateur :";
            // 
            // PWD_Label
            // 
            this.PWD_Label.AutoSize = true;
            this.PWD_Label.Location = new System.Drawing.Point(26, 214);
            this.PWD_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PWD_Label.Name = "PWD_Label";
            this.PWD_Label.Size = new System.Drawing.Size(113, 20);
            this.PWD_Label.TabIndex = 10;
            this.PWD_Label.Text = "Mot de passe :";
            // 
            // Identity_Label
            // 
            this.Identity_Label.AutoSize = true;
            this.Identity_Label.Location = new System.Drawing.Point(26, 154);
            this.Identity_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Identity_Label.Name = "Identity_Label";
            this.Identity_Label.Size = new System.Drawing.Size(175, 20);
            this.Identity_Label.TabIndex = 9;
            this.Identity_Label.Text = "Identité de connection :";
            // 
            // Role_Label
            // 
            this.Role_Label.AutoSize = true;
            this.Role_Label.Location = new System.Drawing.Point(26, 94);
            this.Role_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Role_Label.Name = "Role_Label";
            this.Role_Label.Size = new System.Drawing.Size(150, 20);
            this.Role_Label.TabIndex = 8;
            this.Role_Label.Text = "Role de l\'utilisateur :";
            // 
            // Enter_Button
            // 
            this.Enter_Button.Location = new System.Drawing.Point(794, 378);
            this.Enter_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Enter_Button.Name = "Enter_Button";
            this.Enter_Button.Size = new System.Drawing.Size(224, 62);
            this.Enter_Button.TabIndex = 7;
            this.Enter_Button.Text = "Entrer";
            this.Enter_Button.UseVisualStyleBackColor = true;
            this.Enter_Button.Click += new System.EventHandler(this.Enter_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(548, 426);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(509, 40);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ajouter un nouvelle utilisateur :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 498);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 32);
            this.label4.TabIndex = 21;
            this.label4.Text = "Commande SQL :";
            // 
            // GestionUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1798, 956);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PanelAdd);
            this.Controls.Add(this.SQLentrer_Button);
            this.Controls.Add(this.SQLpwd_TB);
            this.Controls.Add(this.SQL_Label);
            this.Controls.Add(this.SupprimerButton);
            this.Controls.Add(this.AjouterButton);
            this.Controls.Add(this.SQL_TB);
            this.Controls.Add(this.PanelGestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}