﻿namespace extranet_projet_s4
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
            this.gestion_tache_tache_a_realiser_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gestion_tache_nouvelletache_btn = new System.Windows.Forms.Button();
            this.gestion_tache_accesrapide_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gestion_tache_tache_a_realiser_label
            // 
            this.gestion_tache_tache_a_realiser_label.AutoSize = true;
            this.gestion_tache_tache_a_realiser_label.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestion_tache_tache_a_realiser_label.Location = new System.Drawing.Point(12, 70);
            this.gestion_tache_tache_a_realiser_label.Name = "gestion_tache_tache_a_realiser_label";
            this.gestion_tache_tache_a_realiser_label.Size = new System.Drawing.Size(289, 53);
            this.gestion_tache_tache_a_realiser_label.TabIndex = 0;
            this.gestion_tache_tache_a_realiser_label.Text = "Tâches à réaliser :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Oswald", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 53);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tâches récemment réalisées :";
            // 
            // gestion_tache_nouvelletache_btn
            // 
            this.gestion_tache_nouvelletache_btn.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestion_tache_nouvelletache_btn.Location = new System.Drawing.Point(1453, 834);
            this.gestion_tache_nouvelletache_btn.Name = "gestion_tache_nouvelletache_btn";
            this.gestion_tache_nouvelletache_btn.Size = new System.Drawing.Size(134, 46);
            this.gestion_tache_nouvelletache_btn.TabIndex = 2;
            this.gestion_tache_nouvelletache_btn.Text = "Nouvelle tâche";
            this.gestion_tache_nouvelletache_btn.UseVisualStyleBackColor = true;
            this.gestion_tache_nouvelletache_btn.Click += new System.EventHandler(this.gestion_tache_nouvelletache_btn_Click);
            // 
            // gestion_tache_accesrapide_btn
            // 
            this.gestion_tache_accesrapide_btn.Font = new System.Drawing.Font("Oswald", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gestion_tache_accesrapide_btn.Location = new System.Drawing.Point(1261, 834);
            this.gestion_tache_accesrapide_btn.Name = "gestion_tache_accesrapide_btn";
            this.gestion_tache_accesrapide_btn.Size = new System.Drawing.Size(186, 46);
            this.gestion_tache_accesrapide_btn.TabIndex = 3;
            this.gestion_tache_accesrapide_btn.Text = "Ouvrir l\'accès rapide";
            this.gestion_tache_accesrapide_btn.UseVisualStyleBackColor = true;
            this.gestion_tache_accesrapide_btn.Click += new System.EventHandler(this.gestion_tache_accesrapide_btn_Click);
            // 
            // Form_gestion_tache
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1599, 892);
            this.Controls.Add(this.gestion_tache_accesrapide_btn);
            this.Controls.Add(this.gestion_tache_nouvelletache_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gestion_tache_tache_a_realiser_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_gestion_tache";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des tâches";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_gestion_tache_FormClosed);
            this.Load += new System.EventHandler(this.Form_gestion_tache_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gestion_tache_tache_a_realiser_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button gestion_tache_nouvelletache_btn;
        private System.Windows.Forms.Button gestion_tache_accesrapide_btn;
    }
}