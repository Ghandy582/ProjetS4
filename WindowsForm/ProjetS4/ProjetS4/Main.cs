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


namespace ProjetS4
{
    public partial class Main : Form
    {
        Login lg;
        private MySqlDataAdapter mySqlDataAdapter;
        int id_user;
        MySqlConnection BDD = new MySqlConnection("SERVER=localhost;" + "DATABASE=projets4;" + "UID=root;" + "PASSWORD=;");
        public Main(Login lg, int id_user)
        {
            InitializeComponent();
            BDD.Open();
            this.lg = lg;
            this.id_user = id_user;
        }

        private void Menu_User_Delete_Click(object sender, EventArgs e)
        {
            Panel_Ajouter.Visible = false;
            Panel_Liste.Visible = false;
            Panel_Supprimer.Visible = true;
        }

        private void Menu_User_Add_Click(object sender, EventArgs e)
        {
            Panel_Supprimer.Visible = false;
            Panel_Liste.Visible = false;
            Panel_Ajouter.Visible = true;
        }

        private void Add_Valider_Click(object sender, EventArgs e)
        {
            /*------ Pour le salt and hash des passewords -------*/
            string salt=CreateSalt(4);
            string pwd = MD5Hash(Add_Password_TB.Text, salt);

            /*---------------------------------------------------*/
            MessageBox.Show(pwd);
            MySqlCommand cmd = BDD.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "INSERT utilisateurs ( Nom,Prenom,User,Password,Rank,salt) VALUES ('"+Add_Nom_TB.Text+"','"+Add_Prenom_TB.Text+"','"+Add_User_TB.Text+"','"+pwd+"','"+Add_Rank_TB.Text+ "','" + salt + "')";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Ajouter !");
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd = BDD.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "delete from utilisateurs where nom = '" + Delete_Nom_TB.Text + "'and prenom = '"+ Delete_Prenom_TB.Text +"'; ";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Supprimer !");
        }

        private void Delete_Prenom_TB_TextChanged(object sender, EventArgs e)
        {

        }
        /*------ Pour le salt and hash des passewords -------*/

        // créé une chaine de caratère à ajouter au mot de passe
        private static string CreateSalt(int size)
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

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            lg.Close();
        }

        private void personnalisationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Personalisation_DialogBox.ShowDialog() == DialogResult.OK)
            {
                
                Panel_Ajouter.BackColor = Personalisation_DialogBox.Color;
                Panel_Supprimer.BackColor = Personalisation_DialogBox.Color;
                Panel_Liste.BackColor = Personalisation_DialogBox.Color;
                Liste_DataGrid.BackgroundColor = Personalisation_DialogBox.Color;
            }
        }

        private void Menu_User_Liste_Click(object sender, EventArgs e)
        {
            Panel_Liste.Visible = true;
            mySqlDataAdapter = new MySqlDataAdapter("select * from utilisateurs", BDD);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            Liste_DataGrid.DataSource = DS.Tables[0];
        }

        private void Liste_DataGrid_RowValidated(object sender, DataGridViewCellEventArgs e)
        {
            DataTable changes = ((DataTable)Liste_DataGrid.DataSource).GetChanges();

            if (changes != null)
            {
                MySqlCommandBuilder mcb = new MySqlCommandBuilder(mySqlDataAdapter);
                mySqlDataAdapter.UpdateCommand = mcb.GetUpdateCommand();
                mySqlDataAdapter.Update(changes);
                ((DataTable)Liste_DataGrid.DataSource).AcceptChanges();
            }
        }
    }
}
