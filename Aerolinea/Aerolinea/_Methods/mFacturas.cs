using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Aerolinea
{
    class mFacturas : Database
    {
        public int Agregar(pFacturas d)
        {
            string strQuery = string.Format(
                "CALL FACTURAS_INSERT('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');",
                d.RFC, d.DIRECCION, d.PAIS, d.ESTADO, d.CIUDAD, d.CODIGO_POSTAL, d.TELEFONO, d.CORREO_ELECTRONICO);
            return base.AgregarID_WithOutMsg(strQuery);
        }

        public bool Editar(pFacturas d)
        {
            string strQuery = string.Format(
                "CALL FACTURAS_UPDATE({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}');",
                d.ID_FACTURA, d.RFC, d.DIRECCION, d.PAIS, d.ESTADO, d.CIUDAD, d.CODIGO_POSTAL, d.TELEFONO, d.CORREO_ELECTRONICO);
            return base.Editar(strQuery);
        }

        public bool Eliminar(int id)
        {
            string strQuery = string.Format(
                "CALL FACTURAS_DELETE({0});",
                id);
            return base.Eliminar(id, strQuery);
        }

        public pFacturas ConsultaID(int id)
        {
            pFacturas p = new pFacturas();
            MySqlConnection db = base.Connection();
            string strQuery = string.Format(
                "CALL FACTURAS_SELECT_ID({0});",
                id);
            MySqlCommand c = new MySqlCommand(strQuery, db);
            try
            {
                db.Open();
                MySqlDataReader dr = c.ExecuteReader();
                dr.Read();
                p.ID_FACTURA = dr.GetInt32(0);
                p.RFC = dr.GetString(1);
                p.DIRECCION = dr.GetString(2);
                p.PAIS = dr.GetString(3);
                p.ESTADO = dr.GetString(4);
                p.CIUDAD = dr.GetString(5);
                p.CODIGO_POSTAL = dr.GetString(6);
                p.TELEFONO = dr.GetString(7);
                p.CORREO_ELECTRONICO = dr.GetString(8);
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
                "CALL FACTURAS_SELECT_ALL();");
            return base.Consultas(strQuery);
        }
    }
}
