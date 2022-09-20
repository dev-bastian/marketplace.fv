using System.Collections.Generic;
using System.Linq;
using Market.App.Dominio;

namespace Market.App.Persistencia
{
    public class RepositorioUsuariosRegistrados : IRepositorioUsuariosRegistrados
    {
        private readonly AplicationContext _aplicationContext;

        public RepositorioUsuariosRegistrados(AplicationContext aplicationContext)
        {
            _aplicationContext = aplicationContext;
        }
        UsuariosRegistrados IRepositorioUsuariosRegistrados.AddUsuariosRegistrados(UsuariosRegistrados usuariosRegistrados)
        {
            var usuariosRegistradosAdicionados = _aplicationContext.UsuarioRegistrado.Add(usuariosRegistrados);
            _aplicationContext.SaveChanges();
            return usuariosRegistradosAdicionados.Entity;
        }

        void IRepositorioUsuariosRegistrados.DeleteUsuariosRegistrados(int idUsuariosRegistrados)
        {
            var usuariosRegistradosEncontrados = _aplicationContext.UsuarioRegistrado.FirstOrDefault(u => u.Id == idUsuariosRegistrados);
            if (usuariosRegistradosEncontrados != null)
            {
                _aplicationContext.UsuarioRegistrado.Remove(usuariosRegistradosEncontrados);
                _aplicationContext.SaveChanges();
            }
            else
            {
                return;
            }

        }
        IEnumerable<UsuariosRegistrados> IRepositorioUsuariosRegistrados.GetAllUsuariosRegistrados()
        {
            return _aplicationContext.UsuarioRegistrado;
        }
        UsuariosRegistrados IRepositorioUsuariosRegistrados.GetUsuariosRegistrados(int idUsuariosRegistrados)
        {
            return _aplicationContext.UsuarioRegistrado.FirstOrDefault(u => u.Id == idUsuariosRegistrados);
        }


        UsuariosRegistrados IRepositorioUsuariosRegistrados.UpdateUsuariosRegistrados(UsuariosRegistrados usuariosRegistrados)
        {
            var usuariosRegistradosEncontrados = _aplicationContext.UsuarioRegistrado.FirstOrDefault(u => u.Id == usuariosRegistrados.Id);
            if (usuariosRegistradosEncontrados != null)
            {
                usuariosRegistradosEncontrados.Nombre = usuariosRegistrados.Nombre;
                usuariosRegistradosEncontrados.Apellidos = usuariosRegistrados.Apellidos;
                usuariosRegistradosEncontrados.NumeroTelefonico = usuariosRegistrados.NumeroTelefonico;
                usuariosRegistradosEncontrados.Genero = usuariosRegistrados.Genero;
                usuariosRegistradosEncontrados.FechaNacimiento = usuariosRegistrados.FechaNacimiento;
                usuariosRegistradosEncontrados.CorreoElectronico = usuariosRegistrados.CorreoElectronico;
                usuariosRegistradosEncontrados.Direccion = usuariosRegistrados.Direccion;
                usuariosRegistradosEncontrados.Usuario = usuariosRegistrados.Usuario;
                usuariosRegistradosEncontrados.Contraseña = usuariosRegistrados.Contraseña;
                usuariosRegistradosEncontrados.Documento = usuariosRegistrados.Documento;
                usuariosRegistradosEncontrados.MetodoPago = usuariosRegistrados.MetodoPago;
                _aplicationContext.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("usuario no encontrado");
            }
            return usuariosRegistradosEncontrados;
        }

    }
}