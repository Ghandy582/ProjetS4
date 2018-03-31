namespace extranet_projet_s4
{
    partial class Form_choix_admin_prof
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
            this.choix_adminprof_admin_btn = new System.Windows.Forms.Button();
            this.choix_adminprof_prof_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choix_adminprof_admin_btn
            // 
            this.choix_adminprof_admin_btn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choix_adminprof_admin_btn.Location = new System.Drawing.Point(38, 82);
            this.choix_adminprof_admin_btn.Margin = new System.Windows.Forms.Padding(2);
            this.choix_adminprof_admin_btn.Name = "choix_adminprof_admin_btn";
            this.choix_adminprof_admin_btn.Size = new System.Drawing.Size(172, 53);
            this.choix_adminprof_admin_btn.TabIndex = 1;
            this.choix_adminprof_admin_btn.Text = "Administrateur";
            this.choix_adminprof_admin_btn.UseVisualStyleBackColor = true;
            this.choix_adminprof_admin_btn.Click += new System.EventHandler(this.choix_adminprof_admin_btn_Click);
            // 
            // choix_adminprof_prof_btn
            // 
            this.choix_adminprof_prof_btn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choix_adminprof_prof_btn.Location = new System.Drawing.Point(252, 82);
            this.choix_adminprof_prof_btn.Margin = new System.Windows.Forms.Padding(2);
            this.choix_adminprof_prof_btn.Name = "choix_adminprof_prof_btn";
            this.choix_adminprof_prof_btn.Size = new System.Drawing.Size(172, 53);
            this.choix_adminprof_prof_btn.TabIndex = 2;
            this.choix_adminprof_prof_btn.Text = "Professeur";
            this.choix_adminprof_prof_btn.UseVisualStyleBackColor = true;
            this.choix_adminprof_prof_btn.Click += new System.EventHandler(this.choix_adminprof_prof_btn_Click);
            // 
            // Form_choix_admin_prof
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 205);
            this.Controls.Add(this.choix_adminprof_prof_btn);
            this.Controls.Add(this.choix_adminprof_admin_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_choix_admin_prof";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intranet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_choix_admin_prof_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button choix_adminprof_admin_btn;
        private System.Windows.Forms.Button choix_adminprof_prof_btn;
    }
}