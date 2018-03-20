using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace extranet_projet_s4
{
    public partial class Form_eleve : Form
    {
        form_login form_login;
        Utilisateur utilisateur;
        //On créé un objet tache pour toute la gestion des tâches
        Taches taches = new Taches();
        //On créé un objet SqlLite pour la gestion du fichier sqlite
        Sqlite sqlite = new Sqlite();
        Form_gestion_tache form_gestion_tache;
        public Form_eleve(form_login lg, Utilisateur u)
        {
            InitializeComponent();
            this.form_login = lg;
            this.utilisateur = u;
            sqlite.Verification(utilisateur);        }

        private void Form_eleve_Load(object sender, EventArgs e)
        {
            this.Text = utilisateur.Prenom_Membre + " " + utilisateur.Nom_Membre;
            //On vérifie les tâches pour notifier si besoin
            taches.Verification_approche_date_butoire(utilisateur.Id_Membre);
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
    }
}
