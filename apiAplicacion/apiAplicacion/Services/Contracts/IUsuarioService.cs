using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using apiAplicacion.Models;
namespace apiAplicacion.Services.Contracts
{
   public interface IUsuarioService
    {
        Task<List<Usuario>> GetList();
        Task<Usuario> AgregaActualiza(Usuario l, string t);
        Task<Usuario> GetNombreUsuario(string nombreusuario);
        string CreaPasswordHash(string pPassword, string pSalt);
        string GenerarToken(DateTime pDate, Usuario user, TimeSpan pvalidaDate, string vSigningkey, string vAudence, string vIssuer);
    }
}
