using apiAplicacion.Models;
using apiAplicacion.Services.Contracts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiAplicacion.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolController
    {
        private readonly IRolService _IRolService;
        public RolController(IRolService iTemp)
        {
            this._IRolService = iTemp;
        }
        [HttpGet]
        [Authorize]
        //[Produces("application/json", Type = typeof(Resultado))]        
        public async Task<List<Rol>> GetList()
        {
            return await _IRolService.GetList();
        }
        [HttpPost("AgregaActualiza")]
        //[Produces("application/json", Type = typeof(Resultado))]
        [Authorize]
        public async Task<Rol> AgregaActualiza(
      int Id,string NombreRol, string t)
        {
            Rol l = new Rol();
            l.Id = Id;
            l.NombreRol = NombreRol;            
            return await _IRolService.AgregaActualiza(l, t);
        }
    }
}
