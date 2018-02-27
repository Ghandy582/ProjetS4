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

namespace extranet_projet_s4
{
    public partial class Gestion : Form
    {
        private MySqlDataAdapter mySqlDataAdapter;
        public MySqlConnection BDD;
        private int rowIndex = 0;
        public Gestion(MySqlConnection SQL)
        {
            InitializeComponent();
            this.BDD = SQL;
            //recup de donnée
            mySqlDataAdapter = new MySqlDataAdapter("select * from membre", BDD);
            //le tableau 
            DataSet DS = new DataSet();
            //remplissage du tableau aves les données recuperées
            mySqlDataAdapter.Fill(DS);
            Gestion_GridView.DataSource = DS.Tables[0];
            Role_CB.Items.Add("Eleve");
            Role_CB.Items.Add("Professeur");
            Role_CB.Items.Add("Administrateur");
            Role_CB.Items.Add("Super Eleve");
            Role_CB.Items.Add("Super Professeur");
            //remplir le combobox avec les données de la BDD
            string selectQuery = "SELECT * FROM groupe";
            MySqlCommand command = new MySqlCommand(selectQuery, BDD);
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Groupe_CB.Items.Add(reader.GetString("Libelle_Groupe"));
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
            md5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(pwd));

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
            MessageBox.Show("Soon!");
            //SQL_TB.Text = "INSERT INTO `membre`(`Role_Membre`, `User_Membre`,`Prenom_Membre`, `Nom_Membre`, `PremiereCo_Membre`, `ID_Groupe`) VALUES ([value-1],[value-2],[value-3],[value-4],[value-5],[value-6])";
        }

        private void SQLentrer_Button_Click(object sender, EventArgs e)
        {/*
            //------ Pour le salt and hash des passwords -------
            string salt= CreateSalt(4);
            string pwd = MD5Hash(SQLpwd_TB.Text, salt);

            //---------------------------------------------------
            MessageBox.Show(pwd);
            MySqlCommand cmd = BDD.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT membre ( Nom,Prenom,User,Password,Rank,salt) VALUES ('"+Add_Nom_TB.Text+"','"+Add_Prenom_TB.Text+"','"+Add_User_TB.Text+"','"+pwd+"','"+Add_Rank_TB.Text+ "','" + salt + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ajouter !");*/
            MySqlCommand cmd = BDD.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = SQL_TB.Text;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Supprimer !");
        }

        private void SupprimerButton_Click(object sender, EventArgs e)
        {
            SQL_TB.Text = "DELETE FROM `projet4`.`membre` WHERE `membre`.`ID_membre` = ;";
        }


    }
}
