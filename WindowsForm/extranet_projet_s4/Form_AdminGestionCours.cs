using System;
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
        private void Couleur_Button_Click(object sender, EventArgs e)
        {
            col.ShowDialog();
            Couleur_Panel.BackColor = col.Color;
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            if (Libelle_Box.Text == "" || Coefficient_Box.Text == "")
            {
                MessageBox.Show("Erreur !");
            }
            else
            {
                string color = col.Color.ToArgb().ToString("x");
                color = color.Substring(2, 6);
                MySqlCommand cmd = BDD.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO `cours`(`Libelle_Cours`, `Coefficient_Cours`, `Couleur_Cours`) VALUES ('" + Libelle_Box.Text + "','" + Coefficient_Box.Text + "','" + color + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajouter !");
                UpdateGrid(BDD);
                Libelle_Box.Text = "";
                Coefficient_Box.Text = "";
            }
        }

        private void AjouterButton_Click(object sender, EventArgs e)
        {
            string color = col.Color.ToArgb().ToString("x");
            color = color.Substring(2, 6);
            SQL_TB.Text = "INSERT INTO `cours`(`Libelle_Cours`, `Coefficient_Cours`, `Couleur_Cours`) VALUES ('  Libelle ',' Coefficient ','" + color + "')";
        }

        private void SupprimerButton_Click(object sender, EventArgs e)
        {
            SQL_TB.Text = "DELETE FROM `cours` WHERE ";
        }

        private void SQLentrer_Button_Click(object sender, EventArgs e)
        {
            if (SQL_TB.Text == "" || SQL_TB.Text == "DELETE FROM `cours` WHERE ")
            {
                MessageBox.Show("Erreur !");
            }
            else
            {
                MySqlCommand cmd = BDD.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = SQL_TB.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Commandes appliqué !");
                UpdateGrid(BDD);
                Libelle_Box.Text = "";
                Coefficient_Box.Text = "";
            }
        }
    }
}
