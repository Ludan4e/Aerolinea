using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aerolinea
{
    public partial class ServicioAdicionalAgregar : Form
    {
        #region Variables
        Controles elControl = new Controles();
        bool validar = false;
        string strNombreServicio;
        string strDescripcionServicio;
        string strPrecio;
        #endregion

        public ServicioAdicionalAgregar()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            validar = false;
            if (validar = elControl.vldCampoVacio("Nombre Servicio", textAgregarNombre.Text))
            { strNombreServicio = textAgregarNombre.Text; }
            if (validar = elControl.vldCampoVacio("Precio", textPrecio.Text))
            { strPrecio = textPrecio.Text; }
            if (validar = elControl.vldCampoVacio("Descripción Servicio", textDescripcion.Text))
                strDescripcionServicio = textDescripcion.Text;
            if (validar == false)
                //Si algún campo esta vacio no se guarda.
                return;
            else
            {
                //Aqui va el metodo de inserción de datos.
                pServiciosAdicionales p = new pServiciosAdicionales();
                p.NOMBRE = strNombreServicio;
                p.DESCRIPCION = strDescripcionServicio;
                p.PRECIO = strPrecio;
                new mServiciosAdicionales().Agregar(p);
                this.Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Al cancelar no se guardaran los \ncambios realizados?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                this.Close();
        }
    }
}
