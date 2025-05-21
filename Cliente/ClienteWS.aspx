<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ClienteWS.aspx.cs" Inherits="Cliente.ClienteWS" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="lblTitulo" runat="server">
        <div>
        </div>
        Listado de Usuarios<br />
        <br />
        <asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" OnClick="btnBuscar_Click" />
        <br />
        <br />
        <asp:GridView ID="grvUsuarios" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
