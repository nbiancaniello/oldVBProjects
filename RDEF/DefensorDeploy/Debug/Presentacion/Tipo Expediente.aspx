<%@ page language="C#" autoeventwireup="true" inherits="Presentacion_Tipo_Expediente, DefensorDeploy" enableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Mantenimiento - Tipo de Expediente</title>
    <link href="../styles.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
    
        function mostrarCampos(accion)
        {        
            
            document.getElementById('hAccion').value = accion;
                
            document.getElementById('txttipoexpediente').disabled = false;            
            document.getElementById('txtDesc').disabled = false;
            document.getElementById('btnaceptar').disabled = false;
            document.getElementById('cboestado').disabled = false;
            document.getElementById('btncancelar').disabled = false;
            
            
            return false;
        }
        
        function ocultarCampos()
        {
            document.getElementById('txttipoexpediente').disabled = true;
            document.getElementById('txtdescripcion').disabled = true;
            document.getElementById('txttipoexpediente').value = "";
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
                <div>
                    <table id="tblPartidos" style="width: 648px; height: 48px">
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
                    <table id="tblLocalidades" style="width: 648px; height: 360px">
                        <tr>
                            <td align="left" colspan="1" style="width: 126px; height: 20px" valign="top">
                            </td>
                            <td align="center" colspan="4" style="height: 20px" valign="top">
                                <asp:Label ID="lbltipoexpediente" runat="server" CssClass="lblBoldUpperXXS" Font-Bold="True"
                                    Text="Tipos De Expedientes"></asp:Label>
                            </td>
                        </tr>
                        <tr>
                            <td align="center" colspan="1" style="width: 126px; height: 16px" valign="top">
                            </td>
                            <td align="center" colspan="4" style="height: 16px" valign="top">
                                <table style="width: 248px; height: 56px">
                                    <tr>
                                        <td style="width: 264px; height: 165px">
                                            &nbsp;<asp:GridView ID="GvTipoExpedientes" runat="server" CssClass="DataGrid"
                                                ForeColor="Black" Height="168px" Width="280px" OnPageIndexChanged="GvTipoExpedientes_PageIndexChanged" OnRowDataBound="GvTipoExpedientes_RowDataBound" OnSelectedIndexChanged="GvTipoExpedientes_SelectedIndexChanged" OnPageIndexChanging="GvTipoExpedientes_PageIndexChanging" >
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
                            <td align="right" style="width: 126px; height: 21px">
                            </td>
                            <td align="right" style="width: 198px; height: 21px">
                            </td>
                            <td style="width: 187px; height: 21px; text-align: center">
                            </td>
                            <td style="width: 224px; height: 21px; text-align: center">
                            </td>
                            <td style="width: 179px; height: 21px; text-align: center">
                                </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 126px; height: 23px">
                            </td>
                            <td align="right" style="width: 198px; height: 23px">
                                </td>
                            <td style="width: 187px; height: 23px; text-align: center">
                                <asp:Label ID="lblexpediente" runat="server" CssClass="lblBoldUpperXXS" Text="Tipo de Expediente: "></asp:Label></td>
                            <td style="width: 224px; height: 23px; text-align: center">
                                <asp:TextBox ID="txttipoexpediente" runat="server" CssClass="TextBox" Enabled="False"
                                    Width="136px" MaxLength="4" ReadOnly="True"></asp:TextBox></td>
                            <td style="width: 179px; height: 23px; text-align: center">
                                <asp:Button ID="btnAceptar" runat="server" CssClass="ButtonBlue11px" Text="Aceptar" OnClick="btnaceptar_Click" Width="88px" /></td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 126px">
                            </td>
                            <td align="right" style="width: 198px">
                                </td>
                            <td style="width: 187px; text-align: center">
                                <asp:Label ID="lblDesc" runat="server" CssClass="lblBoldUpperXXS" Text="Descripcion: "></asp:Label></td>
                            <td style="width: 224px; text-align: center">
                                <asp:TextBox ID="txtdescripcion" runat="server" CssClass="TextBoxLetras" Enabled="False" Width="136px" MaxLength="30"></asp:TextBox></td>
                            <td style="width: 179px; text-align: center">
                                <asp:Button ID="btnCancelar" runat="server" CssClass="ButtonBlue11px" Text="Cancelar" OnClick="btncancelar_Click" Width="88px" /></td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 126px; height: 30px">
                            </td>
                            <td align="right" style="width: 198px; height: 30px">
                                </td>
                            <td align="left" style="width: 187px; height: 30px; text-align: center">
                                <asp:Label ID="Label1" runat="server" CssClass="lblBoldUpperXXS" Text="Estado: "></asp:Label>&nbsp;</td>
                            <td style="width: 224px; height: 30px">
                            <asp:DropDownList ID="cboestado" runat="server">
                                </asp:DropDownList></td>
                            <td align="right" style="width: 179px; height: 30px">
                            </td>
                        </tr>
                        <tr>
                            <td align="right" style="width: 126px; height: 30px">
                            </td>
                            <td align="right" style="width: 198px; height: 30px">
                                </td>
                            <td align="left" style="width: 187px; height: 30px; text-align: center">
                                </td>
                            <td style="width: 224px; height: 30px">
                            </td>
                            <td align="center" style="width: 179px; height: 30px">
                                </td>
                        </tr>
                    </table>
                    <table style="width: 608px">
                        <tr>
                            <td>
                                <asp:Button ID="btnAgregar" runat="server" CssClass="ButtonBlue11px" Text="Agregar" OnClick="btnagregar_Click" Width="88px" /></td>
                            <td>
                                <asp:Button ID="btnModificar" runat="server" CssClass="ButtonBlue11px" Text="Modificar" OnClick="btnmodificar_Click" Width="88px" /></td>
                            <td style="width: 137px">
                                <asp:Button ID="btnEliminar" runat="server" CssClass="ButtonBlue11px" Text="Eliminar" OnClick="btneliminar_Click" Width="88px" /></td>
                            <td style="width: 63px">
                                <asp:Button ID="btnTodos" runat="server" CssClass="ButtonBlue11px" Text="Ver Todos" OnClick="btntodos_Click" Width="88px" /></td>
                            <td style="width: 46px">
                                <asp:Button ID="btnActivos" runat="server" CssClass="ButtonBlue11px" Text="Ver Activos" OnClick="btnactivos_Click" Width="88px" /></td>
                            <td style="width: 57px">
                                <asp:Button ID="btnInactivos" runat="server" CssClass="ButtonBlue11px" Text="Ver Inactivos" OnClick="btninactivos_Click" Width="88px" /></td>
                            <td style="width: 75px">
                                <asp:Button ID="btnVolver" runat="server" CssClass="ButtonBlue11px" Text="Salir" OnClick="btnregresar_Click" Width="88px" /></td>
                        </tr>
                    </table>
                    <br />
                </div>
            </div>
        </div>
    
    </div>
        <asp:HiddenField ID="hAccion" runat="server" />
    </form>
</body>
</html>
