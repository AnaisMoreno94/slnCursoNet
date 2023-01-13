using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public static class AdmCliente
    {
        public static List<ClienteIndividuo> ListarClienteIndividuo()
        {
            //TODO: Agregar metodo para realizar un SELECT y devolver los clientes de la db.
            return null;
        }
        public static ClienteIndividuo ListarClienteIndividuo(string CUIT) 
        {
            //TODO: Agregar metodo para realizar un SELECT a partir de un cuit y devolver un Cliente de la db
            return null;
        }
        public static List<Empresa> ListarClienteEmpresa(string CUIT)
        {
            //TODO: Agregar metodo para realizar un SELECT  a partir de un cuit y devolver una empresa de la db
            return null;
        }
        public static Empresa ListarClienteEmpresa()
        {
            //TODO: Agregar metodo para realizar un SELECT y devolver una lista de empresas de la db
            return null;
        }
    }
}
