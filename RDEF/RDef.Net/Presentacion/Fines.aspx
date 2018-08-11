<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Fines.aspx.cs" Inherits="Presentacion_Fines" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Mantenimiento - Fines</title>
    
    <link href="../styles.css" rel="stylesheet" type="text/css" />
        <script type="text/javascript">
    
        function mostrarCampos(accion)
        {        
            
            document.getElementById('hAccion').value = accion;
                
            document.getElementById('txtidfin').disabled = false;            
            document.getElementById('txtdescripcion').disabled = false;
            document.getElementById('btnaceptar').disabled = false;
            document.getElementById('cboEstado').disabled = false;
            document.getElementById('btncancelar').disabled = false;
            
            
            return false;
        }
        
        function ocultarCampos()
        {
            document.getElementById('txtidfin').disabled = true;
            document.getElementById('txtdescripcion').disabled = true;
            document.getElementById('txtidfin').value = "";
            document.getElementById('txtdescripcion').value = "";  
            document.getElementById('cboEstado').disabled = true;          
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
                    <td align="left" colspan="1" style="width: 51px; height: 20px" valign="top">
                    </td>
                    <td align="center" colspan="4" style="height: 20px" valign="top">
                        &nbsp;<asp:Label ID="lbl" runat="server" CssClass="lblBoldUpperXXS" Font-Bold="True"
                            Text="Fines"></asp:Label></td>
                </tr>
                <tr>
                    <td align="center" colspan="1" style="width: 51px; height: 16px" valign="top">
                    </td>
                    <td align="center" colspan="4" style="height: 16px" valign="top">
                        <table style="width: 248px; height: 56px">
                            <tr>
                                <td style="width: 264px; height: 165px">
                                    &nbsp;&nbsp;
                                    <asp:GridView ID="GvFines" runat="server" ForeColor="Black" OnPageIndexChanged="GvFines_SelectedIndexChanged" OnRowDataBound="GvFines_RowDataBound" OnSelectedIndexChanged="GvFines_SelectedIndexChanged" CssClass="DataGrid" Height="168px" Width="280px" OnPageIndexChanging="GvFines_SelectedIndexChanging" AllowPaging="True">
                                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                        <RowStyle BackColor="#EFF3FB" />
                                        <Columns>
                                            <asp:CommandField ButtonType="Image" EditImageUrl="~/Imagenes/next.gif" NewImageUrl="~/Imagenes/show2.gif"
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
                    <td align="right" style="width: 51px; height: 15px">
                    </td>
                    <td align="right" style="width: 89px; height: 15px">
                        &nbsp;</td>
                    <td align="left" style="width: 66px; height: 15px; text-align: center">
                        </td>
                    <td style="width: 224px; height: 15px">
                        &nbsp;</td>
                    <td style="width: 179px; height: 15px; text-align: center">
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 51px; height: 23px">
                    </td>
                    <td align="right" style="width: 89px; height: 23px">
                        </td>
                    <td style="width: 66px; height: 23px; text-align: center">
                        <asp:Label ID="lblidFin" runat="server" CssClass="lblBoldUpperXXS" Text="Id Fin"></asp:Label></td>
                    <td style="width: 224px; height: 23px; text-align: center">
                        <asp:TextBox ID="txtidfin" runat="server" MaxLength="4" Width="120px"></asp:TextBox></td>
                    <td style="width: 179px; height: 23px; text-align: center">
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnaceptar_Click" CssClass="ButtonBlue11px" Width="88px" /></td>
                </tr>
                <tr>
                    <td align="right" style="width: 51px; height: 23px;">
                    </td>
                    <td align="right" style="width: 89px; height: 23px;">
                        </td>
                    <td style="width: 66px; text-align: center; height: 23px;">
                        <asp:Label ID="lblDescripcion" runat="server" CssClass="lblBoldUpperXXS" Text="Descripcion: "></asp:Label></td>
                    <td style="width: 224px; text-align: center; height: 23px;">
                        <asp:TextBox ID="txtdescripcion" runat="server" CssClass="TextBoxLetras" MaxLength="30" Width="120px"></asp:TextBox></td>
                    <td style="width: 179px; text-align: center; height: 23px;">
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btncancelar_Click" CssClass="ButtonBlue11px" Width="88px" /></td>
                </tr>
                <tr>
                    <td align="right" style="width: 51px; height: 13px">
                    </td>
                    <td align="right" style="width: 89px; height: 13px">
                        </td>
                    <td align="left" style="width: 66px; height: 13px; text-align: center">
                        <asp:Label ID="lblEstado" runat="server" CssClass="lblBoldUpperXXS" Text="Estado: "></asp:Label>&nbsp;</td>
                    <td style="width: 224px; height: 13px">
                    <asp:DropDownList ID="cboestado" runat="server">
                        </asp:DropDownList></td>
                    <td align="right" style="width: 179px; height: 13px">
                    </td>
                </tr>
            </table>
            <table style="width: 608px">
                <tr>
                    <td style="width: 3px">
                        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnagregar_Click" CssClass="ButtonBlue11px" Width="88px" /></td>
                    <td style="width: 3px">
                        <asp:Button ID="btnModificar" runat="server" Text="Modificar" OnClick="btnmodificar_Click" CssClass="ButtonBlue11px" Width="88px" /></td>
                    <td style="width: 3px">
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btneliminar_Click" CssClass="ButtonBlue11px" Width="88px" /></td>
                    <td style="width: 3px">
                        <asp:Button ID="btnTodos" runat="server" Text="Todos" OnClick="btntodos_Click" CssClass="ButtonBlue11px" Width="88px" /></td>
                    <td style="width: 3px">
                        <asp:Button ID="btnActivos" runat="server" Text="Solo Activos" OnClick="btnactivos_Click" CssClass="ButtonBlue11px" Width="88px" /></td>
                    <td style="width: 3px">
                        <asp:Button ID="btnInactivos" runat="server" Text="Solo Inactivos" OnClick="btninactivos_Click" CssClass="ButtonBlue11px" Width="88px" /></td>
                    <td style="width: 3px">
                        <asp:Button ID="btnVolver" runat="server" OnClick="btnregresar_Click" Text="Salir" CssClass="ButtonBlue11px" Width="88px" /></td>
                </tr>
            </table>
        </div>
    
    </div>
        <asp:HiddenField ID="hAccion" runat="server" />
    </form>
</body>
</html>
