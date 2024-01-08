//CODIGO GENERADO POR davidserrudo@gmail.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using Wcfsisdav.Negocios;
using Wcfsisdav.Datos;

namespace Wcfsisdav
{
    public class Service1 : IService1
    {
        public clsRol ObtieneRol(int IdRol)
        {
            clsRol oRol = new clsRol();
            oRol.IdRol = IdRol;
            return oRol.clsRolPorIdRol();
        }

        public int AgregaRol(clsRol oRol)
        { return oRol.AgregaRol(); }

    }
}
