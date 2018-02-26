using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Windows.Forms;
//Pour utiliser le fichier de configuration
using System.Configuration;
//Pour utiliser mysql
using MySql.Data.MySqlClient;
using System.IO;

namespace extranet_projet_s4
{
    class Sqlite
    {
        /*---------------------------- PROPRIETES ---------------------------*/

        /*___ PROPRIETES DANS LE FIFHIER DE CONFIG______*/
        static string serveur = ConfigurationManager.AppSettings["serveur"];
        static string database = ConfigurationManager.AppSettings["database"];
        /*_____________________________________________*/

        // On créé la chaine de connextion avec les valeurs dans le fichier de conf
        MySqlConnection connexion = new MySqlConnection("SERVER=" + serveur + ";" + "DATABASE=" + database + ";" + "UID=root;" + "PASSWORD=;");

        /*---------------------------------- METHODES -------------------------------*/
        public void Creation_fichier()
        {
            try
            {
                // creer la base de donnée à la première connexion
                SQLiteConnection.CreateFile("BDD.sqlite");

                //_____ la table pour les tâches _________
                SQLiteConnection crea_table;
                crea_table = new SQLiteConnection("Data Source=BDD.sqlite;Version=3;");
                crea_table.Open();

                SQLiteCommand cmd = crea_table.CreateCommand();

                // le texte de la requete
                cmd.CommandText = "CREATE TABLE taches (id_tache integer primary key,id_membre integer, intitule varchar(250),date_creation text, date_butoire text);";

                // execute la commande
                cmd.ExecuteNonQuery();
                //SQLiteDataReader sqlite_datareader;  // Data Reader Object
                crea_table.Close();
                //___ la table pour les emplacment des dossier PLUS TARD

                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode de création du fichier Sqllite " + ex.ToString());
            }

        }
        //_________________________________________________________________
        // Vérfier si prmeière co et si le ficier n'existe pas 
        public void Verification(Utilisateur u)
        {
            Utilisateur utilisateur;
            utilisateur = u;
            try
            {
                if (utilisateur.Premiere_co_membre == 0)
                {
                    Creation_fichier();

                    //on modifie première co dans la bdd
                    Modif_premiereCo(utilisateur);
                }
                else if (!File.Exists("BDD.sqlite"))
                {
                    MessageBox.Show("Le fichier sql lite n'esxiste pas alors que ce n'est pas votre prmière connexion, peut-être avez vous changé d'ordinateur. Voir avec Marine");
                }
                else
                {
                    MessageBox.Show("Le fichier sqllite existe.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode de vérification " + ex.ToString());
            }
        }

        
        //_________________________________________________________________
        //Modifier la variable première co dans la bdd
        public void Modif_premiereCo(Utilisateur u)
        {
            Utilisateur utilisateur;
            utilisateur = u; 
            try {
                MySqlCommand cmd_modi_premire_co = connexion.CreateCommand();
                cmd_modi_premire_co.CommandType= System.Data.CommandType.Text;
                cmd_modi_premire_co.CommandText= "UPDATE `membre` SET `PremiereCo_Membre`=" + 1 + " WHERE `ID_membre`=" + utilisateur.Id_Membre + ";";
                connexion.Open();
                cmd_modi_premire_co.ExecuteNonQuery();
                MessageBox.Show("Valeur premiere co membre bien modifée dans la BDD");
                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode de modification de la valeur de première co dans la bdd " + ex.ToString());
            }

        }

    }

    //________________________________________________________________________________

    class Taches
    {
        /*---------------------------- PROPRIETES ---------------------------*/

        /*___ PROPRIETES DANS LE FIFHIER DE CONFIG______*/
        static string serveur = ConfigurationManager.AppSettings["serveur"];
        static string database = ConfigurationManager.AppSettings["database"];
        /*_____________________________________________*/

        // On créé la chaine de connextion avec les valeurs dans le fichier de conf
        MySqlConnection connexion = new MySqlConnection("SERVER=" + serveur + ";" + "DATABASE=" + database + ";" + "UID=root;" + "PASSWORD=;");

        /*---------------------------------- METHODES -------------------------------*/

        //rechercher les tâches déjà créées
        private void lecture()
        {
            SQLiteConnection crea_table;          // Database Connection Object
            SQLiteCommand sqlite_cmd;             // Database Command Object
            SQLiteDataReader sqlite_datareader;  // Data Reader Object

            crea_table = new SQLiteConnection("Data Source=BDD.sqlite;Version=3;New=True;");

            crea_table.Open();

            sqlite_cmd = crea_table.CreateCommand();

            sqlite_cmd.CommandText = "SELECT * FROM taches";

            sqlite_datareader = sqlite_cmd.ExecuteReader();

            // The SQLiteDataReader allows us to run through each row per loop
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                // Print out the content of the text field:
                // System.Console.WriteLine("DEBUG Output: '" + sqlite_datareader["text"] + "'");

                object idReader = sqlite_datareader.GetValue(0);
                string textReader = sqlite_datareader.GetString(1);
                string dateReader = sqlite_datareader.GetString(3);

                //OutputTextBox.Text += idReader + " '" + textReader + "' " + "\n";
            }
        }
    }

    
}
