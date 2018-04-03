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
    public partial class Form_AdminAssignerNote : Form
    {
        public MySqlConnection BDD;

        public Form_AdminAssignerNote(MySqlConnection SQL)
        {
            this.BDD = SQL;
            InitializeComponent();
            ComboFill(BDD);
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
        private void Groupe_CB_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboMembre(BDD);
        }
        void ComboMembre(MySqlConnection SQL)
        {
            User_CB.Text = "";
            User_CB.Items.Clear();
            try
            {
                string query = "SELECT * FROM membre JOIN groupe on membre.ID_Groupe = groupe.ID_Groupe WHERE '" + Groupe_CB.Text + "' = groupe.Libelle_Groupe";
                MySqlCommand cmd = new MySqlCommand(query, SQL);

                using (MySqlDataReader Reader = cmd.ExecuteReader())
                {
                    while (Reader.Read())
                    {
                        User_CB.Items.Add(Reader.GetString("Nom_membre"));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Membre Combo box:'" + ex.ToString() + "'");
            }
        }
        private void Note_TB_Scroll(object sender, EventArgs e)
        {
            Note_Text.Text = Note_TB.Value.ToString();
        }
        private void Entrer_BTN_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlCommand cmd1 = new MySqlCommand("SELECT ID_Cours FROM cours WHERE Libelle_Cours ='" + Cours_CB.Text + "' ", BDD);
                MySqlCommand cmd2 = new MySqlCommand("SELECT ID_membre FROM membre WHERE Nom_Membre = '" + User_CB.Text + "'", BDD);
                MySqlDataReader Reader1 = cmd1.ExecuteReader();
                Reader1.Read();
                string IDCours = Reader1.GetString("ID_Cours");
                Reader1.Close();
                MySqlDataReader Reader2 = cmd2.ExecuteReader();
                Reader2.Read();
                string IDEleve = Reader2.GetString("ID_membre");
                Reader2.Close();
                MySqlCommand cmd = BDD.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO `note`(`Note`, `Libelle_Note`, `ID_membre`, `ID_Cours`) VALUES('" + Note_Text.Text + "','" + Libelle_TB.Text + "','" + IDEleve + "','" + IDCours + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajouté !");
                User_CB.Text = "";
            }
            catch
            {
                MessageBox.Show("Erreur !");
            }
        }

    }
}
