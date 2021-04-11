using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoMiFinca
{
    class ObjetoEmpleado: ObjetoPersona
    {
        //atributos
        private double dbSalarioEmpleado;
        private string strUsuario, strContrasena;
        private int intEstado;

        public ObjetoEmpleado(int identificacionPersona, string nombrePersona, string primerApellido, string segundoApellido, 
            double salarioEmpleado, string usuario, string contrasena, int estado)
            :base(identificacionPersona, nombrePersona, primerApellido, segundoApellido)
        {
            this.dbSalarioEmpleado = salarioEmpleado;
            this.strUsuario = usuario;
            this.strContrasena = contrasena;
            this.intEstado = estado;
        }//fin constructor con parametros

        //parametros
        //SalarioEmpleado
        public double SalarioEmpleado
        {
            set
            {
                this.dbSalarioEmpleado = value;
            }
            get
            {
                return this.dbSalarioEmpleado;
            }
        }//fin SalarioEmpleado

        //UsuarioEmpleado
        public string UsuarioEmpleado
        {
            set
            {
                this.strUsuario = value;
            }
            get
            {
                return this.strUsuario;
            }
        }//fin UsuarioEmpleado

        //UsuarioContrasena
        public string UsuarioContrasena
        {
            set
            {
                this.strContrasena = value;
            }
            get
            {
                return this.strContrasena;
            }
        }//fin UsuarioContrasena

        //EstadoUsuario
        public int EstadoUsuario
        {
            set
            {
                this.intEstado = value;
            }
            get
            {
                return this.intEstado;
            }
        }//fin EstadoUsuario

        //GetInformacionObjetoEmpleado
        public string GetInformacionObjetoEmpleado()
        {
            return "Información del empleado*\nIdentificacion = " + this.IdentificacionPersona + ", Nombre = " + this.NombrePersona + ", " +
                "Primer Apellido = " + this.PrimerApellidoPersona + ", Segundo Apellido = " + this.SegunoApellidoPersona + ", Salario = " + this.SalarioEmpleado +
                ", Usuario = " + this.UsuarioEmpleado + ", Contrasena = " + this.UsuarioContrasena + ", Estado = " + this.EstadoUsuario;
        }//fin GetInformacionObjetoEmpleado
    }
}
