using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiAplicacion.Models;

namespace apiAplicacion.Business.Contracts
{

    public interface IUsuarioRepository
    {
        Task<List<Usuario>> GetList();
        Task<Usuario> AgregaActualiza(Usuario l, string t);
        Task<Usuario> GetNombreUsuario(string nombreusuario);
    }
}