<%@ page language="C#" autoeventwireup="true" inherits="Presentacion_DetallesConsultasPorInformante, App_Web_r2qjsibb" enableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Detalles Del Expediente</title>
    <link href="../Styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        &nbsp;
        <asp:Button ID="BtnAtras" runat="server" OnClick="BtnAtras_Click" Style="left: 480px;
            position: absolute; top: 592px" Text="Atras" Width="72px" CssClass="ButtonBlue11px" />
        <asp:Button ID="BtnAdelante" runat="server" Style="left: 576px; position: absolute;
            top: 592px" Text="Adelante" CssClass="ButtonBlue11px" OnClick="BtnAdelante_Click1" />
        &nbsp;
        <table id="tblCabecera" border="0" style="left: 232px; width: 712px; position: absolute;
            top: 0px; height: 8px">
            <tr>
                <td style="width: 725px; height: 35px" align="left">
                    <asp:Label ID="lbl" runat="server" CssClass="lblBoldUpperXXS" Text="Nro Expediente: "
                        Width="104px"></asp:Label>
                    <asp:TextBox ID="txtExpediente" runat="server" CssClass="TextBox" Width="72px"></asp:TextBox></td>
                <td style="width: 862px; text-align: left" align="left">
                    <asp:Label ID="Label1" runat="server" CssClass="lblBoldUpperXXS" Text="Fecha Ingreso: "></asp:Label>
                    <asp:TextBox ID="txtFechaIngreso" runat="server" CssClass="TextBox" Width="56px"></asp:TextBox>
                </td>
                <td style="width: 1221px; text-align: left" align="left">
                    <asp:Label ID="Label3" runat="server" CssClass="lblBoldUpperXXS" Text="Fecha Archivo: "></asp:Label>
                    <asp:TextBox ID="txtFechaArchivo" runat="server" CssClass="TextBox" Width="56px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="width: 725px; height: 35px">
                    <asp:Label ID="Label2" runat="server" CssClass="lblBoldUpperXXS" Text="Inició: "></asp:Label>
                    <asp:TextBox ID="txtInicio" runat="server" CssClass="TextBox" Width="120px"></asp:TextBox></td>
                <td style="width: 862px;">
                    <asp:Label ID="Label4" runat="server" CssClass="lblBoldUpperXXS" Text="Informante: "></asp:Label>
                    <asp:TextBox ID="txtInformante" runat="server" CssClass="TextBox" Width="112px"></asp:TextBox></td>
                <td style="width: 1221px; text-align: left">
                                <asp:Label ID="Label18" runat="server" CssClass="lblBoldUpperXXS" Text="Entidad Denunciada: "></asp:Label><asp:TextBox ID="txtDenunciado" runat="server" CssClass="TextBox" Width="120px"></asp:TextBox>&nbsp;
                </td>
            </tr>
        </table>
        <br />
                    <table id="tblDenunciante" style="width: 712px; height: 264px; left: 232px; position: absolute; top: 80px;">
                        <tr>
                            <td style="width: 74px; height: 5px">
                                <asp:Label ID="Label5" runat="server" CssClass="lblBoldUpperXXS" Text="Apellido: "></asp:Label></td>
                            <td style="width: 550px;">
                                <asp:TextBox ID="txtApellido" runat="server" CssClass="TextBox" ReadOnly="True"></asp:TextBox></td>
                            <td style="width: 54px;">
                                <asp:Label ID="Label10" runat="server" CssClass="lblBoldUpperXXS" Text="Nombres: "></asp:Label></td>
                            <td style="width: 314px;">
                                <asp:TextBox ID="txtNombre" runat="server" CssClass="TextBox" ReadOnly="True" Width="224px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width: 74px; height: 10px">
                                <asp:Label ID="Label7" runat="server" CssClass="lblBoldUpperXXS" Text="Calle: "></asp:Label></td>
                            <td style="width: 550px;">
                                <asp:TextBox ID="txtCalle" runat="server" CssClass="TextBox" ReadOnly="True"></asp:TextBox></td>
                            <td style="width: 54px;">
                                <asp:Label ID="Label15" runat="server" CssClass="lblBoldUpperXXS" Text="Nro: "></asp:Label></td>
                            <td style="width: 314px;">
                                <asp:TextBox ID="txtNro" runat="server" CssClass="TextBox" ReadOnly="True" Width="64px"></asp:TextBox>
                                <asp:Label ID="Label16" runat="server" CssClass="lblBoldUpperXXS" Text="Piso:      "
                                    Width="40px"></asp:Label>
                                <asp:TextBox ID="txtPiso" runat="server" CssClass="TextBox" ReadOnly="True" Width="40px"></asp:TextBox>
                                <asp:Label ID="Label17" runat="server" CssClass="lblBoldUpperXXS" Text="Dpto: " Width="40px"></asp:Label>
                                <asp:TextBox ID="txtDpto" runat="server" CssClass="TextBox" ReadOnly="True" Width="56px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width: 74px; height: 10px">
                                <asp:Label ID="Label8" runat="server" CssClass="lblBoldUpperXXS" Text="Tipo Doc: "></asp:Label></td>
                            <td style="width: 550px;">
                                &nbsp;<asp:TextBox ID="txtTipoDoc" runat="server" CssClass="TextBox" ReadOnly="True"
                                    Width="40px"></asp:TextBox>
                                <asp:Label ID="Label22" runat="server" CssClass="lblBoldUpperXXS" Text="Nro Doc:    "
                                    Width="56px"></asp:Label>
                                <asp:TextBox ID="txtNroDoc" runat="server" CssClass="TextBox" ReadOnly="True" Width="104px"></asp:TextBox>
                            </td>
                            <td style="width: 54px;">
                                <asp:Label ID="Label11" runat="server" CssClass="lblBoldUpperXXS" Text="Localidad: "></asp:Label></td>
                            <td style="width: 314px;">
                                &nbsp;<asp:TextBox ID="txtLocalidad" runat="server" CssClass="TextBox" Width="168px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width: 74px; height: 10px">
                                <asp:Label ID="Label9" runat="server" CssClass="lblBoldUpperXXS" Text="Telefono: "></asp:Label></td>
                            <td style="width: 550px;">
                                <asp:TextBox ID="txtTelefono" runat="server" CssClass="TextBox" ReadOnly="True"></asp:TextBox></td>
                            <td style="width: 54px;">
                                </td>
                            <td style="width: 314px;">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 74px; height: 10px">
                                <asp:Label ID="Label12" runat="server" CssClass="lblBoldUpperXXS" Text="Celular: "></asp:Label></td>
                            <td style="width: 550px;">
                                <asp:TextBox ID="txtCelular" runat="server" CssClass="TextBox" ReadOnly="True"></asp:TextBox></td>
                            <td style="width: 54px;">
                                <asp:Label ID="Label14" runat="server" CssClass="lblBoldUpperXXS" Text="Email: "></asp:Label></td>
                            <td style="width: 314px;">
                                <asp:TextBox ID="txtEmail" runat="server" CssClass="TextBox" ReadOnly="True" Width="264px"></asp:TextBox></td>
                        </tr>
                    </table>
                    <table id="tblDenuncia" border="0" style="width: 712px; height: 248px; left: 232px; position: absolute; top: 344px;">
                        <tr>
                            <td style="height: 10px; text-align: left;" colspan="2">
                                &nbsp;<asp:Label ID="Label19" runat="server" CssClass="lblBoldUpperXXS" Text="Area: "></asp:Label>
                                &nbsp; &nbsp; &nbsp;&nbsp;
                                <asp:TextBox ID="txtArea" runat="server" CssClass="TextBox" Width="160px"></asp:TextBox>
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                                &nbsp; &nbsp;
                                <asp:Label ID="Label20" runat="server" CssClass="lblBoldUpperXXS" Text="Tipo Denuncia: "></asp:Label>
                                &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<asp:TextBox ID="txtTipoDenuncia" runat="server" CssClass="TextBox" Width="112px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td colspan="3" rowspan="2" style="height: 21px">
                                <asp:Label ID="Label21" runat="server" CssClass="lblBoldUpperXXS" Text="Detalle de la Denuncia: "></asp:Label>
                                <asp:TextBox ID="txtDetalleDenuncia" runat="server" Height="144px" ReadOnly="True"
                                    TextMode="MultiLine" Width="688px"></asp:TextBox></td>
                        </tr>
                        <tr>
                        </tr>
                    </table>
        <asp:Button ID="btnPrimero" runat="server" CssClass="ButtonBlue11px" Style="left: 376px;
            position: absolute; top: 592px" Text="Ir al Primero" OnClick="btnPrimero_Click" />
        <asp:Button ID="btnUltimo" runat="server" CssClass="ButtonBlue11px" Style="left: 680px;
            position: absolute; top: 592px" Text="Ir al Ultimo" OnClick="btnUltimo_Click" />
        <asp:LinkButton ID="LinkVolver" runat="server" CssClass="lblBoldUpperXXS" Font-Underline="True"
            Style="left: 160px; position: absolute; top: 16px" OnClick="LinkVolver_Click">Volver</asp:LinkButton>
    
    </div>
    </form>
</body>
</html>
