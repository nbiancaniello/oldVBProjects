<%@ page language="C#" autoeventwireup="true" inherits="Presentacion_BuscarMovimiento, DefensorDeploy" enableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Expediente</title>
    <link href="../Styles.css" rel="stylesheet" type="text/css" />
</head>
<body><form id="form1" runat="server">
    &nbsp;<table id="TABLE1" style="width: 22%; height: 112px">
        <tr>
            <td style="width: 1px; height: 20px;">
                <asp:Label ID="Label1" runat="server" Text="Nº Expediente:" Width="104px" CssClass="lblBoldUpperXXS"></asp:Label></td>
            <td style="width: 9px; height: 20px;">
                <asp:TextBox ID="txtExpediente" runat="server" Width="40px" CssClass="TextBoxNumero" MaxLength="5"></asp:TextBox></td>
        </tr>
        <tr>
             <td style="width: 1px; height: 20px;">
                <asp:Button ID="btnVer" runat="server" Text="Ver Movimientos" OnClick="btnVer_Click" CssClass="ButtonBlue11px" Width="120px"  /></td>
            <td style="width: 9px; height: 20px;">
                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo Movimiento" CssClass="ButtonBlue11px" Width="120px" OnClick="btnNuevo_Click" /></td>

        </tr>
        <tr>
            <td style="width: 1px; height: 19px;"></td>
            <td align="center" colspan="1" style="width: 9px; height: 19px;">
                <asp:Button ID="Button1" runat="server" Text="Salir" OnClick="Button1_Click" Width="64px" CssClass="ButtonBlue11px" /></td>
                        
 
        </tr>
    </table>
</form>
</body>
</html>
