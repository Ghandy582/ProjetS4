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
    public partial class Form_eleve : Form
    {
        form_login form_login;
        public Form_eleve(form_login lg)
        {
            InitializeComponent();
            this.form_login = lg;
        }

        private void Form_eleve_Load(object sender, EventArgs e)
        {

        }

        private void Form_eleve_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_login.Close();
        }
    }
}
