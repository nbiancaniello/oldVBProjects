<%@ page language="C#" autoeventwireup="true" inherits="Consultas, App_Web_r2qjsibb" enableviewstate="true" enableEventValidation="false" %>

<%@ Register Src="webUserControl/ModuloConsultas/ucBuscarPorLocalidad.ascx" TagName="ucBuscarPorLocalidad"
    TagPrefix="uc4" %>
<%@ Register Src="webUserControl/ModuloConsultas/ucBuscarPorFecha.ascx" TagName="ucBuscarPorFecha"
    TagPrefix="uc5" %>
<%@ Register Src="webUserControl/ModuloConsultas/ucBuscarPorTextoDenuncia.ascx" TagName="ucBuscarPorTextoDenuncia"
    TagPrefix="uc1" %>
<%@ Register Src="webUserControl/ModuloConsultas/ucBuscarPorEmpresa.ascx" TagName="ucBuscarPorEmpresa"
    TagPrefix="uc2" %>
<%@ Register Src="webUserControl/ModuloConsultas/ucBuscarPorArea.ascx" TagName="ucBuscarPorArea"
    TagPrefix="uc3" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Consultas</title>
    <link href="../Styles.css" rel="stylesheet" type="text/css" />
</head>
<body onload="mostrarTabSeleccionado()">
 
   
    <form id="form1" runat="server">
   
   <input type ="hidden" id="controlOculto" runat ="server" style="width: 1px; height: 1px"/>
   
    <div>
    

   

   
   <table style="width: 720px">
   <tr>
       <td colspan="5" style="width: 747px">
       <asp:Label ID="lblPorTextoDenuncia" runat="server" Text="Por texto de denuncia" CssClass="lblGray11pxSel" Width="135px"></asp:Label>
       <asp:Label ID="lblPorFecha" runat="server" Text="Por fecha" CssClass="lblGray11px" Width="135px"></asp:Label>
       <asp:Label ID="lblPorLocalidad" runat="server" Text="Por localidad" CssClass="lblGray11px" Width="135px"></asp:Label>
       <asp:Label ID="lblPorArea" runat="server" Text="Por area" CssClass="lblGray11px" Width="135px"></asp:Label>
       <asp:Label ID="lblPorEmpresa" runat="server" Text="Por empresa" CssClass="lblGray11px" Width="135px"></asp:Label>
       </td>
       
   </tr>
   </table>
   
    
    </div>
    
    <div id="divPorTextoDenuncia" style="display:block">
        <table style="width: 248px; height: 296px;">
        <tr>
        <td style="width: 753px">
            <uc1:ucBuscarPorTextoDenuncia ID="UcBuscarPorTextoDenuncia1" runat="server" />
        
        </td>
        </tr>
        </table>
    </div>
    
    <div id="divPorFecha" style="display:none">
        <table style="width: 61px">
        <tr>
        <td >
            <uc5:ucBuscarPorFecha ID="UcBuscarPorFecha1" runat="server" />
        
        </td>
        </tr>
        </table>    
    </div>
    
    <div id="divPorLocalidad" style="display:none">
        <table style="width: 61px">
        <tr>
        <td>
            <uc4:ucBuscarPorLocalidad ID="UcBuscarPorLocalidad1" runat="server" />
        
        </td>
        </tr>
        </table>
    </div>
    
    <div id="divPorArea" style="display:none">
        <table style="width: 61px">
        <tr>
        <td style="width: 889px">
            &nbsp;<uc3:ucBuscarPorArea ID="UcBuscarPorArea1" runat="server" />
        
        </td>
        </tr>
        </table>    
    </div>
    
    <div id="divPorEmpresa" style="display:none">
        <table style="width: 61px">
        <tr>
        <td style="width: 703px">
            <uc2:ucBuscarPorEmpresa ID="UcBuscarPorEmpresa1" runat="server" />
        
        </td>
        </tr>
        </table>    
    </div>    
    
        <br />
        <table style="width: 716px; height: 88px;">
            <tr>
                <td style="width: 89px; height: 55px;" valign="top">
                    <asp:Button ID="btnListar" runat="server" Text="Listar" Width="96px" CssClass="ButtonBlue11px" Visible="False" /></td>
                <td style="width: 89px; height: 55px;" valign="top">
                    <asp:Button ID="btnVerDetalle" runat="server" Text="Ver Detalle" Width="96px" OnClick="btnVerDetalle_Click" CssClass="ButtonBlue11px" /></td>
                <td style="width: 89px; height: 55px;" valign="top">
                    <asp:Button ID="btnVolver" runat="server" Text="Volver" Width="96px" CssClass="ButtonBlue11px" OnClick="btnVolver_Click" /></td>
                <td style="width: 89px; height: 55px; border:3;" valign="top" >
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="143px" CssClass="lblBoldUpperXXS" Height="8px" Visible="False">
                        <asp:ListItem Value="Solo anio actual">Solo a&#241;o actual</asp:ListItem>
                        <asp:ListItem Value="Solo anio anterior">Solo a&#241;o anterior</asp:ListItem>
                        <asp:ListItem>Total</asp:ListItem>
                    </asp:RadioButtonList></td>
                <td style="width: 89px; height: 55px;" align="right" valign="top">
                    <asp:Button ID="btnEstadistica" runat="server" Text="Estadística" Width="96px" CssClass="ButtonBlue11px" Visible="False" /></td>
            </tr>
        </table>
    </form>
</body>



</html>
<script type ="text/javascript">

function mostrarTab(nombreTab)
{
//alert(document.getElementById("controlOculto").nodeValue);

        document.getElementById("divPorTextoDenuncia").style.display="none";
        document.getElementById("divPorFecha").style.display="none";
        document.getElementById("divPorLocalidad").style.display="none";
        document.getElementById("divPorArea").style.display="none";
        document.getElementById("divPorEmpresa").style.display="none";

        switch(nombreTab)
        {
            case "divPorTextoDenuncia":
            document.getElementById("divPorTextoDenuncia").style.display="block";
            document.getElementById("controlOculto").value = "divPorTextoDenuncia";
            
            break;
            
            case "divPorFecha":
            document.getElementById("divPorFecha").style.display="block";
            document.getElementById("controlOculto").value = "divPorFecha";
            break;
            
            case "divPorLocalidad":
            document.getElementById("divPorLocalidad").style.display="block";
            document.getElementById("controlOculto").value = "divPorLocalidad";
            break;
            
            case "divPorArea":
            document.getElementById("divPorArea").style.display="block";
            document.getElementById("controlOculto").value = "divPorArea";
            break;
            
            case "divPorEmpresa":
            document.getElementById("divPorEmpresa").style.display="block";
            document.getElementById("controlOculto").value = "divPorEmpresa";
            break;                    
        }
        
        pintarEtiqueta(nombreTab);
        
        //document.getElementById("controlOculto").value = "myValue";
//alert(document.getElementById("controlOculto").value);
}

function mostrarTabSeleccionado()
{
        
//        document.getElementById(document.getElementById("controlOculto").value).style.display="block";
        var nombreTab = document.getElementById("controlOculto").value;
        //alert(document.getElementById("controlOculto").value);
        if(nombreTab!="")
        {
            mostrarTab(nombreTab);
            pintarEtiqueta(nombreTab);
        }
}


function pintarEtiqueta(nombreTab)
{
        switch(nombreTab)
        {
            case "divPorTextoDenuncia":
            document.getElementById("lblPorTextoDenuncia").className = "lblGray11pxSel";
            document.getElementById("lblPorFecha").className = "lblGray11px";
            document.getElementById("lblPorLocalidad").className = "lblGray11px";
            document.getElementById("lblPorArea").className = "lblGray11px";
            document.getElementById("lblPorEmpresa").className = "lblGray11px";           
            
            break;
            
            case "divPorFecha":
            document.getElementById("lblPorTextoDenuncia").className = "lblGray11px";
            document.getElementById("lblPorFecha").className = "lblGray11pxSel";
            document.getElementById("lblPorLocalidad").className = "lblGray11px";
            document.getElementById("lblPorArea").className = "lblGray11px";
            document.getElementById("lblPorEmpresa").className = "lblGray11px";           
            break;
            
            case "divPorLocalidad":
            document.getElementById("lblPorTextoDenuncia").className = "lblGray11px";
            document.getElementById("lblPorFecha").className = "lblGray11px";
            document.getElementById("lblPorLocalidad").className = "lblGray11pxSel";
            document.getElementById("lblPorArea").className = "lblGray11px";
            document.getElementById("lblPorEmpresa").className = "lblGray11px";           
            break;
            
            case "divPorArea":
            document.getElementById("lblPorTextoDenuncia").className = "lblGray11px";
            document.getElementById("lblPorFecha").className = "lblGray11px";
            document.getElementById("lblPorLocalidad").className = "lblGray11px";
            document.getElementById("lblPorArea").className = "lblGray11pxSel";
            document.getElementById("lblPorEmpresa").className = "lblGray11px";           
            break;
            
            case "divPorEmpresa":
            document.getElementById("lblPorTextoDenuncia").className = "lblGray11px";
            document.getElementById("lblPorFecha").className = "lblGray11px";
            document.getElementById("lblPorLocalidad").className = "lblGray11px";
            document.getElementById("lblPorArea").className = "lblGray11px";
            document.getElementById("lblPorEmpresa").className = "lblGray11pxSel";           
            break;                    
        }
        
}

</script>