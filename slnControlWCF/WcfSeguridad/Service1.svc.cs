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
    public class Service1 : IService1
    {
        // con n parametros

        #region Rol
        public clsRol ObtieneRol(int IdRol)
        {
            clsRol oRol = new clsRol();
            oRol.IdRol = IdRol;
            return oRol.clsRolPorIdRol();
        }

        public int AgregaRol(clsRol oRol)
        { return oRol.AgregaRol(); }

        public int ModificaRol(clsRol oRol)
        { return oRol.ModificaRol(); }

        public int EliminaRol(int IdRol)
        {
            clsRol oRol = new clsRol();
            oRol.IdRol = IdRol;
            return oRol.EliminaRol();
        }

        //seleccion con parametros
        public DataSet ObtienepavRol1(string Campo, string Valor)
        {
            object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            pParametros[0] = Campo;
            pParametros[1] = Valor;
            pParametros[2] = "T";
            pParametros[3] = "";
            pParametros[4] = "T";
            pParametros[5] = "";
            pParametros[6] = "T";
            pParametros[7] = "";
            pParametros[8] = "T";
            pParametros[9] = "";
            pParametros[10] = "T";
            pParametros[11] = "";
            pParametros[12] = "T";
            pParametros[13] = "";
            pParametros[14] = "T";
            pParametros[15] = "";
            clsRolDA ad = new clsRolDA();
            return ad.ObtienepavRol(pParametros);
        }
        public DataSet ObtienepavRol2(string Campo, string Valor, string Campo1, string Valor1)
        {
            object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            pParametros[0] = Campo;
            pParametros[1] = Valor;
            pParametros[2] = Campo1;
            pParametros[3] = Valor1;
            pParametros[4] = "T";
            pParametros[5] = "";
            pParametros[6] = "T";
            pParametros[7] = "";
            pParametros[8] = "T";
            pParametros[9] = "";
            pParametros[10] = "T";
            pParametros[11] = "";
            pParametros[12] = "T";
            pParametros[13] = "";
            pParametros[14] = "T";
            pParametros[15] = "";
            clsRolDA ad = new clsRolDA();
            return ad.ObtienepavRol(pParametros);
        }
        public DataSet ObtienepavRol3(string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2)
        {
            object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            pParametros[0] = Campo;
            pParametros[1] = Valor;
            pParametros[2] = Campo1;
            pParametros[3] = Valor1;
            pParametros[4] = Campo2;
            pParametros[5] = Valor2;
            pParametros[6] = "T";
            pParametros[7] = "";
            pParametros[8] = "T";
            pParametros[9] = "";
            pParametros[10] = "T";
            pParametros[11] = "";
            pParametros[12] = "T";
            pParametros[13] = "";
            pParametros[14] = "T";
            pParametros[15] = "";
            clsRolDA ad = new clsRolDA();
            return ad.ObtienepavRol(pParametros);
        }
        public DataSet ObtienepavRol4(string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2, string Campo3, string Valor3)
        {
            object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            pParametros[0] = Campo;
            pParametros[1] = Valor;
            pParametros[2] = Campo1;
            pParametros[3] = Valor1;
            pParametros[4] = Campo2;
            pParametros[5] = Valor2;
            pParametros[6] = Campo3;
            pParametros[7] = Valor3;
            pParametros[8] = "T";
            pParametros[9] = "";
            pParametros[10] = "T";
            pParametros[11] = "";
            pParametros[12] = "T";
            pParametros[13] = "";
            pParametros[14] = "T";
            pParametros[15] = "";
            clsRolDA ad = new clsRolDA();
            return ad.ObtienepavRol(pParametros);
        }
        public DataSet ObtienepavRol5(string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2, string Campo3, string Valor3, string Campo4, string Valor4, string Campo5, string Valor5, string Campo6, string Valor6, string Campo7, string Valor7)
        {
            object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            pParametros[0] = Campo;
            pParametros[1] = Valor;
            pParametros[2] = Campo1;
            pParametros[3] = Valor1;
            pParametros[4] = Campo2;
            pParametros[5] = Valor2;
            pParametros[6] = Campo3;
            pParametros[7] = Valor3;
            pParametros[8] = Campo4;
            pParametros[9] = Valor4;
            pParametros[10] = Campo5;
            pParametros[11] = Valor5;
            pParametros[12] = Campo6;
            pParametros[13] = Valor6;
            pParametros[14] = Campo7;
            pParametros[15] = Valor7;
            clsRolDA ad = new clsRolDA();
            return ad.ObtienepavRol(pParametros);
        }
        #endregion

        #region Usuario
        public clsUsuario ObtieneUsuario(int IdUsuario)
        {
            clsUsuario oUsuario = new clsUsuario();
            oUsuario.IdUsuario = IdUsuario;
            return oUsuario.clsUsuarioPorIdUsuario();
        }

        public int AgregaUsuario(clsUsuario oUsuario)
        { return oUsuario.AgregaUsuario(); }

        public int ModificaUsuario(clsUsuario oUsuario)
        { return oUsuario.ModificaUsuario(); }

        public int EliminaUsuario(int IdUsuario)
        {
            clsUsuario oUsuario = new clsUsuario();
            oUsuario.IdUsuario = IdUsuario;
            return oUsuario.EliminaUsuario();
        }

        //seleccion con parametros
        public DataSet ObtienepavUsuario1(string Campo, string Valor)
        {
            object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            pParametros[0] = Campo;
            pParametros[1] = Valor;
            pParametros[2] = "T";
            pParametros[3] = "";
            pParametros[4] = "T";
            pParametros[5] = "";
            pParametros[6] = "T";
            pParametros[7] = "";
            pParametros[8] = "T";
            pParametros[9] = "";
            pParametros[10] = "T";
            pParametros[11] = "";
            pParametros[12] = "T";
            pParametros[13] = "";
            pParametros[14] = "T";
            pParametros[15] = "";
            clsUsuarioDA ad = new clsUsuarioDA();
            return ad.ObtienepavUsuario(pParametros);
        }
        public DataSet ObtienepavUsuario2(string Campo, string Valor, string Campo1, string Valor1)
        {
            object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            pParametros[0] = Campo;
            pParametros[1] = Valor;
            pParametros[2] = Campo1;
            pParametros[3] = Valor1;
            pParametros[4] = "T";
            pParametros[5] = "";
            pParametros[6] = "T";
            pParametros[7] = "";
            pParametros[8] = "T";
            pParametros[9] = "";
            pParametros[10] = "T";
            pParametros[11] = "";
            pParametros[12] = "T";
            pParametros[13] = "";
            pParametros[14] = "T";
            pParametros[15] = "";
            clsUsuarioDA ad = new clsUsuarioDA();
            return ad.ObtienepavUsuario(pParametros);
        }
        public DataSet ObtienepavUsuario3(string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2)
        {
            object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            pParametros[0] = Campo;
            pParametros[1] = Valor;
            pParametros[2] = Campo1;
            pParametros[3] = Valor1;
            pParametros[4] = Campo2;
            pParametros[5] = Valor2;
            pParametros[6] = "T";
            pParametros[7] = "";
            pParametros[8] = "T";
            pParametros[9] = "";
            pParametros[10] = "T";
            pParametros[11] = "";
            pParametros[12] = "T";
            pParametros[13] = "";
            pParametros[14] = "T";
            pParametros[15] = "";
            clsUsuarioDA ad = new clsUsuarioDA();
            return ad.ObtienepavUsuario(pParametros);
        }
        public DataSet ObtienepavUsuario4(string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2, string Campo3, string Valor3)
        {
            object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            pParametros[0] = Campo;
            pParametros[1] = Valor;
            pParametros[2] = Campo1;
            pParametros[3] = Valor1;
            pParametros[4] = Campo2;
            pParametros[5] = Valor2;
            pParametros[6] = Campo3;
            pParametros[7] = Valor3;
            pParametros[8] = "T";
            pParametros[9] = "";
            pParametros[10] = "T";
            pParametros[11] = "";
            pParametros[12] = "T";
            pParametros[13] = "";
            pParametros[14] = "T";
            pParametros[15] = "";
            clsUsuarioDA ad = new clsUsuarioDA();
            return ad.ObtienepavUsuario(pParametros);
        }
        public DataSet ObtienepavUsuario5(string Campo, string Valor, string Campo1, string Valor1, string Campo2, string Valor2, string Campo3, string Valor3, string Campo4, string Valor4, string Campo5, string Valor5, string Campo6, string Valor6, string Campo7, string Valor7)
        {
            object[] pParametros = new object[] { "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "" };
            pParametros[0] = Campo;
            pParametros[1] = Valor;
            pParametros[2] = Campo1;
            pParametros[3] = Valor1;
            pParametros[4] = Campo2;
            pParametros[5] = Valor2;
            pParametros[6] = Campo3;
            pParametros[7] = Valor3;
            pParametros[8] = Campo4;
            pParametros[9] = Valor4;
            pParametros[10] = Campo5;
            pParametros[11] = Valor5;
            pParametros[12] = Campo6;
            pParametros[13] = Valor6;
            pParametros[14] = Campo7;
            pParametros[15] = Valor7;
            clsUsuarioDA ad = new clsUsuarioDA();
            return ad.ObtienepavUsuario(pParametros);
        }
        #endregion
    }
}
