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
            this.gestion_tache_menu_acces_rapide_taches = new System.Windows.Forms.ToolStripMenuItem();
            this.gestion_tache_menu_nouvelle_tache = new System.Windows.Forms.ToolStripMenuItem();
            this.eleve_menu_tache_parametres = new System.Windows.Forms.ToolStripMenuItem();
            this.form_eleve_lundi_matin_btn = new System.Windows.Forms.Button();
            this.form_eleve_lundi_aprem_btn = new System.Windows.Forms.Button();
            this.form_eleve_mardi_matin_btn = new System.Windows.Forms.Button();
            this.form_eleve_mardi_aprem_btn = new System.Windows.Forms.Button();
            this.form_eleve_mercredi_matin_btn = new System.Windows.Forms.Button();
            this.form_eleve_mercredi_aprem_btn = new System.Windows.Forms.Button();
            this.form_eleve_jeudi_matin_btn = new System.Windows.Forms.Button();
            this.form_eleve_jeudi_aprem_btn = new System.Windows.Forms.Button();
            this.form_eleve_vendredi_matin_btn = new System.Windows.Forms.Button();
            this.form_eleve_vendredi_aprem_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.form_eleve_date_lundi = new System.Windows.Forms.Label();
            this.form_eleve_date_mardi = new System.Windows.Forms.Label();
            this.form_eleve_date_mercredi = new System.Windows.Forms.Label();
            this.form_eleve_date_jeudi = new System.Windows.Forms.Label();
            this.form_eleve_date_vendredi = new System.Windows.Forms.Label();
            this.form_eleve_semaine_suivante_btn = new System.Windows.Forms.Button();
            this.form_eleve_semaine_precedantee_btn = new System.Windows.Forms.Button();
            this.form_eleve_dernieres_notes = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.eleve_menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form_eleve_dernieres_notes)).BeginInit();
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
            this.eleve_menu.Padding = new System.Windows.Forms.Padding(14, 4, 0, 4);
            this.eleve_menu.Size = new System.Drawing.Size(1592, 35);
            this.eleve_menu.TabIndex = 0;
            this.eleve_menu.Text = "menuStrip1";
            // 
            // eleve_menu_taches
            // 
            this.eleve_menu_taches.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eleve_menu_gestion_taches,
            this.gestion_tache_menu_acces_rapide_taches,
            this.gestion_tache_menu_nouvelle_tache,
            this.eleve_menu_tache_parametres});
            this.eleve_menu_taches.Name = "eleve_menu_taches";
            this.eleve_menu_taches.Size = new System.Drawing.Size(81, 27);
            this.eleve_menu_taches.Text = "Tâches";
            this.eleve_menu_taches.Click += new System.EventHandler(this.eleve_menu_taches_Click);
            // 
            // eleve_menu_gestion_taches
            // 
            this.eleve_menu_gestion_taches.Name = "eleve_menu_gestion_taches";
            this.eleve_menu_gestion_taches.Size = new System.Drawing.Size(248, 30);
            this.eleve_menu_gestion_taches.Text = "Gestion des tâches";
            this.eleve_menu_gestion_taches.Click += new System.EventHandler(this.eleve_menu_gestion_taches_Click_1);
            // 
            // gestion_tache_menu_acces_rapide_taches
            // 
            this.gestion_tache_menu_acces_rapide_taches.Name = "gestion_tache_menu_acces_rapide_taches";
            this.gestion_tache_menu_acces_rapide_taches.Size = new System.Drawing.Size(248, 30);
            this.gestion_tache_menu_acces_rapide_taches.Text = "Accès rapide";
            this.gestion_tache_menu_acces_rapide_taches.Click += new System.EventHandler(this.eleve_menu_acces_rapide_taches_Click);
            // 
            // gestion_tache_menu_nouvelle_tache
            // 
            this.gestion_tache_menu_nouvelle_tache.Name = "gestion_tache_menu_nouvelle_tache";
            this.gestion_tache_menu_nouvelle_tache.Size = new System.Drawing.Size(248, 30);
            this.gestion_tache_menu_nouvelle_tache.Text = "Nouvelle tâche";
            this.gestion_tache_menu_nouvelle_tache.Click += new System.EventHandler(this.eleve_menu_nouvelle_tache_Click);
            // 
            // eleve_menu_tache_parametres
            // 
            this.eleve_menu_tache_parametres.Name = "eleve_menu_tache_parametres";
            this.eleve_menu_tache_parametres.Size = new System.Drawing.Size(248, 30);
            this.eleve_menu_tache_parametres.Text = "Paramètres";
            this.eleve_menu_tache_parametres.Click += new System.EventHandler(this.eleve_menu_tache_parametres_Click);
            // 
            // form_eleve_lundi_matin_btn
            // 
            this.form_eleve_lundi_matin_btn.BackColor = System.Drawing.Color.White;
            this.form_eleve_lundi_matin_btn.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_eleve_lundi_matin_btn.Location = new System.Drawing.Point(224, 141);
            this.form_eleve_lundi_matin_btn.Margin = new System.Windows.Forms.Padding(4);
            this.form_eleve_lundi_matin_btn.Name = "form_eleve_lundi_matin_btn";
            this.form_eleve_lundi_matin_btn.Size = new System.Drawing.Size(238, 148);
            this.form_eleve_lundi_matin_btn.TabIndex = 1;
            this.form_eleve_lundi_matin_btn.Text = "Projet Blanc";
            this.form_eleve_lundi_matin_btn.UseVisualStyleBackColor = false;
            this.form_eleve_lundi_matin_btn.Click += new System.EventHandler(this.form_eleve_lundi_matin_btn_Click);
            // 
            // form_eleve_lundi_aprem_btn
            // 
            this.form_eleve_lundi_aprem_btn.BackColor = System.Drawing.Color.White;
            this.form_eleve_lundi_aprem_btn.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_eleve_lundi_aprem_btn.Location = new System.Drawing.Point(224, 323);
            this.form_eleve_lundi_aprem_btn.Margin = new System.Windows.Forms.Padding(4);
            this.form_eleve_lundi_aprem_btn.Name = "form_eleve_lundi_aprem_btn";
            this.form_eleve_lundi_aprem_btn.Size = new System.Drawing.Size(238, 148);
            this.form_eleve_lundi_aprem_btn.TabIndex = 2;
            this.form_eleve_lundi_aprem_btn.Text = "Projet Blanc";
            this.form_eleve_lundi_aprem_btn.UseVisualStyleBackColor = false;
            this.form_eleve_lundi_aprem_btn.Click += new System.EventHandler(this.form_eleve_lundi_aprem_btn_Click);
            // 
            // form_eleve_mardi_matin_btn
            // 
            this.form_eleve_mardi_matin_btn.BackColor = System.Drawing.Color.White;
            this.form_eleve_mardi_matin_btn.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_eleve_mardi_matin_btn.Location = new System.Drawing.Point(488, 141);
            this.form_eleve_mardi_matin_btn.Margin = new System.Windows.Forms.Padding(4);
            this.form_eleve_mardi_matin_btn.Name = "form_eleve_mardi_matin_btn";
            this.form_eleve_mardi_matin_btn.Size = new System.Drawing.Size(238, 148);
            this.form_eleve_mardi_matin_btn.TabIndex = 3;
            this.form_eleve_mardi_matin_btn.Text = "Projet Blanc";
            this.form_eleve_mardi_matin_btn.UseVisualStyleBackColor = false;
            this.form_eleve_mardi_matin_btn.Click += new System.EventHandler(this.form_eleve_mardi_matin_btn_Click);
            // 
            // form_eleve_mardi_aprem_btn
            // 
            this.form_eleve_mardi_aprem_btn.BackColor = System.Drawing.Color.White;
            this.form_eleve_mardi_aprem_btn.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_eleve_mardi_aprem_btn.Location = new System.Drawing.Point(488, 323);
            this.form_eleve_mardi_aprem_btn.Margin = new System.Windows.Forms.Padding(4);
            this.form_eleve_mardi_aprem_btn.Name = "form_eleve_mardi_aprem_btn";
            this.form_eleve_mardi_aprem_btn.Size = new System.Drawing.Size(238, 148);
            this.form_eleve_mardi_aprem_btn.TabIndex = 4;
            this.form_eleve_mardi_aprem_btn.Text = "Projet Blanc";
            this.form_eleve_mardi_aprem_btn.UseVisualStyleBackColor = false;
            this.form_eleve_mardi_aprem_btn.Click += new System.EventHandler(this.form_eleve_mardi_aprem_btn_Click);
            // 
            // form_eleve_mercredi_matin_btn
            // 
            this.form_eleve_mercredi_matin_btn.BackColor = System.Drawing.Color.White;
            this.form_eleve_mercredi_matin_btn.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_eleve_mercredi_matin_btn.Location = new System.Drawing.Point(754, 141);
            this.form_eleve_mercredi_matin_btn.Margin = new System.Windows.Forms.Padding(4);
            this.form_eleve_mercredi_matin_btn.Name = "form_eleve_mercredi_matin_btn";
            this.form_eleve_mercredi_matin_btn.Size = new System.Drawing.Size(238, 148);
            this.form_eleve_mercredi_matin_btn.TabIndex = 5;
            this.form_eleve_mercredi_matin_btn.Text = "Projet Blanc";
            this.form_eleve_mercredi_matin_btn.UseVisualStyleBackColor = false;
            this.form_eleve_mercredi_matin_btn.Click += new System.EventHandler(this.form_eleve_mercredi_matin_btn_Click);
            // 
            // form_eleve_mercredi_aprem_btn
            // 
            this.form_eleve_mercredi_aprem_btn.BackColor = System.Drawing.Color.White;
            this.form_eleve_mercredi_aprem_btn.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_eleve_mercredi_aprem_btn.Location = new System.Drawing.Point(754, 323);
            this.form_eleve_mercredi_aprem_btn.Margin = new System.Windows.Forms.Padding(4);
            this.form_eleve_mercredi_aprem_btn.Name = "form_eleve_mercredi_aprem_btn";
            this.form_eleve_mercredi_aprem_btn.Size = new System.Drawing.Size(238, 148);
            this.form_eleve_mercredi_aprem_btn.TabIndex = 6;
            this.form_eleve_mercredi_aprem_btn.Text = "Projet Blanc";
            this.form_eleve_mercredi_aprem_btn.UseVisualStyleBackColor = false;
            this.form_eleve_mercredi_aprem_btn.Click += new System.EventHandler(this.form_eleve_mercredi_aprem_btn_Click);
            // 
            // form_eleve_jeudi_matin_btn
            // 
            this.form_eleve_jeudi_matin_btn.BackColor = System.Drawing.Color.White;
            this.form_eleve_jeudi_matin_btn.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_eleve_jeudi_matin_btn.Location = new System.Drawing.Point(1016, 141);
            this.form_eleve_jeudi_matin_btn.Margin = new System.Windows.Forms.Padding(4);
            this.form_eleve_jeudi_matin_btn.Name = "form_eleve_jeudi_matin_btn";
            this.form_eleve_jeudi_matin_btn.Size = new System.Drawing.Size(238, 148);
            this.form_eleve_jeudi_matin_btn.TabIndex = 7;
            this.form_eleve_jeudi_matin_btn.Text = "Projet Blanc";
            this.form_eleve_jeudi_matin_btn.UseVisualStyleBackColor = false;
            this.form_eleve_jeudi_matin_btn.Click += new System.EventHandler(this.form_eleve_jeudi_matin_btn_Click);
            // 
            // form_eleve_jeudi_aprem_btn
            // 
            this.form_eleve_jeudi_aprem_btn.BackColor = System.Drawing.Color.White;
            this.form_eleve_jeudi_aprem_btn.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_eleve_jeudi_aprem_btn.Location = new System.Drawing.Point(1016, 323);
            this.form_eleve_jeudi_aprem_btn.Margin = new System.Windows.Forms.Padding(4);
            this.form_eleve_jeudi_aprem_btn.Name = "form_eleve_jeudi_aprem_btn";
            this.form_eleve_jeudi_aprem_btn.Size = new System.Drawing.Size(238, 148);
            this.form_eleve_jeudi_aprem_btn.TabIndex = 8;
            this.form_eleve_jeudi_aprem_btn.Text = "Projet Blanc";
            this.form_eleve_jeudi_aprem_btn.UseVisualStyleBackColor = false;
            this.form_eleve_jeudi_aprem_btn.Click += new System.EventHandler(this.form_eleve_jeudi_aprem_btn_Click);
            // 
            // form_eleve_vendredi_matin_btn
            // 
            this.form_eleve_vendredi_matin_btn.BackColor = System.Drawing.Color.White;
            this.form_eleve_vendredi_matin_btn.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_eleve_vendredi_matin_btn.Location = new System.Drawing.Point(1277, 141);
            this.form_eleve_vendredi_matin_btn.Margin = new System.Windows.Forms.Padding(4);
            this.form_eleve_vendredi_matin_btn.Name = "form_eleve_vendredi_matin_btn";
            this.form_eleve_vendredi_matin_btn.Size = new System.Drawing.Size(238, 148);
            this.form_eleve_vendredi_matin_btn.TabIndex = 9;
            this.form_eleve_vendredi_matin_btn.Text = "Projet Blanc";
            this.form_eleve_vendredi_matin_btn.UseVisualStyleBackColor = false;
            this.form_eleve_vendredi_matin_btn.Click += new System.EventHandler(this.form_eleve_vendredi_matin_btn_Click);
            // 
            // form_eleve_vendredi_aprem_btn
            // 
            this.form_eleve_vendredi_aprem_btn.BackColor = System.Drawing.Color.White;
            this.form_eleve_vendredi_aprem_btn.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_eleve_vendredi_aprem_btn.Location = new System.Drawing.Point(1277, 323);
            this.form_eleve_vendredi_aprem_btn.Margin = new System.Windows.Forms.Padding(4);
            this.form_eleve_vendredi_aprem_btn.Name = "form_eleve_vendredi_aprem_btn";
            this.form_eleve_vendredi_aprem_btn.Size = new System.Drawing.Size(238, 148);
            this.form_eleve_vendredi_aprem_btn.TabIndex = 10;
            this.form_eleve_vendredi_aprem_btn.Text = "Projet Blanc";
            this.form_eleve_vendredi_aprem_btn.UseVisualStyleBackColor = false;
            this.form_eleve_vendredi_aprem_btn.Click += new System.EventHandler(this.form_eleve_vendredi_aprem_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 194);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 37);
            this.label1.TabIndex = 11;
            this.label1.Text = "Matinée";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 376);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Après-Midi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(296, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 37);
            this.label3.TabIndex = 13;
            this.label3.Text = "Lundi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(562, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 37);
            this.label4.TabIndex = 14;
            this.label4.Text = "Mardi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(799, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 37);
            this.label5.TabIndex = 15;
            this.label5.Text = "Mercredi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1086, 52);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 37);
            this.label6.TabIndex = 16;
            this.label6.Text = "Jeudi";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(1323, 52);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 37);
            this.label7.TabIndex = 17;
            this.label7.Text = "Vendredi";
            // 
            // form_eleve_date_lundi
            // 
            this.form_eleve_date_lundi.AutoSize = true;
            this.form_eleve_date_lundi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_eleve_date_lundi.Location = new System.Drawing.Point(279, 100);
            this.form_eleve_date_lundi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form_eleve_date_lundi.Name = "form_eleve_date_lundi";
            this.form_eleve_date_lundi.Size = new System.Drawing.Size(141, 29);
            this.form_eleve_date_lundi.TabIndex = 18;
            this.form_eleve_date_lundi.Text = "00/00/0000";
            // 
            // form_eleve_date_mardi
            // 
            this.form_eleve_date_mardi.AutoSize = true;
            this.form_eleve_date_mardi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_eleve_date_mardi.Location = new System.Drawing.Point(543, 100);
            this.form_eleve_date_mardi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form_eleve_date_mardi.Name = "form_eleve_date_mardi";
            this.form_eleve_date_mardi.Size = new System.Drawing.Size(141, 29);
            this.form_eleve_date_mardi.TabIndex = 19;
            this.form_eleve_date_mardi.Text = "00/00/0000";
            this.form_eleve_date_mardi.Click += new System.EventHandler(this.label8_Click);
            // 
            // form_eleve_date_mercredi
            // 
            this.form_eleve_date_mercredi.AutoSize = true;
            this.form_eleve_date_mercredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_eleve_date_mercredi.Location = new System.Drawing.Point(801, 100);
            this.form_eleve_date_mercredi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form_eleve_date_mercredi.Name = "form_eleve_date_mercredi";
            this.form_eleve_date_mercredi.Size = new System.Drawing.Size(141, 29);
            this.form_eleve_date_mercredi.TabIndex = 20;
            this.form_eleve_date_mercredi.Text = "00/00/0000";
            this.form_eleve_date_mercredi.Click += new System.EventHandler(this.form_eleve_date_mercredi_Click);
            // 
            // form_eleve_date_jeudi
            // 
            this.form_eleve_date_jeudi.AutoSize = true;
            this.form_eleve_date_jeudi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_eleve_date_jeudi.Location = new System.Drawing.Point(1064, 100);
            this.form_eleve_date_jeudi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form_eleve_date_jeudi.Name = "form_eleve_date_jeudi";
            this.form_eleve_date_jeudi.Size = new System.Drawing.Size(141, 29);
            this.form_eleve_date_jeudi.TabIndex = 21;
            this.form_eleve_date_jeudi.Text = "00/00/0000";
            this.form_eleve_date_jeudi.Click += new System.EventHandler(this.form_eleve_date_jeudi_Click);
            // 
            // form_eleve_date_vendredi
            // 
            this.form_eleve_date_vendredi.AutoSize = true;
            this.form_eleve_date_vendredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_eleve_date_vendredi.Location = new System.Drawing.Point(1335, 100);
            this.form_eleve_date_vendredi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.form_eleve_date_vendredi.Name = "form_eleve_date_vendredi";
            this.form_eleve_date_vendredi.Size = new System.Drawing.Size(141, 29);
            this.form_eleve_date_vendredi.TabIndex = 22;
            this.form_eleve_date_vendredi.Text = "00/00/0000";
            // 
            // form_eleve_semaine_suivante_btn
            // 
            this.form_eleve_semaine_suivante_btn.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_eleve_semaine_suivante_btn.Location = new System.Drawing.Point(1495, 65);
            this.form_eleve_semaine_suivante_btn.Name = "form_eleve_semaine_suivante_btn";
            this.form_eleve_semaine_suivante_btn.Size = new System.Drawing.Size(70, 54);
            this.form_eleve_semaine_suivante_btn.TabIndex = 23;
            this.form_eleve_semaine_suivante_btn.Text = ">>";
            this.form_eleve_semaine_suivante_btn.UseVisualStyleBackColor = true;
            this.form_eleve_semaine_suivante_btn.Click += new System.EventHandler(this.form_eleve_semaine_suivante_btn_Click);
            // 
            // form_eleve_semaine_precedantee_btn
            // 
            this.form_eleve_semaine_precedantee_btn.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_eleve_semaine_precedantee_btn.Location = new System.Drawing.Point(174, 65);
            this.form_eleve_semaine_precedantee_btn.Name = "form_eleve_semaine_precedantee_btn";
            this.form_eleve_semaine_precedantee_btn.Size = new System.Drawing.Size(70, 54);
            this.form_eleve_semaine_precedantee_btn.TabIndex = 24;
            this.form_eleve_semaine_precedantee_btn.Text = "<<";
            this.form_eleve_semaine_precedantee_btn.UseVisualStyleBackColor = true;
            this.form_eleve_semaine_precedantee_btn.Click += new System.EventHandler(this.form_eleve_semaine_precedantee_btn_Click);
            // 
            // form_eleve_dernieres_notes
            // 
            this.form_eleve_dernieres_notes.AllowUserToAddRows = false;
            this.form_eleve_dernieres_notes.AllowUserToDeleteRows = false;
            this.form_eleve_dernieres_notes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.form_eleve_dernieres_notes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.form_eleve_dernieres_notes.Location = new System.Drawing.Point(896, 573);
            this.form_eleve_dernieres_notes.Name = "form_eleve_dernieres_notes";
            this.form_eleve_dernieres_notes.ReadOnly = true;
            this.form_eleve_dernieres_notes.RowTemplate.Height = 28;
            this.form_eleve_dernieres_notes.Size = new System.Drawing.Size(619, 244);
            this.form_eleve_dernieres_notes.TabIndex = 25;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(889, 521);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(276, 37);
            this.label8.TabIndex = 26;
            this.label8.Text = "Dernières notes :";
            // 
            // Form_eleve
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1592, 894);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.form_eleve_dernieres_notes);
            this.Controls.Add(this.form_eleve_semaine_precedantee_btn);
            this.Controls.Add(this.form_eleve_semaine_suivante_btn);
            this.Controls.Add(this.form_eleve_date_vendredi);
            this.Controls.Add(this.form_eleve_date_jeudi);
            this.Controls.Add(this.form_eleve_date_mercredi);
            this.Controls.Add(this.form_eleve_date_mardi);
            this.Controls.Add(this.form_eleve_date_lundi);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.form_eleve_vendredi_aprem_btn);
            this.Controls.Add(this.form_eleve_vendredi_matin_btn);
            this.Controls.Add(this.form_eleve_jeudi_aprem_btn);
            this.Controls.Add(this.form_eleve_jeudi_matin_btn);
            this.Controls.Add(this.form_eleve_mercredi_aprem_btn);
            this.Controls.Add(this.form_eleve_mercredi_matin_btn);
            this.Controls.Add(this.form_eleve_mardi_aprem_btn);
            this.Controls.Add(this.form_eleve_mardi_matin_btn);
            this.Controls.Add(this.form_eleve_lundi_aprem_btn);
            this.Controls.Add(this.form_eleve_lundi_matin_btn);
            this.Controls.Add(this.eleve_menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.eleve_menu;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form_eleve";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Page d\'acceuil";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_eleve_FormClosed);
            this.Load += new System.EventHandler(this.Form_eleve_Load);
            this.eleve_menu.ResumeLayout(false);
            this.eleve_menu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form_eleve_dernieres_notes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip eleve_menu;
        private System.Windows.Forms.ToolStripMenuItem eleve_menu_taches;
        private System.Windows.Forms.ToolStripMenuItem gestion_tache_menu_acces_rapide_taches;
        private System.Windows.Forms.ToolStripMenuItem gestion_tache_menu_nouvelle_tache;
        private System.Windows.Forms.ToolStripMenuItem eleve_menu_gestion_taches;
        private System.Windows.Forms.ToolStripMenuItem eleve_menu_tache_parametres;
        private System.Windows.Forms.Button form_eleve_lundi_matin_btn;
        private System.Windows.Forms.Button form_eleve_lundi_aprem_btn;
        private System.Windows.Forms.Button form_eleve_mardi_matin_btn;
        private System.Windows.Forms.Button form_eleve_mardi_aprem_btn;
        private System.Windows.Forms.Button form_eleve_mercredi_matin_btn;
        private System.Windows.Forms.Button form_eleve_mercredi_aprem_btn;
        private System.Windows.Forms.Button form_eleve_jeudi_matin_btn;
        private System.Windows.Forms.Button form_eleve_jeudi_aprem_btn;
        private System.Windows.Forms.Button form_eleve_vendredi_matin_btn;
        private System.Windows.Forms.Button form_eleve_vendredi_aprem_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label form_eleve_date_lundi;
        private System.Windows.Forms.Label form_eleve_date_mardi;
        private System.Windows.Forms.Label form_eleve_date_mercredi;
        private System.Windows.Forms.Label form_eleve_date_jeudi;
        private System.Windows.Forms.Label form_eleve_date_vendredi;
        private System.Windows.Forms.Button form_eleve_semaine_suivante_btn;
        private System.Windows.Forms.Button form_eleve_semaine_precedantee_btn;
        private System.Windows.Forms.DataGridView form_eleve_dernieres_notes;
        private System.Windows.Forms.Label label8;
    }
}