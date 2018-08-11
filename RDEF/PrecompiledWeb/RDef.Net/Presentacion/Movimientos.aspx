<%@ page language="C#" autoeventwireup="true" inherits="Presentacion_Movimientos, App_Web_r2qjsibb" enableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Movimientos</title>
    <link href="../styles.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript" src="../CalendarPopup.js"></script>
    <script type="text/javascript">
        function mostrarFechaRespuesta(){
            var d;
            var s = "Fecha de Respuesta: ";
            d = new Date();
            d.setUTCMonth(d.getUTCMonth()+ 1);
            d.setUTCDate(d.getUTCDate()+ 41);            
            s += (d.getUTCDate()) + "/";
            s += (d.getUTCMonth()) + "/";
            s += d.getUTCFullYear();
            alert(s);return false;
        }
        
        var cal1 = new CalendarPopup();
        var cal2 = new CalendarPopup();
    </script>
</head>
<body>
    <form id="form1" runat="server" title="Movimientos">
    <div title="xd">
        &nbsp;</div>
        <table style="width: 776px;height: 336px" id="tblPrincipal">
            <tr>
                <td style="height: 42px; width: 83px;" colspan="">
                    <asp:Label ID="lblNumeroExpediente" runat="server" Text="N° Exp" CssClass="lblBoldUpperXXS"></asp:Label>
                    <asp:TextBox ID="txtExpediente" runat="server" CssClass="TextBox" Enabled="False" Width="32px" Wrap="False"></asp:TextBox></td>
                <td style="width: 157px; height: 42px;">
                    </td>
                <td style="height: 42px; width: 151px;">
                    <asp:Label ID="lblIniciador" runat="server" Text="Iniciador" CssClass="lblBoldUpperXXS"></asp:Label>
                    <asp:TextBox ID="txtIniciador" runat="server" CssClass="TextBox" Enabled="False" Wrap="False" Width="80px"></asp:TextBox></td>
                <td style="width: 131px; height: 42px;">
                    <asp:Label ID="lblNumeroMovimiento" runat="server" Text="N° Movimiento" CssClass="lblBoldUpperXXS" Width="88px"></asp:Label>
                    <asp:TextBox ID="txtNumeroMovimiento" runat="server" CssClass="TextBox" Enabled="False" Width="32px" Wrap="False"></asp:TextBox></td>
                <td style="width: 115px; height: 42px;">
                    </td>
            </tr>
            <tr>
                <td style="width: 83px">
                    <asp:Label ID="lblTipoMovimiento" runat="server" Text="Tipo Mov:" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="width: 157px">
                    <asp:DropDownList ID="cboTipoMovimiento" runat="server" OnSelectedIndexChanged="cboTipoMovimiento_SelectedIndexChanged" AutoPostBack="True" CssClass="ComboBox" Width="168px" Enabled="False">
                    </asp:DropDownList></td>
                <td style="width: 151px">
                    <asp:Label ID="lblFechaMovimiento" runat="server" Text="Fecha" CssClass="lblBoldUpperXXS"></asp:Label>&nbsp;
                    <asp:TextBox ID="txtFechaMovimiento" runat="server" CssClass="TextBoxDATE" Enabled="False" Width="80px" Wrap="False" MaxLength="10"></asp:TextBox>
                    <img alt="" src="../Imagenes/b_calendar.png" /></td>
                <td style="width: 131px">
                    <asp:Label ID="lblFinal" runat="server" CssClass="lblBoldUpperXXS" Text="Fin"></asp:Label>&nbsp;<asp:DropDownList
                        ID="cboFines" runat="server" CssClass="ComboBox" Enabled="False" Width="72px">
                    </asp:DropDownList>&nbsp;
                </td>
                <td style="width: 115px">
                    <asp:Label ID="lblFechaArchivo" runat="server" Text="Fecha Archivo" Width="96px" CssClass="lblBoldUpperXXS"></asp:Label>
                    <asp:TextBox ID="txtFechaArchivo" runat="server" CssClass="TextBoxDATE" Enabled="False" Width="72px" Wrap="False" MaxLength="10"></asp:TextBox>
                    <img alt="" src="../Imagenes/b_calendar.png" /></td>
            </tr>
            <tr>
                <td style="height: 29px; width: 83px;">
                    <asp:Label ID="lblGenero" runat="server" Text="Generó" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="height: 29px; width: 157px;">
                    <asp:DropDownList ID="cboGenero" runat="server" CssClass="ComboBox" Enabled="False" Width="168px">
                    </asp:DropDownList></td>
                <td style="height: 29px; width: 151px;">
                    <asp:Button ID="btnFechaRespuesta" runat="server" Text="Fecha Respuesta" Width="112px" CssClass="ButtonBlue11px" CausesValidation="False" OnClientClick="mostrarFechaRespuesta()" UseSubmitBehavior="False" Enabled="False" /></td>
                <td style="width: 131px; height: 29px;">
                    <asp:CheckBox ID="chkRespuesta" runat="server" Text="¿Espera Respuesta?" TextAlign="Left" Width="136px" CssClass="lblBoldUpperXXS" Enabled="False" /></td>
                <td style="width: 115px; height: 29px;">
                </td>
            </tr>
            <tr>
                <td style="height: 50px; width: 83px;">
                    <asp:Label ID="lblNumeroExpedienteMVL" runat="server" Text="N° Exp MVL" Width="64px" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="width: 157px; height: 50px;">
                    <asp:DropDownList ID="cboCodigoExpedienteMVL" runat="server" CssClass="ComboBox" Enabled="False" Width="72px">
                    </asp:DropDownList>
                    <asp:TextBox ID="txtNumeroExpedienteMVL" runat="server" CssClass="TextBoxNumero" Enabled="False" Wrap="False" Width="56px" MaxLength="10"></asp:TextBox>
                    <asp:TextBox ID="txtAnioExpediente" runat="server" CssClass="TextBoxNumero" Enabled="False"
                        Width="32px" Wrap="False" MaxLength="4"></asp:TextBox></td>
                <td style="height: 50px; width: 151px;">
                    <asp:Label ID="lblExpedientesGeneradosMVL" runat="server" CssClass="lblBoldUpperXXS"
                        Text="Exp MVL"></asp:Label>&nbsp;
                    <asp:DropDownList ID="cboExpedientesGeneradosMVL" runat="server"
                        CssClass="ComboBox" Enabled="False" Width="120px" >
                    </asp:DropDownList></td>
                <td style="width: 131px; height: 50px;">
                    <asp:Label ID="lblDependencia" runat="server" Text="Dependencia" CssClass="lblBoldUpperXXS"></asp:Label>
                    <br />
                    <asp:DropDownList ID="cboDependencia" runat="server" CssClass="ComboBox" Width="88px" Enabled="False" AutoPostBack="True" OnSelectedIndexChanged="cboDependencia_SelectedIndexChanged">
                    </asp:DropDownList></td>
                <td style="width: 115px; height: 50px;">
                    <asp:ImageButton ID="ibtVerEscrito" runat="server" AlternateText="Ver Escrito" BackColor="Transparent"
                        CausesValidation="False" ForeColor="Transparent" ImageUrl="~/imagenes/word2007.gif"
                        ToolTip="Ver Escrito" OnClick="ibtVerEscrito_Click" Height="32px" Width="32px" />
                    <asp:Label ID="lblVerEscrito" runat="server" CssClass="lblBoldUpperXXS" Text="Ver Escrito" Width="80px"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 83px">
                    <asp:Label ID="lblNumeroResolucion" runat="server" Text="N° Resolución" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="width: 157px">
                    <asp:TextBox ID="txtNumeroResolucion" runat="server" CssClass="TextBoxNumero" Enabled="False" Wrap="False" Width="96px" MaxLength="5"></asp:TextBox></td>
                <td style="width: 151px">
                    <asp:Label ID="lblPasar" runat="server" Text="Pasa a" CssClass="lblBoldUpperXXS"></asp:Label>
                    <asp:DropDownList ID="cboPasar" runat="server" CssClass="ComboBox" Enabled="False">
                    </asp:DropDownList></td>
                <td style="width: 131px">
                    </td>
                <td style="width: 115px">
                <asp:ImageButton ID="ibtGenerarEscrito" runat="server" AlternateText="Generar Escrito"
                        BackColor="Transparent" CausesValidation="False" ForeColor="Transparent" ImageUrl="~/imagenes/word2007.gif"
                        OnClick="ibtGenerarEscrito_Click" ToolTip="Generar Escrito" Height="32px" Width="32px" />
                    <asp:Label ID="lblGenerarEscrito" runat="server" CssClass="lblBoldUpperXXS" Text="Generar Escrito"
                        Width="104px"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 83px">
                    <asp:Label ID="lblComentario" runat="server" Text="Comentario" CssClass="lblBoldUpperXXS"></asp:Label></td>
                <td style="width: 157px">
                </td>
                <td style="width: 151px">
                </td>
                <td style="width: 131px;">
                </td>
                <td style="width: 115px;">
                </td>
            </tr>        
            <tr >
                <td colspan="5" style="height: 90px">
                    <asp:TextBox ID="txtComentario" runat="server" Columns="100" Rows="6" Height="100%" TextMode="MultiLine" Width="98%" CssClass="TextBox" Enabled="False"></asp:TextBox></td>
            </tr>
            
        </table>
            <table width="776">
                <tr>
                    <td style="height: auto; width: 83px;">
                        <asp:Button ID="btnListar" runat="server" Text="Listar" CssClass="ButtonBlue11px" OnClick="btnListar_Click" /></td>
                    <td style="height: auto; width: 77px;">
                        <asp:Button ID="btnAgregar" runat="server" Text="Agregar" CssClass="ButtonBlue11px" OnClick="btnAgregar_Click" /></td>
                    <td style="height: auto; width: 81px;">
                        <asp:Button ID="btnModificar" runat="server" Text="Modificar" CssClass="ButtonBlue11px" OnClick="btnModificar_Click" /></td>                    <td style="height: 26px; width: 79px;">
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="ButtonBlue11px" OnClick="btnEliminar_Click" /></td>                    <td style="height: 26px; width: 80px;">
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" CssClass="ButtonBlue11px" Enabled="False" OnClick="btnCancelar_Click" /></td>                    <td style="height: 26px; width: 83px;">
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" CssClass="ButtonBlue11px" Enabled="False" OnClick="btnGuardar_Click" /></td>                    <td style="height: 26px; width: 83px;">
                        <asp:Button ID="btnSalir" runat="server" Text="Salir" CssClass="ButtonBlue11px" OnClick="btnSalir_Click" /></td>                    <td style="width: 6px; height: 26px;">
                        <asp:Button ID="btnPrimero" runat="server" Text="<<" CssClass="ButtonBlue11px" Width="32px" OnClick="btnPrimero_Click" /></td>                    <td style="height: 26px; width: 33px;">
                        <asp:Button ID="btnAnterior" runat="server" Text="<" CssClass="ButtonBlue11px" Width="32px" OnClick="btnAnterior_Click" /></td>
                    <td style="height: auto; width: 23px;">
                        <asp:Button ID="btnSiguiente" runat="server" Text=">" CssClass="ButtonBlue11px" Width="32px" OnClick="btnSiguiente_Click1" /></td>
                    <td style="height: auto; width: 28px;">
                        <asp:Button ID="btnUltimo" runat="server" Text=">>" CssClass="ButtonBlue11px" Width="32px" OnClick="btnUltimo_Click" /></td>
                </tr>
            </table>
    </form>   
</body>
</html>
