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
    public partial class PromocionBuscar : Form
    {
        #region Variables
        private Controles elControl = new Controles();
        private bool validar = false;
        private string strNombrePromocion;
        public string strNombre { get; set; }
        #endregion

        public PromocionBuscar()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            validar = false;
            if (validar = elControl.vldCampoVacio("Nombre Promoción", textNombre.Text))
            {
                strNombrePromocion = textNombre.Text;
            }
            if (validar == false)
            {
                //Si algún campo esta vacio no se guarda.
                return;
            }
            else
            {
                //Aqui va el metodo de inserción de datos.
                strNombre = strNombrePromocion;
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
