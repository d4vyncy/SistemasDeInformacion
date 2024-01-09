using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEjemplo.Entidades;

namespace WebApiEjemplo.Business.Contracts
{
    public interface IRolRepository
    {
        Task<Rol> GetRol(int idrol);
        //Task<Rol> GetNombreRol(string idrol, string nombrerol);
    }
}
