using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Collections.Generic;
using Negocio;
using Entidades;


public partial class Expedientes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            this.lblDenuncia.Attributes.Add("onclick", "seleccionarTabDenuncia();");
            this.lblDenunciante.Attributes.Add("onclick", "seleccionarTabDenunciante();");
            this.btnNuevo.Attributes.Add("onclick", "limpiarCampos();return habilitarCampos(true);");
            this.btnCancelar.Attributes.Add("onclick", "return habilitarCampos(false)");
            //this.imgBuscarLoc.Attributes.Add("onclick", "return AbrirPopupLocalidades();");
            this.chkDocumentacion.Attributes.Add("onClick", "chkTraeDoc_OnClick()");
            // this.imgPopupContactos.Attributes.Add("onclick", "AbrirPopupContactos();");
            this.cboLocalidad.Attributes.Add("onChange", "return cboLocalidad_SelectedIndexChange();");
            this.btnGuardar.Attributes.Add("onClick", "return validarIngresos();");
            this.cboEntDenunciada.Attributes.Add("onChange", "cboEntDenunciada_SelectedIndexChange();");



            if (!this.IsPostBack)
            {
                this.CargarCombosInformante();
                this.CargarComboTiposDocumento();
                this.CargarComboLocalidades();
                this.CargarComboEntidades();
                this.CargarComboAreas();
                this.CargarComboTiposDenuncia();


                Expediente expediente = TraerExpedienteSession();

                if (expediente == null)
                {
                    expediente = NegocioExpedientes.TraerExpedienteCompletoPorIdExpediente(1);
                    GuardarExpedienteSession(expediente);
                }
                if (expediente != null)
                {
                    SetearControlesExpediente(expediente);
                    this.btnModificar.Enabled = true;
                    this.btnModificar.CssClass = "ButtonBlue11px";
                }
            }
            else
            {
                //evaluo respuesta de usuario..
                if (hNavegarBusqDenunciantes.Value == "true")
                {
                    Session.Add("EsPopup", 1);
                    AbrirPopupDenunciantes();
                    hNavegarBusqDenunciantes.Value = "";
                }
                else if (hNavegarBusqDenunciantes.Value == "false")
                {
                    ReestablecerEstado();
                    hNavegarBusqDenunciantes.Value = "";
                }

                Denunciante denunciante = TraerDenuncianteSession();

                int esPopup = Session["EsPopup"] != null ? int.Parse(Session["EsPopup"].ToString()) : 0;
                if (denunciante != null && esPopup == 1)
                {
                    SetearControlesDenunciante(denunciante);
                    //HabilitarDesHabilitarControlesDenunciante(false);
                    this.imgBuscarDen.Enabled = true;
                    Session["EsPopup"] = 0;
                }

                if (hOtraLoc.Value != "")
                {
                    this.txtOtraLoc.Text = hOtraLoc.Value.Split('|')[1].ToString();
                    this.cboLocalidad.SelectedValue = "0";
                }
                else
                {
                    this.txtOtraLoc.Text = "";
                }

                int PopupContactos = Session["PopupContactos"] != null ? int.Parse(Session["PopupContactos"].ToString()) : 0;
                if (PopupContactos == 1 && denunciante != null)
                {
                    txtTelefono.Text = NegocioContactos.TraerTelefonoActivo(denunciante.idDenunciante);
                    lblTelefono.Text = txtTelefono.Text;
                    txtCelular.Text = NegocioContactos.TraerCelularActivo(denunciante.idDenunciante);
                    txtEmail.Text = NegocioContactos.TraerMailActivo(denunciante.idDenunciante);
                    Session.Add("PopupContactos",0);
                }
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message.ToString());
        }
    }


    private void ReestablecerEstado()
    {
        try
        {
            string str = "<script type=\"text/javascript\">";
            if (this.lblNroExpediente.Text == "0")
            {
                str = str + "document.getElementById('btnNuevo').click();";
                str = str + "</script>";
                Page.ClientScript.RegisterStartupScript(Page.ClientScript.GetType(), "ForzarNuevo", str);
            }
            else
            {
                str = str + "document.getElementById('btnModificar').click();";
                str = str + "</script>";
                Page.ClientScript.RegisterStartupScript(Page.ClientScript.GetType(), "ForzarModificar", str);
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message.ToString());
        }
    }


    private void CargarCombosInformante()
    {
        try
        {
            DataSet ListPersonas = NegocioMantenimiento.TraerPersonas();
            this.cboAtendio.DataSource = ListPersonas;
            this.cboAtendio.DataValueField = "idPersona";
            this.cboAtendio.DataTextField = "nombre";

            this.cboAtendio.DataBind();
            this.cboAtendio.Items.Insert(0, "Sin Seleccionar");
            this.cboAtendio.Items[0].Value = "0";

            this.cboInformante.DataSource = ListPersonas;
            this.cboInformante.DataValueField = "idPersona";
            this.cboInformante.DataTextField = "nombre";


            this.cboInformante.DataBind();
            this.cboInformante.Items.Insert(0, "Sin Seleccionar");
            this.cboInformante.Items[0].Value = "0";


        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void CargarComboTiposDocumento()
    {
        try
        {
            DataSet dsTiposDoc = NegocioMantenimiento.TraerTiposDocumentos();
            this.cboTipoDni.DataSource = dsTiposDoc;
            this.cboTipoDni.DataValueField = "idTipoDocumento";
            this.cboTipoDni.DataTextField = "descTipoDocumento";
            this.cboTipoDni.DataBind();
            this.cboTipoDni.Items.Insert(0, "Sin Seleccionar");
            this.cboTipoDni.Items[0].Value = "0";
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void CargarComboLocalidades()
    {
        try
        {
            DataSet dsLocalidades = NegocioMantenimiento.TraerLocalidadesVteLopez();
            this.cboLocalidad.DataSource = dsLocalidades;
            this.cboLocalidad.DataValueField = "idLocalidad";
            this.cboLocalidad.DataTextField = "descLocalidad";

            this.cboLocalidad.DataBind();
            //this.cboLocalidad.Items.Add(new ListItem("", "0"));
            //this.cboLocalidad.SelectedValue = "0";
            this.cboLocalidad.Items.Insert(0, "Sin Seleccionar");
            this.cboLocalidad.Items[0].Value = "0";

        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void imgBuscarDen_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (this.txtNroDNI.Text.Trim() != "" )//&& TraerDenuncianteSession() == null)
            {
                int nroDoc = int.Parse(this.txtNroDNI.Text);
                Denunciante denunciante = NegocioExpedientes.TraerDenunciantePorNroDoc(nroDoc);
                if (denunciante != null)
                {
                    this.txtApellido.Text = denunciante.apellido;
                    this.txtNombres.Text = denunciante.nombre;
                    this.txtCalle.Text = denunciante.domicilio;
                    this.txtDpto.Text = denunciante.dpto;
                    this.txtNro.Text = denunciante.numero.ToString();
                    this.txtNroDNI.Text = denunciante.nroDocumento.ToString();
                    this.txtOtraLoc.Text = "";
                    this.txtPiso.Text = denunciante.piso.ToString();


                    this.txtTelefono.Text = NegocioContactos.TraerTelefonoActivo(denunciante.idDenunciante);
                    this.txtCelular.Text = NegocioContactos.TraerCelularActivo(denunciante.idDenunciante);
                    this.txtEmail.Text = NegocioContactos.TraerMailActivo(denunciante.idDenunciante);



                    //foreach (Contacto contacto in denunciante.contactos)
                    //{
                    //    switch (contacto.tipoContacto)
                    //    {
                    //        case "T":
                    //            this.txtTelefono.Text = contacto.contacto;
                    //            break;
                    //        case "C":
                    //            this.txtCelular.Text = contacto.contacto;
                    //            break;
                    //        case "E":
                    //            this.txtEmail.Text = contacto.contacto;
                    //            break;
                    //    }

                    //}

                    this.lblApellido.Text = denunciante.apellido;
                    this.lblNombres.Text = denunciante.nombre;
                    this.lblTelefono.Text = this.txtTelefono.Text;

                    GuardarDenuncianteSession(denunciante);

                    //HabilitarDesHabilitarControlesDenunciante(false);
                    //this.imgBuscarDen.Enabled = true;                                        

                }
                else
                {
                    string str = "<script type=\"text/javascript\">";
                    str = str + "mostrarDeseaHacer();</script>";
                    Page.ClientScript.RegisterStartupScript(Page.ClientScript.GetType(), "mostrarConfirmacion", str);

                }
            }
            else
            {
                Session.Add("EsPopup",1);                 
                AbrirPopupDenunciantes();

                
            }


        }
        catch (System.Threading.ThreadAbortException) { }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }

    }

    private void GuardarExpedienteSession(Expediente expediente)
    {
        if (this.Page.Session["Expediente"] == null)
        {
            this.Page.Session.Add("Expediente", expediente);
        }
        else
        {
            this.Page.Session["Expediente"] = expediente;
        }
    }

    private Expediente TraerExpedienteSession()
    {
        return (Expediente)this.Page.Session["Expediente"];
    }

    private void GuardarDenuncianteSession(Denunciante denunciante)
    {
        if (this.Page.Session["Denunciante"] == null)
        {
            this.Page.Session.Add("Denunciante", denunciante);
        }
        else
        {
            this.Page.Session["Denunciante"] = denunciante;
        }
    }

    private Denunciante TraerDenuncianteSession()
    {
        if (this.Page.Session["Denunciante"] != null)
            return (Denunciante)this.Page.Session["Denunciante"];
        return null;
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        try
        {
            Expediente expediente = TraerExpedienteSession();
            if (expediente == null)//nuevo expediente
            {
                expediente = new Expediente();
                Denunciante denunciante = this.TraerDenuncianteSession();
                if (denunciante == null)//agregar tambien al denunciante
                {
                    denunciante = CargarDenunciante(denunciante);
                    NegocioExpedientes.AgregarDenunciante(denunciante);
                    GuardarDenuncianteSession(denunciante);
                    
                }
                else//modificar denunciante
                {
                    denunciante = CargarDenunciante(denunciante);                    
                    NegocioExpedientes.ModificarDenunciante(denunciante);
                    GuardarDenuncianteSession(denunciante);
                    
                }
                expediente = CargarExpediente(expediente);
                NegocioExpedientes.Agregar(expediente);
                this.GuardarExpedienteSession(expediente);
                GuardarDenuncianteSession(denunciante);
                
                HabilitarDesHabilitarControlesDenuncia(false);
                HabilitarDesHabilitarControlesDenunciante(false);
                btnADMCont.Enabled = true;
                btnADMCont.CssClass = "ButtonBlue11px";
            }
            else //modificar expediente
            {
                Denunciante denunciante = CargarDenunciante(expediente.denunciante);
                NegocioExpedientes.ModificarDenunciante(expediente.denunciante);
                GuardarDenuncianteSession(expediente.denunciante);

                expediente = CargarExpediente(expediente);
                NegocioExpedientes.Modificar(expediente);
                GuardarExpedienteSession(expediente);
                GuardarDenuncianteSession(expediente.denunciante);
                HabilitarDesHabilitarControlesDenuncia(false);
                HabilitarDesHabilitarControlesDenunciante(false);
                SetearControlesExpediente(expediente);
                SetearControlesDenunciante(expediente.denunciante);
            }

            this.btnNuevo.Enabled = true;
            this.btnNuevo.CssClass = "ButtonBlue11px";
            this.btnModificar.Enabled = true;
            this.btnModificar.CssClass = "ButtonBlue11px";
            this.btnBuscar.Enabled = true;
            this.btnBuscar.CssClass = "ButtonBlue11px";
            this.btnGuardar.Enabled = false;
            this.btnGuardar.CssClass = "ButtonBlue11pxDisable";
            this.btnCancelar.Enabled = false;
            this.btnCancelar.CssClass = "ButtonBlue11pxDisable";

            this.btnPrimero.Enabled = true;
            this.btnPrimero.CssClass = "ButtonBlue11px";
            this.btnAnterior.Enabled = true;
            this.btnAnterior.CssClass = "ButtonBlue11px";
            this.btnSiguiente.Enabled = true;
            this.btnSiguiente.CssClass = "ButtonBlue11px";
            this.btnUltimo.Enabled = true;
            this.btnUltimo.CssClass = "ButtonBlue11px";
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }
    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        try
        {            
            Response.Redirect("BuscarExpediente.aspx");
        }
        catch (System.Threading.ThreadAbortException) { }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }

    }


    private void AbrirPopupDenunciantes()
    {
        try
        {
            string str = "<script type=\"text/javascript\">";
            str = str + "AbrirPopupDenunciantes();</script>";

            Page.ClientScript.RegisterStartupScript(Page.ClientScript.GetType(), "PopupDenunciantes", str);

 
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void AbrirPopupLocalidades()
    {
        try
        {
            if (Session["EsPopup"] == null)
                Session.Add("EsPopup", 1);
            else
                Session["EsPopup"] = 1;
            

            string str = "<script type=\"text/javascript\">";
            str = str + "AbrirPopupLocalidades();</script>";

            Page.ClientScript.RegisterStartupScript(Page.ClientScript.GetType(), "PopupLocalidades", str);


        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }


    protected void btnSalir_Click(object sender, EventArgs e)
    {
        try
        {
            Response.Redirect("Index.aspx");
        }
        catch (System.Threading.ThreadAbortException) { }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }

    }


    private string TraerEstado(List<Movimiento> movimientos)
    {
        try
        {
            string estado = "";
            if (movimientos.Count > 0)
            {
                byte tipoMovimiento = ((Movimiento) movimientos[movimientos.Count - 1]).idTipoMovimiento;
                if(tipoMovimiento == 5)
                    estado = "ARCHIVADO";
                else if(tipoMovimiento == 21)                                            
                    estado = "ENVIADO A TRIBUNALES";                        
                else if(tipoMovimiento == 28)
                    estado = "EN RESERVA";
                else if(tipoMovimiento == 1 || tipoMovimiento == 13 || tipoMovimiento == 14 ||
                        tipoMovimiento == 27 || tipoMovimiento == 31 || tipoMovimiento == 32)
                     estado = "ESPERANDO RESPUESTA";
                else                
                     estado = "EN ESTUDIO";
            }
            return estado;
        }        
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }
 
    }

    private void TraerIniciadorExpediente(Expediente expediente)
    {
        try
        {
            NegocioExpedientes.TraerIniciadorExpediente(expediente);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);            
        }

    }

    private void CargarComboEntidades()
    {
        try
        {
            DataTable dtEntidades = NegocioMantenimiento.TraerDenunciados();
            this.cboEntDenunciada.DataSource = dtEntidades;
            this.cboEntDenunciada.DataValueField = "idDenunciado";
            this.cboEntDenunciada.DataTextField = "entidad";
            this.cboEntDenunciada.DataBind();
            this.cboEntDenunciada.Items.Insert(0, "Sin Seleccionar");            
            this.cboEntDenunciada.Items[0].Value = "0";

        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void CargarComboAreas()
    {
        try
        {
            DataTable dtAreas = NegocioMantenimiento.TraerAreas();
            this.cboArea.DataSource = dtAreas;
            this.cboArea.DataValueField = "idArea";
            this.cboArea.DataTextField = "descArea";
            this.cboArea.DataBind();
            this.cboArea.Items.Insert(0, "Sin Seleccionar");
            this.cboArea.Items[0].Value = "0";
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void CargarComboTiposDenuncia()
    {
        try
        {
            DataTable dtTiposDenuncia = NegocioMantenimiento.TraerTiposDenuncia();
            this.cboTipoDenuncia.DataSource = dtTiposDenuncia;
            this.cboTipoDenuncia.DataValueField = "idTipoDenuncia";
            this.cboTipoDenuncia.DataTextField = "descTipoDenuncia";
            this.cboTipoDenuncia.DataBind();

            this.cboTipoDenuncia.Items.Insert(0, "Sin Seleccionar");
            this.cboTipoDenuncia.Items[0].Value = "0";
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }
    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        try
        {
            GuardarDenuncianteSession(null);
            GuardarExpedienteSession(null);
            LimpiarControles();
            HabilitarDesHabilitarControlesDenunciante(true);
            HabilitarDesHabilitarControlesDenuncia(true);


            this.lblNroExpediente.Text = NegocioExpedientes.TraerProxIdExpediente().ToString();
            this.lblFechaArchivo.Text = "";
            this.lblFechaIngreso.Text = DateTime.Today.ToShortDateString();
            this.lblEstado.Text = "";
            this.cboInformante.Enabled = false;
            this.cboInformante.SelectedValue = "0";
            this.cboLocalidad.SelectedValue = "0";
            this.cboAtendio.Enabled = true;

            this.btnMovimientos.Enabled = false;
            this.btnMovimientos.CssClass = "ButtonBlue11pxDisable";
            this.btnCancelar.Enabled = true;
            this.btnCancelar.CssClass = "ButtonBlue11px";
            this.btnNuevo.Enabled = false;
            this.btnNuevo.CssClass = "ButtonBlue11pxDisable";
            this.btnGuardar.Enabled = true;
            this.btnGuardar.CssClass = "ButtonBlue11px";
            this.btnBuscar.Enabled = false;
            this.btnBuscar.CssClass = "ButtonBlue11pxDisable";
            this.btnModificar.Enabled = false;
            this.btnModificar.CssClass = "ButtonBlue11pxDisable";
            this.btnPrimero.Enabled = false;
            this.btnPrimero.CssClass = "ButtonBlue11pxDisable";
            this.btnAnterior.Enabled = false;
            this.btnAnterior.CssClass = "ButtonBlue11pxDisable";
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.CssClass = "ButtonBlue11pxDisable";
            this.btnUltimo.Enabled = false;
            this.btnUltimo.CssClass = "ButtonBlue11pxDisable";

            this.btnADMCont.Enabled = false;
            btnADMCont.CssClass = "ButtonBlue11pxDisable";
                    
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }

    }
    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        try 
        {
            GuardarDenuncianteSession(null);
            LimpiarControles();
            HabilitarDesHabilitarControlesDenuncia(false);
            HabilitarDesHabilitarControlesDenunciante(false);

            this.lblNroExpediente.Text = "";
            this.lblFechaArchivo.Text = "";
            this.lblFechaIngreso.Text = "";
            this.lblEstado.Text = "";
            this.cboInformante.Enabled = false;
            this.cboAtendio.Enabled = false;
            
            this.btnNuevo.Enabled = true;
            this.btnNuevo.CssClass = "ButtonBlue11px";
            this.btnGuardar.Enabled = false;
            this.btnGuardar.CssClass = "ButtonBlue11pxDisable";
            this.btnBuscar.Enabled = true;
            this.btnBuscar.CssClass = "ButtonBlue11px";
            this.btnCancelar.Enabled = false;
            this.btnCancelar.CssClass = "ButtonBlue11pxDisable";
            this.btnModificar.Enabled = false;            
            this.btnModificar.CssClass = "ButtonBlue11pxDisable";
            this.cboLocalidad.SelectedValue = "0";

            this.btnPrimero.Enabled = true;
            this.btnPrimero.CssClass = "ButtonBlue11px";
            this.btnAnterior.Enabled = true;
            this.btnAnterior.CssClass = "ButtonBlue11px";
            this.btnSiguiente.Enabled = true;
            this.btnSiguiente.CssClass = "ButtonBlue11px";
            this.btnUltimo.Enabled = true;
            this.btnUltimo.CssClass = "ButtonBlue11px";

            this.btnADMCont.Enabled = true;
            btnADMCont.CssClass = "ButtonBlue11px";

            
            
            Expediente expediente = NegocioExpedientes.TraerExpedienteCompletoPorIdExpediente(1);
            if (expediente != null)
            {
                GuardarExpedienteSession(expediente);
                SetearControlesExpediente(expediente);
                this.btnModificar.Enabled = true;
                this.btnModificar.CssClass = "ButtonBlue11px";
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }

    }

    private void HabilitarDesHabilitarControlesDenuncia(bool estado)
    {
        try
        {
            this.chkDocumentacion.Disabled = !estado;
            //this.chkDocumentacion.Checked = estado;
            //this.cboArea.Enabled = estado;
            this.cboEntDenunciada.Enabled = estado;            
            this.cboTipoDenuncia.Enabled = estado;            
            this.txtDetalleDenuncia.Enabled = estado;
            this.txtDetalleDocumentacion.Enabled = false;
            this.cboAtendio.Enabled = estado;
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void HabilitarDesHabilitarControlesDenunciante(bool estado)
    {
        try 
        {
            this.txtApellido.Enabled = estado;
            this.txtNombres.Enabled = estado;
            this.txtCalle.Enabled = estado;
            //this.txtCelular.Enabled = estado;
            this.txtDpto.Enabled = estado;
            //this.txtEmail.Enabled = estado;
            this.txtNro.Enabled = estado;
            this.txtNroDNI.Enabled = estado;            
            this.txtPiso.Enabled = estado;
            //this.txtTelefono.Enabled = estado;
            this.imgBuscarDen.Enabled = estado;
            this.imgBuscarLoc.Enabled = estado;
            this.cboTipoDni.Enabled = estado;
            this.cboLocalidad.Enabled = estado;
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }

    }

    private void LimpiarControles()
    {
        try
        {
            this.txtApellido.Text = "";
            this.txtNombres.Text = "";
            this.txtCalle.Text = "";
            this.txtCelular.Text = "";
            this.txtDetalleDenuncia.Text = "";
            this.txtDetalleDocumentacion.Text = "";
            this.txtDpto.Text = "";
            this.txtEmail.Text = "";
            this.txtNro.Text = "";
            this.txtNroDNI.Text = "";
            this.txtOtraLoc.Text = "";
            this.txtPiso.Text = "";
            this.txtTelefono.Text = "";

            this.lblApellido.Text = "";
            this.lblNombres.Text = "";
            this.lblTelefono.Text = "";

            this.cboArea.SelectedIndex = 0;
            this.cboAtendio.SelectedIndex = 0;
            this.cboEntDenunciada.SelectedIndex = 0;
            this.cboInformante.SelectedIndex = 0;
            this.cboLocalidad.SelectedIndex = 0;
            this.cboTipoDenuncia.SelectedIndex = 0;
            this.cboTipoDni.SelectedIndex = 0;

            this.chkDocumentacion.Checked = false;
 
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void SetearControlesExpediente(Expediente expediente)
    {
        try
        {
            //Datos Expediente.

            TraerIniciadorExpediente(expediente);

            this.lblNroExpediente.Text = expediente.idExpediente.ToString();                    
            this.cboAtendio.SelectedValue = expediente.atendio.idPersona.ToString();
            if (expediente.informante != null)
            {
                this.cboInformante.SelectedValue = expediente.informante.idPersona.ToString();
            }
            this.lblEstado.Text = TraerEstado(expediente.movimientos);
            if (expediente.fechaArchivo != DateTime.MinValue)
            this.lblFechaArchivo.Text = expediente.fechaArchivo.ToShortDateString();
            else
                this.lblFechaArchivo.Text = "";

            this.lblFechaIngreso.Text = expediente.fechaIngreso.ToShortDateString();

            
            //Datos Denunciante.
            this.txtApellido.Text = expediente.denunciante.apellido;
            this.txtNombres.Text = expediente.denunciante.nombre;
            this.txtCalle.Text = expediente.denunciante.domicilio;
            this.txtDpto.Text = expediente.denunciante.dpto;
            this.txtNro.Text = expediente.denunciante.numero.ToString();
            this.txtPiso.Text = expediente.denunciante.piso.ToString();
            this.txtNroDNI.Text = expediente.denunciante.nroDocumento.ToString();
            this.cboTipoDni.SelectedValue = expediente.denunciante.idTipoDocumento.ToString();                    
            bool flag = false;
            foreach (ListItem item in cboLocalidad.Items)
            {
                if (item.Value == expediente.denunciante.idLocalidad.ToString())
                    flag = true;                            
            }
            if (flag)
            {
                cboLocalidad.SelectedValue = expediente.denunciante.idLocalidad.ToString();
            }
            else
            {
                Localidad localidad = NegocioMantenimiento.TraerLocalidadPorId(expediente.denunciante.idLocalidad);

                cboLocalidad.SelectedValue = "0";
                this.txtOtraLoc.Text = localidad.descLocalidad;                        
                hOtraLoc.Value = expediente.denunciante.idLocalidad.ToString() + "|" + localidad.descLocalidad;
            }


            this.txtTelefono.Text = NegocioContactos.TraerTelefonoActivo(expediente.denunciante.idDenunciante);
            this.txtCelular.Text = NegocioContactos.TraerCelularActivo(expediente.denunciante.idDenunciante);
            this.txtEmail.Text = NegocioContactos.TraerMailActivo(expediente.denunciante.idDenunciante);




            //expediente.denunciante.contactos = NegocioExpedientes.TraerContactoDenunciante(expediente.denunciante.idDenunciante);
            //foreach (Contacto contacto in expediente.denunciante.contactos)
            //{
            //    switch (contacto.tipoContacto)
            //    {
            //        case "T":
            //            this.txtTelefono.Text = contacto.contacto;
            //            break;
            //        case "C":
            //            this.txtCelular.Text = contacto.contacto;
            //            break;
            //        case "E":
            //            this.txtEmail.Text = contacto.contacto;
            //            break;
            //    }
            //}                 

            //Datos Denuncia.
            this.lblApellido.Text = expediente.denunciante.apellido;
            this.lblNombres.Text = expediente.denunciante.nombre;
            this.lblTelefono.Text = this.txtTelefono.Text;
            if (expediente.movimientos.Count != 0)
            {
                this.btnMovimientos.Enabled = true;
                this.btnMovimientos.CssClass = "ButtonBlue11px";
            }
            this.cboArea.SelectedValue = expediente.area.idArea.ToString();
            this.cboEntDenunciada.SelectedValue = expediente.denunciado.idDenunciado.ToString();
            this.cboTipoDenuncia.SelectedValue = expediente.idTipoDenuncia.ToString();
            this.chkDocumentacion.Checked = expediente.traeDocumentacion == 1 ? true : false;
            this.txtDetalleDocumentacion.Text = expediente.descDocumentacion;
            this.txtDetalleDenuncia.Text = expediente.descDenuncia; 
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }

    }


    private void SetearControlesDenunciante(Denunciante denunciante)
    {
        try 
        {
            this.txtApellido.Text =denunciante.apellido;
            this.txtNombres.Text = denunciante.nombre;
            this.txtCalle.Text = denunciante.domicilio;
            this.txtDpto.Text = denunciante.dpto;
            this.txtNro.Text = denunciante.numero.ToString();
            this.txtPiso.Text = denunciante.piso.ToString();
            this.txtNroDNI.Text = denunciante.nroDocumento.ToString();
            this.cboTipoDni.SelectedValue = denunciante.idTipoDocumento.ToString();
            bool flag = false;
            foreach (ListItem item in cboLocalidad.Items)
            {
                if (item.Value == denunciante.idLocalidad.ToString())
                    flag = true;
            }
            if (flag)
            {
                cboLocalidad.SelectedValue = denunciante.idLocalidad.ToString();
            }
            else
            {
                Localidad localidad = NegocioMantenimiento.TraerLocalidadPorId(denunciante.idLocalidad);

                cboLocalidad.SelectedValue = "0";
                this.cboLocalidad.Enabled = false;
                this.txtOtraLoc.Text = localidad.descLocalidad;
                hOtraLoc.Value = denunciante.idLocalidad + "|" + localidad.descLocalidad;
            }

            this.txtTelefono.Text = NegocioContactos.TraerTelefonoActivo(denunciante.idDenunciante);
            this.txtCelular.Text = NegocioContactos.TraerCelularActivo(denunciante.idDenunciante);
            this.txtEmail.Text = NegocioContactos.TraerMailActivo(denunciante.idDenunciante);





            //foreach (Contacto contacto in denunciante.contactos)
            //{
            //    switch (contacto.tipoContacto)
            //    {
            //        case "T":
            //            this.txtTelefono.Text = contacto.contacto;
            //            break;
            //        case "C":
            //            this.txtCelular.Text = contacto.contacto;
            //            break;
            //        case "E":
            //            this.txtEmail.Text = contacto.contacto;
            //            break;
            //    }
            //}                 

        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private Expediente CargarExpediente(Expediente expediente)
    {
        try
        {
            expediente.idExpediente = int.Parse(this.lblNroExpediente.Text);            
            expediente.area.idArea = Byte.Parse(this.cboArea.SelectedValue);
            expediente.denunciado.idDenunciado = Byte.Parse(this.cboEntDenunciada.SelectedValue);
            expediente.idTipoDenuncia = byte.Parse(this.cboTipoDenuncia.SelectedValue);
            expediente.descDenuncia = this.txtDetalleDenuncia.Text.Trim();
            if (this.chkDocumentacion.Checked)
            {
                expediente.traeDocumentacion = 1;
                expediente.descDocumentacion = this.txtDetalleDocumentacion.Text.Trim();
            }
            else
            {
                expediente.traeDocumentacion = 0;
                expediente.descDocumentacion = "";
            }

            expediente.fechaIngreso = DateTime.Now;
            expediente.atendio.idPersona = int.Parse(this.cboAtendio.SelectedValue); 
            if (this.cboInformante.SelectedValue != "0")
            {
                expediente.informante.idPersona = int.Parse(this.cboInformante.SelectedValue);
            }

            expediente.denunciante = TraerDenuncianteSession();

            return expediente;
 
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }

    }

    private Denunciante CargarDenunciante(Denunciante denunciante)
    {
        try
        {
            if (denunciante == null)
            {
                denunciante = new Denunciante();
                denunciante.idDenunciante = NegocioExpedientes.TraerProxIdDenunciante();                
            }
            
            //List<Contacto> contactos = new List<Contacto>();
            //Contacto contacto;
            //contacto = new Contacto();
            //contacto.idDenunciante = denunciante.idDenunciante;
            //contacto.tipoContacto = "T";
            //contactos.Add(contacto);

            //contacto = new Contacto();
            //contacto.idDenunciante = denunciante.idDenunciante;
            //contacto.tipoContacto = "C";
            //contactos.Add(contacto);

            //contacto = new Contacto();
            //contacto.idDenunciante = denunciante.idDenunciante;
            //contacto.tipoContacto = "E";
            //contactos.Add(contacto);

            //denunciante.contactos = contactos;

            denunciante.apellido = txtApellido.Text.ToUpper();
            denunciante.nombre = txtNombres.Text;
            denunciante.domicilio = txtCalle.Text;
            denunciante.numero = txtNro.Text != "" ? int.Parse(txtNro.Text) : (Byte)0;
            denunciante.piso = txtPiso.Text != "" ? Byte.Parse(txtPiso.Text) : (Byte)0;
            denunciante.dpto = txtDpto.Text;
            denunciante.idTipoDocumento = Byte.Parse(cboTipoDni.SelectedValue);
            denunciante.nroDocumento = int.Parse(txtNroDNI.Text);

            //foreach (Contacto cont in denunciante.contactos)
            //{
            //    switch (cont.tipoContacto)
            //    {
            //        case "T":   cont.contacto = txtTelefono.Text;
            //                    break;
            //        case "C":   cont.contacto = txtCelular.Text;
            //                    break;
            //        case "E":   cont.contacto = txtEmail.Text;
            //                    break;
            //    }
            //}

            if (cboLocalidad.SelectedValue != "0")
                denunciante.idLocalidad = int.Parse(cboLocalidad.SelectedValue);
            else
                denunciante.idLocalidad = int.Parse(hOtraLoc.Value.Split('|')[0].ToString());
            

            return denunciante;
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }

    }

    private void MostrarMensaje(string strMensaje)
    {
        try
        {
            string str = "<script type=\"text/javascript\">";
            str = str + "alert('" + strMensaje + "');";
            str = str + "</script>";
            Page.ClientScript.RegisterStartupScript(Page.ClientScript.GetType(), "mostrarMensaje", str);
        }
        catch(Exception ex)
        {       
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }
    }
    protected void btnMovimientos_Click(object sender, EventArgs e)
    {
        try
        {
            Session.Remove("pagina");
            Session.Add("pagina", "Expedientes");
            Response.Redirect("ListarMovimientos.aspx?idExpediente=" + lblNroExpediente.Text);
        }
        catch (System.Threading.ThreadAbortException) { }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }
    }
    protected void imgBuscarLoc_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            AbrirPopupLocalidades();
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }
        
    }
    protected void btnModificar_Click(object sender, EventArgs e)
    {
        try
        {
            HabilitarDesHabilitarControlesDenunciante(true);
            HabilitarDesHabilitarControlesDenuncia(true);

            this.btnNuevo.Enabled = false;
            this.btnNuevo.CssClass = "ButtonBlue11pxDisable";
            this.btnCancelar.Enabled = true;
            this.btnCancelar.CssClass = "ButtonBlue11px";
            this.btnBuscar.Enabled = false;
            this.btnBuscar.CssClass = "ButtonBlue11pxDisable";
            this.btnGuardar.Enabled = true;
            this.btnGuardar.CssClass = "ButtonBlue11px";
            this.btnModificar.Enabled = false;
            this.btnModificar.CssClass = "ButtonBlue11pxDisable";
            this.imgBuscarDen.Enabled = false;
            this.cboAtendio.Enabled = false;

            this.btnPrimero.Enabled = false;
            this.btnPrimero.CssClass = "ButtonBlue11pxDisable";
            this.btnAnterior.Enabled = false;
            this.btnAnterior.CssClass = "ButtonBlue11pxDisable";
            this.btnSiguiente.Enabled = false;
            this.btnSiguiente.CssClass = "ButtonBlue11pxDisable";
            this.btnUltimo.Enabled = false;
            this.btnUltimo.CssClass = "ButtonBlue11pxDisable";

            this.btnADMCont.Enabled = false;
            btnADMCont.CssClass = "ButtonBlue11pxDisable";

        }
        catch(Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }
    }
protected void txtNombres_TextChanged(object sender, EventArgs e)
    {

    }
    protected void btnPrimero_Click(object sender, EventArgs e)
    {
        try
        {
            Expediente expediente = NegocioExpedientes.TraerExpedienteCompletoPorIdExpediente(1);
            if (expediente != null)
            {
                SetearControlesExpediente(expediente);
                GuardarExpedienteSession(expediente);
                GuardarDenuncianteSession(expediente.denunciante);
                this.btnModificar.Enabled = true;
                this.btnModificar.CssClass = "ButtonBlue11px";
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }

    }
    protected void btnAnterior_Click(object sender, EventArgs e)
    {
        try
        {
            Expediente expediente = NegocioExpedientes.TraerExpedienteCompletoPorIdExpediente(int.Parse(lblNroExpediente.Text) - 1);
            if (expediente != null)
            {
                SetearControlesExpediente(expediente);
                GuardarExpedienteSession(expediente);
                GuardarDenuncianteSession(expediente.denunciante);
                this.btnModificar.Enabled = true;
                this.btnModificar.CssClass = "ButtonBlue11px";

            }

        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }    

    }
    protected void btnSiguiente_Click(object sender, EventArgs e)
    {
        try
        {
            Expediente expediente = NegocioExpedientes.TraerExpedienteCompletoPorIdExpediente(int.Parse(lblNroExpediente.Text)+1);
            if (expediente != null)
            {
                SetearControlesExpediente(expediente);
                GuardarExpedienteSession(expediente);
                GuardarDenuncianteSession(expediente.denunciante);
                this.btnModificar.Enabled = true;
                this.btnModificar.CssClass = "ButtonBlue11px";

            }

        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }

    }
    protected void btnUltimo_Click(object sender, EventArgs e)
    {
        try
        {
            int maxID = NegocioExpedientes.TraerProxIdExpediente() - 1;
            Expediente expediente = NegocioExpedientes.TraerExpedienteCompletoPorIdExpediente(maxID);
            if (expediente != null)
            {
                SetearControlesExpediente(expediente);
                GuardarExpedienteSession(expediente);
                GuardarDenuncianteSession(expediente.denunciante);
                this.btnModificar.Enabled = true;
                this.btnModificar.CssClass = "ButtonBlue11px";

            }

        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }

    }

    protected void btnOtroTel_Click(object sender, EventArgs e)
    {
        try
        {
            int idDen = TraerExpedienteSession().denunciante.idDenunciante;
            GuardarDenuncianteSession(TraerExpedienteSession().denunciante);
            string str = "<script type=\"text/javascript\">";
            str = str + "AbrirPopupContactos('" + idDen.ToString() +"');</script>";

            Page.ClientScript.RegisterStartupScript(Page.ClientScript.GetType(), "PopupContactos", str);

            Session.Add("PopupContactos", 1);
            
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw; 
        }
    }

}
