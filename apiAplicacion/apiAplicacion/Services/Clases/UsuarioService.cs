using apiAplicacion.Business.Contracts;
using apiAplicacion.Models;
using apiAplicacion.Services.Contracts;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;


//using System.IdentityModel.Tokens.Jwt;
//using Microsoft.IdentityModel.Tokens;


namespace apiAplicacion.Services.Clases
{
    public class UsuarioService : IUsuarioService
    {
        private readonly IUsuarioRepository _IUsuarioRepository;
        public UsuarioService(IUsuarioRepository tempI)
        {
            _IUsuarioRepository = tempI;
        }
        public Task<List<Usuario>> GetList()
        {
            return _IUsuarioRepository.GetList();
        }
        public Task<Usuario> AgregaActualiza(Usuario l, string t)
        {
            return _IUsuarioRepository.AgregaActualiza(l, t);
        }
        public Task<Usuario> GetNombreUsuario(string nombreusuario)
        {
            return _IUsuarioRepository.GetNombreUsuario(nombreusuario);
        }
        public string CreaPasswordHash(string pPassword, string pSalt)
        {
            string cUnion = string.Concat(pPassword, pSalt);
            using (var sha1 = SHA1.Create())
            {

                var result = sha1.ComputeHash(Encoding.UTF8.GetBytes(cUnion));

                var strResult = BitConverter.ToString(result);

                return strResult.Replace("-", "").ToUpper();

            }
        }
        public string GenerarToken(DateTime pDate, Usuario user, TimeSpan pvalidaDate, string vSigningkey, string vAudence, string vIssuer)
        {
            //string array
            string vRolSerial = "";
            //Obtener roles.            
            var vRoles = 1; //_ITrnRolUsuarioRepository.ObtenerUsuarioRol(user.IdUsuario.Value);
                            // verifica si la consulta es vacia
                            //if (vRoles != null)
                            //{
                            //    vRolSerial = JsonSerializer.Serialize(vRoles);
                            //}
            vRolSerial = JsonSerializer.Serialize(vRoles);
            // tiempo de expiracion.
            var vTokenExpira = pDate.Add(pvalidaDate);
            ///definicion del claim
            var vClaims = new Claim[]
            {
                new  Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),//identificador del token
                new  Claim(
                     JwtRegisteredClaimNames.Iat,
                     new DateTimeOffset(pDate).ToUniversalTime().ToUnixTimeSeconds().ToString(),
                     ClaimValueTypes.Integer64),
                new  Claim("NombreUsuario",user.NombreUsuario),
                new  Claim("IdUsuario",user.IdUsuario.ToString())
            };
            ///varibles de la configuracion.
            var vSigningCredentials = new Microsoft.IdentityModel.Tokens.SigningCredentials(
                new SymmetricSecurityKey(Encoding.ASCII.GetBytes(vSigningkey)),
                SecurityAlgorithms.HmacSha256Signature
                );
            ///token cifrado..
            var jwt = new JwtSecurityToken(
                issuer: vIssuer,
                audience: vAudence,
                claims: vClaims,
                notBefore: pDate,
                expires: vTokenExpira,
                signingCredentials: vSigningCredentials
                );
            ///codificacion de token.
            var vEncodeJwt = new JwtSecurityTokenHandler().WriteToken(jwt);
            return vEncodeJwt;
        }
    }
}
