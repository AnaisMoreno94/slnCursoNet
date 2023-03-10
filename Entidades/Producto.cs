using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Producto
    {
        #region Constructor
        public Producto(string Nombre, string Descripcion, decimal PrecioCosto, double Margen, double IVA, string Proveedor, string Categoria, string SubCategoria) 
        {
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
            this.PrecioCosto = PrecioCosto;
            this.Margen = Margen;
            this.IVA = IVA;
            this.Proveedor = Proveedor;
            this.Categoria = Categoria;
            this.SubCategoria = SubCategoria;
        }
        #endregion

        #region Propiedades
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal PrecioCosto { get; set; }
        public double Margen { get; set; }
        public double IVA { get; set; }
        public decimal PrecioBruto
        {
            get { return (PrecioCosto + (PrecioCosto * Convert.ToDecimal(this.Margen))); }

        }
        public decimal PrecioVenta
        {
            get { return PrecioBruto * Convert.ToDecimal(1 + this.IVA); }
        }
        public string Proveedor { get; set; }

        public string Categoria { get; set; }
        public string SubCategoria { get; set; }        
        #endregion

    }
}
