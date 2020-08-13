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
    public partial class Salario_empleado : Form
    {
        public Salario_empleado()
        {
            InitializeComponent();
        }

        //metodo para calcular la fecha de ingreso
        private double beneficios(double antig, double sBase)//se reciben parametros de fecha de ingreso y sueldo base
        {
            //se declara variable de cuanto es el beneficio y se validan fechas
            double prima = sBase * 0.02;
            if (antig > 5)
                lblBeneficios.Text = string.Format("{0:C0}", prima);
            else
            {
                if (antig == 5)
                {
                    if (DateTime.Now.Month > dattFecha.Value.Month)
                        lblBeneficios.Text = string.Format("{0:C0}", prima);
                    else if (DateTime.Now.Month == dattFecha.Value.Month)
                    {
                        if (DateTime.Now.Day > dattFecha.Value.Day)
                            lblBeneficios.Text = string.Format("{0:C0}", prima);
                        else
                        {
                            lblBeneficios.Text = ".....";
                            prima = 0;
                        }
                    }
                    else
                    {
                        lblBeneficios.Text = ".....";
                        prima = 0;
                    }
                }
                else
                {
                    lblBeneficios.Text = ".....";
                    prima = 0;
                }
            }
            return prima;
        }

        //metodo para limpiar los campos
        private void limpiarCalculo()
        {
            lblBeneficios.Text = ".....";
            lblSueldo.Text = ".....";
            lblComisiones.Text = ".....";
            lblHorExtras.Text = ".....";
            lblSubTransporte.Text = ".....";
            lblSeguridad.Text = ".....";
            lblTotal.Text = ".....";
        }

        //private void dattFecha_ValueChanged(object sender, EventArgs e)
        //{

        //}

        private void btnCalcular_Click_1(object sender, EventArgs e)
        {
            //se declaran variables
            double horasWork = 0, sueldoBase, seguridad, prima, ventas, hExtras;
            int antiguedad;
            limpiarCalculo();
            //se validan que se llenen campos
            if (tbxNombre.Text == "" || tbxDocumento.Text == "" || tbxHorasWork.Text == "")
            {
                MessageBox.Show("Los campos marcados con * no deben estar vacios");
            }
            else
            {
                // se valida que el campo contenga numeros
                if (double.TryParse(tbxHorasWork.Text, out horasWork))
                {
                    //se validan las horas
                    if (horasWork >= 48 && horasWork <= 60)
                    {
                        if (cbxCargo.Text != "")
                        {
                            if (cbxCargo.Text == "Administrativo")
                            {
                                sueldoBase = 30000 * 48;
                                seguridad = sueldoBase * 0.08;
                                antiguedad = DateTime.Now.Year - dattFecha.Value.Year;
                                prima = beneficios(antiguedad, sueldoBase);
                                //se formatea campo con moneda local
                                lblSueldo.Text = string.Format("{0:C0}", sueldoBase);
                                lblSeguridad.Text = string.Format("{0:C0}", seguridad);
                                lblTotal.Text = string.Format("{0:C0}", sueldoBase + prima - seguridad);
                                tbxVentas.Text = "";
                            }

                            if (cbxCargo.Text == "Vendedor")
                            {
                                if (double.TryParse(tbxVentas.Text, out ventas))
                                {
                                    sueldoBase = 15000 * 48;
                                    seguridad = sueldoBase * 0.08;
                                    ventas *= 0.04;
                                    antiguedad = DateTime.Now.Year - dattFecha.Value.Year;
                                    prima = beneficios(antiguedad, sueldoBase);
                                    lblSueldo.Text = string.Format("{0:C0}", sueldoBase);
                                    lblSeguridad.Text = string.Format("{0:C0}", seguridad);
                                    lblComisiones.Text = string.Format("{0:C0}", ventas);
                                    lblTotal.Text = string.Format("{0:C0}", sueldoBase + prima + ventas - seguridad);
                                }
                                else
                                {
                                    MessageBox.Show("OJO! campo de ventas debe contener numeros");
                                }
                            }

                            if (cbxCargo.Text == "Mecanico")
                            {
                                horasWork = float.Parse(tbxHorasWork.Text);
                                hExtras = horasWork - 48;
                                hExtras *= (20000 * 1.5);
                                sueldoBase = 20000 * 48;
                                seguridad = sueldoBase * 0.08;
                                antiguedad = DateTime.Now.Year - dattFecha.Value.Year;
                                prima = beneficios(antiguedad, sueldoBase);

                                lblSueldo.Text = string.Format("{0:C0}", sueldoBase);
                                lblSeguridad.Text = string.Format("{0:C0}", seguridad);
                                lblHorExtras.Text = string.Format("{0:C0}", hExtras);
                                lblTotal.Text = string.Format("{0:C0}", sueldoBase + prima + hExtras - seguridad);
                                tbxVentas.Text = "";

                            }

                            if (cbxCargo.Text == "Servicios Varios")
                            {
                                horasWork = float.Parse(tbxHorasWork.Text);
                                hExtras = horasWork - 48;
                                hExtras *= (5000 * 1.5);
                                sueldoBase = 5000 * 48;
                                seguridad = sueldoBase * 0.08;
                                antiguedad = DateTime.Now.Year - dattFecha.Value.Year;
                                prima = beneficios(antiguedad, sueldoBase);

                                lblSueldo.Text = string.Format("{0:C0}", sueldoBase);
                                lblSeguridad.Text = string.Format("{0:C0}", seguridad);
                                lblHorExtras.Text = string.Format("{0:C0}", hExtras);
                                lblSubTransporte.Text = string.Format("{0:C0}", 45000);
                                lblTotal.Text = string.Format("{0:C0}", sueldoBase + prima + hExtras - seguridad);
                                tbxVentas.Text = "";

                            }
                        }
                        else
                            MessageBox.Show("Seleccione el cargo");
                    }
                    else
                    {
                        MessageBox.Show("¡ATENCION! el numero de horas no debe ser menor a 48 ni mayor a 60");
                        limpiarCalculo();
                    }
                }
                else
                {
                    MessageBox.Show("OJO! campo de horas trabajadas debe contener numeros");
                    limpiarCalculo();
                }
            }
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            tbxNombre.Text = "";
            tbxDocumento.Text = "";
            tbxHorasWork.Text = "";
            tbxVentas.Text = "";
            dattFecha.ResetText();
            cbxCargo.Text = "";
            rbtnFemenino.Checked = false;
            rbtnMasculino.Checked = false;
            limpiarCalculo();
        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //se declara variable
            string sexo="";

            if (rbtnMasculino.Checked)
                sexo = rbtnMasculino.Text;
            if (rbtnFemenino.Checked)
                sexo = rbtnFemenino.Text;
            //se valida que se llenen los campos
            if (tbxNombre.Text == "" || tbxDocumento.Text == "" || dattFecha.Text == "" || cbxCargo.Text == "")
            {
                MessageBox.Show("LLenar los siguientes campos\n **Nombre\n **Documento\n **Sexo\n **Fecha\n **cargo");
            }
            else
            {
                //se valida que se seleccione un checkbox
                if (!rbtnFemenino.Checked  && !rbtnMasculino.Checked)
                    MessageBox.Show("Seleccione sexo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    //se instancia la clase textwriter de la libreria IO y se crea archivo txt con argumento true para sobreescribirlo
                    TextWriter employee = new StreamWriter("employee.txt", true);
                    //se agregan lineas de texto al archivo employee
                    employee.WriteLine($"{tbxNombre.Text},{tbxDocumento.Text},{sexo},{dattFecha.Text},{cbxCargo.Text}");
                    employee.Close();
                    MessageBox.Show($"**Datos guardados**\n{tbxNombre.Text}");
                }
                    
            }
        }
    }
}
