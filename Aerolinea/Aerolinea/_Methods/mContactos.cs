using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Aerolinea
{
    class mContactos : Database
    {
        public int Agregar(pContactos d)
        {
            string strQuery = string.Format(
                "CALL CONTACTOS_INSERT('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}');",
                d.PREFIJO, d.NOMBRES, d.APELLIDOS, d.FECHA_DE_NACIMIENTO, d.GENERO, d.TELEFONO, d.CORREO_ELECTRONICO);
            return base.AgregarID_WithOutMsg(strQuery);
        }

        public bool Editar(pContactos d)
        {
            string strQuery = string.Format(
                "CALL CONTACTOS_UPDATE({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}');",
                d.ID_CONTACTO, d.PREFIJO, d.NOMBRES, d.APELLIDOS, d.FECHA_DE_NACIMIENTO, d.GENERO, d.TELEFONO, d.CORREO_ELECTRONICO);
            return base.Editar(strQuery);
        }

        public bool Eliminar(int id)
        {
            string strQuery = string.Format(
                "CALL CONTACTOS_DELETE({0});",
                id);
            return base.Eliminar(id, strQuery);
        }

        public pContactos ConsultaID(int id)
        {
            pContactos p = new pContactos();
            MySqlConnection db = base.Connection();
            string strQuery = string.Format(
                "CALL CONTACTOS_SELECT_ID({0});",
                id);
            MySqlCommand c = new MySqlCommand(strQuery, db);
            try
            {
                db.Open();
                MySqlDataReader dr = c.ExecuteReader();
                dr.Read();
                p.ID_CONTACTO = dr.GetInt32(0);
                p.PREFIJO = dr.GetString(1);
                p.NOMBRES = dr.GetString(2);
                p.APELLIDOS = dr.GetString(3);
                p.FECHA_DE_NACIMIENTO = dr.GetString(4);
                p.GENERO = dr.GetString(5);
                p.TELEFONO = dr.GetString(6);
                p.CORREO_ELECTRONICO = dr.GetString(7);
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
                "CALL CONTACTOS_SELECT_ALL();");
            return base.Consultas(strQuery);
        }
    }
}
