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
    public partial class Form_choix_admin_prof : Form
    {
        form_login form_login;
        Utilisateur utilisateur;

        public Form_choix_admin_prof(form_login lg, Utilisateur u)
        {
            InitializeComponent();
            this.form_login = lg;
            this.utilisateur = u;
        }

        private void choix_adminprof_admin_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_AdminMain form_AdminMain = new Form_AdminMain(form_login, utilisateur);
            form_AdminMain.Show();
        }

        private void choix_adminprof_prof_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_professeur form_professeur = new Form_professeur(form_login, utilisateur);
            form_professeur.Show();
        }

        private void Form_choix_admin_prof_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_login.Close();
        }
    }
}
