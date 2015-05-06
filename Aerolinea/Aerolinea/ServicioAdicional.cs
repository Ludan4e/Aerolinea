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
    public partial class ServicioAdicional : Form
    {
        private int iSelect = -1;

        public ServicioAdicional()
        {
            InitializeComponent();
        }

        private void Servicios_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.buttonAgregar, "Agrega un servicio.");
            toolTip1.SetToolTip(this.buttonBuscar, "Realiza la busqueda un servicio.");
            toolTip1.SetToolTip(this.buttonEditar, "Modifica un servicio Seleccionado.");
            toolTip1.SetToolTip(this.buttonEliminar, "Elimina un servicio seleccionado.");
            toolTip1.SetToolTip(this.pictureAyuda, "Ayuda");
            dataGridServicios.DataSource = new mServiciosAdicionales().ConsultaAll();
            dataGridServicios.Columns[0].HeaderText = "ID";
            dataGridServicios.Columns[1].HeaderText = "Nombre";
            dataGridServicios.Columns[2].HeaderText = "Descripción";
            dataGridServicios.Columns[3].HeaderText = "Precio";

            dataGridServicios.Columns[0].Width = 40;
            dataGridServicios.Columns[2].Width = 440;
            dataGridServicios.Columns[3].Width = 70;

            dataGridServicios.EnableHeadersVisualStyles = false;
            dataGridServicios.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);
            dataGridServicios.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            ServicioAdicionalAgregar gestion = new ServicioAdicionalAgregar();
            gestion.ShowDialog();
            dataGridServicios.DataSource = new mServiciosAdicionales().ConsultaAll();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            ServicioAdicionalBuscar f = new ServicioAdicionalBuscar();
            f.ShowDialog();
            dataGridServicios.DataSource = new mServiciosAdicionales().ConsultaBuscar(f.strNombre);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (iSelect != -1)
            {
                ServicioAdicionalEditar Editarservicios = new ServicioAdicionalEditar(iSelect);
                Editarservicios.Show();
                dataGridServicios.DataSource = new mServiciosAdicionales().ConsultaAll();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un elemento en la tabla.");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (iSelect != -1)
            {
                new mServiciosAdicionales().Eliminar(iSelect);
                dataGridServicios.DataSource = new mServiciosAdicionales().ConsultaAll();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un elemento en la tabla.");
            }
        }

        private void dataGridServicios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Controles c = new Controles();
            iSelect = c.ID_DataGrid(dataGridServicios, e);
        }

        private void pictureAyuda_Click(object sender, EventArgs e)
        {
            AyudaServicios f = new AyudaServicios();
            f.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
