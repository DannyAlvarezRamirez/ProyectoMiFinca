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
     * que se registren duenos
     */
    public partial class FRMDueno : Form
    {
        //atributos y referencias
        public FRMDueno()
        {
            InitializeComponent();
            LlenarComboBoxFincas();
        }//fin constructor

        /*
         * este metodo se encarga de esconder el formulario Registrar Dueno
         */
        private void buttonIrAlMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }//fin buttonIrAlMenuPrincipal_Click

        /*
         * este metodo se encarga de esconder el formulario actual
         */
        private void FRMDueno_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
        }//fin FRMDueno_Load

        /*
         * este metodo se encarga de esconder el formulario actual  
         */
        private void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }//fin cerrarFormulario

        /*
         * este metodo se encarga de, luego de dar click sobre el boton registrar, de registrar duenos
         * en el sistema 
         */
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.maskedTextBoxIdentificacion.Text != "" && this.textBoxNombre.Text != "" &&
                                this.textBoxPrimerApellido.Text != "" && this.textBoxSegundoApellido.Text != "" &&
                                this.textBoxCorreoElectronico.Text != "" && this.maskedTextBoxNumeroCelular.Text != "" &&
                                this.comboBoxFincas.Text != "")
                {
                    MessageBox.Show(ControladorFRMDueno.RegistrarDueno(ControladorFRMDueno.GetObjetoDueno(
                        Convert.ToInt32(this.maskedTextBoxIdentificacion.Text), this.textBoxNombre.Text,
                        this.textBoxPrimerApellido.Text, this.textBoxSegundoApellido.Text, 
                        this.textBoxCorreoElectronico.Text, Convert.ToInt32(this.maskedTextBoxNumeroCelular.Text),
                        ControladorFRMDueno.BuscarFinca(Convert.ToInt32(this.comboBoxFincas.SelectedItem.ToString())))));
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
                MessageBox.Show("Ha introducido un valor invalido o el numero de identificacion ya existe o no hay fincas registradas aun." +
                    " Por favor, vuelva a intentarlo.");
            }//fin catch
        }//fin buttonRegistrar_Click

        /*
         * este metodo se encarga de dejar la interfaza en su estado inicial
         */
        public void EstadoInicial()
        {
            this.maskedTextBoxIdentificacion.ResetText();
            this.maskedTextBoxNumeroCelular.ResetText();
            this.textBoxNombre.ResetText();
            this.textBoxPrimerApellido.ResetText();
            this.textBoxSegundoApellido.ResetText();
            this.textBoxCorreoElectronico.ResetText();
            this.comboBoxFincas.SelectedIndex = 0;
        }//fin EstadoInicial

        /*
         * este metodo se encarga de llenar el comboboxFincas con los objetos finca registrados en sistema
         */
        public void LlenarComboBoxFincas()
        {
            if (ControladorFRMFinca.miListaFinca != null)
            {
                //llenar combobox con numero de la finca
                for (int i = 0; i < ControladorFRMFinca.miListaFinca.Count; i++)
                {
                    this.comboBoxFincas.Items.Add(ControladorFRMFinca.miListaFinca.ElementAt(i).NumeroFinca + "");
                }//fin for
            }//fin if
        }//fin LlenarComboBoxFincas



    }//fin clase FRMDueno
}
