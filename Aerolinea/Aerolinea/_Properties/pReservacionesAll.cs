using System.Collections.Generic;

namespace Aerolinea
{
    public class pReservacionesAll
    {
        public List<pClientes> clientes { get; set; }
        public pContactos contactos { get; set; }
        public List<List<int>> id_servicio_adicional { get; set; }
        public List<int> id_asiento_de_salida { get; set; }
        public List<int> id_asiento_de_regreso { get; set; }
        public pTarjetasDeCredito tarjetasDeCredito { get; set; }
        public pFacturas facturas { get; set; }
        public int id_promocion { get; set; }

        // Datos Extras.
        public string strOrigen { get; set; }
        public string strDestino { get; set; }
        public string strFechaDeSalida { get; set; }
        public string strFechaDeRegreso { get; set; }
        public int iAdultos { get; set; }
        public int iMenor { get; set; }
        public int iInfantes { get; set; }
        public int iVueloSalida { get; set; }
        public int iVueloRegreso { get; set; }
        public bool bClaseVueloSalida { get; set; }
        public bool bClaseVueloRegreso { get; set; }

        // Información del Vuelo.
        public int iPasajeros { get; set; }
        public int iPrecioDeSalida { get; set; }
        public int iPrecioDeRegreso { get; set; }
        public float iDescuento { get; set; }
        public int iServicios { get; set; }
    }
}
