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
    public partial class formRegister : Form
    {
        public formRegister()
        { 
            InitializeComponent(); 
        }
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            new formLogin().Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new formLogin().Show();
            this.Hide();
        }

        private void btnExitRegister_Click(object sender, EventArgs e)
        {

            DialogResult dialogResult = MessageBox.Show("Seguro quieres irte?", "Salir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                Application.Exit();
            }
        }
    }
}
