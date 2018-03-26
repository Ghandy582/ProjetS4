namespace extranet_projet_s4
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
            this.SSH_Console = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SSH_Console
            // 
            this.SSH_Console.Location = new System.Drawing.Point(13, 13);
            this.SSH_Console.Multiline = true;
            this.SSH_Console.Name = "SSH_Console";
            this.SSH_Console.Size = new System.Drawing.Size(580, 641);
            this.SSH_Console.TabIndex = 0;
            // 
            // Form_AdminSSH
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 666);
            this.Controls.Add(this.SSH_Console);
            this.Name = "Form_AdminSSH";
            this.Text = "Form_AdminSSH";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SSH_Console;
    }
}