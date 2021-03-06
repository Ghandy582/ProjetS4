﻿using System;
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
    public partial class Form_gestion_tache : Form
    {
        form_login form_login;
        Form_eleve form_eleve;
        bool unProf;
        Form_professeur form_professeur;
        Utilisateur utilisateur;
        Taches taches;
        bool fermer_programme;
        public Form_gestion_tache(form_login lg, Utilisateur u,Taches t,Form_eleve e)
        {
            InitializeComponent();
            this.form_login = lg;
            this.utilisateur = u;
            this.taches = t;
            this.form_eleve = e;
            unProf = false;
            fermer_programme = true;


        }
        public Form_gestion_tache(form_login lg, Utilisateur u, Taches t, Form_professeur e)
        {
            InitializeComponent();
            this.form_login = lg;
            this.utilisateur = u;
            this.taches = t;
            this.form_professeur = e;
            unProf = true;
            fermer_programme = true;


        }

        private void Form_gestion_tache_Load(object sender, EventArgs e)
        {
            //remplir les datagrigview
            taches.Remplir_dataGridView_a_realiser(gestion_tache_tache_a_realiser_datagrid,utilisateur.Id_Membre);
            taches.Remplir_dataGridView_realisees(gestion_tache_tache_realisees_datagrid, utilisateur.Id_Membre);
        }

        private void Form_gestion_tache_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!fermer_programme)
            {
                fermer_programme = true;
            } 
            else 
            form_login.Close();
        }

        private void gestion_tache_accesrapide_btn_Click(object sender, EventArgs e)
        {
            Form_acces_rapide_taches form_acces_rapide_taches = new Form_acces_rapide_taches(utilisateur, taches,this);
            form_acces_rapide_taches.Show();
        }

        private void gestion_tache_nouvelletache_btn_Click(object sender, EventArgs e)
        {
            Form_nouvelle_tache form_nouvelle_tache = new Form_nouvelle_tache(utilisateur, taches,this);
            form_nouvelle_tache.Show();
        }

        private void gestion_tache_menu_acces_rapide_taches_Click(object sender, EventArgs e)
        {
            Form_acces_rapide_taches form_acces_rapide_taches = new Form_acces_rapide_taches(utilisateur, taches,this);
            form_acces_rapide_taches.Show();
        }

        private void gestion_tache_menu_nouvelle_tache_Click(object sender, EventArgs e)
        {

            Form_nouvelle_tache form_nouvelle_tache = new Form_nouvelle_tache(utilisateur, taches,this);
            form_nouvelle_tache.Show();
        }

        private void gestion_tache_menu_aaccueil_Click(object sender, EventArgs e)
        {
            if (unProf == false)
            {
                form_eleve.Show();
                fermer_programme = false;
                this.Close();
            }
            else if (unProf== true)
            {
                form_professeur.Show();
                fermer_programme = false;
                this.Close();
            }
            else
            {
                MessageBox.Show("pas de fentre d'acceuil");
            }
        }

        private void gestion_tache_menu_parametres_Click(object sender, EventArgs e)
        {
            Form_paramestres_taches form_parametres_taches = new Form_paramestres_taches(taches);
            form_parametres_taches.Show();
        }

        private void gestion_taches_menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public DataGridView Gestion_tache_tache_a_realiser_datagrid
        {
            get { return this.gestion_tache_tache_a_realiser_datagrid; }
        }
        public DataGridView Gestion_tache_tache_realisees_datagrid
        {
            get { return this.gestion_tache_tache_realisees_datagrid; }
        }
    }
}
