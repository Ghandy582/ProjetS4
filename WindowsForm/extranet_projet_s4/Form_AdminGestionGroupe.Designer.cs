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
            this.label5 = new System.Windows.Forms.Label();
            this.Libelle_Box = new System.Windows.Forms.TextBox();
            this.Entrer_Button = new System.Windows.Forms.Button();
            this.Libelle_Label = new System.Windows.Forms.Label();
            this.SQLEntrer_Button = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClicDroitSupprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Panel_GridView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_GridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_GridView
            // 
            this.Panel_GridView.Controls.Add(this.Gestion_GridView);
            this.Panel_GridView.Location = new System.Drawing.Point(0, -2);
            this.Panel_GridView.Name = "Panel_GridView";
            this.Panel_GridView.Size = new System.Drawing.Size(423, 226);
            this.Panel_GridView.TabIndex = 0;
            // 
            // Gestion_GridView
            // 
            this.Gestion_GridView.AllowUserToAddRows = false;
            this.Gestion_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gestion_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gestion_GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gestion_GridView.Location = new System.Drawing.Point(0, 0);
            this.Gestion_GridView.MultiSelect = false;
            this.Gestion_GridView.Name = "Gestion_GridView";
            this.Gestion_GridView.Size = new System.Drawing.Size(423, 226);
            this.Gestion_GridView.TabIndex = 0;
            this.Gestion_GridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GestionCellMouseUp);
            this.Gestion_GridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_DataGrid_RowValidated);
            // 
            // SQL_Box
            // 
            this.SQL_Box.Location = new System.Drawing.Point(15, 343);
            this.SQL_Box.Multiline = true;
            this.SQL_Box.Name = "SQL_Box";
            this.SQL_Box.Size = new System.Drawing.Size(396, 90);
            this.SQL_Box.TabIndex = 1;
            // 
            // Ajouter_Button
            // 
            this.Ajouter_Button.Location = new System.Drawing.Point(15, 314);
            this.Ajouter_Button.Name = "Ajouter_Button";
            this.Ajouter_Button.Size = new System.Drawing.Size(190, 23);
            this.Ajouter_Button.TabIndex = 2;
            this.Ajouter_Button.Text = "Ajouter";
            this.Ajouter_Button.UseVisualStyleBackColor = true;
            this.Ajouter_Button.Click += new System.EventHandler(this.Ajouter_Button_Click);
            // 
            // Supprimer_Button
            // 
            this.Supprimer_Button.Location = new System.Drawing.Point(223, 314);
            this.Supprimer_Button.Name = "Supprimer_Button";
            this.Supprimer_Button.Size = new System.Drawing.Size(188, 23);
            this.Supprimer_Button.TabIndex = 3;
            this.Supprimer_Button.Text = "Supprimer";
            this.Supprimer_Button.UseVisualStyleBackColor = true;
            this.Supprimer_Button.Click += new System.EventHandler(this.Supprimer_Button_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Libelle_Box);
            this.panel1.Controls.Add(this.Entrer_Button);
            this.panel1.Controls.Add(this.Libelle_Label);
            this.panel1.Location = new System.Drawing.Point(15, 480);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(397, 99);
            this.panel1.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 24);
            this.label5.TabIndex = 22;
            this.label5.Text = "Insérer données :";
            // 
            // Libelle_Box
            // 
            this.Libelle_Box.Location = new System.Drawing.Point(147, 33);
            this.Libelle_Box.Name = "Libelle_Box";
            this.Libelle_Box.Size = new System.Drawing.Size(249, 20);
            this.Libelle_Box.TabIndex = 7;
            // 
            // Entrer_Button
            // 
            this.Entrer_Button.Location = new System.Drawing.Point(257, 59);
            this.Entrer_Button.Name = "Entrer_Button";
            this.Entrer_Button.Size = new System.Drawing.Size(140, 37);
            this.Entrer_Button.TabIndex = 6;
            this.Entrer_Button.Text = "Entrer";
            this.Entrer_Button.UseVisualStyleBackColor = true;
            this.Entrer_Button.Click += new System.EventHandler(this.Entrer_Button_Click);
            // 
            // Libelle_Label
            // 
            this.Libelle_Label.AutoSize = true;
            this.Libelle_Label.Location = new System.Drawing.Point(13, 33);
            this.Libelle_Label.Name = "Libelle_Label";
            this.Libelle_Label.Size = new System.Drawing.Size(96, 13);
            this.Libelle_Label.TabIndex = 0;
            this.Libelle_Label.Text = "Libellé du Groupe :";
            // 
            // SQLEntrer_Button
            // 
            this.SQLEntrer_Button.Location = new System.Drawing.Point(268, 441);
            this.SQLEntrer_Button.Name = "SQLEntrer_Button";
            this.SQLEntrer_Button.Size = new System.Drawing.Size(140, 37);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 26);
            // 
            // ClicDroitSupprimer
            // 
            this.ClicDroitSupprimer.Name = "ClicDroitSupprimer";
            this.ClicDroitSupprimer.Size = new System.Drawing.Size(129, 22);
            this.ClicDroitSupprimer.Text = "Supprimer";
            this.ClicDroitSupprimer.Click += new System.EventHandler(this.ClicDroitSupprimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ajouter un nouveau groupe de travail:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(175, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Commande SQL :";
            // 
            // Form_AdminGestionGroupe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(424, 591);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SQLEntrer_Button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Supprimer_Button);
            this.Controls.Add(this.Ajouter_Button);
            this.Controls.Add(this.SQL_Box);
            this.Controls.Add(this.Panel_GridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}