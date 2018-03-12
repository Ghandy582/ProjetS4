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
        public Form_acces_rapide_taches(Utilisateur u, Taches t)
        {
            InitializeComponent();
            utilisateur = u;
            taches = t;
            taches.affiche_taches_liste_acces_rapide(this.acces_rapide_tache_liste);
        }

        private void acces_rapide_tache_ajouter_tache_Click(object sender, EventArgs e)
        {
            Form_nouvelle_tache form_nouvelle_tache = new Form_nouvelle_tache(utilisateur, taches);
            form_nouvelle_tache.Show();
        }

        private void Form_acces_rapide_taches_Load(object sender, EventArgs e)
        {
            /*Timer timer = new Timer();
            timer.Interval = (1 * 1000); // 1 secs
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();*/
        }      
        /*
        private void timer_Tick(object sender, EventArgs e)
        {
            acces_rapide_tache_liste.Items.Clear();
            taches.affiche_taches_liste_acces_rapide(this.acces_rapide_tache_liste);
        }*/

        private void acces_rapide_tache_liste_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void acces_rapide_tache_tache_termine_btn_Click(object sender, EventArgs e)
        {

        }

        private void acces_rapide_tache_rafraichir_Click(object sender, EventArgs e)
        {
            acces_rapide_tache_liste.Items.Clear();
            taches.affiche_taches_liste_acces_rapide(this.acces_rapide_tache_liste);
        }
    }
}
