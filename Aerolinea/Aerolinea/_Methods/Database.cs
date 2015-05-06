using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Aerolinea
{
    public abstract class Database
    {
        protected MySqlConnection Connection()
        {
            string strConnection = string.Format(
                "server = localhost;" +
                "database = aerolinea;" +
                "uid = root;" +
                "pwd = 12345;");
            MySqlConnection db = new MySqlConnection(strConnection);
            return db;
        }

        protected void Agregar(string strQuery)
        {
            MySqlConnection db = Connection();
            MySqlCommand c = new MySqlCommand(strQuery, db);
            try
            {
                db.Open();
                if (c.ExecuteNonQuery() != 0)
                {
                    MessageBox.Show("Se ha agrego la información correctamente.");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error inesperado.");
                }
                db.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        protected void Agregar_WithOutMsg(string strQuery)
        {
            MySqlConnection db = Connection();
            MySqlCommand c = new MySqlCommand(strQuery, db);
            try
            {
                db.Open();
                if (c.ExecuteNonQuery() != 0)
                {
                    //MessageBox.Show("Se ha agrego la información correctamente.");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error inesperado.");
                }
                db.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        protected int AgregarID(string strQuery)
        {
            int LAST_INSERT_ID = 0;
            MySqlConnection db = Connection();
            MySqlCommand c = new MySqlCommand(strQuery, db);
            try
            {
                db.Open();
                object exe = c.ExecuteScalar();
                if (exe != null)
                {
                    LAST_INSERT_ID = Convert.ToInt32(exe);
                    MessageBox.Show("Se ha agrego la información correctamente.");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error inesperado.");
                }
                db.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return LAST_INSERT_ID;
        }

        protected int AgregarID_WithOutMsg(string strQuery)
        {
            int LAST_INSERT_ID = 0;
            MySqlConnection db = Connection();
            MySqlCommand c = new MySqlCommand(strQuery, db);
            try
            {
                db.Open();
                object exe = c.ExecuteScalar();
                if (exe != null)
                {
                    LAST_INSERT_ID = Convert.ToInt32(exe);
                    //MessageBox.Show("Se ha agrego la información correctamente.");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error inesperado.");
                }
                db.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return LAST_INSERT_ID;
        }

        protected bool Editar(string strQuery)
        {
            bool bdr = false;
            MySqlConnection db = Connection();
            MySqlCommand c = new MySqlCommand(strQuery, db);
            DialogResult dr = MessageBox.Show(
                "¿Está seguro de que desea editar esta información?",
                "Editar Información",
                MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    db.Open();
                    if (c.ExecuteNonQuery() != 0)
                    {
                        bdr = true;
                        MessageBox.Show("Se ha editado la información correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado.");
                    }
                    db.Close();
                }
                catch (MySqlException e)
                {
                    bdr = false;
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                bdr = false;
            }
            return bdr;
        }

        protected void Editar_WithOutMsg(string strQuery)
        {
            MySqlConnection db = Connection();
            MySqlCommand c = new MySqlCommand(strQuery, db);
            try
            {
                db.Open();
                if (c.ExecuteNonQuery() != 0)
                {
                    //MessageBox.Show("Se ha editado la información correctamente.");
                }
                else
                {
                    MessageBox.Show("Ha ocurrido un error inesperado.");
                }
                db.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }

        protected bool Eliminar(int id, string strQuery)
        {
            bool bdr = false;
            MySqlConnection db = Connection();
            MySqlCommand c = new MySqlCommand(strQuery, db);
            DialogResult dr = MessageBox.Show(
                string.Format(
                    "¿Está seguro de que desea eliminar esta información de forma permanente?\r\n" +
                    "ID: {0}",
                    id),
                "Eliminar Información",
                MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    db.Open();
                    if (c.ExecuteNonQuery() != 0)
                    {
                        bdr = true;
                        MessageBox.Show("Se ha eliminado la información correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("Ha ocurrido un error inesperado.");
                    }
                    db.Close();
                }
                catch (MySqlException e)
                {
                    bdr = false;
                    MessageBox.Show(e.Message);
                }
            }
            else
            {
                bdr = false;
            }
            return bdr;
        }

        protected DataTable Consultas(string strQuery)
        {
            DataTable dt = new DataTable();
            MySqlConnection db = Connection();
            MySqlDataAdapter da = new MySqlDataAdapter(strQuery, db);
            try
            {
                db.Open();
                da.Fill(dt);
                db.Close();
            }
            catch (MySqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return dt;
        }
    }
}
