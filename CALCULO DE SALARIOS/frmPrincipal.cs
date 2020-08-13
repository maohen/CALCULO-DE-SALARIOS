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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirForm(Form formHijo)
        {
            //se programa como se mostrara cada modulo en el panel principal del programa
            if (this.pnlVista.Controls.Count > 0)
                this.pnlVista.Controls.RemoveAt(0);
            formHijo.TopLevel = false;
            formHijo.FormBorderStyle = FormBorderStyle.None;
            formHijo.Dock = DockStyle.Fill;
            this.pnlVista.Controls.Add(formHijo);
            formHijo.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCalcularS_Click(object sender, EventArgs e)
        {
            //se instancia la clase 
            Salario_empleado calculo = new Salario_empleado();
            AbrirForm(calculo);
        }

        private void btnAcercaDe_Click(object sender, EventArgs e)
        {
            //se instancia la clase 
            AcercaDe info = new AcercaDe();
            AbrirForm(info);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verEmpleado menu = new verEmpleado();
            AbrirForm(menu);
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
