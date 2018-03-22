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
    public partial class Form_AdminAfficherNote : Form
    {
        public MySqlConnection BDD;
        private MySqlDataAdapter mySqlDataAdapter;
        public Form_AdminAfficherNote(MySqlConnection SQL)
        {
            this.BDD = SQL;
            InitializeComponent();
            ComboFill(BDD);
        }
        private void UpdateGrid(MySqlConnection SQL)
        {
            try
            {
                //recup de donnée
                string query = "select Nom_Membre, Prenom_Membre, Note, Libelle_Note from note JOIN cours ON note.ID_Cours =" +
                    "cours.ID_Cours JOIN membre ON note.ID_membre = membre.ID_membre JOIN groupe ON membre.ID_Groupe = groupe.ID_groupe WHERE Libelle_Groupe ='" + Groupe_CB.Text + "'AND Libelle_Cours ='"+ Cours_CB.Text +"';";
                mySqlDataAdapter = new MySqlDataAdapter(query, BDD);
                //le tableau 
                DataSet DS = new DataSet();
                //remplissage du tableau aves les données recuperées
                mySqlDataAdapter.Fill(DS);
                Note_Grid.DataSource = DS.Tables[0];
            }
            catch(Exception ex)
            {
                MessageBox.Show("Grid : '" + ex.ToString() + "'");
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

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateGrid(BDD);
        }
    }
}
