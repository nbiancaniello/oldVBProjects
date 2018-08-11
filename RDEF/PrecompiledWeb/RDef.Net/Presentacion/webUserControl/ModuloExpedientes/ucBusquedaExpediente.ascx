<%@ control language="C#" autoeventwireup="true" inherits="busquedaExpediente, App_Web_p5h2rzy6" %>

<table style="width: 88%">
    <tr>
        <td colspan="2" style="width: 29px; height: 27px">
            <asp:Label ID="lblBuscarPorNombre" runat="server" Text="Buscar por:" CssClass="lblBoldUpperXXS" Height="17px" Width="80px"></asp:Label>
        </td>
            
        <td colspan="2" style="width: 87px; height: 27px">
            <asp:DropDownList ID="ddlBuscarPor" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlBuscarPor_SelectedIndexChanged" Width="136px" CssClass="ComboBox">
                <asp:ListItem Value="0">N&#250;mero</asp:ListItem>
                <asp:ListItem Value="1">Apellido</asp:ListItem>
                <asp:ListItem Value="2">Calle</asp:ListItem>
            </asp:DropDownList></td>
        
        <td colspan="2" style="height: 27px; width: 52px;">
            &nbsp;<asp:Label ID="lblFiltro" runat="server" CssClass="lblBoldUpperXXS"
                Text="Filtro:" Width="44px" Height="18px"></asp:Label></td>
            
        <td style="width: 5px; height: 27px;">
            <asp:DropDownList ID="ddlFiltro" runat="server" Width="160px" CssClass="ComboBox">
            </asp:DropDownList></td>
        <td style="width: 5px; height: 27px">
            <asp:Label ID="lblValor" runat="server" CssClass="lblBoldUpperXXS" Height="18px"
                Text="Valor a buscar:" Width="96px"></asp:Label></td>
        <td style="width: 5px; height: 27px">
            <asp:TextBox ID="txtConsulta" runat="server" MaxLength="6" CssClass="TextBox" Width="120px"></asp:TextBox></td>
    </tr>
    <tr>
        <td colspan="9" style="height: 17px" align="right">
            <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar"
                Width="84px" CssClass="ButtonBlue11px" /></td>
    </tr>
  

    
</table>

<table style="width: 89%">
    <tr>
        <td style="height: 53px">
            <asp:GridView ID="gvwDatos" runat="server" Height="73%" Width ="100%" CellPadding="4" ForeColor="#333333" AllowPaging="True" OnPageIndexChanging="gvwDatos_PageIndexChanging"  OnRowDataBound="gvwDatos_RowDataBound" OnSelectedIndexChanged="gvwDatos_SelectedIndexChanged" OnPageIndexChanged="gvwDatos_PageIndexChanged" CssClass="DataGrid">
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" CssClass="DataGridItem" />
                <RowStyle BackColor="#EFF3FB" CssClass="DataGridItem" />
                <EditRowStyle BackColor="#2461BF" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" CssClass="DataGridHeader" />
                <AlternatingRowStyle BackColor="White" />
                <Columns>                    
                    <asp:CommandField ShowSelectButton="True" ButtonType="Image" EditImageUrl="~/Imagenes/next.gif" SelectImageUrl="~/Imagenes/next.gif" />                    
                </Columns>
            </asp:GridView>
            </td>
    </tr>
    <tr>
        <td style="height: 32px">
            <asp:Label ID="lblCantidadRegistros" runat="server" CssClass="lblBoldUpperXXS"></asp:Label>
        </td>
    </tr>

</table>
<table style="width: 89%; height: 368px;">
    <tr>
        <td style="height: 21px; width: 787px;" >
            <asp:Label ID="lblDetalleDenuncia" runat="server" Text="Detalle de la denuncia:" CssClass="lblBoldUpperXXS"></asp:Label>
        </td>
    </tr>
    <tr>
        <td style="height: 129px; width: 787px;">
            <asp:TextBox ID="txtDetalleDeLaDenuncia" Width="98%" Height = "95%" runat="server" BackColor="White" ReadOnly="True" TextMode="MultiLine" CssClass="TextBox" Columns="10"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 787px">
            <asp:Label ID="lblDatosDeContacto" runat="server" CssClass="lblBoldUpperXXS"
                Text="Datos de contacto:"></asp:Label></td>
    </tr>
    <tr>
        <td style="height: 100px; width: 787px;"><asp:GridView ID="gvwContactos" runat="server" Height="84%" Width ="100%" CellPadding="4" ForeColor="#333333" PageSize="3" CssClass="DataGrid" Enabled="False">
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" CssClass="DataGridItem" />
            <Columns>
                <asp:CommandField ShowEditButton="True" ButtonType="Image" EditImageUrl="~/Imagenes/next.gif" SelectImageUrl="~/Imagenes/show2.gif" />
            </Columns>
            <RowStyle BackColor="#EFF3FB" CssClass="DataGridItem" />
            <EditRowStyle BackColor="#2461BF" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" CssClass="DataGridHeader" />
            <AlternatingRowStyle BackColor="White" />
        </asp:GridView>
        </td>
    </tr>
    <tr>
        <td align="right" style="width: 787px; height: 33px">
            <asp:Button ID="btnIr" runat="server" CssClass="ButtonBlue11px" OnClick="btnIr_Click"
                Text="Regresar" Width="83px" /></td>
    </tr>
</table>