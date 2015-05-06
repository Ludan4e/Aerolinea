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
    public partial class PromocionAgregar : Form
    {
        #region Variables
        Controles elControl = new Controles();
        bool validar = false;
        string strNombrePromocion;
        string strCodigoPromocion;
        string strDescripcionPromocion;
        string strDescuentoPromocion;
        string strVigenciaInicial;
        string strVigenciaFinal;
        #endregion
        public PromocionAgregar()
        {
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.buttonAgregar, "Aceptar promoción");
            toolTip1.SetToolTip(this.buttonCancelar, "Cancelar promoción");
        }

        #region
        private void textNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            elControl.soloLetras(e);
        }

        private void textCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            elControl.soloAlfanumerico(e);
        }

        private void textDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void textDescuento_KeyPress(object sender, KeyPressEventArgs e)
        {
            elControl.soloNumeros(e);
        }
        #endregion

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            validar = false;
            if (validar = elControl.vldCampoVacio("Nombre Promoción", textNombre.Text))
            { strNombrePromocion = textNombre.Text; }
            if (validar = elControl.vldCampoVacio("Código Promoción", textCodigo.Text))
            { strCodigoPromocion = textCodigo.Text; }
            if (validar = elControl.vldCampoVacio("Descripción Promoción", textDescripcion.Text))
            { strDescripcionPromocion = textDescripcion.Text; }
            if (validar = elControl.vldCampoVacio("Código Promoción", textDescuento.Text))
            { 
                strDescuentoPromocion = textDescuento.Text;
                strDescuentoPromocion.Trim();
                if (int.Parse(strDescuentoPromocion) == 0 || int.Parse(strDescuentoPromocion) >= 101)
                { MessageBox.Show("Descuento No Valido"); return; }
            }
            strVigenciaInicial = dateTimeSalida.Value.Date.ToString("yyyy-MM-dd");
            strVigenciaFinal = dateTimeRegreso.Value.Date.ToString("yyyy-MM-dd");
            if (validar == false)
                //Si algún campo esta vacio no se guarda.
                return;
            else
            {
                //Aqui va el metodo de inserción de datos.
                pPromociones p = new pPromociones();
                p.NOMBRE = strNombrePromocion;
                p.DESCRIPCION = strDescripcionPromocion;
                p.DESCUENTO = strDescuentoPromocion;
                p.CODIGO = strCodigoPromocion;
                p.VIGENCIA_INICIAL = strVigenciaInicial;
                p.VIGENCIA_FINAL = strVigenciaFinal;
                new mPromociones().Agregar(p);
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
