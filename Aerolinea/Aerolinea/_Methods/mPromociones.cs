using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Aerolinea
{
    class mPromociones : Database
    {
        public void Agregar(pPromociones d)
        {
            string strQuery = string.Format(
                "CALL PROMOCIONES_INSERT('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');",
                d.NOMBRE, d.DESCRIPCION, d.DESCUENTO, d.CODIGO, d.VIGENCIA_INICIAL, d.VIGENCIA_FINAL);
            base.Agregar(strQuery);
        }

        public bool Editar(pPromociones d)
        {
            string strQuery = string.Format(
                "CALL PROMOCIONES_UPDATE({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');",
                d.ID_PROMOCION, d.NOMBRE, d.DESCRIPCION, d.DESCUENTO, d.CODIGO, d.VIGENCIA_INICIAL, d.VIGENCIA_FINAL);
            return base.Editar(strQuery);
        }

        public bool Eliminar(int id)
        {
            string strQuery = string.Format(
                "CALL PROMOCIONES_DELETE({0});",
                id);
            return base.Eliminar(id, strQuery);
        }

        public pPromociones ConsultaID(int id)
        {
            pPromociones p = new pPromociones();
            MySqlConnection db = base.Connection();
            string strQuery = string.Format(
                "CALL PROMOCIONES_SELECT_ID({0});",
                id);
            MySqlCommand c = new MySqlCommand(strQuery, db);
            try
            {
                db.Open();
                MySqlDataReader dr = c.ExecuteReader();
                dr.Read();
                p.ID_PROMOCION = dr.GetInt32(0);
                p.NOMBRE = dr.GetString(1);
                p.DESCRIPCION = dr.GetString(2);
                p.DESCUENTO = dr.GetString(3);
                p.CODIGO = dr.GetString(4);
                p.VIGENCIA_INICIAL = dr.GetString(5);
                p.VIGENCIA_FINAL = dr.GetString(6);
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
                "CALL PROMOCIONES_SELECT_ALL();");
            return base.Consultas(strQuery);
        }

        public DataTable ConsultaCombo()
        {
            string strQuery = string.Format(
                "CALL PROMOCIONES_SELECT_COMBO();");
            return base.Consultas(strQuery);
        }

        public DataTable ConsultaBuscar(string NOMBRE)
        {
            string strQuery = string.Format(
                "CALL PROMOCIONES_SELECT_NOMBRE('{0}');",
                NOMBRE);
            return base.Consultas(strQuery);
        }
    }
}
