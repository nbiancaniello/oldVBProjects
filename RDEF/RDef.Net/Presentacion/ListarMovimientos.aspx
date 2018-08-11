<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ListarMovimientos.aspx.cs" Inherits="Presentacion_ListarMovimientos" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Movimientos</title>
    <link href="../styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 672px; height: 344px">
            <tr>
                <td style="width: 794px; height: 32px">
        <asp:Label ID="lblPerteneceExpedienteNumero" runat="server" Text="Perteneciente al Expediente Numero:" CssClass="lblBoldUpperXXS" Width="240px"></asp:Label>
                    <asp:Label ID="lblIdExpediente" runat="server" Text="Label" CssClass="lblBoldUpperXXS"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 776px; height: 225px">
        <asp:GridView ID="gvMovimientos" runat="server" CssClass="DataGrid" ForeColor="Black" Height="95%" Width="95%" AllowPaging="True" OnPageIndexChanging="gvMovimientos_PageIndexChanging" OnPageIndexChanged="gvMovimientos_PageIndexChanged" OnRowDataBound="gvMovimientos_RowDataBound" OnSelectedIndexChanged="gvMovimientos_SelectedIndexChanged">
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" CssClass="DataGridItem" />
                <RowStyle BackColor="#EFF3FB" CssClass="DataGridItem" />
                <EditRowStyle BackColor="#2461BF" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" CssClass="DataGridHeader" />
                <AlternatingRowStyle BackColor="White" />
                <Columns>                    
                    <asp:CommandField ShowSelectButton="True" ButtonType="Image" EditImageUrl="~/Imagenes/next.gif" SelectImageUrl="~/Imagenes/next.gif" SelectText="" />                    
                </Columns>
        </asp:GridView>
                </td>
            </tr>
            <tr>
                <td style="width: 794px; height: 37px">
                    &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;<asp:Button ID="btnNuevoMovimiento" runat="server" CssClass="ButtonBlue11px"
                        OnClick="btnNuevoMovimiento_Click" Text="Nuevo Movimiento" Width="120px" />
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                    &nbsp; &nbsp;<asp:Button ID="btnVer" runat="server" OnClick="btnVer_Click" Text="Ver Movimiento" CssClass="ButtonBlue11px" Width="112px" />
                    &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Salir" CssClass="ButtonBlue11px" Width="64px" /></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
