<%@ page language="C#" autoeventwireup="true" inherits="Presentacion_BuscarMovimiento, App_Web_r2qjsibb" enableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Expediente</title>
    <link href="../Styles.css" rel="stylesheet" type="text/css" />
</head>
<body><form id="form1" runat="server">
    &nbsp;<table style="width: 100%; height: 100%;">
        <tr>
            <td style="width: 20%; height: 20%;">
            </td>
            <td style="width: 60%; height: 20%;">
            </td>
            <td style="width: 20%; height: 20%;">
            </td>
        </tr>
        <tr>
            <td style="height: 60%; width: 20%;">
            </td>
            <td style="width: 60%; height: 60%">
    <table id="TABLE1" style="width: 57%; height: 176px">
        <tr>
            <td style="width: 66px; height: 26px;">
                <asp:Label ID="Label1" runat="server" Text="Nº Expediente:" Width="104px" CssClass="lblBoldUpperXXS"></asp:Label></td>
            <td style="width: 102px; height: 26px;">
                <asp:TextBox ID="txtExpediente" runat="server" Width="40px" CssClass="TextBoxNumero" MaxLength="5"></asp:TextBox></td>
        </tr>
        <tr>
           <td style="width: 66px">
            </td>
            <td style="width: 102px">
            </td>

        </tr>
        <tr>
             <td style="width: 66px">
                <asp:Button ID="btnVer" runat="server" Text="Ver Movimientos" OnClick="btnVer_Click" CssClass="ButtonBlue11px" Width="120px"  /></td>
            <td style="width: 102px">
                <asp:Button ID="btnNuevo" runat="server" Text="Nuevo Movimiento" CssClass="ButtonBlue11px" Width="120px" OnClick="btnNuevo_Click" /></td>

        </tr>
        <tr>
            <td style="width: 66px"></td>
            <td align="center" colspan="1" style="width: 102px">
                <asp:Button ID="Button1" runat="server" Text="Volver" OnClick="Button1_Click" Width="112px" CssClass="ButtonBlue11px" /></td>
                        
 
        </tr>
    </table>
            </td>
            <td style="width: 20%; height: 60%;">
            </td>
        </tr>
        <tr>
            <td style="width: 20%; height: 20%;">
            </td>
            <td style="width: 60%; height: 20%;">
            </td>
            <td style="width: 20%; height: 20%;">
            </td>
        </tr>
    </table>
</form>
</body>
</html>
