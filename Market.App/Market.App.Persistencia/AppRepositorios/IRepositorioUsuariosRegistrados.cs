using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Market.App.Dominio;

namespace Market.App.Persistencia
{
    public interface IRepositorioUsuariosRegistrados
    {
        IEnumerable<UsuariosRegistrados> GetAllUsuariosRegistrados();
        UsuariosRegistrados AddUsuariosRegistrados(UsuariosRegistrados usuariosRegistrados);
        UsuariosRegistrados UpdateUsuariosRegistrados(UsuariosRegistrados usuariosRegistrados);
        void DeleteUsuariosRegistrados(int idUsuariosRegistrados);
        UsuariosRegistrados GetUsuariosRegistrados(int idUsuariosRegistrados);

    }
}