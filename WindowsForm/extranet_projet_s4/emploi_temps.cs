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
        public void Affiche_emploi_temps(int id,Button btn_lundi_matin, Button btn_lundi_aprem, Button btn_mardi_matin, Button btn_mardi_aprem, Button btn_mercredi_matin, Button btn_mercredi_aprem, Button btn_jeudi_matin, Button btn_jeudi_aprem, Button btn_vendredi_matin, Button btn_vendredi_aprem)
        {
            try
            {
                DateTime date = DateTime.Today;
                connexion.Open();
                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM emploi WHERE ID_Groupe ='"+id+"' AND Date_Seance='"+DateTime.Today.ToShortDateString()+"';", connexion);
                int jour_semaine = (int)DateTime.Today.DayOfWeek;
                using (MySqlDataReader Reader1 = cmd1.ExecuteReader())
                {
                    // On place d'abord la date d'aujourd'hui
                    while (Reader1.Read())
                    {
                        string Libelle_Cours = Reader1.GetString("Libelle_Cours");
                        int couleur = Reader1.GetInt32("Couleur_Cours");
                        bool debut_seance = Reader1.GetBoolean("Debut_Seance");
                        //Lundi
                        if (jour_semaine == 1)
                        {
                            if (debut_seance == true)
                            {
                                btn_lundi_matin.Text = Libelle_Cours;
                                btn_lundi_matin.BackColor = System.Drawing.Color.FromArgb(couleur);
                            }
                            else
                            {
                                btn_lundi_aprem.Text = Libelle_Cours;
                                btn_lundi_aprem.BackColor = System.Drawing.Color.FromArgb(couleur);

                            }
                        }
                        //Mardi
                        if (jour_semaine == 2)
                        {
                            if (debut_seance == true)
                            {
                                btn_mardi_matin.Text = Libelle_Cours;
                                btn_mardi_matin.BackColor = System.Drawing.Color.FromArgb(couleur);
                            }
                            else
                            {
                                btn_mardi_aprem.Text = Libelle_Cours;
                                btn_mardi_aprem.BackColor = System.Drawing.Color.FromArgb(couleur);

                            }
                        }
                        //Mercredi
                        if (jour_semaine == 3)
                        {
                            if (debut_seance == true)
                            {
                                btn_mercredi_matin.Text = Libelle_Cours;
                                btn_mercredi_matin.BackColor = System.Drawing.Color.FromArgb(couleur);
                            }
                            else
                            {
                                btn_mercredi_aprem.Text = Libelle_Cours;
                                btn_mercredi_aprem.BackColor = System.Drawing.Color.FromArgb(couleur);

                            }
                        }
                        //Jeudi 
                        if (jour_semaine == 4)
                        {
                            if (debut_seance == true)
                            {
                                btn_jeudi_matin.Text = Libelle_Cours;
                                btn_jeudi_matin.BackColor = System.Drawing.Color.FromArgb(couleur);
                            }
                            else
                            {
                                btn_jeudi_aprem.Text = Libelle_Cours;
                                btn_jeudi_aprem.BackColor = System.Drawing.Color.FromArgb(couleur);

                            }
                        }
                        //Vendredi
                        if (jour_semaine == 5)
                        {
                            if (debut_seance == true)
                            {
                                btn_vendredi_matin.Text = Libelle_Cours;
                                btn_vendredi_matin.BackColor = System.Drawing.Color.FromArgb(couleur);
                            }
                            else
                            {
                                btn_vendredi_aprem.Text = Libelle_Cours;
                                btn_vendredi_aprem.BackColor = System.Drawing.Color.FromArgb(couleur);

                            }
                        }
                        //Week end 
                        if (jour_semaine == 6 || jour_semaine == 7)
                        {
                            MessageBox.Show("penser à gérer quand on se connecte alors que c'est le weekend");
                        }
                    }
                    Reader1.Close();
                    //--------------------------------------------------------------------------
                    // On place le reste en fonction du premier jour
                    if (jour_semaine == 1)
                    {
                        //On ajoute ou supprime des jours par rapport à aujourd'hui
                        date = DateTime.Today.AddDays(1);
                         cmd1 = new MySqlCommand("SELECT * FROM emploi WHERE ID_Groupe ='" + id + "' AND Date_Seance='" + date.ToShortDateString() + "';", connexion);
                         using (MySqlDataReader Reader2 = cmd1.ExecuteReader())
                        {
                            while (Reader2.Read())
                            {
                                string Libelle_Cours = Reader2.GetString("Libelle_Cours");
                                int couleur = Reader2.GetInt32("Couleur_Cours");
                                bool debut_seance = Reader2.GetBoolean("Debut_Seance");
                                //On ajoute mardi 
                                if (debut_seance == true)
                                {
                                    btn_mardi_matin.Text = Libelle_Cours;
                                    btn_mardi_matin.BackColor = System.Drawing.Color.FromArgb(couleur);
                                }
                                else
                                {
                                    btn_mardi_aprem.Text = Libelle_Cours;
                                    btn_mardi_aprem.BackColor = System.Drawing.Color.FromArgb(couleur);

                                }
                            }
                            Reader2.Close();
                               
                        }
                        //------------------------------------------------------
                        //Mercredi
                        //On ajoute ou supprime des jours par rapport à aujourd'hui
                        date = DateTime.Today.AddDays(2);
                        cmd1 = new MySqlCommand("SELECT * FROM emploi WHERE ID_Groupe ='" + id + "' AND Date_Seance='" + date.ToShortDateString() + "';", connexion);
                        using (MySqlDataReader Reader3 = cmd1.ExecuteReader())
                        {
                            while (Reader3.Read())
                            {
                                string Libelle_Cours = Reader3.GetString("Libelle_Cours");
                                int couleur = Reader3.GetInt32("Couleur_Cours");
                                bool debut_seance = Reader3.GetBoolean("Debut_Seance");
                                //On ajoute mardi 
                                if (debut_seance == true)
                                {
                                    btn_mercredi_matin.Text = Libelle_Cours;
                                    btn_mercredi_matin.BackColor = System.Drawing.Color.FromArgb(couleur);
                                }
                                else
                                {
                                    btn_mercredi_aprem.Text = Libelle_Cours;
                                    btn_mercredi_aprem.BackColor = System.Drawing.Color.FromArgb(couleur);

                                }
                            }
                            Reader3.Close();

                        }
                        //------------------------------------------------------
                        //Jeudi
                        //On ajoute ou supprime des jours par rapport à aujourd'hui
                        date = DateTime.Today.AddDays(3);
                        cmd1 = new MySqlCommand("SELECT * FROM emploi WHERE ID_Groupe ='" + id + "' AND Date_Seance='" + date.ToShortDateString() + "';", connexion);
                        using (MySqlDataReader Reader4 = cmd1.ExecuteReader())
                        {
                            while (Reader4.Read())
                            {
                                string Libelle_Cours = Reader4.GetString("Libelle_Cours");
                                int couleur = Reader4.GetInt32("Couleur_Cours");
                                bool debut_seance = Reader4.GetBoolean("Debut_Seance");
                                //On ajoute mardi 
                                if (debut_seance == true)
                                {
                                    btn_jeudi_matin.Text = Libelle_Cours;
                                    btn_jeudi_matin.BackColor = System.Drawing.Color.FromArgb(couleur);
                                }
                                else
                                {
                                    btn_jeudi_aprem.Text = Libelle_Cours;
                                    btn_jeudi_aprem.BackColor = System.Drawing.Color.FromArgb(couleur);

                                }
                            }
                            Reader4.Close();

                        }
                        //------------------------------------------------------
                        //Vendredi
                        //On ajoute ou supprime des jours par rapport à aujourd'hui
                        date = DateTime.Today.AddDays(4);
                        cmd1 = new MySqlCommand("SELECT * FROM emploi WHERE ID_Groupe ='" + id + "' AND Date_Seance='" + date.ToShortDateString() + "';", connexion);
                        using (MySqlDataReader Reader5 = cmd1.ExecuteReader())
                        {
                            while (Reader5.Read())
                            {
                                string Libelle_Cours = Reader5.GetString("Libelle_Cours");
                                int couleur = Reader5.GetInt32("Couleur_Cours");
                                bool debut_seance = Reader5.GetBoolean("Debut_Seance");
                                //On ajoute mardi 
                                if (debut_seance == true)
                                {
                                    btn_vendredi_matin.Text = Libelle_Cours;
                                    btn_vendredi_matin.BackColor = System.Drawing.Color.FromArgb(couleur);
                                }
                                else
                                {
                                    btn_vendredi_aprem.Text = Libelle_Cours;
                                    btn_vendredi_aprem.BackColor = System.Drawing.Color.FromArgb(couleur);

                                }
                            }
                            Reader5.Close();

                        }
                        //------------------------------------------------------
                    }
                }
                    //Reader1.Read();
               /* while (Reader1.Read())
                {
                   
                    
                }*/              
               //a.Text = Libelle_Cours;
               //a.BackColor = System.Drawing.Color.FromArgb(couleur);
                connexion.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode d'affichage de l'emploi du temps " + ex.ToString());
            }
        }

        
    }
}
