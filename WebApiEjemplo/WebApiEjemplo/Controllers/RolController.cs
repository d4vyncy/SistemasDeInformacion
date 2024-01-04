using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEjemplo.Entidades;

namespace WebApiEjemplo.Controllers
{
    [ApiController]
    [Route("api/rol")]
    public class RolController : ControllerBase
    {
        private readonly ApplicationDbContext context;
        public RolController(ApplicationDbContext context)
        {
            this.context = context;
        }

        //[HttpGet]
        //public ActionResult<List<Rol>> Get()
        //{
        //    return context.Roles.ToList();
        //}

        [HttpGet]
        public async Task< ActionResult<List<Rol>>> Get()
        {
            return context.Roles.ToList();
        }

        [HttpPost]
        public async Task<ActionResult> Post(Rol rol)
        {
            context.Add(rol);
            await context.SaveChangesAsync();
            return Ok();
        }
    }
}
