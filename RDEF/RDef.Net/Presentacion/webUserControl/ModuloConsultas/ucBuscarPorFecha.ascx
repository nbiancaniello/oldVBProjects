<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ucBuscarPorFecha.ascx.cs" Inherits="webUserControl_ucBuscarPorFecha" %>
<%@ Register Src="../Comunes/ucFechaDdFechaHh.ascx" TagName="ucFechaDdFechaHh" TagPrefix="uc1" %>
<table style="width: 710px; height: 1px">
    <tr>
        <td style="width: 89px; height: 81px">
            <uc1:ucFechaDdFechaHh ID="UcFechaDdFechaHh1" runat="server" />
        </td>
        <td style="width: 1px; height: 81px; text-align: center">
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" Width="86px" OnClick="btnBuscar_Click" CssClass="ButtonBlue11px" /></td>
        <td style="height: 81px">
        </td>
    </tr>
    <tr>
        <td style="width: 89px; height: 21px">
            <asp:Label ID="lblCantidadRegistrosEncontrados" runat="server" Text="Cantidad de Registros Encontrados"
                Width="303px" CssClass="lblBoldUpperXXS"></asp:Label></td>
        <td style="width: 1px; height: 21px">
            <asp:Label ID="lblCantidadRegistros" runat="server" Text="0" Width="138px" CssClass="TextBox"></asp:Label></td>
        <td style="height: 21px">
        </td>
    </tr>
    <tr>
        <td colspan="3">
        </td>
    </tr>
    <tr>
        <td colspan="4">
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
</table>
