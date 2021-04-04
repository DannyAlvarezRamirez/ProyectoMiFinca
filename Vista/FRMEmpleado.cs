﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroganaderaMiFincaGui
{
    /*
     * esta clase se encarga de desplegar la interfaz de usuario para 
     * que se registren empleados
     */
    public partial class FRMEmpleado : Form
    {
        public FRMEmpleado()
        {
            InitializeComponent();
        }//fin constructor

        /*
         * este metodo se encarga de, luego de dar click sobre el boton registrar, de registrar empleados
         * en el sistema 
         */
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.maskedTextBoxIdentificacion.Text != "" && this.textBoxNombre.Text != "" &&
                                this.textBoxPrimerApellido.Text != "" && this.textBoxSegundoApellido.Text != "" &&
                                this.maskedTextBoxSalario.Text != "")
                {
                    MessageBox.Show(ControladorFRMEmpleado.RegistrarEmpleado(ControladorFRMEmpleado.GetObjetoEmpleado(
                        Convert.ToInt32(this.maskedTextBoxIdentificacion.Text), this.textBoxNombre.Text,
                        this.textBoxPrimerApellido.Text, this.textBoxSegundoApellido.Text,
                        Convert.ToInt32(this.maskedTextBoxSalario.Text))));
                    //estado inicial
                    this.EstadoInicial();
                }//fin if
                else
                {
                    MessageBox.Show("No se puede registrar, algun o algunos de los datos no se ingresaron" +
                        " correctamente. Por favor vuelva a ingresar los datos solicitados.");
                }//fin else 
            }//fin try
            catch (Exception ex)
            {
                MessageBox.Show("Ha introducido un valor invalido o el numero de identificacion ya existe." +
                    " Por favor, vuelva a intentarlo.");
            }//fin catch
        }//fin buttonRegistrar_Click

        /*
         * este metodo se encarga de dejar la interfaza en su estado inicial
         */
        public void EstadoInicial()
        {
            this.maskedTextBoxIdentificacion.ResetText();
            this.maskedTextBoxSalario.ResetText();
            this.textBoxNombre.ResetText();
            this.textBoxPrimerApellido.ResetText();
            this.textBoxSegundoApellido.ResetText();
        }//fin EstadoInicial

        /*
         * este metodo se encarga de esconder el formulario Registrar Empleado
         */
        private void buttonIrAlMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }//fin buttonIrAlMenuPrincipal_Click

        /*
         * este metodo se encarga de esconder el formulario actual
         */
        private void FRMEmpleado_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
        }//fin FRMEmpleado_Load

        /*
         * este metodo se encarga de esconder el formulario actual  
         */
        private void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }//fin cerrarFormulario
    }//fin clase FRMEmpleado
}
