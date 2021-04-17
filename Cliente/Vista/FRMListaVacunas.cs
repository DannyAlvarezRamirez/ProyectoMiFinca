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
     * esta clase se encarga de desplegar los registros de vacunas
     */
    public partial class FRMListaVacunas : Form
    {
        //atributos y referencias
        ControladorFRMVacuna miControladorFRMVacuna;

        public FRMListaVacunas()
        {
            InitializeComponent();
            miControladorFRMVacuna = new ControladorFRMVacuna();
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
                this.dataGridViewVacunas.DataSource = miControladorFRMVacuna.ObtenerMiLista();
            }//fin try
            catch (Exception ex)
            {
                MessageBox.Show("Aun no hay vacunas registradas.");
            }//fin catch
        }//fin LlenarDataGridViewVacunas
        /*
         * este metodo se encarga de esconder el formulario actual
         */
        private void FRMListaVacunas_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
        }//fin FRMListaVacunas_Load

        /*
         * este metodo se encarga de esconder el formulario actual 
         */
        private void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }//fin cerrarFormulario
    }//fin clase FRMListaVacunas
}
