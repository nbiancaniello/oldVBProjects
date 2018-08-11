<%@ page language="C#" autoeventwireup="true" inherits="Presentacion_Localidades, App_Web_r2qjsibb" enableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Mantenimineto - Localidades</title>
    <link href="../styles.css" type="text/css" rel="stylesheet"/>
    <base target="_self"/>
    <script type="text/javascript">
    
        function mostrarCampos(accion)
        {        
            
            document.getElementById('hAccion').value = accion;
                
            document.getElementById('txtCP').disabled = false;            
            document.getElementById('txtLoc').disabled = false;
            document.getElementById('btnaceptar').disabled = false;
            document.getElementById('btncancelar').disabled = false;
            
            return false;
        }
        
        function ocultarCampos()
        {
            document.getElementById('txtCP').disabled = true;
            document.getElementById('txtLoc').disabled = true;
            document.getElementById('txtCP').value = "";
            document.getElementById('txtLoc').value = "";            
            document.getElementById('btnaceptar').disabled = true;
            document.getElementById('btncancelar').disabled = true;
            
            return false;
        }        
    </script>    
     
</head>
<body style="text-align: left">
    <form id="form1" runat="server">
        <table style="width: 608px; height: 48px" id="tblPartidos">
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
                <td style="width: 651px; height: 2px;" align="right">
                    <asp:Label ID="Label2" runat="server" CssClass="lblBoldUpperXXS" Text="Lista de Partidos: "></asp:Label>&nbsp;<asp:DropDownList ID="cboPartidos" runat="server" CssClass="ComboBox" OnSelectedIndexChanged="cboPartidos_SelectedIndexChanged"
                        Width="224px" AutoPostBack="True">
                    </asp:DropDownList></td>
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
                <td style="height: 2px; width: 228px;">
                </td>
                <td style="height: 2px; text-align: center; width: 651px;">
                </td>
                <td style="height: 2px; width: 121px;">
                </td>
                <td style="width: 179px; height: 2px">
                </td>
                <td style="width: 179px; height: 2px">
                </td>
            </tr>
       </table>
       <table style="width: 608px; height: 360px;" id="tblLocalidades">
            <tr>
                <td align="left" colspan="1" style="width: 336px; height: 20px" valign="top">
                </td>
                <td align="left" colspan="4" style="height: 20px" valign="top">
                                <asp:Label ID="lbl" runat="server" Font-Bold="True" Text="Localidades Pertenecientes a " CssClass="lblBoldUpperXXS"></asp:Label>
                    <asp:Label ID="lblPartido" runat="server" CssClass="lblBoldUpperXXS"></asp:Label></td>
            </tr>
            <tr>
                <td align="center" colspan="1" style="width: 336px; height: 16px" valign="top">
                </td>
                <td align="center" colspan="4" style="height: 16px" valign="top">
                    <table style="width: 248px; height: 56px">
                        <tr>
                           <td style="width: 264px; height: 165px">
                                <asp:GridView ID="gvLocalidades" runat="server" Height="168px" Width="280px" CssClass="DataGrid" OnPageIndexChanged="gvLocalidades_PageIndexChanged" OnRowDataBound="gvLocalidades_RowDataBound" OnSelectedIndexChanged="gvLocalidades_SelectedIndexChanged">
                                    <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                                    <Columns>
                                        <asp:CommandField ShowEditButton="True" ButtonType="Image" EditImageUrl="~/Imagenes/next.gif" SelectImageUrl="~/Imagenes/show2.gif" />
                                    </Columns>
                                    <RowStyle BackColor="#EFF3FB" CssClass="DataGridItem" />
                                    <EditRowStyle BackColor="#2461BF" />
                                    <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                                    <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                                    <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" CssClass="DataGridHeader" />
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
                <td style="width: 447px; height: 23px;" align="right">
                    <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="ButtonBlue11px" /></td>
                <td style="width: 74px; text-align: center; height: 23px;" align="center">
                   <asp:Button ID="btnmodificar" runat="server" Text="Modificar" CssClass="ButtonBlue11px" /></td>
                <td style="width: 224px; height: 23px;">
                   <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="ButtonBlue11px" OnClick="btnEliminar_Click" /></td>
                <td style="width: 179px; text-align: center; height: 23px;">
                </td>
            </tr>
            <tr>
                <td align="right" style="width: 336px; height: 21px">
                </td>
                <td style="width: 447px; height: 21px;" align="right">
                    </td>
                <td style="width: 74px; text-align: center; height: 21px;">
                    </td>
                <td style="width: 224px; text-align: center; height: 21px;">
                </td>
                <td style="width: 179px; text-align: center; height: 21px;">
                </td>
            </tr>
           <tr>
               <td align="right" style="width: 336px; height: 23px">
               </td>
               <td align="right" style="width: 447px; height: 23px;">
                    <asp:Label ID="lblCP" runat="server" Text="CP: " CssClass="lblBoldUpperXXS"></asp:Label></td>
               <td style="width: 74px; text-align: center; height: 23px;">
                    <asp:TextBox ID="txtCP" runat="server" Width="136px" CssClass="TextBox" Enabled="False" MaxLength="4"></asp:TextBox></td>
               <td style="width: 224px; text-align: center; height: 23px;">
               </td>
               <td style="width: 179px; text-align: center; height: 23px;">
               </td>
           </tr>
           <tr>
               <td align="right" style="width: 336px">
               </td>
               <td align="right" style="width: 447px">
                    <asp:Label ID="lblLoc" runat="server" Text="Localidad: " CssClass="lblBoldUpperXXS"></asp:Label></td>
               <td style="width: 74px; text-align: center">
                    <asp:TextBox
                        ID="txtLoc" runat="server" Width="136px" CssClass="TextBoxAlfaNumerico" Enabled="False" MaxLength="30"></asp:TextBox></td>
               <td style="width: 224px; text-align: center">
                   </td>
               <td style="width: 179px; text-align: center">
               </td>
           </tr>
            <tr>
                <td align="right" style="width: 336px; height: 30px">
                </td>
                <td style="width: 447px; height: 30px;" align="right">
                    <asp:Button ID="btnaceptar" runat="server" CssClass="ButtonBlue11px" OnClick="btnaceptar_Click1"
                        Text="Aceptar" /></td>
                <td style="text-align: center; width: 74px; height: 30px;" align="left">
                    &nbsp;<asp:Button ID="btncancelar" runat="server" CssClass="ButtonBlue11px" OnClick="btncancelar_Click"
                        Text="Cancelar" /></td>
                <td style="width: 224px; height: 30px;">
                    </td>
                <td style="width: 179px; height: 30px;" align="right"></td>
            </tr>
           <tr>
               <td align="right" style="width: 336px; height: 30px">
               </td>
               <td align="right" style="width: 447px; height: 30px">
               </td>
               <td align="left" style="width: 74px; height: 30px; text-align: center">
               </td>
               <td style="width: 224px; height: 30px">
                   <asp:Button ID="btnRegresar" runat="server" Text="Regresar" CssClass="ButtonBlue11px" OnClick="btnRegresar_Click" /></td>
               <td align="right" style="width: 179px; height: 30px">
               </td>
           </tr>
        </table>
        <input type="hidden" runat="server" id="hAccion" />
        <input type="hidden" runat="server" id="hIdPartidoSel" />
    </form>
</body>
</html>
