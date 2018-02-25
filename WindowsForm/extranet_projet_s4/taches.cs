using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace extranet_projet_s4
{
    class taches
    {
        /*---------------------------- PROPRIETES ---------------------------*/

        /*---------------------------------- METHODES -------------------------------*/
        // A REVOIR
        public void creation_fichier()
        {
            // creer la base de donnée à la première connexion
            SQLiteConnection.CreateFile("BDD.sqlite");

            SQLiteConnection crea_table;
            crea_table = new SQLiteConnection("Data Source=BDD.sqlite;Version=3;");
            crea_table.Open();

            SQLiteCommand cmd = crea_table.CreateCommand();

            // le texte de la requete
            cmd.CommandText = "CREATE TABLE taches (id_tache integer primary key, intitule varchar(250),date_creation text, date_butoire text);";

            // execute la commande
            cmd.ExecuteNonQuery();
            //SQLiteDataReader sqlite_datareader;  // Data Reader Object
            crea_table.Close();
        }
        //______________________________________________
        //rechercher les tâches déjà créées
        private void lecture()
        {
            SQLiteConnection crea_table;          // Database Connection Object
            SQLiteCommand sqlite_cmd;             // Database Command Object
            SQLiteDataReader sqlite_datareader;  // Data Reader Object

            crea_table = new SQLiteConnection("Data Source=BDD.sqlite;Version=3;New=True;");

            crea_table.Open();

            sqlite_cmd = crea_table.CreateCommand();

            sqlite_cmd.CommandText = "SELECT * FROM taches";

            sqlite_datareader = sqlite_cmd.ExecuteReader();

            // The SQLiteDataReader allows us to run through each row per loop
            while (sqlite_datareader.Read()) // Read() returns true if there is still a result line to read
            {
                // Print out the content of the text field:
                // System.Console.WriteLine("DEBUG Output: '" + sqlite_datareader["text"] + "'");

                object idReader = sqlite_datareader.GetValue(0);
                string textReader = sqlite_datareader.GetString(1);
                string dateReader = sqlite_datareader.GetString(3);

                //OutputTextBox.Text += idReader + " '" + textReader + "' " + "\n";
            }
        }
    }
}
