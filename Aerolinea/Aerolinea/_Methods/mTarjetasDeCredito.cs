using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Aerolinea
{
    class mTarjetasDeCredito : Database
    {
        public int Agregar(pTarjetasDeCredito d)
        {
            string strQuery = string.Format(
                "CALL TARJETAS_DE_CREDITO_INSERT('{0}', '{1}', '{2}', '{3}', '{4}', '{5}');",
                d.TIPO_DE_TARJETA_DE_CREDITO, d.TITULAR_DE_LA_TARJETA, d.NUMERO_DE_TARJETA, d.VENCIMIENTO_MES, d.VENCIMIENTO_ANIO, d.NUMERO_DE_SEGURIDAD);
            return base.AgregarID_WithOutMsg(strQuery);
        }

        public bool Editar(pTarjetasDeCredito d)
        {
            string strQuery = string.Format(
                "CALL TARJETAS_DE_CREDITO_UPDATE({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');",
                d.ID_TARJETA_DE_CREDITO, d.TIPO_DE_TARJETA_DE_CREDITO, d.TITULAR_DE_LA_TARJETA, d.NUMERO_DE_TARJETA, d.VENCIMIENTO_MES, d.VENCIMIENTO_ANIO, d.NUMERO_DE_SEGURIDAD);
            return base.Editar(strQuery);
        }

        public bool Eliminar(int id)
        {
            string strQuery = string.Format(
                "CALL TARJETAS_DE_CREDITO_DELETE({0});",
                id);
            return base.Eliminar(id, strQuery);
        }

        public pTarjetasDeCredito ConsultaID(int id)
        {
            pTarjetasDeCredito p = new pTarjetasDeCredito();
            MySqlConnection db = base.Connection();
            string strQuery = string.Format(
                "CALL TARJETAS_DE_CREDITO_SELECT_ID({0});",
                id);
            MySqlCommand c = new MySqlCommand(strQuery, db);
            try
            {
                db.Open();
                MySqlDataReader dr = c.ExecuteReader();
                dr.Read();
                p.ID_TARJETA_DE_CREDITO = dr.GetInt32(0);
                p.TIPO_DE_TARJETA_DE_CREDITO = dr.GetString(1);
                p.TITULAR_DE_LA_TARJETA = dr.GetString(2);
                p.NUMERO_DE_TARJETA = dr.GetString(3);
                p.VENCIMIENTO_MES = dr.GetString(4);
                p.VENCIMIENTO_ANIO = dr.GetString(5);
                p.NUMERO_DE_SEGURIDAD = dr.GetString(6);
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
                "CALL TARJETAS_DE_CREDITO_SELECT_ALL();");
            return base.Consultas(strQuery);
        }
    }
}
