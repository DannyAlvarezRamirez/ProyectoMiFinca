using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace AgroganaderaMiFincaGui
{
    class ObjetoAnimal
    {
        //atributos
        private int intIdentificacionAnimal, strMadreAnimal, strPadreAnimal;
        private string strSexoAnimal, strNombreAnimal, strFechaNacimientoAnimal;
        private ObjetoFinca objFincaAnimal;
        private ObjetoRaza objRazaAnimal;

        //constructores
        public ObjetoAnimal()
        {
            this.intIdentificacionAnimal = 0;
            this.strSexoAnimal = "";
            this.strMadreAnimal = 0;
            this.strPadreAnimal = 0;
            this.strNombreAnimal = "";
            this.strFechaNacimientoAnimal = "";
            this.objFincaAnimal = null;
            this.objRazaAnimal = null;
        }//fin construcor sin parametros
        public ObjetoAnimal(int identificacionAnimal, string sexoAnimal, int madreAnimal, int padreAnimal, string nombreAnimal,
            string fechaNacimientoAnimal, ObjetoFinca objFincaAnimal, ObjetoRaza objRazaAnimal)
        {
            this.intIdentificacionAnimal = identificacionAnimal;
            this.strSexoAnimal = sexoAnimal;
            this.strMadreAnimal = madreAnimal;
            this.strPadreAnimal = padreAnimal;
            this.strNombreAnimal =nombreAnimal;
            this.strFechaNacimientoAnimal = fechaNacimientoAnimal;
            this.objFincaAnimal = objFincaAnimal;
            this.objRazaAnimal = objRazaAnimal;
        }//fin construcor con parametros

        //parametros
        //IdentificacionAnimal
        public int IdentificacionAnimal
        {
            set
            {
                this.intIdentificacionAnimal = value;
            }
            get
            {
                return this.intIdentificacionAnimal;
            }
        }//fin IdentificacionAnimal
        //SexoAnimal
        public string SexoAnimal
        {
            set
            {
                this.strSexoAnimal = value;
            }
            get
            {
                return this.strSexoAnimal;
            }
        }//fin SexoAnimal
        //MadreAnimal
        public int MadreAnimal
        {
            set
            {
                this.strMadreAnimal = value;
            }
            get
            {
                return this.strMadreAnimal;
            }
        }//fin MadreAnimal
        //PadreAnimal
        public int PadreAnimal
        {
            set
            {
                this.strPadreAnimal = value;
            }
            get
            {
                return this.strPadreAnimal;
            }
        }//fin PadreAnimal
        //NombreAnimal
        public string NombreAnimal
        {
            set
            {
                this.strNombreAnimal = value;
            }
            get
            {
                return this.strNombreAnimal;
            }
        }//fin NombreAnimal
        //FechaNacimientoAnimal
        public string FechaNacimientoAnimal
        {
            set
            {
                this.strFechaNacimientoAnimal = value;
            }
            get
            {
                return this.strFechaNacimientoAnimal;
            }
        }//fin FechaNacimientoAnimal
        //ObjetoFincaAnimal
        public ObjetoFinca ObjetoFincaAnimal
        {
            set
            {
                this.objFincaAnimal = value;
            }
            get
            {
                return this.objFincaAnimal;
            }
        }//fin ObjetoFincaAnimal
        //ObjetoRazaAnimal
        public ObjetoRaza ObjetoRazaAnimal
        {
            set
            {
                this.objRazaAnimal = value;
            }
            get
            {
                return this.objRazaAnimal;
            }
        }//fin ObjetoRazaAnimal
        //GetInformacionObjetoAnimal
        public string GetInformacionObjetoAnimal()
        {
            return "Información del animal*\nIdentificacion = " + this.IdentificacionAnimal + ", Sexo = " + this.SexoAnimal + ", " +
                "Madre = " + this.MadreAnimal + ", Padre = " + this.PadreAnimal + ", Nombre = " + this.NombreAnimal +
                ", Fecha Nacimiento = " + this.FechaNacimientoAnimal + ", Nombre de la Finca = " + this.objFincaAnimal.NombreFinca +
                ", Raza = " + this.objRazaAnimal.DescripcionRaza;
        }//fin GetInformacionObjetoAnimal
    }
}
