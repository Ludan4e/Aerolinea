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
    public partial class ReservacionesAsientos : Form
    {
        pReservacionesAll p = new pReservacionesAll();

        private object[,] array = null;
        private bool[,] disponibles;
        private bool[,] disponiblesS;
        private bool[,] disponiblesR;
        private bool bPasajeroConAsiento;

        private bool regreso;
        private int ipasajeros;
        private int iusados = 0;
        private int iusadosR = 0;
        private int iusadosS = 0;
        private int iTipoAvion = -1;
        private bool tipoPasajero;

        public ReservacionesAsientos(pReservacionesAll p)
        {
            InitializeComponent();
            // pReservaciones.
            this.p = p;
            // Variables de Asientos de Salida.
            p.id_asiento_de_salida = new List<int>();
            // Variables de Asientos de Regreso.
            p.id_asiento_de_regreso = new List<int>();
            if (p.iVueloRegreso == -1)
            {
                comboVuelo.Items.RemoveAt(1);
            }
            InformacionDeVuelo();
        }

        private void ReservacionesAsientos_Load(object sender, EventArgs e)
        {
            comboVuelo.SelectedIndex = 0;
            ipasajeros = p.iAdultos + p.iMenor;
            LlenarPasajeros(ipasajeros);
            comboPasajero.SelectedIndex = 0;
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

        private void cargarDatos(bool vuelo)
        {
            panelAvion1.Visible = false;
            panelAvion2.Visible = false;
            panelAvion3.Visible = false;
            panelAvion1.Enabled = false;
            panelAvion2.Enabled = false;
            panelAvion3.Enabled = false;
            if (vuelo == false)
            {// Consultas de Asientos.
                disponiblesR = disponibles;
                disponibles = disponiblesS;
                iusadosR = iusados;
                iusados = iusadosS;
                array = new Controles().ConvertDataTableToArray(new mAsientos().ConsultaID(p.iVueloSalida));
            }
            else
            {// Consultas de Asientos.
                disponiblesS = disponibles;
                disponibles = disponiblesR;
                iusadosS = iusados;
                iusados = iusadosR;
                array = new Controles().ConvertDataTableToArray(new mAsientos().ConsultaID(p.iVueloRegreso));
            }
            iTipoAvion = tipoAvion();
            cargarTipoPasajero();
            cargarAvion();
        }

        private void cargarTipoPasajero()
        {
            if (regreso == true)
            {
                tipoPasajero = p.bClaseVueloRegreso;
            }
            else
            {
                tipoPasajero = p.bClaseVueloSalida;
            }
        }

        private void LlenarPasajeros(int iCantidadPasajeros)
        {
            for (int i = 0; i < iCantidadPasajeros; i++)
            {
                comboPasajero.Items.Add(string.Format("{0}", p.clientes[i].NOMBRES));
                p.id_asiento_de_salida.Add(-1);
                p.id_asiento_de_regreso.Add(-1);
            }
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            ReservacionesPagar f = new ReservacionesPagar(p);
            f.Show();
            this.Close();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            //ReservacionesServicios reservaserv = new ReservacionesServicios(1,ipasajeros);
            //reservaserv.Show();
            //this.Close();
        }

        private int tipoAvion()
        {
            int itam = -1;
            switch (array.GetLength(0))
            {
                case 12:
                    itam = 1; //Tamaño chico
                    break;
                case 18:
                    itam = 2; //Tamaño Grande
                    break;
                case 28:
                    itam = 3; //Tamaño Mediano
                    break;
            }
            return itam;
        }

        private void cargarAvion()
        {
            switch (iTipoAvion)
            {
                #region Avion Chico
                case 1:
                    panelAvion1.Visible = true;
                    panelAvion1.Enabled = true;
                    if (disponibles == null)
                        disponibles = new bool[2, 6];
                    //MessageBox.Show("" + array.Length);
                    for (int i = 0; i < 12; i++)
                    {
                        if (array[i, 3].ToString() == "Y")
                        {
                            switch (i)
                            {
                                case 0: cargaImagen(pictureAvionA1, 0, 0);
                                    break;
                                case 1: cargaImagen(pictureAvionA2, 0, 1);
                                    break;
                                case 2: cargaImagen(pictureAvionA3, 0, 2);
                                    break;
                                case 3: cargaImagen(pictureAvionA4, 0, 3);
                                    break;
                                case 4: cargaImagen(pictureAvionA5, 0, 4);
                                    break;
                                case 5: cargaImagen(pictureAvionA6, 0, 5);
                                    break;
                                case 6: cargaImagen(pictureAvionB1, 1, 0);
                                    break;
                                case 7: cargaImagen(pictureAvionB2, 1, 1);
                                    break;
                                case 8: cargaImagen(pictureAvionB3, 1, 2);
                                    break;
                                case 9: cargaImagen(pictureAvionB4, 1, 3);
                                    break;
                                case 10: cargaImagen(pictureAvionB5, 1, 4);
                                    break;
                                case 11: cargaImagen(pictureAvionB6, 1, 5);
                                    break;
                            }
                        }
                    }
                    break;
                #endregion

                #region Avion Mediano
                case 2:
                    panelAvion2.Enabled = true;
                    panelAvion2.Visible = true;
                    if (disponibles == null)
                        disponibles = new bool[3, 6];

                    for (int i = 0; i < 18; i++)
                    {
                        if (array[i, 3].ToString() == "Y")
                        {
                            switch (i)
                            {
                                case 0:
                                    cargaImagen(pictureAvion2A1, 0, 0);
                                    break;
                                case 1:
                                    cargaImagen(pictureAvion2A2, 0, 1);
                                    break;
                                case 2:
                                    cargaImagen(pictureAvion2A3, 0, 2);
                                    break;
                                case 3:
                                    cargaImagen(pictureAvion2A4, 0, 3);
                                    break;
                                case 4:
                                    cargaImagen(pictureAvion2A5, 0, 4);
                                    break;
                                case 5:
                                    cargaImagen(pictureAvion2A6, 0, 5);
                                    break;
                                case 6:
                                    cargaImagen(pictureAvion2B1, 1, 0);
                                    break;
                                case 7:
                                    cargaImagen(pictureAvion2B2, 1, 1);
                                    break;
                                case 8:
                                    cargaImagen(pictureAvion2B3, 1, 2);
                                    break;
                                case 9:
                                    cargaImagen(pictureAvion2B4, 1, 3);
                                    break;
                                case 10:
                                    cargaImagen(pictureAvion2B5, 1, 4);
                                    break;
                                case 11:
                                    cargaImagen(pictureAvion2B6, 1, 5);
                                    break;
                                case 12:
                                    cargaImagen(pictureAvion2C1, 2, 0);
                                    break;
                                case 13:
                                    cargaImagen(pictureAvion2C2, 2, 1);
                                    break;
                                case 14:
                                    cargaImagen(pictureAvion2C3, 2, 2);
                                    break;
                                case 15:
                                    cargaImagen(pictureAvion2C4, 2, 3);
                                    break;
                                case 16:
                                    cargaImagen(pictureAvion2C5, 2, 4);
                                    break;
                                case 17:
                                    cargaImagen(pictureAvion2C6, 2, 5);
                                    break;
                            }
                        }
                    }
                    break;
                #endregion

                #region Avion Grande
                case 3:
                    panelAvion3.Enabled = true;
                    panelAvion3.Visible = true;
                    if (disponibles == null)
                        disponibles = new bool[4, 7];
                    for (int i = 0; i < 28; i++)
                    {
                        if (array[i, 3].ToString() == "Y")
                        {
                            switch (i)
                            {
                                case 0:
                                    cargaImagen(pictureAvion3A1, 0, 0);
                                    break;
                                case 1:
                                    cargaImagen(pictureAvion3A2, 0, 1);
                                    break;
                                case 2:
                                    cargaImagen(pictureAvion3A3, 0, 2);
                                    break;
                                case 3:
                                    cargaImagen(pictureAvion3A4, 0, 3);
                                    break;
                                case 4:
                                    cargaImagen(pictureAvion3A5, 0, 4);
                                    break;
                                case 5:
                                    cargaImagen(pictureAvion3A6, 0, 5);
                                    break;
                                case 6:
                                    cargaImagen(pictureAvion3A7, 0, 6);
                                    break;
                                case 7:
                                    cargaImagen(pictureAvion3B1, 1, 0);
                                    break;
                                case 8:
                                    cargaImagen(pictureAvion3B2, 1, 1);
                                    break;
                                case 9:
                                    cargaImagen(pictureAvion3B3, 1, 2);
                                    break;
                                case 10:
                                    cargaImagen(pictureAvion3B4, 1, 3);
                                    break;
                                case 11:
                                    cargaImagen(pictureAvion3B5, 1, 4);
                                    break;
                                case 12:
                                    cargaImagen(pictureAvion3B6, 1, 5);
                                    break;
                                case 13:
                                    cargaImagen(pictureAvion3B7, 1, 6);
                                    break;
                                case 14:
                                    cargaImagen(pictureAvion3C1, 2, 0);
                                    break;
                                case 15:
                                    cargaImagen(pictureAvion3C2, 2, 1);
                                    break;
                                case 16:
                                    cargaImagen(pictureAvion3C3, 2, 2);
                                    break;
                                case 17:
                                    cargaImagen(pictureAvion3C4, 2, 3);
                                    break;
                                case 18:
                                    cargaImagen(pictureAvion3C5, 2, 4);
                                    break;
                                case 19:
                                    cargaImagen(pictureAvion3C6, 2, 5);
                                    break;
                                case 20:
                                    cargaImagen(pictureAvion3C7, 2, 6);
                                    break;
                                case 21:
                                    cargaImagen(pictureAvion3D1, 3, 0);
                                    break;
                                case 22:
                                    cargaImagen(pictureAvion3D2, 3, 1);
                                    break;
                                case 23:
                                    cargaImagen(pictureAvion3D3, 3, 2);
                                    break;
                                case 24:
                                    cargaImagen(pictureAvion3D4, 3, 3);
                                    break;
                                case 25:
                                    cargaImagen(pictureAvion3D5, 3, 4);
                                    break;
                                case 26:
                                    cargaImagen(pictureAvion3D6, 3, 5);
                                    break;
                                case 27:
                                    cargaImagen(pictureAvion3D7, 3, 6);
                                    break;
                            }
                        }
                    }
                    break;
                #endregion
            }
        }

        /// <summary>
        /// True:Premium
        /// False:Economico
        /// </summary>
        /// <param name="sit"></param>
        /// <param name="c"></param>
        /// <param name="r"></param>
        /// <param name="tipoPasajero"></param>
        private void cargaImagen(PictureBox sit, int c, int r)
        {
            if (disponibles[c, r] == false && ((regreso == true && iusadosR > 0) || (regreso == false && iusadosS > 0)))
            {
                sit.Enabled = true;
                sit.Image = Aerolinea.Properties.Resources.AS;
                return;
            }
            if ((r == 0 || r == 1))
            {
                if (tipoPasajero == true)
                    sit.Enabled = true;
                else
                    sit.Enabled = false;
                sit.Image = Aerolinea.Properties.Resources.VIP;
                disponibles[c, r] = true;
            }
            else
            {
                if (tipoPasajero == false)
                    sit.Enabled = true;
                else
                    sit.Enabled = false;
                sit.Image = Aerolinea.Properties.Resources.AD;
                disponibles[c, r] = true;
            }
        }

        private void clickAvion(int fila, int numero, PictureBox asiento)
        {
            int idAsiento = sacarIDAsiento(generarNombreAsiento(fila, numero));
            if (disponibles[fila, numero] == true && (iusados >= ipasajeros) == false && checarAsientoPasajero(this.regreso) == false)
            {
                // True.
                gestionLista(true, idAsiento);
                asiento.Image = Aerolinea.Properties.Resources.AS;
                disponibles[fila, numero] = false;
                iusados++;
            }
            else
            {
                if (disponibles[fila, numero] == false)
                {
                    if (regreso)
                    {
                        if (idAsiento != p.id_asiento_de_regreso[comboPasajero.SelectedIndex])
                        { return; }
                    }
                    else
                    {
                        if (idAsiento != p.id_asiento_de_salida[comboPasajero.SelectedIndex])
                        { return; }
                    }
                    // False.
                    gestionLista(false, idAsiento);
                    asiento.Image = Aerolinea.Properties.Resources.AD;
                    disponibles[fila, numero] = true;
                    iusados--;
                }
            }
        }

        private bool checarAsientoPasajero(bool regreso)//Regresa true cuando esta ocupado
        {
            if (regreso == true)
            {
                if (p.id_asiento_de_regreso[comboPasajero.SelectedIndex] == -1)
                    return false;
                else
                    return true;
            }
            else
            {
                if (p.id_asiento_de_salida[comboPasajero.SelectedIndex] == -1)
                    return false;
                else
                    return true;
            }
        }

        private void gestionLista(bool ocupado, int idAsiento)
        {
            if (ocupado == true)
            {
                if (regreso == true)
                {
                    if (p.id_asiento_de_regreso[comboPasajero.SelectedIndex] == -1)
                    {
                        p.id_asiento_de_regreso[comboPasajero.SelectedIndex] = idAsiento;

                    }
                }
                else
                {
                    if (p.id_asiento_de_salida[comboPasajero.SelectedIndex] == -1)
                    {
                        p.id_asiento_de_salida[comboPasajero.SelectedIndex] = idAsiento;

                    }
                }
            }
            else
            {
                if (regreso == true)
                {
                    if (p.id_asiento_de_regreso[comboPasajero.SelectedIndex] != -1)
                    {
                        p.id_asiento_de_regreso[comboPasajero.SelectedIndex] = -1;
                    }
                }
                else
                {
                    if (p.id_asiento_de_salida[comboPasajero.SelectedIndex] != -1)
                    {
                        p.id_asiento_de_salida[comboPasajero.SelectedIndex] = -1;
                    }
                }
            }
        }
        private string generarNombreAsiento(int c, int r)
        {
            string strIDAsiento = null;
            switch (c)
            {
                case 0:
                    strIDAsiento = "A";
                    break;
                case 1:
                    strIDAsiento = "B";
                    break;
                case 2:
                    strIDAsiento = "C";
                    break;
                case 3:
                    strIDAsiento = "D";
                    break;
            }
            switch (r)
            {
                case 0:
                    strIDAsiento += "01";
                    break;
                case 1:
                    strIDAsiento += "02";
                    break;
                case 2:
                    strIDAsiento += "03";
                    break;
                case 3:
                    strIDAsiento += "04";
                    break;
                case 4:
                    strIDAsiento += "05";
                    break;
                case 5:
                    strIDAsiento += "06";
                    break;
                case 6:
                    strIDAsiento += "07";
                    break;
            }
            return strIDAsiento;
        }

        private int sacarIDAsiento(string asiento)
        {
            int j = 0;
            int id = -1;
            switch (iTipoAvion)
            {
                case 1:
                    j = 12;
                    break;
                case 2:
                    j = 18;
                    break;
                case 3:
                    j = 28;
                    break;
            }
            for (int i = 0; i < j; i++)
            {
                if (array[i, 1].ToString() == asiento)
                { id = int.Parse(array[i, 0].ToString()); break; }
            }
            return id;
        }

        #region Asientos Avion Chico
        private void pictureAvionA1_Click(object sender, EventArgs e)
        {
            clickAvion(0, 0, pictureAvionA1);
        }

        private void pictureAvionA2_Click(object sender, EventArgs e)
        {
            clickAvion(0, 1, pictureAvionA2);
        }

        private void pictureAvionA3_Click(object sender, EventArgs e)
        {
            clickAvion(0, 2, pictureAvionA3);
        }

        private void pictureAvionA4_Click(object sender, EventArgs e)
        {
            clickAvion(0, 3, pictureAvionA4);
        }

        private void pictureAvionA5_Click(object sender, EventArgs e)
        {
            clickAvion(0, 4, pictureAvionA5);
        }

        private void pictureAvionA6_Click(object sender, EventArgs e)
        {
            clickAvion(0, 5, pictureAvionA6);
        }

        private void pictureAvionB1_Click(object sender, EventArgs e)
        {
            clickAvion(1, 0, pictureAvionB1);
        }

        private void pictureAvionB2_Click(object sender, EventArgs e)
        {
            clickAvion(1, 1, pictureAvionB2);
        }

        private void pictureAvionB3_Click(object sender, EventArgs e)
        {
            clickAvion(1, 2, pictureAvionB3);
        }

        private void pictureAvionB4_Click(object sender, EventArgs e)
        {
            clickAvion(1, 3, pictureAvionB4);
        }

        private void pictureAvionB5_Click(object sender, EventArgs e)
        {
            clickAvion(1, 4, pictureAvionB5);
        }

        private void pictureAvionB6_Click(object sender, EventArgs e)
        {
            clickAvion(1, 5, pictureAvionB6);
        }
        #endregion

        #region Asientos Avion Grande
        private void pictureAvion3A1_Click(object sender, EventArgs e)
        {
            clickAvion(0, 0, pictureAvion3A1);
        }

        private void pictureAvion3A2_Click(object sender, EventArgs e)
        {
            clickAvion(0, 1, pictureAvion3A2);
        }

        private void pictureAvion3A3_Click(object sender, EventArgs e)
        {
            clickAvion(0, 2, pictureAvion3A3);
        }

        private void pictureAvion3A4_Click(object sender, EventArgs e)
        {
            clickAvion(0, 3, pictureAvion3A4);
        }

        private void pictureAvion3A5_Click(object sender, EventArgs e)
        {
            clickAvion(0, 4, pictureAvion3A5);
        }

        private void pictureAvion3A6_Click(object sender, EventArgs e)
        {
            clickAvion(0, 5, pictureAvion3A6);
        }

        private void pictureAvion3A7_Click(object sender, EventArgs e)
        {
            clickAvion(0, 6, pictureAvion3A7);
        }

        private void pictureAvion3B1_Click(object sender, EventArgs e)
        {
            clickAvion(1, 0, pictureAvion3B1);
        }

        private void pictureAvion3B2_Click(object sender, EventArgs e)
        {
            clickAvion(1, 1, pictureAvion3B2);
        }

        private void pictureAvion3B3_Click(object sender, EventArgs e)
        {
            clickAvion(1, 2, pictureAvion3B3);
        }

        private void pictureAvion3B4_Click(object sender, EventArgs e)
        {
            clickAvion(1, 3, pictureAvion3B4);
        }

        private void pictureAvion3B5_Click(object sender, EventArgs e)
        {
            clickAvion(1, 4, pictureAvion3B5);
        }

        private void pictureAvion3B6_Click(object sender, EventArgs e)
        {
            clickAvion(1, 5, pictureAvion3B6);
        }

        private void pictureAvion3B7_Click(object sender, EventArgs e)
        {
            clickAvion(1, 6, pictureAvion3B7);
        }

        private void pictureAvion3C1_Click(object sender, EventArgs e)
        {
            clickAvion(2, 0, pictureAvion3C1);
        }

        private void pictureAvion3C2_Click(object sender, EventArgs e)
        {
            clickAvion(2, 1, pictureAvion3C2);
        }

        private void pictureAvion3C3_Click(object sender, EventArgs e)
        {
            clickAvion(2, 2, pictureAvion3C3);
        }

        private void pictureAvion3C4_Click(object sender, EventArgs e)
        {
            clickAvion(2, 3, pictureAvion3C4);
        }

        private void pictureAvion3C5_Click(object sender, EventArgs e)
        {
            clickAvion(2, 4, pictureAvion3C5);
        }

        private void pictureAvion3C6_Click(object sender, EventArgs e)
        {
            clickAvion(2, 5, pictureAvion3C6);
        }

        private void pictureAvion3C7_Click(object sender, EventArgs e)
        {
            clickAvion(2, 6, pictureAvion3C7);
        }

        private void pictureAvion3D1_Click(object sender, EventArgs e)
        {
            clickAvion(3, 0, pictureAvion3D1);
        }

        private void pictureAvion3D2_Click(object sender, EventArgs e)
        {
            clickAvion(3, 1, pictureAvion3D2);
        }

        private void pictureAvion3D3_Click(object sender, EventArgs e)
        {
            clickAvion(3, 2, pictureAvion3D3);
        }

        private void pictureAvion3D4_Click(object sender, EventArgs e)
        {
            clickAvion(3, 3, pictureAvion3D4);
        }

        private void pictureAvion3D5_Click(object sender, EventArgs e)
        {
            clickAvion(3, 4, pictureAvion3D5);
        }

        private void pictureAvion3D6_Click(object sender, EventArgs e)
        {
            clickAvion(3, 5, pictureAvion3D6);
        }

        private void pictureAvion3D7_Click(object sender, EventArgs e)
        {
            clickAvion(3, 6, pictureAvion3D7);
        }
        #endregion

        #region Asientos Avion Mediano
        private void pictureAvion2A1_Click(object sender, EventArgs e)
        {
            clickAvion(0, 0, pictureAvion2A1);
        }

        private void pictureAvion2A2_Click(object sender, EventArgs e)
        {
            clickAvion(0, 1, pictureAvion2A2);
        }

        private void pictureAvion2A3_Click(object sender, EventArgs e)
        {
            clickAvion(0, 2, pictureAvion2A3);
        }

        private void pictureAvion2A4_Click(object sender, EventArgs e)
        {
            clickAvion(0, 3, pictureAvion2A4);
        }

        private void pictureAvion2A5_Click(object sender, EventArgs e)
        {
            clickAvion(0, 4, pictureAvion2A5);
        }

        private void pictureAvion2A6_Click(object sender, EventArgs e)
        {
            clickAvion(0, 5, pictureAvion2A6);
        }

        private void pictureAvion2B1_Click(object sender, EventArgs e)
        {
            clickAvion(1, 0, pictureAvion2B1);
        }

        private void pictureAvion2B2_Click(object sender, EventArgs e)
        {
            clickAvion(1, 1, pictureAvion2B2);
        }

        private void pictureAvion2B3_Click(object sender, EventArgs e)
        {
            clickAvion(1, 2, pictureAvion2B3);
        }

        private void pictureAvion2B4_Click(object sender, EventArgs e)
        {
            clickAvion(1, 3, pictureAvion2B4);
        }

        private void pictureAvion2B5_Click(object sender, EventArgs e)
        {
            clickAvion(1, 4, pictureAvion2B5);
        }

        private void pictureAvion2B6_Click(object sender, EventArgs e)
        {
            clickAvion(1, 5, pictureAvion2B6);
        }

        private void pictureAvion2C1_Click(object sender, EventArgs e)
        {
            clickAvion(2, 0, pictureAvion2C1);
        }

        private void pictureAvion2C2_Click(object sender, EventArgs e)
        {
            clickAvion(2, 1, pictureAvion2C2);
        }

        private void pictureAvion2C3_Click(object sender, EventArgs e)
        {
            clickAvion(2, 2, pictureAvion2C3);
        }

        private void pictureAvion2C4_Click(object sender, EventArgs e)
        {
            clickAvion(2, 3, pictureAvion2C4);
        }

        private void pictureAvion2C5_Click(object sender, EventArgs e)
        {
            clickAvion(2, 4, pictureAvion2C5);
        }

        private void pictureAvion2C6_Click(object sender, EventArgs e)
        {
            clickAvion(2, 5, pictureAvion2C6);
        }
        #endregion

        private void comboPasajero_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void comboVuelo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboVuelo.Items.Count < 2)
                return;
            if (comboVuelo.SelectedIndex == 0)
            {
                regreso = false;
                cargarDatos(false);
            }
            else
            {
                if (comboVuelo.SelectedIndex == 1)
                {
                    regreso = true;
                    cargarDatos(true);
                }
            }
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
