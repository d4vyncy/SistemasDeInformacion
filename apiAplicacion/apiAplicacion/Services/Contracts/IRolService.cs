using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiAplicacion.Models;
namespace apiAplicacion.Services.Contracts
{
   public interface IRolService
    {
        Task<List<Rol>> GetList();
        Task<Rol> AgregaActualiza(Rol l, string t);
    }
}
