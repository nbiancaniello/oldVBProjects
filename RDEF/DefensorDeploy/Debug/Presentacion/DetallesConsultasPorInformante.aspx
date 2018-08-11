<%@ page language="C#" autoeventwireup="true" inherits="Presentacion_DetallesConsultasPorInformante, DefensorDeploy" enableEventValidation="false" %>

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
        <asp:Button ID="BtnAtras" runat="server" OnClick="BtnAtras_Click" Style="left: 224px;
            position: absolute; top: 416px" Text="Atras" Width="88px" CssClass="ButtonBlue11px" />
        <asp:Button ID="BtnAdelante" runat="server" Style="left: 344px; position: absolute;
            top: 416px" Text="Adelante" CssClass="ButtonBlue11px" OnClick="BtnAdelante_Click1" Width="88px" />
        &nbsp;
        <table id="tblCabecera" border="0" style="left: 8px; width: 776px; position: absolute;
            top: 8px; height: 8px">
            <tr>
                <td style="width: 155px; height: 12px" align="left">
                    <asp:Label ID="lbl" runat="server" CssClass="lblBoldUpperXXS" Text="Nro Expediente: "
                        Width="104px"></asp:Label>
                    </td>
                <td align="left" style="width: 185px; height: 12px">
                    <asp:TextBox ID="txtExpediente" runat="server" CssClass="TextBox" Width="40px" ReadOnly="True"></asp:TextBox></td>
                <td style="width: 244px; text-align: left; height: 12px;" align="left">
                    <asp:Label ID="Label1" runat="server" CssClass="lblBoldUpperXXS" Text="Fecha Ingreso: "></asp:Label>&nbsp;
                </td>
                <td align="left" style="width: 133px; height: 12px; text-align: left">
                    <asp:TextBox ID="txtFechaIngreso" runat="server" CssClass="TextBox" Width="56px" ReadOnly="True"></asp:TextBox></td>
                <td style="width: 182px; text-align: left; height: 12px;" align="left">
                    <asp:Label ID="Label3" runat="server" CssClass="lblBoldUpperXXS" Text="Fecha Archivo: "></asp:Label>&nbsp;
                </td>
                <td align="left" style="width: 154px; height: 12px; text-align: left">
                    <asp:TextBox ID="txtFechaArchivo" runat="server" CssClass="TextBox" Width="56px" ReadOnly="True"></asp:TextBox></td>
            </tr>
            <tr>
                <td style="width: 155px; height: 10px">
                    <asp:Label ID="Label2" runat="server" CssClass="lblBoldUpperXXS" Text="Inició: "></asp:Label></td>
                <td style="width: 185px; height: 10px">
                    <asp:TextBox ID="txtInicio" runat="server" CssClass="TextBox" Width="112px" ReadOnly="True"></asp:TextBox></td>
                <td style="width: 244px; height: 10px;">
                    <asp:Label ID="Label4" runat="server" CssClass="lblBoldUpperXXS" Text="Informante: "></asp:Label>
                    </td>
                <td style="width: 133px; height: 10px">
                    <asp:TextBox ID="txtInformante" runat="server" CssClass="TextBox" Width="112px" ReadOnly="True"></asp:TextBox></td>
                <td style="width: 182px; text-align: left; height: 10px;">
                                <asp:Label ID="Label18" runat="server" CssClass="lblBoldUpperXXS" Text="Entidad Denunciada: " Width="128px"></asp:Label></td>
                <td style="width: 154px; height: 10px; text-align: left">
                    <asp:TextBox ID="txtDenunciado" runat="server" CssClass="TextBox" Width="120px" ReadOnly="True"></asp:TextBox></td>
            </tr>
        </table>
        <br />
                    <table id="tblDenunciante" style="width: 776px; height: 160px; left: 8px; position: absolute; top: 64px;">
                        <tr>
                            <td style="width: 147px; height: 25px">
                                <asp:Label ID="Label5" runat="server" CssClass="lblBoldUpperXXS" Text="Apellido: "></asp:Label></td>
                            <td style="width: 113px; height: 25px;">
                                <asp:TextBox ID="txtApellido" runat="server" CssClass="TextBox" ReadOnly="True" Width="112px"></asp:TextBox></td>
                            <td style="width: 233px; height: 25px">
                                <asp:Label ID="Label10" runat="server" CssClass="lblBoldUpperXXS" Text="Nombres: "></asp:Label></td>
                            <td style="width: 116px; height: 25px">
                                <asp:TextBox ID="txtNombre" runat="server" CssClass="TextBox" ReadOnly="True" Width="168px"></asp:TextBox></td>
                            <td style="width: 153px; height: 25px;">
                                </td>
                            <td style="width: 120px; height: 25px;">
                                </td>
                        </tr>
                        <tr>
                            <td style="width: 147px; height: 10px">
                                <asp:Label ID="Label7" runat="server" CssClass="lblBoldUpperXXS" Text="Calle: "></asp:Label></td>
                            <td style="width: 113px;">
                                <asp:TextBox ID="txtCalle" runat="server" CssClass="TextBox" ReadOnly="True" Width="112px"></asp:TextBox></td>
                            <td style="width: 233px">
                                <asp:Label ID="Label15" runat="server" CssClass="lblBoldUpperXXS" Text="Nro: "></asp:Label></td>
                            <td style="width: 116px">
                                <asp:TextBox ID="txtNro" runat="server" CssClass="TextBox" ReadOnly="True" Width="64px"></asp:TextBox></td>
                            <td style="width: 153px;">
                                <asp:Label ID="Label16" runat="server" CssClass="lblBoldUpperXXS" Text="Piso:      "
                                    Width="40px"></asp:Label>
                                <asp:TextBox ID="txtPiso" runat="server" CssClass="TextBox" ReadOnly="True" Width="32px"></asp:TextBox></td>
                            <td style="width: 120px;">
                                <asp:Label ID="Label17" runat="server" CssClass="lblBoldUpperXXS" Text="Dpto: " Width="40px"></asp:Label>
                                <asp:TextBox ID="txtDpto" runat="server" CssClass="TextBox" ReadOnly="True" Width="56px"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width: 147px; height: 10px">
                                <asp:Label ID="Label8" runat="server" CssClass="lblBoldUpperXXS" Text="Tipo Doc: "></asp:Label></td>
                            <td style="width: 113px;">
                                <asp:TextBox ID="txtTipoDoc" runat="server" CssClass="TextBox" ReadOnly="True"
                                    Width="40px"></asp:TextBox>
                                &nbsp;
                            </td>
                            <td style="width: 233px">
                                <asp:Label ID="Label22" runat="server" CssClass="lblBoldUpperXXS" Text="Nro Doc:    "
                                    Width="56px"></asp:Label></td>
                            <td style="width: 116px">
                                <asp:TextBox ID="txtNroDoc" runat="server" CssClass="TextBox" ReadOnly="True" Width="80px"></asp:TextBox></td>
                            <td style="width: 153px;">
                                <asp:Label ID="Label11" runat="server" CssClass="lblBoldUpperXXS" Text="Localidad: "></asp:Label></td>
                            <td style="width: 120px;">
                                <asp:TextBox ID="txtLocalidad" runat="server" CssClass="TextBox" Width="112px" ReadOnly="True"></asp:TextBox></td>
                        </tr>
                        <tr>
                            <td style="width: 147px; height: 10px">
                                <asp:Label ID="Label9" runat="server" CssClass="lblBoldUpperXXS" Text="Telefono: "></asp:Label></td>
                            <td style="width: 113px;">
                                <asp:TextBox ID="txtTelefono" runat="server" CssClass="TextBox" ReadOnly="True" Width="112px"></asp:TextBox></td>
                            <td style="width: 233px">
                                <asp:Label ID="Label12" runat="server" CssClass="lblBoldUpperXXS" Text="Celular: "></asp:Label></td>
                            <td style="width: 116px">
                                <asp:TextBox ID="txtCelular" runat="server" CssClass="TextBox" ReadOnly="True" Width="112px"></asp:TextBox></td>
                            <td style="width: 153px;">
                                </td>
                            <td style="width: 120px;">
                                &nbsp;</td>
                        </tr>
                        <tr>
                            <td style="width: 147px; height: 10px">
                                <asp:Label ID="Label14" runat="server" CssClass="lblBoldUpperXXS" Text="Email: "></asp:Label></td>
                            <td style="width: 113px;">
                                <asp:TextBox ID="txtEmail" runat="server" CssClass="TextBox" ReadOnly="True" Width="200px"></asp:TextBox></td>
                            <td style="width: 233px">
                            </td>
                            <td style="width: 116px">
                            </td>
                            <td style="width: 153px;">
                                </td>
                            <td style="width: 120px;">
                                </td>
                        </tr>
                    </table>
                    <table id="tblDenuncia" border="0" style="width: 768px; height: 160px; left: 8px; position: absolute; top: 232px;">
                        <tr>
                            <td style="height: 10px; text-align: left; width: 267px;" colspan="2">
                                <asp:Label ID="Label19" runat="server" CssClass="lblBoldUpperXXS" Text="Area: "></asp:Label></td>
                            <td colspan="1" style="width: 355px; height: 10px; text-align: left">
                                <asp:TextBox ID="txtArea" runat="server" CssClass="TextBox" Width="160px" ReadOnly="True"></asp:TextBox></td>
                            <td colspan="1" style="width: 228px; height: 10px; text-align: left">
                                <asp:Label ID="Label20" runat="server" CssClass="lblBoldUpperXXS" Text="Tipo Denuncia: "></asp:Label></td>
                            <td colspan="1" style="width: 379px; height: 10px; text-align: left">
                                <asp:TextBox ID="txtTipoDenuncia" runat="server" CssClass="TextBox" Width="112px" ReadOnly="True"></asp:TextBox></td>
                            <td colspan="1" style="width: 228px; height: 10px; text-align: left">
                            </td>
                            <td colspan="1" style="width: 764px; height: 10px; text-align: left">
                            </td>
                        </tr>
                        <tr>
                            <td colspan="8" rowspan="2" style="height: 19px; width: 779px;">
                                <asp:Label ID="Label21" runat="server" CssClass="lblBoldUpperXXS" Text="Detalle de la Denuncia: "></asp:Label>
                                <asp:TextBox ID="txtDetalleDenuncia" runat="server" Height="104px" ReadOnly="True"
                                    TextMode="MultiLine" Width="760px"></asp:TextBox></td>
                        </tr>
                        <tr>
                        </tr>
                    </table>
        <asp:Button ID="btnPrimero" runat="server" CssClass="ButtonBlue11px" Style="left: 104px;
            position: absolute; top: 416px" Text="Ir al Primero" OnClick="btnPrimero_Click" Width="88px" />
        <asp:Button ID="btnUltimo" runat="server" CssClass="ButtonBlue11px" Style="left: 464px;
            position: absolute; top: 416px" Text="Ir al Ultimo" OnClick="btnUltimo_Click" Width="88px" />
        &nbsp;
        <asp:Button ID="btnVolver" runat="server" CssClass="ButtonBlue11px" OnClick="Button1_Click"
            Style="left: 584px; position: absolute; top: 416px" Text="Salir" Width="88px" />
    
    </div>
    </form>
</body>
</html>
