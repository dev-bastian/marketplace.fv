using System;

namespace Market.App.Dominio
{
    public class UsuariosRegistrados : Usuarios
    {
        public DateTime FechaNacimiento { get; set; }
        public string CorreoElectronico { get; set; }
        public string Direccion { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public int Documento { get; set; }
        public string MetodoPago { get; set; }
    }
}