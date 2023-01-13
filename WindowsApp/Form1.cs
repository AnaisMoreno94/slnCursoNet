using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace WindowsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrearProducto_Click(object sender, EventArgs e)
        {
            Producto sprite = new Producto("Sprite", "Gaseosa Sabor Limon", 100,0.3, 0.21, "Coca-Cola", "Bebida", "Gaseosa");

            MessageBox.Show("Producto Creado: " + sprite.Nombre + ", Categoria: " + sprite.Categoria + ", SubCategoria: " + sprite.SubCategoria + ", Proveedor: " + sprite.Proveedor + ", Precio de costo: " + sprite.PrecioCosto + ", Margen de ganancia: " + (sprite.Margen * 100) + "%, IVA: " + (sprite.IVA * 100) + "%, Precio Bruto: " + Convert.ToDouble(sprite.PrecioBruto) + ", Precio Venta: " + Convert.ToDouble(sprite.PrecioVenta));

        }

        private void btnCrearCliente_Click(object sender, EventArgs e)
        {
            ClienteIndividuo Juan = new ClienteIndividuo("Juan", "Perez", "21-97035564-0", "juanpablo@hotmail.com", "11-56985467", "Av. Santa Fe, 954");

            MessageBox.Show("Cliente Creado: " + Juan.Nombre + " " + Juan.Apellido + ", CUIT: " + Juan.CUIT + ", E-mail: " + Juan.Email + ", Telefono: " + Juan.Telefono + ", Direccion:" + Juan.Direccion);


        }

        private void btnCrearEmpresa_Click(object sender, EventArgs e)
        {
            Empresa empresa = new Empresa("Coca-Cola", "12-45765789-1", "Juan Perez", "juan@coca-cola.com", "43457890", "CABA");
            MessageBox.Show($"Empresa Creada = Nombre: {empresa.Nombre}, CUIT: {empresa.CUIT}, Contacto: {empresa.Contacto}, Telefono: {empresa.Telefono}, Direccion: {empresa.Direccion}");

        }

        private void btnCrearFactura_Click(object sender, EventArgs e)
        {
            Factura factura = new Factura("A","200-00293-12", DateTime.Now,"Jumbo", "Paraguay 4542", "No-Exento","30 dias", "Venta Coca-Cola200ml x 120u", 8400);

            MessageBox.Show($"Factura Creada = Tipo: {factura.Tipo}, Numero: {factura.Numero}, Fecha: {factura.Fecha.ToString()}, Cliente: {factura.Cliente}, Direccion: {factura.Direccion}, CondicionIVA: {factura.CondicionIVA}, Condicion Venta: {factura.CondicionVenta}, Total {factura.Total}");
        }

        private void btnCrearRemito_Click(object sender, EventArgs e)
        {
            Remito remito = new Remito("200-06", DateTime.Now, "Jumbo", "Paraguay 4542", "No-Exento", "30 dias", "Venta Coca-Cola200ml x 120u", new DateTime(2023, 01, 15), 8400);

            MessageBox.Show($"Factura Creada = Numero: {remito.Numero}, Fecha: {remito.Fecha.ToString()}, Cliente: {remito.Cliente}, Direccion: {remito.Direccion}, CondicionIVA: {remito.CondicionIVA}, Condicion Venta: {remito.CondicionVenta}, Fecha de entrega: {remito.FechaEntrega.ToString()}, Total {remito.Total}");


        }

        private void btnCrearVendedor_Click(object sender, EventArgs e)
        {
            Vendedor Paco = new Vendedor("Paco", "Guzman", "96785098", "pacogusman@hotmail.com", "11-45678900", "Av. Entre rios 458");

            MessageBox.Show("Cliente Creado: " + Paco.Nombre + " " + Paco.Apellido + ", DNI: " + Paco.DNI + ", E-mail: " + Paco.Email + ", Telefono: " + Paco.Telefono + ", Direccion:" + Paco.Direccion);
        }
    }
}
