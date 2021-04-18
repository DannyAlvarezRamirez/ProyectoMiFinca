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
         * que se registren tratamiento de animales
         */
    public partial class FRMTratamientoAnimal : Form
    {
        //atributos y referencias
        ControladorTratamientoAnimal miControladorTratamientoAnimal;

        //constructor
        public FRMTratamientoAnimal()
        {
            InitializeComponent();
            miControladorTratamientoAnimal = new ControladorTratamientoAnimal();
        }//fin constructor

        /*
         * este metodo se encarga de, luego de dar click sobre el boton registrar, de registrar tratamientos
         * de animales en el sistema 
         */
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.maskedTextBoxIdentificacionAnimal.Text != "" && this.maskedTextBoxDiasTratamiento.Text != "" &&
                    this.maskedTextBoxFecha.Text != "" && this.textBoxDiagnostico.Text != "" &&
                    this.textBoxObservaciones.Text != "" && this.textBoxMedicamentos.Text != "")
                {
                    MessageBox.Show(miControladorTratamientoAnimal.RegistrarTratamientoAnimal(miControladorTratamientoAnimal.GetObjetoTratamientoAnimal(
                        Convert.ToInt32(this.maskedTextBoxIdentificacionAnimal.Text), Convert.ToInt32(this.maskedTextBoxDiasTratamiento.Text),
                        this.maskedTextBoxFecha.Text, this.textBoxDiagnostico.Text, this.textBoxObservaciones.Text, this.textBoxMedicamentos.Text)));
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
            this.maskedTextBoxIdentificacionAnimal.ResetText();
            this.maskedTextBoxDiasTratamiento.ResetText();
            this.maskedTextBoxFecha.ResetText();
            this.textBoxDiagnostico.ResetText();
            this.textBoxObservaciones.ResetText();
            this.textBoxMedicamentos.ResetText();
        }//fin EstadoInicial

        /*
         * este metodo se encarga de esconder el formulario Registrar tratamiento animal
         */
        private void buttonIrAlMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }//fin buttonIrAlMenuPrincipal_Click

        /*
         * este metodo se encarga de esconder el formulario actual
         */
        private void FRMVacunaAnimal_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
        }//fin FRMVacunaAnimal_Load

        /*
         * este metodo se encarga de esconder el formulario actual  
         */
        private void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }//fin cerrarFormulario

    }//fin clase FRMTratamientoAnimal
}
