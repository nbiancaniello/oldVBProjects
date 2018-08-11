<%@ page language="C#" autoeventwireup="true" inherits="Index, DefensorDeploy" enableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Defensoria del Pueblo - Vte Lopez</title>
    <link href="../styles.css" type="text/css" rel="stylesheet"/>
<script type ="text/javascript" >

function pintarEtiqueta(etiqueta){

    document.getElementById("cuerpoPrincipal").style.cursor="pointer";

    switch(etiqueta)
    {
        case "Expedientes":
            document.getElementById("lblExpedientes").style.backgroundColor = "#58ACFA";
            document.getElementById("lblMovimientos").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblConsultas").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblConsultasPorInformantes").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblMantenimiento").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblSalir").style.backgroundColor = "#ecf4ff";
        break;
        
        case "BuscarMovimiento":
            document.getElementById("lblExpedientes").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblMovimientos").style.backgroundColor = "#58ACFA";
            document.getElementById("lblConsultas").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblConsultasPorInformantes").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblMantenimiento").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblSalir").style.backgroundColor = "#ecf4ff";
        break;
        
        case "Consultas":
            document.getElementById("lblExpedientes").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblMovimientos").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblConsultas").style.backgroundColor = "#58ACFA";
            document.getElementById("lblConsultasPorInformantes").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblMantenimiento").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblSalir").style.backgroundColor = "#ecf4ff";
        break;
        
        case "ConsultasPorInformantes":
            document.getElementById("lblExpedientes").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblMovimientos").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblConsultas").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblConsultasPorInformantes").style.backgroundColor = "#58ACFA";
            document.getElementById("lblMantenimiento").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblSalir").style.backgroundColor = "#ecf4ff";
        break;    

        case "Mantenimiento":
            document.getElementById("lblExpedientes").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblMovimientos").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblConsultas").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblConsultasPorInformantes").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblMantenimiento").style.backgroundColor = "#58ACFA";
            document.getElementById("lblSalir").style.backgroundColor = "#ecf4ff";
        break;
        
        case "Salir":
            document.getElementById("lblExpedientes").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblMovimientos").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblConsultas").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblConsultasPorInformantes").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblMantenimiento").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblSalir").style.backgroundColor = "#58ACFA";
        break;
        
    }

    
}

function blanquearEtiquetas(etiqueta)
{           

    document.getElementById("cuerpoPrincipal").style.cursor="auto";
    
    switch(etiqueta)
    {
        case "Expedientes":
            document.getElementById("lblExpedientes").style.backgroundColor = "#ecf4ff";
        break;
        
        case "BuscarMovimiento":
            document.getElementById("lblMovimientos").style.backgroundColor = "#ecf4ff";
        break;
        
        case "Consultas":
            document.getElementById("lblConsultas").style.backgroundColor = "#ecf4ff";
        break;
        
        case "ConsultasPorInformantes":
            document.getElementById("lblConsultasPorInformantes").style.backgroundColor = "#ecf4ff";
        break;     

        case "Mantenimiento":
            document.getElementById("lblMantenimiento").style.backgroundColor = "#ecf4ff";
        break;
        
        case "Salir":
            document.getElementById("lblSalir").style.backgroundColor = "#ecf4ff";
        break;
    }
}

function redireccionar(etiqueta)
{           

    document.getElementById("cuerpoPrincipal").style.cursor="auto";
    
    switch(etiqueta)
    {
        case "Expedientes":
            location.href = "Expedientes.aspx";
        break;
        
        case "BuscarMovimiento":
            location.href = "BuscarMovimiento.aspx";
        break;
        
        case "Consultas":
            location.href = "Consultas.aspx";
        break;
        
        case "ConsultasPorInformantes":
            location.href = "ConsultasPorInformantes.aspx";
        break;    

        case "Mantenimiento":
            location.href = "MenuMantenimiento.aspx";
        break;
        
        case "Salir":
            window.opener = "";
            window.close();
        break;
    }
}


</script>    
</head>
<body id="cuerpoPrincipal" style="text-align: center"> 
    <form id="form1" runat="server">
    <div style="text-align: left">
        <br />
        <br />
        <br />
        <table style="width: 75%; height: 9%"> 
            <tr>
                <td style="vertical-align: middle; height: 4px; text-align: center; width: 744px;">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Tahoma" Font-Size="X-Large"
                        Text="Sistema Web de la Defensoría del Pueblo de Vicente López" Width="704px" BackColor="#E0E0E0" BorderStyle="Ridge" ForeColor="Black"></asp:Label></td>
            </tr>

        </table>
        <br />
        <table style="width: 75%; height: 296px; vertical-align: middle; text-align: center;">
            <tr>
                <td style="width: 74px; height: 21px">
                </td>
                <td style="width: 58px; height: 21px">
                    <asp:Image ID="imgExpedientes" runat="server" ImageUrl="~/Imagenes/next.gif" /></td>
                <td style="height: 21px; width: 134px;">
                    <asp:Label ID="lblExpedientes" runat="server" Text="Expedientes" Font-Bold="False" Font-Names="Tahoma" Font-Overline="False" Font-Size="20pt" Font-Strikeout="False" Width="200px"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 74px; height: 21px">
                </td>
                <td style="width: 58px; height: 21px">
                    <asp:Image ID="imgMovimientos" runat="server" ImageUrl="~/Imagenes/next.gif" /></td>
                <td style="height: 21px; width: 134px;">
                    <asp:Label ID="lblMovimientos" runat="server" Text="Movimientos" Font-Bold="False" Font-Names="Tahoma" Font-Overline="False" Font-Size="20pt" Font-Strikeout="False" Width="200px"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 74px; height: 35px">
                </td>
                <td style="width: 58px; height: 35px">
                    <asp:Image ID="imgConsultas" runat="server" ImageUrl="~/Imagenes/next.gif" /></td>
                <td style="width: 134px; height: 35px">
                    <asp:Label ID="lblConsultas" runat="server" Text="Consultas" Font-Bold="False" Font-Names="Tahoma" Font-Overline="False" Font-Size="20pt" Font-Strikeout="False" Width="200px"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 74px; height: 35px">
                </td>
                <td style="width: 58px; height: 35px">
                    <asp:Image ID="imgConsultasPorInformantes" runat="server" ImageUrl="~/Imagenes/next.gif" /></td>
                <td style="width: 134px; height: 35px">
                    <asp:Label ID="lblConsultasPorInformantes" runat="server" Font-Bold="False" Font-Names="Tahoma"
                        Font-Overline="False" Font-Size="20pt" Font-Strikeout="False" Text="Consultas por Informante"
                        Width="312px"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 74px; height: 35px">
                </td>
                <td style="width: 58px; height: 35px">
                    <asp:Image ID="imgMantenimiento" runat="server" ImageUrl="~/Imagenes/next.gif" /></td>
                <td style="width: 134px; height: 35px;">
                    <asp:Label ID="lblMantenimiento" runat="server" Font-Bold="False" Font-Names="Tahoma" Font-Overline="False"
                        Font-Size="20pt" Font-Strikeout="False" Text="Mantenimiento" Width="200px"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 74px; height: 35px">
                </td>
                <td style="width: 58px; height: 35px">
                    <asp:Image ID="imgSalir" runat="server" ImageUrl="~/Imagenes/next.gif" /></td>
                <td style="width: 134px; height: 35px">
                    <asp:Label ID="lblSalir" runat="server" Font-Bold="False" Font-Names="Tahoma" Font-Overline="False"
                        Font-Size="20pt" Font-Strikeout="False" Text="Salir" Width="200px"></asp:Label></td>
            </tr>
        </table>
    
    </div>
    </form>
</body>

</html>

