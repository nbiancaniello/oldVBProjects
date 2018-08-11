<%@ page language="C#" autoeventwireup="true" inherits="Presentacion_Dependencias, App_Web_r2qjsibb" enableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Mantenimiento - Dependencias</title>
        <link href="../styles.css" rel="stylesheet" type="text/css" />
        <script type="text/javascript">
    
        function mostrarCampos(accion)
        {        
            
            document.getElementById('hAccion').value = accion;
                
            document.getElementById('txtidDependencia').disabled = false;            
            document.getElementById('txtdescripcion').disabled = false;
            //document.getElementById('BtnAceptar').disabled = false;
            document.getElementById('cboEstado').disabled = false;
            //document.getElementById('BtnCancelar').disabled = false;
            
            
            return false;
        }
        
        function ocultarCampos()
        {
            document.getElementById('txtidDependencia').disabled = true;
            document.getElementById('txtdescripcion').disabled = true;
            document.getElementById('txtidDependencia').value = "";
            document.getElementById('txtdescripcion').value = "";  
            document.getElementById('cboEstado').disabled = true;          
          //  document.getElementById('BtnAceptar').disabled = true;
          //  document.getElementById('BtnCancelar').disabled = true;
            
            return false;
        }        
    </script> 
</head>
<body style="text-align: left">
    <form id="form1" runat="server">
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
                    &nbsp;<asp:Label ID="lbl" runat="server" CssClass="lblBoldUpperXXS" Font-Bold="True"
                        Text="Dependencias"></asp:Label></td>
            </tr>
            <tr>
                <td align="center" colspan="1" style="width: 336px; height: 16px" valign="top">
                </td>
                <td align="center" colspan="4" style="height: 16px" valign="top">
                    <table style="width: 248px; height: 56px">
                        <tr>
                            <td style="width: 264px; height: 165px">
                                <asp:GridView ID="GvDependencias" runat="server" CssClass="DataGrid"
                                    ForeColor="Black" Height="168px" Width="280px" OnPageIndexChanged="GvDependencias_PageIndexChanged" OnRowDataBound="GvDependencias_RowDataBound" OnSelectedIndexChanged="GvDependencias_SelectedIndexChanged">
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
                                &nbsp;
                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
            <tr>
                <td align="right" style="width: 336px; height: 23px">
                </td>
                <td align="right" style="width: 447px; height: 23px">
                    <asp:Button ID="btnagregar" runat="server" OnClick="btnagregar_Click" Text="Agregar" CssClass="ButtonBlue11px" /></td>
                <td align="center" style="width: 74px; height: 23px; text-align: center">
                    <asp:Button ID="btnModificar" runat="server" CssClass="ButtonBlue11px" Text="Modificar" OnClick="btnModificar_Click" /></td>
                <td style="width: 224px; height: 23px">
                    <asp:Button ID="btnEliminar" runat="server" CssClass="ButtonBlue11px" Text="Eliminar" OnClick="btnEliminar_Click" /></td>
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
                    <asp:Button ID="btnTodos" runat="server" CssClass="ButtonBlue11px" OnClick="btnTodos_Click"
                        Text="Todos" Width="88px" /></td>
            </tr>
            <tr>
                <td align="right" style="width: 336px; height: 23px">
                </td>
                <td align="right" style="width: 447px; height: 23px">
                    <asp:Label ID="lblidDependencia" runat="server" CssClass="lblBoldUpperXXS" Text="Id Dependencia: "></asp:Label></td>
                <td style="width: 74px; height: 23px; text-align: center">
                    <asp:TextBox ID="txtidDependencia" runat="server" CssClass="TextBox" Enabled="False"
                        Width="136px" MaxLength="4"></asp:TextBox></td>
                <td style="width: 224px; height: 23px; text-align: center">
                </td>
                <td style="width: 179px; height: 23px; text-align: center">
                    <asp:Button ID="btnActivos" runat="server" CssClass="ButtonBlue11px" OnClick="btnActivos_Click"
                        Text="Solo Activos" Width="88px" /></td>
            </tr>
            <tr>
                <td align="right" style="width: 336px; height: 23px;">
                </td>
                <td align="right" style="width: 447px; height: 23px;">
                    <asp:Label ID="lblDescripcion" runat="server" CssClass="lblBoldUpperXXS" Text="Descripcion: "></asp:Label></td>
                <td style="width: 74px; text-align: center; height: 23px;">
                    <asp:TextBox ID="txtdescripcion" runat="server" CssClass="TextBoxLetras"
                        Width="136px" MaxLength="30" BackColor="White"></asp:TextBox></td>
                <td style="width: 224px; text-align: center; height: 23px;">
                </td>
                <td style="width: 179px; text-align: center; height: 23px;">
                    <asp:Button ID="btnInactivos" runat="server" CssClass="ButtonBlue11px" OnClick="btnInactivos_Click"
                        Text="Solo Inactivos" Width="88px" /></td>
            </tr>
            <tr>
                <td align="right" style="width: 336px; height: 30px">
                </td>
                <td align="right" style="width: 447px; height: 30px">
                    <asp:Label ID="lblEstado" runat="server" CssClass="lblBoldUpperXXS" Text="Estado: "></asp:Label></td>
                <td align="left" style="width: 74px; height: 30px; text-align: center">
                    &nbsp;<asp:DropDownList ID="cboEstado" runat="server">
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
                    <asp:Button ID="BtnAceptar" runat="server" CssClass="ButtonBlue11px" OnClick="BtnAceptar_Click"
                        Text="Aceptar" /></td>
                <td align="left" style="width: 74px; height: 30px; text-align: center">
                    <asp:Button ID="BtnCancelar" runat="server" CssClass="ButtonBlue11px" OnClick="BtnCancelar_Click"
                        Text="Cancelar" /></td>
                <td style="width: 224px; height: 30px">
                </td>
                <td align="center" style="width: 179px; height: 30px">
                    <asp:Button ID="btnregresar" runat="server" CssClass="ButtonBlue11px" OnClick="btnvolver_Click"
                        Text="Regresar" /></td>
            </tr>
        </table>
   
      
        <input type="hidden" runat="server" id="hAccion" style="height: 24px"/>
    </div>
    </form>
</body>
</html>
