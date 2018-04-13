namespace extranet_projet_s4
{
    partial class Form_modifier_notes_cours
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
            this.modifications_textbox = new System.Windows.Forms.TextBox();
            this.modifications_valider_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modifications_textbox
            // 
            this.modifications_textbox.Font = new System.Drawing.Font("Trebuchet MS", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifications_textbox.Location = new System.Drawing.Point(38, 38);
            this.modifications_textbox.Multiline = true;
            this.modifications_textbox.Name = "modifications_textbox";
            this.modifications_textbox.Size = new System.Drawing.Size(457, 169);
            this.modifications_textbox.TabIndex = 4;
            // 
            // modifications_valider_btn
            // 
            this.modifications_valider_btn.Location = new System.Drawing.Point(400, 245);
            this.modifications_valider_btn.Name = "modifications_valider_btn";
            this.modifications_valider_btn.Size = new System.Drawing.Size(119, 35);
            this.modifications_valider_btn.TabIndex = 5;
            this.modifications_valider_btn.Text = "Valider";
            this.modifications_valider_btn.UseVisualStyleBackColor = true;
            this.modifications_valider_btn.Click += new System.EventHandler(this.modifications_valider_btn_Click);
            // 
            // Form_modifier_notes_cours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(541, 292);
            this.Controls.Add(this.modifications_valider_btn);
            this.Controls.Add(this.modifications_textbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_modifier_notes_cours";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifications";
            this.Load += new System.EventHandler(this.Form_modifier_notes_cours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox modifications_textbox;
        private System.Windows.Forms.Button modifications_valider_btn;
    }
}