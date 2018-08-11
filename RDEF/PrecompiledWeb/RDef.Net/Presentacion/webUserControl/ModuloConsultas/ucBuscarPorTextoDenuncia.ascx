<%@ control language="C#" autoeventwireup="true" inherits="webUserControl_ModuloConsultas_ucBuscarPorTextoDenuncia, App_Web_wcttqurf" %>
<%@ Register Src="../Comunes/ucFechaDdFechaHh.ascx" TagName="ucFechaDdFechaHh" TagPrefix="uc1" %>

<table style="width: 710px; height: 1px;">
    <tr>
        <td style="width: 471px; height: 31px;">
            <asp:Label ID="lblTextoABuscar" runat="server" Text="Texto a buscar" CssClass="lblBoldUpperXXS"></asp:Label></td>
        <td style="width: 262px; height: 31px;">
            <asp:TextBox ID="txtTextoABuscar" runat="server" MaxLength="20" CssClass="TextBox"></asp:TextBox></td>
        <td style="width: 161px; height: 31px;">
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" Width="86px" OnClick="btnBuscar_Click" CssClass="ButtonBlue11px"/></td>
        <td rowspan="2">
            <uc1:ucFechaDdFechaHh ID="UcFechaDdFechaHh1" runat="server" />
            </td>
    </tr>

    <tr>
        <td colspan="2">
            <asp:Label ID="lblCantidadRegistrosEncontrados" runat="server" Text="Cantidad de Registros Encontrados" CssClass="lblBoldUpperXXS"></asp:Label></td>
        <td style="width: 161px;">
            <asp:Label ID="lblCantidadRegistros" runat="server" Text="0" Width="50px" CssClass="TextBox"></asp:Label></td>
    </tr>

    <tr>
        <td colspan="4">
            &nbsp;</td>
    </tr>
    <tr>
        <td colspan="4" style="height: 183px">
            <asp:GridView ID="gvwDatos" runat="server" Width ="100%" CellPadding="4" ForeColor="#333333" GridLines="None" OnRowDataBound ="gvwDatos_RowDataBound" CssClass="DataGrid">
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