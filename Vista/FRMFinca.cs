using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMiFinca
{
    /*
     * esta clase se encarga de desplegar la interfaz de usuario para 
     * que se registren fincas
     */
    public partial class FRMFinca : Form
    {
        //atributos y referencias
        
        public FRMFinca()
        {
            InitializeComponent();
        }//fin constructor

        /*
         * este metodo se encarga de esconder el formulario Registrar Finca
         */
        private void btnIrAMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }//fin btnIrAMenuPrincipal_Click

        /*
         * este metodo se encarga de esconder el formulario actual
         */
        private void FRMFinca_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
        }//fin FRMFinca_Load

        /*
         * este metodo se encarga de cerrar el formulario actual y abrir el menu principal 
         */
        private void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }//fin cerrarFormulario

        /*
         * este metodo se encarga de accionar con un click el registro de una finca
         */
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.maskedTextBoxNumeroFinca.Text != "" && this.textBoxNombreFinca.Text != "" &&
                                this.textBoxDireccionFinca.Text != "" && this.maskedTextBoxTelefono.Text != "" &&
                                this.maskedTextBoxTamanoFinca.Text != "")
                {
                    MessageBox.Show(ControladorFRMFinca.RegistrarFinca(ControladorFRMFinca.GetObjetoFinca(
                        Convert.ToInt32(this.maskedTextBoxNumeroFinca.Text), this.textBoxNombreFinca.Text,
                        this.textBoxDireccionFinca.Text, Convert.ToInt32(this.maskedTextBoxTelefono.Text),
                        Convert.ToInt32(this.maskedTextBoxTamanoFinca.Text))));
                    //estado inicial
                    this.EstadoInicial();
                }//fin if
                else
                {
                    MessageBox.Show("No se puede registrar, algun o algunos de los datos no se ingresaron" +
                        " correctamente. Por favor vuelva a ingresar los datos solicitados.");
                }//fin else 
            }//fin try
            catch(Exception ex) 
            {
                MessageBox.Show("Ha introducido un valor invalido o el numero de finca ya existe." +
                    " Por favor, vuelva a intentarlo.");
            }//fin catch
            
        }//fin btnRegistrar_Click

        /*
         * este metodo se encarga de dejar la interfaza en su estado inicial
         */
        public void EstadoInicial()
        {
            this.maskedTextBoxNumeroFinca.ResetText();
            this.maskedTextBoxTamanoFinca.ResetText();
            this.maskedTextBoxTelefono.ResetText();
            this.textBoxNombreFinca.ResetText();
            this.textBoxDireccionFinca.ResetText();
        }//fin EstadoInicial

    }//fin clase FRMFinca
}
