<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListadoDenunciantes.aspx.cs" Inherits="Presentacion_ListadoDenunciantes" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Busqueda de Denunciantes</title>
    <link href="../styles.css" type="text/css" rel="stylesheet"/>
    <base target="_self"/>
</head>
<body>
    <form id="form1" runat="server">
    <div style="background-color: transparent">
        <table style="width: 664px; height: 40px" id="tblCabecera">
            <tr>
                <td align="center" colspan="3" style="height: 12px">
                </td>
            </tr>
            <tr>
                <td align="center" colspan="3" style="height: 12px">
                </td>
            </tr>
            <tr>
                <td style="width: 207px; border-left-color: yellow; border-bottom-color: yellow; border-top-style: none; border-top-color: yellow; border-right-style: none; border-left-style: none; height: 36px; border-right-color: yellow; border-bottom-style: none;" align="left">
                                <asp:Label ID="lblFiltroBusqueda" runat="server" Text="Buscar Por:" CssClass="lblBoldUpperXXS" Width="72px"></asp:Label>
                                <asp:DropDownList ID="cmbEleccionFiltro" runat="server" AutoPostBack="True" OnSelectedIndexChanged="cmbEleccionFiltro_SelectedIndexChanged" CssClass="ComboBox">
                                    <asp:ListItem>Codigo Denunciante</asp:ListItem>
                                    <asp:ListItem>Apellido</asp:ListItem>
                                    <asp:ListItem>Nombre</asp:ListItem>
                                    <asp:ListItem>Nro Documento</asp:ListItem>
                                </asp:DropDownList></td>
                <td style="height: 36px; width: 142px;">
                    <asp:Label ID="lblXqFiltro" runat="server" Text="Filtrado:" CssClass="lblBoldUpperXXS"></asp:Label>
                                <asp:DropDownList ID="cmbFiltro" runat="server" CssClass="ComboBox">
                                </asp:DropDownList></td>
                <td style="width: 285px; height: 36px;" align="right">
                    &nbsp;
                                <asp:Label ID="lblTexto" runat="server" Text="Texto: " Width="48px" CssClass="lblBoldUpperXXS"></asp:Label>
                                <asp:TextBox ID="txtTexto" runat="server" Width="128px" CssClass="TextBox"></asp:TextBox>
                    <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" CssClass="ButtonBlue11px" />
                </td>
            </tr>
        </table>
        <table style="width: 664px; height: 40px" id="tblGrilla">
            <tr>
                <td align="center" colspan="" style="height: 31px" valign="top">
                </td>
            </tr>
            <tr>
                <td style="height: 218px" align="center" colspan="" valign="top">
                <asp:GridView ID="gvDatoDenunciante" runat="server" Height="73%" Width ="100%" CellPadding="4" ForeColor="#333333" OnRowDataBound="gvDatoDenunciante_RowDataBound" CssClass="DataGrid" AllowPaging="True" OnPageIndexChanged="gvDatoDenunciante_PageIndexChanged" OnPageIndexChanging="gvDatoDenunciante_PageIndexChanging" OnSelectedIndexChanged="gvDatoDenunciante_SelectedIndexChanged">
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
                    &nbsp;&nbsp;
                </td>
            </tr>
            <tr>
                <td align="right">
                </td>
            </tr>
            <tr>
                <td align="right">
                </td>
            </tr>
            <tr>
                <td align="right">
                     <asp:Button ID="btnRegresar" runat="server" Text="Regresar" OnClick="btnRegresar_Click" CssClass="ButtonBlue11px" /><asp:Button ID="btnLimpiarBusqueda" runat="server" OnClick="btnLimpiarBusqueda_Click"
                     Text="Limpiar" CssClass="ButtonBlue11px" /></td>
            </tr>
        </table>
    
    </div>

    </form>
</body>
</html>
