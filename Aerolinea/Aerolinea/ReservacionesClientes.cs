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
    public partial class ReservacionesClientes : Form
    {
        pReservacionesAll p = new pReservacionesAll();
        Controles elControl = new Controles();

        #region Metodos Validaciones
        // Se ingresan los metodos de validaciones en la siguiente región para el formulario.
        bool vldCampoVacio(string campo, string texto)
        {
            // Si el campo es vacio despliega mensaje y regresa false.
            if (texto.Trim() == string.Empty)
            {
                MessageBox.Show("Por favor ingrese dato.", campo);
                return false; // return because we don't want to run normal code of buton click
            }
            return true;
        }
        #endregion

        public ReservacionesClientes(pReservacionesAll p)
        {
            InitializeComponent();
            // pReservaciones.
            this.p = p;
            // Variables de Pasajero.
            p.clientes = new List<pClientes>();
            // Variables de Contacto.
            p.contactos = new pContactos();
            InformacionDeVuelo();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Se añaden los controles de ayuda.
            toolTip1.SetToolTip(this.buttonContinuar, "Continuar con el registro de reservación");
            toolTip1.SetToolTip(this.comboPasajero, "Escoge un pasajero para llenar sus datos");
            // Inicializar controles.
            LlenarPasajeros(p.iPasajeros);
            comboPasajero.SelectedIndex = 0;
            comboPrefijo.SelectedIndex = 0;
            comboGenero.SelectedIndex = 0;
            comboPrefijoContacto.SelectedIndex = 0;
            comboGeneroContacto.SelectedIndex = 0;
            toolTip1.SetToolTip(this.pictureAyuda, "Ayuda");
        }

        private void LlenarPasajeros(int iCantidadPasajeros)
        {
            for (int i = 1; i <= iCantidadPasajeros; i++)
            {
                pClientes c = new pClientes();
                comboPasajero.Items.Add(string.Format("Pasajero {0}", i));
                c.PREFIJO = "Sr.";
                c.NOMBRES = null;
                c.APELLIDOS = null;
                c.FECHA_DE_NACIMIENTO = DateTime.Today.ToString();
                c.GENERO = "Hombre";
                p.clientes.Add(c);
            }
        }

        private void InformacionDeVuelo()
        {
            int salida = p.iPasajeros * p.iPrecioDeSalida;
            int regreso = p.iPasajeros * p.iPrecioDeRegreso;
            int servicios = 0;
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

        #region Controles de eventos keypress
        private void textNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Control de entrada de caracteres no validos, solo se permite letras.   
            //if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != 46))
            //{
            //    MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    e.Handled = true;
            //    return;
            //}
            elControl.soloLetras(e);
        }

        private void textApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Control de entrada de caracteres no validos, solo se permite letras.
            elControl.soloLetras(e);
        }

        private void textNombreContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            elControl.soloLetras(e);
        }

        private void textApellidoContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            elControl.soloLetras(e);
        }
        #endregion

        private void comboPasajero_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboPrefijo.SelectedIndex = comboPrefijo.Items.IndexOf(p.clientes[comboPasajero.SelectedIndex].PREFIJO);
            textNombres.Text = p.clientes[comboPasajero.SelectedIndex].NOMBRES;
            textApellidos.Text = p.clientes[comboPasajero.SelectedIndex].APELLIDOS;
            dateTimeNacimiento.Value = Convert.ToDateTime(p.clientes[comboPasajero.SelectedIndex].FECHA_DE_NACIMIENTO);
            comboGenero.SelectedIndex = comboGenero.Items.IndexOf(p.clientes[comboPasajero.SelectedIndex].GENERO);
        }

        private void checkContacto_CheckedChanged(object sender, EventArgs e)
        {
            if (checkContacto.Checked == false)
            {
                comboGeneroContacto.SelectedIndex = 0;
                comboPrefijoContacto.SelectedIndex = 0;
                textNombreContacto.Text = string.Empty;
                textApellidoContacto.Text = string.Empty;
                dateTimeNacimientoContacto.Value = DateTime.Today;
                return;
            }
            comboGeneroContacto.SelectedIndex = comboGenero.SelectedIndex;
            comboPrefijoContacto.SelectedIndex = comboPrefijo.SelectedIndex;
            textNombreContacto.Text = textNombres.Text;
            textApellidoContacto.Text = textApellidos.Text;
            dateTimeNacimientoContacto.Value = dateTimeNacimiento.Value;
        }

        private void buttonContinuar_Click(object sender, EventArgs e)
        {
            p.contactos.PREFIJO = comboPrefijoContacto.SelectedItem.ToString();
            p.contactos.NOMBRES = textNombreContacto.Text;
            p.contactos.APELLIDOS = textApellidoContacto.Text;
            p.contactos.FECHA_DE_NACIMIENTO = dateTimeNacimientoContacto.Value.Date.ToString("yyyy-MM-dd");
            p.contactos.GENERO = comboGeneroContacto.SelectedItem.ToString();
            p.contactos.TELEFONO = maskedTextTelefono.Text;
            p.contactos.CORREO_ELECTRONICO = textConfirmarCorreo.Text;
            #region Validar Correo
            //Validación de Correo Electronico
            if (vldCampoVacio("Email Contacto", textCorreo.Text) == true)
            {
                if (vldCampoVacio("Email Confirmativo Contacto", textConfirmarCorreo.Text) == true)
                {
                    if (textCorreo.Text == textConfirmarCorreo.Text)
                    {
                        try
                        {
                            var mail = new System.Net.Mail.MailAddress(p.contactos.CORREO_ELECTRONICO);
                        }
                        catch
                        {
                            MessageBox.Show("Correo no valido", "Correo");
                        }
                    }
                    else { MessageBox.Show("La confirmación de correo no fue correcta", "Confirmación Correo"); return; }
                }
                else
                { MessageBox.Show("Escriba un correo de confirmación", "Confirmación Correo"); return; }
            }
            else
            { MessageBox.Show("Escriba un correo", "Confirmación Correo"); return; }
            #endregion
            ReservacionesServicios f = new ReservacionesServicios(p);
            f.Show();
            this.Close();
        }

        private void buttonRegresar_Click(object sender, EventArgs e)
        {
            // ReservacionesVuelos reservuelo = new ReservacionesVuelos();
            // reservuelo.Show();
            // this.Close();
        }

        private void comboPrefijo_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.clientes[comboPasajero.SelectedIndex].PREFIJO = comboPrefijo.SelectedItem.ToString();
        }

        private void textNombres_TextChanged(object sender, EventArgs e)
        {
            p.clientes[comboPasajero.SelectedIndex].NOMBRES = textNombres.Text;
        }

        private void textApellidos_TextChanged(object sender, EventArgs e)
        {
            p.clientes[comboPasajero.SelectedIndex].APELLIDOS = textApellidos.Text;
        }

        private void dateTimeNacimiento_ValueChanged(object sender, EventArgs e)
        {
            p.clientes[comboPasajero.SelectedIndex].FECHA_DE_NACIMIENTO = dateTimeNacimiento.Value.Date.ToString("yyyy-MM-dd");
        }

        private void comboGenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            p.clientes[comboPasajero.SelectedIndex].GENERO = comboGenero.SelectedItem.ToString();
        }

        private void pictureAyuda_Click(object sender, EventArgs e)
        {
            AyudaClientesContactos f = new AyudaClientesContactos();
            f.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Si cierra esta ventana\nperdera los datos de reservación", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
            {
                this.Close();
            }
        }

        #region LuisAdan
        //private void buttonGuardarPasajero_Click(object sender, EventArgs e)
        //{
        //    //En la siguiente región se valida los campos vacios y se asignan a variables
        //    bool datovacio = true;
        //    if (vldCampoVacio("Nombre Pasajero", textNombres.Text) == true)
        //        strNombrePasajero = textNombres.Text;
        //    else
        //        datovacio = false;
        //    if (vldCampoVacio("Apellido Pasajero", textApellidos.Text) == true)
        //        strApellidoPasajero = textApellidos.Text;
        //    else
        //        datovacio = false;
        //    strPrefijoPasajero = comboPrefijo.SelectedItem.ToString();
        //    strGeneroPasajero = comboGenero.SelectedItem.ToString();
        //    strNacimientoPasajero = dateTimeNacimiento.Value.Date.ToString("yyyy-MM-dd");
        //    if (datovacio == false)
        //        //Si algún campo esta vacio no se guarda.
        //        return;
        //    else
        //    {
        //        //Aqui va el metodo de inserción de datos
        //        //cliente c = new cliente();
        //        //c.prefijo = strPrefijoPasajero;
        //        //c.nombres = strNombrePasajero;
        //        //c.apellidos = strApellidoPasajero;
        //        //c.fecha = strNacimientoPasajero;
        //        //c.genero = strGeneroPasajero;
        //        //new mCliente().agregar(c);
        //    }
        //}

        //private void buttonGuardarConctacto_Click(object sender, EventArgs e)
        //{
        //    bool datovacio = true;
        //    if(vldCampoVacio("Nombre Contacto",textNombreContacto.Text)==true)
        //    strNombreContacto = textNombreContacto.Text;
        //    else
        //        datovacio = false;
        //    if(vldCampoVacio("Apellido Contacto",textApellidoContacto.Text)==true)
        //    strApellidoContacto = textApellidoContacto.Text;
        //    else
        //        datovacio = false;
        //    if (maskedTextTelefono.MaskFull == true)
        //        strTelContacto = maskedTextTelefono.Text;
        //    else { MessageBox.Show("Ingrese un teléfono valido", "Teléfono"); return; }
        //    #region Validar Correo
        //    //Validación de Correo Electronico
        //    if (vldCampoVacio("Email Contacto", textCorreo.Text) == true)
        //    {
        //        if (vldCampoVacio("Email Confirmativo Contacto", textConfirmarCorreo.Text) == true)
        //        {
        //            if (textCorreo.Text == textConfirmarCorreo.Text)
        //            {
        //                try
        //                {
        //                    strEmailContacto = textConfirmarCorreo.Text;
        //                    var mail = new System.Net.Mail.MailAddress(strEmailContacto);
        //                }
        //                catch
        //                {
        //                    datovacio = false; MessageBox.Show("Correo no valido", "Correo");
        //                }
        //            }
        //            else { MessageBox.Show("La confirmación de correo no fue correcta", "Confirmación Correo"); datovacio=false; }
        //        }
        //        else
        //            datovacio = false;
        //    }
        //    else
        //        datovacio = false;
        //    #endregion
        //    strNacimientoContacto = dateTimeNacimientoContacto.Value.Date.ToString("yyyy-MM-dd");
        //    strPrefijoContacto = comboPrefijoContacto.SelectedItem.ToString();
        //    strGeneroContacto = comboGeneroContacto.SelectedItem.ToString();
        //    if (datovacio == false)
        //        //Si algún campo esta vacio no se guarda.
        //        return;
        //    else
        //    {
        //        //Aqui va el metodo de inserción de datos
        //        //contacto c = new contacto();
        //        //c.prefijo = strPrefijoContacto;
        //        //c.nombres = strNombreContacto;
        //        //c.apellidos = strApellidoContacto;
        //        //c.fecha = strNacimientoContacto;
        //        //c.genero = strGeneroContacto;
        //        //c.tel = strTelContacto;
        //        //c.email = strEmailContacto;
        //        //new mContacto().agregar(c);
        //    }
        //}

        //private void vaciarPasajero()
        //{
        //    comboPrefijo.SelectedIndex = -1;
        //    comboGenero.SelectedIndex = -1;
        //    textNombres.Text = "";
        //    textApellidos.Text = "";
        //    dateTimeNacimiento.Value = DateTime.Today;
        //}
        #endregion
    }
}
