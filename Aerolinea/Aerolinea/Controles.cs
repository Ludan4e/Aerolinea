using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;


namespace Aerolinea
{
    class Controles
    {
        public bool vldCampoVacio(string campo, string texto)
        {
            //Si el campo es vacio despliega mensaje y regresa false.
            if (texto.Trim() == string.Empty)
            {
                MessageBox.Show("¡Por favor ingrese dato!", campo);
                return false; // return because we don't want to run normal code of buton click
            }
            return true;
        }

        public void soloLetras(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != 46))
            {
                MessageBox.Show("¡Solo se permiten letras!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public void soloNumeros(KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != 46))
            {
                MessageBox.Show("¡Solo se permiten numeros!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public void soloAlfanumerico(KeyPressEventArgs e)
        {
            if (!(char.IsLetterOrDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != 46))
            {
                MessageBox.Show("¡No se permiten caracteres especiales!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        public int ID_DataGrid(DataGridView dgv, DataGridViewCellEventArgs e)
        {
            try
            {
                return Convert.ToInt32(dgv[0, dgv.CurrentRow.Index].Value);
            }
            catch (Exception)
            {
                MessageBox.Show("Ha seleccionado un campo vacío.");
                return -1;
            }
        }

        public bool vldHoraLlegada(DateTimePicker Horasalida, DateTimePicker Horallegada)
        {
            if (Horasalida.Value >= Horallegada.Value)
            { MessageBox.Show("La hora de llegada debe ser despues de la hora de salida", "Hora Llegada", MessageBoxButtons.OK, MessageBoxIcon.Asterisk); return false; }
            return true;
        }

        public bool vldDestino(string Origen, string Destino)
        {
            if (Origen == Destino)
            {
                MessageBox.Show("Escoja un destino diferente al origen", "Destino Vuelo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            return true;
        }

        public object[,] ConvertDataTableToArray(DataTable dt)
        {
            object[,] arr = new object[dt.Rows.Count, dt.Columns.Count];
            for (int row = 0; row < dt.Rows.Count; row++)
            {
                for (int col = 0; col < dt.Columns.Count; col++)
                {
                    arr[row, col] = dt.Rows[row][col];
                }
            }
            return arr;
        }
    }
}
