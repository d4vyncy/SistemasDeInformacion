using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiEjemplo.Business.Contracts;
using WebApiEjemplo.Entidades;

namespace WebApiEjemplo.Business.Clases
{
    public class RolRepository : IRolRepository
    {
        private readonly string connec;
        public RolRepository(IConfiguration _IConfiguration)
        {
            connec = _IConfiguration.GetConnectionString("defaultConnection");
        }
        public async Task<Rol> GetRol(int idrol)
        {
            List<string> list = new List<string>();
            Rol oRol = new Rol();
            using (SqlConnection conn = new SqlConnection(connec))
            {
                await conn.OpenAsync();                
                SqlCommand cmd = new SqlCommand("select * from Roles where id=" + idrol.ToString() +";", conn);

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        oRol.Id= Convert.ToInt32(reader["Id"].ToString());
                        oRol.NombreRol = reader["NombreRol"].ToString();
                        
                    }
                }
            }
            return oRol;
        }
    }
}
