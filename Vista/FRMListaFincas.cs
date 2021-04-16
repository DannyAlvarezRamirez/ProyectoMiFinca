using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoMiFinca
{
    /*
     * esta clase se encarga de desplegar los registros de fincas
     */
    public partial class FRMListaFincas : Form
    {
        //atributos y referencias
        ControladorFRMFinca miControladorFRMFinca;

        public FRMListaFincas()
        {
            InitializeComponent();
            miControladorFRMFinca = new ControladorFRMFinca();
            LlenarDataGridViewFincas();
        }//fin constructor

        //metodos
        /*
         * LlenarDataGridViewFincas = este metodo se encarga de llenar el dataGridViewFincas
         * con sus respectivos registros de fincas
         */
        public void LlenarDataGridViewFincas()
        {
            try
            {
                this.dataGridViewFincas.DataSource = miControladorFRMFinca.ObtenerMiLista();
            }//fin try
            catch (Exception ex)
            {
                MessageBox.Show("Aun no hay fincas registradas." + ex.Message);
            }//fin catch
        }//fin LlenarDataGridViewFincas

        /*
         * este metodo se encarga de cesconder el formulario actual
         */
        private void FRMListaFincas_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
        }//fin FRMListaFincas_Load

        /*
         * este metodo se encarga de esconder el formulario actual
         */
        private void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }//fin cerrarFormulario
    }//fin clase FRMListaFincas
}
