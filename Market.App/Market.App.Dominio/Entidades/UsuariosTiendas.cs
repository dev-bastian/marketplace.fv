using System;
using System.Collections.Generic;

namespace Market.App.Dominio
{
    public class UsuariosTiendas : Usuarios
    {
        public Catalogo Catalogo { get; set; }
        public string HorarioAtencion { get; set; }
        public string NombreTienda { get; set; }
        public int Nit { get; set; }
        public Domicilios Domicilios { get; set; }

    }
}