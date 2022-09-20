using System;


namespace Market.App.Dominio
{
    public class Pedidos
    {
        public int Id { get; set; }
        public DateTime FechaPedido { get; set; }
        public UsuariosRegistrados IdUsuarios { get; set; }
        public int NumProductos { get; set; }
        public int PrecioProducto { get; set; }
        public int Factura { get; set; }


    }
}