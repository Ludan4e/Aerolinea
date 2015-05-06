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
    public partial class ReservacionesPagar : Form
    {
        pReservacionesAll p = new pReservacionesAll();

        #region Variables
        private string strTipo_de_tarjeta_de_credito = null;
        private string strNumero_de_tarjeta = null;
        private string strTitular_de_la_tarjeta = null;
        private string strVencimiento_mes = null;
        private string strVencimiento_anio = null;
        private string strNumero_de_seguridad = null;

        private string strRfc = null;
        private string strDireccion = null;
        private string strPais = null;
        private string strEstado = null;
        private string strCiudad = null;
        private string strCodigo_postal = null;
        #endregion

        public ReservacionesPagar(pReservacionesAll p)
        {
            InitializeComponent();
            // pReservaciones.
            this.p = p;
            // Variables de Tarjeta.
            p.tarjetasDeCredito = new pTarjetasDeCredito();
            // Variables de Facturas.
            p.facturas = new pFacturas();
            InformacionDeVuelo();
        }

        private void Paga_reservacion_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.pictureAyuda, "Ayuda");
            comboTarjeta.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            comboPaises.SelectedIndex = 0;
            comboEstado.SelectedIndex = 0;
            textTelefono.Text = p.contactos.TELEFONO;
            textCorreoEmail.Text = p.contactos.CORREO_ELECTRONICO;
        }

        private void InformacionDeVuelo()
        {
            int salida = p.iPasajeros * p.iPrecioDeSalida;
            int regreso = p.iPasajeros * p.iPrecioDeRegreso;
            int servicios = p.iServicios;
            int iva = (int)((salida + regreso + servicios) * 0.16);
            int descuento = (int)((salida + regreso + servicios + iva) * p.iDescuento);
            int total = (salida + regreso + servicios + iva) - descuento;
            labelPrecioSalida.Text = string.Format("${0}.00", salida);
            labelPrecioRegreso.Text = string.Format("${0}.00", regreso);
            labelServicios.Text = string.Format("${0}.00", servicios);
            labelIVA.Text = string.Format("${0}.00", iva);
            labelDescuento.Text = string.Format("${0}.00", descuento);
            labelCostoTotal.Text = string.Format("${0}.00", total);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //pendiente
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space))
            {
                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            strTipo_de_tarjeta_de_credito = comboTarjeta.SelectedItem.ToString();
            strNumero_de_tarjeta = textNoTarjeta.Text;
            strTitular_de_la_tarjeta = textNombreTitular.Text;
            strVencimiento_mes = comboBox2.SelectedItem.ToString();
            strVencimiento_anio = comboBox3.SelectedItem.ToString();
            strNumero_de_seguridad = textCodigoSeguridad.Text;

            strRfc = textRFC.Text;
            strDireccion = textDireccion.Text;
            strPais = comboPaises.SelectedItem.ToString();
            strEstado = comboEstado.SelectedItem.ToString();
            strCiudad = textCiudad.Text;
            strCodigo_postal = textCodigoPostal.Text;

            p.tarjetasDeCredito.TIPO_DE_TARJETA_DE_CREDITO = strTipo_de_tarjeta_de_credito;
            p.tarjetasDeCredito.NUMERO_DE_TARJETA = strNumero_de_tarjeta;
            p.tarjetasDeCredito.TITULAR_DE_LA_TARJETA = strTitular_de_la_tarjeta;
            p.tarjetasDeCredito.VENCIMIENTO_MES = strVencimiento_mes;
            p.tarjetasDeCredito.VENCIMIENTO_ANIO = strVencimiento_anio;
            p.tarjetasDeCredito.NUMERO_DE_SEGURIDAD = strNumero_de_seguridad;

            p.facturas.RFC = strRfc;
            p.facturas.DIRECCION = strDireccion;
            p.facturas.PAIS = strPais;
            p.facturas.ESTADO = strEstado;
            p.facturas.CIUDAD = strCiudad;
            p.facturas.CODIGO_POSTAL = strCodigo_postal;
            p.facturas.TELEFONO = p.contactos.TELEFONO;
            p.facturas.CORREO_ELECTRONICO = p.contactos.CORREO_ELECTRONICO;

            int id_contacto = new mContactos().Agregar(p.contactos);
            int id_tarjeta = new mTarjetasDeCredito().Agregar(p.tarjetasDeCredito);
            int id_factura = new mFacturas().Agregar(p.facturas);

            // Reservaciones de Salida.
            List<int> id_clientes = new List<int>();
            for (int i = 0; i < p.iPasajeros; i++)
            {
                id_clientes.Add(new mClientes().Agregar(p.clientes[i]));
            }

            // Reservaciones de Salida.
            for (int i = 0; i < p.iPasajeros; i++)
            {
                pReservaciones obj = new pReservaciones();
                obj.ID_CLIENTE = id_clientes[i];
                obj.ID_CONTACTO = id_contacto;
                obj.ID_ASIENTO = p.id_asiento_de_salida[i];
                new mAsientos().Editar(p.id_asiento_de_salida[i]);
                obj.ID_TARJETA_DE_CREDITO = id_tarjeta;
                obj.ID_FACTURA = id_factura;
                obj.ID_PROMOCION = p.id_promocion;
                int id_reservacion = new mReservaciones().Agregar(obj);
                for (int j = 0; j < p.id_servicio_adicional[i].Count; j++)
                {
                    new mReservacionesServicios().Agregar(id_reservacion, p.id_servicio_adicional[i][j]);
                }
            }

            // Reservaciones de Regreso.
            if (p.strFechaDeRegreso != "")
            {
                for (int i = 0; i < p.iPasajeros; i++)
                {
                    pReservaciones obj = new pReservaciones();
                    obj.ID_CLIENTE = id_clientes[i];
                    obj.ID_CONTACTO = id_contacto;
                    obj.ID_ASIENTO = p.id_asiento_de_regreso[i];
                    new mAsientos().Editar(p.id_asiento_de_regreso[i]);
                    obj.ID_TARJETA_DE_CREDITO = id_tarjeta;
                    obj.ID_FACTURA = id_factura;
                    obj.ID_PROMOCION = p.id_promocion;
                    int id_reservacion = new mReservaciones().Agregar(obj);
                    for (int j = 0; j < p.id_servicio_adicional[i].Count; j++)
                    {
                        new mReservacionesServicios().Agregar(id_reservacion, p.id_servicio_adicional[i][j]);
                    }
                }
            }

            // Mail.
            string body = "Se ha realizado la reservacion correctamente.";
            new mEmail().SendMail(p.contactos.CORREO_ELECTRONICO, body, "");

            this.Close();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            //ReservacionesAsientos asientos = new ReservacionesAsientos(1,1);
            //asientos.Show();
            //this.Close();
        }

        private void pictureAyuda_Click(object sender, EventArgs e)
        {
            AyudaPagar f = new AyudaPagar();
            f.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Si cierra esta ventana\nperdera los datos de reservación", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
