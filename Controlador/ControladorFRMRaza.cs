using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ProyectoMiFinca
{
    /*
     * esta clase se encarga de controlar las funciones entre la vista y los formularios
     * de raza
     */
    class ControladorFRMRaza
    {
        //atributos y referencias
        static int posicion;
        static ObjetoRaza miObjetoRaza;
        public static List<ObjetoRaza> miListaRaza;
        public ConexionServidorBBDD cadenaConexion = new ConexionServidorBBDD();

        //constructor
        public ControladorFRMRaza()
        {
            miListaRaza = new List<ObjetoRaza>();
        }//fin constructor

        //metodos
        /*
         * este metodo se encarga de registrar objeto raza
         */
        public string RegistrarRaza(ObjetoRaza miObjetoRaza)
        {
            string salida = "";
            if (BuscarCodigoRaza(miObjetoRaza.CodigoRaza))
            {
                salida = "Ya existe un registro con ese mismo codigo. Por favor" +
                    " vuelva a intentarlo.";
            }//fin if
            else
            {
                SqlCommand comando = new SqlCommand();
                string sentencia = " Insert	Into Raza (Id_Raza, Descripcion)" +
                    " Values (@Id_Raza, @Descripcion)";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = cadenaConexion.conexion;
                comando.Parameters.AddWithValue("@Id_Raza", miObjetoRaza.CodigoRaza);
                comando.Parameters.AddWithValue("@Descripcion", miObjetoRaza.DescripcionRaza);

                //abrir conexion
                cadenaConexion.abrir();
                comando.ExecuteNonQuery();
                //cerrar conexion
                cadenaConexion.cerrar();
                salida = "Se agrego la raza correctamente";
            }//fin else

            return salida;
        }//fin RegistrarRaza

        /*
         * este metodo se encarga de devolver una lista de razas
         */
        public List<ObjetoRaza> ObtenerMiLista()
        {
            //cargar miListaFinca desde base de datos
            SqlCommand comando = new SqlCommand();
            string sentencia = " Select Id_Raza, Descripcion From Raza ";
            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = cadenaConexion.conexion;
            //abrir conexion
            cadenaConexion.abrir();
            SqlDataReader lectorDatos = comando.ExecuteReader();
            if (lectorDatos.HasRows == true)
            {
                while (lectorDatos.Read())
                {
                    miListaRaza.Add(new ObjetoRaza
                    {
                        CodigoRaza = Convert.ToInt32(lectorDatos["Id_Raza"].ToString()),
                        DescripcionRaza = lectorDatos["Descripcion"].ToString()
                    });
                }//fin while
            }//fin if
            //cerrar conexion
            cadenaConexion.cerrar();

            return miListaRaza;

        }//fin ObtenerMiLista

        /*
         * BuscarCodigoRaza = se encarga de verificar si existe o no un objeto raza en 
         * el registro
         */
        public bool BuscarCodigoRaza(int codigoRaza)
        {

            bool encontrado = false;

            for (int i = 0; i < miListaRaza.Count; i++)
            {
                if (miListaRaza.ElementAt(i).CodigoRaza.Equals(codigoRaza))
                {
                    encontrado = true;
                    miObjetoRaza = miListaRaza.ElementAt(index: codigoRaza);//objetoRaza
                    posicion = i;
                }//fin if verdad
            }//fin

            return encontrado;

        }//fin BuscarCodigoRaza
        /*
         * GetObjetoRaza = devuelve un objeto Raza con sus valores respectivos
         */
        public ObjetoRaza GetObjetoRaza(int codigoRaza, string descripcionRaza)
        {
            miObjetoRaza = new ObjetoRaza(codigoRaza, descripcionRaza);
            return miObjetoRaza;
        }//fin GetObjetoRaza

        /*
         * este metodo se encarga de buscar un objeto raza en especifico y devolverlo
         */
        public ObjetoRaza BuscarRaza(int identificacion)
        {
            ObjetoRaza miObjetoRaza = null;
            for (int i = 0; i < ControladorFRMRaza.miListaRaza.Count; i++)
            {
                if (ControladorFRMRaza.miListaRaza.ElementAt(i).Equals(identificacion))
                {
                    miObjetoRaza = ControladorFRMRaza.miListaRaza.ElementAt(i);
                }//fin if
            }//fin for

            return miObjetoRaza;

        }//fin BuscarRaza

    }//fin clase ControladorFRMRaza
}
