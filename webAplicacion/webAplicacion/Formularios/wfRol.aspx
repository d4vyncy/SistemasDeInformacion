<%@ Page Title="" Language="C#" MasterPageFile="~/mpPrincipal.Master" AutoEventWireup="true" CodeBehind="wfRol.aspx.cs" Inherits="webAplicacion.Formularios.wfRol" %>
<%@ Register src="../ControlesUsuario/CU_ListaRoles.ascx" tagname="CU_ListaRoles" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:CU_ListaRoles ID="CU_ListaRoles1" runat="server" />
</asp:Content>
