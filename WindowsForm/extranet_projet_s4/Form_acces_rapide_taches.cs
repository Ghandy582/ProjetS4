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
    public partial class Form_acces_rapide_taches : Form
    {
        Utilisateur utilisateur;
        Taches taches;
        Form_gestion_tache form_gestion_tache;
        public Form_acces_rapide_taches(Utilisateur u, Taches t, Form_gestion_tache g)
        {
            InitializeComponent();
            utilisateur = u;
            taches = t;
            taches.affiche_taches_liste_acces_rapide(this.acces_rapide_tache_liste,utilisateur.Id_Membre);
            form_gestion_tache = g;
        }

        private void acces_rapide_tache_ajouter_tache_Click(object sender, EventArgs e)
        {
            Form_nouvelle_tache form_nouvelle_tache = new Form_nouvelle_tache(utilisateur, taches, form_gestion_tache);
            form_nouvelle_tache.Show();
        }

        private void Form_acces_rapide_taches_Load(object sender, EventArgs e)
        {
            
        }      
        

        private void acces_rapide_tache_liste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void acces_rapide_tache_tache_termine_btn_Click(object sender, EventArgs e)
        {

            taches.Transfert_tache_realisee(acces_rapide_tache_liste, utilisateur.Id_Membre);
            //On réactualise la liste
            acces_rapide_tache_liste.Items.Clear();
            taches.affiche_taches_liste_acces_rapide(this.acces_rapide_tache_liste, utilisateur.Id_Membre);
            //si gestion tache ouvert on le rafraichie 
            if (form_gestion_tache != null && form_gestion_tache.Visible == true)
            {
                //remplir les datagrigview
                taches.Remplir_dataGridView_a_realiser(form_gestion_tache.Gestion_tache_tache_a_realiser_datagrid, utilisateur.Id_Membre);
                taches.Remplir_dataGridView_realisees(form_gestion_tache.Gestion_tache_tache_realisees_datagrid , utilisateur.Id_Membre);

            }
        }

        private void acces_rapide_tache_rafraichir_Click(object sender, EventArgs e)
        {
            acces_rapide_tache_liste.Items.Clear();
            taches.affiche_taches_liste_acces_rapide(this.acces_rapide_tache_liste, utilisateur.Id_Membre);
        }
    }
}
