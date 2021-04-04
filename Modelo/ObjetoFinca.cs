using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgroganaderaMiFincaGui
{
    /*
     * esta clase es un modelo u objeto de Finca con sus parametros y metodos especificos
     */
    class ObjetoFinca
    {
        //atributos
        private int intNumeroFinca, intTelefonoFinca;
        private string strNombreFinca, strDireccionFinca;
        private double dbTamanoFinca;

        ////constructores
        public ObjetoFinca(int numeroFinca, string nombreFinca, string direccionFinca, int telefonoFinca, double tamanoFinca)
        {
            this.intNumeroFinca = numeroFinca;
            this.strNombreFinca = nombreFinca;
            this.strDireccionFinca = direccionFinca;
            this.intTelefonoFinca = telefonoFinca;
            this.dbTamanoFinca = tamanoFinca;
        }//fin constructor con parametros

        //parametros
        //NumeroFinca
        public int NumeroFinca
        {
            set
            {
                this.intNumeroFinca = value;
            }
            get
            {
                return this.intNumeroFinca;
            }
        }//fin NumeroFinca
        //NombreFinca
        public string NombreFinca
        {
            set
            {
                this.strNombreFinca = value;
            }
            get
            {
                return this.strNombreFinca;
            }
        }//fin NombreFinca
        //DireccionFinca
        public string DireccionFinca
        {
            set
            {
                this.strDireccionFinca = value;
            }
            get
            {
                return this.strDireccionFinca;
            }
        }//fin DireccionFinca
        //TelefonoFinca
        public int TelefonoFinca
        {
            set
            {
                this.intTelefonoFinca  = value;
            }
            get
            {
                return this.intTelefonoFinca;
            }
        }//fin TelefonoFinca
        //TamanoFinca
        public double TamanoFinca
        {
            set
            {
                this.dbTamanoFinca = value;
            }
            get
            {
                return this.dbTamanoFinca;
            }
        }//fin TamanoFinca
        //GetInformacionObjetoFinca
        public string GetInformacionObjetoFinca()
        {
            return "Información de la finca*\nNumero = " + this.NumeroFinca + ", Nombre = " + this.NombreFinca + ", " +
                "Direccion = " + this.DireccionFinca + ", Telefono = " + this.TelefonoFinca + ", Tamano = " +
                this.TamanoFinca;
        }//fin GetInformacionObjetoFinca
    }//fin clase ObjetoFinca
}
