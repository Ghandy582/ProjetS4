using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Threading;
using System.IO;

namespace extranet_projet_s4
{
    public partial class Form_FTP : Form
    {
        public string Username;
        public string Filename;
        public string Fullname;
        public string Server;
        public string Password;
        public string path;
        public string localdest;
        public Form_FTP()
        {
            InitializeComponent();
            if (checkdown.Checked == true)
            {
                checkup.Enabled = false;
            }

        }
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

                if (checkdown.Checked == true)
                {
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}", Server, Filename)));

                    request.Credentials = new NetworkCredential(Username, Password);
                    request.Method = WebRequestMethods.Ftp.DownloadFile;  //Download Method


                    //Get some data form the source file like the zise and the TimeStamp. every data you request need to be a different request and response
                    FtpWebRequest request1 = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}", Server, Filename)));
                    request1.Credentials = new NetworkCredential(Username, Password);
                    request1.Method = WebRequestMethods.Ftp.GetFileSize;  //GetFileze Method
                    FtpWebResponse response = (FtpWebResponse)request1.GetResponse();
                    double total = response.ContentLength;
                    response.Close();

                    FtpWebRequest request2 = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}", Server, Filename)));
                    request2.Credentials = new NetworkCredential(Username, Password);
                    request2.Method = WebRequestMethods.Ftp.GetDateTimestamp; //GetTimestamp Method
                    FtpWebResponse response2 = (FtpWebResponse)request2.GetResponse();
                    DateTime modify = response2.LastModified;
                    response2.Close();


                    Stream ftpstream = request.GetResponse().GetResponseStream();
                    FileStream fs = new FileStream(localdest, FileMode.Create);
                    ftpstream.Close();
                    fs.Close();


                }
                else
                {

                    //Upload Method.
                    FtpWebRequest request = (FtpWebRequest)WebRequest.Create(new Uri(string.Format("{0}/{1}", Server, Filename)));
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.Credentials = new NetworkCredential(Username, Password);
                    Stream ftpstream = request.GetRequestStream();
                    FileStream fs = File.OpenRead(Fullname);
                    fs.Close();
                    ftpstream.Close();

                }
            }
            catch {
                MessageBox.Show("erreur");
                    
                   }

        }

        //Background
        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {

            if (checkdown.Checked == true)
            {

                progressBar1.Value = e.ProgressPercentage;
                progressBar1.Update();
            }

            if (checkup.Checked == true)
            {
                progressBar1.Value = e.ProgressPercentage;
                progressBar1.Update();
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (checkdown.Checked == true)
            {
                MessageBox.Show("Téléchargement réussi");
            }

            if (checkup.Checked == true)
            {
                MessageBox.Show("Partage réussi");
            }

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (checkup.Checked == true)
            {

                using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = true, ValidateNames = true, Filter = "All Files|*.*" })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        FileInfo fi = new FileInfo(ofd.FileName);
                        Username = "jacobgengoo";
                        Password = "jacobgengoo7";
                        Server = "ftp://10.101.0.2:21";
                        Filename = fi.Name;
                        Fullname = fi.FullName;
                    }
                }
            }


            if (checkdown.Checked == true)
            {
                Username = "jacobgengoo";
                Password = "jacobgengoo7";
                Server = "ftp://10.101.0.2:21";
                Filename = textBox1.Text;
                path = @"C:\Users\Christopher Gengoo\Desktop";
                localdest = path + @"" + Filename;
                Fullname = Server + @"/" + Filename;
            }

            //Start the Background and wait a little to start it.
            Thread.Sleep(1000);
            backgroundWorker1.RunWorkerAsync();  //the most important command to start the background worker
            Thread.Sleep(1000);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkdown.Checked == false)
            {
                checkup.Enabled = true;
                checkup.Checked = true;
                button1.Text = @"Partager";
                checkdown.Enabled = false;
            }

        }

        private void checkup_CheckedChanged(object sender, EventArgs e)
        {
            if (checkup.Checked == false)
            {
                checkdown.Enabled = true;
                checkdown.Checked = true;
                button1.Text = @"Télécharger";
                checkup.Enabled = false;
            }

        }
    }
}
