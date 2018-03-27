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


        /*---------------------------------- METHODES --------------------------------*/
        public void Affiche_emploi_temps(int id, Button btn_lundi_matin, Button btn_lundi_aprem, Button btn_mardi_matin, Button btn_mardi_aprem, Button btn_mercredi_matin, Button btn_mercredi_aprem, Button btn_jeudi_matin, Button btn_jeudi_aprem, Button btn_vendredi_matin, Button btn_vendredi_aprem)
        {
            try
            {
                DateTime date = DateTime.Today;               
                int jour_semaine = (int)date.DayOfWeek;
                // On définit le premier jour de la semaine en fonction d'aujourd'hui
                //Lundi
                if (jour_semaine == 1)
                {
                    // Lundi
                    Ajouter_dans_boutons(id, btn_lundi_matin, btn_lundi_aprem, date);
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
        public void Afficher_dates_semaine(Label lundi, Label mardi, Label mercredi, Label jeudi, Label vendredi)
        {
            try
            {
                DateTime date = DateTime.Today;
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
    }
}
