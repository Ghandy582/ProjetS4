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
    }
}