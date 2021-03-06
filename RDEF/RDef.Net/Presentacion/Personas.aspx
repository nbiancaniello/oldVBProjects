﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Personas.aspx.cs" Inherits="Presentacion_Personas" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Mantenimiento - Personas</title>
    <link href="../styles.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
    
        function mostrarCampos(accion)
        {        
            
            document.getElementById('hAccion').value = accion;
                
            document.getElementById('txtidPersona').disabled = false;            
            document.getElementById('txtnombre').disabled = false;
            //document.getElementById('btnaceptar').disabled = false;
            document.getElementById('cboestado').disabled = false;
           //document.getElementById('btncancelar').disabled = false;
           
            
            return false;
        }
        
        function ocultarCampos()
        {
            document.getElementById('txtidPersona').disabled = true;
            document.getElementById('txtnombre').disabled = true;
            document.getElementById('txtIDPersona').value = "";
            document.getElementById('txtnombre').value = "";  
            document.getElementById('cboestado').disabled = true;          
            //document.getElementById('btnaceptar').disabled = true;
            //document.getElementById('btncancelar').disabled = true;
            
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
                    <td align="left" colspan="1" style="width: 42px; height: 20px" valign="top">
                    </td>
                    <td align="center" colspan="4" style="height: 20px" valign="top">
                        &nbsp;<asp:Label ID="lbl" runat="server" CssClass="lblBoldUpperXXS" Font-Bold="True"
                            Text="Personas"></asp:Label></td>
                </tr>
                <tr>
                    <td align="center" colspan="1" style="width: 42px; height: 16px" valign="top">
                    </td>
                    <td align="center" colspan="4" style="height: 16px" valign="top">
                        <table style="width: 248px; height: 56px">
                            <tr>
                                <td style="width: 347px; height: 165px">
                                    <asp:GridView ID="GvPersonas" runat="server" ForeColor="Black" OnPageIndexChanged="GvPersonas_PageIndexChanged" OnRowDataBound="GvPersonas_RowDataBound" OnSelectedIndexChanged="GvPersonas_SelectedIndexChanged" CssClass="DataGrid" Width="280px" OnPageIndexChanging="GvPersonas_PageIndexChanging" AllowPaging="True" Height="168px">
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
                                    &nbsp;&nbsp;</td>
                            </tr>
                        </table>
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 42px; height: 23px">
                    </td>
                    <td align="right" style="width: 154px; height: 23px">
                        </td>
                    <td align="center" style="width: 108px; height: 23px; text-align: center">
                        </td>
                    <td style="width: 217px; height: 23px">
                        </td>
                    <td style="width: 179px; height: 23px; text-align: center">
                    </td>
                </tr>
                <tr>
                    <td align="right" style="width: 42px; height: 19px">
                    </td>
                    <td align="right" style="width: 154px; height: 19px">
                        </td>
                    <td style="width: 108px; height: 19px; text-align: center">
                        <asp:Label ID="Label1" runat="server" CssClass="lblBoldUpperXXS" Font-Bold="True"
                            Text="Codigo"></asp:Label></td>
                    <td style="width: 217px; height: 19px; text-align: center">
                        <asp:TextBox ID="txtidpersona" runat="server" Width="112px"></asp:TextBox></td>
                    <td style="width: 179px; height: 19px; text-align: center">
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnaceptar_Click" CssClass="ButtonBlue11px" /></td>
                </tr>
                <tr>
                    <td align="right" style="width: 42px; height: 23px">
                    </td>
                    <td align="right" style="width: 154px; height: 23px">
                        </td>
                    <td style="width: 108px; height: 23px; text-align: center">
                        <asp:Label ID="Label2" runat="server" CssClass="lblBoldUpperXXS" Font-Bold="True"
                            Text="Nombre"></asp:Label></td>
                    <td style="width: 217px; height: 23px; text-align: center">
                        <asp:TextBox ID="txtnombre" runat="server" CssClass="TextBoxLetras"></asp:TextBox></td>
                    <td style="width: 179px; height: 23px; text-align: center">
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" OnClick="btncancelar_Click" CssClass="ButtonBlue11px" /></td>
                </tr>
                <tr>
                    <td align="right" style="width: 42px; height: 5px;">
                    </td>
                    <td align="right" style="width: 154px; height: 5px;">
                        </td>
                    <td style="width: 108px; text-align: center; height: 5px;">
                        <asp:Label ID="Label3" runat="server" CssClass="lblBoldUpperXXS" Font-Bold="True"
                            Text="Estado"></asp:Label></td>
                    <td style="width: 217px; text-align: center; height: 5px;">
                        <asp:DropDownList ID="cboestado" runat="server">
                        </asp:DropDownList></td>
                    <td style="width: 179px; text-align: center; height: 5px;">
                        </td>
                </tr>
                <tr>
                    <td align="right" style="width: 42px; height: 19px">
                    </td>
                    <td align="right" style="width: 154px; height: 19px">
                        </td>
                    <td align="center" style="width: 108px; height: 19px; text-align: center">
                        &nbsp;</td>
                    <td style="width: 217px; height: 19px">
                    </td>
                    <td align="right" style="width: 179px; height: 19px">
                    </td>
                </tr>
            </table>
            <table style="width: 608px">
                <tr>
                    <td>
                        <asp:Button ID="btnAgregar" runat="server" OnClick="BtnAgregar_Click" Text="Agregar" CssClass="ButtonBlue11px" /></td>
                    <td>
                        <asp:Button ID="btnModificar" runat="server" OnClick="btnmodificar_Click" Text="Modificar" CssClass="ButtonBlue11px" /></td>
                    <td>
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btneliminar_Click" CssClass="ButtonBlue11px" /></td>
                    <td>
                        <asp:Button ID="btnTodos" runat="server" Text="Ver Todos" OnClick="btntodos_Click" CssClass="ButtonBlue11px" Width="88px" /></td>
                    <td>
                        <asp:Button ID="btnActivos" runat="server" Text="Ver Activos" OnClick="btnactivos_Click" CssClass="ButtonBlue11px" Width="88px" /></td>
                    <td>
                        <asp:Button ID="btnInactivos" runat="server" Text="Ver Inactivos" OnClick="btninactivos_Click" CssClass="ButtonBlue11px" Width="88px" /></td>
                    <td>
                        <asp:Button ID="btnVolver" runat="server" Text="Salir" OnClick="btnretornar_Click" CssClass="ButtonBlue11px" Width="88px" /></td>
                </tr>
            </table>
        </div>
    
    </div>
        <asp:HiddenField ID="hAccion" runat="server" />
    </form>
</body>
</html>
