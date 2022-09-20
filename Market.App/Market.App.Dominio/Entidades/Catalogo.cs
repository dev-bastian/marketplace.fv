using System;
namespace Market.App.Dominio
{
    public class Catalogo
    {
        public int Id { get; set; }
        public string NombreProductos { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
    }
}