using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Pour utiliser mysql
using MySql.Data.MySqlClient;
//Pour utiliser le fichier de configuration
using System.Configuration;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace extranet_projet_s4
{
    class Emploi_temps
    {
        /*---------------------------- PROPRIETES ---------------------------*/

        /*___ PROPRIETES DANS LE FIFHIER DE CONFIG______*/
        static string serveur = ConfigurationManager.AppSettings["serveur"];
        static string database = ConfigurationManager.AppSettings["database"];
        /*_____________________________________________*/
        // On créé la chaine de connextion avec les valeurs dans le fichier de conf
        MySqlConnection connexion = new MySqlConnection("SERVER=" + serveur + ";" + "DATABASE=" + database + ";" + "UID=root;" + "PASSWORD=;");
        // stocker le premier jour de la semaine
        DateTime premier_jour_semaine;
        //stocker les notes et les professeurs
        //------------------------------
        /*---------------------------------- METHODES --------------------------------*/
        public void Affiche_emploi_temps(DateTime date,int id, Button btn_lundi_matin, Button btn_lundi_aprem, Button btn_mardi_matin, Button btn_mardi_aprem, Button btn_mercredi_matin, Button btn_mercredi_aprem, Button btn_jeudi_matin, Button btn_jeudi_aprem, Button btn_vendredi_matin, Button btn_vendredi_aprem)
        {
            try
            {
               // DateTime date = DateTime.Today;               
                int jour_semaine = (int)date.DayOfWeek;
                // On définit le premier jour de la semaine en fonction d'aujourd'hui
                //Lundi
                if (jour_semaine == 1)
                {
                    // Lundi
                    Ajouter_dans_boutons(id, btn_lundi_matin, btn_lundi_aprem, date);
                    premier_jour_semaine = date;
                    // Mardi
                    date = date.AddDays(1); ;
                    Ajouter_dans_boutons(id, btn_mardi_matin, btn_mardi_aprem, date);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_mercredi_matin, btn_mercredi_aprem, date);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_jeudi_matin, btn_jeudi_aprem, date);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_vendredi_matin, btn_vendredi_aprem, date);
                }
                //Mardi
                else if (jour_semaine == 2)
                {
                    date = date.AddDays(-1);
                    // Lundi
                    premier_jour_semaine = date;
                    Ajouter_dans_boutons(id, btn_lundi_matin, btn_lundi_aprem, date);
                    // Mardi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_mardi_matin, btn_mardi_aprem, date);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_mercredi_matin, btn_mercredi_aprem, date);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_jeudi_matin, btn_jeudi_aprem, date);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_vendredi_matin, btn_vendredi_aprem, date);
                }
                //Mercredi
                else if (jour_semaine == 3)
                {
                    date = date.AddDays(-2);
                    // Lundi
                    premier_jour_semaine = date;
                    Ajouter_dans_boutons(id, btn_lundi_matin, btn_lundi_aprem, date);
                    // Mardi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_mardi_matin, btn_mardi_aprem, date);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_mercredi_matin, btn_mercredi_aprem, date);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_jeudi_matin, btn_jeudi_aprem, date);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_vendredi_matin, btn_vendredi_aprem, date);
                }
                //Jeudi 
                else if (jour_semaine == 4)
                {
                    date = date.AddDays(-3);
                    // Lundi
                    premier_jour_semaine = date;
                    Ajouter_dans_boutons(id, btn_lundi_matin, btn_lundi_aprem, date);
                    // Mardi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_mardi_matin, btn_mardi_aprem, date);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_mercredi_matin, btn_mercredi_aprem, date);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_jeudi_matin, btn_jeudi_aprem, date);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_vendredi_matin, btn_vendredi_aprem, date);
                }
                //Vendredi
                else if (jour_semaine == 5)
                {
                    date = date.AddDays(-4);
                    // Lundi
                    premier_jour_semaine = date;
                    Ajouter_dans_boutons(id, btn_lundi_matin, btn_lundi_aprem, date);
                    // Mardi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_mardi_matin, btn_mardi_aprem, date);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_mercredi_matin, btn_mercredi_aprem, date);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_jeudi_matin, btn_jeudi_aprem, date);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_vendredi_matin, btn_vendredi_aprem, date);
                }
                //Samedi 
                else if (jour_semaine == 6)
                {
                    date = date.AddDays(-5);
                    // Lundi
                    premier_jour_semaine = date;
                    Ajouter_dans_boutons(id, btn_lundi_matin, btn_lundi_aprem, date);
                    // Mardi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_mardi_matin, btn_mardi_aprem, date);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_mercredi_matin, btn_mercredi_aprem, date);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_jeudi_matin, btn_jeudi_aprem, date);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_vendredi_matin, btn_vendredi_aprem, date);
                }
                //Dimanche
                else if (jour_semaine == 7)
                {
                    date = date.AddDays(-6);
                    // Lundi
                    premier_jour_semaine = date;
                    Ajouter_dans_boutons(id, btn_lundi_matin, btn_lundi_aprem, date);
                    // Mardi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_mardi_matin, btn_mardi_aprem, date);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_mercredi_matin, btn_mercredi_aprem, date);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_jeudi_matin, btn_jeudi_aprem, date);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_vendredi_matin, btn_vendredi_aprem, date);
                }

                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode d'affichage de l'emploi du temps " + ex.ToString());
            }
        }

        //______________________________________________________
        //ajouter les informations dans le bouton
        public void Ajouter_dans_boutons(int id, Button btn_matin, Button btn_aprem, DateTime date)
        {
            try
            {
                connexion.Open();
                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM emploi WHERE ID_Groupe ='" + id + "' AND Date_Seance='" + date.ToShortDateString() + "';", connexion);
                using (MySqlDataReader Reader1 = cmd1.ExecuteReader())
                {
                    while (Reader1.Read())
                    {
                        string Libelle_Cours = Reader1.GetString("Libelle_Cours");
                        int couleur = Reader1.GetInt32("Couleur_Cours");
                        bool debut_seance = Reader1.GetBoolean("Debut_Seance");
                        if (debut_seance == true)
                        {
                            btn_matin.Text = Libelle_Cours;
                            btn_matin.BackColor = System.Drawing.Color.FromArgb(couleur);
                        }
                        else
                        {
                            btn_aprem.Text = Libelle_Cours;
                            btn_aprem.BackColor = System.Drawing.Color.FromArgb(couleur);

                        }
                    }
                    Reader1.Close();
                }
                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode Ajouter dans boutons pour l'emploi du temps " + ex.ToString());
            }


        }

        //_________________________________________________________
        //remplir un label avec une date
        public void Ajouter_dans_label(Label jour, DateTime date)
        {
            jour.Text = date.ToShortDateString();
        }
        
        //__________________________________________________________
        // afficher toutes les dates de la semaine
        public void Afficher_dates_semaine(DateTime date,Label lundi, Label mardi, Label mercredi, Label jeudi, Label vendredi)
        {
            try
            {
                int jour_semaine = (int)date.DayOfWeek;
                if (jour_semaine == 1)
                {
                    // Lundi
                    Ajouter_dans_label(lundi, date);
                    // Mardi
                    date = date.AddDays(1);
                    Ajouter_dans_label(mardi, date);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_label(mercredi, date);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_label(jeudi, date);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_label(vendredi, date);
                }
                //Mardi
                else if (jour_semaine == 2)
                {
                    date = date.AddDays(-1);
                    // Lundi
                    Ajouter_dans_label(lundi, date);
                    // Mardi
                    date = date.AddDays(1);
                    Ajouter_dans_label(mardi, date);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_label(mercredi, date);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_label(jeudi, date);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_label(vendredi, date);
                }
                //Mercredi
                else if (jour_semaine == 3)
                {
                    date = date.AddDays(-2);
                    // Lundi
                    Ajouter_dans_label(lundi, date);
                    // Mardi
                    date = date.AddDays(1);
                    Ajouter_dans_label(mardi, date);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_label(mercredi, date);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_label(jeudi, date);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_label(vendredi, date);
                }
                //Jeudi 
                else if (jour_semaine == 4)
                {
                    date = date.AddDays(-3);
                    // Lundi
                    Ajouter_dans_label(lundi, date);
                    // Mardi
                    date = date.AddDays(1);
                    Ajouter_dans_label(mardi, date);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_label(mercredi, date);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_label(jeudi, date);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_label(vendredi, date);
                }
                //Vendredi
                else if (jour_semaine == 5)
                {
                    date = date.AddDays(-4);
                    // Lundi
                    Ajouter_dans_label(lundi, date);
                    // Mardi
                    date = date.AddDays(1);
                    Ajouter_dans_label(mardi, date);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_label(mercredi, date);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_label(jeudi, date);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_label(vendredi, date);
                }
                //Samedi 
                else if (jour_semaine == 6)
                {
                    date = date.AddDays(-5);
                    // Lundi
                    Ajouter_dans_label(lundi, date);
                    // Mardi
                    date = date.AddDays(1);
                    Ajouter_dans_label(mardi, date);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_label(mercredi, date);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_label(jeudi, date);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_label(vendredi, date);
                }
                //Dimanche
                else if (jour_semaine == 7)
                {
                    date = date.AddDays(-6);
                    // Lundi
                    Ajouter_dans_label(lundi, date);
                    // Mardi
                    date = date.AddDays(1);
                    Ajouter_dans_label(mardi, date);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_label(mercredi, date);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_label(jeudi, date);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_label(vendredi, date);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode Afficher_dates_semaine pour l'emploi du temps " + ex.ToString());
            }

        }

        //__________________________________________________________
        //remettre du projet blanc partout pour l'affichage
        public void Remetre_zero_affichage_emploi_temps(Button btn_lundi_matin, Button btn_lundi_aprem, Button btn_mardi_matin, Button btn_mardi_aprem, Button btn_mercredi_matin, Button btn_mercredi_aprem, Button btn_jeudi_matin, Button btn_jeudi_aprem, Button btn_vendredi_matin, Button btn_vendredi_aprem)
        {
            string texte = "Projet blanc";

            btn_lundi_matin.Text = texte;
            btn_lundi_aprem.Text = texte;
            btn_mardi_matin.Text = texte;
            btn_mardi_aprem.Text = texte;
            btn_mercredi_matin.Text = texte;
            btn_mercredi_aprem.Text = texte;
            btn_jeudi_matin.Text = texte;
            btn_jeudi_aprem.Text = texte;
            btn_vendredi_matin.Text = texte;
            btn_vendredi_aprem.Text = texte;
            btn_lundi_matin.BackColor = System.Drawing.Color.FromName("White");
            btn_lundi_aprem.BackColor = System.Drawing.Color.FromName("White");
            btn_mardi_matin.BackColor = System.Drawing.Color.FromName("White");
            btn_mardi_aprem.BackColor = System.Drawing.Color.FromName("White");
            btn_mercredi_matin.BackColor = System.Drawing.Color.FromName("White");
            btn_mercredi_aprem.BackColor = System.Drawing.Color.FromName("White");
            btn_jeudi_matin.BackColor = System.Drawing.Color.FromName("White");
            btn_jeudi_aprem.BackColor = System.Drawing.Color.FromName("White");
            btn_vendredi_matin.BackColor = System.Drawing.Color.FromName("White");
            btn_vendredi_aprem.BackColor = System.Drawing.Color.FromName("White");

        }
        //__________________________________________________________
        public DateTime Premier_jour_semaine
        {
            get { return premier_jour_semaine; }
            set { premier_jour_semaine = value; }
        }
        //___________________________________________________________
        // afficher les dernières notes 
        public void Afficher_dernieres_notes(DataGridView view, int id)
        {
            try
            {
                connexion.Open();
                
                MySqlDataAdapter dataadapter = new MySqlDataAdapter("SELECT note.Note, note.Libelle_Note, cours.Libelle_Cours FROM note INNER JOIN cours ON note.ID_Cours=cours.ID_Cours WHERE ID_Membre ='" + id + "' ORDER BY ID_Note DESC LIMIT 5;", connexion);
                DataSet ds = new DataSet();
                dataadapter.Fill(ds, "Info");
                view.DataSource = ds.Tables[0];
                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode d'affichage des dernières notes " + ex.ToString());
            }

        }
    }
}
