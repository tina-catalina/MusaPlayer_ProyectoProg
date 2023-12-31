﻿using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace interfaz_2._0._01
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }

        private void clickRegistrar_Click(object sender, EventArgs e)
        {
            new formRegister().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            new formMain().Show();
            this.Hide();
        }

        private void btnExitLogin_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Seguro quieres irte?", "Salir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                Application.Exit();
            }
        }
    }
}
