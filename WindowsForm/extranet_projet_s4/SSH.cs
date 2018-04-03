using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Renci.SshNet;
using Renci.SshNet.Common;
using System.Windows.Forms;


namespace extranet_projet_s4
{
    
    class SSH
    {

        public SshClient client = new SshClient("10.101.0.2", "jacobgengoo", "jacobgengoo7");
        public ShellStream shellStream { get; set; }
        public void Connection()
        {
           
            try
            {
                client.Connect();
                MessageBox.Show("Connecté à :'" + client.ConnectionInfo.Host + "'");
                shellStream = client.CreateShellStream("dumb", 80, 24, 800, 600, 1024);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection impossible à :'" + client.ConnectionInfo.Host + "' Erreur '" + ex.ToString() + "'");
            }
            //http://www.hankerspace.com/fr/acces-ssh-via-c/
        }
        public void test()
        {
            client.CreateCommand("uptime");
            client.RunCommand("uptime");
        }

    }
}
