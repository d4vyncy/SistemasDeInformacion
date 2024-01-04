//CODIGO GENERADO POR davidserrudo@gmail.com
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using WcfSeguridad.Negocios;
using WcfSeguridad.Datos;

namespace WcfSeguridad
{
[ServiceContract]
public interface IService1
{


#region Rol
[OperationContract]
clsRol ObtieneRol(int IdRol);

[OperationContract]
int AgregaRol(clsRol oRol);

[OperationContract]
int ModificaRol(clsRol oRol);

[OperationContract]
int EliminaRol(int IdRol);

[OperationContract]
DataSet ObtienepavRol1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavRol2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavRol3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavRol4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavRol5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
#region Usuario
[OperationContract]
clsUsuario ObtieneUsuario(int IdUsuario);

[OperationContract]
int AgregaUsuario(clsUsuario oUsuario);

[OperationContract]
int ModificaUsuario(clsUsuario oUsuario);

[OperationContract]
int EliminaUsuario(int IdUsuario);

[OperationContract]
DataSet ObtienepavUsuario1(string Campo, string Valor);

[OperationContract]
DataSet ObtienepavUsuario2(string Campo, string Valor,string Campo1, string Valor1);

[OperationContract]
DataSet ObtienepavUsuario3(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2);

[OperationContract]
DataSet ObtienepavUsuario4(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3);

[OperationContract]
DataSet ObtienepavUsuario5(string Campo, string Valor,string Campo1, string Valor1,string Campo2, string Valor2,string Campo3, string Valor3,string Campo4, string Valor4,string Campo5, string Valor5,string Campo6, string Valor6,string Campo7, string Valor7);

#endregion 
}
}
