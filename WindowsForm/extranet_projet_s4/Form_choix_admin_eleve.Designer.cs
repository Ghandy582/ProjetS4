namespace extranet_projet_s4
{
    partial class Form_choix_admin_eleve
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
            this.choix_admineleve_admin_btn = new System.Windows.Forms.Button();
            this.choix_admineleve_eleve_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choix_admineleve_admin_btn
            // 
            this.choix_admineleve_admin_btn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choix_admineleve_admin_btn.Location = new System.Drawing.Point(226, 209);
            this.choix_admineleve_admin_btn.Margin = new System.Windows.Forms.Padding(6);
            this.choix_admineleve_admin_btn.Name = "choix_admineleve_admin_btn";
            this.choix_admineleve_admin_btn.Size = new System.Drawing.Size(365, 150);
            this.choix_admineleve_admin_btn.TabIndex = 0;
            this.choix_admineleve_admin_btn.Text = "Administrateur";
            this.choix_admineleve_admin_btn.UseVisualStyleBackColor = true;
            this.choix_admineleve_admin_btn.Click += new System.EventHandler(this.choix_admineleve_admin_btn_Click);
            // 
            // choix_admineleve_eleve_btn
            // 
            this.choix_admineleve_eleve_btn.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choix_admineleve_eleve_btn.Location = new System.Drawing.Point(782, 209);
            this.choix_admineleve_eleve_btn.Margin = new System.Windows.Forms.Padding(6);
            this.choix_admineleve_eleve_btn.Name = "choix_admineleve_eleve_btn";
            this.choix_admineleve_eleve_btn.Size = new System.Drawing.Size(364, 150);
            this.choix_admineleve_eleve_btn.TabIndex = 1;
            this.choix_admineleve_eleve_btn.Text = "Elève";
            this.choix_admineleve_eleve_btn.UseVisualStyleBackColor = true;
            this.choix_admineleve_eleve_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_choix_admin_eleve
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1374, 574);
            this.Controls.Add(this.choix_admineleve_eleve_btn);
            this.Controls.Add(this.choix_admineleve_admin_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form_choix_admin_eleve";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Intranet";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_choix_admin_eleve_FormClosed);
            this.Load += new System.EventHandler(this.Form_choix_admin_eleve_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button choix_admineleve_admin_btn;
        private System.Windows.Forms.Button choix_admineleve_eleve_btn;
    }
}