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
     * que se registren animales
     */
    public partial class FRMAnimal : Form
    {
        //atributos y referencias e intancias necesarias
        ControladorFRMFinca miControladorFRMFinca;
        ControladorFRMRaza miControladorFRMRaza;
        ControladorFRMAnimal miControladorFRMAnimal;

        public FRMAnimal()
        {
            InitializeComponent();
            miControladorFRMFinca = new ControladorFRMFinca();
            miControladorFRMRaza = new ControladorFRMRaza();
            miControladorFRMAnimal = new ControladorFRMAnimal();
            LlenarComboBoxFincas();
            LlenarComboBoxRazas();
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
        private void FRMAnimal_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
        }//fin FRMAnimal_Load

        /*
         * este metodo se encarga de esconder el formulario actual  
         */
        private void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }//fin cerrarFormulario

        /*
         * este metodo se encarga de, luego de dar click sobre el boton registrar, de registrar animales
         * en el sistema 
         */
        private void buttonRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.maskedTextBoxIdentificacion.Text != "" && this.textBoxNombre.Text != "" &&
                                this.comboBoxFincas.Text != "" && this.comboBoxRazas.Text != "" &&
                                this.maskedTextBoxFechaNacimiento.Text != "" && this.comboBoxSexos.Text != "" &&
                                this.textBoxMadre.Text != "" && this.textBoxPadre.Text != "")
                {
                    MessageBox.Show(miControladorFRMAnimal.RegistrarAnimal(miControladorFRMAnimal.GetObjetoAnimal(
                        Convert.ToInt32(this.maskedTextBoxIdentificacion.Text), this.comboBoxSexos.Text,
                        Convert.ToInt32(this.textBoxMadre.Text), Convert.ToInt32(this.textBoxPadre.Text), this.textBoxNombre.Text, this.maskedTextBoxFechaNacimiento.Text,
                        miControladorFRMFinca.BuscarFinca(Convert.ToInt32(this.comboBoxFincas.SelectedItem.ToString())),
                        miControladorFRMRaza.BuscarRaza(Convert.ToInt32(this.comboBoxRazas.SelectedItem.ToString())))));
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
                MessageBox.Show("Ha introducido un valor invalido o el numero de identificacion ya existe o no hay ficas o razas registradas." +
                    " Por favor, vuelva a intentarlo.");
            }//fin catch
        }//fin buttonRegistrar_Click

        /*
         * este metodo se encarga de dejar la interfaza en su estado inicial
         */
        public void EstadoInicial()
        {
            this.maskedTextBoxIdentificacion.ResetText();
            this.textBoxNombre.ResetText();
            this.comboBoxFincas.SelectedIndex = 0;
            this.comboBoxRazas.SelectedIndex = 0;
            this.maskedTextBoxFechaNacimiento.ResetText();
            this.comboBoxSexos.SelectedIndex = 0;
            this.textBoxMadre.ResetText();
            this.textBoxPadre.ResetText();
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

        /*
         * este metodo se encarga de llenar el comboboxRazas con los objetos raza registrados en sistema
         */
        public void LlenarComboBoxRazas()
        {
            if (ControladorFRMRaza.miListaRaza != null)
            {
                //llenar combobox con identificacion de la raza
                for (int i = 0; i < ControladorFRMRaza.miListaRaza.Count; i++)
                {
                    this.comboBoxRazas.Items.Add(ControladorFRMRaza.miListaRaza.ElementAt(i).CodigoRaza + "");
                }//fin for
            }//fin if
        }//fin LlenarComboBoxFincas

    }//fin clase FRMAnimal
}
