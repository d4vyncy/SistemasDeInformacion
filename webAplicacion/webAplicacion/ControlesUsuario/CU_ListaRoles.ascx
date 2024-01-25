<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CU_ListaRoles.ascx.cs" Inherits="webAplicacion.ControlesUsuario.CU_ListaRoles" %>
<asp:GridView ID="rgvListaRoles" runat="server" AutoGenerateColumns="False">
    <Columns>
        <asp:BoundField DataField="Id" HeaderText="Id" />
        <asp:BoundField DataField="NombreRol" HeaderText="Rol" />
    </Columns>
</asp:GridView>

