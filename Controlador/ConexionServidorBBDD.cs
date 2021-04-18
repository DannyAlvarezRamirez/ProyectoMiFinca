using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace ProyectoMiFinca
{
    public class ConexionServidorBBDD
    {
        //atributos, referencias, instancias
        //Cadena de Conexion
        public string cadena = "Data Source = LAPTOP-8OSCM6S2\\SQLEXPRESS; Initial Catalog = MIFINCA; Integrated Security = true";
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

        /*
         * este metodo se encarga de enviar una consulta a la base de datos
         */
        public void EnviarConsultaABaseDatos(string consulta)
        {
            try
            {
                //verificar que tipo de consulta es: insert o select
                if (esInsert(consulta) == true)
                {
                    SqlCommand comando = new SqlCommand();
                    string sentencia = consulta;
                    comando.CommandType = CommandType.Text;
                    comando.CommandText = sentencia;
                    comando.Connection = conexion;
                    abrir();
                    comando.ExecuteNonQuery();
                    cerrar();
                }//fin if insert
                else
                {
                    ObtenerListaDeBaseDeDatos(consulta); 
                }//fin else select
            }//fin try
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error en la conexion con la base de datos. " +
                    "\nDetalle del error: " + ex.Message);
            }//fin catch
        }//fin EnviarConsultaABaseDatos

        /*
         * este metodo se encarga de verificar si la consulta es insert o no
         */
        public bool esInsert(string consulta)
        {
            bool esVerdad = false;
            string palabra = "";
            //recorrer la cadena de string consulta
            for (int i = 0; i < 6;i++)
            {
                palabra += consulta[i];
            }//fin for
            //verificar si palabra es igual a "insert"
            if (palabra.ToLower().Equals("insert"))
            {
                esVerdad = true;
            }//fin if
            return esVerdad;
        }//fin esInsert

        /*
         * este metodo se encarga de devolver una lista generica
         */
        public List<Object> ObtenerListaDeBaseDeDatos(string consulta)
        {
            List<Object> miLista = null;
            //cargar miListaFinca desde base de datos
            SqlCommand comando = new SqlCommand();
            string sentencia = consulta;
            comando.CommandType = CommandType.Text;
            comando.CommandText = sentencia;
            comando.Connection = conexion;
            //abrir conexion
            abrir();
            SqlDataReader lectorDatos = comando.ExecuteReader();
            if (lectorDatos.HasRows == true)
            {
                while (lectorDatos.Read())
                {
                    if (tablaEsTipo(consulta) == "tramientos") {
                        miLista.Add(new ObjetoTratamientoAnimal
                        {
                            IdentificacionAnimal = Convert.ToInt32(lectorDatos["Id_animal"].ToString()),
                            Fecha = lectorDatos["Fec_tratamiento"].ToString(),
                            DiagnosticoAnimal = lectorDatos["Diagnostico"].ToString(),
                            MedicamentoAnimal = lectorDatos["Medicamento"].ToString(),
                            DiasTratamiento = Convert.ToInt32(lectorDatos["Dias_tratamiento"].ToString()),
                            ObservacionesAnimal = lectorDatos["Observaciones"].ToString()
                        });
                    }//fin if tratamiento
                    else if (tablaEsTipo(consulta) == "vacunas")
                    {
                        miLista.Add(new ObjetoVacunaAnimal
                        {
                            IdentificacionAnimal = Convert.ToInt32(lectorDatos["Id_animal"].ToString()),
                            IdentificacionVacuna = Convert.ToInt32(lectorDatos["Id_vacuna"].ToString()),
                            FechaNacimientoAnimal = lectorDatos["Fec_vacuna"].ToString(),
                            EnfermedadAnimal = lectorDatos["Enfermedad"].ToString(),
                            ObservacionesAnimal = lectorDatos["Observaciones"].ToString()
                        });
                    }//fin else if vacuna
                    else
                    {
                        miLista.Add(new ObjetoEmpleado
                        {
                            IdentificacionPersona = Convert.ToInt32(lectorDatos["Identificacion"].ToString()),
                            NombrePersona = lectorDatos["Nombre"].ToString(),
                            PrimerApellidoPersona = lectorDatos["Primer_Apellido"].ToString(),
                            SegunoApellidoPersona = lectorDatos["Segundo_Apellido"].ToString(),
                            SalarioEmpleado = Convert.ToInt32(lectorDatos["Salario"].ToString()),
                            UsuarioEmpleado = lectorDatos["Usuario"].ToString(),
                            UsuarioContrasena = lectorDatos["Contrasena"].ToString(),
                            EstadoUsuario = Convert.ToInt32(lectorDatos["Estado"].ToString()),
                        });
                    }//fin else empleado
                }//fin while
            }//fin if
            //cerrar conexion
            cerrar();
            return miLista;
        }//fin ObtenerListaDeBaseDeDatos

        /*
         * este metodo se encarga de verificar a que tabla se hace la consulta: tratamiento, empleado o vacuna
         */
        public string tablaEsTipo(string consulta)
        {
            string tipoTabla = "";
            string palabra = "";
            string cadena = Invertir(consulta);//invertimos el string
            //recorremos la cadena caracteres
            for (int i = 0; i < 9; i++)
            {
                cadena += consulta[i];
            }//fin for
            //asignamos el valor a tipoTabla y comparamos, invertimos el string, quitamos espacios y colocamos todo en minuscula
            tipoTabla = Invertir(cadena).Trim();
            if (tipoTabla.ToLower().Equals("tramientos"))
            {
                palabra = "tramientos";
            }//fin if tramientos
            else if (tipoTabla.ToLower().Equals("empleado"))
            {
                palabra = "empleado";
            }//fin else if empleado
            else
            {
                palabra = "vacunas";
            }//fin else vacunas

            return palabra;
        }//fin tablaEsTipo
        
        /*
         * este metodo se encarga de invertir una cadena de caracteres o string
         */
        public string Invertir(string cadena)
        {
            // Convertir a arreglo
            char[] cadenaComoCaracteres = cadena.ToCharArray();
            // Invertir el arreglo 
            Array.Reverse(cadenaComoCaracteres);
            // Convertir de nuevo el arreglo a cadena de caracteres o string
            return new string(cadenaComoCaracteres);
        }//fin Invertir

    }//fin clase ConexionServidorBBDD
}
