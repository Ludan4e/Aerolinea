using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Aerolinea
{
    class mServiciosAdicionales : Database
    {
        public void Agregar(pServiciosAdicionales d)
        {
            string strQuery = string.Format(
                "CALL SERVICIOS_ADICIONALES_INSERT('{0}', '{1}', '{2}');",
                d.NOMBRE, d.DESCRIPCION, d.PRECIO);
            base.Agregar(strQuery);
        }

        public bool Editar(pServiciosAdicionales d)
        {
            string strQuery = string.Format(
                "CALL SERVICIOS_ADICIONALES_UPDATE({0}, '{1}', '{2}', '{3}');",
                d.ID_SERVICIO_ADICIONAL, d.NOMBRE, d.DESCRIPCION, d.PRECIO);
            return base.Editar(strQuery);
        }

        public bool Eliminar(int id)
        {
            string strQuery = string.Format(
                "CALL SERVICIOS_ADICIONALES_DELETE({0});",
                id);
            return base.Eliminar(id, strQuery);
        }

        public pServiciosAdicionales ConsultaID(int id)
        {
            pServiciosAdicionales p = new pServiciosAdicionales();
            MySqlConnection db = base.Connection();
            string strQuery = string.Format(
                "CALL SERVICIOS_ADICIONALES_SELECT_ID({0});",
                id);
            MySqlCommand c = new MySqlCommand(strQuery, db);
            try
            {
                db.Open();
                MySqlDataReader dr = c.ExecuteReader();
                dr.Read();
                p.ID_SERVICIO_ADICIONAL = dr.GetInt32(0);
                p.NOMBRE = dr.GetString(1);
                p.DESCRIPCION = dr.GetString(2);
                p.PRECIO = dr.GetString(3);
                db.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return p;
        }

        public DataTable ConsultaAll()
        {
            string strQuery = string.Format(
                "CALL SERVICIOS_ADICIONALES_SELECT_ALL();");
            return base.Consultas(strQuery);
        }

        public DataTable ConsultaBuscar(string NOMBRE)
        {
            string strQuery = string.Format(
                "CALL SERVICIOS_ADICIONALES_SELECT_NOMBRE('{0}');",
                NOMBRE);
            return base.Consultas(strQuery);
        }
    }
}
