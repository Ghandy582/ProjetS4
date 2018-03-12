namespace extranet_projet_s4
{
    partial class Form_nouvelle_tache
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
            this.nouvelle_tache_label = new System.Windows.Forms.Label();
            this.nouvelle_tache_textbox = new System.Windows.Forms.TextBox();
            this.nouvelle_tache_sansDate_radiobtn = new System.Windows.Forms.RadioButton();
            this.nouvelle_tache_avecDate_radiobtn = new System.Windows.Forms.RadioButton();
            this.nouvelle_tache_calendrier = new System.Windows.Forms.MonthCalendar();
            this.nouvelle_tache_ajouter_btn = new System.Windows.Forms.Button();
            this.nouvelle_tache_annuler_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nouvelle_tache_label
            // 
            this.nouvelle_tache_label.AutoSize = true;
            this.nouvelle_tache_label.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouvelle_tache_label.Location = new System.Drawing.Point(15, 52);
            this.nouvelle_tache_label.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.nouvelle_tache_label.Name = "nouvelle_tache_label";
            this.nouvelle_tache_label.Size = new System.Drawing.Size(156, 26);
            this.nouvelle_tache_label.TabIndex = 0;
            this.nouvelle_tache_label.Text = "Tâche à faire : ";
            this.nouvelle_tache_label.Click += new System.EventHandler(this.nouvelle_tache_label_Click);
            // 
            // nouvelle_tache_textbox
            // 
            this.nouvelle_tache_textbox.Location = new System.Drawing.Point(183, 52);
            this.nouvelle_tache_textbox.Margin = new System.Windows.Forms.Padding(6);
            this.nouvelle_tache_textbox.Name = "nouvelle_tache_textbox";
            this.nouvelle_tache_textbox.Size = new System.Drawing.Size(286, 26);
            this.nouvelle_tache_textbox.TabIndex = 1;
            // 
            // nouvelle_tache_sansDate_radiobtn
            // 
            this.nouvelle_tache_sansDate_radiobtn.AutoSize = true;
            this.nouvelle_tache_sansDate_radiobtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouvelle_tache_sansDate_radiobtn.Location = new System.Drawing.Point(114, 113);
            this.nouvelle_tache_sansDate_radiobtn.Margin = new System.Windows.Forms.Padding(6);
            this.nouvelle_tache_sansDate_radiobtn.Name = "nouvelle_tache_sansDate_radiobtn";
            this.nouvelle_tache_sansDate_radiobtn.Size = new System.Drawing.Size(204, 30);
            this.nouvelle_tache_sansDate_radiobtn.TabIndex = 2;
            this.nouvelle_tache_sansDate_radiobtn.TabStop = true;
            this.nouvelle_tache_sansDate_radiobtn.Text = "Sans date butoire";
            this.nouvelle_tache_sansDate_radiobtn.UseVisualStyleBackColor = true;
            this.nouvelle_tache_sansDate_radiobtn.CheckedChanged += new System.EventHandler(this.nouvelle_tache_sansDate_radiobtn_CheckedChanged);
            // 
            // nouvelle_tache_avecDate_radiobtn
            // 
            this.nouvelle_tache_avecDate_radiobtn.AutoSize = true;
            this.nouvelle_tache_avecDate_radiobtn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouvelle_tache_avecDate_radiobtn.Location = new System.Drawing.Point(116, 170);
            this.nouvelle_tache_avecDate_radiobtn.Margin = new System.Windows.Forms.Padding(6);
            this.nouvelle_tache_avecDate_radiobtn.Name = "nouvelle_tache_avecDate_radiobtn";
            this.nouvelle_tache_avecDate_radiobtn.Size = new System.Drawing.Size(202, 30);
            this.nouvelle_tache_avecDate_radiobtn.TabIndex = 3;
            this.nouvelle_tache_avecDate_radiobtn.TabStop = true;
            this.nouvelle_tache_avecDate_radiobtn.Text = "A faire avant le : ";
            this.nouvelle_tache_avecDate_radiobtn.UseVisualStyleBackColor = true;
            this.nouvelle_tache_avecDate_radiobtn.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // nouvelle_tache_calendrier
            // 
            this.nouvelle_tache_calendrier.Location = new System.Drawing.Point(116, 223);
            this.nouvelle_tache_calendrier.Margin = new System.Windows.Forms.Padding(19, 17, 19, 17);
            this.nouvelle_tache_calendrier.Name = "nouvelle_tache_calendrier";
            this.nouvelle_tache_calendrier.TabIndex = 4;
            this.nouvelle_tache_calendrier.Visible = false;
            // 
            // nouvelle_tache_ajouter_btn
            // 
            this.nouvelle_tache_ajouter_btn.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouvelle_tache_ajouter_btn.Location = new System.Drawing.Point(133, 546);
            this.nouvelle_tache_ajouter_btn.Margin = new System.Windows.Forms.Padding(6);
            this.nouvelle_tache_ajouter_btn.Name = "nouvelle_tache_ajouter_btn";
            this.nouvelle_tache_ajouter_btn.Size = new System.Drawing.Size(216, 46);
            this.nouvelle_tache_ajouter_btn.TabIndex = 5;
            this.nouvelle_tache_ajouter_btn.Text = "Ajouter la tâche";
            this.nouvelle_tache_ajouter_btn.UseVisualStyleBackColor = true;
            this.nouvelle_tache_ajouter_btn.Click += new System.EventHandler(this.nouvelle_tache_ajouter_btn_Click);
            // 
            // nouvelle_tache_annuler_btn
            // 
            this.nouvelle_tache_annuler_btn.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nouvelle_tache_annuler_btn.Location = new System.Drawing.Point(361, 546);
            this.nouvelle_tache_annuler_btn.Margin = new System.Windows.Forms.Padding(6);
            this.nouvelle_tache_annuler_btn.Name = "nouvelle_tache_annuler_btn";
            this.nouvelle_tache_annuler_btn.Size = new System.Drawing.Size(140, 46);
            this.nouvelle_tache_annuler_btn.TabIndex = 6;
            this.nouvelle_tache_annuler_btn.Text = "Annuler";
            this.nouvelle_tache_annuler_btn.UseVisualStyleBackColor = true;
            // 
            // Form_nouvelle_tache
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(516, 607);
            this.Controls.Add(this.nouvelle_tache_annuler_btn);
            this.Controls.Add(this.nouvelle_tache_ajouter_btn);
            this.Controls.Add(this.nouvelle_tache_calendrier);
            this.Controls.Add(this.nouvelle_tache_avecDate_radiobtn);
            this.Controls.Add(this.nouvelle_tache_sansDate_radiobtn);
            this.Controls.Add(this.nouvelle_tache_textbox);
            this.Controls.Add(this.nouvelle_tache_label);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form_nouvelle_tache";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nouvelle tâche";
            this.Load += new System.EventHandler(this.Form_nouvelle_tache_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nouvelle_tache_label;
        private System.Windows.Forms.TextBox nouvelle_tache_textbox;
        private System.Windows.Forms.RadioButton nouvelle_tache_sansDate_radiobtn;
        private System.Windows.Forms.RadioButton nouvelle_tache_avecDate_radiobtn;
        private System.Windows.Forms.MonthCalendar nouvelle_tache_calendrier;
        private System.Windows.Forms.Button nouvelle_tache_ajouter_btn;
        private System.Windows.Forms.Button nouvelle_tache_annuler_btn;
    }
}