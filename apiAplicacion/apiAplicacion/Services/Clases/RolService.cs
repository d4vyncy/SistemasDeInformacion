using apiAplicacion.Business.Contracts;
using apiAplicacion.Models;
using apiAplicacion.Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiAplicacion.Services.Clases
{
    public class RolService : IRolService
    {
        private readonly IRolRepository _IRolRepository;
        public RolService(IRolRepository tempI)
        {
            _IRolRepository = tempI;
        }
        public Task<List<Rol>> GetList()
        {
            return _IRolRepository.GetList();
        }
        public Task<Rol> AgregaActualiza(Rol l, string t)
        {
            return _IRolRepository.AgregaActualiza(l, t);
        }
    }
}
