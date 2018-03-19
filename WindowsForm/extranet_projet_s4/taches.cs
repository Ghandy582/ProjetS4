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
// Pour les notifications
using Tulpep.NotificationWindow;

using System.Data;

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

                crea_table.Close();

                //_____ la table pour les tâches réalisée _________
                SQLiteConnection crea_table_taches_realises;
                crea_table_taches_realises = new SQLiteConnection("Data Source=BDD.sqlite;Version=3;");
                crea_table_taches_realises.Open();

                SQLiteCommand cmd2 = crea_table_taches_realises.CreateCommand();

                // le texte de la requete
                cmd2.CommandText = "CREATE TABLE taches_realisees (id_tache_realisees integer primary key,id_membre integer, intitule varchar(250),date_realisation text);";

                // execute la commande
                cmd2.ExecuteNonQuery();

                crea_table_taches_realises.Close();
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
                    // Si le fichier n'existe pas 
                    if (!File.Exists("BDD.sqlite")) {
                        Creation_fichier();
                    }
                    else
                    {
                        MessageBox.Show("c'est votre première connexion sur l'application mais le fichier sqllite existe déjà");
                    }   
                    //on modifie première co dans la bdd
                    Modif_premiereCo(utilisateur);
                }
                else if (!File.Exists("BDD.sqlite"))
                {
                    MessageBox.Show("Le fichier sql lite n'esxiste pas alors que ce n'est pas votre prmière connexion, peut-être avez vous changé d'ordinateur. Voir avec Marine");
                }
                else
                {
                    //MessageBox.Show("Le fichier sqllite existe.");
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
                //MessageBox.Show("Valeur premiere co membre bien modifée dans la BDD");
                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode de modification de la valeur de première co dans la bdd " + ex.ToString());
            }

        }

    }

    //________________________________________________________________________________

     public class Taches
    {
        /*---------------------------- PROPRIETES ---------------------------*/

        /*___ PROPRIETES DANS LE FIFHIER DE CONFIG______*/
        static string serveur = ConfigurationManager.AppSettings["serveur"];
        static string database = ConfigurationManager.AppSettings["database"];
        static string nb_jours_notif_string = ConfigurationManager.AppSettings["nb_jours_notif"];
        static string nb_jours_supression = ConfigurationManager.AppSettings["nb_jours_supression"];
        /*_____________________________________________*/

        // On créé la chaine de connextion avec les valeurs dans le fichier de conf
        MySqlConnection connexion = new MySqlConnection("SERVER=" + serveur + ";" + "DATABASE=" + database + ";" + "UID=root;" + "PASSWORD=;");


        SQLiteConnection ajouter_tache;       // Database Connection Object
        SQLiteCommand sqlite_cmd;             // Database Command Object
        SQLiteDataReader sqlite_datareader;  // Data Reader Object





        /*---------------------------------- METHODES -------------------------------*/

        //rechercher les tâches déjà créées pour acces rapide correspondant à l'id de la personne co
        public void affiche_taches_liste_acces_rapide( CheckedListBox c, int id)
        {
            SQLiteConnection affiche_taches;          // Database Connection Object
            SQLiteCommand sqlite_cmd;             // Database Command Object
            SQLiteDataReader sqlite_datareader;  // Data Reader Object

            affiche_taches = new SQLiteConnection("Data Source=BDD.sqlite;Version=3;New=True;");

            affiche_taches.Open();

            sqlite_cmd = affiche_taches.CreateCommand();

            sqlite_cmd.CommandText = "SELECT intitule FROM taches WHERE id_membre='"+id+"'";

            sqlite_datareader = sqlite_cmd.ExecuteReader();

            // The SQLiteDataReader allows us to run through each row per loop
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                string textReader = sqlite_datareader.GetString(0);
               
                c.Items.Add(textReader);
            }
            affiche_taches.Close();
        }

        //______________________________________________________________________
        // Ajouter une nouvelle tâche si pas de date butoire
        public void Ajout_Tache_Sans_Date(int id_utilisateur, string intitule, string date)
        {
            try
            {
                /*-------- INSERTION DANS LE FICHIER SQLITE ---------*/

                ajouter_tache = new SQLiteConnection("Data Source=BDD.sqlite;Version=3;New=True;");
                ajouter_tache.Open();
                sqlite_cmd = ajouter_tache.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO taches (id_membre,intitule,date_creation, date_butoire) VALUES ('" + id_utilisateur + "','" + intitule + "','" + date+ "', 'NULL');";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                ajouter_tache.Close();
                /*---------------------------------------------------*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode d'ajout de tache sans date butoire" + ex.ToString());
            }

        }
        //______________________________________________________________________
        // Ajouter une nouvelle tâche si une date butoire
        public void Ajout_Tache_Avec_Date(int id_utilisateur, string intitule, string fin_tache,string date_ajout)
        {
            try
            {
                /*-------- INSERTION DANS LE FICHIER SQLITE ---------*/

                ajouter_tache = new SQLiteConnection("Data Source=BDD.sqlite;Version=3;New=True;");
                ajouter_tache.Open();
                sqlite_cmd = ajouter_tache.CreateCommand();
                sqlite_cmd.CommandText = "INSERT INTO taches (id_membre,intitule,date_creation, date_butoire) VALUES ('" + id_utilisateur + "','" + intitule + "','" + date_ajout + "', '"+fin_tache+"');";
                sqlite_datareader = sqlite_cmd.ExecuteReader();
                ajouter_tache.Close();
                /*---------------------------------------------------*/
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode d'ajout de tache avec date butoire" + ex.ToString());
            }
        }

        //______________________________________________________________________
        // Vérifier si une tache arrive bientot à sa date butoire ou périmé
        public void Verification_approche_date_butoire(int id_membre)
        {
            DateTime today = DateTime.Today;
            //fin tache va pas rester Now c'est juste pour que le programme me fiche la paix
            DateTime fin_tache=DateTime.Now;
            int result1;
            int result2;
            int nb_taches_perimes=0;
            int nb_taches_proche_fin=0;
            int nb_tache_bonnes = 0;
            string intitule_peri="";
            string intitule_proche="";
            string date_perime="";
            // On convertie la variable qui est stockée dans le .conf
            double nb_jours_notif = Convert.ToDouble(nb_jours_notif_string);

            SQLiteConnection recherche_tache_echeante;      // Database Connection Object
            SQLiteCommand sqlite_cmd;             // Database Command Object
            SQLiteDataReader sqlite_datareader;  // Data Reader Object
            recherche_tache_echeante = new SQLiteConnection("Data Source=BDD.sqlite;Version=3;New=True;");
            try
            {
                recherche_tache_echeante.Open();

                sqlite_cmd = recherche_tache_echeante.CreateCommand();
                //On sélectionne les taches avec une date butoire correspondant à l'id de la personne co
                sqlite_cmd.CommandText = "SELECT * FROM taches WHERE id_membre='" + id_membre + "' AND date_butoire!='NULL'";

                sqlite_datareader = sqlite_cmd.ExecuteReader();

                // The SQLiteDataReader allows us to run through each row per loop
                while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
                {
                    //on récupère la date butoire pour chaque tache
                    fin_tache = DateTime.Parse(sqlite_datareader.GetString(4));
                    //On compare avec aujourdhui
                    result1 = DateTime.Compare(today, fin_tache);

                    DateTime today_et_deux_jours = today.AddDays(nb_jours_notif);
                    //On compare si proche de fin en fonction du nb de jours choisi
                    result2 = DateTime.Compare(today_et_deux_jours, fin_tache);

                    //Si tache périmé
                    if (result1 > 0)
                    {
                        nb_taches_perimes += 1;
                        intitule_peri = sqlite_datareader.GetString(2);
                        date_perime = fin_tache.ToString();
                    }
                    // Si il reste que nb_jours_notif jour avant date butoire
                    else if (result2 >= 0)
                    {
                        nb_taches_proche_fin += 1;
                        intitule_proche = sqlite_datareader.GetString(2);
                    }
                    else
                    {
                        nb_tache_bonnes += 1;
                    }

                }
                recherche_tache_echeante.Close();
                //MessageBox.Show("Nombre de taches prérimés: " + nb_taches_perimes + " Nombres de taches proche de leurs dates butoire: " + nb_taches_proche_fin + " Nombres de tâches bonnes: " + nb_tache_bonnes);
                Notifier(nb_taches_perimes, nb_taches_proche_fin, intitule_peri, date_perime, intitule_proche, fin_tache.ToShortDateString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode de vérification des taches périmées et celles proche de leurs dates butoire" + ex.ToString());
            }
        }

        //_______________________________________________________________________
        // Les notifications
        public void Notifier(int nb_peri, int nb_proche, string intitule_peri, string date_peri, string intitule_proche, string date_proche)
        {
            PopupNotifier notification = new PopupNotifier();
            notification.Delay = 5000;
            notification.Image = Properties.Resources.icone;
            notification.TitleFont = new System.Drawing.Font("Segoe UI", 10F);
            notification.TitleColor = System.Drawing.Color.FromName("Red");
            notification.ContentFont = new System.Drawing.Font("Segoe UI", 9F);

            try
            {
                if (nb_peri >= 1 && nb_proche >= 1)
                {
                    notification.TitleText = "Retard et date butoire proche";
                    notification.ContentText = "Vous avez du retard pour  " + nb_peri + " tâche(s) et "+nb_proche+" est/sont proches de leur date butoire";
                    notification.Popup();

                }
                else
                {
                    //Si une seule tache périmés
                    if (nb_peri == 1)
                    {

                        notification.TitleText = "Retard pour une tâche";
                        notification.ContentText = "Vous avez du retard pour une tâche. Cela concerne la tâche : " + intitule_peri + " qui devait être terminée avant le " + date_peri;
                        notification.Popup();
                    }
                    //Si plusieurs tâches périmés
                    else if (nb_peri > 1)
                    {
                        notification.TitleText = "Retard pour plusieurs tâches";
                        notification.ContentText = "Vous avez du retard pour plusieurs tâches. Cela concerne " + nb_peri + " tâches.";
                        notification.Popup();
                    }
                    else
                    {

                    }

                    //Si une seule tâche approche de sa date butoire
                    if (nb_proche == 1)
                    {
                        notification.TitleText = "Date butoire proche pour une tâche";
                        notification.ContentText = "L'une de vos tâches approche de sa date butoire. Cela concerne la tâche : " + intitule_proche + " elle doit être réaisée avant le " + date_proche;
                        notification.Popup();
                    }
                    // Si plusieurs tâches approchent de leurs dates butoires
                    else if (nb_proche > 1)
                    {
                        notification.TitleText = "Date butoire proche pour plusieurs tâches";
                        notification.ContentText = "Vous avez plusieurs tâches qui approchent de leur date butoire. Cela concerne " + nb_proche + " tâches.";
                        notification.Popup();
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode de notification" + ex.ToString());
            }
        }

        //_______________________________________________________________________
        // Remplir le datagridview des tâche à réaliser
        public void Remplir_dataGridView_a_realiser(DataGridView v,int id)
        {
            SQLiteConnection conn;          // Database Connection Object
            conn= new SQLiteConnection("Data Source=BDD.sqlite;Version=3;New=True;");
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("SELECT intitule, date_creation, date_butoire FROM taches WHERE id_membre='" + id + "'", conn);
            
            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                dataadapter.Fill(ds, "Info");
                v.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode pour remplir le tableau des tâches à réaliser" + ex.ToString());
            }
        }
        //_______________________________________________________________________
        // Remplir le datagridview des tâche réalisées
        public void Remplir_dataGridView_realisees(DataGridView v, int id)
        {
            SQLiteConnection conn;          // Database Connection Object
            conn = new SQLiteConnection("Data Source=BDD.sqlite;Version=3;New=True;");
            SQLiteDataAdapter dataadapter = new SQLiteDataAdapter("SELECT intitule, date_realisation FROM taches_realisees WHERE id_membre='" + id + "'", conn);

            try
            {
                conn.Open();
                DataSet ds = new DataSet();
                dataadapter.Fill(ds, "Info");
                v.DataSource = ds.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode pour remplir le tableau des tâches réalisées " + ex.ToString());
            }
        }

        //________________________________________________________________________
        // Pour changer les paramètres de taches (modifier le .conf
        public void Changer_parametres_taches(int nb_notif, int nb_supp)
        {
            try
            {
                // on modifie dans le fichier de configuration
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                if (nb_notif == 1)
                {
                    config.AppSettings.Settings.Remove("nb_jours_notif");
                    config.AppSettings.Settings.Add("nb_jours_notif", "1");
                }
                else if (nb_notif == 3)
                {
                    config.AppSettings.Settings.Remove("nb_jours_notif");
                    config.AppSettings.Settings.Add("nb_jours_notif", "3");
                }
                else if (nb_notif == 7)
                {
                    config.AppSettings.Settings.Remove("nb_jours_notif");
                    config.AppSettings.Settings.Add("nb_jours_notif", "7");
                }
                else if (nb_notif==10)
                {
                    config.AppSettings.Settings.Remove("nb_jours_notif");
                    config.AppSettings.Settings.Add("nb_jours_notif", "10");
                }

                if (nb_supp == 3)
                {
                    config.AppSettings.Settings.Remove("nb_jours_supression");
                    config.AppSettings.Settings.Add("nb_jours_supression", "3");
                }
                else if (nb_supp == 7)
                {
                    config.AppSettings.Settings.Remove("nb_jours_supression");
                    config.AppSettings.Settings.Add("nb_jours_supression", "7");
                }
                else if (nb_supp == 15)
                {
                    config.AppSettings.Settings.Remove("nb_jours_supression");
                    config.AppSettings.Settings.Add("nb_jours_supression", "15");
                }
                else if (nb_supp == 30)
                {
                    config.AppSettings.Settings.Remove("nb_jours_supression");
                    config.AppSettings.Settings.Add("nb_jours_supression", "30");
                }

                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("appSettings");
                nb_jours_notif_string = ConfigurationManager.AppSettings["nb_jours_notif"];
                nb_jours_supression = ConfigurationManager.AppSettings["nb_jours_supression"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode de changements des paramètres des tâches " + ex.ToString());
            }

        }

        //_________________________________________________________________________
        // Basculer les tâches réalisés dans la table taches réalisées pour acces rapide
        public void Transfert_tache_realisee(CheckedListBox liste, int id)
        {
            try
            {
                DateTime today = DateTime.Now;
                ajouter_tache = new SQLiteConnection("Data Source=BDD.sqlite;Version=3;New=True;");
                ajouter_tache.Open();
                sqlite_cmd = ajouter_tache.CreateCommand();

                // Pour tous les items cochés
                foreach (object itemChecked in liste.CheckedItems)
                {
                    //---- On ajoute dans la table taches realisées ----
                    
                    sqlite_cmd.CommandText = "INSERT INTO taches_realisees (id_membre,intitule,date_realisation) VALUES ('" + id + "','" + itemChecked.ToString() + "','" + today.ToShortDateString() +  "');";
                    sqlite_datareader = sqlite_cmd.ExecuteReader();
                    sqlite_datareader.Close();
                    //--------------------------------------------------
                    //---- On supprime de la table à réaliser ----------
                    sqlite_cmd.CommandText = "DELETE FROM taches WHERE id_membre='"+id+"' AND intitule='"+ itemChecked.ToString()+"';";
                    sqlite_datareader = sqlite_cmd.ExecuteReader();
                    //--------------------------------------------------                    
                }
                ajouter_tache.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode de transfert des tâches réalisées dans l'accès rapide:  " + ex.ToString());
            }
        }
    }



}
