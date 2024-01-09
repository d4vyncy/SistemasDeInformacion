using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEjemplo.Entidades;

namespace WebApiEjemplo.Services.Contracts
{
    public interface IRolService
    {
        Task<Rol> GetRol(int idrol);

        Rol GetRolPrueba();
    }
}
