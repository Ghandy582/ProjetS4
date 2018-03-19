using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Pour utiliser le fichier de configuration
using System.Configuration;

namespace extranet_projet_s4
{
    public partial class Form_paramestres_taches : Form
    {
        Taches taches;
        static string nb_jours_notif_string;
        static string nb_jours_supression;

        string nb_modif;
        string nb_supp;
        

        public Form_paramestres_taches(Taches t)
        {
            InitializeComponent();

            this.taches = t;
        }

        private void parametre_tache_nbjour_notif_label_Click(object sender, EventArgs e)
        {

        }

        private void parametres_tache_nbJourNotif_10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form_paramestres_taches_Load(object sender, EventArgs e)
        {
            nb_jours_notif_string = ConfigurationManager.AppSettings["nb_jours_notif"];
            nb_jours_supression = ConfigurationManager.AppSettings["nb_jours_supression"];
            //Pour cocher les bons radiobuttons
            if (nb_jours_notif_string == "1")
            {
                this.parametres_tache_nbJourNotif_1.Checked=true;
                nb_modif = "1";
            }
            else if(nb_jours_notif_string == "3")
            {
                this.parametres_tache_nbJourNotif_3.Checked = true;
                nb_modif = "3";
            }
            else if (nb_jours_notif_string == "7")
            {
                this.parametres_tache_nbJourNotif_7.Checked = true;
                nb_modif = "7";
            }
            else if (nb_jours_notif_string == "10")
            {
                this.parametres_tache_nbJourNotif_10.Checked = true;
                nb_modif = "10";
            }

            if (nb_jours_supression == "3")
            {
                this.parametres_tache_nbJourSupp_3.Checked = true;
                nb_supp = "3";
            }
            else if (nb_jours_supression == "7")
            {
                this.parametres_tache_nbJourSupp_7.Checked = true;
                nb_supp = "7";
            }
            else if (nb_jours_supression == "15")
            {
                this.parametres_tache_nbJourSupp_15.Checked = true;
                nb_supp = "15";
            }
            else if (nb_jours_supression == "30")
            {
                this.parametres_tache_nbJourSupp_30.Checked = true;
                nb_supp = "30";
            }
        }

        private void Form_paramestres_taches_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // On vérifie ce qui est coché pour pas lancer la fonc de changement si 
            // rien n'a changé
            if (parametres_tache_nbJourNotif_1.Checked )
            { 
                nb_modif = "1";
            }
            else if (parametres_tache_nbJourNotif_3.Checked)
            {
                nb_modif = "3";
            }
            else if (parametres_tache_nbJourNotif_7.Checked )
            {
                nb_modif = "7";
            }
            else if (parametres_tache_nbJourNotif_10.Checked)
            {
                nb_modif = "10";
            }

            if (parametres_tache_nbJourSupp_3.Checked)
            {
                nb_supp = "3";
            }
            else if (parametres_tache_nbJourSupp_7.Checked)
            {
                nb_supp = "7";
            }
            else if (parametres_tache_nbJourSupp_15.Checked)
            {
                nb_supp = "15";
            }
            else if (parametres_tache_nbJourSupp_30.Checked)
            {
                nb_supp = "30";
            }

            if (!nb_modif.Equals(nb_jours_notif_string) || !nb_supp.Equals(nb_jours_supression))
            {
                taches.Changer_parametres_taches(int.Parse(nb_modif), int.Parse(nb_supp));
            }
            
            this.Close();
        }

        private void parametre_taches_annuler_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
