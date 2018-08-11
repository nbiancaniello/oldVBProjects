<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TipoDocumento.aspx.cs" Inherits="Presentacion_TipoDocumento" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
    <link href="../styles.css" rel="stylesheet" type="text/css" />
</head>
<body style="text-align: left">
    <form id="form1" runat="server">
    <div>
        <div>
            <table id="tblPartidos" style="width: 608px; height: 48px">
                <tr>
                    <td style="width: 228px; height: 2px">
                    </td>
                    <td style="width: 651px; height: 2px; text-align: center">
                    </td>
                    <td style="width: 121px; height: 2px">
                    </td>
                    <td style="width: 179px; height: 2px">
                    </td>
                    <td style="width: 179px; height: 2px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 228px; height: 2px">
                    </td>
                    <td align="right" style="width: 651px; height: 2px">
                        &nbsp;</td>
                    <td style="width: 121px; height: 2px">
                    </td>
                    <td style="width: 179px; height: 2px">
                    </td>
                    <td style="width: 179px; height: 2px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 228px; height: 2px">
                    </td>
                    <td style="width: 651px; height: 2px; text-align: center">
                    </td>
                    <td style="width: 121px; height: 2px">
                    </td>
                    <td style="width: 179px; height: 2px">
                    </td>
                    <td style="width: 179px; height: 2px">
                    </td>
                </tr>
                <tr>
                    <td style="width: 228px; height: 2px">
                    </td>
                    <td style="width: 651px; height: 2px; text-align: center">
                    </td>
                    <td style="width: 121px; height: 2px">
                    </td>
                    <td style="width: 179px; height: 2px">
                    </td>
                    <td style="width: 179px; height: 2px">
                    </td>
                </tr>
            </table>
            <table id="tblLocalidades" style="width: 608px; height: 360px">
                <tr>
                    <td align="left" colspan="1" style="width: 336px; height: 20px" valign="top">
                    </td>
                    <td align="left" colspan="4" style="height: 20px" valign="top">
                        <asp:Label ID="lbl" runat="server" CssClass="lblBoldUpperXXS" Font-Bold="True" Text="Tipos De Documento"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td align="center" colspan="1" style="width: 336px; height: 16px" valign="top">
                    </td>
                    <td align="center" colspan="4" style="height: 16px" valign="top">
                        <table style="width: 248px; height: 56px">
                            <tr>
                                <td style="width: 264px; height: 165px">
                                    <asp:GridView ID="GvTipoDocumento" runat="server" AllowPaging="True" CssClass="DataGrid"
                                        ForeColor="Black" Height="168px" Width="280px">
                                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <RowStyle BackColor="#EFF3FB" />
                                        <Columns>
                                            <asp:CommandField ButtonType="Image" EditImageUrl="~/Imagenes/next.gif" ShowEditButton="True"
                                                UpdateImageUrl="~/Imagenes/show2.gif" />
                                        </Columns>
                                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <EditRowStyle BackColor="#2461BF" />
                                        <AlternatingRowStyle BackColor="White" />
                                    </asp:GridView>
                                    &nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 336px; height: 23px">
                    </td>
                    <td align="right" style="width: 447px; height: 23px">
                        <asp:Button ID="btnAgregar" runat="server" CssClass="ButtonBlue11px" Text="Agregar" /></td>
                    <td align="center" style="width: 74px; height: 23px; text-align: center">
                        <asp:Button ID="btnmodificar" runat="server" CssClass="ButtonBlue11px" Text="Modificar" /></td>
                    <td style="width: 224px; height: 23px">
                        <asp:Button ID="btnEliminar" runat="server" CssClass="ButtonBlue11px" Text="Eliminar" /></td>
                    <td style="width: 179px; height: 23px; text-align: center">
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 336px; height: 21px">
                    </td>
                    <td align="right" style="width: 447px; height: 21px">
                    </td>
                    <td style="width: 74px; height: 21px; text-align: center">
                    </td>
                    <td style="width: 224px; height: 21px; text-align: center">
                    </td>
                    <td style="width: 179px; height: 21px; text-align: center">
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 336px; height: 23px">
                    </td>
                    <td align="right" style="width: 447px; height: 23px">
                        <asp:Label ID="lblDoc" runat="server" CssClass="lblBoldUpperXXS" Text="Tipo de Documento: "></asp:Label></td>
                    <td style="width: 74px; height: 23px; text-align: center">
                        <asp:TextBox ID="txtCP" runat="server" CssClass="TextBox" Enabled="False" Width="136px"></asp:TextBox></td>
                    <td style="width: 224px; height: 23px; text-align: center">
                    </td>
                    <td style="width: 179px; height: 23px; text-align: center">
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 336px">
                    </td>
                    <td align="right" style="width: 447px">
                        <asp:Label ID="lblDesc" runat="server" CssClass="lblBoldUpperXXS" Text="Descripcion: "></asp:Label></td>
                    <td style="width: 74px; text-align: center">
                        <asp:TextBox ID="txtLoc" runat="server" CssClass="TextBox" Enabled="False" Width="136px"></asp:TextBox></td>
                    <td style="width: 224px; text-align: center">
                    </td>
                    <td style="width: 179px; text-align: center">
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 336px; height: 30px">
                    </td>
                    <td align="right" style="width: 447px; height: 30px">
                    </td>
                    <td align="left" style="width: 74px; height: 30px; text-align: center">
                        <asp:ImageButton ID="ImagenOK" runat="server" Enabled="False" Height="24px" ImageUrl="~/Imagenes/smallOK.gif"
                            Width="24px" />
                        <asp:ImageButton ID="imgCancel" runat="server" Enabled="False" Height="24px" ImageUrl="~/Imagenes/smallFail.gif"
                            Width="24px" /></td>
                    <td style="width: 224px; height: 30px">
                    </td>
                    <td align="right" style="width: 179px; height: 30px">
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 336px; height: 30px">
                    </td>
                    <td align="right" style="width: 447px; height: 30px">
                    </td>
                    <td align="left" style="width: 74px; height: 30px; text-align: center">
                    </td>
                    <td style="width: 224px; height: 30px">
                    </td>
                    <td align="right" style="width: 179px; height: 30px">
                    </td>
                </tr>
            </table>
        </div>
    
    </div>
    </form>
</body>
</html>
