<%@ page language="C#" autoeventwireup="true" inherits="DetalleDenuncia, DefensorDeploy" enableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Detalle de la denuncia</title>
    <link href="../Styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <table style="width: 712px">
            <tr>
                <td style="height: 21px; width: 94px;">
                    <asp:Label ID="Label1" runat="server" Text="Nº Expediente" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="width: 152px; height: 21px">
                    <asp:TextBox ID="txtNroExpediente" runat="server" ReadOnly="True" CssClass="TextBox"></asp:TextBox></td>
                <td style="height: 21px; width: 104px;">
                    <asp:Label ID="Label16" runat="server" Text="Ingreso" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="width: 196px; height: 21px">
                    <asp:TextBox ID="txtIngreso" runat="server" ReadOnly="True" CssClass="TextBox"></asp:TextBox></td>
                <td style="height: 21px; width: 97px;">
                    <asp:Label ID="Label15" runat="server" Text="Archivo" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="height: 21px">
                    <asp:TextBox ID="txtArchivo" runat="server" ReadOnly="True" CssClass="TextBox"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 94px; height: 26px">
                    <asp:Label ID="Label2" runat="server" Text="Apellido" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="width: 152px; height: 26px;">
                    <asp:TextBox ID="txtApellido" runat="server" ReadOnly="True" CssClass="TextBox"></asp:TextBox></td>
                <td style="width: 104px; height: 26px;">
                    <asp:Label ID="Label9" runat="server" Text="Nombre" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="width: 196px; height: 26px;">
                    <asp:TextBox ID="txtNombre" runat="server" ReadOnly="True" CssClass="TextBox"></asp:TextBox></td>
                <td style="width: 97px; height: 26px;">
                    <asp:Label ID="Label3" runat="server" Text="Domicilio" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="height: 26px">
                    <asp:TextBox ID="txtDomicilio" runat="server" ReadOnly="True" CssClass="TextBox"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 94px">
                    <asp:Label ID="Label13" runat="server" Text="Localidad" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="width: 152px">
                    <asp:TextBox ID="txtLocalidad" runat="server" ReadOnly="True" CssClass="TextBox"></asp:TextBox></td>
                <td style="width: 104px">
                    <asp:Label ID="Label11" runat="server" Text="CP" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="width: 196px">
                    <asp:TextBox ID="txtCP" runat="server" ReadOnly="True" CssClass="TextBox"></asp:TextBox></td>
                <td style="width: 97px">
                    <asp:Label ID="Label17" runat="server" Text="Número" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td>
                    <asp:TextBox ID="txtNumero" runat="server" ReadOnly="True" CssClass="TextBox"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 94px">
                    <asp:Label ID="Label4" runat="server" Text="Nº Doc" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="width: 152px">
                    <asp:TextBox ID="txtNroDocumento" runat="server" ReadOnly="True" CssClass="TextBox"></asp:TextBox></td>
                <td style="width: 104px">
                    <asp:Label ID="Label14" runat="server" Text="Tipo" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="width: 196px">
                    <asp:TextBox ID="txtTipoDocumento" runat="server" ReadOnly="True" CssClass="TextBox"></asp:TextBox></td>
                <td style="width: 97px">
                    </td>
                <td>
                    </td>
            </tr>
            <tr>
                <td style="height: 133px; width: 94px;">
                    <asp:Label ID="Label20" runat="server" Text="Contactos" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td colspan="5" style="height: 133px">
                    <asp:GridView ID="gvwContactos" runat="server" Height="1%" PageSize="4" Width="100%" AllowPaging="True" CssClass="DataGrid">
                        <FooterStyle CssClass="DataGridItem" />
                        <HeaderStyle CssClass="DataGridHeader" />
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td style="width: 94px">
                    <asp:Label ID="Label5" runat="server" Text="Ente" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="width: 152px">
                    <asp:TextBox ID="txtEnte" runat="server" ReadOnly="True" CssClass="TextBox"></asp:TextBox></td>
                <td style="width: 104px">
                </td>
                <td style="width: 196px">
                    <asp:Label ID="Label10" runat="server" Text="Tema" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="width: 97px">
                    <asp:TextBox ID="txtTema" runat="server" ReadOnly="True" CssClass="TextBox"></asp:TextBox></td>
                <td>
                    </td>
            </tr>
            <tr>
                <td style="height: 21px; width: 94px;">
                    <asp:Label ID="Label6" runat="server" Text="Area" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="width: 152px; height: 21px">
                    <asp:TextBox ID="txtArea" runat="server" ReadOnly="True" CssClass="TextBox"></asp:TextBox></td>
                <td style="height: 21px; width: 104px;">
                </td>
                <td style="width: 196px; height: 21px">
                    <asp:Label ID="Label7" runat="server" Text="Tipo de Denuncia" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="height: 21px; width: 97px;">
                    <asp:TextBox ID="txtTipoDenuncia" runat="server" ReadOnly="True" CssClass="TextBox"></asp:TextBox></td>
                <td style="height: 21px">
                    </td>
            </tr>
            <tr>
                <td style="width: 94px">
                    </td>
                <td style="width: 152px">
                    </td>
                <td style="width: 104px">
                </td>
                <td style="width: 196px">
                </td>
                <td style="width: 97px">
                    </td>
                <td>
                    </td>
            </tr>
            <tr>
                <td style="width: 94px">
                    <asp:Label ID="Label8" runat="server" Text="Denuncia" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="width: 152px">
                    </td>
                <td style="width: 104px">
                </td>
                <td style="width: 196px">
                </td>
                <td style="width: 97px">
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td colspan="6" rowspan="4">
                    <asp:TextBox ID="txtDenuncia" runat="server" Height="128px" Width="99%" ReadOnly="True"></asp:TextBox></td>
            </tr>
            <tr>
            </tr>
            <tr>
            </tr>
            <tr>
            </tr>
            <tr>
                <td style="height: 17px; width: 94px;">
                    <asp:Label ID="Label18" runat="server" Text="Informante" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="width: 152px; height: 17px;">
                    <asp:TextBox ID="txtInformante" runat="server" ReadOnly="True" CssClass="TextBox"></asp:TextBox></td>
                <td style="height: 17px; width: 104px;">
                </td>
                <td style="width: 196px; height: 17px;">
                </td>
                <td style="height: 17px; width: 97px;">
                    <asp:Label ID="Label19" runat="server" Text="Inicio" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="height: 17px">
                    <asp:TextBox ID="txtInicio" runat="server" ReadOnly="True" CssClass="TextBox"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 94px">
                </td>
                <td style="width: 152px">
                </td>
                <td style="width: 104px">
                </td>
                <td style="width: 196px">
                </td>
                <td style="width: 97px">
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td style="width: 94px">
                </td>
                <td style="width: 152px">
                </td>
                <td style="width: 104px">
                </td>
                <td style="width: 196px" align="center">
                    <asp:Button ID="btnVolver" runat="server" Text="Volver" Width="80px" PostBackUrl="~/Presentacion/Consultas.aspx" CssClass="ButtonBlue11px"  /></td>
                <td style="width: 97px">
                </td>
                <td>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
