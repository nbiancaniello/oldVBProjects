<%@ page language="C#" autoeventwireup="true" inherits="Presentacion_Errores_CI, DefensorDeploy" enableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 520px; height: 264px">
            <tr>
                <td>
                    <asp:Label ID="lblError" runat="server" BackColor="White" Font-Bold="True" ForeColor="Red"></asp:Label></td>
                <td style="width: 3px">
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btnVolver" runat="server" OnClick="btnVolver_Click" Text="Volver" /></td>
                <td style="width: 3px">
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td style="width: 3px">
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
