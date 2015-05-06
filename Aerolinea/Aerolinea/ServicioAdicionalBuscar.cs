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
    public partial class ServicioAdicionalBuscar : Form
    {
        #region Variables
        private Controles elControl = new Controles();
        private bool validar = false;
        private string strNombreServicio;
        public string strNombre { get; set; }
        #endregion

        public ServicioAdicionalBuscar()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            validar = false;
            if (validar = elControl.vldCampoVacio("Nombre Servicio", textEditarNombre.Text))
            {
                strNombreServicio = textEditarNombre.Text;
            }
            if (validar == false)
            {
                //Si algún campo esta vacio no se guarda.
                return;
            }
            else
            {
                //Aqui va el metodo de inserción de datos.
                strNombre = strNombreServicio;
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
