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
     * esta clase se encarga de desplegar los registros de tratamientos
     */
    public partial class FRMListaTratamientoAnimales : Form
    {
        //atributos y referencias
        ControladorTratamientoAnimal miControladorFRMTratamientoAnimal;

        public FRMListaTratamientoAnimales()
        {
            InitializeComponent();
            miControladorFRMTratamientoAnimal = new ControladorTratamientoAnimal();
            LlenarDataGridViewTratamientos();
        }//fin constructor

        //metodos
        /*
         * LlenarDataGridViewTratamientos = este metodo se encarga de llenar el LlenarDataGridViewTratamientos
         * con sus respectivos registros de tratamientos
         */
        public void LlenarDataGridViewTratamientos()
        {
            try
            {
                this.dataGridViewTratamientoAnimales.DataSource = miControladorFRMTratamientoAnimal.ObtenerMiLista();
            }//fin try
            catch (Exception ex)
            {
                MessageBox.Show("Aun no hay tratamientos de animales registradas.");
            }//fin catch
        }//fin LlenarDataGridViewTratamientos
        /*
         * este metodo se encarga de esconder el formulario actual
         */
        private void FRMListaTratamientoAnimales_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
        }//fin FRMListaVacunasAnimales_Load

        /*
         * este metodo se encarga de esconder el formulario actual 
         */
        private void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }//fin cerrarFormulario
    }//fin clase FRMListaVacunas
}
