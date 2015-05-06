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
    public partial class ClientesClientes : Form
    {
        #region Variables
        int idCliente;
        String strNombre;
        String strApellido;
        String strPrefijo;
        String strGenero;
        String strNacimiento;
        //Inicializar clase de control
        Controles elControl = new Controles();
        #endregion

        public ClientesClientes(int id)
        {
            InitializeComponent();
            //Inicialización del formulario para evitar datos vacios.
            comboGenero.SelectedIndex = 0;
            comboPrefijo.SelectedIndex = 0;
            toolTip1.SetToolTip(this.buttonCambiar, "Guarda los cambios");
            toolTip1.SetToolTip(this.buttonCancelar, "Cancela los cambios");

            pClientes p = new mClientes().ConsultaID(id);
            textIDCliente.Text = p.ID_CLIENTE.ToString();
            comboPrefijo.SelectedIndex = comboPrefijo.Items.IndexOf(p.PREFIJO);
            textNombres.Text = p.NOMBRES;
            textApellidos.Text = p.APELLIDOS;
            dateTimeNacimiento.Value = Convert.ToDateTime(p.FECHA_DE_NACIMIENTO);
            comboGenero.SelectedIndex = comboGenero.Items.IndexOf(p.GENERO);
        }

        #region Validaciones
        private void textNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            elControl.soloLetras(e);
        }

        private void textApellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            elControl.soloLetras(e);
        }
        #endregion

        private void buttonCambiar_Click(object sender, EventArgs e)
        {
            //En la siguiente región se valida los campos vacios y se asignan a variables
            bool datovacio = true;
            idCliente = Convert.ToInt32(textIDCliente.Text);
            strPrefijo = comboPrefijo.SelectedItem.ToString();
            if (elControl.vldCampoVacio("Nombre", textNombres.Text) == true)
            {
                strNombre = textNombres.Text;
            }
            else
            {
                datovacio = false;
            }
            if (elControl.vldCampoVacio("Apellido Pasajero", textApellidos.Text) == true)
            {
                strApellido = textApellidos.Text;
            }
            else
            {
                datovacio = false;
            }
            strNacimiento = dateTimeNacimiento.Value.Date.ToString("yyyy-MM-dd");
            strGenero = comboGenero.SelectedItem.ToString();
            if (datovacio == false)
            {
                //Si algún campo esta vacio no se guarda.
                return;
            }
            else
            {
                //Aqui va el metodo de inserción de datos
                pClientes p = new pClientes();
                p.ID_CLIENTE = idCliente;
                p.PREFIJO = strPrefijo;
                p.NOMBRES = strNombre;
                p.APELLIDOS = strApellido;
                p.FECHA_DE_NACIMIENTO = strNacimiento;
                p.GENERO = strGenero;
                new mClientes().Editar(p);
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
