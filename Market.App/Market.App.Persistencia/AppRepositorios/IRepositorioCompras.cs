using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Market.App.Dominio;

namespace Market.App.Persistencia
{
    public interface IRepositorioCompras
    {
        IEnumerable<Compras> GetAllCompras();
        Compras AddCompras(Compras compras);
        Compras UpdateCompras(Compras compras);
        void DeleteCompras(int idCompras);
        Compras GetCompras(int idCompras);
    }
}