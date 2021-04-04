﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgroganaderaMiFincaGui
{
    /*
     * esta clase se encarga de desplegar los registros de duenos
     */
    public partial class FRMListaAnimales : Form
    {
        public FRMListaAnimales()
        {
            InitializeComponent();
            LlenarDataGridViewAnimales();
        }//fin constructor

        //metodos
        /*
         * LlenarDataGridViewAnimales = este metodo se encarga de llenar el dataGridViewAnimales
         * con sus respectivos registros de animales
         */
        public void LlenarDataGridViewAnimales()
        {
            try
            {
                this.dataGridViewAnimales.DataSource = ControladorFRMAnimal.miListaAnimal;
            }//fin try
            catch (Exception ex)
            {
                MessageBox.Show("Aun no hay razas y/o fincas registradas.");
            }//fin catch
        }//fin LlenarDataGridViewAnimales

        /*
         * este metodo se encarga de esconder el formulario actual
         */
        private void FRMListaAnimales_Load(object sender, EventArgs e)
        {
            this.FormClosed += new FormClosedEventHandler(cerrarFormulario);
        }//fin FRMListaAnimales_Load

        /*
         * este metodo se encarga de esconder el formulario actual 
         */
        private void cerrarFormulario(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }//fin cerrarFormulario

    }//fin clase FRMListaAnimales
}
