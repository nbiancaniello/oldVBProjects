<%@ Page Language="C#" AutoEventWireup="true" CodeFile="MenuMantenimiento.aspx.cs" Inherits="Presentacion_MenuMantenimiento" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Mantenimiento</title>
    <link href="../styles.css" rel="stylesheet" type="text/css" />
</head>
<script type ="text/javascript" >

function pintarEtiqueta(etiqueta){

    document.getElementById("cuerpoPrincipal").style.cursor="pointer";

    switch(etiqueta)
    {
        case "areas":
            document.getElementById("lblAreas").style.backgroundColor = "#58ACFA";
            document.getElementById("lblDenunciados").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblDependencias").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblFines").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblLocalidades").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblPersonas").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposDenuncia").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposExpediente").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposMovimiento").style.backgroundColor = "#ecf4ff";
        break;
        
        case "Denunciados":
            document.getElementById("lblAreas").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblDenunciados").style.backgroundColor = "#58ACFA";
            document.getElementById("lblDependencias").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblFines").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblLocalidades").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblPersonas").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposDenuncia").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposExpediente").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposMovimiento").style.backgroundColor = "#ecf4ff";
        break;
        
        case "dependencias":
            document.getElementById("lblAreas").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblDenunciados").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblDependencias").style.backgroundColor = "#58ACFA";
            document.getElementById("lblFines").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblLocalidades").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblPersonas").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposDenuncia").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposExpediente").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposMovimiento").style.backgroundColor = "#ecf4ff";
        break;
        
        case "fines":
            document.getElementById("lblAreas").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblDenunciados").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblDependencias").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblFines").style.backgroundColor = "#58ACFA";
            document.getElementById("lblLocalidades").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblPersonas").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposDenuncia").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposExpediente").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposMovimiento").style.backgroundColor = "#ecf4ff";
        break;    

        case "localidades":
            document.getElementById("lblAreas").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblDenunciados").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblDependencias").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblFines").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblLocalidades").style.backgroundColor = "#58ACFA";
            document.getElementById("lblPersonas").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposDenuncia").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposExpediente").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposMovimiento").style.backgroundColor = "#ecf4ff";
        break;
        
        case "personas":
            document.getElementById("lblAreas").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblDenunciados").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblDependencias").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblFines").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblLocalidades").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblPersonas").style.backgroundColor = "#58ACFA";
            document.getElementById("lblTiposDenuncia").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposExpediente").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposMovimiento").style.backgroundColor = "#ecf4ff";
        break;
        
        case "tipodenuncias":
            document.getElementById("lblAreas").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblDenunciados").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblDependencias").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblFines").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblLocalidades").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblPersonas").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposDenuncia").style.backgroundColor = "#58ACFA";
            document.getElementById("lblTiposExpediente").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposMovimiento").style.backgroundColor = "#ecf4ff";
        break;
        
        case "tipo Expediente":
            document.getElementById("lblAreas").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblDenunciados").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblDependencias").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblFines").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblLocalidades").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblPersonas").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposDenuncia").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposExpediente").style.backgroundColor = "#58ACFA";
            document.getElementById("lblTiposMovimiento").style.backgroundColor = "#ecf4ff";
        break;
        
        case "TipoMovimiento":
            document.getElementById("lblAreas").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblDenunciados").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblDependencias").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblFines").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblLocalidades").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblPersonas").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposDenuncia").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposExpediente").style.backgroundColor = "#ecf4ff";
            document.getElementById("lblTiposMovimiento").style.backgroundColor = "#58ACFA";
        break;
    }
}

function blanquearEtiquetas(etiqueta)
{           
    document.getElementById("cuerpoPrincipal").style.cursor="auto";
    
    switch(etiqueta)
    {
        case "areas":
            document.getElementById("lblAreas").style.backgroundColor = "#ecf4ff";
        break;
        
        case "Denunciados":
            document.getElementById("lblDenunciados").style.backgroundColor = "#ecf4ff";
        break;
        
        case "dependencias":
            document.getElementById("lblDependencias").style.backgroundColor = "#ecf4ff";
        break;
        
        case "fines":
            document.getElementById("lblFines").style.backgroundColor = "#ecf4ff";
        break;     

        case "localidades":
            document.getElementById("lblLocalidades").style.backgroundColor = "#ecf4ff";
        break;
        
        case "personas":
            document.getElementById("lblPersonas").style.backgroundColor = "#ecf4ff";
        break;
        
        case "tipodenuncias":
            document.getElementById("lblTiposDenuncia").style.backgroundColor = "#ecf4ff";
        break;     

        case "tipo Expediente":
            document.getElementById("tipo Expediente").style.backgroundColor = "#ecf4ff";
        break;
        
        case "TipoMovimiento":
            document.getElementById("TipoMovimiento").style.backgroundColor = "#ecf4ff";
        break;
    }
}

function redireccionar(etiqueta)
{           

    document.getElementById("cuerpoPrincipal").style.cursor="auto";
    
    switch(etiqueta)
    {
        case "areas":
            location.href = "areas.aspx";
        break;
        
        case "Denunciados":
            location.href = "Denunciados.aspx";
        break;
        
        case "dependencias":
            location.href = "dependencias.aspx";
        break;
        
        case "fines":
            location.href = "fines.aspx";
        break;    

        case "localidades":
            location.href = "localidades.aspx";
        break;
        
        case "personas":
            location.href = "personas.aspx";
        break;
        
        case "tipodenuncias":
            location.href = "tipodenuncias.aspx";
        break;
        
        case "tipo Expediente":
            location.href = "tipo Expediente.aspx";
        break;    

        case "TipoMovimiento":
            location.href = "TipoMovimiento.aspx";
        break;
    }
}
</script>
<body style="text-align: left" id="cuerpoPrincipal">
    <form id="form1" runat="server">
    <div>
        &nbsp;<table style="width: 704px">
            <tr>
                <td style="width: 161px">
                </td>
                <td style="width: 265px">
                    &nbsp; &nbsp; &nbsp;&nbsp;
                    <asp:Label ID="lblMantenimiento" runat="server" Font-Names="Tahoma" Font-Size="24pt"
                        Text="Mantenimiento"></asp:Label></td>
                <td>
                </td>
            </tr>
        </table>
        <table style="width: 704px; height: 328px">
            <tr>
                <td style="width: 141px; height: 21px">
                </td>
                <td style="width: 44px">
                </td>
                <td style="width: 257px">
                </td>
                <td>
                </td>
            </tr>
                        <tr>
                            <td style="width: 141px; height: 21px">
                                </td>
                            <td style="width: 44px">
                                <asp:Image ID="imgExpedientes" runat="server" ImageUrl="~/Imagenes/next.gif" /></td>
                            <td style="width: 257px">
                                <asp:Label ID="lblAreas" runat="server" Font-Names="Tahoma" Font-Size="16pt" Text="Areas"></asp:Label></td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 141px">
                                </td>
                            <td style="width: 44px">
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/Imagenes/next.gif" /></td>
                            <td style="width: 257px">
                                <asp:Label ID="lblDenunciados" runat="server" Text="Denunciados" Font-Size="16pt" Font-Names="Tahoma"></asp:Label></td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 141px">
                                </td>
                            <td style="width: 44px">
                                <asp:Image ID="Image2" runat="server" ImageUrl="~/Imagenes/next.gif" /></td>
                            <td style="width: 257px">
                                <asp:Label ID="lblDependencias" runat="server" Text="Dependencias" Font-Size="16pt" Font-Names="Tahoma"></asp:Label></td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 141px">
                                </td>
                            <td style="width: 44px">
                                <asp:Image ID="Image3" runat="server" ImageUrl="~/Imagenes/next.gif" /></td>
                            <td style="width: 257px">
                                <asp:Label ID="lblFines" runat="server" Text="Fines" Font-Size="16pt" Font-Names="Tahoma"></asp:Label></td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 141px">
                                </td>
                            <td style="width: 44px">
                                <asp:Image ID="Image4" runat="server" ImageUrl="~/Imagenes/next.gif" /></td>
                            <td style="width: 257px">
                                <asp:Label ID="lblLocalidades" runat="server" Text="Localidades" Font-Size="16pt" Font-Names="Tahoma"></asp:Label></td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 141px">
                                </td>
                            <td style="width: 44px">
                                <asp:Image ID="Image5" runat="server" ImageUrl="~/Imagenes/next.gif" /></td>
                            <td style="width: 257px">
                                <asp:Label ID="lblPersonas" runat="server" Text="Personas" Font-Size="16pt" Font-Names="Tahoma"></asp:Label></td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 141px">
                                </td>
                            <td style="width: 44px">
                                <asp:Image ID="Image6" runat="server" ImageUrl="~/Imagenes/next.gif" /></td>
                            <td style="width: 257px">
                                <asp:Label ID="lblTiposDenuncia" runat="server" Text="Tipos de Denuncia" Font-Size="16pt" Font-Names="Tahoma"></asp:Label></td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 141px">
                                </td>
                            <td style="width: 44px">
                                <asp:Image ID="Image7" runat="server" ImageUrl="~/Imagenes/next.gif" /></td>
                            <td style="width: 257px">
                                <asp:Label ID="lblTiposExpediente" runat="server" Text="Tipos de  Expediente" Font-Size="16pt" Font-Names="Tahoma"></asp:Label></td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 141px">
                                </td>
                            <td style="width: 44px">
                                <asp:Image ID="Image8" runat="server" ImageUrl="~/Imagenes/next.gif" /></td>
                            <td style="width: 257px">
                                <asp:Label ID="lblTiposMovimiento" runat="server" Text="Tipos de  Movimiento" Font-Size="16pt" Font-Names="Tahoma"></asp:Label></td>
                            <td>
                            </td>
                        </tr>
                        <tr>
                            <td style="width: 141px">
                            </td>
                            <td style="width: 44px">
                            </td>
                            <td style="width: 257px">
                            </td>
                            <td>
                            </td>
                        </tr>
            <tr>
                <td style="width: 141px">
                </td>
                <td style="width: 44px">
                </td>
                <td style="width: 257px">
                    </td>
                <td>
                    <asp:Button ID="Button1" runat="server" CssClass="ButtonBlue11px" OnClick="Button1_Click"
                        Text="Salir" Width="88px" /></td>
            </tr>
                    </table>
    
    </div>
    </form>
</body>
</html>
