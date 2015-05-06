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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(this.pictureBox1, "Realiza tu reservación");
            toolTip1.SetToolTip(this.pictureBox3, "Información de vuelos");
            toolTip1.SetToolTip(this.pictureBox4, "Información de servicios");
            toolTip1.SetToolTip(this.pictureBox5, "Información de promociones");
            toolTip1.SetToolTip(this.pictureBox6, "Registros de clientes");
            toolTip1.SetToolTip(this.pictureBox7, "Información sobre el sistema");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Reservaciones busq = new Reservaciones();
            busq.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Vuelo vuelo = new Vuelo();
            vuelo.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ServicioAdicional serv = new ServicioAdicional();
            serv.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Promocion prom = new Promocion();
            prom.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Clientes client = new Clientes();
            client.Show();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Ayuda ayu = new Ayuda();
            ayu.Show();
        }
    }
}
