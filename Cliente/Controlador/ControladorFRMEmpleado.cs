using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace Cliente
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
            if (BuscarIdentificacionPersona(miObjetoEmpleado.IdentificacionPersona))
            {
                salida = "Ya existe un registro con ese mismo numero de identificacion. Por favor" +
                    " vuelva a intentarlo.";
            }//fin if 
            else
            {
                miListaEmpleado.Add(miObjetoEmpleado);
                salida = "Se agrego el empleado correctamente";

            }//fin else 
            return salida;
        }//fin RegistrarEmpleado

        /*
         * este metodo se encarga de devolver una lista de empleados
         */
        public List<ObjetoEmpleado> ObtenerMiLista()
        {
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
