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
    public partial class Form_informations_seance_prod : Form
    {
        Emploi_temps emploi_temps;
        int id_utilidateur;
        int debut_journee;
        int id_seance;
        public Form_informations_seance_prod(int id,String date, Emploi_temps t, int p, Button jour)
        {
            InitializeComponent();
            emploi_temps = t;
            id_seance=emploi_temps.Remplir_fenetre_infos_prof(date, informations_seances_date_label, form_informations_btn, jour, p, infos_promo_label, informations_note_textbox,infos_note_persone_texbox);
            id_utilidateur = id;
            //savoir si séance matin ou aprem pour les updates des notes de séances
            if(p==0 || p == 2 || p == 4 || p == 6 || p == 8)
            {
                debut_journee = 1;
            }
            else
            {
                debut_journee = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_informations_seance_prod_Load(object sender, EventArgs e)
        {

        }

        private void infos_prof_modifier_notes_seance_btn_Click(object sender, EventArgs e)
        {
            Form_modifier_notes_cours form_modifier_note_seance = new Form_modifier_notes_cours(id_utilidateur, emploi_temps, informations_note_textbox, informations_seances_date_label.Text,debut_journee,false,id_seance);
            form_modifier_note_seance.Show();
        }

        private void infos_prof_modifier_note_perso_btn_Click(object sender, EventArgs e)
        {
            Form_modifier_notes_cours form_modifier_note_seance = new Form_modifier_notes_cours(id_utilidateur, emploi_temps, infos_note_persone_texbox, informations_seances_date_label.Text, debut_journee, true,id_seance);
            form_modifier_note_seance.Show();
        }

        private void Form_informations_seance_prod_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
    }
}
