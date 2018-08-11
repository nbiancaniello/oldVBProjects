<%@ page language="C#" autoeventwireup="true" inherits="Presentacion_consultasPorInformantes, App_Web_r2qjsibb" enableEventValidation="false" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Consultas Por Informantes</title>
    <link href="../Styles.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListBox ID="Lista" runat="server" Height="104px" Style="left: 504px; position: absolute;
            top: 64px" Width="176px" CssClass="ComboBox" Rows="10"></asp:ListBox>
        <asp:RadioButtonList ID="RbLista" runat="server" Style="left: 544px; position: absolute;
            top: 208px" CssClass="lblBoldUpperXXS">
            <asp:ListItem Selected="True">Todos</asp:ListItem>
            <asp:ListItem>Archivados</asp:ListItem>
            <asp:ListItem>Sin archivar</asp:ListItem>
        </asp:RadioButtonList>
        <asp:Label ID="Label1" runat="server" Style="left: 504px; position: absolute; top: 32px"
            Text="Informantes" Width="168px" CssClass="lblGray11pxSel"></asp:Label>
        <asp:Label ID="Label2" runat="server" Style="left: 504px; position: absolute; top: 184px"
            Text="Estado de Expedientes" Width="168px" CssClass="lblGray11pxSel"></asp:Label>
        <asp:Button ID="btnInformantes" runat="server" Style="left: 392px; position: absolute;
            top: 296px" TabIndex="1" Text="Mostar por informantes" Width="192px" OnClick="btnInformantes_Click" CssClass="ButtonBlue11px" />
        <asp:GridView ID="tabla" runat="server" AllowPaging="True" AutoGenerateColumns="False"
            BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px"
            CellPadding="3" GridLines="Horizontal" Height="48px" HorizontalAlign="Center"
            PageSize="9" Style="left: 224px; position: absolute; top: 328px" Width="776px" CssClass="ComboBox" OnPageIndexChanging="tabla_PageIndexChanging" >
            <RowStyle BackColor="#E7E7FF" BorderColor="Red" ForeColor="#4A3C8C" Height="5px"
                HorizontalAlign="Center" />
            <Columns>
                <asp:HyperLinkField DataNavigateUrlFields="idExpediente" DataNavigateUrlFormatString="DetallesConsultasPorInformante.aspx?idExpediente={0}"
                    Text="Ver Detalle">
                    <ControlStyle Width="100px" />
                </asp:HyperLinkField>
                <asp:HyperLinkField DataNavigateUrlFields="idExpediente" Text="Movimientos" DataNavigateUrlFormatString="ListarMovimientos.aspx?idExpediente={0}" />
                <asp:BoundField DataField="idExpediente" HeaderText="Expediente" />
                <asp:BoundField DataField="nombre" HeaderText="Nombre Denunciante" />
                <asp:BoundField DataField="apellido" HeaderText="Apellido Denunciante" />
                <asp:BoundField DataField="entidad" HeaderText="Entidad Denunciada" />
                <asp:BoundField DataField="fechaIngreso" HeaderText="Fecha Ingreso" />
                <asp:BoundField DataField="fechaArchivo" HeaderText="Fecha Archivo" />
                <asp:BoundField DataField="ultMovimiento" HeaderText="Ultimo Movimiento" />
            </Columns>
            <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C" />
            <PagerStyle BackColor="#E7E7FF" ForeColor="#4A3C8C" HorizontalAlign="Center" />
            <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7" />
            <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7" />
            <AlternatingRowStyle BackColor="#F7F7F7" />
        </asp:GridView>
        <asp:Button ID="btnPaseInterno" runat="server" Style="left: 432px; position: absolute;
            top: 576px" Text="Solo Pase Interno" OnClick="btnPaseInterno_Click" CssClass="ButtonBlue11px" Width="136px" />
        <asp:Button ID="btnUltMovimiento" runat="server" Style="left: 640px; position: absolute;
            top: 576px" Text="Ultimo Movimiento" OnClick="btnUltMovimiento_Click" CssClass="ButtonBlue11px" Width="152px" />
        <asp:Button ID="btnTodos" runat="server" Style="left: 624px; position: absolute;
            top: 296px" Text="Mostrar todos" Width="176px" OnClick="btnTodos_Click" CssClass="ButtonBlue11px" />
        &nbsp;
        <asp:Button ID="btnVolver" runat="server" CssClass="ButtonBlue11px" OnClick="Button1_Click"
            Style="left: 224px; position: absolute; top: 32px" Text="Volver" Width="112px" />
    
    </div>
    </form>
</body>
</html>
