using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEjemplo.Business.Contracts;
using WebApiEjemplo.Entidades;
using WebApiEjemplo.Services.Contracts;

namespace WebApiEjemplo.Services.Clases
{
    public class RolService : IRolService
    {
        private readonly IRolRepository _IRolRepository;
        public RolService(IRolRepository tempI)
        {
            _IRolRepository = tempI;
        }
        public Task<Rol> GetRol(int idrol)
        {
            return _IRolRepository.GetRol(idrol);
        }
        public Rol GetRolPrueba()
        {
            return new Rol
            {
                Id = 1,
                NombreRol= "Code"                
            }; 
        }
    }
}
