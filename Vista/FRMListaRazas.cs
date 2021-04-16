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
     * esta clase se encarga de desplegar los registros de razas
     */
    public partial class FRMListaRazas : Form
    {
        //atributos y referencias
        ControladorFRMRaza miControladorFRMRaza;
        public FRMListaRazas()
        {
            InitializeComponent();
            LlenarDataGridViewRazas();
        }//fin constructor

        //metodos
        /*
         * LlenarDataGridViewRazas = este metodo se encarga de llenar el LlenarDataGridViewRazas
         * con sus respectivos registros de razas
         */
        public void LlenarDataGridViewRazas()
        {
            try
            {
                this.dataGridViewRazas.DataSource = miControladorFRMRaza.ObtenerMiLista();
            }//fin try
            catch (Exception ex)
            {
                MessageBox.Show("Aun no hay razas registradas.");
            }//fin catch
        }//fin LlenarDataGridViewRazas
        /*
         * este metodo se encarga de esconder el formulario actual
         */
        private void FRMListaRazas_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
        }//fin FRMListaRazas_Load

        /*
         * este metodo se encarga de esconder el formulario actual 
         */
        private void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }//fin cerrarFormulario

    }//fin clase FRMListaRazas
}
