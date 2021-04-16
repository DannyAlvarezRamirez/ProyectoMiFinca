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
     * esta clase se encarga de desplegar los registros de vacunas
     */
    public partial class FRMListaVacunasAnimales : Form
    {
        //atributos y referencias
        ControladorVacunaAnimal miControladorFRMVacunaAnimal;

        public FRMListaVacunasAnimales()
        {
            InitializeComponent();
            miControladorFRMVacunaAnimal = new ControladorVacunaAnimal();
            LlenarDataGridViewVacunas();
        }//fin constructor

        //metodos
        /*
         * LlenarDataGridViewVacunas = este metodo se encarga de llenar el LlenarDataGridViewVacunas
         * con sus respectivos registros de vacunas
         */
        public void LlenarDataGridViewVacunas()
        {
            try
            {
                this.dataGridViewVacunasAnimales.DataSource = miControladorFRMVacunaAnimal.ObtenerMiLista();
            }//fin try
            catch (Exception ex)
            {
                MessageBox.Show("Aun no hay vacunas de animales registradas.");
            }//fin catch
        }//fin LlenarDataGridViewVacunas
        /*
         * este metodo se encarga de esconder el formulario actual
         */
        private void FRMListaVacunasAnimales_Load(object sender, EventArgs e)
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
