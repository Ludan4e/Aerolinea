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
    public partial class Promocion : Form
    {
        private int iSelect = -1;

        public Promocion()
        {
            InitializeComponent();
        }

        private void Promociones_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.buttonAgregar, "Agregar promoción");
            toolTip1.SetToolTip(this.buttonBuscar, "Buscar promoción");
            toolTip1.SetToolTip(this.buttonEditar, "Editar promoción");
            toolTip1.SetToolTip(this.buttonEliminar, "Eliminar promoción");
            toolTip1.SetToolTip(this.pictureAyuda, "Ayuda");
            dataGridPromociones.DataSource = new mPromociones().ConsultaAll();
            FormatoTabla();
        }

        public void FormatoTabla()
        {
            dataGridPromociones.Columns[0].HeaderText = "ID";
            dataGridPromociones.Columns[1].HeaderText = "Nombre";
            dataGridPromociones.Columns[2].HeaderText = "Descripcion";
            dataGridPromociones.Columns[3].HeaderText = "Dscto";
            dataGridPromociones.Columns[4].HeaderText = "Codigo";
            dataGridPromociones.Columns[5].HeaderText = "Vigencia Inicial";
            dataGridPromociones.Columns[6].HeaderText = "Vigencia Final";

            dataGridPromociones.Columns[0].Width = 30;
            dataGridPromociones.Columns[2].Width = 260;
            dataGridPromociones.Columns[3].Width = 50;

            dataGridPromociones.EnableHeadersVisualStyles = false;
            dataGridPromociones.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);
            dataGridPromociones.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            PromocionAgregar agre = new PromocionAgregar();
            agre.ShowDialog();
            dataGridPromociones.DataSource = new mPromociones().ConsultaAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PromocionBuscar f = new PromocionBuscar();
            f.ShowDialog();
            dataGridPromociones.DataSource = new mPromociones().ConsultaBuscar(f.strNombre);
        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            if (iSelect != -1)
            {
                PromocionEditar edi = new PromocionEditar(iSelect);
                edi.ShowDialog();
                dataGridPromociones.DataSource = new mPromociones().ConsultaAll();
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
                new mPromociones().Eliminar(iSelect);
                dataGridPromociones.DataSource = new mPromociones().ConsultaAll();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un elemento en la tabla.");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Controles c = new Controles();
            iSelect = c.ID_DataGrid(dataGridPromociones, e);
        }

        private void pictureAyuda_Click(object sender, EventArgs e)
        {
            AyudaPromocion ayudapromo = new AyudaPromocion();
            ayudapromo.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
