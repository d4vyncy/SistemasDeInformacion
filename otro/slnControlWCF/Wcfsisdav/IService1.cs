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
[ServiceContract]
public interface IService1
{
        [OperationContract]
        clsRol ObtieneRol(int IdRol);

        [OperationContract]
        int AgregaRol(clsRol oRol);

    }
}
