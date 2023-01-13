using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vendedor:Persona
    {
        #region Constructor
        public Vendedor(string Nombre, string Apellido, string DNI, string Email, string Telefono, string Direccion):base(Nombre, Apellido,Email,Telefono,Direccion)
        { 
            this.DNI = DNI;
        }
        #endregion

        #region Propiedades
        public string DNI { get; set; }
  
        #endregion

    }
}
