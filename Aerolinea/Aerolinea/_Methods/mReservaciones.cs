using System.Data;

namespace Aerolinea
{
    class mReservaciones : Database
    {
        public int Agregar(pReservaciones d)
        {
            string strQuery = string.Format(
                "CALL RESERVACIONES_INSERT({0}, {1}, {2}, {3}, {4}, {5});",
                d.ID_CLIENTE, d.ID_CONTACTO, d.ID_ASIENTO, d.ID_TARJETA_DE_CREDITO, d.ID_FACTURA, d.ID_PROMOCION);
            return base.AgregarID_WithOutMsg(strQuery);
        }

        public bool Editar(pReservaciones d)
        {
            string strQuery = string.Format(
                "CALL RESERVACIONES_UPDATE({0}, {1}, {2}, {3}, {4}, {5}, {6});",
                d.ID_RESERVACION, d.ID_CLIENTE, d.ID_CONTACTO, d.ID_ASIENTO, d.ID_TARJETA_DE_CREDITO, d.ID_FACTURA, d.ID_PROMOCION);
            return base.Editar(strQuery);
        }

        public bool Eliminar(int id)
        {
            string strQuery = string.Format(
                "CALL RESERVACIONES_DELETE({0});",
                id);
            return base.Eliminar(id, strQuery);
        }

        public DataTable ConsultaAll()
        {
            string strQuery = string.Format(
                "CALL RESERVACIONES_SELECT_ALL();");
            return base.Consultas(strQuery);
        }

        public DataTable ConsultaAllID()
        {
            string strQuery = string.Format(
                "CALL RESERVACIONES_SELECT_ALL_ID();");
            return base.Consultas(strQuery);
        }

        public DataTable ConsultaClientes(string NOMBRE)
        {
            string strQuery = string.Format(
                "CALL RESERVACIONES_SELECT_CLIENTES('{0}');",
                NOMBRE);
            return base.Consultas(strQuery);
        }

        public DataTable ConsultaClientesID(string NOMBRE)
        {
            string strQuery = string.Format(
                "CALL RESERVACIONES_SELECT_CLIENTES_ID('{0}');",
                NOMBRE);
            return base.Consultas(strQuery);
        }

        public DataTable ConsultaContactos(string NOMBRE)
        {
            string strQuery = string.Format(
                "CALL RESERVACIONES_SELECT_CONTACTOS('{0}');",
                NOMBRE);
            return base.Consultas(strQuery);
        }

        public DataTable ConsultaContactosID(string NOMBRE)
        {
            string strQuery = string.Format(
                "CALL RESERVACIONES_SELECT_CONTACTOS_ID('{0}');",
                NOMBRE);
            return base.Consultas(strQuery);
        }
    }
}
