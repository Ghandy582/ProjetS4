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
    public partial class form_login : Form
    {
        login login = new login();
        public form_login()
        {
            InitializeComponent();   
        }

        private void form_login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void mdp_texte_Click(object sender, EventArgs e)
        {

        }

        private void login_connexion_btn_Click(object sender, EventArgs e)
        {
             login.connect(login_user_tb.Text, login_mdp_tb.Text, this);
            
        }
    }
}
