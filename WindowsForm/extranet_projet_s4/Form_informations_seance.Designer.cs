namespace extranet_projet_s4
{
    partial class Form_informations_seance
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
            this.informations_seances_date_label = new System.Windows.Forms.Label();
            this.informations_seances_professeur_label = new System.Windows.Forms.Label();
            this.informations_note_textbox = new System.Windows.Forms.TextBox();
            this.information_note_label = new System.Windows.Forms.Label();
            this.form_informations_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // informations_seances_date_label
            // 
            this.informations_seances_date_label.AutoSize = true;
            this.informations_seances_date_label.Font = new System.Drawing.Font("Trebuchet MS", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informations_seances_date_label.ForeColor = System.Drawing.Color.DarkRed;
            this.informations_seances_date_label.Location = new System.Drawing.Point(195, 24);
            this.informations_seances_date_label.Name = "informations_seances_date_label";
            this.informations_seances_date_label.Size = new System.Drawing.Size(133, 36);
            this.informations_seances_date_label.TabIndex = 0;
            this.informations_seances_date_label.Text = "Une date";
            // 
            // informations_seances_professeur_label
            // 
            this.informations_seances_professeur_label.AutoSize = true;
            this.informations_seances_professeur_label.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.informations_seances_professeur_label.Location = new System.Drawing.Point(30, 187);
            this.informations_seances_professeur_label.Name = "informations_seances_professeur_label";
            this.informations_seances_professeur_label.Size = new System.Drawing.Size(148, 29);
            this.informations_seances_professeur_label.TabIndex = 1;
            this.informations_seances_professeur_label.Text = "Professeur :";
            // 
            // informations_note_textbox
            // 
            this.informations_note_textbox.Location = new System.Drawing.Point(35, 294);
            this.informations_note_textbox.Multiline = true;
            this.informations_note_textbox.Name = "informations_note_textbox";
            this.informations_note_textbox.Size = new System.Drawing.Size(457, 169);
            this.informations_note_textbox.TabIndex = 3;
            this.informations_note_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // information_note_label
            // 
            this.information_note_label.AutoSize = true;
            this.information_note_label.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.information_note_label.Location = new System.Drawing.Point(30, 255);
            this.information_note_label.Name = "information_note_label";
            this.information_note_label.Size = new System.Drawing.Size(219, 27);
            this.information_note_label.TabIndex = 4;
            this.information_note_label.Text = "Note de la séance : ";
            this.information_note_label.Click += new System.EventHandler(this.label1_Click);
            // 
            // form_informations_btn
            // 
            this.form_informations_btn.BackColor = System.Drawing.Color.White;
            this.form_informations_btn.Font = new System.Drawing.Font("Trebuchet MS", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.form_informations_btn.Location = new System.Drawing.Point(35, 90);
            this.form_informations_btn.Margin = new System.Windows.Forms.Padding(4);
            this.form_informations_btn.Name = "form_informations_btn";
            this.form_informations_btn.Size = new System.Drawing.Size(457, 67);
            this.form_informations_btn.TabIndex = 5;
            this.form_informations_btn.Text = "Projet Blanc";
            this.form_informations_btn.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(184, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 29);
            this.label1.TabIndex = 6;
            this.label1.Text = "un professeur";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form_informations_seance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.form_informations_btn);
            this.Controls.Add(this.information_note_label);
            this.Controls.Add(this.informations_note_textbox);
            this.Controls.Add(this.informations_seances_professeur_label);
            this.Controls.Add(this.informations_seances_date_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_informations_seance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Informations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label informations_seances_date_label;
        private System.Windows.Forms.Label informations_seances_professeur_label;
        private System.Windows.Forms.TextBox informations_note_textbox;
        private System.Windows.Forms.Label information_note_label;
        private System.Windows.Forms.Button form_informations_btn;
        private System.Windows.Forms.Label label1;
    }
}