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
    public partial class ClientesVuelos : Form
    {
        private int iSelect = -1;
        private string strFechaDeSalida = null;
        private string strOrigen = null;
        private string strDestino = null;

        public ClientesVuelos(int id)
        {
            InitializeComponent();
            // ID de Vuelo.
            textBox1.Text = id.ToString();
            // Inicializa los valores.
            comboOrigen.SelectedIndex = 0;
            comboDestino.SelectedIndex = 0;
            strFechaDeSalida = dateTimeSalida.Value.Date.ToString("yyyy-MM-dd");
            strOrigen = comboOrigen.SelectedItem.ToString();
            strDestino = comboDestino.SelectedItem.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new mVuelos().ConsultaBuscar(0, strFechaDeSalida, strOrigen, strDestino);
            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "Fecha salida";
            dataGridView1.Columns[2].HeaderText = "Origen";
            dataGridView1.Columns[3].HeaderText = "Hora salida";
            dataGridView1.Columns[4].HeaderText = "Destino";
            dataGridView1.Columns[5].HeaderText = "Hora llegada";
            dataGridView1.Columns[6].HeaderText = "Clase";
            dataGridView1.Columns[7].HeaderText = "Disponibles";
            dataGridView1.Columns[8].HeaderText = "Precio";

            dataGridView1.Columns[0].Width = 30;
            dataGridView1.Columns[1].Width = 95;
            dataGridView1.Columns[2].Width = 100;
            dataGridView1.Columns[3].Width = 55;
            dataGridView1.Columns[4].Width = 100;
            dataGridView1.Columns[5].Width = 55;
            dataGridView1.Columns[6].Width = 75;
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[8].Width = 70;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(255, 128, 0);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void dateTimeSalida_ValueChanged(object sender, EventArgs e)
        {
            strFechaDeSalida = dateTimeSalida.Value.Date.ToString("yyyy-MM-dd");
            dataGridView1.DataSource = new mVuelos().ConsultaBuscar(0, strFechaDeSalida, strOrigen, strDestino);
        }

        private void comboOrigen_SelectedIndexChanged(object sender, EventArgs e)
        {
            strOrigen = comboOrigen.SelectedItem.ToString();
            dataGridView1.DataSource = new mVuelos().ConsultaBuscar(0, strFechaDeSalida, strOrigen, strDestino);
        }

        private void comboDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            strDestino = comboDestino.SelectedItem.ToString();
            dataGridView1.DataSource = new mVuelos().ConsultaBuscar(0, strFechaDeSalida, strOrigen, strDestino);
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Controles c = new Controles();
            iSelect = c.ID_DataGrid(dataGridView1, e);
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Al cancelar no se guardaran los \ncambios realizados?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                this.Close();
        }
    }
}
