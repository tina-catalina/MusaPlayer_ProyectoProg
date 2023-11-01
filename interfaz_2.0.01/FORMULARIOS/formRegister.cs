using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            if (this.campoValidando())
            {
                return;
            }
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

        private bool campoValidando()
        {
            Regex rxCedula = new Regex(@"^[1-9]\d*$",
           RegexOptions.Compiled | RegexOptions.IgnoreCase);

            Regex rxContrasenia = new Regex(@"^(?=.*\d).{6,}$",
           RegexOptions.Compiled | RegexOptions.IgnoreCase);


            

            if (!rxCedula.Match(this.txbxCI_Register.Text).Success || !rxContrasenia.Match(this.txtbxPassword_Register.Text).Success || this.txtbxCheckPassword_Register != this.txtbxPassword_Register)
            {
                MessageBox.Show("Error! Verifica que tus datos cumplan con:\n 1.- Cedula sin letras\n 2.- Contrasenia con mas de 6 caracteres y al menos 1 numero\n 3.- Ambas Contrasenias coincidan");
                return true;
            }

            return false;
        }
    }
}
