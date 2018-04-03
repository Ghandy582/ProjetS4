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
    public partial class Form_AdminAssignerProf : Form
    {
        private MySqlDataAdapter mySqlDataAdapter;
        public MySqlConnection BDD;
        private int rowIndex = 0;
        public Form_AdminAssignerProf(MySqlConnection SQL)
        {
            this.BDD = SQL;
            InitializeComponent();
            UpdateGrid(BDD);
            ComboFill(BDD);
        }
        private void UpdateGrid(MySqlConnection SQL)
        {
            //recup de donnée
            mySqlDataAdapter = new MySqlDataAdapter("select ID_membre, Prenom_Membre, Nom_Membre from membre where ID_groupe = 1", BDD);
            //le tableau 
            DataSet DS = new DataSet();
            //remplissage du tableau aves les données recuperées
            mySqlDataAdapter.Fill(DS);
            Prof_DataGrid.DataSource = DS.Tables[0];
            //recup de donnée
            mySqlDataAdapter = new MySqlDataAdapter("select * from cours", BDD);
            //le tableau 
            DataSet DS2 = new DataSet();
            //remplissage du tableau aves les données recuperées
            mySqlDataAdapter.Fill(DS2);
            Cours_DataGrid.DataSource = DS2.Tables[0];
            //recup de donnée
            mySqlDataAdapter = new MySqlDataAdapter("select Libelle_Cours,Prenom_Membre,Nom_Membre from cours_membre JOIN cours ON cours_membre.ID_Cours = cours.ID_Cours JOIN membre ON cours_membre.ID_membre = membre.ID_membre ", BDD);
            //le tableau 
            DataSet DS3 = new DataSet();
            //remplissage du tableau aves les données recuperées
            mySqlDataAdapter.Fill(DS3);
            Membre_Cours_Grid.DataSource = DS3.Tables[0];
        }
        //FONCTION POUR MODIFIER DIRECTEMENT DANS LE TABLEAU
        private void Liste_DataGrid_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)Membre_Cours_Grid.DataSource).GetChanges();

            if (changes != null)
            {
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(mySqlDataAdapter);
                mySqlDataAdapter.UpdateCommand = mcb.GetUpdateCommand();
                mySqlDataAdapter.Update(changes);
                ((DataTable)Membre_Cours_Grid.DataSource).AcceptChanges();
            }
        }
        /*clic droit sur le grid*/
        private void GestionCellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.Membre_Cours_Grid.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.Membre_Cours_Grid.CurrentCell = this.Membre_Cours_Grid.Rows[e.RowIndex].Cells[1];
            }
        }

        private void ClicDroitSupprimer_Click(object sender, EventArgs e)
        {
            if (!this.Membre_Cours_Grid.Rows[this.rowIndex].IsNewRow)
            {
                this.Membre_Cours_Grid.Rows.RemoveAt(this.rowIndex);
            }
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
            string query2 = "SELECT * FROM membre where ID_Groupe = 1";
            MySqlCommand cmd2 = new MySqlCommand(query2, SQL);

            using (MySqlDataReader Reader = cmd2.ExecuteReader())
            {
                while (Reader.Read())
                {
                    Prof_CB.Items.Add(Reader.GetString("Nom_Membre"));
                }
            }
        }

        private void Entrer_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd1 = new MySqlCommand("SELECT ID_Cours FROM cours WHERE Libelle_Cours = '" + Cours_CB.Text + "'", BDD);
                MySqlDataReader Reader1 = cmd1.ExecuteReader();
                Reader1.Read();
                string IDCours = Reader1.GetString("ID_Cours");
                Reader1.Close();
                MySqlCommand cmd2 = new MySqlCommand("SELECT ID_Membre FROM membre WHERE Nom_Membre = '" + Prof_CB.Text + "'", BDD);
                MySqlDataReader Reader2 = cmd1.ExecuteReader();
                Reader2.Read();
                string IDMembre = Reader1.GetString("ID_Membre");
                Reader1.Close();
                MySqlCommand cmd = BDD.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO `cours_membre`(`ID_Cours`, `ID_membre`) VALUES ('" + IDCours + "','" + IDMembre + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajouté !");
                Cours_CB.Text = "";
                Prof_CB.Text = "";
                UpdateGrid(BDD);
            }
            catch
            {
                MessageBox.Show("Erreur !");
            }
        }

        private void Ajouter_BTN_Click(object sender, EventArgs e)
        {
            SQL_Text.Text = "INSERT INTO `cours_membre`(`ID_Cours`, `ID_membre`) VALUES (         ,          );";
        }

        private void Supprimer_BTN_Click(object sender, EventArgs e)
        {
            SQL_Text.Text = "DELETE FROM `cours_membre` WHERE `ID_Cours` =  AND `ID_membre` = ; ";
        }

        private void SQLEntrer_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd = BDD.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = SQL_Text.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajouté !");
                SQL_Text.Text = "";
                UpdateGrid(BDD);
            }
            catch
            {
                MessageBox.Show("Erreur !");
            }
        }
    }
}
