﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Denunciados.aspx.cs" Inherits="Presentacion_Denunciados" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Mantenimiento - Denunciados</title>
    <link href="../styles.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
    
        function mostrarCampos(accion)
        {        
            
            document.getElementById('hAccion').value = accion;
                
            document.getElementById('txtidDenunciado').disabled = false;            
            document.getElementById('txtEntidad').disabled = false;
            document.getElementById('imagenOK').disabled = false;
            document.getElementById('cboEstado').disabled = false;
            document.getElementById('imagenCancel').disabled = false;
            
            
            return false;
        }
        
        function ocultarCampos()
        {
            document.getElementById('txtidDenunciado').disabled = true;
            document.getElementById('txtEntidad').disabled = true;
            document.getElementById('txtidDenunciado').value = "";
            document.getElementById('txtEntidad').value = "";  
            document.getElementById('cboEstado').disabled = true;          
            document.getElementById('imagenOK').disabled = true;
            document.getElementById('imagenCancel').disabled = true;
            
            return false;
        }        
    </script> 
</head>
<body style="text-align: left">
    <form id="form1" runat="server">
    <div>
        <div>
            <table id="tblPartidos" style="width: 624px; height: 48px">
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
            <table id="tblLocalidades" style="width: 624px; height: 360px">
                <tr>
                    <td align="left" colspan="1" style="width: 62px; height: 20px" valign="top">
                    </td>
                    <td align="center" colspan="4" style="height: 20px" valign="top">
                        &nbsp;<asp:Label ID="lbldenun" runat="server" Text="Denunciados" CssClass="lblBoldUpperXXS"></asp:Label></td>
                </tr>
                <tr>
                    <td align="center" colspan="1" style="width: 62px; height: 16px" valign="top">
                    </td>
                    <td align="center" colspan="4" style="height: 16px" valign="top">
                        <table style="width: 248px; height: 56px">
                            <tr>
                                <td style="width: 264px; height: 165px">
                                    <asp:GridView ID="GvDenunciados" runat="server" CssClass="DataGrid"
                                        ForeColor="Black" Width="280px" OnPageIndexChanged="GvDenunciados_PageIndexChanged" OnRowDataBound="GvDenunciados_RowDataBound" OnSelectedIndexChanged="GvDenunciados_SelectedIndexChanged" OnPageIndexChanging="GvDenunciados_PageIndexChanging" AllowPaging="True" Height="168px">
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
                                    &nbsp;&nbsp;
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 62px; height: 21px">
                    </td>
                    <td align="right" style="width: 59px; height: 21px">
                    </td>
                    <td style="width: 134px; height: 21px; text-align: center">
                    </td>
                    <td style="width: 224px; height: 21px; text-align: center">
                    </td>
                    <td style="width: 179px; height: 21px; text-align: center">
                        </td>
                </tr>
                <tr>
                    <td align="right" style="width: 62px; height: 23px">
                    </td>
                    <td align="right" style="width: 59px; height: 23px">
                        </td>
                    <td style="width: 134px; height: 23px; text-align: center">
                        <asp:Label ID="lblidDenunciado" runat="server" CssClass="lblBoldUpperXXS" Text="Id Denunciado: "></asp:Label></td>
                    <td style="width: 224px; height: 23px; text-align: center">
                        <asp:TextBox ID="txtidDenunciado" runat="server" CssClass="TextBox" Enabled="False" Width="136px" MaxLength="4"></asp:TextBox></td>
                    <td style="width: 179px; height: 23px; text-align: center">
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" CssClass="ButtonBlue11px" OnClick="btnAceptar_Click" /></td>
                </tr>
                <tr>
                    <td align="right" style="width: 62px">
                    </td>
                    <td align="right" style="width: 59px">
                        </td>
                    <td style="width: 134px; text-align: center">
                        <asp:Label ID="lblEntidad" runat="server" CssClass="lblBoldUpperXXS" Text="Entidad: "></asp:Label></td>
                    <td style="width: 224px; text-align: center">
                        <asp:TextBox ID="txtEntidad" runat="server" CssClass="TextBoxLetras" Enabled="False" Width="136px" MaxLength="30"></asp:TextBox></td>
                    <td style="width: 179px; text-align: center">
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="ButtonBlue11px" OnClick="btnCancelar_Click" /></td>
                </tr>
                <tr>
                    <td align="right" style="width: 62px">
                    </td>
                    <td align="right" style="width: 59px">
                        </td>
                    <td style="width: 134px; text-align: center">
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
                        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="ButtonBlue11px" OnClick="btnAgregar_Click" /></td>
                    <td style="width: 3px">
                        <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="ButtonBlue11px" OnClick="btnModificar_Click" /></td>
                    <td style="width: 107px">
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="ButtonBlue11px" OnClick="btnEliminar_Click" /></td>
                    <td style="width: 107px">
                        <asp:Button ID="btnTodos" runat="server" Text="Ver Todos" CssClass="ButtonBlue11px" OnClick="btnTodos_Click" Width="88px" /></td>
                    <td style="width: 107px">
                        <asp:Button ID="btnActivos" runat="server" Text="Ver Activos" CssClass="ButtonBlue11px" OnClick="btnActivos_Click" Width="88px" /></td>
                    <td style="width: 107px">
                        <asp:Button ID="btnInactivos" runat="server" Text="Ver Inactivos" CssClass="ButtonBlue11px" OnClick="btnInactivos_Click" Width="88px" /></td>
                    <td style="width: 111px">
                        <asp:Button ID="btnVolver" runat="server" Text="Salir" CssClass="ButtonBlue11px" OnClick="btnRegresar_Click" Width="88px" /></td>
                </tr>
            </table>
        </div>
    
    </div>
       
        <input type="hidden" runat="server" id="hAccion" style="height: 24px" />
    </form>
</body>
</html>
