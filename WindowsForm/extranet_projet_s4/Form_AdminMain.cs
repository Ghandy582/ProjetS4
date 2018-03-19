using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Pour utiliser le fichier de configuration
using System.Configuration;
using MySql.Data.MySqlClient;



namespace extranet_projet_s4
{
    public partial class Form_AdminMain : Form
    {
        form_login lg;
        Utilisateur utilisateur;
        /*---------------------------- PROPRIETES ---------------------------*/

        /*___ PROPRIETES DANS LE FIFHIER DE CONFIG______*/
        static string serveur = ConfigurationManager.AppSettings["serveur"];
        static string database = ConfigurationManager.AppSettings["database"];
        /*_____________________________________________*/

        // On créé la chaine de connextion avec les valeurs dans le fichier de conf
        MySqlConnection BDD = new MySqlConnection("SERVER=" + serveur + ";" + "DATABASE=" + database + ";" + "UID=root;" + "PASSWORD=;");
        public Form_AdminMain(form_login lg, Utilisateur utilisateur)
        {
            InitializeComponent();
            BDD.Open();
            this.lg = lg;
        }

        private void Menu_User_Delete_Click(object sender, EventArgs e)
        {
        }

        private void Menu_User_Add_Click(object sender, EventArgs e)
        {
        }
        /*
        private void Add_Valider_Click(object sender, EventArgs e)
        {
            /*------ Pour le salt and hash des passewords -------*//*
            string salt=CreateSalt(4);
            string pwd = MD5Hash(Add_Password_TB.Text, salt);

            *//*---------------------------------------------------*//*
            MessageBox.Show(pwd);
            MySqlCommand cmd = BDD.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT utilisateurs ( Nom,Prenom,User,Password,Rank,salt) VALUES ('"+Add_Nom_TB.Text+"','"+Add_Prenom_TB.Text+"','"+Add_User_TB.Text+"','"+pwd+"','"+Add_Rank_TB.Text+ "','" + salt + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ajouter !");
        }*/

        /*private void Delete_Button_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = BDD.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "delete from utilisateurs where nom = '" + Delete_Nom_TB.Text + "'and prenom = '"+ Delete_Prenom_TB.Text +"'; ";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Supprimer !");
        }*/



        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            lg.Close();
        }

        private void Menu_User_Gestion_Click(object sender, EventArgs e)
        {
            GestionUser Gestion_Page = new GestionUser(BDD);
            Gestion_Page.Show();
        }

        private void Menu_Gestion_Groupe_Click(object sender, EventArgs e)
        {
            Form_AdminGestionGroupe Gestion_Page = new Form_AdminGestionGroupe(BDD);
            Gestion_Page.Show();
        }

        private void Menu_Gestion_Cours_Click(object sender, EventArgs e)
        {
            Form_AdminGestionCours Gestion_Page = new Form_AdminGestionCours(BDD);
            Gestion_Page.Show();
        }

        private void Menu_Gestion_Sceance_Click(object sender, EventArgs e)
        {
            Form_AdminGestionSeance Gestion_Page = new Form_AdminGestionSeance(BDD);
            Gestion_Page.Show();
        }

        private void Apropos_BTN_Click(object sender, EventArgs e)
        {
            Form_APropos Gestion_Page = new Form_APropos();
            Gestion_Page.Show();
        }

        private void Reglage_BTN_Click(object sender, EventArgs e)
        {
            Form_AdminPhp Gestion_Page = new Form_AdminPhp();
            Gestion_Page.Show();
        }

        private void Menu_Assigner_Prof_Click(object sender, EventArgs e)
        {
            Form_AdminAssignerProf Gestion_Page = new Form_AdminAssignerProf(BDD);
            Gestion_Page.Show();
        }

        private void Menu_Assigner_Note_Click(object sender, EventArgs e)
        {
            Form_AdminAssignerNote Gestion_Page = new Form_AdminAssignerNote(BDD);
            Gestion_Page.Show();
        }
    }
}
