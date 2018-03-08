namespace extranet_projet_s4
{
    partial class Form_AdminGestionGroupe
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
            this.Panel_GridView = new System.Windows.Forms.Panel();
            this.Gestion_GridView = new System.Windows.Forms.DataGridView();
            this.SQL_Box = new System.Windows.Forms.TextBox();
            this.Ajouter_Button = new System.Windows.Forms.Button();
            this.Supprimer_Button = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Libelle_Box = new System.Windows.Forms.TextBox();
            this.Entrer_Button = new System.Windows.Forms.Button();
            this.Libelle_Label = new System.Windows.Forms.Label();
            this.SQLEntrer_Button = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClicDroitSupprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.Panel_GridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_GridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_GridView
            // 
            this.Panel_GridView.Controls.Add(this.Gestion_GridView);
            this.Panel_GridView.Location = new System.Drawing.Point(0, -6);
            this.Panel_GridView.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Panel_GridView.Name = "Panel_GridView";
            this.Panel_GridView.Size = new System.Drawing.Size(1340, 643);
            this.Panel_GridView.TabIndex = 0;
            // 
            // Gestion_GridView
            // 
            this.Gestion_GridView.AllowUserToAddRows = false;
            this.Gestion_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gestion_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gestion_GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gestion_GridView.Location = new System.Drawing.Point(0, 0);
            this.Gestion_GridView.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Gestion_GridView.MultiSelect = false;
            this.Gestion_GridView.Name = "Gestion_GridView";
            this.Gestion_GridView.Size = new System.Drawing.Size(1340, 643);
            this.Gestion_GridView.TabIndex = 0;
            this.Gestion_GridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GestionCellMouseUp);
            // 
            // SQL_Box
            // 
            this.SQL_Box.Location = new System.Drawing.Point(38, 760);
            this.SQL_Box.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.SQL_Box.Multiline = true;
            this.SQL_Box.Name = "SQL_Box";
            this.SQL_Box.Size = new System.Drawing.Size(1245, 334);
            this.SQL_Box.TabIndex = 1;
            // 
            // Ajouter_Button
            // 
            this.Ajouter_Button.Location = new System.Drawing.Point(38, 677);
            this.Ajouter_Button.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Ajouter_Button.Name = "Ajouter_Button";
            this.Ajouter_Button.Size = new System.Drawing.Size(602, 65);
            this.Ajouter_Button.TabIndex = 2;
            this.Ajouter_Button.Text = "Ajouter";
            this.Ajouter_Button.UseVisualStyleBackColor = true;
            this.Ajouter_Button.Click += new System.EventHandler(this.Ajouter_Button_Click);
            // 
            // Supprimer_Button
            // 
            this.Supprimer_Button.Location = new System.Drawing.Point(697, 677);
            this.Supprimer_Button.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Supprimer_Button.Name = "Supprimer_Button";
            this.Supprimer_Button.Size = new System.Drawing.Size(595, 65);
            this.Supprimer_Button.TabIndex = 3;
            this.Supprimer_Button.Text = "Supprimer";
            this.Supprimer_Button.UseVisualStyleBackColor = true;
            this.Supprimer_Button.Click += new System.EventHandler(this.Supprimer_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.Libelle_Box);
            this.panel1.Controls.Add(this.Entrer_Button);
            this.panel1.Controls.Add(this.Libelle_Label);
            this.panel1.Location = new System.Drawing.Point(38, 1244);
            this.panel1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1257, 282);
            this.panel1.TabIndex = 4;
            // 
            // Libelle_Box
            // 
            this.Libelle_Box.Location = new System.Drawing.Point(459, 34);
            this.Libelle_Box.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Libelle_Box.Name = "Libelle_Box";
            this.Libelle_Box.Size = new System.Drawing.Size(780, 44);
            this.Libelle_Box.TabIndex = 7;
            // 
            // Entrer_Button
            // 
            this.Entrer_Button.Location = new System.Drawing.Point(814, 168);
            this.Entrer_Button.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Entrer_Button.Name = "Entrer_Button";
            this.Entrer_Button.Size = new System.Drawing.Size(443, 105);
            this.Entrer_Button.TabIndex = 6;
            this.Entrer_Button.Text = "Entrer";
            this.Entrer_Button.UseVisualStyleBackColor = true;
            this.Entrer_Button.Click += new System.EventHandler(this.Entrer_Button_Click);
            // 
            // Libelle_Label
            // 
            this.Libelle_Label.AutoSize = true;
            this.Libelle_Label.Location = new System.Drawing.Point(48, 43);
            this.Libelle_Label.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.Libelle_Label.Name = "Libelle_Label";
            this.Libelle_Label.Size = new System.Drawing.Size(287, 37);
            this.Libelle_Label.TabIndex = 0;
            this.Libelle_Label.Text = "Libellé du Groupe :";
            // 
            // SQLEntrer_Button
            // 
            this.SQLEntrer_Button.Location = new System.Drawing.Point(849, 1121);
            this.SQLEntrer_Button.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.SQLEntrer_Button.Name = "SQLEntrer_Button";
            this.SQLEntrer_Button.Size = new System.Drawing.Size(443, 105);
            this.SQLEntrer_Button.TabIndex = 5;
            this.SQLEntrer_Button.Text = "Entrer";
            this.SQLEntrer_Button.UseVisualStyleBackColor = true;
            this.SQLEntrer_Button.Click += new System.EventHandler(this.SQLEntrer_Button_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(48, 48);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClicDroitSupprimer});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(267, 56);
            // 
            // ClicDroitSupprimer
            // 
            this.ClicDroitSupprimer.Name = "ClicDroitSupprimer";
            this.ClicDroitSupprimer.Size = new System.Drawing.Size(266, 52);
            this.ClicDroitSupprimer.Text = "Supprimer";
            this.ClicDroitSupprimer.Click += new System.EventHandler(this.ClicDroitSupprimer_Click);
            // 
            // Form_AdminGestionGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1333, 1545);
            this.Controls.Add(this.SQLEntrer_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Supprimer_Button);
            this.Controls.Add(this.Ajouter_Button);
            this.Controls.Add(this.SQL_Box);
            this.Controls.Add(this.Panel_GridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "Form_AdminGestionGroupe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_AdminGestionGroupe";
            this.Panel_GridView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_GridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_GridView;
        private System.Windows.Forms.DataGridView Gestion_GridView;
        private System.Windows.Forms.TextBox SQL_Box;
        private System.Windows.Forms.Button Ajouter_Button;
        private System.Windows.Forms.Button Supprimer_Button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Libelle_Label;
        private System.Windows.Forms.Button SQLEntrer_Button;
        private System.Windows.Forms.Button Entrer_Button;
        private System.Windows.Forms.TextBox Libelle_Box;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ClicDroitSupprimer;
    }
}