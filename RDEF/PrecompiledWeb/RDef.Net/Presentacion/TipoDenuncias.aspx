﻿<%@ page language="C#" autoeventwireup="true" inherits="Presentacion_TipoDenuncias, App_Web_r2qjsibb" enableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Mantenimiento - Tipo de Denuncias</title>
    <link href="../styles.css" rel="stylesheet" type="text/css" />
        <script type="text/javascript">
    
        function mostrarCampos(accion)
        {        
            
            document.getElementById('hAccion').value = accion;
                
            document.getElementById('txttipodenuncia').disabled = false;            
            document.getElementById('txtdescripcion').disabled = false;
            document.getElementById('btnaceptar').disabled = false;
            document.getElementById('cboestado').disabled = false;
            document.getElementById('btncancelar').disabled = false;
            
            
            return false;
        }
        
        function ocultarCampos()
        {
            document.getElementById('txttipodenuncia').disabled = true;
            document.getElementById('txtdescripcion').disabled = true;
            document.getElementById('txttipodenuncia').value = "";
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
                    <asp:Label ID="lbl" runat="server" CssClass="lblBoldUpperXXS" Font-Bold="True" Text="Tipos De Denuncias"></asp:Label>
                </td>
            </tr>
            <tr>
                <td align="center" colspan="1" style="width: 336px; height: 16px" valign="top">
                </td>
                <td align="center" colspan="4" style="height: 16px" valign="top">
                    <table style="width: 248px; height: 56px">
                        <tr>
                            <td style="width: 264px; height: 165px">
                                &nbsp;<asp:GridView ID="GvTipoDenuncias" runat="server" CellPadding="4"
                                    CssClass="DataGrid" ForeColor="#333333" GridLines="None" Height="168px" Width="280px" OnPageIndexChanged="GvTipoDenuncias_PageIndexChanged" OnRowDataBound="GvTipoDenuncias_RowDataBound" OnSelectedIndexChanged="GvTipoDenuncias_SelectedIndexChanged">
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
                    <asp:Button ID="btnagregar" runat="server" CssClass="ButtonBlue11px" Text="Agregar" OnClick="btnagregar_Click" Width="88px" /></td>
                <td align="center" style="width: 74px; height: 23px; text-align: center">
                    <asp:Button ID="btnmodificar" runat="server" CssClass="ButtonBlue11px" Text="Modificar" OnClick="btnmodificar_Click" Width="88px" /></td>
                <td style="width: 224px; height: 23px">
                    <asp:Button ID="btneliminar" runat="server" CssClass="ButtonBlue11px" Text="Eliminar" OnClick="btneliminar_Click" Width="88px" /></td>
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
                    <asp:Button ID="btntodos" runat="server" Text="Todos" OnClick="btntodos_Click" CssClass="ButtonBlue11px" Width="88px" /></td>
            </tr>
            <tr>
                <td align="right" style="width: 336px; height: 23px">
                </td>
                <td align="right" style="width: 447px; height: 23px">
                    <asp:Label ID="lblCP" runat="server" CssClass="lblBoldUpperXXS" Text="Tipo de Denuncia: "></asp:Label></td>
                <td style="width: 74px; height: 23px; text-align: center">
                    <asp:TextBox ID="txttipodenuncia" runat="server" CssClass="TextBox" MaxLength="4"
                        Width="136px"></asp:TextBox></td>
                <td style="width: 224px; height: 23px; text-align: center">
                </td>
                <td style="width: 179px; height: 23px; text-align: center">
                    <asp:Button ID="btnactivos" runat="server" CssClass="ButtonBlue11px" OnClick="btnactivos_Click"
                        Text="Solo Activos" Width="88px" /></td>
            </tr>
            <tr>
                <td align="right" style="width: 336px; height: 23px;">
                </td>
                <td align="right" style="width: 447px; height: 23px;">
                    <asp:Label ID="lblLoc" runat="server" CssClass="lblBoldUpperXXS" Text="Descripcion: "></asp:Label></td>
                <td style="width: 74px; text-align: center; height: 23px;">
                    <asp:TextBox ID="txtdescripcion" runat="server" Enabled="False" Width="136px" MaxLength="30" CssClass="TextBoxLetras" ></asp:TextBox></td>
                <td style="width: 224px; text-align: center; height: 23px;">
                </td>
                <td style="width: 179px; text-align: center; height: 23px;">
                    <asp:Button ID="btninactivos" runat="server" CssClass="ButtonBlue11px" OnClick="btninactivos_Click"
                        Text="Solo Inactivos" Width="88px" /></td>
            </tr>
            <tr>
                <td align="right" style="width: 336px; height: 30px">
                </td>
                <td align="right" style="width: 447px; height: 30px">
                    <asp:Label ID="lblEstado" runat="server" CssClass="lblBoldUpperXXS" Text="Estado: "></asp:Label></td>
                <td align="left" style="width: 74px; height: 30px; text-align: center">
                    <asp:DropDownList ID="cboestado" runat="server">
                    </asp:DropDownList>&nbsp;</td>
                <td style="width: 224px; height: 30px">
                </td>
                <td align="right" style="width: 179px; height: 30px">
                </td>
            </tr>
            <tr>
                <td align="right" style="width: 336px; height: 30px">
                </td>
                <td align="right" style="width: 447px; height: 30px">
                    <asp:Button ID="btnaceptar" runat="server" CssClass="ButtonBlue11px" OnClick="btnaceptar_Click"
                        Text="Aceptar" Width="88px" /></td>
                <td align="left" style="width: 74px; height: 30px; text-align: center">
                    <asp:Button ID="Btncancelar" runat="server" CssClass="ButtonBlue11px" OnClick="btncancelar_Click"
                        Text="Cancelar" Width="88px" /></td>
                <td style="width: 224px; height: 30px">
                    </td>
                <td align="center" style="width: 179px; height: 30px">
                    <asp:Button ID="btnvolver" runat="server" CssClass="ButtonBlue11px" OnClick="btnVolver_Click"
                        Text="Regresar" Width="88px" /></td>
            </tr>
        </table>
    
    </div>
        <asp:HiddenField ID="hAccion" runat="server" />
    </form>
</body>
</html>
