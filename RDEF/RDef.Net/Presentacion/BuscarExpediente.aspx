<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BuscarExpediente.aspx.cs" ValidateRequest="false" Inherits="BuscarExpediente" %>

<%@ Register Src="webUserControl/ModuloExpedientes/ucBusquedaExpediente.ascx" TagName="ucBusquedaExpediente"
    TagPrefix="uc1" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Buscar Expediente</title>
    <link href="../styles.css" type="text/css" rel="stylesheet"/>    
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:ucBusquedaExpediente ID="UcBusquedaExpediente1" runat="server" />
    
    </div>
    </form>
</body>
</html>