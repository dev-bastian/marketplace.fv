using Microsoft.EntityFrameworkCore;
using Market.App.Dominio;

namespace Market.App.Persistencia
{
    public class AplicationContext : DbContext
    {
        public DbSet<Usuarios> Usuario { get; set; }
        public DbSet<UsuariosRegistrados> UsuarioRegistrado { get; set; }
        public DbSet<UsuariosTiendas> UsuarioTienda { get; set; }
        public DbSet<Pedidos> Pedido { get; set; }
        public DbSet<Domicilios> Domicilio { get; set; }
        public DbSet<Compras> Compra { get; set; }
        public DbSet<Catalogo> Catalogos { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Server=localhost;Database=MarketPlaceData;User Id=sa;Password=Se13052018;");
            }
        }
    }
}