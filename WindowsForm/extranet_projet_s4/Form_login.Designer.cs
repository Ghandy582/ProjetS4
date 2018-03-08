namespace extranet_projet_s4
{
    partial class form_login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_login));
            this.user_texte = new System.Windows.Forms.Label();
            this.mdp_texte = new System.Windows.Forms.Label();
            this.login_user_tb = new System.Windows.Forms.TextBox();
            this.login_mdp_tb = new System.Windows.Forms.TextBox();
            this.login_connexion_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // user_texte
            // 
            this.user_texte.AutoSize = true;
            this.user_texte.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_texte.Location = new System.Drawing.Point(217, 124);
            this.user_texte.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.user_texte.Name = "user_texte";
            this.user_texte.Size = new System.Drawing.Size(129, 49);
            this.user_texte.TabIndex = 0;
            this.user_texte.Text = "User :";
            this.user_texte.Click += new System.EventHandler(this.label1_Click);
            // 
            // mdp_texte
            // 
            this.mdp_texte.AutoSize = true;
            this.mdp_texte.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mdp_texte.Location = new System.Drawing.Point(55, 250);
            this.mdp_texte.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.mdp_texte.Name = "mdp_texte";
            this.mdp_texte.Size = new System.Drawing.Size(279, 49);
            this.mdp_texte.TabIndex = 1;
            this.mdp_texte.Text = "Mot de passe :";
            this.mdp_texte.Click += new System.EventHandler(this.mdp_texte_Click);
            // 
            // login_user_tb
            // 
            this.login_user_tb.Location = new System.Drawing.Point(365, 122);
            this.login_user_tb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.login_user_tb.Name = "login_user_tb";
            this.login_user_tb.Size = new System.Drawing.Size(359, 44);
            this.login_user_tb.TabIndex = 2;
            // 
            // login_mdp_tb
            // 
            this.login_mdp_tb.Location = new System.Drawing.Point(365, 252);
            this.login_mdp_tb.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.login_mdp_tb.Name = "login_mdp_tb";
            this.login_mdp_tb.PasswordChar = '*';
            this.login_mdp_tb.Size = new System.Drawing.Size(359, 44);
            this.login_mdp_tb.TabIndex = 3;
            // 
            // login_connexion_btn
            // 
            this.login_connexion_btn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_connexion_btn.Location = new System.Drawing.Point(565, 420);
            this.login_connexion_btn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.login_connexion_btn.Name = "login_connexion_btn";
            this.login_connexion_btn.Size = new System.Drawing.Size(273, 87);
            this.login_connexion_btn.TabIndex = 4;
            this.login_connexion_btn.Text = "Connexion";
            this.login_connexion_btn.UseVisualStyleBackColor = true;
            this.login_connexion_btn.Click += new System.EventHandler(this.login_connexion_btn_Click);
            // 
            // form_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 529);
            this.Controls.Add(this.login_connexion_btn);
            this.Controls.Add(this.login_mdp_tb);
            this.Controls.Add(this.login_user_tb);
            this.Controls.Add(this.mdp_texte);
            this.Controls.Add(this.user_texte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "form_login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.form_login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label user_texte;
        private System.Windows.Forms.Label mdp_texte;
        private System.Windows.Forms.TextBox login_user_tb;
        private System.Windows.Forms.TextBox login_mdp_tb;
        private System.Windows.Forms.Button login_connexion_btn;
    }
}

