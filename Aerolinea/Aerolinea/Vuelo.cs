/*****************************************************/
/* Programa proyecto: AVI Soft */
/* Nombre: Aerolinea AVI */
/* Fecha: 08/04/2015 */
/* Descripción: Gestionar las rutas de vuelo */
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
    public partial class Vuelo : Form
    {
        private int iSelect = -1;

        public Vuelo()
        {
            InitializeComponent();
        }

        private void Vuelo_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.buttonAgregar, "Agregar vuelo");
            toolTip1.SetToolTip(this.buttonBuscar, "Buscar vuelo");
            toolTip1.SetToolTip(this.buttonEditar, "Editar vuelo");
            toolTip1.SetToolTip(this.buttonEliminar, "Eliminar vuelo");
            toolTip1.SetToolTip(this.pictureAyuda, "Ayuda");

            dataGridVuelos.DataSource = new mVuelos().ConsultaAll();
            dataGridVuelos.Columns[0].HeaderText = "ID";
            dataGridVuelos.Columns[1].HeaderText = "Avion";
            dataGridVuelos.Columns[2].HeaderText = "Fecha Salida";
            dataGridVuelos.Columns[3].HeaderText = "Precio";
            dataGridVuelos.Columns[4].HeaderText = "Hora Salida";
            dataGridVuelos.Columns[5].HeaderText = "Origen";
            dataGridVuelos.Columns[6].HeaderText = "Hora Llegada";
            dataGridVuelos.Columns[7].HeaderText = "Destino";

            dataGridVuelos.Columns[0].Width = 40;
            dataGridVuelos.Columns[5].Width = 150;
            dataGridVuelos.Columns[7].Width = 150;
            dataGridVuelos.Columns[3].Width = 60;

            dataGridVuelos.EnableHeadersVisualStyles = false;
            dataGridVuelos.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);
            dataGridVuelos.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VueloAgregar v = new VueloAgregar();
            v.ShowDialog();
            dataGridVuelos.DataSource = new mVuelos().ConsultaAll();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VueloBuscar f = new VueloBuscar();
            f.ShowDialog();
            dataGridVuelos.DataSource = new mVuelos().ConsultaFecha(f.strFechaSalida);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (iSelect != -1)
            {
                VueloEditar v = new VueloEditar(iSelect);
                v.ShowDialog();
                dataGridVuelos.DataSource = new mVuelos().ConsultaAll();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un elemento en la tabla.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (iSelect != -1)
            {
                new mVuelos().Eliminar(iSelect);
                dataGridVuelos.DataSource = new mVuelos().ConsultaAll();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un elemento en la tabla.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Es un evento necesario para definir el renglon de vuelo a gestionar.
            Controles c = new Controles();
            iSelect = c.ID_DataGrid(dataGridVuelos, e);
        }

        private void pictureAyuda_Click(object sender, EventArgs e)
        {
            AyudaVuelos ayudaVuelo = new AyudaVuelos();
            ayudaVuelo.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
