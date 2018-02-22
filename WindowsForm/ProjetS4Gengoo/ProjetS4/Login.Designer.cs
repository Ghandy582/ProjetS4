namespace ProjetS4
{
    partial class Login
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Connect_BT = new System.Windows.Forms.Button();
            this.User_Text = new System.Windows.Forms.Label();
            this.Password_Text = new System.Windows.Forms.Label();
            this.User_Box = new System.Windows.Forms.TextBox();
            this.Password_Box = new System.Windows.Forms.TextBox();
            this.Unknown_text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Connect_BT
            // 
            this.Connect_BT.Location = new System.Drawing.Point(285, 192);
            this.Connect_BT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Connect_BT.Name = "Connect_BT";
            this.Connect_BT.Size = new System.Drawing.Size(112, 35);
            this.Connect_BT.TabIndex = 0;
            this.Connect_BT.Text = "Valider";
            this.Connect_BT.UseVisualStyleBackColor = true;
            this.Connect_BT.Click += new System.EventHandler(this.Login_Connect_Button);
            // 
            // User_Text
            // 
            this.User_Text.AutoSize = true;
            this.User_Text.Location = new System.Drawing.Point(70, 48);
            this.User_Text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.User_Text.Name = "User_Text";
            this.User_Text.Size = new System.Drawing.Size(43, 20);
            this.User_Text.TabIndex = 1;
            this.User_Text.Text = "User";
            // 
            // Password_Text
            // 
            this.Password_Text.AutoSize = true;
            this.Password_Text.Location = new System.Drawing.Point(70, 122);
            this.Password_Text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password_Text.Name = "Password_Text";
            this.Password_Text.Size = new System.Drawing.Size(78, 20);
            this.Password_Text.TabIndex = 2;
            this.Password_Text.Text = "Password";
            // 
            // User_Box
            // 
            this.User_Box.Location = new System.Drawing.Point(189, 48);
            this.User_Box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.User_Box.Name = "User_Box";
            this.User_Box.Size = new System.Drawing.Size(206, 26);
            this.User_Box.TabIndex = 3;
            // 
            // Password_Box
            // 
            this.Password_Box.Location = new System.Drawing.Point(189, 111);
            this.Password_Box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Password_Box.Name = "Password_Box";
            this.Password_Box.Size = new System.Drawing.Size(206, 26);
            this.Password_Box.TabIndex = 4;
            // 
            // Unknown_text
            // 
            this.Unknown_text.AutoSize = true;
            this.Unknown_text.Location = new System.Drawing.Point(70, 192);
            this.Unknown_text.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Unknown_text.Name = "Unknown_text";
            this.Unknown_text.Size = new System.Drawing.Size(0, 20);
            this.Unknown_text.TabIndex = 5;
            this.Unknown_text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 262);
            this.Controls.Add(this.Unknown_text);
            this.Controls.Add(this.Password_Box);
            this.Controls.Add(this.User_Box);
            this.Controls.Add(this.Password_Text);
            this.Controls.Add(this.User_Text);
            this.Controls.Add(this.Connect_BT);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect_BT;
        private System.Windows.Forms.Label User_Text;
        private System.Windows.Forms.Label Password_Text;
        private System.Windows.Forms.TextBox User_Box;
        private System.Windows.Forms.TextBox Password_Box;
        private System.Windows.Forms.Label Unknown_text;
    }
}

