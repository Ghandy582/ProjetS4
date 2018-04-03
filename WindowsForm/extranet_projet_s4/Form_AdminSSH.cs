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
        }

        private void Form_AdminSSH_Load(object sender, EventArgs e)
        {
            n.shellStream.Close();
        }

        private void Commande_TB_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                var command = n.client.CreateCommand(Commande_TB.Text);
                var result = command.Execute();
                string recup = Shell_TB.Text;
                Shell_TB.Text = recup + result.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
