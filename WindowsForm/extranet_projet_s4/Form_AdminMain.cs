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



namespace ProjetS4
{
    public partial class Main : Form
    {
        Login lg;
        int id_user;
        public MySqlConnection BDD = new MySqlConnection("SERVER=localhost;" + "DATABASE=projet4;" + "UID=root;" + "PASSWORD=;");
        public Main(Login lg, int id_user)
        {
            InitializeComponent();
            BDD.Open();
            this.lg = lg;
            this.id_user = id_user;
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
            Gestion Gestion_Page = new Gestion(BDD);
            Gestion_Page.Show();
        }
    }
}
