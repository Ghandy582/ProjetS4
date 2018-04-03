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
    public partial class Form_eleve : Form
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
        public Form_eleve(form_login lg, Utilisateur u)
        {
            InitializeComponent();
            this.form_login = lg;
            this.utilisateur = u;
            sqlite.Verification(utilisateur);
            

        }

        private void Form_eleve_Load(object sender, EventArgs e)
        {
            this.Text = utilisateur.Prenom_Membre + " " + utilisateur.Nom_Membre;
            //On vérifie les tâches pour notifier si besoin
            taches.Verification_approche_date_butoire(utilisateur.Id_Membre);
            //On supprime les taches réalisées trop vielles 
            taches.Suppression_tache_realisee(utilisateur.Id_Membre);
            //On remplie l'emploi du temps de la semaine
            emploi_temps.Affiche_emploi_temps( DateTime.Today, utilisateur.Id_groupe_membre,form_eleve_lundi_matin_btn,form_eleve_lundi_aprem_btn,form_eleve_mardi_matin_btn,form_eleve_mardi_aprem_btn,form_eleve_mercredi_matin_btn,form_eleve_mercredi_aprem_btn,form_eleve_jeudi_matin_btn,form_eleve_jeudi_aprem_btn,form_eleve_vendredi_matin_btn,form_eleve_vendredi_aprem_btn);
            //On affiche les dates de la semaine
            emploi_temps.Afficher_dates_semaine(DateTime.Today,form_eleve_date_lundi, form_eleve_date_mardi, form_eleve_date_mercredi, form_eleve_date_jeudi, form_eleve_date_vendredi);
            //On affiche les dernières notes
            emploi_temps.Afficher_dernieres_notes(form_eleve_dernieres_notes, utilisateur.Id_Membre);
        }

        private void Form_eleve_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_login.Close();
        }
        

        private void eleve_menu_acces_rapide_taches_Click(object sender, EventArgs e)
        {
            Form_acces_rapide_taches form_acces_rapide_taches = new Form_acces_rapide_taches(utilisateur, taches, form_gestion_tache);
            form_acces_rapide_taches.Show();
        }

        private void eleve_menu_nouvelle_tache_Click(object sender, EventArgs e)
        {

            Form_nouvelle_tache form_nouvelle_tache = new Form_nouvelle_tache(utilisateur, taches,form_gestion_tache);
            form_nouvelle_tache.Show();
        }

        private void eleve_menu_gestion_taches_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form_gestion_tache form_gestion_tache = new Form_gestion_tache(form_login, utilisateur, taches,this);
            form_gestion_tache.Show();
        }

        private void eleve_menu_taches_Click(object sender, EventArgs e)
        {

        }

        private void eleve_menu_tache_parametres_Click(object sender, EventArgs e)
        {
            Form_paramestres_taches form_parametres_taches = new Form_paramestres_taches(taches);
            form_parametres_taches.Show();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void form_eleve_date_mercredi_Click(object sender, EventArgs e)
        {

        }

        private void form_eleve_date_jeudi_Click(object sender, EventArgs e)
        {

        }

        private void form_eleve_semaine_suivante_btn_Click(object sender, EventArgs e)
        {
            DateTime a = emploi_temps.Premier_jour_semaine;
            a = a.AddDays(7);
            // On remet l'affichage sur que des projets blanc
            emploi_temps.Remetre_zero_affichage_emploi_temps(form_eleve_lundi_matin_btn, form_eleve_lundi_aprem_btn, form_eleve_mardi_matin_btn, form_eleve_mardi_aprem_btn, form_eleve_mercredi_matin_btn, form_eleve_mercredi_aprem_btn, form_eleve_jeudi_matin_btn, form_eleve_jeudi_aprem_btn, form_eleve_vendredi_matin_btn, form_eleve_vendredi_aprem_btn);
            // On affiche la semaine suivante
            emploi_temps.Affiche_emploi_temps(a, utilisateur.Id_groupe_membre, form_eleve_lundi_matin_btn, form_eleve_lundi_aprem_btn, form_eleve_mardi_matin_btn, form_eleve_mardi_aprem_btn, form_eleve_mercredi_matin_btn, form_eleve_mercredi_aprem_btn, form_eleve_jeudi_matin_btn, form_eleve_jeudi_aprem_btn, form_eleve_vendredi_matin_btn, form_eleve_vendredi_aprem_btn);
            //On affiche les dates de la semaine
            emploi_temps.Afficher_dates_semaine(a, form_eleve_date_lundi, form_eleve_date_mardi, form_eleve_date_mercredi, form_eleve_date_jeudi, form_eleve_date_vendredi);
        }

        private void form_eleve_semaine_precedantee_btn_Click(object sender, EventArgs e)
        {
            DateTime a = emploi_temps.Premier_jour_semaine;
            a = a.AddDays(-7);
            // On remet l'affichage sur que des projets blanc
            emploi_temps.Remetre_zero_affichage_emploi_temps(form_eleve_lundi_matin_btn, form_eleve_lundi_aprem_btn, form_eleve_mardi_matin_btn, form_eleve_mardi_aprem_btn, form_eleve_mercredi_matin_btn, form_eleve_mercredi_aprem_btn, form_eleve_jeudi_matin_btn, form_eleve_jeudi_aprem_btn, form_eleve_vendredi_matin_btn, form_eleve_vendredi_aprem_btn);
            // On affiche la semaine suivante
            emploi_temps.Affiche_emploi_temps(a, utilisateur.Id_groupe_membre, form_eleve_lundi_matin_btn, form_eleve_lundi_aprem_btn, form_eleve_mardi_matin_btn, form_eleve_mardi_aprem_btn, form_eleve_mercredi_matin_btn, form_eleve_mercredi_aprem_btn, form_eleve_jeudi_matin_btn, form_eleve_jeudi_aprem_btn, form_eleve_vendredi_matin_btn, form_eleve_vendredi_aprem_btn);
            //On affiche les dates de la semaine
            emploi_temps.Afficher_dates_semaine(a, form_eleve_date_lundi, form_eleve_date_mardi, form_eleve_date_mercredi, form_eleve_date_jeudi, form_eleve_date_vendredi);
        }
    }
}
