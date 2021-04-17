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
     * de empleado
     */
    class ControladorFRMEmpleado
    {
        //atributos y referencias
        int posicion;
        static ObjetoEmpleado miObjetoEmpleado;
        public List<ObjetoEmpleado> miListaEmpleado;
        public ConexionServidorBBDD cadenaConexion = new ConexionServidorBBDD();

        //constructor
        public ControladorFRMEmpleado()
        {
            miListaEmpleado = new List<ObjetoEmpleado>();
        }//fin constructor
        //metodos
        /*
         * este metodo se encarga de registrar objeto empleado
         */
        public string RegistrarEmpleado(ObjetoEmpleado objetoEmpleado)
        {
            string salida = "";
            if (BuscarIdentificacionPersona(objetoEmpleado.IdentificacionPersona))
            {
                salida = "Ya existe un registro con ese mismo numero de identificacion. Por favor" +
                    " vuelva a intentarlo.";
            }//fin if
            else
            {
                SqlCommand comando = new SqlCommand();
                string sentencia = " Insert	Into Empleado (Identificacion, Nombre, Primer_Apellido, " +
                    "Segundo_Apellido, Salario, Usuario, Contrasena, Estado)" +
                    " Values (@Identificacion, @Nombre, @Primer_Apellido, " +
                    "@Segundo_Apellido,	@Salario, @Usuario, @Contrasena, @Estado)";

                comando.CommandType = CommandType.Text;
                comando.CommandText = sentencia;
                comando.Connection = cadenaConexion.conexion;
                comando.Parameters.AddWithValue("@Identificacion", miObjetoEmpleado.IdentificacionPersona);
                comando.Parameters.AddWithValue("@Nombre", miObjetoEmpleado.NombrePersona);
                comando.Parameters.AddWithValue("@Primer_Apellido", miObjetoEmpleado.PrimerApellidoPersona);
                comando.Parameters.AddWithValue("@Segundo_Apellido", miObjetoEmpleado.SegunoApellidoPersona);
                comando.Parameters.AddWithValue("@Salario", miObjetoEmpleado.SalarioEmpleado);
                comando.Parameters.AddWithValue("@Usuario", miObjetoEmpleado.UsuarioEmpleado);
                comando.Parameters.AddWithValue("@Contrasena", miObjetoEmpleado.UsuarioContrasena);
                comando.Parameters.AddWithValue("@Estado", miObjetoEmpleado.EstadoUsuario);

                //abrir conexion
                cadenaConexion.abrir();
                comando.ExecuteNonQuery();
                //cerrar conexion
                cadenaConexion.cerrar();
                salida = "Se agrego el empleado correctamente";
            }//fin else

            return salida;
        }//fin RegistrarEmpleado

        /*
         * este metodo se encarga de devolver una lista de empleados
         */
        public List<ObjetoEmpleado> ObtenerMiLista()
        {
            //cargar miListaFinca desde base de datos
            SqlCommand comando = new SqlCommand();
            string sentencia = " Select Identificacion, Nombre, Primer_Apellido, " +
                    "Segundo_Apellido, Salario, Usuario, Contrasena, Estado From Empleado ";
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
                    miListaEmpleado.Add(new ObjetoEmpleado
                    {
                        IdentificacionPersona = Convert.ToInt32(lectorDatos["Identificacion"].ToString()),
                        NombrePersona = lectorDatos["Nombre"].ToString(),
                        PrimerApellidoPersona = lectorDatos["Primer_Apellido"].ToString(),
                        SegunoApellidoPersona = lectorDatos["Segundo_Apellido"].ToString(),
                        SalarioEmpleado = Convert.ToInt32(lectorDatos["Salario"].ToString()),
                        UsuarioEmpleado = lectorDatos["Usuario"].ToString(),
                        UsuarioContrasena = lectorDatos["Contrasena"].ToString(),
                        EstadoUsuario = Convert.ToInt32(lectorDatos["Estado"].ToString())
                    });
                }//fin while
            }//fin if
            //cerrar conexion
            cadenaConexion.cerrar();

            return miListaEmpleado;

        }//fin ObtenerMiLista

        /*
         * BuscarIdentificacionPersona = se encarga de verificar si existe o no un objeto empleado en 
         * el registro
         */
        public bool BuscarIdentificacionPersona(int identificacionEmpleado)
        {

            bool encontrado = false;

            for (int i = 0; i < miListaEmpleado.Count; i++)
            {
                if (miListaEmpleado.ElementAt(i).IdentificacionPersona.Equals(identificacionEmpleado))
                {
                    encontrado = true;
                    miObjetoEmpleado = miListaEmpleado.ElementAt(index: identificacionEmpleado);//objetoEmpleado
                    posicion = i;
                }//fin if verdad
            }//fin

            return encontrado;

        }//fin BuscarIdentificacionPersona
        /*
         * GetObjetoEmpleado = devuelve un objeto Empleado con sus valores respectivos
         */
        public ObjetoEmpleado GetObjetoEmpleado(int identificacionPersona, string nombrePersona, string primerApellido, string segundoApellido,
            double salarioEmpleado, string usuario, string contrasena, int estado)
        {
            miObjetoEmpleado = new ObjetoEmpleado(identificacionPersona, nombrePersona, primerApellido, segundoApellido,
                salarioEmpleado, usuario, contrasena, estado);
            return miObjetoEmpleado;
        }//fin GetLlenarObjetoEmpleado

    }//fin clase ControladorFRMEmpleado
}
