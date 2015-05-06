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
    public partial class ClientesContactos : Form
    {
        #region Variables
        int idContacto;
        String strNombre;
        String strApellido;
        String strPrefijo;
        String strGenero;
        String strNacimiento;
        String strTel;
        String strEmail;
        //Inicializar clase de control
        Controles elControl = new Controles();
        #endregion

        public ClientesContactos(int id)
        {
            InitializeComponent();
            //Inicialización del formulario para evitar datos vacios.
            comboGeneroContacto.SelectedIndex = 0;
            comboPrefijoContacto.SelectedIndex = 0;
            toolTip1.SetToolTip(this.buttonGuardar, "Guarda los cambios");
            toolTip1.SetToolTip(this.buttonCancelar, "Cancela los cambios");

            pContactos p = new mContactos().ConsultaID(id);
            textIDContacto.Text = p.ID_CONTACTO.ToString();
            comboPrefijoContacto.SelectedIndex = comboPrefijoContacto.Items.IndexOf(p.PREFIJO);
            textNombreContacto.Text = p.NOMBRES;
            textApellidoContacto.Text = p.APELLIDOS;
            dateTimeNacimientoContacto.Value = Convert.ToDateTime(p.FECHA_DE_NACIMIENTO);
            comboGeneroContacto.SelectedIndex = comboGeneroContacto.Items.IndexOf(p.GENERO);
            maskedTextTelefono.Text = p.TELEFONO;
            textCorreo.Text = p.CORREO_ELECTRONICO;
            textConfirmarCorreo.Text = p.CORREO_ELECTRONICO;
        }

        #region Validaciones Keypress
        private void textNombreContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            elControl.soloLetras(e);
        }

        private void textApellidoContacto_KeyPress(object sender, KeyPressEventArgs e)
        {
            elControl.soloLetras(e);
        }
        #endregion

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            //En la siguiente región se valida los campos vacios y se asignan a variables
            bool datovacio = true;
            idContacto = Convert.ToInt32(textIDContacto.Text);
            strPrefijo = comboPrefijoContacto.SelectedItem.ToString();
            if (elControl.vldCampoVacio("Nombre", textNombreContacto.Text) == true)
            {
                strNombre = textNombreContacto.Text;
            }
            else
            {
                datovacio = false;
            }
            if (elControl.vldCampoVacio("Apellido Pasajero", textApellidoContacto.Text) == true)
            {
                strApellido = textApellidoContacto.Text;
            }
            else
            {
                datovacio = false;
            }
            strNacimiento = dateTimeNacimientoContacto.Value.Date.ToString("yyyy-MM-dd");
            strGenero = comboGeneroContacto.SelectedItem.ToString();
            strTel = maskedTextTelefono.Text;
            strEmail = textCorreo.Text;
            if (datovacio == false)
            {
                //Si algún campo esta vacio no se guarda.
                return;
            }
            else
            {
                pContactos p = new pContactos();
                p.ID_CONTACTO = idContacto;
                p.PREFIJO = strPrefijo;
                p.NOMBRES = strNombre;
                p.APELLIDOS = strApellido;
                p.FECHA_DE_NACIMIENTO = strNacimiento;
                p.GENERO = strGenero;
                p.TELEFONO = strTel;
                p.CORREO_ELECTRONICO = strEmail;
                new mContactos().Editar(p);
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
