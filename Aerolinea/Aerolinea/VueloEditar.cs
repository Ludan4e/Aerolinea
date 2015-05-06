/*****************************************************/
/* Programa proyecto: AVI Soft */
/* Nombre: Aerolinea AVI */
/* Fecha: 08/04/2015 */
/* Descripción: Editar las rutas de vuelo */
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
    public partial class VueloEditar : Form
    {
        #region Variables
        //Variables del vuelo
        private int IDvuelo;
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

        public VueloEditar(int id)//Carga del formulario.
        {
            InitializeComponent();
            //Inicialización del formulario para evitar datos vacios.
            dateTimeHoraSalida.Format = DateTimePickerFormat.Custom;
            dateTimeHoraSalida.CustomFormat = "HH:mm";
            dateTimeHoraLlegada.Format = DateTimePickerFormat.Custom;
            dateTimeHoraLlegada.CustomFormat = "HH:mm";

            pVuelos p = new mVuelos().ConsultaID(id);
            textIDVuelo.Text = id.ToString();
            comboAvion.SelectedIndex = comboAvion.Items.IndexOf(p.AVION);
            dateTimeSalida.Value = Convert.ToDateTime(p.FECHA_DE_SALIDA);
            textPrecio.Text = p.PRECIO;
            dateTimeHoraSalida.Text = p.HORA_DE_SALIDA;
            comboOrigen.SelectedIndex = comboOrigen.Items.IndexOf(p.ORIGEN);
            dateTimeHoraLlegada.Text = p.HORA_DE_LLEGADA;
            comboDestino.SelectedIndex = comboDestino.Items.IndexOf(p.DESTINO);
        }

        private void buttonAceptar_Click(object sender, EventArgs e)//Boton para agregar el vuelo
        {
            bool validar = true;
            //Validar que la hora de salida sea menor a la de llegada
            validar = elControl.vldHoraLlegada(dateTimeHoraSalida, dateTimeHoraLlegada);
            if (validar == false)
                return;
            IDvuelo = Convert.ToInt32(textIDVuelo.Text);
            strAvion = comboAvion.SelectedItem.ToString();
            strfechaSalida = dateTimeSalida.Value.Date.ToString("yyyy-MM-dd");
            strPrecio = textPrecio.Text;
            strHoraSalida = dateTimeHoraSalida.Text;
            strOrigen = comboOrigen.SelectedItem.ToString();
            strHoraLlegada = dateTimeHoraLlegada.Text;
            strDestino = comboDestino.SelectedItem.ToString();
            //Validar que el destino sea diferente al origen
            elControl.vldDestino(strOrigen, strDestino);
            if (validar == false)
                return;
            if (validar == true)
            {
                pVuelos p = new pVuelos();
                p.ID_VUELO = IDvuelo;
                p.AVION = strAvion;
                p.FECHA_DE_SALIDA = strfechaSalida;
                p.PRECIO = strPrecio;
                p.HORA_DE_SALIDA = strHoraSalida;
                p.ORIGEN = strOrigen;
                p.HORA_DE_LLEGADA = strHoraLlegada;
                p.DESTINO = strDestino;
                new mVuelos().Editar(p);
                this.Close();
            }
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Al cancelar no se guardaran los \ncambios realizados?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                this.Close();
        }
    }
}
