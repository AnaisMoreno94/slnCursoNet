using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Negocio
{
    public static class AdmProductos
    {
        public static List<Producto> Listar()
        {
            //Agregar un metodo para hacer un SELECT y traer una lista de productos de la db
            return null;
        }

        public static List<Producto> Listar(string Categoria)
        {
            //Agregar un metodo para hacer un SELECT BY categoria y traer una lista de productos de la db
            return null;
        }
        public static List<Producto> Listar(string Categoria, string SubCateogria)
        {
            //Agregar un metodo para hacer un SELECT BY categoria y subcategoria y traer una lista de productos de la db
            return null;
        }
        public static Producto ListarDetalle(string Nombre)
        {
            //Agregar metodo que haga un SELECT BY nombre y devuelva un solo producto 
            return null;
        }


    }
}
