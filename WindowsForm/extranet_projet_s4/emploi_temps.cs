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
    public class Emploi_temps
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
        string[] notes = new string[10];
        string[] profs = new string[10];
        string[] notes_perso = new string[10];
        string[] promotions = new string[10];



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
                    Ajouter_dans_boutons(id, btn_lundi_matin, btn_lundi_aprem, date,0);
                    premier_jour_semaine = date;
                    // Mardi
                    date = date.AddDays(1); ;
                    Ajouter_dans_boutons(id, btn_mardi_matin, btn_mardi_aprem, date,2);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_mercredi_matin, btn_mercredi_aprem, date,4);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_jeudi_matin, btn_jeudi_aprem, date,6);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_vendredi_matin, btn_vendredi_aprem, date,8);
                }
                //Mardi
                else if (jour_semaine == 2)
                {
                    date = date.AddDays(-1);
                    // Lundi
                    Ajouter_dans_boutons(id, btn_lundi_matin, btn_lundi_aprem, date, 0);
                    premier_jour_semaine = date;
                    // Mardi
                    date = date.AddDays(1); ;
                    Ajouter_dans_boutons(id, btn_mardi_matin, btn_mardi_aprem, date, 2);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_mercredi_matin, btn_mercredi_aprem, date, 4);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_jeudi_matin, btn_jeudi_aprem, date, 6);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_vendredi_matin, btn_vendredi_aprem, date, 8);
                }
                //Mercredi
                else if (jour_semaine == 3)
                {
                    date = date.AddDays(-2);
                    // Lundi
                    Ajouter_dans_boutons(id, btn_lundi_matin, btn_lundi_aprem, date, 0);
                    premier_jour_semaine = date;
                    // Mardi
                    date = date.AddDays(1); ;
                    Ajouter_dans_boutons(id, btn_mardi_matin, btn_mardi_aprem, date, 2);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_mercredi_matin, btn_mercredi_aprem, date, 4);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_jeudi_matin, btn_jeudi_aprem, date, 6);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_vendredi_matin, btn_vendredi_aprem, date, 8);
                }
                //Jeudi 
                else if (jour_semaine == 4)
                {
                    date = date.AddDays(-3);
                    // Lundi
                    Ajouter_dans_boutons(id, btn_lundi_matin, btn_lundi_aprem, date, 0);
                    premier_jour_semaine = date;
                    // Mardi
                    date = date.AddDays(1); ;
                    Ajouter_dans_boutons(id, btn_mardi_matin, btn_mardi_aprem, date, 2);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_mercredi_matin, btn_mercredi_aprem, date, 4);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_jeudi_matin, btn_jeudi_aprem, date, 6);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_vendredi_matin, btn_vendredi_aprem, date, 8);
                }
                //Vendredi
                else if (jour_semaine == 5)
                {
                    date = date.AddDays(-4);
                    // Lundi
                    Ajouter_dans_boutons(id, btn_lundi_matin, btn_lundi_aprem, date, 0);
                    premier_jour_semaine = date;
                    // Mardi
                    date = date.AddDays(1); ;
                    Ajouter_dans_boutons(id, btn_mardi_matin, btn_mardi_aprem, date, 2);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_mercredi_matin, btn_mercredi_aprem, date, 4);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_jeudi_matin, btn_jeudi_aprem, date, 6);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_vendredi_matin, btn_vendredi_aprem, date, 8);
                }
                //Samedi 
                else if (jour_semaine == 6)
                {
                    date = date.AddDays(-5);
                    // Lundi
                    Ajouter_dans_boutons(id, btn_lundi_matin, btn_lundi_aprem, date, 0);
                    premier_jour_semaine = date;
                    // Mardi
                    date = date.AddDays(1); ;
                    Ajouter_dans_boutons(id, btn_mardi_matin, btn_mardi_aprem, date, 2);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_mercredi_matin, btn_mercredi_aprem, date, 4);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_jeudi_matin, btn_jeudi_aprem, date, 6);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_vendredi_matin, btn_vendredi_aprem, date, 8);
                }
                //Dimanche
                else if (jour_semaine == 7)
                {
                    date = date.AddDays(-6);
                    // Lundi
                    Ajouter_dans_boutons(id, btn_lundi_matin, btn_lundi_aprem, date, 0);
                    premier_jour_semaine = date;
                    // Mardi
                    date = date.AddDays(1); ;
                    Ajouter_dans_boutons(id, btn_mardi_matin, btn_mardi_aprem, date, 2);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_mercredi_matin, btn_mercredi_aprem, date, 4);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_jeudi_matin, btn_jeudi_aprem, date, 6);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons(id, btn_vendredi_matin, btn_vendredi_aprem, date, 8);
                }

                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode d'affichage de l'emploi du temps " + ex.ToString());
            }
        }

        //______________________________________________________
        //ajouter les informations dans le bouton + stocker les infos pour la fenetres infos supplémentaires 
        public void Ajouter_dans_boutons(int id, Button btn_matin, Button btn_aprem, DateTime date, int num_tab)
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
                            notes[num_tab] = Reader1.GetString("Note_Seance");
                            profs[num_tab] = Reader1.GetString("Prenom") + " " + Reader1.GetString("Nom");
                        }
                        else
                        {
                            btn_aprem.Text = Libelle_Cours;
                            btn_aprem.BackColor = System.Drawing.Color.FromArgb(couleur);
                            notes[num_tab + 1] = Reader1.GetString("Note_Seance");
                            profs[num_tab + 1] = Reader1.GetString("Prenom") + " " + Reader1.GetString("Nom");
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
        // afficher toutes les dates de la semaine eleve
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
        public void Remetre_zero_affichage_emploi_temps(string texte,Button btn_lundi_matin, Button btn_lundi_aprem, Button btn_mardi_matin, Button btn_mardi_aprem, Button btn_mercredi_matin, Button btn_mercredi_aprem, Button btn_jeudi_matin, Button btn_jeudi_aprem, Button btn_vendredi_matin, Button btn_vendredi_aprem)
        {

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

        //____________________________________________________________
        // remplir les informations dans la fenètre d'informations
        public void Remplir_fenetre_infos(string date, Label lb_date, Button btn_a_remplir, Button btn,int empla_tab, Label prof, TextBox note)
        {
            lb_date.Text = date;
            btn_a_remplir.BackColor = btn.BackColor;
            btn_a_remplir.Text = btn.Text;
            switch (empla_tab)
            {
                case 0:
                    prof.Text = profs[0];
                    note.Text = notes[0];
                    break;
                case 1:
                    prof.Text = profs[1];
                    note.Text = notes[1];
                    break;
                case 2:
                    prof.Text = profs[2];
                    note.Text = notes[2];
                    break;
                case 3:
                    prof.Text = profs[3];
                    note.Text = notes[3];
                    break;
                case 4:
                    prof.Text = profs[4];
                    note.Text = notes[4];
                    break;
                case 5:
                    prof.Text = profs[5];
                    note.Text = notes[5];
                    break;
                case 6:
                    prof.Text = profs[6];
                    note.Text = notes[6];
                    break;
                case 7:
                    prof.Text = profs[7];
                    note.Text = notes[7];
                    break;
                case 8:
                    prof.Text = profs[8];
                    note.Text = notes[8];
                    break;
                case 9:
                    prof.Text = profs[9];
                    note.Text = notes[9];
                    break;


            }
        }
        //______________________________________________________
        //ajouter les informations dans le bouton + stocker les infos pour la fenetres infos supplémentaires 
        public void Ajouter_dans_boutons_profs(int id, Button btn_matin, Button btn_aprem, DateTime date, int num_tab)
        {
            try
            {
                connexion.Open();
                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM emploi2 WHERE ID_membre ='" + id + "' AND Date_Seance='" + date.ToShortDateString() + "';", connexion);
                using (MySqlDataReader Reader1 = cmd1.ExecuteReader())
                {
                    while (Reader1.Read())
                    {
                        string Libelle_Cours = Reader1.GetString("Libelle_Cours");
                        int couleur = Reader1.GetInt32("Couleur_Cours");
                        bool debut_seance = Reader1.GetBoolean("Debut_Seance");
                        string promotion = Reader1.GetString("Libelle_Groupe");

                        if (debut_seance == true)
                        {
                            btn_matin.Text = Libelle_Cours+"\n"+promotion;
                            btn_matin.BackColor = System.Drawing.Color.FromArgb(couleur);
                            notes[num_tab] = Reader1.GetString("Note_Seance");
                            notes_perso[num_tab] = Reader1.GetString("NotePersonnel_Seance");
                            promotions[num_tab] = promotion;
                        }
                        else
                        {
                            btn_aprem.Text = Libelle_Cours + "\n" + promotion;
                            btn_aprem.BackColor = System.Drawing.Color.FromArgb(couleur);
                            notes[num_tab + 1] = Reader1.GetString("Note_Seance");
                            notes_perso[num_tab + 1] = Reader1.GetString("NotePersonnel_Seance");
                            promotions[num_tab + 1] = promotion;
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
        //_______________________________________________________
        public void Affiche_emploi_temps_profs(DateTime date, int id, Button btn_lundi_matin, Button btn_lundi_aprem, Button btn_mardi_matin, Button btn_mardi_aprem, Button btn_mercredi_matin, Button btn_mercredi_aprem, Button btn_jeudi_matin, Button btn_jeudi_aprem, Button btn_vendredi_matin, Button btn_vendredi_aprem)
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
                    Ajouter_dans_boutons_profs(id, btn_lundi_matin, btn_lundi_aprem, date, 0);
                    premier_jour_semaine = date;
                    // Mardi
                    date = date.AddDays(1); ;
                    Ajouter_dans_boutons_profs(id, btn_mardi_matin, btn_mardi_aprem, date, 2);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons_profs(id, btn_mercredi_matin, btn_mercredi_aprem, date, 4);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons_profs(id, btn_jeudi_matin, btn_jeudi_aprem, date, 6);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons_profs(id, btn_vendredi_matin, btn_vendredi_aprem, date, 8);
                }
                //Mardi
                else if (jour_semaine == 2)
                {
                    date = date.AddDays(-1);
                    // Lundi
                    Ajouter_dans_boutons_profs(id, btn_lundi_matin, btn_lundi_aprem, date, 0);
                    premier_jour_semaine = date;
                    // Mardi
                    date = date.AddDays(1); ;
                    Ajouter_dans_boutons_profs(id, btn_mardi_matin, btn_mardi_aprem, date, 2);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons_profs(id, btn_mercredi_matin, btn_mercredi_aprem, date, 4);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons_profs(id, btn_jeudi_matin, btn_jeudi_aprem, date, 6);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons_profs(id, btn_vendredi_matin, btn_vendredi_aprem, date, 8);
                }
                //Mercredi
                else if (jour_semaine == 3)
                {
                    date = date.AddDays(-2);
                    // Lundi
                    Ajouter_dans_boutons_profs(id, btn_lundi_matin, btn_lundi_aprem, date, 0);
                    premier_jour_semaine = date;
                    // Mardi
                    date = date.AddDays(1); ;
                    Ajouter_dans_boutons_profs(id, btn_mardi_matin, btn_mardi_aprem, date, 2);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons_profs(id, btn_mercredi_matin, btn_mercredi_aprem, date, 4);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons_profs(id, btn_jeudi_matin, btn_jeudi_aprem, date, 6);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons_profs(id, btn_vendredi_matin, btn_vendredi_aprem, date, 8);
                }
                //Jeudi 
                else if (jour_semaine == 4)
                {
                    date = date.AddDays(-3);
                    // Lundi
                    Ajouter_dans_boutons_profs(id, btn_lundi_matin, btn_lundi_aprem, date, 0);
                    premier_jour_semaine = date;
                    // Mardi
                    date = date.AddDays(1); ;
                    Ajouter_dans_boutons_profs(id, btn_mardi_matin, btn_mardi_aprem, date, 2);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons_profs(id, btn_mercredi_matin, btn_mercredi_aprem, date, 4);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons_profs(id, btn_jeudi_matin, btn_jeudi_aprem, date, 6);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons_profs(id, btn_vendredi_matin, btn_vendredi_aprem, date, 8);
                }
                //Vendredi
                else if (jour_semaine == 5)
                {
                    date = date.AddDays(-4);
                    // Lundi
                    Ajouter_dans_boutons_profs(id, btn_lundi_matin, btn_lundi_aprem, date, 0);
                    premier_jour_semaine = date;
                    // Mardi
                    date = date.AddDays(1); ;
                    Ajouter_dans_boutons_profs(id, btn_mardi_matin, btn_mardi_aprem, date, 2);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons_profs(id, btn_mercredi_matin, btn_mercredi_aprem, date, 4);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons_profs(id, btn_jeudi_matin, btn_jeudi_aprem, date, 6);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons_profs(id, btn_vendredi_matin, btn_vendredi_aprem, date, 8);
                }
                //Samedi 
                else if (jour_semaine == 6)
                {
                    date = date.AddDays(-5);
                    // Lundi
                    Ajouter_dans_boutons_profs(id, btn_lundi_matin, btn_lundi_aprem, date, 0);
                    premier_jour_semaine = date;
                    // Mardi
                    date = date.AddDays(1); ;
                    Ajouter_dans_boutons_profs(id, btn_mardi_matin, btn_mardi_aprem, date, 2);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons_profs(id, btn_mercredi_matin, btn_mercredi_aprem, date, 4);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons_profs(id, btn_jeudi_matin, btn_jeudi_aprem, date, 6);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons_profs(id, btn_vendredi_matin, btn_vendredi_aprem, date, 8);
                }
                //Dimanche
                else if (jour_semaine == 7)
                {
                    date = date.AddDays(-6);
                    // Lundi
                    Ajouter_dans_boutons_profs(id, btn_lundi_matin, btn_lundi_aprem, date, 0);
                    premier_jour_semaine = date;
                    // Mardi
                    date = date.AddDays(1); ;
                    Ajouter_dans_boutons_profs(id, btn_mardi_matin, btn_mardi_aprem, date, 2);
                    // Mercredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons_profs(id, btn_mercredi_matin, btn_mercredi_aprem, date, 4);
                    // Jeudi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons_profs(id, btn_jeudi_matin, btn_jeudi_aprem, date, 6);
                    // Vendredi
                    date = date.AddDays(1);
                    Ajouter_dans_boutons_profs(id, btn_vendredi_matin, btn_vendredi_aprem, date, 8);
                }

                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode d'affichage de l'emploi du temps " + ex.ToString());
            }
        }
        //____________________________________________________________
        // remplir les informations dans la fenètre d'informations
        public void Remplir_fenetre_infos_prof(string date, Label lb_date, Button btn_a_remplir, Button btn, int empla_tab, Label promo, TextBox note, TextBox note_perso)
        {
            lb_date.Text = date;
            btn_a_remplir.BackColor = btn.BackColor;
            btn_a_remplir.Text = btn.Text;
            switch (empla_tab)
            {
                case 0:
                    promo.Text = promotions[0];
                    note.Text = notes[0];
                    note_perso.Text = notes_perso[0];
                    break;
                case 1:
                    promo.Text = promotions[1];
                    note.Text = notes[1];
                    note_perso.Text = notes_perso[1];
                    break;
                case 2:
                    promo.Text = promotions[2];
                    note.Text = notes[2];
                    note_perso.Text = notes_perso[2];
                    break;
                case 3:
                    promo.Text = promotions[3];
                    note.Text = notes[3];
                    note_perso.Text = notes_perso[3];
                    break;
                case 4:
                    promo.Text = promotions[4];
                    note.Text = notes[4];
                    note_perso.Text = notes_perso[4];
                    break;
                case 5:
                    promo.Text = promotions[5];
                    note.Text = notes[5];
                    note_perso.Text = notes_perso[5];
                    break;
                case 6:
                    promo.Text = promotions[6];
                    note.Text = notes[6];
                    note_perso.Text = notes_perso[6];
                    break;
                case 7:
                    promo.Text = promotions[7];
                    note.Text = notes[7];
                    note_perso.Text = notes_perso[7];
                    break;
                case 8:
                    promo.Text = promotions[8];
                    note.Text = notes[8];
                    note_perso.Text = notes_perso[8];
                    break;
                case 9:
                    promo.Text = promotions[9];
                    note.Text = notes[9];
                    note_perso.Text = notes_perso[9];
                    break;


            }
        }
    }
}
