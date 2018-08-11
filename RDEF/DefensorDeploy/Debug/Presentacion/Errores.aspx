<%@ page language="C#" autoeventwireup="true" inherits="Errores, DefensorDeploy" enableEventValidation="false" %>


<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
    <base target="_self" />
    <link href="../styles.css" type="text/css" rel="stylesheet"/>
    <script type="text/javascript">
        function cerrarVentana(){
        
        window.returnValue = "1";
            window.close();
        }
    </script>
    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;
        <table style="width: 776px; height: 472px">
            <tr>
                <td colspan="5" valign="top">
                    <asp:Label ID="lblError" runat="server" BackColor="Transparent" Font-Bold="False" ForeColor="Red" CssClass="etiquetas" Font-Italic="False" Font-Overline="False" Font-Size="Smaller" Font-Strikeout="False" Font-Underline="False">Ha Ocurrido un problema grave. Contacte al soporte Tecnico.</asp:Label></td>
            </tr>
            <tr>
                <td style="width: 232px">
                    </td>
                <td style="width: 208px">
                </td>
                <td style="width: 208px">
                </td>
                <td style="width: 208px">
                </td>
                <td style="width: 208px">
                </td>
            </tr>
            <tr>
                <td align="right" style="width: 232px">
                </td>
                <td style="width: 208px">
                </td>
                <td style="width: 208px">
                </td>
                <td style="width: 208px">
                </td>
                <td style="width: 208px">
                </td>
            </tr>
            <tr>
                <td align="right" style="width: 232px">
                </td>
                <td style="width: 208px">
                </td>
                <td style="width: 208px">
                </td>
                <td style="width: 208px">
                </td>
                <td style="width: 208px">
                </td>
            </tr>
            <tr>
                <td align="right" style="width: 232px">
                </td>
                <td style="width: 208px">
                </td>
                <td style="width: 208px">
                </td>
                <td style="width: 208px">
                </td>
                <td style="width: 208px">
                </td>
            </tr>
            <tr>
                <td align="right" style="width: 232px">
                    </td>
                <td style="width: 208px">
                </td>
                <td style="width: 208px">
                </td>
                <td style="width: 208px">
                </td>
                <td align="right" style="width: 208px" valign="bottom">
                    <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver" CssClass="ButtonBlue11px" /></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
