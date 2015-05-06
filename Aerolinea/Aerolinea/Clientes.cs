/*****************************************************/
/* Programa proyecto: AVI Soft */
/* Nombre: Aerolinea AVI */
/* Fecha: 08/04/2015 */
/* Descripción: Administrar Clientes */
/*****************************************************/
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
    public partial class Clientes : Form
    {
        private int id_reservacion = -1;
        private int id_cliente = -1;
        private int id_contacto = -1;
        private int id_asiento = -1;
        private object[,] ids = null;

        public Clientes()
        {
            InitializeComponent();
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.buttonCliente, "Cambio de cliente");
            toolTip1.SetToolTip(this.buttonContacto, "Cambio de contacto");
            toolTip1.SetToolTip(this.buttonCambioVuelo, "Cambiar vuelo");
            toolTip1.SetToolTip(this.buttonCancelacionVuelo, "Cancelar vuelo");
            toolTip1.SetToolTip(this.buttonItinerario, "Imprimir itinerario");
            toolTip1.SetToolTip(this.buttonFactura, "Imprimir factura");
            toolTip1.SetToolTip(this.pictureAyuda, "Ayuda");

            dataGridTabla.DataSource = new mReservaciones().ConsultaAll();
            ids = new Controles().ConvertDataTableToArray(new mReservaciones().ConsultaAllID());
            FormatoTabla();
        }

        private void FormatoTabla()
        {
            dataGridTabla.Columns[0].HeaderText = "Nombre(s) de cliente";
            dataGridTabla.Columns[1].HeaderText = "Apellido(s) de cliente";
            dataGridTabla.Columns[2].HeaderText = "Nombre(s) de contacto";
            dataGridTabla.Columns[3].HeaderText = "Apellido(s) de contacto";
            dataGridTabla.Columns[4].HeaderText = "Telefono de contacto";
            dataGridTabla.Columns[5].HeaderText = "Correo de contacto";
            dataGridTabla.Columns[6].HeaderText = "Fecha Salida";
            dataGridTabla.Columns[7].HeaderText = "Hora Salida";
            dataGridTabla.Columns[8].HeaderText = "Origen";
            dataGridTabla.Columns[9].HeaderText = "Hora Llegada";
            dataGridTabla.Columns[10].HeaderText = "Destino";

            dataGridTabla.Columns[0].Width = 150;
            dataGridTabla.Columns[1].Width = 150;
            dataGridTabla.Columns[2].Width = 150;
            dataGridTabla.Columns[3].Width = 150;
            dataGridTabla.Columns[4].Width = 90;
            dataGridTabla.Columns[5].Width = 200;
            dataGridTabla.Columns[6].Width = 80;
            dataGridTabla.Columns[7].Width = 80;
            dataGridTabla.Columns[8].Width = 100;
            dataGridTabla.Columns[9].Width = 80;
            dataGridTabla.Columns[10].Width = 100;

            dataGridTabla.EnableHeadersVisualStyles = false;
            dataGridTabla.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);
            dataGridTabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            if (id_cliente != -1)
            {
                ClientesClientes f = new ClientesClientes(id_cliente);
                f.ShowDialog();
                dataGridTabla.DataSource = new mReservaciones().ConsultaAll();
                ids = new Controles().ConvertDataTableToArray(new mReservaciones().ConsultaAllID());
            }
            else
            {
                MessageBox.Show("Por favor seleccione un elemento en la tabla.");
            }
        }

        private void buttonContacto_Click(object sender, EventArgs e)
        {
            if (id_contacto != -1)
            {
                ClientesContactos f = new ClientesContactos(id_contacto);
                f.ShowDialog();
                dataGridTabla.DataSource = new mReservaciones().ConsultaAll();
                ids = new Controles().ConvertDataTableToArray(new mReservaciones().ConsultaAllID());
            }
            else
            {
                MessageBox.Show("Por favor seleccione un elemento en la tabla.");
            }
        }

        private void buttonCambioVuelo_Click(object sender, EventArgs e)
        {
            if (id_asiento != -1)
            {
                ClientesVuelos f = new ClientesVuelos(id_asiento);
                f.ShowDialog();
                dataGridTabla.DataSource = new mReservaciones().ConsultaAll();
                ids = new Controles().ConvertDataTableToArray(new mReservaciones().ConsultaAllID());
            }
            else
            {
                MessageBox.Show("Por favor seleccione un elemento en la tabla.");
            }
        }

        private void buttonCancelacionVuelo_Click(object sender, EventArgs e)
        {
            if (id_reservacion != -1)
            {
                new mReservaciones().Eliminar(id_reservacion);
                dataGridTabla.DataSource = new mReservaciones().ConsultaAll();
                ids = new Controles().ConvertDataTableToArray(new mReservaciones().ConsultaAllID());
            }
            else
            {
                MessageBox.Show("Por favor seleccione un elemento en la tabla.");
            }
        }

        private void buttonItinerario_Click(object sender, EventArgs e)
        {
        }

        private void buttonFactura_Click(object sender, EventArgs e)
        {
        }

        private void dataGridTabla_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id_reservacion = Convert.ToInt32(ids[dataGridTabla.CurrentRow.Index, 0]);
                id_cliente = Convert.ToInt32(ids[dataGridTabla.CurrentRow.Index, 1]);
                id_contacto = Convert.ToInt32(ids[dataGridTabla.CurrentRow.Index, 2]);
                id_asiento = Convert.ToInt32(ids[dataGridTabla.CurrentRow.Index, 3]);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha seleccionado un campo vacío.");
                id_reservacion = -1;
                id_cliente = -1;
                id_contacto = -1;
                id_asiento = -1;
            }
        }

        private void pictureAyuda_Click(object sender, EventArgs e)
        {
            AyudaCliente ayudaclient = new AyudaCliente();
            ayudaclient.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
