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
                    Cours_CB.Items.Add(Reader.GetString("Libelle_Cours"));
                }
            }
            string query2 = "SELECT * FROM groupe";
            MySqlCommand cmd2 = new MySqlCommand(query2, SQL);

            using (MySqlDataReader Reader = cmd2.ExecuteReader())
            {
                while (Reader.Read())
                {
                    Groupe_CB.Items.Add(Reader.GetString("Libelle_Groupe"));
                }
            }
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            
            try
            {
                MySqlCommand cmd1 = new MySqlCommand("SELECT ID_Cours FROM cours WHERE Libelle_Cours ='" + Cours_CB.Text + "' ", BDD);
                MySqlCommand cmd2 = new MySqlCommand("SELECT ID_Groupe FROM groupe WHERE Libelle_Groupe = '" + Groupe_CB.Text + "'", BDD);
                MySqlDataReader Reader1 = cmd1.ExecuteReader();
                Reader1.Read();
                string IDCours = Reader1.GetString("ID_Cours");
                Reader1.Close();
                MySqlDataReader Reader2 = cmd2.ExecuteReader();
                Reader2.Read();
                string IDGroupe = Reader2.GetString("ID_Groupe");
                Reader2.Close();
                MySqlCommand cmd = BDD.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO `seance`(`Date_Seance`, `Debut_Seance`, `Note_Seance`, `NotePersonnel_Seance`, `ID_Cours`) VALUES ('" + Date_Box.Text + "','" + BoolDate_Box.Text +"','" + Note_Box.Text +"','" + NoteP_Box.Text +"','" + IDCours + "')";
                cmd.ExecuteNonQuery();
                cmd.CommandText = "INSERT INTO `groupe_seance`(`ID_Seance`, `ID_Groupe`) VALUES ((SELECT `ID_Seance` FROM `seance` Order BY `ID_Seance` DESC LIMIT 1),'"+ IDGroupe +"')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajouter !");
                Date_Box.Text = "";
                BoolDate_Box.Text = "";
                NoteP_Box.Text = "";
                Note_Box.Text = "";
                Cours_CB.Text = "";
                UpdateGrid(BDD);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Entrer Seance '" + ex.ToString() + "'");
            }
            
        }

        private void SQLentrer_Button_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = BDD.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = SQL_TB.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Commandes appliqué !");
                UpdateGrid(BDD);
                SQL_TB.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Entrer SQL Seance '" + ex.ToString() + "'");
            }
        }
    }
}
