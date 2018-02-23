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
    public partial class Form_choix_admin_eleve : Form
    {
       form_login form_login;
        public Form_choix_admin_eleve(form_login lg )
        {
            InitializeComponent();
            this.form_login = lg;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_eleve form_eleve = new Form_eleve(form_login);
            form_eleve.Show();
        }
        private void choix_admineleve_admin_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Accès à l'interface Administrateur");
        }

        private void Form_choix_admin_eleve_Load(object sender, EventArgs e)
        {

        }

        private void Form_choix_admin_eleve_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_login.Close();
        }

       
    }
}
