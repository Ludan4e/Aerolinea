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
    public partial class ReservacionesVuelos : Form
    {
        pReservacionesAll p = new pReservacionesAll();

        public ReservacionesVuelos(pReservacionesAll p)
        {
            InitializeComponent();
            // pReservaciones.
            this.p = p;
            // IDs y Precio.
            p.iVueloSalida = -1;
            p.iVueloRegreso = -1;
            p.iPrecioDeSalida = 0;
            p.iPrecioDeRegreso = 0;
        }

        private void Elige_tu_vuelo_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.pictureAyuda, "Ayuda");
            dataGridTablaVuelo.DataSource = new mVuelos().ConsultaBuscar(p.iPasajeros, p.strFechaDeSalida, p.strOrigen, p.strDestino);           
            if (p.strFechaDeRegreso != "")
            {
                dataGridRegreso.DataSource = new mVuelos().ConsultaBuscar(p.iPasajeros, p.strFechaDeRegreso, p.strDestino, p.strOrigen);
            }
            else
            {
                labelRegreso.Visible = false;
                dataGridRegreso.Visible = false;
            }
            // Descuento.
            if (p.id_promocion != -1)
            {
                pPromociones obj = new mPromociones().ConsultaID(p.id_promocion);
                p.iDescuento = Convert.ToInt32(obj.DESCUENTO) / 100f;
            }
            else
            {
                p.iDescuento = 0;
            }
            FormatoTabla();
        }

        private void FormatoTabla()
        {
            dataGridTablaVuelo.Columns[0].HeaderText = "ID";
            dataGridTablaVuelo.Columns[1].HeaderText = "Fecha salida";
            dataGridTablaVuelo.Columns[2].HeaderText = "Origen";
            dataGridTablaVuelo.Columns[3].HeaderText = "Hora salida";
            dataGridTablaVuelo.Columns[4].HeaderText = "Destino";
            dataGridTablaVuelo.Columns[5].HeaderText = "Hora llegada";
            dataGridTablaVuelo.Columns[6].HeaderText = "Clase";
            dataGridTablaVuelo.Columns[7].HeaderText = "Disponibles";
            dataGridTablaVuelo.Columns[8].HeaderText = "Precio";

            dataGridTablaVuelo.Columns[0].Width = 30;
            dataGridTablaVuelo.Columns[1].Width = 95;
            dataGridTablaVuelo.Columns[2].Width = 100;
            dataGridTablaVuelo.Columns[3].Width = 55;
            dataGridTablaVuelo.Columns[4].Width = 100;
            dataGridTablaVuelo.Columns[5].Width = 55;
            dataGridTablaVuelo.Columns[6].Width = 75;
            dataGridTablaVuelo.Columns[7].Width = 100;
            dataGridTablaVuelo.Columns[8].Width = 70;

            dataGridTablaVuelo.EnableHeadersVisualStyles = false;
            dataGridTablaVuelo.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);
            dataGridTablaVuelo.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            if (p.strFechaDeRegreso != "")
            {
                dataGridRegreso.Columns[0].HeaderText = "ID";
                dataGridRegreso.Columns[1].HeaderText = "Fecha salida";
                dataGridRegreso.Columns[2].HeaderText = "Origen";
                dataGridRegreso.Columns[3].HeaderText = "Hora salida";
                dataGridRegreso.Columns[4].HeaderText = "Destino";
                dataGridRegreso.Columns[5].HeaderText = "Hora llegada";
                dataGridRegreso.Columns[6].HeaderText = "Clase";
                dataGridRegreso.Columns[7].HeaderText = "Disponibles";
                dataGridRegreso.Columns[8].HeaderText = "Precio";

                dataGridRegreso.Columns[0].Width = 30;
                dataGridRegreso.Columns[1].Width = 95;
                dataGridRegreso.Columns[2].Width = 100;
                dataGridRegreso.Columns[3].Width = 55;
                dataGridRegreso.Columns[4].Width = 100;
                dataGridRegreso.Columns[5].Width = 55;
                dataGridRegreso.Columns[6].Width = 75;
                dataGridRegreso.Columns[7].Width = 100;
                dataGridRegreso.Columns[8].Width = 70;

                dataGridRegreso.EnableHeadersVisualStyles = false;
                dataGridRegreso.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);
                dataGridRegreso.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            }
        }

        private void InformacionDeVuelo()
        {
            int salida = p.iPasajeros * p.iPrecioDeSalida;
            int regreso = p.iPasajeros * p.iPrecioDeRegreso;
            int servicios = 0;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Reservaciones f = new Reservaciones();
            f.Show();
            this.Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (p.iVueloSalida != -1)
            {
                ReservacionesClientes f = new ReservacionesClientes(p);
                f.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Seleccione el vuelo", "Vuelo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }

        private void dataGridTablaVuelo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Controles c = new Controles();
            p.iVueloSalida = c.ID_DataGrid(dataGridTablaVuelo, e);
            // Datos de la Tabla.
            try
            {
                if (dataGridTablaVuelo[6, dataGridTablaVuelo.CurrentRow.Index].Value.ToString() == "Premier")
                {
                    p.bClaseVueloSalida = true;
                }
                if (dataGridTablaVuelo[6, dataGridTablaVuelo.CurrentRow.Index].Value.ToString() == "Económica")
                {
                    p.bClaseVueloSalida = false;
                }
                p.iPrecioDeSalida = Convert.ToInt32(dataGridTablaVuelo[8, dataGridTablaVuelo.CurrentRow.Index].Value);
            }
            catch (Exception)
            {
                p.iPrecioDeSalida = 0;
            }
            InformacionDeVuelo();
        }

        private void dataGridRegreso_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Controles c = new Controles();
            p.iVueloRegreso = c.ID_DataGrid(dataGridRegreso, e);
            // Datos de la Tabla.
            try
            {
                if (dataGridRegreso[6, dataGridRegreso.CurrentRow.Index].Value.ToString() == "Premier")
                {
                    p.bClaseVueloRegreso = true;
                }
                if (dataGridRegreso[6, dataGridRegreso.CurrentRow.Index].Value.ToString() == "Económica")
                {
                    p.bClaseVueloRegreso = false;
                }
                p.iPrecioDeRegreso = Convert.ToInt32(dataGridRegreso[8, dataGridRegreso.CurrentRow.Index].Value);
            }
            catch (Exception)
            {
                p.iPrecioDeRegreso = 0;
            }
            InformacionDeVuelo();
        }

        private void pictureAyuda_Click(object sender, EventArgs e)
        {
            AyudaEligetuvuelo f = new AyudaEligetuvuelo();
            f.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Si cierra esta ventana\nperdera los datos de reservación", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
