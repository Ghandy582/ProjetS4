using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Security.Cryptography;
using Microsoft.VisualBasic;

namespace extranet_projet_s4
{
    public partial class GestionUser : Form
    {
        private MySqlDataAdapter mySqlDataAdapter;
        public MySqlConnection BDD;

        private int rowIndex = 0;
        public GestionUser(MySqlConnection SQL)
        {
            InitializeComponent();
            this.BDD = SQL;
            UpdateGrid(BDD);
            Role_CB.Items.Insert(0,"Eleve");
            Role_CB.Items.Insert(1,"Professeur");
            Role_CB.Items.Insert(2,"Administrateur");
            Role_CB.Items.Insert(3,"Super Eleve");
            Role_CB.Items.Insert(4,"Super Professeur");
            //remplir le combobox avec les données de la BDD
            ComboFill(BDD);
        }
        private void UpdateGrid(MySqlConnection SQL)
        {
            //recup de donnée
            mySqlDataAdapter = new MySqlDataAdapter("select * from membre", BDD);
            //le tableau 
            DataSet DS = new DataSet();
            //remplissage du tableau aves les données recuperées
            mySqlDataAdapter.Fill(DS);
            Gestion_GridView.DataSource = DS.Tables[0];
        }
        private void ComboFill(MySqlConnection SQL)
        {
         
            string query = "SELECT * FROM groupe";
            MySqlCommand cmd = new MySqlCommand(query, SQL);

            using (MySqlDataReader Reader = cmd.ExecuteReader())
            {
                while (Reader.Read())
                { 
                    Groupe_CB.Items.Add(Reader.GetString("ID_Groupe"));
                }
            }
        }

        //FONCTION POUR MODIFIER DIRECTEMENT DANS LE TABLEAU
        private void Liste_DataGrid_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)Gestion_GridView.DataSource).GetChanges();

            if (changes != null)
            {
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(mySqlDataAdapter);
                mySqlDataAdapter.UpdateCommand = mcb.GetUpdateCommand();
                mySqlDataAdapter.Update(changes);
                ((DataTable)Gestion_GridView.DataSource).AcceptChanges();
            }
        }
        /*clic droit sur le grid*/
        private void GestionCellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.Gestion_GridView.Rows[e.RowIndex].Selected = true;
                this.rowIndex = e.RowIndex;
                this.Gestion_GridView.CurrentCell = this.Gestion_GridView.Rows[e.RowIndex].Cells[1];
                this.contextMenuStrip1.Show(this.Gestion_GridView, e.Location);
                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void ClicDroitSupprimer_Click(object sender, EventArgs e)
        {
            if (!this.Gestion_GridView.Rows[this.rowIndex].IsNewRow)
            {
                this.Gestion_GridView.Rows.RemoveAt(this.rowIndex);
            }
        }
        /*------ Pour le salt and hash des passewords -------*/

        // créé une chaine de caratère à ajouter au mot de passe
        public static string CreateSalt(int size)
        {
            //Generate a cryptographic random number.
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);

            // Return a Base64 string representation of the random number.
            return Convert.ToBase64String(buff);
        }


        // Hasl le mot de passe avec la chaine de caratète ajoutée
        public static string MD5Hash(string pwd, string salt)
        {
            string saltAndPwd = String.Concat(pwd, salt);
            MD5 md5 = new MD5CryptoServiceProvider();

            //compute hash from the bytes of text
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(saltAndPwd));

            //get hash result after compute it
            byte[] result = md5.Hash;

            StringBuilder strBuilder = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {
                //change it into 2 hexadecimal digits
                //for each byte
                strBuilder.Append(result[i].ToString("x2"));
            }

            return strBuilder.ToString();
        }

        private void AjouterButton_Click(object sender, EventArgs e)
        {

            //Microsoft.VisualBasic.Interaction.Inputbox(message)
            string salt = CreateSalt(4);
            string pwd = MD5Hash(SQLpwd_TB.Text, salt);
            SQL_TB.Text = "INSERT INTO `membre`(`ID_membre`, `Role_Membre`, `User_Membre`, `MotdePasse_Membre`, `Salt_Membre`, `Prenom_Membre`, `Nom_Membre`, `PremiereCo_Membre`, `ID_Groupe`) VALUES ( , , ,'"+ salt +"','"+ pwd +"', , ,[value-8],[value-9])";
            
        }

        private void SQLentrer_Button_Click(object sender, EventArgs e)
        {/*
            //------ Pour le salt and hash des passwords -------
            string salt= CreateSalt(4);
            string pwd = MD5Hash(SQLpwd_TB.Text, salt);
            */
            if (SQL_TB.Text == "")
            {
                MessageBox.Show("Erreur !");
            }
            else
            {
                MySqlCommand cmd = BDD.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = SQL_TB.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Commande Appliquée !");
            }
        }

        private void SupprimerButton_Click(object sender, EventArgs e)
        {
            SQL_TB.Text = "DELETE FROM `extranet`.`membre` WHERE `membre`.`ID_membre` = ;";
        }

        private void Enter_Button_Click(object sender, EventArgs e)
        {
            if(Prenom_Box.Text == "" || Nom_Box.Text == "" || Identity_Box.Text == "" || PWD_Box.Text == "")
            {
                MessageBox.Show("Erreur !");
            }
            else { //------ Pour le salt and hash des passwords -------
                string salt = CreateSalt(4);
                string pwd = MD5Hash(PWD_Box.Text, salt);

                //---------------------------------------------------
                //MessageBox.Show(pwd);
                MySqlCommand cmd = BDD.CreateCommand();
                cmd.CommandType = System.Data.CommandType.Text;
                cmd.CommandText = "INSERT INTO `membre`(`Role_Membre`, `User_Membre`, `MotdePasse_Membre`, `Salt_Membre`, `Prenom_Membre`, `Nom_Membre`, `ID_Groupe`) VALUES('" + (Role_CB.SelectedIndex + 1) + "','" + Identity_Box.Text + "','" + pwd + "','" + salt + "','" + Prenom_Box.Text + "','" + Nom_Box.Text + "','" + Groupe_CB.Text + "')";
                cmd.ExecuteNonQuery();
                MessageBox.Show("Ajouter !");
                Role_CB.Text = "";
                Prenom_Box.Text = "";
                Nom_Box.Text = "";
                Groupe_CB.Text = "";
                Identity_Box.Text = "";
                PWD_Box.Text = "";
                UpdateGrid(BDD);
            }
           
        }
    }
}
