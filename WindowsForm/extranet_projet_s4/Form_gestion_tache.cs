﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace extranet_projet_s4
{
    public partial class Form_gestion_tache : Form
    {
        form_login form_login;
        public Form_gestion_tache(form_login lg)
        {
            InitializeComponent();
            this.form_login = lg;
        }

        private void Form_gestion_tache_Load(object sender, EventArgs e)
        {

        }

        private void Form_gestion_tache_FormClosed(object sender, FormClosedEventArgs e)
        {
            form_login.Close();
        }

        private void gestion_tache_accesrapide_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bientôt disponible");
        }

        private void gestion_tache_nouvelletache_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bientôt disponible");
        }
    }
}