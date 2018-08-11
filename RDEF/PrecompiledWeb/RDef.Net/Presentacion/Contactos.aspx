<%@ page language="C#" autoeventwireup="true" inherits="Presentacion_Contactos, App_Web_r2qjsibb" enableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Lista de Contactos</title>
    <link href="../styles.css" type="text/css" rel="stylesheet"/>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 448px; height: 360px">
            <tr>
                <td style="width: 57px">
                </td>
                <td style="width: 363px">
                </td>
            </tr>
            <tr>
                <td style="width: 57px">
                </td>
                <td style="width: 363px">
                    <asp:Label ID="lbl" runat="server" CssClass="lblBoldUpperXXS" Text="SELECCIONE "
                        Width="112px"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 57px">
                </td>
                <td style="width: 363px" align="center" valign="top">
                    <asp:GridView ID="grdContactos" runat="server" AutoGenerateSelectButton="True" Width="360px" CssClass="DataGrid">
                        <FooterStyle CssClass="DataGridItem" />
                        <HeaderStyle CssClass="DataGridHeader" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td style="width: 57px">
                </td>
                <td style="width: 363px">
                </td>
            </tr>
            <tr>
                <td style="width: 57px">
                </td>
                <td style="width: 363px" align="right">
                    <asp:Button ID="btnRegresar" runat="server" CssClass="ButtonBlue11px"
                        Text="Regresar" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
