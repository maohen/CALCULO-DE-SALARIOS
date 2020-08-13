using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CALCULO_DE_SALARIOS
{
    public partial class verEmpleado : Form
    {
        public verEmpleado()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //intancia de DialogResult para mostrar el openfileDialog
            DialogResult rta = openFileDialog1.ShowDialog();
            //si se seleciona aceptar llena el campo con el  nombre del archivo
            if (rta == DialogResult.OK)
                tbxArchivo.Text = openFileDialog1.FileName;
        }

        private void btnProcesar_Click(object sender, EventArgs e)
        {
            //si no selecciona un archivo arroja error
            if (openFileDialog1.FileName == "")
            {
                MessageBox.Show("Debe seleccionar un archivo","Error",MessageBoxButtons.OK,   MessageBoxIcon.Exclamation);
                return;
            }

            //el archivo elegido debe ser txt
            if (tbxArchivo.Text.EndsWith("txt"))
            {
                //se instacia un streamReader y se escribe sobre el textbox principal
                StreamReader lector = new StreamReader(tbxArchivo.Text);
                //variable registro es igual a la linea leida
                string registro = lector.ReadLine();
                txtResultados.AppendText(string.Format("{0,-20} {1,-10} {2,-10} {3,-18} {4,-15}\r\n", "Nombre", "Documento", "Sexo","Fecha de ingreso","Cargo"));
                txtResultados.AppendText(string.Format("*******************  *********  *********  ****************   ***************\r\n")); ;

                //mientras la linea no se de valor null
                while (registro != null)
                {
                    //variable pos tendra el indice donde encuentre la coma
                    int pos = registro.IndexOf(",");
                    //variable tendra el texto desde indice 0 hasta pos
                    string nombre = registro.Substring(0, pos);
                    //registro tendra el texto desde pos+1 en adelante
                    registro = registro.Substring(pos + 1);

                    pos = registro.IndexOf(",");
                    string documento = registro.Substring(0, pos);
                    registro = registro.Substring(pos + 1);
                    pos = registro.IndexOf(",");
                    string sexo = registro.Substring(0, pos);
                    registro = registro.Substring(pos + 1);
                    pos = registro.IndexOf(",");
                    string fecha = registro.Substring(0, pos);
                    registro = registro.Substring(pos + 1);
                    
                    string cargo = registro.Substring(0);
                    

                    txtResultados.AppendText(string.Format("{0,-20} {1,-10} {2,-10} {3,-18} {4,-15}\r\n",nombre, documento, sexo,fecha,cargo));
                    registro = lector.ReadLine();
                }
                lector.Close();
            }
            else
                MessageBox.Show("Debe ser un archivo de texto","Error", MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
    }
}
