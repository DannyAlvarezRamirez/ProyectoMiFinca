using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoMiFinca
{
    class ConexionServidorBBDD
    {
        //atributos, referencias, instancias
        //Cadena de Conexion
        string cadena = "Data Source = LAPTOP-8OSCM6S2\\SQLEXPRESS; Initial Catalog = MIFINCA; Integrated Security = true";
        public SqlConnection conexion = new SqlConnection();

        //Constructor
        public ConexionServidorBBDD()
        {
            this.conexion.ConnectionString = cadena;
        }//fin constructor

        /*
         * Metodo para abrir la conexion
         */
        public void abrir()
        {
            try
            {
                this.conexion.Open();
                MessageBox.Show("Conectado!");
            }//fin try
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir BD.\nDetalle de error =" + ex.Message);
            }//fin catch
        }//fin abrir

        /*
         * Metodo para cerrar la conexion
         */
        public void cerrar()
        {
            this.conexion.Close();
        }//fin cerrar

    }//fin clase ConexionServidorBBDD
}
