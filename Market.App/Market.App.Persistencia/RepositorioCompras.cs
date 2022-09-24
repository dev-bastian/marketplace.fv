using System.Collections.Generic;
using System.Linq;
using Market.App.Dominio;

namespace Market.App.Persistencia
{
    public class RepositorioCompras : IRepositorioCompras  
    {
        private readonly AplicationContext _aplicationContext;

        public  RepositorioCompras(AplicationContext aplicationContext)
        {
            _aplicationContext = aplicationContext;
        }

        Compras IRepositorioCompras.AddCompras(Compras compras)
        {
            var comprasAdicionadas = _aplicationContext.Compra.Add(compras);
            _aplicationContext.SaveChanges();
            return comprasAdicionadas.Entity;
        }

        void IRepositorioCompras.DeleteCompras(int idCompras)
        {
            var comprasEncontradas = _aplicationContext.Compra.FirstOrDefault(c => c.Id == idCompras);
            if (comprasEncontradas != null)
            {
               _aplicationContext.Compra.Remove(comprasEncontradas);
               _aplicationContext.SaveChanges();
            }
            else
            {
                return;
            }
        }

        IEnumerable <Compras> IRepositorioCompras.GetAllCompras()
        {
            return _aplicationContext.Compra;
        }
        
        Compras IRepositorioCompras.GetCompras(int idCompras)
        {
            return _aplicationContext.Compra.FirstOrDefault(c => c.Id == idCompras);
        }

        Compras IRepositorioCompras.UpdateCompras(Compras compras)
        {
            var comprasEncontradas = _aplicationContext.Compra.FirstOrDefault(c => c.Id == compras.Id);
            if (comprasEncontradas != null)
            {
                comprasEncontradas.MetodoPago = compras.MetodoPago;
                comprasEncontradas.OpcionEntrega = compras.OpcionEntrega;
                comprasEncontradas. IdPedidos = compras.IdPedidos;
                _aplicationContext.SaveChanges();
            }
            else
            {
                System.Console.WriteLine("Usuario no encontrado");
            }
            return comprasEncontradas;
        }

    }
}