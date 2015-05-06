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
    public partial class ServicioAdicionalEditar : Form
    {
        #region Variables
        Controles elControl = new Controles();
        bool validar = false;
        int intID;
        string strNombreServicio;
        string strDescripcionServicio;
        string strPrecio;
        #endregion
        public ServicioAdicionalEditar(int id)
        {
            InitializeComponent();
            pServiciosAdicionales p = new mServiciosAdicionales().ConsultaID(id);
            textId.Text = id.ToString();
            textEditarNombre.Text = p.NOMBRE;
            textDescripcion.Text = p.DESCRIPCION;
            textPrecio.Text = p.PRECIO;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            validar = false;
            if (validar = elControl.vldCampoVacio("Número ID", textId.Text))
            { intID = Convert.ToInt32(textId.Text); }
            if (validar = elControl.vldCampoVacio("Precio", textPrecio.Text))
            { strPrecio = textPrecio.Text; }
            if (validar = elControl.vldCampoVacio("Nombre Servicio", textEditarNombre.Text))
            { strNombreServicio = textEditarNombre.Text; }
            if (validar = elControl.vldCampoVacio("Descripción Servicio", textDescripcion.Text))
                strDescripcionServicio = textDescripcion.Text;
            if (validar == false)
                //Si algún campo esta vacio no se guarda.
                return;
            else
            {
                //Aqui va el metodo de inserción de datos.
                pServiciosAdicionales p = new pServiciosAdicionales();
                p.ID_SERVICIO_ADICIONAL = intID;
                p.NOMBRE = strNombreServicio;
                p.DESCRIPCION = strDescripcionServicio;
                p.PRECIO = strPrecio;
                new mServiciosAdicionales().Editar(p);
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Al cancelar no se guardaran los \ncambios realizados?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                this.Close();
        }
    }
}
