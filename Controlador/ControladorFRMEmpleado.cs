using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoMiFinca
{
    /*
     * esta clase se encarga de controlar las funciones entre la vista y los formularios
     * de empleado
     */
    static class ControladorFRMEmpleado
    {
        //atributos y referencias
        static int posicion;
        static ObjetoEmpleado miObjetoEmpleado;
        public static List<ObjetoEmpleado> miListaEmpleado = new List<ObjetoEmpleado>();

        //metodos
        /*
         * este metodo se encarga de registrar objeto empleado
         */
        public static string RegistrarEmpleado(ObjetoEmpleado objetoEmpleado)
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
         * BuscarIdentificacionPersona = se encarga de verificar si existe o no un objeto empleado en 
         * el registro
         */
        public static bool BuscarIdentificacionPersona(int identificacionEmpleado)
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
        public static ObjetoEmpleado GetObjetoEmpleado(int identificacionPersona, string nombrePersona, string primerApellido, string segundoApellido,
            double salarioEmpleado)
        {
            miObjetoEmpleado = new ObjetoEmpleado(identificacionPersona, nombrePersona, primerApellido, segundoApellido,
                salarioEmpleado);
            return miObjetoEmpleado;
        }//fin GetLlenarObjetoEmpleado

    }//fin clase ControladorFRMEmpleado
}
