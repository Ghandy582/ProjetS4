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
        public Form_informations_seance_prod(String date, Emploi_temps t, int p, Button jour)
        {
            InitializeComponent();
            emploi_temps = t;
            emploi_temps.Remplir_fenetre_infos_prof(date, informations_seances_date_label, form_informations_btn, jour, p, infos_promo_label, informations_note_textbox,infos_note_persone_texbox);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form_informations_seance_prod_Load(object sender, EventArgs e)
        {

        }
    }
}
