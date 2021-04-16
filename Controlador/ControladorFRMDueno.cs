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
     * de dueno
     */
    class ControladorFRMDueno
    {
        //atributos y referencias
        public ObjetoDueno miObjetoDueno;
        public static List<ObjetoDueno> miListaDueno;
        public ConexionServidorBBDD cadenaConexion = new ConexionServidorBBDD();
        ControladorFRMFinca miControladorFRMFinca;

        //constructor
        public ControladorFRMDueno()
        {
            miListaDueno = new List<ObjetoDueno>();
            miControladorFRMFinca = new ControladorFRMFinca();
        }//fin constructor

        //metodos
        /*
         * este metodo se encarga de registrar objeto dueno
         */
        public string RegistrarDueno(ObjetoDueno miObjetoDueno)
        {
            string salida = "";
            if (BuscarIdentificacionPersona(miObjetoDueno.IdentificacionPersona))
            {
                salida = "Ya existe un registro con ese mismo numero de identificacion. Por favor" +
                    " vuelva a intentarlo.";
            }//fin if
            else
            {
                SqlCommand comando = new SqlCommand();
                string sentencia = " Insert	Into Duenno (Identificacion, Nombre, Primer_Apellido, " +
                    "Segundo_Apellido, Correo_Electronico, Telefono_Celular, Id_Finca)" +
                    " Values (@Identificacion, @Nombre, @Primer_Apellido, @Segundo_Apellido,	" +
                    "@Correo_Electronico, @Telefono_Celular, @Id_Finca)";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = cadenaConexion.conexion;
                comando.Parameters.AddWithValue("@Identificacion", miObjetoDueno.IdentificacionPersona);
                comando.Parameters.AddWithValue("@Nombre", miObjetoDueno.NombrePersona);
                comando.Parameters.AddWithValue("@Primer_Apellido", miObjetoDueno.PrimerApellidoPersona);
                comando.Parameters.AddWithValue("@Segundo_Apellido", miObjetoDueno.SegunoApellidoPersona);
                comando.Parameters.AddWithValue("@Correo_Electronico", miObjetoDueno.CorreoElectronicoDueno);
                comando.Parameters.AddWithValue("@Telefono_Celular", miObjetoDueno.NumeroCelularDueno);
                comando.Parameters.AddWithValue("@Id_Finca", miObjetoDueno.FincaDueno.NumeroFinca);

                //abrir conexion
                cadenaConexion.abrir();
                comando.ExecuteNonQuery();
                //cerrar conexion
                cadenaConexion.cerrar();
                salida = "Se agrego el dueno correctamente";
            }//fin else

            return salida;
        }//fin RegistrarDueno

        /*
         * BuscarIdentificacionPersona = se encarga de verificar si existe o no un objeto dueno en 
         * el registro
         */
        public bool BuscarIdentificacionPersona(int identificacionDueno)
        {

            bool encontrado = false;

            for (int i = 0; i < miListaDueno.Count; i++)
            {
                if (miListaDueno.ElementAt(i).IdentificacionPersona.Equals(identificacionDueno))
                {
                    encontrado = true;
                }//fin if verdad
            }//fin

            return encontrado;

        }//fin BuscarIdentificacionPersona

        /*
         * este metodo se encarga de devolver una lista de duenos
         */
        public List<ObjetoDueno> ObtenerMiLista()
        {
            //cargar miListaFinca desde base de datos
            SqlCommand comando = new SqlCommand();
            string sentencia = " Select Identificacion, Nombre, Primer_Apellido, " +
                    "Segundo_Apellido, Correo_Electronico, Telefono_Celular, Id_Finca From Duenno ";
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
                    miListaDueno.Add(new ObjetoDueno
                    {
                        IdentificacionPersona = Convert.ToInt32(lectorDatos["Identificacion"].ToString()),
                        NombrePersona = lectorDatos["Nombre"].ToString(),
                        PrimerApellidoPersona = lectorDatos["Primer_Apellido"].ToString(),
                        SegunoApellidoPersona = lectorDatos["Segundo_Apellido"].ToString(),
                        CorreoElectronicoDueno = lectorDatos["Correo_Electronico"].ToString(),
                        NumeroCelularDueno = Convert.ToInt32(lectorDatos["Telefono_Celular"].ToString()),
                        FincaDueno = miControladorFRMFinca.BuscarFinca(Convert.ToInt32(lectorDatos["Id_Finca"].ToString()))
                    });
                }//fin while
            }//fin if
            //cerrar conexion
            cadenaConexion.cerrar();

            return miListaDueno;

        }//fin ObtenerMiLista

        /*
         * GetObjetoDueno = devuelve un objeto Dueno con sus valores respectivos
         */
        public ObjetoDueno GetObjetoDueno(int identificacionPersona, string nombrePersona, string primerApellido, string segundoApellido,
            string correoElectronico, int numeroCelular, ObjetoFinca objetoFinca)
        {
            miObjetoDueno = new ObjetoDueno(identificacionPersona, nombrePersona, primerApellido, segundoApellido,
                correoElectronico, numeroCelular, objetoFinca);
            return miObjetoDueno;
        }//fin GetLlenarObjetoDueno

        /*
         * este metodo se encarga de buscar un objeto finca en especifico y devolverlo
         */
        public ObjetoFinca BuscarFinca(int numeroFinca)
        {
            ObjetoFinca miObjetoFinca = null;
            for (int i = 0; i < ControladorFRMFinca.miListaFinca.Count; i++)
            {
                if (ControladorFRMFinca.miListaFinca.ElementAt(i).Equals(numeroFinca))
                {
                    miObjetoFinca = ControladorFRMFinca.miListaFinca.ElementAt(i);
                }//fin if
            }//fin for

            return miObjetoFinca;

        }//fin BuscarFinca

    }//fin clase ControladorFRMDueno
}
