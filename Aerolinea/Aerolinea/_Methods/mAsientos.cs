using System.Data;

namespace Aerolinea
{
    class mAsientos : Database
    {
        public void AgregarA(int id)
        {
            string strQuery = string.Format(
                "CALL ASIENTOS_INSERT_A({0});",
                id);
            base.Agregar_WithOutMsg(strQuery);
        }

        public void AgregarB(int id)
        {
            string strQuery = string.Format(
                "CALL ASIENTOS_INSERT_B({0});",
                id);
            base.Agregar_WithOutMsg(strQuery);
        }

        public void AgregarC(int id)
        {
            string strQuery = string.Format(
                "CALL ASIENTOS_INSERT_C({0});",
                id);
            base.Agregar_WithOutMsg(strQuery);
        }

        public void Editar(int id)
        {
            string strQuery = string.Format(
                "CALL ASIENTOS_UPDATE({0});",
                id);
            base.Editar_WithOutMsg(strQuery);
        }

        public DataTable ConsultaID(int id)
        {
            string strQuery = string.Format(
                "CALL ASIENTOS_SELECT_ID({0});",
                id);
            return base.Consultas(strQuery);
        }
    }
}
