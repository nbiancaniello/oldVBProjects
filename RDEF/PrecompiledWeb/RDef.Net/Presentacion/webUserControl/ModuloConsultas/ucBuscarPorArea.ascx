<%@ control language="C#" autoeventwireup="true" inherits="webUserControl_ucBuscarPorArea, App_Web_wcttqurf" %>
<table style="width: 720px">
    <tr>
        <td colspan="2">
            <asp:ListBox ID="lstAreas" runat="server" Height="112px" Width="600px"></asp:ListBox></td>
        <td>
            <asp:Button ID="btnBuscar" runat="server" Text="Buscar" Width="86px" OnClick="btnBuscar_Click" CssClass="ButtonBlue11px" /></td>
    </tr>
    <tr>
        <td>
            <asp:Label ID="lblCantidadRegistrosEncontrados" runat="server" Text="Cantidad de Registros Encontrados" CssClass="lblBoldUpperXXS"></asp:Label></td>
        <td>
            <asp:Label ID="lblCantidadRegistros" runat="server" Text="0" Width="138px" CssClass="Textbox"></asp:Label></td>
        <td>
        </td>
    </tr>
    <tr>
        <td colspan="3">
        </td>
    </tr>
    <tr>
        <td colspan="3">
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
