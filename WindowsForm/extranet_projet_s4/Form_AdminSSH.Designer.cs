﻿namespace extranet_projet_s4
{
    partial class Form_AdminSSH
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
            this.Shell_TB = new System.Windows.Forms.TextBox();
            this.Commande_TB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Shell_TB
            // 
            this.Shell_TB.Enabled = false;
            this.Shell_TB.Location = new System.Drawing.Point(12, 38);
            this.Shell_TB.Multiline = true;
            this.Shell_TB.Name = "Shell_TB";
            this.Shell_TB.ReadOnly = true;
            this.Shell_TB.Size = new System.Drawing.Size(707, 378);
            this.Shell_TB.TabIndex = 0;
            // 
            // Commande_TB
            // 
            this.Commande_TB.Location = new System.Drawing.Point(12, 423);
            this.Commande_TB.Name = "Commande_TB";
            this.Commande_TB.Size = new System.Drawing.Size(707, 20);
            this.Commande_TB.TabIndex = 1;
            this.Commande_TB.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Commande_TB_KeyDown);
            // 
            // Form_AdminSSH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 453);
            this.Controls.Add(this.Commande_TB);
            this.Controls.Add(this.Shell_TB);
            this.Name = "Form_AdminSSH";
            this.Text = "Form_AdminSSH";
            this.Load += new System.EventHandler(this.Form_AdminSSH_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Shell_TB;
        private System.Windows.Forms.TextBox Commande_TB;
    }
}