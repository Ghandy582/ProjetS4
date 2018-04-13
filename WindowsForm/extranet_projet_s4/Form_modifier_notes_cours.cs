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
    public partial class Form_modifier_notes_cours : Form
    {
        Emploi_temps emploi_temps;
        TextBox textebox_note;
        int debut_journee;
        int id_utilisateur;
        string date_seance;
        //une note publique ou personnelle
        bool note_perso;
        int id_seance;
        public Form_modifier_notes_cours(int id,Emploi_temps t,TextBox texte, string date,int debut_seance, bool note_perso_,int id_seance_)
        {
            InitializeComponent();
            emploi_temps = t;
            textebox_note = texte;
            modifications_textbox.Text = textebox_note.Text;
            //pour le update des notes
            debut_journee = debut_seance;
            id_utilisateur = id;
            date_seance = date;
            note_perso = note_perso_;
            id_seance = id_seance_;
        }

        private void Form_modifier_notes_cours_Load(object sender, EventArgs e)
        {
            
        }

        private void modifications_valider_btn_Click(object sender, EventArgs e)
        {
            textebox_note.Text = modifications_textbox.Text;
            emploi_temps.Modification_note_seance(date_seance, textebox_note.Text, note_perso, id_seance);
            this.Close();
        }
    }
}
