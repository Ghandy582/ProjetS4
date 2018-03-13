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
    public partial class Form_AdminGestionSeance : Form
    {
        private MySqlDataAdapter mySqlDataAdapter;
        public MySqlConnection BDD;
        private int rowIndex = 0;
        public Form_AdminGestionSeance(MySqlConnection SQL)
        {
            this.BDD = SQL;
            InitializeComponent();
            UpdateGrid(BDD);
            ComboFill(BDD);
        }
        private void UpdateGrid(MySqlConnection SQL)
        {
            //recup de donnée
            mySqlDataAdapter = new MySqlDataAdapter("select * from seance", BDD);
            //le tableau 
            DataSet DS = new DataSet();
            //remplissage du tableau aves les données recuperées
            mySqlDataAdapter.Fill(DS);
            Gestion_GridView.DataSource = DS.Tables[0];
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

        private void AjouterButton_Click(object sender, EventArgs e)
        {
            SQL_TB.Text = "INSERT INTO `seance`( `Date_Seance`, `Debut_Seance`, `Note_Seance`, `NotePersonnel_Seance`, `ID_Cours`) VALUES ( , , , , );";
        }

        private void SupprimerButton_Click(object sender, EventArgs e)
        {
            SQL_TB.Text = "DELETE FROM `seance` WHERE `seance`.`ID_Seance` =";
        }

        private void Calendrier_DateChanged(object sender, DateRangeEventArgs e)
        {
            Date_Box.Text = Calendrier.SelectionRange.Start.ToShortDateString();
        }

        private void ComboFill(MySqlConnection SQL)
        {

            string query = "SELECT * FROM cours";
            MySqlCommand cmd = new MySqlCommand(query, SQL);

            using (MySqlDataReader Reader = cmd.ExecuteReader())
            {
                while (Reader.Read())
                {
                    Cours_CB.Items.Add(Reader.GetString("ID_Cours"));
                }
            }
            string query2 = "SELECT * FROM groupe";
            MySqlCommand cmd2 = new MySqlCommand(query2, SQL);

            using (MySqlDataReader Reader = cmd2.ExecuteReader())
            {
                while (Reader.Read())
                {
                    Groupe_CB.Items.Add(Reader.GetString("ID_Groupe"));
                }
            }
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            if (BoolDate_Box.Text == "")
            {
                MessageBox.Show("Erreur !");
            }
            else
            {
                MySqlCommand cmd = BDD.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO `seance`(`Date_Seance`, `Debut_Seance`, `Note_Seance`, `NotePersonnel_Seance`, `ID_Cours`) VALUES ('"+ Date_Box.Text +"','"+ BoolDate_Box.Text +"','" + Note_Box.Text +"','" + NoteP_Box.Text +"','" + Cours_CB.Text +"')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO `groupe_seance`(`ID_Seance`, `ID_Groupe`) VALUES ((SELECT `ID_Seance` FROM `seance` Order BY `ID_Seance` DESC LIMIT 1),'"+ Groupe_CB.Text +"')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajouter !");
                Date_Box.Text = "";
                BoolDate_Box.Text = "";
                NoteP_Box.Text = "";
                Note_Box.Text = "";
                Cours_CB.Text = "";
                UpdateGrid(BDD);
            }
        }

        private void SQLentrer_Button_Click(object sender, EventArgs e)
        {
            if (SQL_TB.Text == "" || SQL_TB.Text == "DELETE FROM `seance` WHERE `seance`.`ID_Seance` =")
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
                SQL_TB.Text = "";
            }
        }
    }
}
