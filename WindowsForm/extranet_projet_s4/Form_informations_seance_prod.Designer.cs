namespace extranet_projet_s4
{
    partial class Form_informations_seance_prod
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
            this.form_informations_btn = new System.Windows.Forms.Button();
            this.informations_seances_date_label = new System.Windows.Forms.Label();
            this.infos_promo_label = new System.Windows.Forms.Label();
            this.informations_seances_professeur_label = new System.Windows.Forms.Label();
            this.information_note_label = new System.Windows.Forms.Label();
            this.informations_note_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.infos_note_persone_texbox = new System.Windows.Forms.TextBox();
            this.infos_prof_modifier_notes_seance_btn = new System.Windows.Forms.Button();
            this.infos_prof_modifier_note_perso_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // form_informations_btn
            // 
            this.form_informations_btn.BackColor = System.Drawing.Color.White;
            this.form_informations_btn.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_informations_btn.Location = new System.Drawing.Point(34, 74);
            this.form_informations_btn.Margin = new System.Windows.Forms.Padding(4);
            this.form_informations_btn.Name = "form_informations_btn";
            this.form_informations_btn.Size = new System.Drawing.Size(457, 81);
            this.form_informations_btn.TabIndex = 7;
            this.form_informations_btn.Text = "Projet Blanc";
            this.form_informations_btn.UseVisualStyleBackColor = false;
            // 
            // informations_seances_date_label
            // 
            this.informations_seances_date_label.AutoSize = true;
            this.informations_seances_date_label.Font = new System.Drawing.Font("Trebuchet MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informations_seances_date_label.ForeColor = System.Drawing.Color.DarkRed;
            this.informations_seances_date_label.Location = new System.Drawing.Point(172, 18);
            this.informations_seances_date_label.Name = "informations_seances_date_label";
            this.informations_seances_date_label.Size = new System.Drawing.Size(153, 40);
            this.informations_seances_date_label.TabIndex = 6;
            this.informations_seances_date_label.Text = "Une date";
            // 
            // infos_promo_label
            // 
            this.infos_promo_label.AutoSize = true;
            this.infos_promo_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infos_promo_label.Location = new System.Drawing.Point(183, 173);
            this.infos_promo_label.Name = "infos_promo_label";
            this.infos_promo_label.Size = new System.Drawing.Size(173, 29);
            this.infos_promo_label.TabIndex = 9;
            this.infos_promo_label.Text = "Une promotion";
            // 
            // informations_seances_professeur_label
            // 
            this.informations_seances_professeur_label.AutoSize = true;
            this.informations_seances_professeur_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informations_seances_professeur_label.Location = new System.Drawing.Point(29, 173);
            this.informations_seances_professeur_label.Name = "informations_seances_professeur_label";
            this.informations_seances_professeur_label.Size = new System.Drawing.Size(131, 29);
            this.informations_seances_professeur_label.TabIndex = 8;
            this.informations_seances_professeur_label.Text = "Promotion";
            // 
            // information_note_label
            // 
            this.information_note_label.AutoSize = true;
            this.information_note_label.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_note_label.Location = new System.Drawing.Point(29, 226);
            this.information_note_label.Name = "information_note_label";
            this.information_note_label.Size = new System.Drawing.Size(219, 27);
            this.information_note_label.TabIndex = 11;
            this.information_note_label.Text = "Note de la séance : ";
            // 
            // informations_note_textbox
            // 
            this.informations_note_textbox.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informations_note_textbox.Location = new System.Drawing.Point(34, 265);
            this.informations_note_textbox.Multiline = true;
            this.informations_note_textbox.Name = "informations_note_textbox";
            this.informations_note_textbox.ReadOnly = true;
            this.informations_note_textbox.Size = new System.Drawing.Size(457, 169);
            this.informations_note_textbox.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 445);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 27);
            this.label1.TabIndex = 13;
            this.label1.Text = "Note personelle :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // infos_note_persone_texbox
            // 
            this.infos_note_persone_texbox.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infos_note_persone_texbox.Location = new System.Drawing.Point(34, 484);
            this.infos_note_persone_texbox.Multiline = true;
            this.infos_note_persone_texbox.Name = "infos_note_persone_texbox";
            this.infos_note_persone_texbox.ReadOnly = true;
            this.infos_note_persone_texbox.Size = new System.Drawing.Size(457, 169);
            this.infos_note_persone_texbox.TabIndex = 12;
            // 
            // infos_prof_modifier_notes_seance_btn
            // 
            this.infos_prof_modifier_notes_seance_btn.Location = new System.Drawing.Point(243, 224);
            this.infos_prof_modifier_notes_seance_btn.Name = "infos_prof_modifier_notes_seance_btn";
            this.infos_prof_modifier_notes_seance_btn.Size = new System.Drawing.Size(96, 35);
            this.infos_prof_modifier_notes_seance_btn.TabIndex = 14;
            this.infos_prof_modifier_notes_seance_btn.Text = "Modifier";
            this.infos_prof_modifier_notes_seance_btn.UseVisualStyleBackColor = true;
            this.infos_prof_modifier_notes_seance_btn.Click += new System.EventHandler(this.infos_prof_modifier_notes_seance_btn_Click);
            // 
            // infos_prof_modifier_note_perso_btn
            // 
            this.infos_prof_modifier_note_perso_btn.Location = new System.Drawing.Point(229, 443);
            this.infos_prof_modifier_note_perso_btn.Name = "infos_prof_modifier_note_perso_btn";
            this.infos_prof_modifier_note_perso_btn.Size = new System.Drawing.Size(96, 35);
            this.infos_prof_modifier_note_perso_btn.TabIndex = 15;
            this.infos_prof_modifier_note_perso_btn.Text = "Modifier";
            this.infos_prof_modifier_note_perso_btn.UseVisualStyleBackColor = true;
            this.infos_prof_modifier_note_perso_btn.Click += new System.EventHandler(this.infos_prof_modifier_note_perso_btn_Click);
            // 
            // Form_informations_seance_prod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(525, 682);
            this.Controls.Add(this.infos_prof_modifier_note_perso_btn);
            this.Controls.Add(this.infos_prof_modifier_notes_seance_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.infos_note_persone_texbox);
            this.Controls.Add(this.information_note_label);
            this.Controls.Add(this.informations_note_textbox);
            this.Controls.Add(this.infos_promo_label);
            this.Controls.Add(this.informations_seances_professeur_label);
            this.Controls.Add(this.form_informations_btn);
            this.Controls.Add(this.informations_seances_date_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_informations_seance_prod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informations";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_informations_seance_prod_FormClosed);
            this.Load += new System.EventHandler(this.Form_informations_seance_prod_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button form_informations_btn;
        private System.Windows.Forms.Label informations_seances_date_label;
        private System.Windows.Forms.Label infos_promo_label;
        private System.Windows.Forms.Label informations_seances_professeur_label;
        private System.Windows.Forms.Label information_note_label;
        private System.Windows.Forms.TextBox informations_note_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox infos_note_persone_texbox;
        private System.Windows.Forms.Button infos_prof_modifier_notes_seance_btn;
        private System.Windows.Forms.Button infos_prof_modifier_note_perso_btn;
    }
}