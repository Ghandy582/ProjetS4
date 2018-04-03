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
    public partial class Form_AdminSSH : Form
    {
        SSH n = new SSH();
        public Form_AdminSSH()
        {
            InitializeComponent();
            n.Connection();
            var command = n.client.CreateCommand("uptime");
            var result = command.Execute();
            Shell_TB.Text = result.ToString();
           
        }
        void commande()
        {
            try
            {

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Form_AdminSSH_Load(object sender, EventArgs e)
        {
            n.shellStream.Close();
        }
    }
}
