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
                MySqlCommand cmd1 = new MySqlCommand("SELECT * FROM emploie", connexion);
                MySqlDataReader Reader1 = cmd1.ExecuteReader();
                Reader1.Read();
                string Libelle_Cours = Reader1.GetString("Libelle_Cours");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur pendant l'execution de la méthode d'affichage de l'emploi du temps " + ex.ToString());
            }
        }
    }
}
