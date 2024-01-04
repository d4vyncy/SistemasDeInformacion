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
    public class clsRolDA : clsRolBE
    {

        Database db = null;
        //DataSet dtoRol;

        public clsRolDA()
        {
            db = DatabaseFactory.CreateDatabase("ConSeguridad");
        }

        public IDataReader ObtieneRol(clsRolBE pRol)
        {
            DbCommand cmd = db.GetStoredProcCommand("pagRol", 2, pRol.IdRol, pRol.NombreRol);
            IDataReader dr = db.ExecuteReader(cmd);
            return dr;
        }


        public int AgregaRol(clsRolBE pRol)
        {
            DbCommand cmd = db.GetStoredProcCommand("pagRol", 1, pRol.IdRol, pRol.NombreRol);
            int nIdRol = 0;
            using (IDataReader dr = db.ExecuteReader(cmd))
            {
                if (dr.Read())
                {
                    nIdRol = Convert.ToInt32(dr["IdRol"]);
                }
            }
            return nIdRol;
        }

        public int ModificaRol(clsRolBE pPaq)
        {
            DbCommand cmd = db.GetStoredProcCommand("pagRol", 3, pPaq.IdRol, pPaq.NombreRol);
            return db.ExecuteNonQuery(cmd);
        }

        public int EliminaRol(clsRolBE pRol)
        {
            DbCommand cmd = db.GetStoredProcCommand("pagRol", 4, pRol.IdRol, pRol.NombreRol);
            return db.ExecuteNonQuery(cmd);
        }

        public DataSet ObtienepavRol(object[] pParametros)
        {
            DbCommand cmd = db.GetStoredProcCommand("pavRol", pParametros);
            return db.ExecuteDataSet(cmd);
        }

    }
}
