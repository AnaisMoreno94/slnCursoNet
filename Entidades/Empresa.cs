using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empresa
    {
        #region Constructor
        public Empresa(string Nombre, string CUIT, string Contacto, string Email, string Telefono, string  Direccion) 
        {
            this.Nombre = Nombre;   
            this.CUIT = CUIT;   
            this.Contacto = Contacto;                
            this.Email = Email;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
        }
        #endregion

        #region Propiedades
        public string Nombre { get; set; }
        public string CUIT { get; set; }
        public string Contacto { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        #endregion
    }
}
