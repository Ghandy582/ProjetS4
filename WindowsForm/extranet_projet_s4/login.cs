using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Pour utiliser mysql
using MySql.Data.MySqlClient;
//Pour utiliser le fichier de configuration
using System.Configuration;
//Pour hasher les mot des passes
using System.Security.Cryptography;
using System.Windows.Forms;

namespace extranet_projet_s4
{
    class login
    {
        /*---------------------------- PROPRIETES ---------------------------*/

        /*___ PROPRIETES DANS LE FIFHIER DE CONFIG______*/
        static string serveur = ConfigurationManager.AppSettings["serveur"];
        static string database = ConfigurationManager.AppSettings["database"];
        /*_____________________________________________*/

        // On créé la chaine de connextion avec les valeurs dans le fichier de conf
        MySqlConnection connexion = new MySqlConnection("SERVER=" + serveur + ";" + "DATABASE=" + database + ";" + "UID=root;" + "PASSWORD=;");
        int i;

        /* Pour les id user:
         1 pour élèvre
         2 pour professeur 
         4 pour administrateur, c'est valeur peuventse cumuler */
        int role_tentative_co = 0;    // ne correspnd à rien

        int id_user;              // ne correspond à rien



        /*---------------------------------- METHODES -------------------------------*/

        // Pour créer un salt
        private static string CreateSalt(int size)
        {
            try
            {
                //Generate a cryptographic random number.
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                byte[] buff = new byte[size];
                rng.GetBytes(buff);

                // Return a Base64 string representation of the random number.
                return Convert.ToBase64String(buff);
            }
            catch(Exception ex)
            {
                string vide = "";
                MessageBox.Show("Erreur pendant l'execution de la méthode CreateSalt" + ex.ToString());
                return vide;
            }
        }
        //________________________________________________________
        //Pour hasher le mot de passe avec son salt 
        public static string MD5Hash(string pwd, string salt)
        {
            try
            {
                //On combine le mot de passe et son salt
                string saltAndPwd = String.Concat(pwd, salt);
                MD5 md5 = new MD5CryptoServiceProvider();

                //compute hash from the bytes of text
                md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(saltAndPwd));

                //get hash result after compute it
                byte[] result = md5.Hash;

                StringBuilder strBuilder = new StringBuilder();
                for (int i = 0; i < result.Length; i++)
                {
                    //change it into 2 hexadecimal digits
                    //for each byte
                    strBuilder.Append(result[i].ToString("x2"));  
                }
                //on retroune le mot de passe qui n'est plus en clair
                return strBuilder.ToString();
            }
            catch(Exception ex)
            {
                string vide = "";
                MessageBox.Show("Erreur pendant l'execution de la méthode MD5hash" + ex.ToString());
                return vide;
            }
        }
        //________________________________________________________
        // Pour récupérer le salt correspondant au user pour pouvoir ensuite
        // Haser le mdp qu'il vient de rentrer (utilise des  méthodes précédantes)
        private string recup_salt_bdd_and_hash_pwd(string motPasse, string user)
        {
            string mdp = motPasse;
            i = 0;
            // On va chercher le salt correspondant au user que la personne a rentré
            // Pour l'ajouter au mdp qu'elle vient de taper
            MySqlCommand recupereSalt = new MySqlCommand("select Salt_Membre from membre where User_Membre = '" + user + "'", connexion);
            try
            {

                MySqlDataReader myReader;
                connexion.Open();
                myReader = recupereSalt.ExecuteReader();
                string salt = "";
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                    salt = myReader.GetString(0);
                }
                myReader.Close();
                connexion.Close();

                // on obtient le mot de passe qu'on va comparer avec celui de la bdd
                string mdpCompare = MD5Hash(mdp, salt);
                return mdpCompare;
            }
            catch (MySqlException ex)
            {
                string vide = "";
                MessageBox.Show("Erreur pendant l'execution de la méthode recup_and_compare_pwd " + ex.ToString());
                return vide;
            }
        }
        //________________________________________________________
        // Pour se connecter (utilise des  méthodes précédantes)
        public void connect(string user_connexion, string mdp_connexion, form_login form_login)
        {
            string user = user_connexion;
            string mdp = mdp_connexion;
            form_login login = form_login;

            // Pour créer l'obet utilidateur si la connexion est bonne
            //---------
            string prenom_membre="";
            string nom_membre="";
            int premiere_co_membre=999;
            int id_groupe_membre=999;
            //---------

            try
            {
                //On commence par la méthode de récup du salt enregistré pour créer le mdp à comparer
                string mdp_compare = recup_salt_bdd_and_hash_pwd(mdp, user);

                MySqlDataReader myReader;
                MySqlCommand cmd_login = new MySqlCommand("select * from membre where User_Membre = '" + user + "' and MotdePasse_Membre = '" + mdp_compare + "'", connexion);
                connexion.Open();
                myReader = cmd_login.ExecuteReader();
                int count = 0;
                // On vérifie si la personne est connu et unique dans la bdd + on récupère les infos
                while (myReader.Read())
                {
                    count = count + 1;
                    role_tentative_co = myReader.GetInt16(1);
                    id_user = myReader.GetInt16(0);
                    prenom_membre = myReader.GetString(5);
                    nom_membre= myReader.GetString(6);
                    premiere_co_membre = myReader.GetInt16(7);
                    id_groupe_membre = myReader.GetInt16(8);
                }
                // __________ POUR ADMIN (4) ___________
                if (count == 1 && role_tentative_co == 3)
                {
                    MessageBox.Show("ID Correct ! Vous etes un admin");
                   // login.Hide();
                    //Main Main_Page = new Main(this, id_user);
                   // Main_Page.Show();
                }
                // __________ POUR PROF(2) ___________
                else if (count == 1 && role_tentative_co == 2)
                {
                    MessageBox.Show("ID Correct ! Vous etes un professeur");
                }
                // __________ POUR ELEVE (1) ___________
                else if (count == 1 && role_tentative_co == 1)
                {
                    Utilisateur utilisateur = new Utilisateur(id_user, role_tentative_co, user, prenom_membre, nom_membre, premiere_co_membre, id_groupe_membre);
                    form_login.Hide();
                    Form_eleve form_eleve = new Form_eleve(form_login, utilisateur);
                    form_eleve.Show();

                }
                // __________ POUR ADMIN + PROF (5) ___________
                else if (count == 1 && role_tentative_co == 5)
                {
                    Utilisateur utilisateur = new Utilisateur(id_user, role_tentative_co, user, prenom_membre, nom_membre, premiere_co_membre, id_groupe_membre);
                    form_login.Hide();
                    Form_choix_admin_prof choix_admin_prof = new Form_choix_admin_prof(form_login, utilisateur);
                    choix_admin_prof.Show();
                }
                // __________ POUR ADMIN + ELEVE (4) ___________
                else if (count == 1 && role_tentative_co == 4)
                {
                    Utilisateur utilisateur = new Utilisateur(id_user, role_tentative_co, user, prenom_membre, nom_membre, premiere_co_membre, id_groupe_membre);
                    form_login.Hide();
                    Form_choix_admin_eleve choix_admin_eleve = new Form_choix_admin_eleve(form_login,utilisateur);
                    choix_admin_eleve.Show();
                }
                // __________ Si plusieurs mêmes utilisateurs ______
                else if (count > 1)
                {
                    MessageBox.Show("Il y a plusieurs utilisateur avec les mêmes ID ! Accès Refuser !");
                }
                else
                {
                    MessageBox.Show("User ou mot de passe incorect");
                }

                connexion.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode connect " + ex.ToString());
            }
        }
    }
}
