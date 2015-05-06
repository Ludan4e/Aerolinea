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
    public partial class PromocionEditar : Form
    {
        int intID;
        string strNombre;
        string strDescripcion;
        string strDescuento;
        string strCodigo;
        string strVigenciaInicial;
        string strVigenciaFinal;

        public PromocionEditar(int id)
        {
            InitializeComponent();
            textID.Text = id.ToString();
            pPromociones p = new mPromociones().ConsultaID(id);
            textID.Text = p.ID_PROMOCION.ToString();
            textNombre.Text = p.NOMBRE;
            textDescripcion.Text = p.DESCRIPCION;
            textDescuento.Text = p.DESCUENTO;
            textCodigo.Text = p.CODIGO;
            dateTimePicker1.Value = Convert.ToDateTime(p.VIGENCIA_INICIAL);
            dateTimePicker2.Value = Convert.ToDateTime(p.VIGENCIA_FINAL);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            intID = Convert.ToInt32(textID.Text);
            strNombre = textNombre.Text;
            strDescripcion = textDescripcion.Text;
            strDescuento = textDescuento.Text;
            strCodigo = textCodigo.Text;
            strVigenciaInicial = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            strVigenciaFinal = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");

            pPromociones p = new pPromociones();
            p.ID_PROMOCION = intID;
            p.NOMBRE = strNombre;
            p.DESCRIPCION = strDescripcion;
            p.DESCUENTO = strDescuento;
            p.CODIGO = strCodigo;
            p.VIGENCIA_INICIAL = strVigenciaInicial;
            p.VIGENCIA_FINAL = strVigenciaFinal;
            new mPromociones().Editar(p);

            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Al cancelar no se guardaran los \ncambios realizados?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                this.Close();
        }
    }
}
