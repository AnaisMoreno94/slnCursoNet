using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Constructor
        public Persona(string Nombre, string Apellido, string Email, string Telefono, string Direccion)
        {
            this.Nombre = Nombre;
            this.Apellido = Apellido;
            this.Email = Email;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
        }
        #endregion

        #region Propiedades
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        #endregion
    }
}
