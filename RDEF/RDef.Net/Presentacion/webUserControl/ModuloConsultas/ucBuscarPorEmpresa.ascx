<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ucBuscarPorEmpresa.ascx.cs" Inherits="webUserControl_ucBuscarPorEmpresa" %>
<%@ Register Src="../Comunes/ucFechaDdFechaHh.ascx" TagName="ucFechaDdFechaHh" TagPrefix="uc1" %>
<table style="width: 696px;">
    <tr>
        <td>
            <uc1:ucFechaDdFechaHh ID="UcFechaDdFechaHh1" runat="server" />
        </td>
        <td style="width: 275px">
            <asp:ListBox ID="lstEmpresas" runat="server" Height="77px" Width="256px"></asp:ListBox></td>
        <td style="width: 64px">
            &nbsp;<asp:Button ID="btnBuscar" runat="server" Text="Buscar" Width="86px" OnClick="btnBuscar_Click" CssClass="ButtonBlue11px" /></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCantidadRegistrosEncontrados" runat="server" Text="Cantidad de Registros Encontrados" CssClass="lblBoldUpperXXS"></asp:Label></td>
        <td style="width: 275px">
            <asp:Label ID="lblCantidadRegistros" runat="server" Text="0" Width="50px" CssClass="TextBox"></asp:Label></td>
        <td style="width: 64px">
        </td>
    </tr>
    <tr>
        <td colspan="3">
        </td>
    </tr>
    <tr>
        <td colspan="3" rowspan="7">
            <asp:GridView ID="gvwDatos" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound ="gvwDatos_RowDataBound"
                Width="100%" CssClass="DataGrid">
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" CssClass="DataGridItem" />
                <RowStyle BackColor="#EFF3FB" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" ButtonType="Image" EditImageUrl="~/Imagenes/next.gif" SelectImageUrl="~/Imagenes/next.gif" />
                </Columns>
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" CssClass="DataGridHeader" />
                <EditRowStyle BackColor="#2461BF" />
                <AlternatingRowStyle BackColor="White" />
            </asp:GridView>
        </td>
    </tr>
    <tr>
    </tr>
    <tr>
    </tr>
    <tr>
    </tr>
    <tr>
    </tr>
    <tr>
    </tr>
    <tr>
    </tr>
</table>
