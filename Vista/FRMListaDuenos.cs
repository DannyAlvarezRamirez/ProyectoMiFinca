using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroganaderaMiFincaGui
{
    /*
     * esta clase se encarga de desplegar los registros de duenos
     */
    public partial class FRMListaDuenos : Form
    {
        public FRMListaDuenos()
        {
            InitializeComponent();
            LlenarDataGridViewDuenos();
        }//fin constructor

        //metodos
        /*
         * LlenarDataGridViewDuenos = este metodo se encarga de llenar el dataGridViewDuenos
         * con sus respectivos registros de duenos
         */
        public void LlenarDataGridViewDuenos()
        {
            try
            {
                this.dataGridViewDuenos.DataSource = ControladorFRMDueno.miListaDueno;
            }//fin try
            catch (Exception ex)
            {
                MessageBox.Show("Aun no hay duenos y/o fincas registradas.");
            }//fin catch
        }//fin LlenarDataGridViewDuenos

        /*
         * este metodo se encarga de esconder el formulario actual
         */
        private void FRMListaDuenos_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
        }//fin FRMListaDuenos_Load

        /*
         * este metodo se encarga de esconder el formulario actual 
         */
        private void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }//fin cerrarFormulario

    }//fin clase FRMListaDuenos
}
