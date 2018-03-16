namespace extranet_projet_s4
{
    partial class Form_acces_rapide_taches
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
            this.acces_rapide_tache_liste = new System.Windows.Forms.CheckedListBox();
            this.acces_rapide_tache_ajouter_tache = new System.Windows.Forms.Button();
            this.acces_rapide_tache_tache_termine_btn = new System.Windows.Forms.Button();
            this.acces_rapide_tache_rafraichir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // acces_rapide_tache_liste
            // 
            this.acces_rapide_tache_liste.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acces_rapide_tache_liste.FormattingEnabled = true;
            this.acces_rapide_tache_liste.Location = new System.Drawing.Point(12, 12);
            this.acces_rapide_tache_liste.Name = "acces_rapide_tache_liste";
            this.acces_rapide_tache_liste.Size = new System.Drawing.Size(469, 395);
            this.acces_rapide_tache_liste.TabIndex = 0;
            this.acces_rapide_tache_liste.SelectedIndexChanged += new System.EventHandler(this.acces_rapide_tache_liste_SelectedIndexChanged);
            // 
            // acces_rapide_tache_ajouter_tache
            // 
            this.acces_rapide_tache_ajouter_tache.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acces_rapide_tache_ajouter_tache.Location = new System.Drawing.Point(239, 516);
            this.acces_rapide_tache_ajouter_tache.Name = "acces_rapide_tache_ajouter_tache";
            this.acces_rapide_tache_ajouter_tache.Size = new System.Drawing.Size(242, 39);
            this.acces_rapide_tache_ajouter_tache.TabIndex = 1;
            this.acces_rapide_tache_ajouter_tache.Text = "Ajouter une nouvelle tâche";
            this.acces_rapide_tache_ajouter_tache.UseVisualStyleBackColor = true;
            this.acces_rapide_tache_ajouter_tache.Click += new System.EventHandler(this.acces_rapide_tache_ajouter_tache_Click);
            // 
            // acces_rapide_tache_tache_termine_btn
            // 
            this.acces_rapide_tache_tache_termine_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acces_rapide_tache_tache_termine_btn.Location = new System.Drawing.Point(35, 413);
            this.acces_rapide_tache_tache_termine_btn.Name = "acces_rapide_tache_tache_termine_btn";
            this.acces_rapide_tache_tache_termine_btn.Size = new System.Drawing.Size(420, 43);
            this.acces_rapide_tache_tache_termine_btn.TabIndex = 2;
            this.acces_rapide_tache_tache_termine_btn.Text = "Déclarer les tâches cochées comme terminées";
            this.acces_rapide_tache_tache_termine_btn.UseVisualStyleBackColor = true;
            this.acces_rapide_tache_tache_termine_btn.Click += new System.EventHandler(this.acces_rapide_tache_tache_termine_btn_Click);
            // 
            // acces_rapide_tache_rafraichir
            // 
            this.acces_rapide_tache_rafraichir.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.acces_rapide_tache_rafraichir.Location = new System.Drawing.Point(64, 516);
            this.acces_rapide_tache_rafraichir.Name = "acces_rapide_tache_rafraichir";
            this.acces_rapide_tache_rafraichir.Size = new System.Drawing.Size(169, 39);
            this.acces_rapide_tache_rafraichir.TabIndex = 3;
            this.acces_rapide_tache_rafraichir.Text = "Rafraichir la liste";
            this.acces_rapide_tache_rafraichir.UseVisualStyleBackColor = true;
            this.acces_rapide_tache_rafraichir.Click += new System.EventHandler(this.acces_rapide_tache_rafraichir_Click);
            // 
            // Form_acces_rapide_taches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(493, 567);
            this.Controls.Add(this.acces_rapide_tache_rafraichir);
            this.Controls.Add(this.acces_rapide_tache_tache_termine_btn);
            this.Controls.Add(this.acces_rapide_tache_ajouter_tache);
            this.Controls.Add(this.acces_rapide_tache_liste);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_acces_rapide_taches";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vos tâches";
            this.Load += new System.EventHandler(this.Form_acces_rapide_taches_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox acces_rapide_tache_liste;
        private System.Windows.Forms.Button acces_rapide_tache_ajouter_tache;
        private System.Windows.Forms.Button acces_rapide_tache_tache_termine_btn;
        private System.Windows.Forms.Button acces_rapide_tache_rafraichir;
    }
}