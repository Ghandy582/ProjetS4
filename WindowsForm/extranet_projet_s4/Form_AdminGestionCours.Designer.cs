namespace extranet_projet_s4
{
    partial class Form_AdminGestionCours
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
            this.Libelle_Label = new System.Windows.Forms.Label();
            this.Enter_Button = new System.Windows.Forms.Button();
            this.SQLentrer_Button = new System.Windows.Forms.Button();
            this.SupprimerButton = new System.Windows.Forms.Button();
            this.AjouterButton = new System.Windows.Forms.Button();
            this.SQL_TB = new System.Windows.Forms.TextBox();
            this.ClicDroitSupprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.Gestion_GridView = new System.Windows.Forms.DataGridView();
            this.PanelAdd = new System.Windows.Forms.Panel();
            this.Couleur_Panel = new System.Windows.Forms.Panel();
            this.Couleur_Button = new System.Windows.Forms.Button();
            this.Coefficient_Box = new System.Windows.Forms.TextBox();
            this.Libelle_Box = new System.Windows.Forms.TextBox();
            this.Coefficient_Label = new System.Windows.Forms.Label();
            this.PanelGestion = new System.Windows.Forms.Panel();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_GridView)).BeginInit();
            this.PanelAdd.SuspendLayout();
            this.PanelGestion.SuspendLayout();
            this.SuspendLayout();
            // 
            // Libelle_Label
            // 
            this.Libelle_Label.AutoSize = true;
            this.Libelle_Label.Location = new System.Drawing.Point(38, 28);
            this.Libelle_Label.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Libelle_Label.Name = "Libelle_Label";
            this.Libelle_Label.Size = new System.Drawing.Size(259, 37);
            this.Libelle_Label.TabIndex = 8;
            this.Libelle_Label.Text = "Libellé du cours :";
            // 
            // Enter_Button
            // 
            this.Enter_Button.Location = new System.Drawing.Point(48, 418);
            this.Enter_Button.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Enter_Button.Name = "Enter_Button";
            this.Enter_Button.Size = new System.Drawing.Size(472, 117);
            this.Enter_Button.TabIndex = 7;
            this.Enter_Button.Text = "Entrer";
            this.Enter_Button.UseVisualStyleBackColor = true;
            this.Enter_Button.Click += new System.EventHandler(this.Enter_Button_Click);
            // 
            // SQLentrer_Button
            // 
            this.SQLentrer_Button.Location = new System.Drawing.Point(922, 1255);
            this.SQLentrer_Button.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.SQLentrer_Button.Name = "SQLentrer_Button";
            this.SQLentrer_Button.Size = new System.Drawing.Size(472, 117);
            this.SQLentrer_Button.TabIndex = 15;
            this.SQLentrer_Button.Text = "Entrer";
            this.SQLentrer_Button.UseVisualStyleBackColor = true;
            this.SQLentrer_Button.Click += new System.EventHandler(this.SQLentrer_Button_Click);
            // 
            // SupprimerButton
            // 
            this.SupprimerButton.Location = new System.Drawing.Point(709, 803);
            this.SupprimerButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.SupprimerButton.Name = "SupprimerButton";
            this.SupprimerButton.Size = new System.Drawing.Size(684, 65);
            this.SupprimerButton.TabIndex = 12;
            this.SupprimerButton.Text = "Supprimer";
            this.SupprimerButton.UseVisualStyleBackColor = true;
            this.SupprimerButton.Click += new System.EventHandler(this.SupprimerButton_Click);
            // 
            // AjouterButton
            // 
            this.AjouterButton.Location = new System.Drawing.Point(10, 803);
            this.AjouterButton.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.AjouterButton.Name = "AjouterButton";
            this.AjouterButton.Size = new System.Drawing.Size(681, 65);
            this.AjouterButton.TabIndex = 11;
            this.AjouterButton.Text = "Ajouter";
            this.AjouterButton.UseVisualStyleBackColor = true;
            this.AjouterButton.Click += new System.EventHandler(this.AjouterButton_Click);
            // 
            // SQL_TB
            // 
            this.SQL_TB.Location = new System.Drawing.Point(10, 885);
            this.SQL_TB.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.SQL_TB.Multiline = true;
            this.SQL_TB.Name = "SQL_TB";
            this.SQL_TB.Size = new System.Drawing.Size(1375, 337);
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
            this.Gestion_GridView.Size = new System.Drawing.Size(2932, 768);
            this.Gestion_GridView.TabIndex = 0;
            // 
            // PanelAdd
            // 
            this.PanelAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanelAdd.Controls.Add(this.Couleur_Panel);
            this.PanelAdd.Controls.Add(this.Couleur_Button);
            this.PanelAdd.Controls.Add(this.Coefficient_Box);
            this.PanelAdd.Controls.Add(this.Libelle_Box);
            this.PanelAdd.Controls.Add(this.Coefficient_Label);
            this.PanelAdd.Controls.Add(this.Libelle_Label);
            this.PanelAdd.Controls.Add(this.Enter_Button);
            this.PanelAdd.Location = new System.Drawing.Point(1517, 803);
            this.PanelAdd.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(1425, 569);
            this.PanelAdd.TabIndex = 17;
            // 
            // Couleur_Panel
            // 
            this.Couleur_Panel.Location = new System.Drawing.Point(453, 256);
            this.Couleur_Panel.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Couleur_Panel.Name = "Couleur_Panel";
            this.Couleur_Panel.Size = new System.Drawing.Size(944, 60);
            this.Couleur_Panel.TabIndex = 19;
            // 
            // Couleur_Button
            // 
            this.Couleur_Button.Location = new System.Drawing.Point(48, 256);
            this.Couleur_Button.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Couleur_Button.Name = "Couleur_Button";
            this.Couleur_Button.Size = new System.Drawing.Size(329, 60);
            this.Couleur_Button.TabIndex = 18;
            this.Couleur_Button.Text = "Couleur";
            this.Couleur_Button.UseVisualStyleBackColor = true;
            this.Couleur_Button.Click += new System.EventHandler(this.Couleur_Button_Click);
            // 
            // Coefficient_Box
            // 
            this.Coefficient_Box.Location = new System.Drawing.Point(453, 134);
            this.Coefficient_Box.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Coefficient_Box.Name = "Coefficient_Box";
            this.Coefficient_Box.Size = new System.Drawing.Size(935, 44);
            this.Coefficient_Box.TabIndex = 17;
            // 
            // Libelle_Box
            // 
            this.Libelle_Box.Location = new System.Drawing.Point(453, 20);
            this.Libelle_Box.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Libelle_Box.Name = "Libelle_Box";
            this.Libelle_Box.Size = new System.Drawing.Size(935, 44);
            this.Libelle_Box.TabIndex = 16;
            // 
            // Coefficient_Label
            // 
            this.Coefficient_Label.AutoSize = true;
            this.Coefficient_Label.Location = new System.Drawing.Point(38, 142);
            this.Coefficient_Label.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Coefficient_Label.Name = "Coefficient_Label";
            this.Coefficient_Label.Size = new System.Drawing.Size(318, 37);
            this.Coefficient_Label.TabIndex = 15;
            this.Coefficient_Label.Text = "Coefficient du cours :";
            // 
            // PanelGestion
            // 
            this.PanelGestion.Controls.Add(this.Gestion_GridView);
            this.PanelGestion.Location = new System.Drawing.Point(10, 17);
            this.PanelGestion.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.PanelGestion.Name = "PanelGestion";
            this.PanelGestion.Size = new System.Drawing.Size(2932, 768);
            this.PanelGestion.TabIndex = 9;
            // 
            // Form_AdminGestionCours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2951, 1440);
            this.Controls.Add(this.SQLentrer_Button);
            this.Controls.Add(this.SupprimerButton);
            this.Controls.Add(this.AjouterButton);
            this.Controls.Add(this.SQL_TB);
            this.Controls.Add(this.PanelAdd);
            this.Controls.Add(this.PanelGestion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form_AdminGestionCours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AdminGestionCours";
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_GridView)).EndInit();
            this.PanelAdd.ResumeLayout(false);
            this.PanelAdd.PerformLayout();
            this.PanelGestion.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Libelle_Label;
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
        private System.Windows.Forms.Label Coefficient_Label;
        private System.Windows.Forms.Panel Couleur_Panel;
        private System.Windows.Forms.Button Couleur_Button;
        private System.Windows.Forms.TextBox Coefficient_Box;
        private System.Windows.Forms.TextBox Libelle_Box;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}