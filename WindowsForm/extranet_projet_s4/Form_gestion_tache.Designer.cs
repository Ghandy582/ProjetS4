namespace extranet_projet_s4
{
    partial class Form_gestion_tache
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gestion_tache_tache_a_realiser_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gestion_tache_nouvelletache_btn = new System.Windows.Forms.Button();
            this.gestion_tache_accesrapide_btn = new System.Windows.Forms.Button();
            this.gestion_taches_menu = new System.Windows.Forms.MenuStrip();
            this.gestion_tache_menu_aaccueil = new System.Windows.Forms.ToolStripMenuItem();
            this.gestion_tache_menu_taches = new System.Windows.Forms.ToolStripMenuItem();
            this.gestion_tache_menu_acces_rapide_taches = new System.Windows.Forms.ToolStripMenuItem();
            this.gestion_tache_menu_nouvelle_tache = new System.Windows.Forms.ToolStripMenuItem();
            this.gestion_tache_menu_parametres = new System.Windows.Forms.ToolStripMenuItem();
            this.gestion_tache_tache_a_realiser_datagrid = new System.Windows.Forms.DataGridView();
            this.gestion_tache_tache_realisees_datagrid = new System.Windows.Forms.DataGridView();
            this.gestion_taches_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_tache_tache_a_realiser_datagrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_tache_tache_realisees_datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // gestion_tache_tache_a_realiser_label
            // 
            this.gestion_tache_tache_a_realiser_label.AutoSize = true;
            this.gestion_tache_tache_a_realiser_label.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestion_tache_tache_a_realiser_label.Location = new System.Drawing.Point(8, 46);
            this.gestion_tache_tache_a_realiser_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gestion_tache_tache_a_realiser_label.Name = "gestion_tache_tache_a_realiser_label";
            this.gestion_tache_tache_a_realiser_label.Size = new System.Drawing.Size(331, 44);
            this.gestion_tache_tache_a_realiser_label.TabIndex = 0;
            this.gestion_tache_tache_a_realiser_label.Text = "Tâches à réaliser :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 440);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tâches récemment réalisées :";
            // 
            // gestion_tache_nouvelletache_btn
            // 
            this.gestion_tache_nouvelletache_btn.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestion_tache_nouvelletache_btn.Location = new System.Drawing.Point(1079, 548);
            this.gestion_tache_nouvelletache_btn.Margin = new System.Windows.Forms.Padding(2);
            this.gestion_tache_nouvelletache_btn.Name = "gestion_tache_nouvelletache_btn";
            this.gestion_tache_nouvelletache_btn.Size = new System.Drawing.Size(216, 58);
            this.gestion_tache_nouvelletache_btn.TabIndex = 2;
            this.gestion_tache_nouvelletache_btn.Text = "Nouvelle tâche";
            this.gestion_tache_nouvelletache_btn.UseVisualStyleBackColor = true;
            this.gestion_tache_nouvelletache_btn.Click += new System.EventHandler(this.gestion_tache_nouvelletache_btn_Click);
            // 
            // gestion_tache_accesrapide_btn
            // 
            this.gestion_tache_accesrapide_btn.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestion_tache_accesrapide_btn.Location = new System.Drawing.Point(1079, 633);
            this.gestion_tache_accesrapide_btn.Margin = new System.Windows.Forms.Padding(2);
            this.gestion_tache_accesrapide_btn.Name = "gestion_tache_accesrapide_btn";
            this.gestion_tache_accesrapide_btn.Size = new System.Drawing.Size(216, 58);
            this.gestion_tache_accesrapide_btn.TabIndex = 3;
            this.gestion_tache_accesrapide_btn.Text = "Ouvrir l\'accès rapide";
            this.gestion_tache_accesrapide_btn.UseVisualStyleBackColor = true;
            this.gestion_tache_accesrapide_btn.Click += new System.EventHandler(this.gestion_tache_accesrapide_btn_Click);
            // 
            // gestion_taches_menu
            // 
            this.gestion_taches_menu.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestion_taches_menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.gestion_taches_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestion_tache_menu_aaccueil,
            this.gestion_tache_menu_taches});
            this.gestion_taches_menu.Location = new System.Drawing.Point(0, 0);
            this.gestion_taches_menu.Name = "gestion_taches_menu";
            this.gestion_taches_menu.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.gestion_taches_menu.Size = new System.Drawing.Size(1407, 35);
            this.gestion_taches_menu.TabIndex = 4;
            this.gestion_taches_menu.Text = "menuStrip1";
            this.gestion_taches_menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.gestion_taches_menu_ItemClicked);
            // 
            // gestion_tache_menu_aaccueil
            // 
            this.gestion_tache_menu_aaccueil.Name = "gestion_tache_menu_aaccueil";
            this.gestion_tache_menu_aaccueil.Size = new System.Drawing.Size(82, 27);
            this.gestion_tache_menu_aaccueil.Text = "Accueil";
            this.gestion_tache_menu_aaccueil.Click += new System.EventHandler(this.gestion_tache_menu_aaccueil_Click);
            // 
            // gestion_tache_menu_taches
            // 
            this.gestion_tache_menu_taches.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestion_tache_menu_acces_rapide_taches,
            this.gestion_tache_menu_nouvelle_tache,
            this.gestion_tache_menu_parametres});
            this.gestion_tache_menu_taches.Name = "gestion_tache_menu_taches";
            this.gestion_tache_menu_taches.Size = new System.Drawing.Size(81, 27);
            this.gestion_tache_menu_taches.Text = "Tâches";
            // 
            // gestion_tache_menu_acces_rapide_taches
            // 
            this.gestion_tache_menu_acces_rapide_taches.Name = "gestion_tache_menu_acces_rapide_taches";
            this.gestion_tache_menu_acces_rapide_taches.Size = new System.Drawing.Size(217, 30);
            this.gestion_tache_menu_acces_rapide_taches.Text = "Accès rapide";
            this.gestion_tache_menu_acces_rapide_taches.Click += new System.EventHandler(this.gestion_tache_menu_acces_rapide_taches_Click);
            // 
            // gestion_tache_menu_nouvelle_tache
            // 
            this.gestion_tache_menu_nouvelle_tache.Name = "gestion_tache_menu_nouvelle_tache";
            this.gestion_tache_menu_nouvelle_tache.Size = new System.Drawing.Size(217, 30);
            this.gestion_tache_menu_nouvelle_tache.Text = "Nouvelle tâche";
            this.gestion_tache_menu_nouvelle_tache.Click += new System.EventHandler(this.gestion_tache_menu_nouvelle_tache_Click);
            // 
            // gestion_tache_menu_parametres
            // 
            this.gestion_tache_menu_parametres.Name = "gestion_tache_menu_parametres";
            this.gestion_tache_menu_parametres.Size = new System.Drawing.Size(217, 30);
            this.gestion_tache_menu_parametres.Text = "Paramètres";
            this.gestion_tache_menu_parametres.Click += new System.EventHandler(this.gestion_tache_menu_parametres_Click);
            // 
            // gestion_tache_tache_a_realiser_datagrid
            // 
            this.gestion_tache_tache_a_realiser_datagrid.AllowUserToAddRows = false;
            this.gestion_tache_tache_a_realiser_datagrid.AllowUserToDeleteRows = false;
            this.gestion_tache_tache_a_realiser_datagrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestion_tache_tache_a_realiser_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gestion_tache_tache_a_realiser_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gestion_tache_tache_a_realiser_datagrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gestion_tache_tache_a_realiser_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gestion_tache_tache_a_realiser_datagrid.GridColor = System.Drawing.SystemColors.MenuText;
            this.gestion_tache_tache_a_realiser_datagrid.Location = new System.Drawing.Point(15, 104);
            this.gestion_tache_tache_a_realiser_datagrid.Margin = new System.Windows.Forms.Padding(2);
            this.gestion_tache_tache_a_realiser_datagrid.Name = "gestion_tache_tache_a_realiser_datagrid";
            this.gestion_tache_tache_a_realiser_datagrid.ReadOnly = true;
            this.gestion_tache_tache_a_realiser_datagrid.RowTemplate.Height = 46;
            this.gestion_tache_tache_a_realiser_datagrid.Size = new System.Drawing.Size(1377, 316);
            this.gestion_tache_tache_a_realiser_datagrid.TabIndex = 5;
            // 
            // gestion_tache_tache_realisees_datagrid
            // 
            this.gestion_tache_tache_realisees_datagrid.AllowUserToAddRows = false;
            this.gestion_tache_tache_realisees_datagrid.AllowUserToDeleteRows = false;
            this.gestion_tache_tache_realisees_datagrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestion_tache_tache_realisees_datagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.gestion_tache_tache_realisees_datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gestion_tache_tache_realisees_datagrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.gestion_tache_tache_realisees_datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gestion_tache_tache_realisees_datagrid.GridColor = System.Drawing.SystemColors.MenuText;
            this.gestion_tache_tache_realisees_datagrid.Location = new System.Drawing.Point(15, 498);
            this.gestion_tache_tache_realisees_datagrid.Margin = new System.Windows.Forms.Padding(2);
            this.gestion_tache_tache_realisees_datagrid.Name = "gestion_tache_tache_realisees_datagrid";
            this.gestion_tache_tache_realisees_datagrid.ReadOnly = true;
            this.gestion_tache_tache_realisees_datagrid.RowTemplate.Height = 46;
            this.gestion_tache_tache_realisees_datagrid.Size = new System.Drawing.Size(930, 242);
            this.gestion_tache_tache_realisees_datagrid.TabIndex = 6;
            this.gestion_tache_tache_realisees_datagrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Form_gestion_tache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1407, 771);
            this.Controls.Add(this.gestion_tache_tache_realisees_datagrid);
            this.Controls.Add(this.gestion_tache_tache_a_realiser_datagrid);
            this.Controls.Add(this.gestion_taches_menu);
            this.Controls.Add(this.gestion_tache_accesrapide_btn);
            this.Controls.Add(this.gestion_tache_nouvelletache_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gestion_tache_tache_a_realiser_label);
            this.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form_gestion_tache";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des tâches";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_gestion_tache_FormClosed);
            this.Load += new System.EventHandler(this.Form_gestion_tache_Load);
            this.gestion_taches_menu.ResumeLayout(false);
            this.gestion_taches_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_tache_tache_a_realiser_datagrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gestion_tache_tache_realisees_datagrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gestion_tache_tache_a_realiser_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gestion_tache_nouvelletache_btn;
        private System.Windows.Forms.Button gestion_tache_accesrapide_btn;
        private System.Windows.Forms.MenuStrip gestion_taches_menu;
        private System.Windows.Forms.ToolStripMenuItem gestion_tache_menu_taches;
        private System.Windows.Forms.ToolStripMenuItem gestion_tache_menu_acces_rapide_taches;
        private System.Windows.Forms.ToolStripMenuItem gestion_tache_menu_nouvelle_tache;
        private System.Windows.Forms.ToolStripMenuItem gestion_tache_menu_aaccueil;
        private System.Windows.Forms.DataGridView gestion_tache_tache_a_realiser_datagrid;
        private System.Windows.Forms.ToolStripMenuItem gestion_tache_menu_parametres;
        private System.Windows.Forms.DataGridView gestion_tache_tache_realisees_datagrid;
    }
}