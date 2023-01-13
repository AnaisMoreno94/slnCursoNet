using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Remito:DocumentoComercial
    {
        #region Constructor
        public Remito(string Numero, DateTime Fecha, string Cliente, string Direccion, string CondicionIVA, string CondicionVenta, string Detalle, DateTime FechaEntrega, decimal Total):base(Numero, Fecha,Cliente, Direccion, CondicionIVA, CondicionVenta, Detalle, Total)
        {
            this.FechaEntrega= FechaEntrega;
        }
        #endregion

        #region Propiedades
        public DateTime FechaEntrega { get; set; } 
        #endregion

    }
}
