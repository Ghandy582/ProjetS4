using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace extranet_projet_s4
{
    public partial class Form_AdminGestionGroupe : Form
    {
        private MySqlDataAdapter mySqlDataAdapter;
        public MySqlConnection BDD;
        private int rowIndex = 0;
        public Form_AdminGestionGroupe(MySqlConnection SQL)
        {
            this.BDD = SQL;
            InitializeComponent();
            UpdateGrid(BDD);
        }
        private void UpdateGrid(MySqlConnection SQL)
        {
            //recup de donnée
            mySqlDataAdapter = new MySqlDataAdapter("select * from groupe", BDD);
            //le tableau 
            DataSet DS = new DataSet();
            //remplissage du tableau aves les données recuperées
            mySqlDataAdapter.Fill(DS);
            Gestion_GridView.DataSource = DS.Tables[0];
        }

        private void Entrer_Button_Click(object sender, EventArgs e)
        {
            if (Libelle_Box.Text == "")
            {
                MessageBox.Show("Erreur !");
            }
            else
            {
                MySqlCommand cmd = BDD.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO `groupe`(`Libelle_Groupe`) VALUES('" + Libelle_Box.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajouter !");
                Libelle_Box.Text = "";
                UpdateGrid(BDD);
            }
        }

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

        private void Ajouter_Button_Click(object sender, EventArgs e)
        {
            SQL_Box.Text = "INSERT INTO `groupe`(`Libelle_Groupe`) VALUES()";
        }

        private void Supprimer_Button_Click(object sender, EventArgs e)
        {
            SQL_Box.Text = "DELETE FROM `groupe` WHERE ";
        }

        private void SQLEntrer_Button_Click(object sender, EventArgs e)
        {
            if (SQL_Box.Text == ""|| SQL_Box.Text == "INSERT INTO `groupe`(`Libelle_Groupe`) VALUES()" || SQL_Box.Text == "DELETE FROM `groupe` WHERE ")
            {
                MessageBox.Show("Erreur !");
            }
            else
            {
                MySqlCommand cmd = BDD.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = SQL_Box.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Commande appliqué !");
                SQL_Box.Text = "";
                UpdateGrid(BDD);
            }
        }
    }
}
