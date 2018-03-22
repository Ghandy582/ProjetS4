﻿using System;
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
        MySqlConnection BDD = new MySqlConnection("SERVER=" + serveur + ";" + "DATABASE=" + database + ";" + "UID=root;" + "PASSWORD=;");
        //On créé un objet tache pour toute la gestion des tâches
        Taches taches = new Taches();
        //On créé un objet SqlLite pour la gestion du fichier sqlite
        Sqlite sqlite = new Sqlite();
        Form_gestion_tache form_gestion_tache;
        public Form_eleve(form_login lg, Utilisateur u)
        {
            InitializeComponent();
            BDD.Open();
            this.form_login = lg;
            this.utilisateur = u;
            sqlite.Verification(utilisateur);
            emploie();
        }

        private void Form_eleve_Load(object sender, EventArgs e)
        {
            this.Text = utilisateur.Prenom_Membre + " " + utilisateur.Nom_Membre;
            //On vérifie les tâches pour notifier si besoin
            taches.Verification_approche_date_butoire(utilisateur.Id_Membre);
            //On supprime les taches réalisées trop vielles 
            taches.Suppression_tache_realisee(utilisateur.Id_Membre);
        }

        private void Form_eleve_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_login.Close();
        }
        void emploie()
        {
            try
            {
                 MySqlCommand cmd1 = new MySqlCommand("SELECT Libelle_Cours FROM groupe_seance JOIN seance ON groupe_seance.ID_Seance = seance.ID_Seance JOIN groupe ON groupe_seance.ID_Groupe = groupe.ID_Groupe JOIN cours ON seance.ID_Cours = cours.ID_Cours WHERE groupe_seance.ID_groupe = 2 AND seance.Date_Seance = '"+ DateTime.Now.ToShortDateString()+"'", BDD);
                 MySqlDataReader Reader1 = cmd1.ExecuteReader();
                 Reader1.Read();
                 string Libelle_Cours= Reader1.GetString("Libelle_Cours");
                 button7.Text = Libelle_Cours;
                DateTime test = DateTime.Now;
                button1.Text = "'" + test.DayOfWeek + "'";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
