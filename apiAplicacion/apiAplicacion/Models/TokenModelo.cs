using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apiAplicacion.Models
{
    public class TokenModelo
    {
        public string token { get; set; }
        public DateTime tiempoExpira { get; set; }
    }
}
