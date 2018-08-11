<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ucFechaDdFechaHh.ascx.cs" Inherits="webUserControl_ucFechaDdFechaHh" %>

<%@ Register Assembly="eWorld.UI" Namespace="eWorld.UI" TagPrefix="ew" %>

<table id="tblCustom" style="width: 319px; height: 12px">
<tr>
    <td style="width: 177px">
        <asp:Label ID="lblFechaDesde" runat="server" Text="Fecha Desde" CssClass="lblBoldUpperXXS"></asp:Label></td>
<td style="width: 243px">
    <ew:CalendarPopup ID="calendarDesde" runat ="server" culture="Spanish (Argentina)" width="132px" cssClass="TextBox"></ew:CalendarPopup>
</td>
</tr>
    <tr>
        <td style="width: 177px">
            <asp:Label ID="lblFechaHasta" runat="server" Text="Fecha Hasta" CssClass="lblBoldUpperXXS"></asp:Label></td>
        <td style="width: 243px">
            <ew:CalendarPopup ID="calendarHasta" runat ="server" Culture="Spanish (Argentina)" Width="132px" CssClass="TextBox">
            </ew:CalendarPopup>
        </td>
    </tr>
</table>