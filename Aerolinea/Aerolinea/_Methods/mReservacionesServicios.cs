
namespace Aerolinea
{
    class mReservacionesServicios : Database
    {
        public void Agregar(int ID_RESERVACION, int ID_SERVICIO_ADICIONAL)
        {
            string strQuery = string.Format(
                "CALL RESERVACIONES_HAS_SERVICIOS_ADICIONALES_INSERT({0}, {1});",
                ID_RESERVACION, ID_SERVICIO_ADICIONAL);
            base.Agregar_WithOutMsg(strQuery);
        }

        public bool Eliminar(int ID_RESERVACION, int ID_SERVICIO_ADICIONAL)
        {
            string strQuery = string.Format(
                "CALL RESERVACIONES_HAS_SERVICIOS_ADICIONALES_DELETE({0}, {1});",
                ID_RESERVACION, ID_SERVICIO_ADICIONAL);
            return base.Eliminar(ID_SERVICIO_ADICIONAL, strQuery);
        }
    }
}
