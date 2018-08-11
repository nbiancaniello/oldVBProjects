<%@ page language="C#" autoeventwireup="true" inherits="Presentacion_TipoMovimiento, App_Web_r2qjsibb" enableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Página sin título</title>
    <link href="../styles.css" rel="stylesheet" type="text/css" />
    
    <script type="text/javascript">
    
        function mostrarCampos(accion)
        {        
            
            document.getElementById('hAccion').value = accion;
                
            document.getElementById('txtidtipomovimiento').disabled = false;            
            document.getElementById('txtdescripcion').disabled = false;
            document.getElementById('btnaceptar').disabled = false;
            document.getElementById('cboestado').disabled = false;
            document.getElementById('btncancelar').disabled = false;
            
            
            return false;
        }
        
        function ocultarCampos()
        {
            document.getElementById('txtidtipomovimiento').disabled = true;
            document.getElementById('txtdescripcion').disabled = true;
            document.getElementById('txtidtipomovimiento').value = "";
            document.getElementById('txtdescripcion').value = "";  
            document.getElementById('cboestado').disabled = true;          
            document.getElementById('btnaceptar').disabled = true;
            document.getElementById('btncancelar').disabled = true;
            
            return false;
        }        
    </script> 
</head>
<body style="text-align: left">
    <form id="form1" runat="server">
    <div>
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
                        <td align="center" colspan="4" style="height: 20px" valign="top">
                            <asp:Label ID="lbltipomovimiento" runat="server" CssClass="lblBoldUpperXXS" Font-Bold="True"
                                Text="Tipos De Movimientos"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td align="center" colspan="1" style="width: 336px; height: 16px" valign="top">
                        </td>
                        <td align="center" colspan="4" style="height: 16px" valign="top">
                            <table style="width: 248px; height: 56px">
                                <tr>
                                    <td style="width: 264px; height: 165px">
                                        &nbsp;<asp:GridView ID="GvTipoMovimientos" runat="server" CssClass="DataGrid"
                                            ForeColor="Black" Height="168px" Width="280px" OnPageIndexChanged="GvTipoMovimientos_PageIndexChanged" OnRowDataBound="GvTipoMovimientos_RowDataBound" OnSelectedIndexChanged="GvTipoMovimientos_SelectedIndexChanged">
                                            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                            <RowStyle BackColor="#EFF3FB" />
                                            <Columns>
                                                <asp:CommandField ButtonType="Image" EditImageUrl="~/Imagenes/next.gif" SelectImageUrl="~/Imagenes/show2.gif"
                                                    ShowEditButton="True" />
                                            </Columns>
                                            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                            <EditRowStyle BackColor="#2461BF" />
                                            <AlternatingRowStyle BackColor="White" />
                                        </asp:GridView>
                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 336px; height: 23px">
                        </td>
                        <td align="right" style="width: 447px; height: 23px">
                            <asp:Button ID="btnagregar" runat="server" CssClass="ButtonBlue11px" Text="Agregar" OnClick="btnagregar_Click" /></td>
                        <td align="right" style="width: 74px; height: 23px; text-align: center">
                            <asp:Button ID="btnmodificar" runat="server" CssClass="ButtonBlue11px" Text="Modificar" OnClick="btnmodificar_Click" /></td>
                        <td style="width: 224px; height: 23px">
                            <asp:Button ID="btneliminar" runat="server" CssClass="ButtonBlue11px" Text="Eliminar" OnClick="btneliminar_Click" /></td>
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
                            <asp:Button ID="btntodos" runat="server" CssClass="ButtonBlue11px" Text="Todos" OnClick="btntodos_Click" /></td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 336px; height: 23px">
                        </td>
                        <td align="right" style="width: 447px; height: 23px">
                            <asp:Label ID="lblmovimiento" runat="server" CssClass="lblBoldUpperXXS" Text="Tipo de Movimiento: "></asp:Label></td>
                        <td style="width: 74px; height: 23px; text-align: center">
                            <asp:TextBox ID="txttipomovimiento" runat="server" CssClass="TextBox" Enabled="False"
                                Width="136px"></asp:TextBox></td>
                        <td style="width: 224px; height: 23px; text-align: center">
                        </td>
                        <td style="width: 179px; height: 23px; text-align: center">
                            <asp:Button ID="btnactivos" runat="server" CssClass="ButtonBlue11px" Text="Solo Activos" OnClick="btnactivos_Click" /></td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 336px">
                        </td>
                        <td align="right" style="width: 447px">
                            <asp:Label ID="lblDesc" runat="server" CssClass="lblBoldUpperXXS" Text="Descripcion: "></asp:Label></td>
                        <td style="width: 74px; text-align: center">
                            <asp:TextBox ID="txtdescripcion" runat="server" CssClass="TextBox" Enabled="False" Width="136px"></asp:TextBox></td>
                        <td style="width: 224px; text-align: center">
                        </td>
                        <td style="width: 179px; text-align: center">
                            <asp:Button ID="btninactivos" runat="server" CssClass="ButtonBlue11px" Text="Solo Inactivos" OnClick="btninactivos_Click" /></td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 336px; height: 30px">
                        </td>
                        <td align="right" style="width: 447px; height: 30px">
                            <asp:Label ID="Label1" runat="server" CssClass="lblBoldUpperXXS" Text="Estado:"></asp:Label></td>
                        <td align="left" style="width: 74px; height: 30px; text-align: center">
                            &nbsp;<asp:DropDownList ID="cboestado" runat="server">
                            </asp:DropDownList></td>
                        <td style="width: 224px; height: 30px">
                        </td>
                        <td align="right" style="width: 179px; height: 30px">
                        </td>
                    </tr>
                    <tr>
                        <td align="right" style="width: 336px; height: 30px">
                        </td>
                        <td align="right" style="width: 447px; height: 30px">
                            <asp:Button ID="btnaceptar" runat="server" CssClass="ButtonBlue11px" Text="Aceptar" OnClick="btnaceptar_Click" /></td>
                        <td align="left" style="width: 74px; height: 30px; text-align: center">
                            <asp:Button ID="btncancelar" runat="server" CssClass="ButtonBlue11px" Text="Cancelar" OnClick="btncancelar_Click" /></td>
                        <td style="width: 224px; height: 30px">
                        </td>
                        <td align="center" style="width: 179px; height: 30px">
                        
                            <asp:Button ID="btnregresar" runat="server" CssClass="ButtonBlue11px" Text="Regresar" OnClick="btnregresar_Click" /></td>
                    </tr>
                </table>
            </div>
        </div>
    
    </div>
        <asp:HiddenField ID="hAccion" runat="server" />
    </form>
</body>
</html>
