using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente
{
    /*
     * esta clase se encarga de desplegar la interfaz de usuario para 
     * que se registren empleados
     */
    public partial class FRMEmpleado : Form
    {
        //atributos y referencias
        ControladorFRMEmpleado miControladorFRMEmpleado;
        public FRMEmpleado()
        {
            InitializeComponent();
            miControladorFRMEmpleado = new ControladorFRMEmpleado();
            this.EstadoInicial();
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
                    MessageBox.Show(miControladorFRMEmpleado.RegistrarEmpleado(miControladorFRMEmpleado.GetObjetoEmpleado(
                        Convert.ToInt32(this.maskedTextBoxIdentificacion.Text), this.textBoxNombre.Text,
                        this.textBoxPrimerApellido.Text, this.textBoxSegundoApellido.Text,
                        Convert.ToInt32(this.maskedTextBoxSalario.Text), this.textBoxUsuario.Text, this.textBoxContrasena.Text,
                        Convert.ToInt32(this.comboBoxEstado.SelectedItem.ToString()))));
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
            this.textBoxUsuario.ResetText();
            this.textBoxContrasena.ResetText();
            this.comboBoxEstado.SelectedItem = 0;
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
