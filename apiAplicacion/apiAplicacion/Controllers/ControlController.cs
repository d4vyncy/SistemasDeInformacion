using apiAplicacion.Models;
using apiAplicacion.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiAplicacion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControlController : ControllerBase
    {
        private readonly IConfiguration _Configuration;
        private readonly IUsuarioService _IUsuarioService;
        public ControlController(IConfiguration Configuration, IUsuarioService UsuarioService)
        {
            _IUsuarioService = UsuarioService;
            _Configuration = Configuration;
        }
        [HttpPost("CrearToken")]
        //[Produces("application/json", Type = typeof(Resultado))]
        public async Task<TokenModelo> PostToken(string plogin, string ppassword)
        {
            TokenModelo token = new TokenModelo();
            var vObjUsuario = await _IUsuarioService.GetNombreUsuario(plogin);
            //verifica si existe el objeto.
            if (vObjUsuario != null)
            {
                var clave = _IUsuarioService.CreaPasswordHash(ppassword, vObjUsuario.Salt);
                if (clave == vObjUsuario.Clave)
                {
                    var vDate = DateTime.UtcNow;
                    //define tiempo del token[TODO].
                    var expirateDate = TimeSpan.FromMinutes(10);
                    var expireDateTime = vDate.Add(expirateDate);

                    string vIssuer = _Configuration.GetSection("AuthentificationSettings").GetChildren().Where(x => x.Key == "Issuer").Select(x => x.Value).FirstOrDefault();
                    string vAudience = _Configuration.GetSection("AuthentificationSettings").GetChildren().Where(x => x.Key == "Audence").Select(x => x.Value).FirstOrDefault();
                    string vSigningkey = _Configuration.GetSection("AuthentificationSettings").GetChildren().Where(x => x.Key == "Signingkey").Select(x => x.Value).FirstOrDefault();

                    //obtiene data
                    token.token = _IUsuarioService.GenerarToken(vDate, vObjUsuario, expirateDate, vSigningkey, vAudience, vIssuer);
                    token.tiempoExpira = expireDateTime;
                    //asigna token.                
                }
                else
                {
                    //vResultado.Notificacion = "Error de contraseña";
                    //vResultado.Correcto = false;
                }
            }


            else
            {
                //vResultado.Notificacion = "Usuario no existente";
                //vResultado.Correcto = false;
            }
            return token;
        }
    }
}
