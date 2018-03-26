using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;

namespace extranet_projet_s4
{
    public partial class Form_AdminSSH : Form
    {
        public Form_AdminSSH()
        {
            InitializeComponent();
            Connection();
        }
        void Connection()
        {
            SshClient client = new SshClient("10.101.0.2", "JacobGengoo", "jacobgengoo7");
            
            try
            {
                client.Connect();
                MessageBox.Show("Connecté à :'" + client.ConnectionInfo.Host + "'");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection impossible à :'" + client.ConnectionInfo.Host + "' Erreur '"+ ex.ToString() +"'");
            }
            //http://www.hankerspace.com/fr/acces-ssh-via-c/
        }
    }
}
