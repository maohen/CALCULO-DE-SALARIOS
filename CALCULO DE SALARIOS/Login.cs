using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CALCULO_DE_SALARIOS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            if (tbxUsuario.Text == "Mauro" && tbxContraseña.Text == "123")
            {
                //se instancia clase y se muestra ocultando el login
                frmPrincipal menu = new frmPrincipal();
                menu.Show();
                this.Hide();
            }
            else
                MessageBox.Show("Login incorrecto");
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbxContraseña_Enter(object sender, EventArgs e)
        {
            
        }

        private void tbxContraseña_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
