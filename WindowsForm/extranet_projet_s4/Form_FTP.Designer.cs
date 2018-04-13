namespace extranet_projet_s4
{
    partial class Form_FTP
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.checkdown = new System.Windows.Forms.CheckBox();
            this.checkup = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 63);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(318, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 8);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(318, 20);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Télécharger";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorker1.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker1_ProgressChanged);
            this.backgroundWorker1.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted);
            // 
            // checkdown
            // 
            this.checkdown.AutoSize = true;
            this.checkdown.Checked = true;
            this.checkdown.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkdown.Location = new System.Drawing.Point(27, 93);
            this.checkdown.Name = "checkdown";
            this.checkdown.Size = new System.Drawing.Size(83, 17);
            this.checkdown.TabIndex = 3;
            this.checkdown.Text = "Télécharger";
            this.checkdown.UseVisualStyleBackColor = true;
            this.checkdown.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkup
            // 
            this.checkup.AutoSize = true;
            this.checkup.Location = new System.Drawing.Point(27, 117);
            this.checkup.Name = "checkup";
            this.checkup.Size = new System.Drawing.Size(66, 17);
            this.checkup.TabIndex = 4;
            this.checkup.Text = "Partager";
            this.checkup.UseVisualStyleBackColor = true;
            this.checkup.CheckedChanged += new System.EventHandler(this.checkup_CheckedChanged);
            // 
            // Form_FTP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 170);
            this.Controls.Add(this.checkup);
            this.Controls.Add(this.checkdown);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.progressBar1);
            this.Name = "Form_FTP";
            this.Text = "Form_FTP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox checkdown;
        private System.Windows.Forms.CheckBox checkup;
    }
}