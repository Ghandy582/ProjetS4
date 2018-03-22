namespace extranet_projet_s4
{
    partial class Form_AdminAfficherNote
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
            this.Data_Panel = new System.Windows.Forms.Panel();
            this.Note_Grid = new System.Windows.Forms.DataGridView();
            this.Groupe_Text = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Groupe_CB = new System.Windows.Forms.ComboBox();
            this.Cours_CB = new System.Windows.Forms.ComboBox();
            this.Afficher_BTN = new System.Windows.Forms.Button();
            this.Data_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Note_Grid)).BeginInit();
            this.SuspendLayout();
            // 
            // Data_Panel
            // 
            this.Data_Panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Data_Panel.Controls.Add(this.Note_Grid);
            this.Data_Panel.Location = new System.Drawing.Point(13, 169);
            this.Data_Panel.Name = "Data_Panel";
            this.Data_Panel.Size = new System.Drawing.Size(336, 499);
            this.Data_Panel.TabIndex = 0;
            // 
            // Note_Grid
            // 
            this.Note_Grid.AllowUserToAddRows = false;
            this.Note_Grid.AllowUserToDeleteRows = false;
            this.Note_Grid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Note_Grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Note_Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Note_Grid.Location = new System.Drawing.Point(0, 0);
            this.Note_Grid.Name = "Note_Grid";
            this.Note_Grid.ReadOnly = true;
            this.Note_Grid.Size = new System.Drawing.Size(336, 499);
            this.Note_Grid.TabIndex = 0;
            // 
            // Groupe_Text
            // 
            this.Groupe_Text.AutoSize = true;
            this.Groupe_Text.Location = new System.Drawing.Point(21, 73);
            this.Groupe_Text.Name = "Groupe_Text";
            this.Groupe_Text.Size = new System.Drawing.Size(94, 13);
            this.Groupe_Text.TabIndex = 1;
            this.Groupe_Text.Text = "Groupe de travail :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(341, 29);
            this.label2.TabIndex = 9;
            this.label2.Text = "Afficher les notes d\'un groupe :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Cours :";
            // 
            // Groupe_CB
            // 
            this.Groupe_CB.FormattingEnabled = true;
            this.Groupe_CB.Location = new System.Drawing.Point(154, 70);
            this.Groupe_CB.Name = "Groupe_CB";
            this.Groupe_CB.Size = new System.Drawing.Size(195, 21);
            this.Groupe_CB.TabIndex = 11;
            // 
            // Cours_CB
            // 
            this.Cours_CB.FormattingEnabled = true;
            this.Cours_CB.Location = new System.Drawing.Point(154, 101);
            this.Cours_CB.Name = "Cours_CB";
            this.Cours_CB.Size = new System.Drawing.Size(195, 21);
            this.Cours_CB.TabIndex = 12;
            // 
            // Afficher_BTN
            // 
            this.Afficher_BTN.Location = new System.Drawing.Point(154, 139);
            this.Afficher_BTN.Name = "Afficher_BTN";
            this.Afficher_BTN.Size = new System.Drawing.Size(195, 24);
            this.Afficher_BTN.TabIndex = 13;
            this.Afficher_BTN.Text = "Afficher";
            this.Afficher_BTN.UseVisualStyleBackColor = true;
            this.Afficher_BTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form_AdminAfficherNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 680);
            this.Controls.Add(this.Afficher_BTN);
            this.Controls.Add(this.Cours_CB);
            this.Controls.Add(this.Groupe_CB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Groupe_Text);
            this.Controls.Add(this.Data_Panel);
            this.Name = "Form_AdminAfficherNote";
            this.Text = "Form_AdminAfficherNote";
            this.Data_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Note_Grid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Data_Panel;
        private System.Windows.Forms.Label Groupe_Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Groupe_CB;
        private System.Windows.Forms.ComboBox Cours_CB;
        private System.Windows.Forms.DataGridView Note_Grid;
        private System.Windows.Forms.Button Afficher_BTN;
    }
}