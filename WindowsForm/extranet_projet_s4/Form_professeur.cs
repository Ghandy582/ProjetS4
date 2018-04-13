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
using MySql.Data.MySqlClient;

namespace extranet_projet_s4
{
    public partial class Form_professeur : Form
    {
        form_login form_login;
        Utilisateur utilisateur;
        /*___ PROPRIETES DANS LE FIFHIER DE CONFIG______*/
        static string serveur = ConfigurationManager.AppSettings["serveur"];
        static string database = ConfigurationManager.AppSettings["database"];
        //On créé un objet tache pour toute la gestion des tâches
        Taches taches = new Taches();
        Emploi_temps emploi_temps = new Emploi_temps();
        //On créé un objet SqlLite pour la gestion du fichier sqlite
        Sqlite sqlite = new Sqlite();
        Form_gestion_tache form_gestion_tache;

        public Form_professeur(form_login lg, Utilisateur u)
        {
            InitializeComponent();
            this.form_login = lg;
            this.utilisateur = u;
            sqlite.Verification(utilisateur);
        }

        private void Form_professeur_Load(object sender, EventArgs e)
        {
            this.Text = utilisateur.Prenom_Membre + " " + utilisateur.Nom_Membre;
            //On vérifie les tâches pour notifier si besoin
            taches.Verification_approche_date_butoire(utilisateur.Id_Membre);
            //On supprime les taches réalisées trop vielles 
            taches.Suppression_tache_realisee(utilisateur.Id_Membre);
            // On remet l'affichage sur que des projets blanc
            emploi_temps.Remetre_zero_affichage_emploi_temps("", form_prof_lundi_matin_btn, form_prof_lundi_aprem_btn, form_prof_mardi_matin_btn, form_prof_mardi_aprem_btn, form_prof_mercredi_matin_btn, form_prof_mercredi_aprem_btn, form_prof_jeudi_matin_btn, form_prof_jeudi_aprem_btn, form_prof_vendredi_matin_btn, form_prof_vendredi_aprem_btn);
            //On affiche les dates de la semaine
            emploi_temps.Afficher_dates_semaine(DateTime.Today, form_prof_date_lundi, form_prof_date_mardi, form_prof_date_mercredi, form_prof_date_jeudi, form_prof_date_vendredi);
            //On remplie l'emploi du temps de la semaine
            emploi_temps.Affiche_emploi_temps_profs(DateTime.Today, utilisateur.Id_Membre, form_prof_lundi_matin_btn, form_prof_lundi_aprem_btn, form_prof_mardi_matin_btn, form_prof_mardi_aprem_btn, form_prof_mercredi_matin_btn, form_prof_mercredi_aprem_btn, form_prof_jeudi_matin_btn, form_prof_jeudi_aprem_btn, form_prof_vendredi_matin_btn, form_prof_vendredi_aprem_btn);
        }

        private void Form_professeur_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_login.Close();
        }

        private void gestionDesTâchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_gestion_tache form_gestion_tache = new Form_gestion_tache(form_login, utilisateur, taches, this);
            form_gestion_tache.Show();
        }

        private void accèsRapideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_acces_rapide_taches form_acces_rapide_taches = new Form_acces_rapide_taches(utilisateur, taches, form_gestion_tache);
            form_acces_rapide_taches.Show();
        }

        private void nouvelleTâcheToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_nouvelle_tache form_nouvelle_tache = new Form_nouvelle_tache(utilisateur, taches, form_gestion_tache);
            form_nouvelle_tache.Show();
        }

        private void paramètresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_paramestres_taches form_parametres_taches = new Form_paramestres_taches(taches);
            form_parametres_taches.Show();
        }

        private void form_eleve_semaine_suivante_btn_Click(object sender, EventArgs e)
        {
            DateTime a = emploi_temps.Premier_jour_semaine;
            a = a.AddDays(7);
            // On remet l'affichage sur que des projets blanc
            emploi_temps.Remetre_zero_affichage_emploi_temps("", form_prof_lundi_matin_btn, form_prof_lundi_aprem_btn, form_prof_mardi_matin_btn, form_prof_mardi_aprem_btn, form_prof_mercredi_matin_btn, form_prof_mercredi_aprem_btn, form_prof_jeudi_matin_btn, form_prof_jeudi_aprem_btn, form_prof_vendredi_matin_btn, form_prof_vendredi_aprem_btn);
            // On affiche la semaine suivante
            emploi_temps.Affiche_emploi_temps_profs(a, utilisateur.Id_Membre, form_prof_lundi_matin_btn, form_prof_lundi_aprem_btn, form_prof_mardi_matin_btn, form_prof_mardi_aprem_btn, form_prof_mercredi_matin_btn, form_prof_mercredi_aprem_btn, form_prof_jeudi_matin_btn, form_prof_jeudi_aprem_btn, form_prof_vendredi_matin_btn, form_prof_vendredi_aprem_btn);
            //On affiche les dates de la semaine
            emploi_temps.Afficher_dates_semaine(a, form_prof_date_lundi, form_prof_date_mardi, form_prof_date_mercredi, form_prof_date_jeudi, form_prof_date_vendredi);

        }

        private void form_eleve_semaine_precedantee_btn_Click(object sender, EventArgs e)
        {
            DateTime a = emploi_temps.Premier_jour_semaine;
            a = a.AddDays(-7);
            // On remet l'affichage sur que des projets blanc
            emploi_temps.Remetre_zero_affichage_emploi_temps("", form_prof_lundi_matin_btn, form_prof_lundi_aprem_btn, form_prof_mardi_matin_btn, form_prof_mardi_aprem_btn, form_prof_mercredi_matin_btn, form_prof_mercredi_aprem_btn, form_prof_jeudi_matin_btn, form_prof_jeudi_aprem_btn, form_prof_vendredi_matin_btn, form_prof_vendredi_aprem_btn);
            // On affiche la semaine suivante
            emploi_temps.Affiche_emploi_temps_profs(a, utilisateur.Id_Membre, form_prof_lundi_matin_btn, form_prof_lundi_aprem_btn, form_prof_mardi_matin_btn, form_prof_mardi_aprem_btn, form_prof_mercredi_matin_btn, form_prof_mercredi_aprem_btn, form_prof_jeudi_matin_btn, form_prof_jeudi_aprem_btn, form_prof_vendredi_matin_btn, form_prof_vendredi_aprem_btn);
            //On affiche les dates de la semaine
            emploi_temps.Afficher_dates_semaine(a, form_prof_date_lundi, form_prof_date_mardi, form_prof_date_mercredi, form_prof_date_jeudi, form_prof_date_vendredi);
        }

        private void form_prof_lundi_matin_btn_Click(object sender, EventArgs e)
        {
            if (emploi_temps.get_id_seance(0) != -1)
            {
                Form_informations_seance_prod form_informations_seance_prof = new Form_informations_seance_prod(utilisateur.Id_Membre, form_prof_date_lundi.Text, emploi_temps, 0, form_prof_lundi_matin_btn);
                form_informations_seance_prof.Show();
            }
            
        }

        private void form_prof_lundi_aprem_btn_Click(object sender, EventArgs e)
        {
            if (emploi_temps.get_id_seance(1) != -1)
            {
                Form_informations_seance_prod form_informations_seance_prof = new Form_informations_seance_prod(utilisateur.Id_Membre, form_prof_date_lundi.Text, emploi_temps, 1, form_prof_lundi_aprem_btn);
                form_informations_seance_prof.Show();
            }
              
        }

        private void form_prof_mardi_matin_btn_Click(object sender, EventArgs e)
        {
            if (emploi_temps.get_id_seance(2) != -1)
            {
                Form_informations_seance_prod form_informations_seance_prof = new Form_informations_seance_prod(utilisateur.Id_Membre, form_prof_date_mardi.Text, emploi_temps, 2, form_prof_mardi_matin_btn);
                form_informations_seance_prof.Show();
            }
            
        }

        private void form_prof_mardi_aprem_btn_Click(object sender, EventArgs e)
        {
            if (emploi_temps.get_id_seance(3) != -1)
            {
                Form_informations_seance_prod form_informations_seance_prof = new Form_informations_seance_prod(utilisateur.Id_Membre, form_prof_date_mardi.Text, emploi_temps, 3, form_prof_mardi_aprem_btn);
                form_informations_seance_prof.Show();
            }
            
        }

        private void form_prof_mercredi_matin_btn_Click(object sender, EventArgs e)
        {
            if (emploi_temps.get_id_seance(4) != -1) {
                Form_informations_seance_prod form_informations_seance_prof = new Form_informations_seance_prod(utilisateur.Id_Membre, form_prof_date_mercredi.Text, emploi_temps, 4, form_prof_mercredi_matin_btn);
                form_informations_seance_prof.Show();
            }
            
        }

        private void form_prof_mercredi_aprem_btn_Click(object sender, EventArgs e)
        {
            if (emploi_temps.get_id_seance(5) != -1) {
                Form_informations_seance_prod form_informations_seance_prof = new Form_informations_seance_prod(utilisateur.Id_Membre, form_prof_date_mercredi.Text, emploi_temps, 5, form_prof_mercredi_aprem_btn);
                form_informations_seance_prof.Show();
            }
            
        }

        private void form_prof_jeudi_matin_btn_Click(object sender, EventArgs e)
        {
            if (emploi_temps.get_id_seance(6) != -1) {
                Form_informations_seance_prod form_informations_seance_prof = new Form_informations_seance_prod(utilisateur.Id_Membre, form_prof_date_jeudi.Text, emploi_temps, 6, form_prof_jeudi_matin_btn);
                form_informations_seance_prof.Show();
            }
            
        }

        private void form_prof_jeudi_aprem_btn_Click(object sender, EventArgs e)
        {
            if (emploi_temps.get_id_seance(7) != -1) {
                Form_informations_seance_prod form_informations_seance_prof = new Form_informations_seance_prod(utilisateur.Id_Membre, form_prof_date_jeudi.Text, emploi_temps, 7, form_prof_jeudi_aprem_btn);
                form_informations_seance_prof.Show();
            }
            
        }

        private void form_prof_vendredi_matin_btn_Click(object sender, EventArgs e)
        {
            if (emploi_temps.get_id_seance(8) != -1) {
                Form_informations_seance_prod form_informations_seance_prof = new Form_informations_seance_prod(utilisateur.Id_Membre, form_prof_date_vendredi.Text, emploi_temps, 8, form_prof_vendredi_matin_btn);
                form_informations_seance_prof.Show();
            }
            
        }

        private void form_prof_vendredi_aprem_btn_Click(object sender, EventArgs e)
        {
            if (emploi_temps.get_id_seance(9) != -1)
            {
                Form_informations_seance_prod form_informations_seance_prof = new Form_informations_seance_prod(utilisateur.Id_Membre, form_prof_date_vendredi.Text, emploi_temps, 9, form_prof_vendredi_aprem_btn);
                form_informations_seance_prof.Show();
            }
            
        }
    }
}
