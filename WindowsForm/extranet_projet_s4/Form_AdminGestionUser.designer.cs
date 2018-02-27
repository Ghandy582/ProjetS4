namespace extranet_projet_s4
{
    partial class Gestion
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
            this.components = new System.ComponentModel.Container();
            this.PanelGestion = new System.Windows.Forms.Panel();
            this.Gestion_GridView = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ClicDroitSupprimer = new System.Windows.Forms.ToolStripMenuItem();
            this.SQL_TB = new System.Windows.Forms.TextBox();
            this.AjouterButton = new System.Windows.Forms.Button();
            this.SupprimerButton = new System.Windows.Forms.Button();
            this.SQL_Label = new System.Windows.Forms.Label();
            this.SQLpwd_TB = new System.Windows.Forms.TextBox();
            this.SQLentrer_Button = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.PanelAdd = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.PanelGestion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_GridView)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.PanelAdd.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelGestion
            // 
            this.PanelGestion.Controls.Add(this.Gestion_GridView);
            this.PanelGestion.Location = new System.Drawing.Point(0, 0);
            this.PanelGestion.Name = "PanelGestion";
            this.PanelGestion.Size = new System.Drawing.Size(1206, 270);
            this.PanelGestion.TabIndex = 0;
            // 
            // Gestion_GridView
            // 
            this.Gestion_GridView.AllowUserToAddRows = false;
            this.Gestion_GridView.AllowUserToOrderColumns = true;
            this.Gestion_GridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Gestion_GridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Gestion_GridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gestion_GridView.Location = new System.Drawing.Point(0, 0);
            this.Gestion_GridView.Name = "Gestion_GridView";
            this.Gestion_GridView.Size = new System.Drawing.Size(1206, 270);
            this.Gestion_GridView.TabIndex = 0;
            this.Gestion_GridView.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.GestionCellMouseUp);
            this.Gestion_GridView.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.Liste_DataGrid_RowValidated);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClicDroitSupprimer});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(130, 26);
            // 
            // ClicDroitSupprimer
            // 
            this.ClicDroitSupprimer.Name = "ClicDroitSupprimer";
            this.ClicDroitSupprimer.Size = new System.Drawing.Size(129, 22);
            this.ClicDroitSupprimer.Text = "Supprimer";
            this.ClicDroitSupprimer.Click += new System.EventHandler(this.ClicDroitSupprimer_Click);
            // 
            // SQL_TB
            // 
            this.SQL_TB.Location = new System.Drawing.Point(12, 311);
            this.SQL_TB.Multiline = true;
            this.SQL_TB.Name = "SQL_TB";
            this.SQL_TB.Size = new System.Drawing.Size(459, 229);
            this.SQL_TB.TabIndex = 1;
            // 
            // AjouterButton
            // 
            this.AjouterButton.Location = new System.Drawing.Point(13, 282);
            this.AjouterButton.Name = "AjouterButton";
            this.AjouterButton.Size = new System.Drawing.Size(219, 23);
            this.AjouterButton.TabIndex = 2;
            this.AjouterButton.Text = "Ajouter";
            this.AjouterButton.UseVisualStyleBackColor = true;
            this.AjouterButton.Click += new System.EventHandler(this.AjouterButton_Click);
            // 
            // SupprimerButton
            // 
            this.SupprimerButton.Location = new System.Drawing.Point(238, 281);
            this.SupprimerButton.Name = "SupprimerButton";
            this.SupprimerButton.Size = new System.Drawing.Size(232, 23);
            this.SupprimerButton.TabIndex = 3;
            this.SupprimerButton.Text = "Supprimer";
            this.SupprimerButton.UseVisualStyleBackColor = true;
            this.SupprimerButton.Click += new System.EventHandler(this.SupprimerButton_Click);
            // 
            // SQL_Label
            // 
            this.SQL_Label.AutoSize = true;
            this.SQL_Label.Location = new System.Drawing.Point(10, 560);
            this.SQL_Label.Name = "SQL_Label";
            this.SQL_Label.Size = new System.Drawing.Size(78, 13);
            this.SQL_Label.TabIndex = 4;
            this.SQL_Label.Text = "Mot de Passe :";
            // 
            // SQLpwd_TB
            // 
            this.SQLpwd_TB.Location = new System.Drawing.Point(120, 557);
            this.SQLpwd_TB.Name = "SQLpwd_TB";
            this.SQLpwd_TB.Size = new System.Drawing.Size(350, 20);
            this.SQLpwd_TB.TabIndex = 5;
            // 
            // SQLentrer_Button
            // 
            this.SQLentrer_Button.Location = new System.Drawing.Point(321, 594);
            this.SQLentrer_Button.Name = "SQLentrer_Button";
            this.SQLentrer_Button.Size = new System.Drawing.Size(149, 41);
            this.SQLentrer_Button.TabIndex = 6;
            this.SQLentrer_Button.Text = "Entrer";
            this.SQLentrer_Button.UseVisualStyleBackColor = true;
            this.SQLentrer_Button.Click += new System.EventHandler(this.SQLentrer_Button_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(10, 647);
            this.splitter1.TabIndex = 7;
            this.splitter1.TabStop = false;
            // 
            // PanelAdd
            // 
            this.PanelAdd.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.PanelAdd.Controls.Add(this.button1);
            this.PanelAdd.Location = new System.Drawing.Point(509, 282);
            this.PanelAdd.Name = "PanelAdd";
            this.PanelAdd.Size = new System.Drawing.Size(686, 353);
            this.PanelAdd.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 41);
            this.button1.TabIndex = 7;
            this.button1.Text = "Entrer";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Gestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 647);
            this.Controls.Add(this.PanelAdd);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.SQLentrer_Button);
            this.Controls.Add(this.SQLpwd_TB);
            this.Controls.Add(this.SQL_Label);
            this.Controls.Add(this.SupprimerButton);
            this.Controls.Add(this.AjouterButton);
            this.Controls.Add(this.SQL_TB);
            this.Controls.Add(this.PanelGestion);
            this.Name = "Gestion";
            this.Text = "Gestion des utilisateurs";
            this.PanelGestion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Gestion_GridView)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.PanelAdd.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelGestion;
        private System.Windows.Forms.DataGridView Gestion_GridView;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ClicDroitSupprimer;
        private System.Windows.Forms.TextBox SQL_TB;
        private System.Windows.Forms.Button AjouterButton;
        private System.Windows.Forms.Button SupprimerButton;
        private System.Windows.Forms.Label SQL_Label;
        private System.Windows.Forms.TextBox SQLpwd_TB;
        private System.Windows.Forms.Button SQLentrer_Button;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel PanelAdd;
        private System.Windows.Forms.Button button1;
    }
}