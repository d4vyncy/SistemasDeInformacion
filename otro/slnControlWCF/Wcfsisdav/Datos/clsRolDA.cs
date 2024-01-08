using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Web;
using Wcfsisdav.Entidades;

namespace Wcfsisdav.Datos
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

    }
}