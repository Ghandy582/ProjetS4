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
    class emploi_temps
    {
        /*---------------------------- PROPRIETES ---------------------------*/
       
            /*___ PROPRIETES DANS LE FIFHIER DE CONFIG______*/
        static string serveur = ConfigurationManager.AppSettings["serveur"];
        static string database = ConfigurationManager.AppSettings["database"];
        /*_____________________________________________*/
        // On créé la chaine de connextion avec les valeurs dans le fichier de conf
        MySqlConnection connexion = new MySqlConnection("SERVER=" + serveur + ";" + "DATABASE=" + database + ";" + "UID=root;" + "PASSWORD=;");
        
        
        /*---------------------------------- METHODES --------------------------------*/
        void Affiche_emploi_temps(Form_eleve form_eleve)
        {
            try
            {
                MySqlCommand cmd1 = new MySqlCommand("SELECT Libelle_Cours FROM groupe_seance JOIN seance ON groupe_seance.ID_Seance = seance.ID_Seance JOIN groupe ON groupe_seance.ID_Groupe = groupe.ID_Groupe JOIN cours ON seance.ID_Cours = cours.ID_Cours WHERE groupe_seance.ID_groupe = 2 AND seance.Date_Seance = '" + DateTime.Now.ToShortDateString() + "'", connexion);
                MySqlDataReader Reader1 = cmd1.ExecuteReader();
                Reader1.Read();
                string Libelle_Cours = Reader1.GetString("Libelle_Cours");
                //button7.Text = Libelle_Cours;
                DateTime test = DateTime.Now;
                //button1.Text = "'" + test.DayOfWeek + "'";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode d'affichage de l'emploi du temps " + ex.ToString());
            }
        }
    }
}
