using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{

    
    public class ClienteIndividuo:Persona
    {
        #region Constructor
        public ClienteIndividuo(string Nombre, string Apellido, string CUIT, string Email,string Telefono, string Direccion ): base(Nombre, Apellido, Email, Telefono, Direccion) 
        {
            this.CUIT = CUIT;
        }
        #endregion

        #region Propiedades
        public string CUIT { get; set; }
        #endregion    
    }
    
}
