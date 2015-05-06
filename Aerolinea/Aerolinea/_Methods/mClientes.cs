using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Aerolinea
{
    class mClientes : Database
    {
        public int Agregar(pClientes d)
        {
            string strQuery = string.Format(
                "CALL CLIENTES_INSERT('{0}', '{1}', '{2}', '{3}', '{4}');",
                d.PREFIJO, d.NOMBRES, d.APELLIDOS, d.FECHA_DE_NACIMIENTO, d.GENERO);
            return base.AgregarID_WithOutMsg(strQuery);
        }

        public bool Editar(pClientes d)
        {
            string strQuery = string.Format(
                "CALL CLIENTES_UPDATE({0}, '{1}', '{2}', '{3}', '{4}', '{5}');",
                d.ID_CLIENTE, d.PREFIJO, d.NOMBRES, d.APELLIDOS, d.FECHA_DE_NACIMIENTO, d.GENERO);
            return base.Editar(strQuery);
        }

        public bool Eliminar(int id)
        {
            string strQuery = string.Format(
                "CALL CLIENTES_DELETE({0});",
                id);
            return base.Eliminar(id, strQuery);
        }

        public pClientes ConsultaID(int id)
        {
            pClientes p = new pClientes();
            MySqlConnection db = base.Connection();
            string strQuery = string.Format(
                "CALL CLIENTES_SELECT_ID({0});",
                id);
            MySqlCommand c = new MySqlCommand(strQuery, db);
            try
            {
                db.Open();
                MySqlDataReader dr = c.ExecuteReader();
                dr.Read();
                p.ID_CLIENTE = dr.GetInt32(0);
                p.PREFIJO = dr.GetString(1);
                p.NOMBRES = dr.GetString(2);
                p.APELLIDOS = dr.GetString(3);
                p.FECHA_DE_NACIMIENTO = dr.GetString(4);
                p.GENERO = dr.GetString(5);
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
                "CALL CLIENTES_SELECT_ALL();");
            return base.Consultas(strQuery);
        }
    }
}
