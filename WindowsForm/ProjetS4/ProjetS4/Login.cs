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
    public partial class Login : Form
    {
        
        MySqlConnection connexion = new MySqlConnection("SERVER=localhost;" + "DATABASE=projet4;"+"UID=root;" + "PASSWORD=;");
        int i;
        int id_user = 4;              // ne correspond à rien
        public Login()
        {
            InitializeComponent();
           

        }


        private void Login_Connect_Button(object sender, EventArgs e)
        {

            
            MySqlCommand recupereSalt = new MySqlCommand("select salt from utilisateurs where User = '" + User_Box.Text+ "'", connexion);
            i = 0;
            
            try
            {
               

                MySqlDataReader myReader;
                connexion.Open();
                /*------ on modifie le mot de passe -------*/
                string mdp = Password_Box.Text;
                myReader = recupereSalt.ExecuteReader();
                string salt = "";
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                    salt = myReader.GetString(0);
                }
                myReader.Close();
               string mdpCompare = Main.MD5Hash(mdp,salt);
                /*-----------------------------------------*/
                MySqlCommand cmd = new MySqlCommand("select * from utilisateurs where User = '" + User_Box.Text + "' and Password = '" + mdpCompare + "'", connexion);
                myReader = cmd.ExecuteReader();
                count = 0;
                int role_tentative_co = 4;    //4 ne correspond à rien
               
               
                while (myReader.Read())
                {
                    count = count + 1;
                    role_tentative_co = myReader.GetInt16(5);
                    id_user = myReader.GetInt16(0);
                }
                // Si c'est un admin
                if (count == 1 && role_tentative_co == 1)
                {
                    MessageBox.Show("ID Correct !");
                    this.Hide();
                    Main Main_Page = new Main(this,id_user);
                    Main_Page.Show();
                }
                else if (count == 1 && role_tentative_co == 0)
                {
                    MessageBox.Show("Vous un utilisateur de grade 0");
                }
                else if (count > 1)
                {
                    MessageBox.Show("Il y a plusieurs utilisateur avec les mêmes ID ! Accès Refuser !");
                }
                else
                {
                    MessageBox.Show("Les ID sont Incorrect !");
                    connexion.Close();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("La connexion à la base de donnée a échouée : " + ex.ToString());
            }

        }
    }
}
