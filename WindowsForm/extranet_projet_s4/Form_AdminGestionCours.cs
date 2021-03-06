﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace extranet_projet_s4
{
    public partial class Form_AdminGestionCours : Form
    {
        public MySqlConnection BDD;
        private MySqlDataAdapter mySqlDataAdapter;
        ColorDialog col = new ColorDialog();
        private int rowIndex = 0;
        public Form_AdminGestionCours(MySqlConnection SQL)
        {
            this.BDD = SQL;
            InitializeComponent();
            UpdateGrid(BDD);
        }
        private void UpdateGrid(MySqlConnection SQL)
        {
            //recup de donnée
            mySqlDataAdapter = new MySqlDataAdapter("select * from cours", BDD);
            //le tableau 
            DataSet DS = new DataSet();
            //remplissage du tableau aves les données recuperées
            mySqlDataAdapter.Fill(DS);
            Gestion_GridView.DataSource = DS.Tables[0];
        }
        //FONCTION POUR MODIFIER DIRECTEMENT DANS LE TABLEAU
        private void Liste_DataGrid_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)Gestion_GridView.DataSource).GetChanges();

            if (changes != null)
            {
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(mySqlDataAdapter);
                mySqlDataAdapter.UpdateCommand = mcb.GetUpdateCommand();
                mySqlDataAdapter.Update(changes);
                ((DataTable)Gestion_GridView.DataSource).AcceptChanges();
            }
        }
        /*clic droit sur le grid*/
        private void GestionCellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.Gestion_GridView.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.Gestion_GridView.CurrentCell = this.Gestion_GridView.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.Gestion_GridView, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void ClicDroitSupprimer_Click(object sender, EventArgs e)
        {
            if (!this.Gestion_GridView.Rows[this.rowIndex].IsNewRow)
            {
                this.Gestion_GridView.Rows.RemoveAt(this.rowIndex);
            }
        }
        private void Couleur_Button_Click(object sender, EventArgs e)
        {
            col.ShowDialog();
            Couleur_Panel.BackColor = col.Color;
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {

            try
            {
                int color = col.Color.ToArgb();
                MySqlCommand cmd = BDD.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO `cours`(`Libelle_Cours`, `Coefficient_Cours`, `Couleur_Cours`) VALUES ('" + Libelle_Box.Text + "','" + Coefficient_Box.Text + "','" + color + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajouté !");
                UpdateGrid(BDD);
                Libelle_Box.Text = "";
                Coefficient_Box.Text = "";
            }
            catch
            {
                MessageBox.Show("Erreur !");
            }
        }

        private void AjouterButton_Click(object sender, EventArgs e)
        {
            int color = col.Color.ToArgb();
            SQL_TB.Text = "INSERT INTO `cours`(`Libelle_Cours`, `Coefficient_Cours`, `Couleur_Cours`) VALUES ('  Libelle ',' Coefficient ','" + color + "')";
        }

        private void SupprimerButton_Click(object sender, EventArgs e)
        {
            SQL_TB.Text = "DELETE FROM `cours` WHERE ";
        }

        private void SQLentrer_Button_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = BDD.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = SQL_TB.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Commande appliquée !");
                UpdateGrid(BDD);
                Libelle_Box.Text = "";
                Coefficient_Box.Text = "";
            }
            catch
            {
                MessageBox.Show("Erreur !");
            }
        }

    }
}
