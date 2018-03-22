namespace extranet_projet_s4
{
    partial class Form_AdminAssignerNote
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
            this.Entrer_BTN = new System.Windows.Forms.Button();
            this.Groupe_CB = new System.Windows.Forms.ComboBox();
            this.User_CB = new System.Windows.Forms.ComboBox();
            this.Note_TB = new System.Windows.Forms.TrackBar();
            this.Libelle_TB = new System.Windows.Forms.TextBox();
            this.Cours_CB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Note_Text = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Note_TB)).BeginInit();
            this.SuspendLayout();
            // 
            // Entrer_BTN
            // 
            this.Entrer_BTN.Location = new System.Drawing.Point(296, 275);
            this.Entrer_BTN.Name = "Entrer_BTN";
            this.Entrer_BTN.Size = new System.Drawing.Size(99, 39);
            this.Entrer_BTN.TabIndex = 0;
            this.Entrer_BTN.Text = "Entrer";
            this.Entrer_BTN.UseVisualStyleBackColor = true;
            this.Entrer_BTN.Click += new System.EventHandler(this.Entrer_BTN_Click);
            // 
            // Groupe_CB
            // 
            this.Groupe_CB.FormattingEnabled = true;
            this.Groupe_CB.Location = new System.Drawing.Point(173, 59);
            this.Groupe_CB.Name = "Groupe_CB";
            this.Groupe_CB.Size = new System.Drawing.Size(222, 21);
            this.Groupe_CB.TabIndex = 1;
            this.Groupe_CB.SelectedIndexChanged += new System.EventHandler(this.Groupe_CB_SelectedIndexChanged);
            // 
            // User_CB
            // 
            this.User_CB.FormattingEnabled = true;
            this.User_CB.Location = new System.Drawing.Point(173, 97);
            this.User_CB.Name = "User_CB";
            this.User_CB.Size = new System.Drawing.Size(222, 21);
            this.User_CB.TabIndex = 2;
            // 
            // Note_TB
            // 
            this.Note_TB.Location = new System.Drawing.Point(173, 172);
            this.Note_TB.Maximum = 20;
            this.Note_TB.Name = "Note_TB";
            this.Note_TB.Size = new System.Drawing.Size(151, 45);
            this.Note_TB.TabIndex = 3;
            this.Note_TB.Scroll += new System.EventHandler(this.Note_TB_Scroll);
            // 
            // Libelle_TB
            // 
            this.Libelle_TB.Location = new System.Drawing.Point(173, 236);
            this.Libelle_TB.Multiline = true;
            this.Libelle_TB.Name = "Libelle_TB";
            this.Libelle_TB.Size = new System.Drawing.Size(222, 20);
            this.Libelle_TB.TabIndex = 4;
            // 
            // Cours_CB
            // 
            this.Cours_CB.FormattingEnabled = true;
            this.Cours_CB.Location = new System.Drawing.Point(173, 135);
            this.Cours_CB.Name = "Cours_CB";
            this.Cours_CB.Size = new System.Drawing.Size(222, 21);
            this.Cours_CB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Groupe de travail :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 29);
            this.label2.TabIndex = 19;
            this.label2.Text = "Ajouter une note  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Eleve :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 21;
            this.label4.Text = "Cours :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Note :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 23;
            this.label6.Text = "Libellé de la note :";
            // 
            // Note_Text
            // 
            this.Note_Text.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Note_Text.Location = new System.Drawing.Point(331, 172);
            this.Note_Text.Multiline = true;
            this.Note_Text.Name = "Note_Text";
            this.Note_Text.Size = new System.Drawing.Size(45, 45);
            this.Note_Text.TabIndex = 24;
            // 
            // Form_AdminAssignerNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 326);
            this.Controls.Add(this.Note_Text);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cours_CB);
            this.Controls.Add(this.Libelle_TB);
            this.Controls.Add(this.Note_TB);
            this.Controls.Add(this.User_CB);
            this.Controls.Add(this.Groupe_CB);
            this.Controls.Add(this.Entrer_BTN);
            this.Name = "Form_AdminAssignerNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Form_AdminAssignerNote";
            ((System.ComponentModel.ISupportInitialize)(this.Note_TB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Entrer_BTN;
        private System.Windows.Forms.ComboBox Groupe_CB;
        private System.Windows.Forms.ComboBox User_CB;
        private System.Windows.Forms.TrackBar Note_TB;
        private System.Windows.Forms.TextBox Libelle_TB;
        private System.Windows.Forms.ComboBox Cours_CB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Note_Text;
    }
}