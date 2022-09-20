using System;

namespace Market.App.Dominio
{
    public class Compras
    {
        public int Id { get; set; }
        public string MetodoPago { get; set; }
        public string OpcionEntrega { get; set; }
        public Pedidos IdPedidos { get; set; }

    }
}