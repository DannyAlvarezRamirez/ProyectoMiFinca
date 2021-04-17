using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Cliente
{
    class ObjetoVacunas
    {
        //atributos
        private int intIdentificacionVacuna;
        private string strDescripcionVacuna;

        //constructores
        public ObjetoVacunas()
        {
            this.intIdentificacionVacuna = 0;
            this.strDescripcionVacuna = "";
        }//fin construcor sin parametros
        public ObjetoVacunas(int identificacionVacuna, string descripcionVacuna)
        {
            this.intIdentificacionVacuna = identificacionVacuna;
            this.strDescripcionVacuna = descripcionVacuna;
        }//fin construcor con parametros

        //parametros
        //IdentificacionVacuna
        public int IdentificacionVacuna
        {
            set
            {
                this.intIdentificacionVacuna = value;
            }
            get
            {
                return this.intIdentificacionVacuna;
            }
        }//fin IdentificacionVacuna
        //DescripcionVacuna
        public string DescripcionVacuna
        {
            set
            {
                this.strDescripcionVacuna = value;
            }
            get
            {
                return this.strDescripcionVacuna;
            }
        }//fin DescripcionVacuna

        //GetInformacionObjetoVacunas
        public string GetInformacionObjetoAnimal()
        {
            return "Información de vacuna animal*\nIdentificacion Vacuna = " 
                + this.IdentificacionVacuna +
                ", Descripcion vacuna = " + this.DescripcionVacuna;
        }//fin GetInformacionObjetoVacunas
    }
}
