/*****************************************************/
/* Programa proyecto: AVI Soft */
/* Nombre: Aerolinea AVI */
/* Fecha: 08/04/2015 */
/* Descripción: Agregar las rutas de vuelo */
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
    public partial class VueloAgregar : Form
    {
        #region Variables
        //Variables del vuelo
        private string strAvion;
        private string strfechaSalida;
        private string strPrecio;
        private string strHoraLlegada;
        private string strOrigen;
        private string strHoraSalida;
        private string strDestino;
        //Variable Control
        Controles elControl = new Controles();
        #endregion

        public VueloAgregar() //Carga del formulario
        {
            InitializeComponent();
            //Inicialización del formulario para evitar datos vacios.
            comboAvion.SelectedIndex = 0;
            dateTimeHoraSalida.Format = DateTimePickerFormat.Custom;
            dateTimeHoraSalida.CustomFormat = "HH:mm";
            comboOrigen.SelectedIndex = 0;
            dateTimeHoraLlegada.Format = DateTimePickerFormat.Custom;
            dateTimeHoraLlegada.CustomFormat = "HH:mm";
            comboDestino.SelectedIndex = 0;
            dateTimeSalida.MinDate = DateTime.Today.Add(TimeSpan.FromDays(5));
        }

        private void buttonAceptar_Click(object sender, EventArgs e)//Boton para agregar el vuelo
        {
            bool validar = true;
            //Validar que la hora de salida sea menor a la de llegada
            if (validar = elControl.vldHoraLlegada(dateTimeHoraSalida, dateTimeHoraLlegada) == false)
                return;
            strAvion = comboAvion.SelectedItem.ToString();
            strfechaSalida = dateTimeSalida.Value.Date.ToString("yyyy-MM-dd");
            strPrecio = textPrecio.Text;
            strHoraSalida = dateTimeHoraSalida.Text;
            strOrigen = comboOrigen.SelectedItem.ToString();
            strHoraLlegada = dateTimeHoraLlegada.Text;
            strDestino = comboDestino.SelectedItem.ToString();
            //Validar que el destino sea diferente al origen
            if (validar = elControl.vldDestino(strOrigen, strDestino) == false)
                return;
            pVuelos p = new pVuelos();
            p.AVION = strAvion;
            p.FECHA_DE_SALIDA = strfechaSalida;
            p.PRECIO = strPrecio;
            p.HORA_DE_SALIDA = strHoraSalida;
            p.ORIGEN = strOrigen;
            p.HORA_DE_LLEGADA = strHoraLlegada;
            p.DESTINO = strDestino;
            int id = new mVuelos().Agregar(p);
            switch (comboAvion.SelectedIndex)
            {
                case 0:
                    {
                        new mAsientos().AgregarA(id);
                        break;
                    }
                case 1:
                    {
                        new mAsientos().AgregarB(id);
                        break;
                    }
                case 2:
                    {
                        new mAsientos().AgregarC(id);
                        break;
                    }
            }
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Al cancelar no se guardaran los \ncambios realizados?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                this.Close();
        }
    }
}
