﻿using System;
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
    public partial class Form_AdminGestionSeance : Form
    {
        private MySqlDataAdapter mySqlDataAdapter;
        public MySqlConnection BDD;
        private int rowIndex = 0;
        public Form_AdminGestionSeance(MySqlConnection SQL)
        {
            this.BDD = SQL;
            InitializeComponent();
            UpdateGrid(BDD);
        }
        private void UpdateGrid(MySqlConnection SQL)
        {
            //recup de donnée
            mySqlDataAdapter = new MySqlDataAdapter("select * from seance", BDD);
            //le tableau 
            DataSet DS = new DataSet();
            //remplissage du tableau aves les données recuperées
            mySqlDataAdapter.Fill(DS);
            Gestion_GridView.DataSource = DS.Tables[0];
        }

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

        private void AjouterButton_Click(object sender, EventArgs e)
        {
            SQL_TB.Text = "INSERT INTO `seance`( `Date_Seance`, `Debut_Seance`, `Note_Seance`, `NotePersonnel_Seance`, `ID_Cours`) VALUES ( , , , , );";
        }

        private void SupprimerButton_Click(object sender, EventArgs e)
        {
            SQL_TB.Text = "DELETE FROM `seance` WHERE";
        }
    }
}