using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Aerolinea
{
    class mVuelos : Database
    {
        public int Agregar(pVuelos d)
        {
            string strQuery = string.Format(
                "CALL VUELOS_INSERT('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');",
                d.AVION, d.FECHA_DE_SALIDA, d.PRECIO, d.HORA_DE_SALIDA, d.ORIGEN, d.HORA_DE_LLEGADA, d.DESTINO);
            return base.AgregarID(strQuery);
        }

        public bool Editar(pVuelos d)
        {
            string strQuery = string.Format(
                "CALL VUELOS_UPDATE({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');",
                d.ID_VUELO, d.AVION, d.FECHA_DE_SALIDA, d.PRECIO, d.HORA_DE_SALIDA, d.ORIGEN, d.HORA_DE_LLEGADA, d.DESTINO);
            return base.Editar(strQuery);
        }

        public bool Eliminar(int id)
        {
            string strQuery = string.Format(
                "CALL VUELOS_DELETE({0});",
                id);
            return base.Eliminar(id, strQuery);
        }

        public pVuelos ConsultaID(int id)
        {
            pVuelos p = new pVuelos();
            MySqlConnection db = base.Connection();
            string strQuery = string.Format(
                "CALL VUELOS_SELECT_ID({0});",
                id);
            MySqlCommand c = new MySqlCommand(strQuery, db);
            try
            {
                db.Open();
                MySqlDataReader dr = c.ExecuteReader();
                dr.Read();
                p.ID_VUELO = dr.GetInt32(0);
                p.AVION = dr.GetString(1);
                p.FECHA_DE_SALIDA = dr.GetString(2);
                p.PRECIO = dr.GetString(3);
                p.HORA_DE_SALIDA = dr.GetString(4);
                p.ORIGEN = dr.GetString(5);
                p.HORA_DE_LLEGADA = dr.GetString(6);
                p.DESTINO = dr.GetString(7);
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
                "CALL VUELOS_SELECT_ALL();");
            return base.Consultas(strQuery);
        }

        public DataTable ConsultaFecha(string FECHA_DE_SALIDA)
        {
            string strQuery = string.Format(
                "CALL VUELOS_SELECT_FECHA('{0}');",
                FECHA_DE_SALIDA);
            return base.Consultas(strQuery);
        }

        public DataTable ConsultaBuscar(int PASAJEROS, string FECHA_DE_SALIDA, string ORIGEN, string DESTINO)
        {
            string strQuery = string.Format(
                "CALL VUELOS_SELECT_BUSCAR({0}, '{1}', '{2}', '{3}');",
                PASAJEROS, FECHA_DE_SALIDA, ORIGEN, DESTINO);
            return base.Consultas(strQuery);
        }
    }
}
