<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Areas.aspx.cs" Inherits="Presentacion_Areas" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Mantenimiento - Areas</title>
    <link href="../Styles.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
    
        function mostrarCampos(accion)
        {        
            
            document.getElementById('hAccion').value = accion;
                
            document.getElementById('txtCod').disabled = false;            
            document.getElementById('txtDesc').disabled = false;
            document.getElementById('imagenOK').disabled = false;
            document.getElementById('cboEstado').disabled = false;
            document.getElementById('imagenCancel').disabled = false;
            
            
            return false;
        }
        
        function ocultarCampos()
        {
            document.getElementById('txtCod').disabled = true;
            document.getElementById('txtDesc').disabled = true;
            document.getElementById('txtCod').value = "";
            document.getElementById('txtDesc').value = "";  
            document.getElementById('cboEstado').disabled = true;          
            document.getElementById('imagenOK').disabled = true;
            document.getElementById('imagenCancel').disabled = true;
            
            return false;
        }        
    </script> 
</head>
<body style="text-align: left">
    <form id="form1" runat="server">
<!--    <div>-->
        <table id="tblPartidos" style="width: 616px; height: 48px">
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
        <table id="tblLocalidades" style="width: 616px; height: 360px">
            <tr>
                <td align="left" colspan="1" style="width: 21px; height: 20px" valign="top">
                </td>
                <td align="center" colspan="4" style="height: 20px" valign="top">
                    <asp:Label ID="lbl" runat="server" CssClass="lblBoldUpperXXS" Font-Bold="True" Text="Areas"></asp:Label></td>
            </tr>
            <tr>
                <td align="center" colspan="1" style="width: 21px; height: 16px" valign="top">
                </td>
                <td align="center" colspan="4" style="height: 16px" valign="top">
                    <table style="width: 248px; height: 56px">
                        <tr>
                            <td style="width: 264px; height: 165px">
                                <asp:GridView ID="GvAreas" runat="server" CssClass="DataGrid"
                                    ForeColor="Black" Height="168px" Width="280px" OnRowDataBound="GvAreas_RowDataBound" OnSelectedIndexChanged="GvAreas_SelectedIndexChanged" OnPageIndexChanged="GvAreas_PageIndexChanged" OnPageIndexChanging="GvAreas_PageIndexChanging" AllowPaging="True">
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
                                &nbsp;</td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td align="right" style="width: 21px; height: 23px">
                </td>
                <td align="right" style="width: 72px; height: 23px">
                    </td>
                <td align="center" style="width: 88px; height: 23px; text-align: center">
                    </td>
                <td style="width: 224px; height: 23px">
                    </td>
                <td style="width: 179px; height: 23px; text-align: center">
                </td>
            </tr>
            <tr>
                <td align="right" style="width: 21px; height: 21px">
                </td>
                <td align="right" style="width: 72px; height: 21px">
                </td>
                <td style="width: 88px; height: 21px; text-align: center">
                    <asp:Label ID="lblID" runat="server" CssClass="lblBoldUpperXXS" Text="Código: "></asp:Label></td>
                <td style="width: 224px; height: 21px; text-align: center">
                    <asp:TextBox ID="txtCod" runat="server" CssClass="TextBox" Enabled="False" Width="136px" ForeColor="Silver" MaxLength="4"></asp:TextBox></td>
                <td style="width: 179px; height: 21px; text-align: center">
                    <asp:Button ID="btnAceptar" runat="server" CssClass="ButtonBlue11px" OnClick="BtnAceptar_Click"
                        Text="Aceptar" /></td>
            </tr>
            <tr>
                <td align="right" style="width: 21px; height: 23px">
                </td>
                <td align="right" style="width: 72px; height: 23px">
                    </td>
                <td style="width: 88px; height: 23px; text-align: center">
                    <asp:Label ID="lblDesc" runat="server" CssClass="lblBoldUpperXXS" Text="Descripcion: "></asp:Label></td>
                <td style="width: 224px; height: 23px; text-align: center">
                    <asp:TextBox ID="txtDesc" runat="server" CssClass="TextBoxLetras" Enabled="False" Width="136px" MaxLength="30"></asp:TextBox></td>
                <td style="width: 179px; height: 23px; text-align: center">
                    <asp:Button ID="btnCancelar" runat="server" CssClass="ButtonBlue11px" Text="Cancelar" OnClick="BtnCancelar_Click" /></td>
            </tr>
            <tr>
                <td align="right" style="width: 21px">
                </td>
                <td align="right" style="width: 72px">
                    </td>
                <td style="width: 88px; text-align: center">
                    <asp:Label ID="lblEstado" runat="server" CssClass="lblBoldUpperXXS" Text="Estado: "></asp:Label></td>
                <td style="width: 224px; text-align: center">
                    <asp:DropDownList ID="cboEstado" runat="server">
                    </asp:DropDownList></td>
                <td style="width: 179px; text-align: center">
                    </td>
            </tr>
        </table>
        <table style="width: 608px">
            <tr>
                <td style="width: 3px">
                    <asp:Button ID="btnAgregar" runat="server" CssClass="ButtonBlue11px" Text="Agregar" OnClick="btnAgregar_Click" /></td>
                <td style="width: 3px">
                    <asp:Button ID="btnModificar" runat="server" CssClass="ButtonBlue11px" Text="Modificar" OnClick="BtnModificar_Click" /></td>
                <td style="width: 3px">
                    <asp:Button ID="btnEliminar" runat="server" CssClass="ButtonBlue11px" Text="Eliminar" OnClick="btnEliminar_Click" /></td>
                <td style="width: 3px">
                    <asp:Button ID="btnTodos" runat="server" CssClass="ButtonBlue11px" OnClick="btnTodos_Click"
                        Text="Ver Todo" Width="88px" /></td>
                <td style="width: 3px">
                    <asp:Button ID="btnActivos" runat="server" CssClass="ButtonBlue11px" OnClick="btnActivos_Click"
                        Text="Ver Activos" Width="88px" /></td>
                <td style="width: 3px">
                    <asp:Button ID="btnInactivos" runat="server" CssClass="ButtonBlue11px" OnClick="btnInactivos_Click"
                        Text="Ver Inactivos" Width="88px" /></td>
                <td style="width: 3px">
                    <asp:Button ID="btnVolver" runat="server" CssClass="ButtonBlue11px" OnClick="btnVolver_Click"
                        Text="Salir" /></td>
            </tr>
        </table>
    
        <input type="hidden" runat="server" id="hAccion" style="height: 24px" />
    </form>
  
    
  

</body>
</html>
