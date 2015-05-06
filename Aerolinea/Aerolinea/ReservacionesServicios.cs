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
    public partial class ReservacionesServicios : Form
    {
        pReservacionesAll p = new pReservacionesAll();

        public ReservacionesServicios(pReservacionesAll p)
        {
            InitializeComponent();
            toolTip1.SetToolTip(this.pictureAyuda, "Ayuda");
            // pReservaciones.
            this.p = p;
            // Variables de Servicios.
            p.id_servicio_adicional = new List<List<int>>();
            // Consultas de Servicios.
            dataGridServicios.DataSource = new mServiciosAdicionales().ConsultaAll();
            // Llenar Pasajeros.
            LlenarPasajeros(p.iPasajeros);
            comboPasajero.SelectedIndex = 0;
            InformacionDeVuelo();
            formatoTabla();
        }

        private void LlenarPasajeros(int iCantidadPasajeros)
        {
            for (int i = 1; i <= iCantidadPasajeros; i++)
            {
                comboPasajero.Items.Add(string.Format("Pasajero {0}", i));
                p.id_servicio_adicional.Add(new List<int>());
            }
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

        private int SumaServicios()
        {
            int total = 0;
            for (int i = 0; i < p.iPasajeros; i++)
            {
                for (int j = 0; j < dataGridServicios.RowCount; j++)
                {
                    int id = Convert.ToInt32(dataGridServicios[0, j].Value);
                    if (p.id_servicio_adicional[i].Contains(id))
                    {
                        total += Convert.ToInt32(dataGridServicios[3, j].Value);
                    }
                }
            }
            return total;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReservacionesAsientos f = new ReservacionesAsientos(p);
            f.Show();
            this.Close();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            //ReservacionesClientes reser = new ReservacionesClientes(iIDVuelo,iPasajeros);
            //reser.ShowDialog();
            //this.Close();
        }

        private void dataGridServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Controles c = new Controles();
            int id = c.ID_DataGrid(dataGridServicios, e);
            if (!p.id_servicio_adicional[comboPasajero.SelectedIndex].Remove(id))
            {
                p.id_servicio_adicional[comboPasajero.SelectedIndex].Add(id);
            }
            p.iServicios = SumaServicios();
            InformacionDeVuelo();
        }

        private void pictureAyuda_Click(object sender, EventArgs e)
        {
            AyudaServiciosAdicionales f = new AyudaServiciosAdicionales();
            f.Show();
        }

        private void ReservacionesServicios_Load(object sender, EventArgs e)
        {
            
        }
        public void formatoTabla()
        {
            dataGridServicios.Columns[0].HeaderText = "ID";
            dataGridServicios.Columns[1].HeaderText = "Nombre";
            dataGridServicios.Columns[2].HeaderText = "Descripción";
            dataGridServicios.Columns[3].HeaderText = "Precio";

            dataGridServicios.Columns[0].Width = 30;
            dataGridServicios.Columns[1].Width = 80;
            dataGridServicios.Columns[2].Width = 580;
            dataGridServicios.Columns[3].Width = 50;

            dataGridServicios.EnableHeadersVisualStyles = false;
            dataGridServicios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);
            dataGridServicios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
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
