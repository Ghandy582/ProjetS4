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

namespace extranet_projet_s4
{
    public partial class Form_AdminAssignerProf : Form
    {
        private MySqlDataAdapter mySqlDataAdapter;
        public MySqlConnection BDD;
        public Form_AdminAssignerProf(MySqlConnection SQL)
        {
            this.BDD = SQL;
            InitializeComponent();
            UpdateGrid(BDD);
        }
        private void UpdateGrid(MySqlConnection SQL)
        {
            //recup de donnée
            mySqlDataAdapter = new MySqlDataAdapter("select ID_membre, Prenom_Membre, Nom_Membre from membre where ID_groupe = 1", BDD);
            //le tableau 
            DataSet DS = new DataSet();
            //remplissage du tableau aves les données recuperées
            mySqlDataAdapter.Fill(DS);
            Prof_DataGrid.DataSource = DS.Tables[0];
            //recup de donnée
            mySqlDataAdapter = new MySqlDataAdapter("select * from cours", BDD);
            //le tableau 
            DataSet DS2 = new DataSet();
            //remplissage du tableau aves les données recuperées
            mySqlDataAdapter.Fill(DS2);
            Cours_DataGrid.DataSource = DS2.Tables[0];
            //recup de donnée
            mySqlDataAdapter = new MySqlDataAdapter("select Libelle_Cours,Prenom_Membre,Nom_Membre from cours_membre JOIN cours ON cours_membre.ID_Cours = cours.ID_Cours JOIN membre ON cours_membre.ID_membre = membre.ID_membre ", BDD);
            //le tableau 
            DataSet DS3 = new DataSet();
            //remplissage du tableau aves les données recuperées
            mySqlDataAdapter.Fill(DS3);
            Membre_Cours_Grid.DataSource = DS3.Tables[0];
        }
    }
}
