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

namespace ProjetS4
{
    public partial class Gestion : Form
    {
        private MySqlDataAdapter mySqlDataAdapter;
        public MySqlConnection BDD;
        private int rowIndex = 0;
        public Gestion(MySqlConnection Main)
        {
            InitializeComponent();
            this.BDD = Main;
            mySqlDataAdapter = new MySqlDataAdapter("select * from membre", BDD);
            DataSet DS = new DataSet();
            mySqlDataAdapter.Fill(DS);
            Gestion_GridView.DataSource = DS.Tables[0];
        }
   
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
    }
}
