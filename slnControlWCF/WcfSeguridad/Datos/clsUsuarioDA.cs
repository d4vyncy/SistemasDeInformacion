//CODIGO GENERADO POR davidserrudo@gmail.com
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Common;
//using Microsoft.ApplicationBlocks.Data;
using System.Data.SqlClient;
using WcfSeguridad.Entidades;

namespace WcfSeguridad.Datos 
{
public class clsUsuarioDA : clsUsuarioBE
{

Database db = null;
//DataSet dtoUsuario;

public clsUsuarioDA()
{
db = DatabaseFactory.CreateDatabase("ConSeguridad");
}

public IDataReader ObtieneUsuario(clsUsuarioBE pUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pagUsuario",2, pUsuario.IdUsuario,  pUsuario.NombreUsuario, pUsuario.Clave, pUsuario.Salt,  pUsuario.Estilo);
IDataReader dr = db.ExecuteReader(cmd);
return dr;
}


public int AgregaUsuario(clsUsuarioBE pUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pagUsuario",1, pUsuario.IdUsuario,  pUsuario.NombreUsuario, pUsuario.Clave, pUsuario.Salt,  pUsuario.Estilo);
int nIdUsuario = 0;
using (IDataReader dr = db.ExecuteReader(cmd))
{
if (dr.Read())
{
nIdUsuario = Convert.ToInt32(dr["IdUsuario"]);
}
}
return nIdUsuario;
}

public int ModificaUsuario(clsUsuarioBE pPaq)
{
DbCommand cmd = db.GetStoredProcCommand("pagUsuario",3, pPaq.IdUsuario, pPaq.NombreUsuario, pPaq.Clave, pPaq.Salt,  pPaq.Estilo);
return db.ExecuteNonQuery(cmd);
}

public int EliminaUsuario(clsUsuarioBE pUsuario)
{
DbCommand cmd = db.GetStoredProcCommand("pagUsuario",4, pUsuario.IdUsuario,  pUsuario.NombreUsuario, pUsuario.Clave, pUsuario.Salt,  pUsuario.Estilo);
return db.ExecuteNonQuery(cmd);
}

public DataSet ObtienepavUsuario(object[] pParametros)
{
DbCommand cmd = db.GetStoredProcCommand("pavUsuario" , pParametros);
return db.ExecuteDataSet(cmd);
}

}
}
