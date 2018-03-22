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
    public partial class Form_nouvelle_tache : Form
    {
        Taches taches;
        Utilisateur utilisateur;
        DateTime fin_tache;
        DateTime today;
        Form_gestion_tache form_gestion_tache;

        public Form_nouvelle_tache(Utilisateur u,Taches t,Form_gestion_tache g)
        {
            InitializeComponent();
            taches = t;
            utilisateur = u;
            today = DateTime.Now;
            form_gestion_tache = g;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            // Si la case avec date cochée alors on voit le calendrier
            if (nouvelle_tache_avecDate_radiobtn.Checked)
                nouvelle_tache_calendrier.Visible = true;
            else
                nouvelle_tache_calendrier.Visible = false;
        }

        private void nouvelle_tache_label_Click(object sender, EventArgs e)
        {

        }

        private void nouvelle_tache_sansDate_radiobtn_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void nouvelle_tache_ajouter_btn_Click(object sender, EventArgs e)
        {
            char carac = '"';
            char carac2 = '\'';
            char carac_remplacement = ' ';
            // si la case n'est pas vide 
            if (nouvelle_tache_textbox.Text != "")
            {
                //On remplave les caractères indésirables pas des espaces
                nouvelle_tache_textbox.Text = nouvelle_tache_textbox.Text.Replace(carac, carac_remplacement).Replace(carac2, carac_remplacement);

                // Si il y a une date
                if (nouvelle_tache_avecDate_radiobtn.Checked)
                {
                    fin_tache = nouvelle_tache_calendrier.SelectionStart;
                    int result = DateTime.Compare(today, fin_tache);
                    //si la date n'est pas bonne
                    if (result > 0)
                    {
                        MessageBox.Show("Veuillez choisir une date ultérieur à la date d'aujourd'hui");
                    }
                    else
                    {
                        taches.Ajout_Tache_Avec_Date(utilisateur.Id_Membre, nouvelle_tache_textbox.Text, fin_tache.ToShortDateString(), today.ToShortDateString());                       
                        this.Close();
                        if (form_gestion_tache != null && form_gestion_tache.Visible==true)
                        {
                            //remplir les datagrigview
                            taches.Remplir_dataGridView_a_realiser(form_gestion_tache.Gestion_tache_tache_a_realiser_datagrid, utilisateur.Id_Membre);
                            
                        }
                    }
                }
                else if (nouvelle_tache_sansDate_radiobtn.Checked)
                {
                    taches.Ajout_Tache_Sans_Date(utilisateur.Id_Membre, nouvelle_tache_textbox.Text, today.ToShortDateString());
                    this.Close();
                    if (form_gestion_tache!=null && form_gestion_tache.Visible == true)
                    {
                        //remplir les datagrigview
                        taches.Remplir_dataGridView_a_realiser(form_gestion_tache.Gestion_tache_tache_a_realiser_datagrid, utilisateur.Id_Membre);
                        
                    }
                }
                else
                {
                    MessageBox.Show("veuillez choisir si cette tâche a une date butoire ou non.");
                }
            }
            else
            {
                MessageBox.Show("Veuillez entrer un intitulé.");
            }

        }

        private void Form_nouvelle_tache_Load(object sender, EventArgs e)
        {

        }
    }
}
