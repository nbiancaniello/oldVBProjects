<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Contactos.aspx.cs" Inherits="Presentacion_Contactos" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Administracion de Contactos</title>
    <link href="../styles.css" type="text/css" rel="stylesheet"/>
    <base target="_self"/>
        <script type="text/javascript">
        
        function Confirmar()
        {
            return confirm("Se eliminará el contacto de la lista. ¿Desea continuar?");
        }
    
        function mostrarCampos(accion)
        {        
            
            document.getElementById('hAccion').value = accion;
            
            if(accion == 'agregar')
            {
                document.getElementById('txtTel').value = "";                        
            }
            else
                if(document.getElementById('txtTel').value == "")
                {
                    alert('Seleccione un telefono');
                    return false;
                }

                
            document.getElementById('txtTel').disabled = false;
            document.getElementById('btnAceptar').disabled = false;
            document.getElementById('btnAceptar').className = "ButtonBlue11px";            
            
            document.getElementById('btnCancelar').disabled = false;
            document.getElementById('btnCancelar').className = "ButtonBlue11px";
            
            return false;
        }
        

        function ocultarCampos()
        {
            document.getElementById('txtTel').disabled = true;
            document.getElementById('txtTel').value = "";                        
            document.getElementById('btnAceptar').disabled = true;
            document.getElementById('btnCancelar').disabled = true;
            
            document.getElementById('btnAceptar').className = "ButtonBlue11pxDisable";            
            document.getElementById('btnCancelar').className = "ButtonBlue11pxDisable";
            
            return false;
        }        
        
        function Submit()
        {
            document.forms['form1'].submit();
        }
    </script> 

</head>
<body runat="server">
    <form id="form1" runat="server" >  
    <div>
        <table style="width: 496px; height: 408px">
            <tr>
                <td style="width: 57px">
                </td>
                <td style="width: 363px">
                </td>
            </tr>
            <tr>
                <td style="width: 57px">
                </td>
                <td style="width: 363px">
                    &nbsp;<asp:Label ID="lbl" runat="server" CssClass="lblBoldUpperXXS" Text="tipo de contacto: "
                        Width="112px"></asp:Label>
                    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
                        Width="192px" CssClass="ComboBox">
                        <asp:ListItem Selected="True" Value="0">&lt;Seleccionar&gt;</asp:ListItem>
                        <asp:ListItem Value="T">Telefono</asp:ListItem>
                        <asp:ListItem Value="C">Celular</asp:ListItem>
                        <asp:ListItem Value="E">Email</asp:ListItem>
                    </asp:DropDownList></td>
            </tr>
            <tr>
                <td style="width: 57px">
                </td>
                <td style="width: 363px" align="center">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 57px; height: 139px;">
                </td>
                <td style="width: 363px; height: 139px;" align="center" valign="top">
                    <asp:GridView ID="grdContactos" runat="server" Width="360px" CssClass="DataGrid" OnRowDataBound="grdContactos_RowDataBound" OnSelectedIndexChanged="grdContactos_SelectedIndexChanged">
                        <FooterStyle CssClass="DataGridItem" />
                        <HeaderStyle CssClass="DataGridHeader" BackColor="#507CD1" />
                        <RowStyle BackColor="#EFF3FB" CssClass="DataGridItem" />
                        <SelectedRowStyle BackColor="#D1DDF1" />
                        <Columns>
                        <asp:CommandField ShowEditButton="True" ButtonType="Image" EditImageUrl="~/Imagenes/next.gif" SelectImageUrl="~/Imagenes/show2.gif" />
                        </Columns>
                    </asp:GridView>
                </td>
            </tr>
            <tr>
                <td style="width: 57px; height: 28px;">
                </td>
                <td align="center" style="width: 363px; height: 28px;" valign="baseline">
                    <asp:Button ID="btnAplicar" runat="server" Text="ACTIVAR" CssClass="ButtonBlue11pxDisable" Enabled="False" OnClick="btnAplicar_Click" Width="96px" />
                    &nbsp; <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="ButtonBlue11pxDisable" Enabled="False"/>
                    <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="ButtonBlue11pxDisable" Enabled="False" />
                    <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" OnClick="btnEliminar_Click" CssClass="ButtonBlue11pxDisable" Enabled="False" /></td>
            </tr>
            <tr>
                <td style="width: 57px; height: 32px;">
                </td>
                <td align="center" style="width: 363px; height: 32px;" valign="baseline">
                    <asp:Label ID="lblContacto" runat="server" Text="Contacto: " CssClass="lblBoldUpperXXS"></asp:Label>
                    <asp:TextBox ID="txtTel" runat="server" CssClass="TextBox" Enabled="False" Width="280px"></asp:TextBox>&nbsp;
                </td>
            </tr>
            <tr>
                <td style="width: 57px">
                </td>
                <td align="center" style="width: 363px" valign="top">
                    <asp:Button ID="btnAceptar" runat="server" CssClass="ButtonBlue11pxDisable" OnClick="btnAceptar_Click"
                        Text="Aceptar" Enabled="False" /><asp:Button ID="btnCancelar" runat="server" CssClass="ButtonBlue11pxDisable"
                            Text="Cancelar" Enabled="False" /></td>
            </tr>
            <tr>
                <td style="width: 57px">
                </td>
                <td align="center" style="width: 363px" valign="top">
                </td>
            </tr>
            <tr>
                <td style="width: 57px; height: 25px;">
                </td>
                <td style="width: 363px; height: 25px;">
                </td>
            </tr>
            <tr>
                <td style="width: 57px">
                </td>
                <td style="width: 363px" align="right">
                    &nbsp;<asp:Button ID="btnVolver" runat="server" Text="Volver" OnClick="btnVolver_Click" CssClass="ButtonBlue11px" /></td>
            </tr>
        </table>
    
    </div>
    <input type="hidden" runat="server" id="hAccion" style="height: 1px; width: 8px;" />
    <input type="hidden" runat="server" id="hTelAct" style="height: 1px; width: 8px;" />
    <input type="hidden" runat="server" id="hCelAct" style="height: 1px; width: 8px;" />
    <input type="hidden" runat="server" id="hMailAct" style="height: 1px; width: 8px;" />
    <input type="hidden" runat="server" id="hActivo" style="height: 1px; width: 8px;" />
    </form>
</body>
</html>
