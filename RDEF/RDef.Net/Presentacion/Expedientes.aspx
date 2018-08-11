<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Expedientes.aspx.cs" Inherits="Expedientes" EnableViewState="true" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=8.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"
    Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Defensor del Pueblo - Vicente Lopez</title>
    <link href="../styles.css" type="text/css" rel="stylesheet"/>
    <base target="_self"/>
    <script type="text/javascript">
    
        function chkTraeDoc_OnClick()
        {
            if(document.getElementById("chkDocumentacion").checked)
                document.getElementById("txtDetalleDocumentacion").disabled = false;
            else
            {
                document.getElementById("txtDetalleDocumentacion").value = '';
                document.getElementById("txtDetalleDocumentacion").disabled = true;
            }
        }
    
    
        function mostrarDeseaHacer(){               
            
            document.getElementById("hNavegarBusqDenunciantes").value = "false";
            if(confirm('DNI inexistente. ¿Buscar mediante otros datos?'))
                 document.getElementById("hNavegarBusqDenunciantes").value = "true";
               
            document.forms[0].submit();
        }
    
        function seleccionarTabDenunciante(){
            document.getElementById("divDenunciante").style.display = "block";
            document.getElementById("divDenuncia").style.display = "none";
            document.getElementById("lblDenunciante").className = "lblGray11pxSel";
            document.getElementById("lblDenuncia").className = "lblGray11px";
        }
        
        function seleccionarTabDenuncia(){
            document.getElementById("divDenuncia").style.display = "block";
            document.getElementById("divDenunciante").style.display = "none";
            document.getElementById("lblDenunciante").className = "lblGray11px";
            document.getElementById("lblDenuncia").className = "lblGray11pxSel";
        }      
        
        function limpiarCampos(){
        
                document.getElementById("txtApellido").value = '';                
                document.getElementById("txtNombres").value = '';                
                document.getElementById("txtCalle").value = '';                
                document.getElementById("txtNro").value = '';                
                document.getElementById("txtPiso").value = '';                
                document.getElementById("txtDpto").value = '';                              
                document.getElementById("cboTipoDni").selectedIndex = 0;                                               
                document.getElementById("txtNroDNI").value = '';                
                document.getElementById("cboLocalidad").selectedIndex = 0;                
                document.getElementById("txtTelefono").value = '';                
                document.getElementById("txtOtraLoc").value = '';
                document.getElementById("txtCelular").value = '';             
                document.getElementById("txtEmail").value = ''; 
                
                
                //div Denuncia
                
                document.getElementById("cboEntDenunciada").selectedIndex = 0;                
                document.getElementById("cboArea").selectedIndex = 0;                
                document.getElementById("cboTipoDenuncia").selectedIndex = 0;                               
                document.getElementById("chkDocumentacion").checked = false;                
                document.getElementById("txtDetalleDocumentacion").value = '';             
                document.getElementById("txtDetalleDenuncia").value = ''; 
                document.getElementById("lblApellido").innerText = ''; 
                document.getElementById("lblNombres").innerText = ''; 
                document.getElementById("lblTelefono").innerText = ''; 
            
               
        }
        
        
        function habilitarCampos(valor){        
                        
                                  
                //habilitar los campos del div denunciante                                
                document.getElementById("txtApellido").disabled = !valor;                
                document.getElementById("txtNombres").disabled = !valor;                
                document.getElementById("txtCalle").disabled = !valor;                
                document.getElementById("txtNro").disabled = !valor;                
                document.getElementById("txtPiso").disabled = !valor;                
                document.getElementById("txtDpto").disabled = !valor;                
                document.getElementById("cboTipoDni").disabled = !valor;                                               
                document.getElementById("txtNroDNI").disabled = !valor;                
                document.getElementById("cboLocalidad").disabled = !valor;                
                document.getElementById("txtTelefono").disabled = !valor;                
                document.getElementById("txtOtraLoc").disabled = !valor;
                document.getElementById("txtCelular").disabled = !valor;             
                document.getElementById("txtEmail").disabled = !valor; 
                
                document.getElementById("imgBuscarDen").disabled = !valor; 
                document.getElementById("imgBuscarLoc").disabled = !valor; 
                
                //div Denuncia
                
                document.getElementById("cboEntDenunciada").disabled = !valor;                
                document.getElementById("cboArea").disabled = !valor;                
                document.getElementById("cboTipoDenuncia").disabled = !valor;                               
                document.getElementById("chkDocumentacion").disabled = !valor;                
                document.getElementById("txtDetalleDocumentacion").disabled = !valor;             
                document.getElementById("txtDetalleDenuncia").disabled = !valor; 
                
                  
                //document.getElementById("btnCancelar").disabled = !valor;                          
                
//                if(valor == false)
//                {
//                    document.getElementById("btnCancelar").className = "ButtonBlue11px";
//                }
//                else
//                {
//                    document.getElementById("btnCancelar").className = "ButtonBlue11px";
//                     document.getElementById("txtApellido").focus();
//                }
                    
                                
            
            return true;      
        }
        
        function cerrarVentana(){   
           // window.opener = "";
            window.close();            
        }  
        
		function desabilitarTodo()
		{
			for (i=0;i<document.forms[0].elements.length;i++) 
			{
				if (document.forms[0].elements[i].name != "__VIEWSTATE" && document.forms[0].elements[i].name != "btnNuevo")
					document.forms[0].elements[i].disabled = true;
			}
		}
		
			function AbrirPopupLocalidades()
			{
				var propiedades ="dialogHeight:500px;" +  "dialogWidth:650px;" + "dialogTop: 20px;" + "dialogLeft: 20px;"
				propiedades += "center:yes; edge:raised; help:no; resizable:no; scroll:yes; status:no; "; 					
				var respuesta = window.showModalDialog("Localidades.aspx","",propiedades); 
				if(respuesta != null)
				    document.getElementById("hOtraLoc").value = respuesta;
				
				document.forms[0].submit();
			}
			
			function AbrirPopupContactos(idDen)
			{
				var propiedades ="dialogHeight:460px;" +  "dialogWidth:550px;" + "dialogTop: 20px;" + "dialogLeft: 20px;"
				propiedades += "center:yes; edge:raised; help:no; resizable:no; scroll:yes; status:no; "; 					
				var respuesta = window.showModalDialog("Contactos.aspx?idDenunciante="+idDen,"",propiedades); 
//				if(respuesta != null) 
//				{	
//				
//    				var obj = respuesta.split("|");
//    				var tel =  obj[0];//.split("/");
//    				var cel =  obj[1];
//    				var mail = obj[2];
//    				
//				    if(tel[1] != "")//si es distinto me activaron un tel nuevo
//				    {
//				        alert('pasa por aca');
//					    document.getElementById('txtTelefono').value = tel[1];
//			    	    document.getElementById('lblTelefono').innerText = tel[1];
//	        		}
//	        		else//si es vacio, o me lo dejaron intacto, o me eliminaron el activo
//	        		{
//	        		    if(tel[0] == "")//si es vacio, no hay activos
//	        		    {
//	        		    alert('o pasa por aca?');
//       					    document.getElementById('txtTelefono').value = tel[1];
//	    		    	    document.getElementById('lblTelefono').innerText = tel[1];
//	    		    	}
//	        		}
//	        		
//	        		
//	        		if(cel != "")
//				    {
//					    document.getElementById('txtCelular').value = cel;			    	    
//	        		}
//				    if(mail != "")
//				    {
//					    document.getElementById('txtEmail').value = mail;			    	    
//	        		}	        		
//    			}
                document.forms[0].submit();
			}			
			
			
		
			function AbrirPopupDenunciantes()
			{
			
				var propiedades ="dialogHeight:450px;" +  "dialogWidth:730px;" + "dialogTop: 0px;" + "dialogLeft: 0px;"
				propiedades += "center:yes; edge:raised; help:no; resizable:no; scroll:yes; status:no; "; 					
				var respuesta = window.showModalDialog("ListadoDenunciantes.aspx","",propiedades); 
//				while (respuesta == null) 
//				{
//					respuesta = window.showModalDialog("Errores.aspx?error=Hola","",propiedades);
//				}					
				
				
				document.forms[0].submit();
			}			
			
			function cboLocalidad_SelectedIndexChange()
			{
			    //var indice =  document.getElementById('cboLocalidad').selectedIndex;
			    //var valor = document.getElementById('cboLocalidad').options[indice].value;
			    document.getElementById('hOtraLoc').value = "";
			    document.getElementById('txtOtraLoc').value = "";
			}	
		
		    function validarIngresos()
		    {
		        
		        if(document.getElementById("txtApellido").value == '')
		        {
		            alert('Apellido obligatorio');   
		            return false;
		        }
		        
                if(document.getElementById("txtNombres").value == '')
                {
                    alert('Nombre obligatorio');
                    return false;
                }
                
                if(document.getElementById("txtCalle").value == '')
                {
                    alert('Calle obligatoria');
                    return false;
                }
                
                if(document.getElementById("txtNro").value == '') 
                {
                    alert('Nro de Calle obligatorio');
                    return false;
                }
                
                if(document.getElementById("txtNroDNI").value == '') 
                {
                    alert('DNI obligatorio');
                    return false;
                }                

                if(document.getElementById("cboLocalidad").options[document.getElementById("cboLocalidad").selectedIndex].value == "0")
                {
                    if(document.getElementById("txtOtraLoc").value == '')
                    {
                        alert('Localidad obligatorio');
                        return false;
                    }                    
                }                
                if(document.getElementById("chkDocumentacion").checked)
                {
                    if(document.getElementById('txtDetalleDocumentacion').value == '')
                    {
                        alert('Ingrese una descripcion de la documentacion recibida.');
                        return false;
                    }
                }
                
                if(document.getElementById('cboEntDenunciada').selectedIndex == 0)
                {
                    alert('Debe Seleccionar la Entidad Denunciada.');
                    return false;
                }
                
                if(document.getElementById('cboTipoDenuncia').selectedIndex == 0)
                {
                    alert('Debe Seleccionar el Tipo de Denuncia.');
                    return false;
                }
                
                if(document.getElementById('txtDetalleDenuncia').value == "")
                {
                    alert('Debe Ingresar un detalle de la Denuncia generada.');
                    return false;
                }
                if(document.getElementById('cboAtendio').selectedIndex == 0)
                {
                    alert('Debe Seleccionar la Persona que creó/atendio el expediente.');
                    return false;
                }                
                
                
                return true;
		    }
		    
		    function cboEntDenunciada_SelectedIndexChange()
		    {		    
		        if(document.getElementById('cboEntDenunciada').options[document.getElementById('cboEntDenunciada').selectedIndex].text == "MVL")
		        {
		            document.getElementById('cboArea').disabled = false;
		        }
		        else
		        {
		            document.getElementById('cboArea').disabled = true;		        
		        }
		    }

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>   
            <table style="width: 712px; height: 40px" border="0" id="tblCabecera">
                <tr>
                    <td style="width: 85px; height: 34px">
                         <asp:Label ID="lbl" runat="server" Text="Nro Expediente: " Width="96px" CssClass="lblBoldUpperXXS"></asp:Label></td>
                    <td style="width: 45px; height: 34px">
                         <asp:Label ID="lblNroExpediente" runat="server" Text="0" Width="72px" CssClass="lblBoldUpperXXS"></asp:Label></td>
                    <td style="width: 93px; height: 34px; text-align: right;">
                         <asp:Label ID="Label1" runat="server" Text="Fecha Ingreso: " CssClass="lblBoldUpperXXS" Height="16px" Width="88px"></asp:Label></td>
                    <td style="width: 99px; height: 34px; text-align: right">
                         <asp:Label ID="lblFechaIngreso" runat="server" CssClass="lblBoldUpperXXS"></asp:Label></td>
                    <td style="width: 99px; height: 34px; text-align: right;">
                         <asp:Label ID="Label3" runat="server" Text="Fecha Archivo: " CssClass="lblBoldUpperXXS"></asp:Label>
                         </td>
                    <td style="width: 163px; height: 34px; text-align: right">
                         <asp:Label ID="lblFechaArchivo" runat="server" CssClass="lblBoldUpperXXS"></asp:Label></td>
                </tr>
                <tr>
                    <td style="width: 85px; height: 39px;">
                        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
                        <asp:Label ID="Label2" runat="server" Text="Atendio: " CssClass="lblBoldUpperXXS"></asp:Label></td>
                    <td style="width: 45px; height: 39px">
                         <asp:DropDownList ID="cboAtendio" runat="server" Width="128px" CssClass="ComboBox" Enabled="False">
                         </asp:DropDownList></td>
                    <td style="width: 93px; height: 39px;">
                        &nbsp; &nbsp;&nbsp;
                         <asp:Label ID="Label4" runat="server" Text="Informante: " CssClass="lblBoldUpperXXS"></asp:Label></td>
                    <td style="width: 99px; height: 39px">
                         <asp:DropDownList ID="cboInformante" runat="server" Width="104px" CssClass="ComboBox" Enabled="False">
                         </asp:DropDownList></td>
                    <td style="width: 99px; text-align: right; height: 39px;" align="left">
                         <asp:Label ID="Label6" runat="server" Text="Estado: " CssClass="lblBoldUpperXXS"></asp:Label>
                         </td>
                    <td align="left" style="width: 163px; height: 39px; text-align: right">
                         <asp:Label ID="lblEstado" runat="server" CssClass="lblBoldUpperXXS"></asp:Label></td>
                    </tr>
           </table>    
           <table style="width: 712px; height: 40px" border="0" id="tblTabs">
            <tr>
                <td style="width: 716px; height: 30px;">                    
                    <asp:Label ID="lblDenunciante" runat="server" CssClass="lblGray11pxSel" Text="INICIADOR"
                        Width="160px"></asp:Label>
                    <asp:Label ID="lblDenuncia" runat="server" CssClass="lblGray11px" Text="DENUNCIA"
                        Width="160px"></asp:Label>
                </td>
                <td align="right" style="width: 716px; height: 30px">
                         <asp:Button ID="btnMovimientos" runat="server" Text="Movimientos" Width="88px" CssClass="ButtonBlue11pxDisable" Enabled="False" OnClick="btnMovimientos_Click" /></td>
            </tr>
            </table>
            <div id="divDenunciante" style="display:block">
                <table id="tblDivDenunciante" runat="server">
                <tr>
                    <td id="tdDenunciante" style="width: 707px; height: 330px">
                            <table id="tblDenunciante" style="width: 707px; height: 330px;" >
                                <tr>
                                    <td style="width:115px; height:auto">
                                        <asp:Label ID="Label5" runat="server" Text="Apellido: " CssClass="lblBoldUpperXXS"></asp:Label></td>
                                    <td style="width:416px; height:auto">
                                        <asp:TextBox ID="txtApellido" runat="server" CssClass="TextBoxLetrasMay" Enabled="False" MaxLength="30"></asp:TextBox></td>                                    
                                    <td style="width: 110px; height: auto">
                                        <asp:Label ID="Label10" runat="server" Text="Nombres: " CssClass="lblBoldUpperXXS"></asp:Label></td>
                                    <td style="width: 309px; height: auto">
                                        <asp:TextBox ID="txtNombres" runat="server" Width="224px" CssClass="TextBoxLetras" Enabled="False" MaxLength="30"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width: 115px; height: 15px">
                                        <asp:Label ID="Label8" runat="server" Text="Nro Doc: " CssClass="lblBoldUpperXXS"></asp:Label></td>
                                    <td style="width: 416px; height: 15px">
                                        <asp:DropDownList ID="cboTipoDni" runat="server" Width="80px" CssClass="ComboBox" Enabled="False">
                                        </asp:DropDownList>
                                        <asp:TextBox ID="txtNroDNI" runat="server" Width="104px" CssClass="TextBoxNumero" Enabled="False" MaxLength="8"></asp:TextBox>
                                        <asp:ImageButton ID="imgBuscarDen" runat="server" ImageUrl="~/Imagenes/Buscar.gif" OnClick="imgBuscarDen_Click" ToolTip="Ingrese el Nro de Documento del denunciante y haga click aquí." Enabled="False"   /></td>
                                    <td colspan="2" style="height: 15px">
                                    </td>
                                </tr>
                                <tr>
                                    <td style="width:115px; height:auto">
                                        <asp:Label ID="Label7" runat="server" Text="Calle: " CssClass="lblBoldUpperXXS"></asp:Label></td>
                                    <td style="width:416px; height:auto">
                                        <asp:TextBox ID="txtCalle" runat="server" CssClass="TextBoxAlfaNumerico" Enabled="False" MaxLength="50" Width="168px"></asp:TextBox></td> 
                                    <td style="width: 110px; height: auto">
                                        <asp:Label ID="Label15" runat="server" Text="Nro Calle: " CssClass="lblBoldUpperXXS"></asp:Label></td>
                                    <td style="width: 309px; height: auto">
                                        <asp:TextBox ID="txtNro" runat="server" Width="64px" CssClass="TextBoxNumero" Enabled="False" MaxLength="4"></asp:TextBox>
                                        <asp:Label ID="Label16" runat="server" Text="Piso:      " Width="40px" CssClass="lblBoldUpperXXS"></asp:Label>
                                        <asp:TextBox ID="txtPiso" runat="server" Width="40px" CssClass="TextBoxNumero" Enabled="False" MaxLength="2"></asp:TextBox>
                                        <asp:Label ID="Label17" runat="server" Text="Dpto: " Width="32px" CssClass="lblBoldUpperXXS"></asp:Label>
                                        <asp:TextBox ID="txtDpto" runat="server" Width="48px" CssClass="TextBoxAlfaNumerico" Enabled="False" MaxLength="2"></asp:TextBox></td>

                                </tr>  
                               <tr>
                                    <td style="width:115px; height:auto">
                                       <asp:Label ID="Label11" runat="server" Text="Localidad: " CssClass="lblBoldUpperXXS"></asp:Label></td>
                                    <td style="width:416px; height:auto">
                                        <asp:DropDownList ID="cboLocalidad" runat="server" Width="152px" CssClass="ComboBox" Enabled="False">
                                       </asp:DropDownList></td> 
                                   <td style="width: 110px; height: auto">
                                       <asp:Label ID="Label13" runat="server" Text="Otra Loc: " CssClass="lblBoldUpperXXS"></asp:Label></td>
                                   <td style="width: 309px; height: auto">
                                       <asp:TextBox ID="txtOtraLoc" runat="server" CssClass="TextBox" Enabled="False"></asp:TextBox>
                                        <asp:ImageButton ID="imgBuscarLoc" runat="server" ImageUrl="~/Imagenes/Buscar.gif" Enabled="False" OnClick="imgBuscarLoc_Click" />  
                                   </td>                                     
                                </tr>
                                <tr>
                                    <td style="width: 115px; height: auto">
                                        <asp:Label ID="Label9" runat="server" CssClass="lblBoldUpperXXS" Text="Telefono Particular: "></asp:Label></td>
                                    <td style="width: 416px; height: auto">
                                        <asp:TextBox ID="txtTelefono" CssClass="TextBoxTelefono" runat="server" Width="168px" Enabled="False" MaxLength="100"></asp:TextBox>
                                        </td>
                                    <td style="width: 110px; height: auto">
                                        <asp:Label ID="Label12" runat="server" CssClass="lblBoldUpperXXS" Text="Celular: "></asp:Label></td>
                                    <td style="width: 309px; height: auto">
                                        <asp:TextBox ID="txtCelular" CssClass="TextBoxTelefono" runat="server" Enabled="False" MaxLength="100"></asp:TextBox>
                                        </td>
                                </tr>
                               <tr>
                                    <td style="width:115px; height:auto">
                                        <asp:Label ID="Label14" runat="server" CssClass="lblBoldUpperXXS" Text="Email: "></asp:Label></td>
                                   <td colspan="3" style="height: auto">
                                       <asp:TextBox ID="txtEmail" CssClass="TextBox" runat="server" Width="336px" Enabled="False" MaxLength="100"></asp:TextBox>
                                       &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
                                        <asp:Button ID="btnADMCont" runat="server" Text="Administrar Contactos" OnClick="btnOtroTel_Click" CssClass="ButtonBlue11px" Width="176px" /></td>
                                </tr>
                            </table>
                    
                    </td>
                </tr>
                </table>
            </div>  
            <div id="divDenuncia" style="display:none">
                <table id="tblDivDenuncia">
                     <tr>
                        <td id="tdDenuncia" style="width: 707px; height: 330px;">
                            <table id="tblDenuncia" style="width: 707px; height: 330px;" border="0">
                                <tr>
                                    <td style="width:250px; height:auto">
                                        &nbsp;<asp:Label ID="lblApellido" runat="server" Font-Bold="True" CssClass="etiquetas"></asp:Label></td>
                                    <td style="width:250px; height:auto">
                                        <asp:Label ID="lblNombres" runat="server" Font-Bold="True" CssClass="etiquetas"></asp:Label></td>                                    
                                    <td style="width: auto; height: auto">
                                        <asp:Label ID="lblTelefono" runat="server" Font-Bold="True" CssClass="etiquetas"></asp:Label></td>
                                </tr>
                                <tr>
                                    <td style="width:250px; height:auto">
                                        <asp:Label ID="Label18" runat="server" Text="Entidad Denunciada: " CssClass="lblBoldUpperXXS"></asp:Label>
                                        <asp:DropDownList ID="cboEntDenunciada" runat="server" Width="104px" Enabled="False" CssClass="ComboBox">
                                        </asp:DropDownList></td>
                                    <td style="width:250px; height:auto">
                                        &nbsp;<asp:Label ID="Label19" runat="server" Text="Area: " CssClass="lblBoldUpperXXS"></asp:Label>
                                        <asp:DropDownList ID="cboArea" runat="server" Enabled="False" CssClass="ComboBox">
                                        </asp:DropDownList>
                                    </td> 
                                    <td style="width: auto; height: auto">
                                        <asp:Label ID="Label20" runat="server" Text="Tipo Denuncia: " CssClass="lblBoldUpperXXS"></asp:Label>
                                        <asp:DropDownList ID="cboTipoDenuncia" runat="server" Enabled="False" CssClass="ComboBox">
                                        </asp:DropDownList></td>
                                </tr>  
                               <tr>
                                    <td style="width:250px; height:auto">
                                        &nbsp;&nbsp;
                                        <asp:Label ID="Label22" runat="server" CssClass="lblBoldUpperXXS" Text="¿Acompaña Documentacion?"></asp:Label>
                                        <input id="chkDocumentacion" disabled="disabled" type="checkbox" runat="server" /></td>
                                   <td colspan="2" style="height: auto">
                                       <asp:TextBox ID="txtDetalleDocumentacion" runat="server" TextMode="MultiLine" Width="432px" Enabled="False" CssClass="TextBoxAlfaNumerico"></asp:TextBox></td>
                                </tr>
                                <tr>
                                    <td style="width:250px; height:auto">
                                        <asp:Label ID="Label21" runat="server" Text="Detalle de la Denuncia: " CssClass="lblBoldUpperXXS"></asp:Label></td>
                                    <td style="width:250px; height:auto">
                                    </td> 
                                    <td style="width: auto; height: auto">
                                    </td>
                                </tr>  
                               <tr>
                                   <td colspan="3" rowspan="2">
                                       <asp:TextBox ID="txtDetalleDenuncia" runat="server" Height="56px" TextMode="MultiLine"
                                           Width="672px" Enabled="False" CssClass="TextBoxAlfaNumerico"></asp:TextBox></td>
                                </tr>
                                <tr>
                                </tr>                                                                                                
                            </table>
                        </td>
                            
                    </tr>
                </table>
            </div> 
            <table style="width: 712px; height: 16px" border="0" id="tblBotonera">
                <tr>
                    <td style="height: 12px">
                        <asp:Button ID="btnNuevo" runat="server" Text="Nuevo" Width="72px" Enabled="true" CssClass="ButtonBlue11px" OnClick="btnNuevo_Click" />
                    </td>
                    <td style="height: 12px">
                        <asp:Button ID="btnModificar" runat="server" Text="Modificar" Width="72px" Enabled="False" CssClass="ButtonBlue11pxDisable" OnClick="btnModificar_Click" />
                    </td>
                    <td style="height: 12px">
                        <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Width="72px" Enabled="false" CssClass="ButtonBlue11pxDisable" />
                    </td>
                    <td style="height: 12px">
                        <asp:Button ID="btnCancelar" runat="server" Text="Cancelar" Enabled="false" Width="72px" CssClass="ButtonBlue11pxDisable" OnClick="btnCancelar_Click" />
                    </td>
                    <td style="height: 12px">
                        <asp:Button ID="btnGuardar" runat="server" Text="Guardar" Enabled="false" Width="72px" CssClass="ButtonBlue11pxDisable" OnClick="btnGuardar_Click" />
                    </td>
                    <td style="height: 12px">
                        <asp:Button ID="btnBuscar" runat="server" Text="Buscar" Enabled="true" Width="72px" CssClass="ButtonBlue11px" OnClick="btnBuscar_Click" /></td>
                    <td style="height: 12px; text-align: right;">
                        <asp:Button ID="btnSalir" runat="server" Text="Salir" Enabled="true" Width="72px" CssClass="ButtonBlue11px" OnClick="btnSalir_Click"/></td>
                    <td style="height: 12px; text-align: right">
                        <asp:Button ID="btnPrimero" runat="server" CssClass="ButtonBlue11px" OnClick="btnPrimero_Click"
                        Text="<<" Width="32px" /></td>
                    <td style="height: 12px; text-align: right">
                    <asp:Button ID="btnAnterior" runat="server" CssClass="ButtonBlue11px" OnClick="btnAnterior_Click"
                        Text="<" Width="32px" /></td>
                    <td style="height: 12px; text-align: right">
                    <asp:Button ID="btnSiguiente" runat="server" CssClass="ButtonBlue11px" OnClick="btnSiguiente_Click"
                        Text=">" Width="32px" /></td>
                    <td style="height: 12px; text-align: right">
                    <asp:Button ID="btnUltimo" runat="server" CssClass="ButtonBlue11px" OnClick="btnUltimo_Click"
                        Text=">>" Width="32px" /></td>
                </tr>
            </table>
            <input type="hidden" id="hNavegarBusqDenunciantes" runat="server" style="width: 1px; height: 1px"/>
            <input type="hidden" id="hOtraLoc" runat="server" style="width: 1px; height: 1px"/>&nbsp;
            
    </div>
    </form>
</body>
</html>
