<%@ page language="C#" autoeventwireup="true" inherits="Presentacion_Areas, App_Web_r2qjsibb" enableEventValidation="false" %>

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
                <td align="left" colspan="1" style="width: 368px; height: 20px" valign="top">
                </td>
                <td align="center" colspan="4" style="height: 20px" valign="top">
                    <asp:Label ID="lbl" runat="server" CssClass="lblBoldUpperXXS" Font-Bold="True" Text="Areas"></asp:Label></td>
            </tr>
            <tr>
                <td align="center" colspan="1" style="width: 368px; height: 16px" valign="top">
                </td>
                <td align="center" colspan="4" style="height: 16px" valign="top">
                    <table style="width: 248px; height: 56px">
                        <tr>
                            <td style="width: 264px; height: 165px">
                                <asp:GridView ID="GvAreas" runat="server" CssClass="DataGrid"
                                    ForeColor="DimGray" Height="168px" Width="280px" OnRowDataBound="GvAreas_RowDataBound" OnSelectedIndexChanged="GvAreas_SelectedIndexChanged" OnPageIndexChanged="GvAreas_PageIndexChanged" BackColor="White">
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
                <td align="right" style="width: 368px; height: 23px">
                </td>
                <td align="right" style="width: 447px; height: 23px">
                    <asp:Button ID="btnAgregar" runat="server" CssClass="ButtonBlue11px" Text="Agregar" OnClick="btnAgregar_Click" /></td>
                <td align="center" style="width: 86px; height: 23px; text-align: center">
                    <asp:Button ID="BtnModificar" runat="server" CssClass="ButtonBlue11px" Text="Modificar" OnClick="BtnModificar_Click" /></td>
                <td style="width: 224px; height: 23px">
                    <asp:Button ID="btnEliminar" runat="server" CssClass="ButtonBlue11px" Text="Eliminar" OnClick="btnEliminar_Click" /></td>
                <td style="width: 179px; height: 23px; text-align: center">
                </td>
            </tr>
            <tr>
                <td align="right" style="width: 368px; height: 21px">
                </td>
                <td align="right" style="width: 447px; height: 21px">
                </td>
                <td style="width: 86px; height: 21px; text-align: center">
                </td>
                <td style="width: 224px; height: 21px; text-align: center">
                </td>
                <td style="width: 179px; height: 21px; text-align: center">
                    <asp:Button ID="btnTodos" runat="server" CssClass="ButtonBlue11px" OnClick="btnTodos_Click"
                        Text="Todos" Width="88px" /></td>
            </tr>
            <tr>
                <td align="right" style="width: 368px; height: 23px">
                </td>
                <td align="right" style="width: 447px; height: 23px">
                    <asp:Label ID="lblID" runat="server" CssClass="lblBoldUpperXXS" Text="Código: "></asp:Label></td>
                <td style="width: 86px; height: 23px; text-align: center">
                    <asp:TextBox ID="txtCod" runat="server" CssClass="TextBox" Enabled="False" Width="136px" ForeColor="Silver" MaxLength="4"></asp:TextBox></td>
                <td style="width: 224px; height: 23px; text-align: center">
                </td>
                <td style="width: 179px; height: 23px; text-align: center">
                    <asp:Button ID="btnActivos" runat="server" CssClass="ButtonBlue11px" OnClick="btnActivos_Click"
                        Text="Solo Activos" Width="88px" /></td>
            </tr>
            <tr>
                <td align="right" style="width: 368px">
                </td>
                <td align="right" style="width: 447px">
                    <asp:Label ID="lblDesc" runat="server" CssClass="lblBoldUpperXXS" Text="Descripcion: "></asp:Label></td>
                <td style="width: 86px; text-align: center">
                    <asp:TextBox ID="txtDesc" runat="server" CssClass="TextBoxLetras" Enabled="False" Width="136px" MaxLength="30"></asp:TextBox></td>
                <td style="width: 224px; text-align: center">
                </td>
                <td style="width: 179px; text-align: center">
                    <asp:Button ID="btnInactivos" runat="server" CssClass="ButtonBlue11px" OnClick="btnInactivos_Click"
                        Text="Solo Inactivos" Width="88px" /></td>
            </tr>
            <tr>
                <td align="right" style="width: 368px; height: 30px">
                </td>
                <td align="right" style="width: 447px; height: 30px">
                    <asp:Label ID="lblEstado" runat="server" CssClass="lblBoldUpperXXS" Text="Estado: "></asp:Label></td>
                <td align="left" style="width: 86px; height: 30px; text-align: center">
                    <asp:DropDownList ID="cboEstado" runat="server">
                    </asp:DropDownList></td>
                <td style="width: 224px; height: 30px">
                </td>
                <td align="right" style="width: 179px; height: 30px">
                </td>
            </tr>
            <tr>
                <td align="right" style="width: 368px; height: 63px">
                </td>
                <td align="right" style="width: 447px; height: 63px">
                    <asp:Button ID="BtnAceptar" runat="server" CssClass="ButtonBlue11px" OnClick="BtnAceptar_Click"
                        Text="Aceptar" /></td>
                <td align="left" style="width: 86px; height: 63px; text-align: center">
                    <asp:Button ID="BtnCancelar" runat="server" CssClass="ButtonBlue11px" Text="Cancelar" OnClick="BtnCancelar_Click" /></td>
                <td style="width: 224px; height: 63px">
                </td>
                <td align="center" style="width: 179px; height: 63px">
                    <asp:Button ID="btnVolver" runat="server" CssClass="ButtonBlue11px" OnClick="btnVolver_Click"
                        Text="Regresar" /></td>
            </tr>
        </table>
    
        <input type="hidden" runat="server" id="hAccion" style="height: 24px" />
    </form>
  
    
  

</body>
</html>
