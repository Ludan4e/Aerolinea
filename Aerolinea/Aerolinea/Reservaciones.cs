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
    public partial class Reservaciones : Form
    {
        pReservacionesAll p = new pReservacionesAll();
        private bool BotonRedondoSencillo = true;
        private bool destino = false;
        private object[,] arrPro = null;

        public Reservaciones()
        {
            InitializeComponent();
            // Inicialización del formulario para evitar datos vacios.
            textDestino.Enabled = false;
            textOrigen.Enabled = false;
            buttonRedondo.BackColor = Color.Orange;
            buttonRedondo.ForeColor = Color.White;
            toolTip1.SetToolTip(this.buttonOrigen, "Selección de origen");
            toolTip1.SetToolTip(this.buttonDestino, "Selección de destino");
            toolTip1.SetToolTip(this.buttonRedondo, "Vuelo redondo");
            toolTip1.SetToolTip(this.buttonSencillo, "Vuelo sencillo");
            toolTip1.SetToolTip(this.buttonBuscar, "Buscar reservación");
            toolTip1.SetToolTip(this.pictureAyuda, "Ayuda");
            // pReservacionesAll.
            p.strOrigen = null;
            p.strDestino = null;
            p.strFechaDeSalida = null;
            p.strFechaDeRegreso = null;
            p.iAdultos = -1;
            p.iMenor = -1;
            p.iInfantes = -1;
            // Promociones.
            arrPro = new Controles().ConvertDataTableToArray(new mPromociones().ConsultaCombo());
            p.id_promocion = -1;
            for (int i = 0; i < arrPro.GetLength(0); i++)
            {
                comboPromocion.Items.Add(arrPro[i, 1]);
            }
        }

        private void comboPromocion_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.id_promocion = Convert.ToInt32(arrPro[comboPromocion.SelectedIndex, 0]);
        }

        private void buttonOrigen_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox1.Location = new Point(45, 14);
            buttonDestino.Enabled = true;
            textDestino.Clear();
            destino = false;
        }

        private void buttonDestino_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox1.Location = new Point(45, 14);
            destino = true;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (textOrigen.Text == "" || textDestino.Text == "")
            { MessageBox.Show("Seleccione un Origen y un Destino", "Vuelo", MessageBoxButtons.OK, MessageBoxIcon.Information); return; }
            p.strOrigen = textOrigen.Text;
            p.strDestino = textDestino.Text;
            p.strFechaDeSalida = dateTimePicker1.Value.Date.ToString("yyyy-MM-dd");
            if (BotonRedondoSencillo)
            {
                p.strFechaDeRegreso = dateTimePicker2.Value.Date.ToString("yyyy-MM-dd");
            }
            else
            {
                p.strFechaDeRegreso = "";
            }
            p.iAdultos = (int)numericAdulto.Value;
            p.iMenor = (int)numericMenor.Value;
            p.iInfantes = (int)numericInfante.Value;
            p.iPasajeros = p.iAdultos + p.iMenor;
            ReservacionesVuelos f = new ReservacionesVuelos(p);
            f.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BotonRedondoSencillo = true;
            buttonRedondo.BackColor = Color.Orange;
            buttonRedondo.ForeColor = Color.White;
            buttonSencillo.BackColor = Color.LightGray;
            buttonSencillo.ForeColor = Color.Black;
            labelFechaRegreso.Visible = true;
            dateTimePicker2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BotonRedondoSencillo = false;
            buttonSencillo.BackColor = Color.Orange;
            buttonSencillo.ForeColor = Color.White;
            buttonRedondo.BackColor = Color.LightGray;
            buttonRedondo.ForeColor = Color.Black;
            labelFechaRegreso.Visible = false;
            dateTimePicker2.Visible = false;
        }

        #region Links Labels
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel1.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel1.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel2.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel2.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel3.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel3.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel4.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel4.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel5.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel5.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel6.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel6.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel7.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel7.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel8.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel8.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel9.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel9.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel10.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel10.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel11.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel11.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel12.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel12.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel13.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel13.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel14.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel14.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel15.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel15.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel16.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel16.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel17.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel17.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel18.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel18.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel19.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel19.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel20_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel20.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel20.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel21_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel21.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel21.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel22_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel22.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel22.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel23_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel23.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel23.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel24_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel24.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel24.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel25_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel25.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel25.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel26_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel25.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel25.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel27_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel27.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel27.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel29_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel29.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel29.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel28_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel28.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel28.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel30_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel30.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel30.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel31_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel31.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel31.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel32_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel32.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel32.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel33_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel33.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel33.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel34_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel34.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel34.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel35_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel35.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel35.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel36_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel36.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel36.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel37_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel37.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel37.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel38_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel38.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel38.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel39_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel39.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel39.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel40_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel40.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel40.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel41_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel41.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel41.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel42_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel42.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel42.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel43_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel43.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel43.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel44_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel44.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel44.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel45_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel45.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel45.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel46_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel46.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel46.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel47_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel47.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel47.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel48_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel48.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel48.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel49_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel49.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel49.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel50_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel50.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel50.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel51_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel51.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel51.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel52_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel52.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel52.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel53_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel53.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel53.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel54_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel54.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel54.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel55_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel55.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel55.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }

        private void linkLabel56_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!destino)
            {
                textOrigen.Text = linkLabel56.Text;
                groupBox1.Visible = false;
            }
            else
            {
                textDestino.Text = linkLabel56.Text;
                groupBox1.Visible = false;
            }
            if (textOrigen.Text == textDestino.Text)
            {
                MessageBox.Show("No puedes tener el mismo destino", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textDestino.Clear();
            }
        }
        #endregion

        private void pictureAyuda_Click(object sender, EventArgs e)
        {
            AyudaBusqueda ayudabus = new AyudaBusqueda();
            ayudabus.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
