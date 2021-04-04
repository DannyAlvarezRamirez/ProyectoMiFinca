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
     * esta clase se encarga de desplegar los registros de empleados
     */
    public partial class FRMListaEmpleados : Form
    {
        public FRMListaEmpleados()
        {
            InitializeComponent();
            LlenarDataGridViewEmpleados();
        }//fin constructor

        //metodos
        /*
         * LlenarDataGridViewEmpleados = este metodo se encarga de llenar el dataGridViewEmpleados
         */
        public void LlenarDataGridViewEmpleados()
        {
            try
            {
                this.dataGridViewEmpleados.DataSource = ControladorFRMEmpleado.miListaEmpleado;
            }//fin try
            catch (Exception ex)
            {
                MessageBox.Show("Aun no hay empleados registrados.");
            }//fin catch
        }//fin LlenarDataGridViewEmpleados

        /*
         * este metodo se encarga de esconder el formulario actual
         */
        private void FRMListaEmpleados_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
        }//fin FRMListaEmpleados_Load

        /*
         * este metodo se encarga de esconder el formulario actual 
         */
        private void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }//fin cerrarFormulario

    }//fin clase FRMListaEmpleados
}
