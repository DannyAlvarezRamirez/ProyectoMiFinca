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
     * de vacuna
     */
    class ControladorFRMVacuna
    {
        //atributos y referencias
        public int posicion;
        public ObjetoVacunas miObjetoVacunas;
        public static List<ObjetoVacunas> miListaVacunas;

        //constructor
        public ControladorFRMVacuna()
        {
            miListaVacunas = new List<ObjetoVacunas>();
        }//fin constructor

        //metodos
        /*
         * este metodo se encarga de registrar objeto vacunas
         */
        public string RegistrarVacuna(ObjetoVacunas miObjetoVacunas)
        {
            string salida = "";
            if (BuscarIdentificacionVacuna(miObjetoVacunas.IdentificacionVacuna))
            {
                salida = "Ya existe un registro con ese mismo numero de identificacion. Por favor" +
                    " vuelva a intentarlo.";
            }//fin if 
            else
            {
                miListaVacunas.Add(miObjetoVacunas);
                salida = "Se agrego la vacuna correctamente";

            }//fin else 
            return salida;
        }//fin RegistrarVacuna

        /*
         * este metodo se encarga de devolver una lista de vacunas
         */
        public List<ObjetoVacunas> ObtenerMiLista()
        {
            return miListaVacunas;
        }//fin ObtenerMiLista

        /*
         * BuscarIdentificacionVacuna = se encarga de verificar si existe o no un objeto vacuna en 
         * el registro
         */
        public bool BuscarIdentificacionVacuna(int identificacionVacuna)
        {

            bool encontrado = false;

            for (int i = 0; i < miListaVacunas.Count; i++)
            {
                if (miListaVacunas.ElementAt(i).IdentificacionVacuna.Equals(identificacionVacuna))
                {
                    encontrado = true;
                    miObjetoVacunas = miListaVacunas.ElementAt(index: identificacionVacuna);//objetoVacuna
                    posicion = i;
                }//fin if verdad
            }//fin

            return encontrado;

        }//fin BuscarIdentificacionVacuna
        /*
         * GetObjetoVacuna = devuelve un objeto Vacuna con sus valores respectivos
         */
        public ObjetoVacunas GetObjetoVacuna(int identificacionVacuna, string descripcionVacuna)
        {
            miObjetoVacunas = new ObjetoVacunas(identificacionVacuna, descripcionVacuna);
            return miObjetoVacunas;
        }//fin GetObjetoVacuna

        /*
         * este metodo se encarga de buscar un objeto vacuna en especifico y devolverlo
         */
        public ObjetoVacunas BuscarVacuna(int identificacion)
        {
            ObjetoVacunas miObjetoVacunas = null;
            for (int i = 0; i < ControladorFRMVacuna.miListaVacunas.Count; i++)
            {
                if (ControladorFRMVacuna.miListaVacunas.ElementAt(i).Equals(identificacion))
                {
                    miObjetoVacunas = ControladorFRMVacuna.miListaVacunas.ElementAt(i);
                }//fin if
            }//fin for

            return miObjetoVacunas;

        }//fin BuscarVacuna
    }//fin clase ControladorFRMVacuna
}
