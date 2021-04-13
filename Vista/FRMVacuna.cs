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
         * que se registren vacunas
         */
    public partial class FRMVacuna : Form
    {
        //atributos, referencias e instancias
        public FRMVacuna()
        {
            InitializeComponent();
        }//fin constructor

        /*
         * este metodo se encarga de, luego de dar click sobre el boton registrar, de registrar razas
         * en el sistema 
         */
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.maskedTextBoxIdentificacionVacuna.Text != "" && this.textBoxDescripcionVacuna.Text != "")
                {
                    MessageBox.Show(ControladorFRMVacuna.RegistrarVacuna(ControladorFRMVacuna.GetObjetoVacuna(
                        Convert.ToInt32(this.maskedTextBoxIdentificacionVacuna.Text), this.textBoxDescripcionVacuna.Text)));
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
         * este metodo se encarga de esconder el formulario Registrar vacuna
         */
        private void buttonIrAlMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }//fin buttonIrAlMenuPrincipal_Click

        /*
         * este metodo se encarga de esconder el formulario actual
         */
        private void FRMVacuna_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
        }//fin FRMVacuna_Load

        /*
         * este metodo se encarga de esconder el formulario actual  
         */
        private void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }//fin cerrarFormulario

        /*
         * este metodo se encarga de dejar la interfaza en su estado inicial
         */
        public void EstadoInicial()
        {
            this.maskedTextBoxIdentificacionVacuna.ResetText();
            this.textBoxDescripcionVacuna.ResetText();
        }//fin EstadoInicial
    }//fin clase 
}
