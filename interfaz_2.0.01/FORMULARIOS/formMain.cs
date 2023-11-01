using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace interfaz_2._0._01
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();
        }

        private void OpenSelectedForm(Form cf)
        {
            if (this.mainPanel.Controls.Count > 0)
            {
                if (this.mainPanel.Controls[0].GetType() == cf.GetType()) return;

                this.mainPanel.Controls.RemoveAt(0);
            }
            cf.TopLevel = false; // Esto evita que el form se ponga enfrente de todas las ventanas
            cf.Dock = DockStyle.Fill; // esto acopla los bordes del form llenando el control o superficie donde este Ej: un panel/ventana etc
            this.mainPanel.Controls.Add(cf); // Esto agrega el form al panel principal del form principal
            this.mainPanel.Tag = cf; // crea un enlace a los posibles datos/atributos en el panel
            cf.Show(); // muestra el form
        }

        private void btnMiMusica_Click(object sender, EventArgs e)
        {
            OpenSelectedForm(new formMyMusic()); // Donde queda guardada la instancia pasada por parametro?
        }


        private void btnComunidad_Click(object sender, EventArgs e)
        {
            OpenSelectedForm(new formCommunity());
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            OpenSelectedForm(new formPreferences());
        }

        private void btnExitRegister_Click(object sender, EventArgs e)
        {
            // ARREGLAR BOTONES SALIRSE Y MINIMIZAR DEL MAIN
            // Hacer message box para preguntar si quiere salir
            Application.Exit();
        }

        private void btnCerrarSesion_Main_Click(object sender, EventArgs e)
        {
            // logica para cerrar la sesion, falta la meesagebox para comprobar si quiere irse o no.

            DialogResult dialogResult = MessageBox.Show("Seguro quieres irte?", "Cerrar Sesion", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            new formLogin().Show();
            this.Close();

            }


        }

        private void formMain_Load(object sender, EventArgs e)
        {
            OpenSelectedForm(new formMyMusic());
        }

        private void btnSubirMusica_Click(object sender, EventArgs e)
        {
            OpenSelectedForm(new formUploadMusic());

        }

        private void btnCerrarFormulario_Main_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult =  MessageBox.Show("Seguro quieres irte?", "Salir", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                Application.Exit();
            }

        }
    }
}
