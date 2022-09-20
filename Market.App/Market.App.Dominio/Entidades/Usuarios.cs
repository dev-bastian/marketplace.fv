namespace Market.App.Dominio
{
    public class Usuarios
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string NumeroTelefonico { get; set; }
        public Genero Genero { get; set; }

    }
}