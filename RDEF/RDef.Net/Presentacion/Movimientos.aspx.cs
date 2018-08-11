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
using System.IO;
using Negocio;
using Entidades;
using Enum = Entidades.Movimiento.eAccion;

// IMPORTANTE: Se utilizará al atributo de la clase Movimiento 'idMovimiento' como
// atributo 'idMovimientoSolicitud'.

public partial class Presentacion_Movimientos : System.Web.UI.Page
{
    private DataSet camposTipoMovimiento;

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!this.IsPostBack)
            {
                int idExpediente = 1;
                Byte idMovimiento = 1;
                Enum accion = Enum .Ver;
                if (Request.QueryString.Count > 0)
                {
                    if (Request.QueryString.Get("accion") == "nuevo")
                        accion = Enum.Nuevo;

                    idExpediente = Convert.ToInt32(Request.QueryString.Get("idExpediente"));

                    if (accion == Enum.Ver)
                        idMovimiento = Convert.ToByte(Request.QueryString.Get("idMovimiento"));
                    else                         
                        idMovimiento = 0;
                }
                List<Movimiento> listaMovimientos = new List<Movimiento>();
                List<DetalleMovimiento> listaDetalleMovimientos = new List<DetalleMovimiento>();
                List<ExpedienteMVL> listaExpedienteMVL = new List<ExpedienteMVL>();
                listaMovimientos = NegocioMovimientos.Listar(idExpediente);
                listaDetalleMovimientos = NegocioDetalleMovimiento.Listar(idExpediente);
                listaExpedienteMVL = NegocioExpedienteMVL.Listar(idExpediente);
                this.camposTipoMovimiento = NegocioMovimientos.traerCamposPorTipoMovimiento();
                Expediente expediente = new Expediente();
                expediente = NegocioExpedientes.TraerExpedienteCompletoPorIdExpediente(idExpediente);
                Session.Add("camposTipoMovimiento", camposTipoMovimiento);
                Session.Add("listaExpedienteMVL", listaExpedienteMVL);
                Session.Add("listaDetalleMovimiento", listaDetalleMovimientos);
                Session.Add("accion", accion);
                Session.Add("SSlistaMovimientos", listaMovimientos);
                Session.Add("SSMov", idMovimiento);
                Session.Add("generoArchivo", 0);
                Session.Add("fechaArchivo", expediente.fechaArchivo);
                Session.Add("idFin", expediente.fin.idFin);
                Session.Add("informante", expediente.informante.idPersona);
                inicializarVista();
                this.cargarCodigosExpedientesMVL();
                this.cargarExpedientesMVLGenerados();
                this.cargarComboPersonas();
                this.CargarComboFines();
                this.cargarComboTiposMovimientos();
                this.cargarComboDependencias();
                txtExpediente.Text = Convert.ToString(idExpediente);
                txtNumeroMovimiento.Text = Convert.ToString(idMovimiento);
                if (accion == Enum.Ver)
                {
                    this.cargarElementos();
                    cambiarVista();
                    cargarDatosAdicionales();
                }
                else 
                {
                    agregarNuevoMovimiento();
                }
                txtIniciador.Text = NegocioExpedientes.TraerIniciadorMovimientos(idExpediente);
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message.ToString());
        }
    }

    #region cargaCombos

    private void cargarComboPersonas()
    {
        try
        {
            DataSet ListPersonas = NegocioMantenimiento.TraerPersonas();
            this.cboGenero.Items.Clear();
            this.cboGenero.DataSource = ListPersonas;
            this.cboGenero.DataValueField = "idPersona";
            this.cboGenero.DataTextField = "nombre";
            this.cboGenero.DataBind();
            this.cboGenero.Items.Insert(0, "Seleccione una opción");
            this.cboGenero.Items[0].Value = "0";

            this.cboPasar.Items.Clear();
            this.cboPasar.DataSource = ListPersonas;
            this.cboPasar.DataValueField = "idPersona";
            this.cboPasar.DataTextField = "nombre";
            this.cboPasar.DataBind();
            this.cboPasar.Items.Insert(0, "Seleccione una opción");
            this.cboPasar.Items[0].Value = "0";
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    private void CargarComboFines()
    {
        try
        {
            DataSet ListFines = NegocioMantenimiento.TraerFines();
            this.cboFines.DataSource = ListFines;
            this.cboFines.DataValueField = "idFin";
            this.cboFines.DataTextField = "descFin";
            this.cboFines.DataBind();
            this.cboFines.Items.Insert(0, "Seleccione una opción");
            this.cboFines.Items[0].Value = "0";
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    private void cargarComboTiposMovimientos()
    {
        try
        {
            DataSet ListTipoMovimientos = NegocioMantenimiento.TraerTiposMovimientos();
            this.cboTipoMovimiento.Items.Clear();
            this.cboTipoMovimiento.DataSource = ListTipoMovimientos;
            this.cboTipoMovimiento.DataValueField = "idTipoMovimiento";
            this.cboTipoMovimiento.DataTextField = "descMovimiento";
            this.cboTipoMovimiento.DataBind();
            this.cboTipoMovimiento.Items.Insert(0, "Seleccione una opción");
            this.cboTipoMovimiento.Items[0].Value = "0";
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    private void cargarComboDependencias()
    {
        try
        {
            DataSet ListDependencias = NegocioMantenimiento.TraerDependencias();
            this.cboDependencia.Items.Clear();
            this.cboDependencia.DataSource = ListDependencias;
            this.cboDependencia.DataValueField = "idDependencia";
            this.cboDependencia.DataTextField = "descDependencia";
            this.cboDependencia.DataBind();
            this.cboDependencia.Items.Insert(0, "Seleccione una opción");
            this.cboDependencia.Items[0].Value = "0";
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    private void cargarExpedientesMVLGenerados()
    {
        try
        {
            Int32 idExpediente = 1;
            DataSet ListExpedientesMVL = NegocioExpedienteMVL.traerExpedientesMVL(idExpediente);
            this.cboExpedientesGeneradosMVL.Items.Clear();
            this.cboExpedientesGeneradosMVL.DataSource = ListExpedientesMVL;
            this.cboExpedientesGeneradosMVL.DataValueField = "idMovimientoSolicitud";
            this.cboExpedientesGeneradosMVL.DataTextField = "cad";
            this.cboExpedientesGeneradosMVL.DataBind();
            this.cboExpedientesGeneradosMVL.Items.Insert(0, "Seleccione una opción");
            this.cboExpedientesGeneradosMVL.Items[0].Value = "0";
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    private void cargarCodigosExpedientesMVL()
    {
        try
        {
            this.cboCodigoExpedienteMVL.Items.Add("Seleccione una opción");
            this.cboCodigoExpedienteMVL.Items[0].Value = "0";
            this.cboCodigoExpedienteMVL.Items.Add("4119");
            this.cboCodigoExpedienteMVL.Items[1].Value = "4119";
            this.cboCodigoExpedienteMVL.Items.Add("HCD");
            this.cboCodigoExpedienteMVL.Items[2].Value = "HCD";
            this.cboCodigoExpedienteMVL.Items.Add("Nota");
            this.cboCodigoExpedienteMVL.Items[3].Value = "Nota";
            this.cboCodigoExpedienteMVL.Items.Add("Otro");
            this.cboCodigoExpedienteMVL.Items[4].Value = "Otro";
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    #endregion

    private void cargarElementos()
    {
        try
        {
            Byte idmov;
            Int32 cantidad;
            List<Movimiento> listaMovimientos = new List<Movimiento>();
            listaMovimientos = (List<Movimiento>)Session["SSlistaMovimientos"];
            idmov = Convert.ToByte(Session["SSMov"]);
            cantidad = listaMovimientos.Count;
            if (cantidad == 0) 
            {
                MostrarMensaje("Sin Movimientos para mostrar. Se redireccionará a la página anterior.");
                salirMovimientos();
            }
            for (int i = 0; i < cantidad; i++) 
            {
                if (listaMovimientos[i].idMovimiento == idmov) 
                {
                    txtExpediente.Text = listaMovimientos[i].idExpediente.ToString();
                    txtNumeroMovimiento.Text = listaMovimientos[i].idMovimiento.ToString();
                    txtComentario.Text = listaMovimientos[i].comentario;
                    txtFechaMovimiento.Text = listaMovimientos[i].fechaMovimiento.ToShortDateString();
                    cboGenero.SelectedValue = listaMovimientos[i].idPersona.ToString();
                    cboTipoMovimiento.SelectedValue = listaMovimientos[i].idTipoMovimiento.ToString();
                    chkRespuesta.Checked = Convert.ToBoolean(listaMovimientos[i].realizado);   
                }
            }                
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    #region cambioIndiceCombos

    protected void cboTipoMovimiento_SelectedIndexChanged(object sender, EventArgs e)
    {
        limpiarControles();
        cambiarVista();
    }

    protected void cboDependencia_SelectedIndexChanged(object sender, EventArgs e)
    {
        try 
        {
            if (cboDependencia.SelectedIndex > 0)
            {
                txtComentario.Text = txtComentario.Text + " " + cboDependencia.SelectedItem.Text + "\n";
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }

    #endregion

    #region manejoVista

    private void inicializarVista() {
        try {
            chkRespuesta.Checked = false;
            visibleDependencia(false);
            visibleFechaArchivo(false);
            visibleVerEscrito(false);
            visibleGenerarEscrito(false);
            visibleNumeroMVL(false);
            visiblePasar(false);
            visibleNumeroExpedienteMVL(false);
            visibleNumeroResolucion(false);
            visibleFines(false);
            visibleAnioExpediente(false);
            visibleExpedienteGeneradoMVL(false);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    private void cambiarVista()
    {
        try
        {
            DataSet ds = new DataSet();
            ds = (DataSet)Session["camposTipoMovimiento"];
            int i = 0;
            inicializarVista();
            if (Convert.ToInt16(cboTipoMovimiento.SelectedValue) != 0)
            {
                while (i < ds.Tables[0].Rows.Count)
                {
                    if (Convert.ToInt16(cboTipoMovimiento.SelectedValue) == Convert.ToInt16(ds.Tables[0].Rows[i][0]))
                    {
                        visibleDependencia(Convert.ToBoolean(ds.Tables[0].Rows[i][1]));
                        visibleFechaArchivo(Convert.ToBoolean(ds.Tables[0].Rows[i][2]));
                        visibleVerEscrito(Convert.ToBoolean(ds.Tables[0].Rows[i][3]));
                        visibleGenerarEscrito(Convert.ToBoolean(ds.Tables[0].Rows[i][4]));
                        visibleNumeroMVL(Convert.ToBoolean(ds.Tables[0].Rows[i][5]));
                        visiblePasar(Convert.ToBoolean(ds.Tables[0].Rows[i][6]));
                        visibleNumeroExpedienteMVL(Convert.ToBoolean(ds.Tables[0].Rows[i][7]));
                        visibleNumeroResolucion(Convert.ToBoolean(ds.Tables[0].Rows[i][8]));
                        chkRespuesta.Checked = Convert.ToBoolean(ds.Tables[0].Rows[i][9]);
                        visibleAnioExpediente(Convert.ToBoolean(ds.Tables[0].Rows[i][10]));
                        visibleExpedienteGeneradoMVL(Convert.ToBoolean(ds.Tables[0].Rows[i][11]));
                        visibleFines(Convert.ToBoolean(ds.Tables[0].Rows[i][12]));
                        i = ds.Tables[0].Rows.Count;
                    }
                    i = i + 1;
                }
            }
            // Agregado Nico
            if (txtFechaArchivo.Visible) 
            {
                txtFechaArchivo.Text = txtFechaMovimiento.Text;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    #endregion

    #region visibilidadControles

    private void visibleDependencia(Boolean val)
    {
        cboDependencia.Visible = val;
        lblDependencia.Visible = val;
    }

    private void visibleFechaArchivo(Boolean val)
    {   txtFechaArchivo.Visible = val;
        lblFechaArchivo.Visible = val;
    }

    private void visibleVerEscrito(Boolean val)
    { 
        ibtVerEscrito.Visible = val;
        lblVerEscrito.Visible = val;
    }

    private void visibleGenerarEscrito(Boolean val)
    { 
        ibtGenerarEscrito.Visible = val;
        lblGenerarEscrito.Visible = val;
    }

    private void visibleNumeroMVL(Boolean val) 
    {
        cboCodigoExpedienteMVL.Visible = val;
    }

    private void visiblePasar(Boolean val) 
    {
        cboPasar.Visible = val;
        lblPasar.Visible = val;
    }

    private void visibleNumeroExpedienteMVL(Boolean val) 
    {
        txtNumeroExpedienteMVL.Visible = val;
        lblNumeroExpedienteMVL.Visible = val;
    }

    private void visibleExpedienteGeneradoMVL(Boolean val)
    {
        lblExpedientesGeneradosMVL.Visible = val;
        cboExpedientesGeneradosMVL.Visible = val;
    }

    private void visibleAnioExpediente(Boolean val) 
    {
        txtAnioExpediente.Visible = val;
    }

    private void visibleNumeroResolucion(Boolean val) 
    {
        txtNumeroResolucion.Visible = val;
        lblNumeroResolucion.Visible = val;
    }

    private void visibleFines(Boolean val)
    {
        cboFines.Visible = val;
        lblFinal.Visible = val;
    }

    #endregion

    #region habilitacionControlesBotones

    private void habilitarControles(Boolean val)
    {
        try {
            cboTipoMovimiento.Enabled = val;
            cboGenero.Enabled = val;
            txtFechaMovimiento.Enabled = val;
            btnFechaRespuesta.Enabled = val;
            btnFechaRespuesta.CssClass = btnFechaRespuesta.Enabled ? "ButtonBlue11px" : "ButtonBlue11pxDisable";
            chkRespuesta.Enabled = val;
            txtComentario.Enabled = val;
            cboDependencia.Enabled = val;
            txtFechaArchivo.Enabled = val;
            ibtVerEscrito.Enabled = val;
            ibtGenerarEscrito.Enabled = val;
            cboCodigoExpedienteMVL.Enabled = val;
            cboPasar.Enabled = val;
            txtNumeroExpedienteMVL.Enabled = val;
            txtNumeroResolucion.Enabled = val;
            txtAnioExpediente.Enabled = val;
            cboExpedientesGeneradosMVL.Enabled = val;
            cboFines.Enabled = val;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    private void limpiarControles()
    {
        cboDependencia.SelectedIndex = 0;
        txtFechaArchivo.Text = "";
        cboCodigoExpedienteMVL.SelectedIndex = 0;
        cboPasar.SelectedIndex = 0;
        txtNumeroExpedienteMVL.Text = "";
        txtNumeroResolucion.Text = "";
        txtAnioExpediente.Text = "";
        cboExpedientesGeneradosMVL.SelectedIndex = 0;
        cboFines.SelectedIndex = 0;
    }

    private void habilitarBotones(Boolean val)
    {
        Boolean val2 = !val;
        try
        {
            btnAgregar.Enabled = val2;
            btnAgregar.CssClass = btnAgregar.Enabled ? "ButtonBlue11px" : "ButtonBlue11pxDisable";
            btnModificar.Enabled = val2;
            btnModificar.CssClass = btnModificar.Enabled ? "ButtonBlue11px" : "ButtonBlue11pxDisable";
            btnEliminar.Enabled = val2;
            btnEliminar.CssClass = btnEliminar.Enabled ? "ButtonBlue11px" : "ButtonBlue11pxDisable";
            btnSalir.Enabled = val2;
            btnSalir.CssClass = btnSalir.Enabled ? "ButtonBlue11px" : "ButtonBlue11pxDisable";
            btnCancelar.Enabled = val;
            btnCancelar.CssClass = btnCancelar.Enabled ? "ButtonBlue11px" : "ButtonBlue11pxDisable";
            btnGuardar.Enabled = val;
            btnGuardar.CssClass = btnGuardar.Enabled ? "ButtonBlue11px" : "ButtonBlue11pxDisable";
            btnListar.Enabled = val2;
            btnListar.CssClass = btnListar.Enabled ? "ButtonBlue11px" : "ButtonBlue11pxDisable";
            btnPrimero.Enabled = val2;
            btnPrimero.CssClass = btnPrimero.Enabled ? "ButtonBlue11px" : "ButtonBlue11pxDisable";
            btnAnterior.Enabled = val2;
            btnAnterior.CssClass = btnAnterior.Enabled ? "ButtonBlue11px" : "ButtonBlue11pxDisable";
            btnSiguiente.Enabled = val2;
            btnSiguiente.CssClass = btnSiguiente.Enabled ? "ButtonBlue11px" : "ButtonBlue11pxDisable";
            btnUltimo.Enabled = val2;
            btnUltimo.CssClass = btnUltimo.Enabled ? "ButtonBlue11px" : "ButtonBlue11pxDisable";
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    #endregion

    #region accionBotones

    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        agregarNuevoMovimiento();
    }

    private void agregarNuevoMovimiento()
    {
        try
        {
            List<Movimiento> listaMovimientos = new List<Movimiento>();
            listaMovimientos = (List<Movimiento>)Session["SSlistaMovimientos"];
            limpiarControles();
            cboTipoMovimiento.SelectedIndex = 0;
            cboGenero.SelectedIndex = 0;
            txtFechaMovimiento.Text = "";
            txtComentario.Text = "";
            habilitarControles(true);
            habilitarBotones(true);
            inicializarVista();
            txtFechaMovimiento.Text = System.DateTime.Now.ToShortDateString();
            Session["accion"] = Enum.Nuevo;
            Byte idmov = Convert.ToByte(Session["SSMov"]);
            for (int i = 0; i < listaMovimientos.Count; i++)
            {
                idmov = listaMovimientos[i].idMovimiento;
            }
            idmov = Convert.ToByte(idmov + 1);
            txtNumeroMovimiento.Text = Convert.ToString(idmov);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    protected void btnGuardar_Click(object sender, EventArgs e)
    {
        guardarMovimiento();
    }

    private void guardarMovimiento()
    {
        try
        {
            if (verificarCampos())
            {
                Movimiento movimiento = new Movimiento();
                DetalleMovimiento detalleMovimiento = new DetalleMovimiento();
                ExpedienteMVL expedienteMVL = new ExpedienteMVL();
                Byte idmov = Convert.ToByte(txtNumeroMovimiento.Text);

                // Asignaciones -----------------------------------------------------------------------------------
                movimiento = asignarMovimiento();
                //DetalleMovimiento
                if (ibtGenerarEscrito.Visible || cboDependencia.Visible || txtNumeroResolucion.Visible)
                { detalleMovimiento = asignarDetalleMovimiento(movimiento); }
                //ExpedienteMVL
                if ((cboCodigoExpedienteMVL.Visible && txtNumeroExpedienteMVL.Visible && txtAnioExpediente.Visible)
                    || cboExpedientesGeneradosMVL.Visible)
                {
                    expedienteMVL = asignarExpedienteMVL();
                    if (expedienteMVL.idExpediente == 0)
                    {
                        MostrarMensaje("No se puede asociar el expediente MVL");
                        return;
                    }
                }
                // Agregado Nico 12/08
                Expediente expediente = new Expediente();
                expediente.idExpediente = Convert.ToInt32(txtExpediente.Text);
                if (cboPasar.Visible)
                {
                    expediente.informante.idPersona = Convert.ToInt32(cboPasar.SelectedValue);
                    Session["informante"] = expediente.informante.idPersona;
                }
                if (txtFechaArchivo.Visible && cboFines.Visible)
                {
                    expediente.fechaArchivo = Convert.ToDateTime(txtFechaArchivo.Text);
                    expediente.fin.idFin = Convert.ToByte(cboFines.SelectedValue);
                    Session["fechaArchivo"] = expediente.fechaArchivo;
                    Session["idFin"] = expediente.fin.idFin;
                }

                // ------------------------------------------------------------------------------------------------
                if (Session["accion"].Equals(Enum.Nuevo))

                { NegocioMovimientos.Agregar(movimiento, detalleMovimiento, expedienteMVL, expediente); }
                else
                { NegocioMovimientos.Modificar(movimiento, detalleMovimiento, expedienteMVL, expediente); }

                // Actualizacion de listas -------------------------------------------------------------------------
                actualizarListaMovimientos(movimiento);
                if (detalleMovimiento.idExpediente != 0)
                { actualizarListaDetalleMovimientos(detalleMovimiento); }
                if (expedienteMVL.idExpediente != 0)
                {
                    actualizarListaExpedientesMVL(expedienteMVL);
                    cargarExpedientesMVLGenerados();
                }
                // -------------------------------------------------------------------------------------------------

                habilitarControles(false);
                habilitarBotones(false);
                // Una vez finalizada la transacción, si se generó un archivo se modificará el botón.               
                if (Convert.ToInt32(Session["generoArchivo"]) == 1)
                {
                    ibtVerEscrito.Visible = true;
                    lblVerEscrito.Visible = true;
                    ibtVerEscrito.Enabled = true;
                    lblVerEscrito.Enabled = true;

                    lblGenerarEscrito.Visible = false;
                    ibtGenerarEscrito.Visible = false;
                    lblGenerarEscrito.Enabled = false;
                    ibtGenerarEscrito.Enabled = false;
                }
                Session["generoArchivo"] = 0;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    protected void btnModificar_Click(object sender, EventArgs e)
    {
        try
        {
            Byte idmov;
            Int32 cantidad;
            List<Movimiento> listaMovimientos = new List<Movimiento>();
            listaMovimientos = (List<Movimiento>)Session["SSlistaMovimientos"];
            idmov = Convert.ToByte(txtNumeroMovimiento.Text);
            cantidad = listaMovimientos.Count;
            //if (idmov != listaMovimientos[cantidad - 1].idMovimiento)
            //{
            //    MostrarMensaje("Movimiento inexistente. Se cargará el primer movimiento.");
            //    Session["SSMov"] = listaMovimientos[0].idMovimiento;
            //    limpiarControles();
            //    cargarElementos();
            //    cambiarVista();
            //    cargarDatosAdicionales();                
            //    return;
            //}
            habilitarControles(true);
            habilitarBotones(true);
            Session["accion"] = Enum.Modificar;
        }        
        catch (Exception ex)
        {
            throw ex;
        }
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        try {
            Session["accion"] = Enum.Eliminar;
            Movimiento movimiento = new Movimiento();
            DetalleMovimiento detalleMovimiento = new DetalleMovimiento();
            ExpedienteMVL expedienteMVL = new ExpedienteMVL();
            movimiento = asignarMovimiento();

            if (ibtGenerarEscrito.Visible || cboDependencia.Visible || txtNumeroResolucion.Visible)
            { detalleMovimiento = asignarDetalleMovimiento(movimiento); }
            //ExpedienteMVL
            if ((cboCodigoExpedienteMVL.Visible && txtNumeroExpedienteMVL.Visible && txtAnioExpediente.Visible)
                || cboExpedientesGeneradosMVL.Visible)
            {
                expedienteMVL.idExpediente = Convert.ToInt32(txtExpediente.Text);
                expedienteMVL = asignarExpedienteMVL();
                expedienteMVL.accion = ExpedienteMVL.eAccion.Eliminar;
                if (expedienteMVL.idMovimiento == Convert.ToByte(txtNumeroMovimiento.Text))
                {
                    if (expedienteMVL.idMovimientoRecepcion != 0 || expedienteMVL.idMovimientoDevolucion != 0) 
                    {
                        MostrarMensaje("No se puede eliminar el expediente MVL, tiene movimientos asociados.");
                        return;
                    }
                }
                if (expedienteMVL.idMovimientoRecepcion == Convert.ToByte(txtNumeroMovimiento.Text))
                {
                    if (expedienteMVL.idMovimientoDevolucion != 0)
                    {
                        MostrarMensaje("No se puede eliminar el expediente MVL, tiene movimientos asociados.");
                        return;
                    }
                    expedienteMVL.idMovimientoRecepcion = 0;
                    expedienteMVL.accion = ExpedienteMVL.eAccion.Modificar;
                }
                if (expedienteMVL.idMovimientoDevolucion == Convert.ToByte(txtNumeroMovimiento.Text))
                {
                    expedienteMVL.idMovimientoDevolucion = 0;
                    expedienteMVL.accion = ExpedienteMVL.eAccion.Modificar;
                }
            }

            NegocioMovimientos.Eliminar(movimiento,detalleMovimiento,expedienteMVL);

            if (expedienteMVL.idMovimiento == Convert.ToByte(txtNumeroMovimiento.Text))
            { cargarExpedientesMVLGenerados(); }
            actualizarListaMovimientos(movimiento);
            actualizarListaDetalleMovimientos(detalleMovimiento);
            actualizarListaExpedientesMVL(expedienteMVL);
            this.cargarElementos();
            this.cargarDatosAdicionales();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {
        Int32 cantidad;
        List<Movimiento> listaMovimientos = new List<Movimiento>();
        listaMovimientos = (List<Movimiento>)Session["SSlistaMovimientos"];
        cantidad = listaMovimientos.Count;
        if (cantidad == 0) 
        {
            MostrarMensaje("Sin Movimientos para mostrar. Se redireccionará a la página anterior.");
            salirMovimientos();
        }

        if (Convert.ToByte(txtNumeroMovimiento.Text) != listaMovimientos[cantidad - 1].idMovimiento)
        {
            Session["SSMov"] = listaMovimientos[0].idMovimiento;
        }

        if (Session["accion"].Equals(Enum.Nuevo))
        {
            inicializarVista();
            limpiarControles();
            cboTipoMovimiento.SelectedIndex = 0;
            this.cargarElementos();
        }
        habilitarControles(false);
        habilitarBotones(false);
        Session["generoArchivo"] = 0;
    }

    protected void ibtVerEscrito_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            AppSettingsReader x = new AppSettingsReader();
            String carpeta = (string)x.GetValue("rutaArchivo", typeof(string));
            //string carpeta = "C:\\archivosServidor\\";
            Int16 tm;
            tm = Convert.ToInt16(cboTipoMovimiento.SelectedValue);
            if (tm == 1) {             
                string file = "reiteracion_dos_" + txtExpediente.Text + "_" + txtNumeroMovimiento.Text + ".doc";
                FileInfo finfo = new FileInfo(carpeta + file);
                if (finfo.Exists == true) { System.Diagnostics.Process.Start(carpeta + file); }
            }
            if (tm == 8) {             
                string file = "cedula_" + txtExpediente.Text + "_" + txtNumeroMovimiento.Text + ".doc";
                FileInfo finfo = new FileInfo(carpeta + file);
                if (finfo.Exists == true) { System.Diagnostics.Process.Start(carpeta + file); }
            }
            if (tm == 9)
            {
                string file = "devolucion_" + txtExpediente.Text + "_" + txtNumeroMovimiento.Text + ".doc";
                FileInfo finfo = new FileInfo(carpeta + file);
                if (finfo.Exists == true) { System.Diagnostics.Process.Start(carpeta + file); }
            }
            if (tm == 12)
            {
                string file = "nota_denunciante_" + txtExpediente.Text + "_" + txtNumeroMovimiento.Text + ".doc";
                FileInfo finfo = new FileInfo(carpeta + file);
                if (finfo.Exists == true) { System.Diagnostics.Process.Start(carpeta + file); }
            }
            if (tm == 13)
            {
                string file = "nota_externa_" + txtExpediente.Text + "_" + txtNumeroMovimiento.Text + ".doc";
                FileInfo finfo = new FileInfo(carpeta + file);
                if (finfo.Exists == true) { System.Diagnostics.Process.Start(carpeta + file); }
            } 
            if (tm == 14)
            {
                string file = "nota_interna_" + txtExpediente.Text + "_" + txtNumeroMovimiento.Text + ".doc";
                FileInfo finfo = new FileInfo(carpeta + file);
                if (finfo.Exists == true) { System.Diagnostics.Process.Start(carpeta + file); }
            }
            if (tm == 27)
            {
                string file = "reiteracion_uno_" + txtExpediente.Text + "_" + txtNumeroMovimiento.Text + ".doc";
                FileInfo finfo = new FileInfo(carpeta + file);
                if (finfo.Exists == true) { System.Diagnostics.Process.Start(carpeta + file); }
            }
            if (tm == 29)
            {
                string file = "resolucion_" + txtExpediente.Text + "_" + txtNumeroMovimiento.Text + ".doc";
                FileInfo finfo = new FileInfo(carpeta + file);
                if (finfo.Exists == true) { System.Diagnostics.Process.Start(carpeta + file); }
            }
            if (tm == 31)
            {
                string file = "solicitud_exp_" + txtExpediente.Text + "_" + txtNumeroMovimiento.Text + ".doc";
                FileInfo finfo = new FileInfo(carpeta + file);
                if (finfo.Exists == true) { System.Diagnostics.Process.Start(carpeta + file);                
                }
            }
            if (tm == 32)
            {
                string file = "solicitud_inf_" + txtExpediente.Text + "_" + txtNumeroMovimiento.Text + ".doc";
                FileInfo finfo = new FileInfo(carpeta + file);
                if (finfo.Exists == true)
                {
                    System.Diagnostics.Process.Start(carpeta + file);
                }
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    protected void ibtGenerarEscrito_Click(object sender, ImageClickEventArgs e)
    {
        try
        {
            if (!verificarCampos())
            {
                return;
            }
            Int16 tm;
            AppSettingsReader x = new AppSettingsReader();
            String carpeta = (string)x.GetValue("rutaArchivo", typeof(string));
            tm = Convert.ToInt16(cboTipoMovimiento.SelectedValue);
            if (tm == 1)
            {//2º Reiteración pedido
                string file = "reiteracion_dos_" + txtExpediente.Text + "_" + txtNumeroMovimiento.Text + ".doc";
                string strBody = "<html><body><table width=100% border=1><tr><td><u>Defensor del Pueblo de Vicente L&oacute;pez</u><img src=Imagenes//logo.png width=223 height=127 /></td></tr><tr><td>";
                string strCuerpo = "<p align=right>Vicente  L&oacute;pez, " + devolverFechaParaDocumento() + "</p>     <p>Señor Presidente del E.T.O.S.S<br />Dr. Carlos Mar&iacute;a Vilas<br /><u>S                      /                    D</u></p><h4>Ref. expte. DP 16427</h4><p>&nbsp;</p><p>Ud. con  relaci&oacute;n a un reclamo formulado por la señora Elba Haydee Pedemonte, con  domicilio en la calle C&oacute;rdoba 2526 Dto 3, de Olivos, Pdo. de Vicente L&oacute;pez,  tel&eacute;fono 4790-2301, <p>Atento a lo  precedentemente planteado agradecer&iacute;a vuestra intervenci&oacute;n.</p><p>Saludo a Ud.  con mi mayor consideraci&oacute;n.</p><p>&nbsp;</p>";
                string strPie = "</td></tr><tr><td><p align=center><strong>M. Pelliza  1401. (B1636FCS) Vicente L&oacute;pez. Buenos Aires. Rep&uacute;blica Argentina</strong></p><p align=center><strong>Tel&eacute;fono/fax: (54)-(011)-4799-5119/5127/5146</strong><br /><strong>e-mail: </strong><a name=_Hlt453383388 id=_Hlt453383388><strong>corre</strong></a><a name=_Hlt453384021 id=_Hlt453384021><strong>o</strong></a><strong>@de<a name=_Hlt453383826 id=_Hlt453383826>f</a>ensorvlopez.gov.ar</strong> <strong> </strong><br /><strong>Sitio Web: www.defensorvlopez.gov.ar</strong> </p></td></tr></table></body></html>";
                StreamWriter sw = new StreamWriter(carpeta + file);
                sw.WriteLine(strBody + strCuerpo + strPie);
                sw.Close();
                System.Diagnostics.Process.Start(carpeta + file);               
                //NegocioDetalleMovimiento.ModificarArchivo(Convert.ToInt16(txtExpediente.Text), Convert.ToInt16(txtNumeroMovimiento.Text), 1);
            }

            if (tm == 8)
            {//Cédula notificación
                string file = "cedula_" + txtExpediente.Text + "_" + txtNumeroMovimiento.Text + ".doc";
                string strBody = "<html><body><table width=100% border=1><tr><td><u>Defensor del Pueblo de Vicente L&oacute;pez</u><img src=Imagenes//logo.png width=223 height=127 /></td></tr><tr><td>";
                string strCuerpo = "<p align=right>Vicente  L&oacute;pez, " + devolverFechaParaDocumento() + "</p>     <p>Señor Presidente del E.T.O.S.S<br />Dr. Carlos María Vilas<br /><u>S                      /                    D</u></p><h4>Ref. expte. DP 16427</h4><p>&nbsp;</p><p>Ud. con  relación a un reclamo formulado por la señora Elba Haydee Pedemonte, con  domicilio en la calle C&oacute;rdoba 2526 Dto 3, de Olivos, Pdo. de Vicente López,  teléfono 4790-2301, <p>Atento a lo  precedentemente planteado agradecería vuestra intervención.</p><p>Saludo a Ud.  con mi mayor consideración.</p><p>&nbsp;</p>";
                string strPie = "</td></tr><tr><td><p align=center><strong>M. Pelliza  1401. (B1636FCS) Vicente López. Buenos Aires. República Argentina</strong></p><p align=center><strong>Tel&eacute;fono/fax: (54)-(011)-4799-5119/5127/5146</strong><br /><strong>e-mail: </strong><a name=_Hlt453383388 id=_Hlt453383388><strong>corre</strong></a><a name=_Hlt453384021 id=_Hlt453384021><strong>o</strong></a><strong>@de<a name=_Hlt453383826 id=_Hlt453383826>f</a>ensorvlopez.gov.ar</strong> <strong> </strong><br /><strong>Sitio Web: www.defensorvlopez.gov.ar</strong> </p></td></tr></table></body></html>";
                StreamWriter sw = new StreamWriter(carpeta + file);
                sw.WriteLine(strBody + strCuerpo + strPie);
                sw.Close();
                System.Diagnostics.Process.Start(carpeta + file);
                //NegocioDetalleMovimiento.ModificarArchivo(Convert.ToInt16(txtExpediente.Text), Convert.ToInt16(txtNumeroMovimiento.Text), 1);
            }

            if (tm == 9)
            {//Devolución exp. MVL
                string file = "devolucion_" + txtExpediente.Text + "_" + txtNumeroMovimiento.Text + ".doc";
                string strBody = "<html>" + "<body>" + "Correspondiente al Expediente Nº" + cboCodigoExpedienteMVL.SelectedValue.ToString() + "-" + txtNumeroExpedienteMVL.Text + "/" + txtAnioExpediente.Text + "<br>" +"DEFENSORIA DEL PUEBLO," + txtFechaArchivo.Text + "</body>" + "</html>";
                StreamWriter sw = new StreamWriter(carpeta+ file);
                sw.WriteLine(strBody);
                sw.Close();
                System.Diagnostics.Process.Start(carpeta + file);
                //NegocioDetalleMovimiento.ModificarArchivo(Convert.ToInt16(txtExpediente.Text),Convert.ToInt16( txtNumeroMovimiento.Text),1);               
            }
            if (tm == 12)
            {//Envío nota a denunciante
                string file = "nota_denunciante_" + txtExpediente.Text + "_" + txtNumeroMovimiento.Text + ".doc";
                string strBody = "<html><body><table width=100% border=1><tr><td><u>Defensor del Pueblo de Vicente L&oacute;pez</u><img src=Imagenes//logo.png width=223 height=127 /></td></tr><tr><td>";
                string strCuerpo = "<p align=right>Vicente  L&oacute;pez, " + devolverFechaParaDocumento() + "</p>     <p>Señor Presidente del E.T.O.S.S<br />Dr. Carlos Mar&iacute;a Vilas<br /><u>S                      /                    D</u></p><h4>Ref. expte. DP " + txtNumeroExpedienteMVL.Text + "</h4><p>&nbsp;</p><p>Ud. con  relaci&oacute;n a un reclamo formulado por -----------, con  domicilio en la calle -----------, de -----------, Pdo. de -----------,  teléfono -----------,</p><p>Atento a lo  precedentemente planteado agradecería vuestra intervenci&oacute;n.</p><p>Saludo a Ud.  con mi mayor consideraci&oacute;n.</p><p>&nbsp;</p>";
                string strPie = "</td></tr><tr><td><p align=center><strong>M. Pelliza  1401. (B1636FCS) Vicente L&oacute;pez. Buenos Aires. Rep&uacute;blica Argentina</strong></p><p align=center><strong>Tel&eacute;fono/fax: (54)-(011)-4799-5119/5127/5146</strong><br /><strong>e-mail: </strong><a name=_Hlt453383388 id=_Hlt453383388><strong>corre</strong></a><a name=_Hlt453384021 id=_Hlt453384021><strong>o</strong></a><strong>@de<a name=_Hlt453383826 id=_Hlt453383826>f</a>ensorvlopez.gov.ar</strong> <strong> </strong><br /><strong>Sitio Web: www.defensorvlopez.gov.ar</strong> </p></td></tr></table></body></html>";
                StreamWriter sw = new StreamWriter(carpeta + file);
                sw.WriteLine(strBody + strCuerpo + strPie);
                sw.Close();
                System.Diagnostics.Process.Start(carpeta + file);
                //NegocioDetalleMovimiento.ModificarArchivo(Convert.ToInt16(txtExpediente.Text), Convert.ToInt16(txtNumeroMovimiento.Text), 1);     
            }
            if (tm == 13)
            {//Envío nota externa
                string file = "nota_externa_" + txtExpediente.Text + "_" + txtNumeroMovimiento.Text + ".doc";
                string strBody = "<html><body><table width=100% border=1><tr><td><u>Defensor del Pueblo de Vicente L&oacute;pez</u><img src=Imagenes//logo.png width=223 height=127 /></td></tr><tr><td>";
                string strCuerpo = "<p align=right>Vicente  L&oacute;pez, " + devolverFechaParaDocumento() + "</p>     <p>Señor Presidente del E.T.O.S.S<br />Dr. Carlos Mar&iacute;a Vilas<br /><u>S                      /                    D</u></p><h4>Ref. expte. DP " + txtNumeroExpedienteMVL.Text + "</h4><p>&nbsp;</p><p>Ud. con  relaci&oacute;n a un reclamo formulado por -----------,, con  domicilio en la calle -----------,, de -----------,, Pdo. de -----------,,  tel&eacute;fono -----------, <p>Atento a lo  precedentemente planteado agradecería vuestra intervención.</p><p>Saludo a Ud.  con mi mayor consideraci&oacute;n.</p><p>&nbsp;</p>";
                string strPie = "</td></tr><tr><td><p align=center><strong>M. Pelliza  1401. (B1636FCS) Vicente L&oacute;pez. Buenos Aires. Rep&uacute;blica Argentina</strong></p><p align=center><strong>Tel&eacute;fono/fax: (54)-(011)-4799-5119/5127/5146</strong><br /><strong>e-mail: </strong><a name=_Hlt453383388 id=_Hlt453383388><strong>corre</strong></a><a name=_Hlt453384021 id=_Hlt453384021><strong>o</strong></a><strong>@de<a name=_Hlt453383826 id=_Hlt453383826>f</a>ensorvlopez.gov.ar</strong> <strong> </strong><br /><strong>Sitio Web: www.defensorvlopez.gov.ar</strong> </p></td></tr></table></body></html>";
                StreamWriter sw = new StreamWriter(carpeta + file);
                sw.WriteLine(strBody + strCuerpo + strPie);
                sw.Close();
                System.Diagnostics.Process.Start(carpeta + file);
                //NegocioDetalleMovimiento.ModificarArchivo(Convert.ToInt16(txtExpediente.Text), Convert.ToInt16(txtNumeroMovimiento.Text), 1);
            }
            if (tm == 14)
            {//Envío nota interna
                string file = "nota_interna_" + txtExpediente.Text + "_" + txtNumeroMovimiento.Text + ".doc";
                string strBody = "<html><body><table width=100% border=1><tr><td><u>Defensor del Pueblo de Vicente L&oacute;pez</u><img src=Imagenes//logo.png width=223 height=127 /></td></tr><tr><td>";
                string strCuerpo = "<p align=right>Vicente  L&oacute;pez, " + devolverFechaParaDocumento() + "</p>     <p>Señor Presidente del E.T.O.S.S<br />Dr. Carlos María Vilas<br /><u>S                      /                    D</u></p><h4>Ref. expte. DP " + txtNumeroExpedienteMVL.Text + "</h4><p>&nbsp;</p><p>Ud. con  relación a un reclamo formulado por la señora Elba Haydee Pedemonte, con  domicilio en la calle Córdoba 2526 Dto 3, de Olivos, Pdo. de Vicente L&oacute;pez,  teléfono 4790-2301, quien denuncia la deficiente prestación en el servicio de  provisi&oacute;n de agua corriente debido a la baja presión de la misma.</p><p>Por tal motivo  realiz&oacute; el pertinente reclamo ante la empresa prestadora bajo el número  20031596, sin haber recibido respuesta hasta la actualidad.</p><p>Se adjunta  fotocopia de la documentación pertinente que consta de seis fojas &uacute;tiles.</p><p>Atento a lo  precedentemente planteado agradecería vuestra intervenci&oacute;n.</p><p>Saludo a Ud.  con mi mayor consideraci&oacute;n.</p><p>&nbsp;</p>";
                string strPie = "</td></tr><tr><td><p align=center><strong>M. Pelliza  1401. (B1636FCS) Vicente López. Buenos Aires. Rep&uacute;blica Argentina</strong></p><p align=center><strong>Tel&eacute;fono/fax: (54)-(011)-4799-5119/5127/5146</strong><br /><strong>e-mail: </strong><a name=_Hlt453383388 id=_Hlt453383388><strong>corre</strong></a><a name=_Hlt453384021 id=_Hlt453384021><strong>o</strong></a><strong>@de<a name=_Hlt453383826 id=_Hlt453383826>f</a>ensorvlopez.gov.ar</strong> <strong> </strong><br /><strong>Sitio Web: www.defensorvlopez.gov.ar</strong> </p></td></tr></table></body></html>";
                StreamWriter sw = new StreamWriter(carpeta + file);
                sw.WriteLine(strBody + strCuerpo + strPie);
                sw.Close();
                System.Diagnostics.Process.Start(carpeta + file);
                //NegocioDetalleMovimiento.ModificarArchivo(Convert.ToInt16(txtExpediente.Text), Convert.ToInt16(txtNumeroMovimiento.Text), 1);
            }
            if (tm == 27)
            {//Reiteración pedido
                string file = "reiteracion_uno_" + txtExpediente.Text + "_" + txtNumeroMovimiento.Text + ".doc";
                string strBody = "<html><body><table width=100% border=1><tr><td><u>Defensor del Pueblo de Vicente L&oacute;pez</u><img src=Imagenes//logo.png width=223 height=127 /></td></tr><tr><td>";
                string strCuerpo = "<p align=right>Vicente  L&oacute;pez, " + devolverFechaParaDocumento() + "</p>     <p>Señor Presidente del E.T.O.S.S<br />Dr. Carlos María Vilas<br /><u>S                      /                    D</u></p><h4>Ref. expte. DP 16427</h4><p>&nbsp;</p><p>Ud. con  relación a un reclamo formulado por la señora Elba Haydee Pedemonte, con  domicilio en la calle C&oacute;rdoba 2526 Dto 3, de Olivos, Pdo. de Vicente López,  teléfono 4790-2301, <p>Atento a lo  precedentemente planteado agradecería vuestra intervención.</p><p>Saludo a Ud.  con mi mayor consideración.</p><p>&nbsp;</p>";
                string strPie = "</td></tr><tr><td><p align=center><strong>M. Pelliza  1401. (B1636FCS) Vicente López. Buenos Aires. República Argentina</strong></p><p align=center><strong>Tel&eacute;fono/fax: (54)-(011)-4799-5119/5127/5146</strong><br /><strong>e-mail: </strong><a name=_Hlt453383388 id=_Hlt453383388><strong>corre</strong></a><a name=_Hlt453384021 id=_Hlt453384021><strong>o</strong></a><strong>@de<a name=_Hlt453383826 id=_Hlt453383826>f</a>ensorvlopez.gov.ar</strong> <strong> </strong><br /><strong>Sitio Web: www.defensorvlopez.gov.ar</strong> </p></td></tr></table></body></html>";
                StreamWriter sw = new StreamWriter(carpeta + file);
                sw.WriteLine(strBody + strCuerpo + strPie);
                sw.Close();
                System.Diagnostics.Process.Start(carpeta + file);
                //NegocioDetalleMovimiento.ModificarArchivo(Convert.ToInt16(txtExpediente.Text), Convert.ToInt16(txtNumeroMovimiento.Text), 1);
            }
            if (tm == 29)
            {//Resolución
                string file = "resolucion_" + txtExpediente.Text + "_" + txtNumeroMovimiento.Text + ".doc";
                string strBody = "<html><body><table width=100% border=0><tr><td><u>Defensor del Pueblo de Vicente L&oacute;pez</u><img src=Imagenes//logo.png width=223 height=127 /></td></tr><tr><td>"
                + "<center><table border=1 align=center><tr><td>"
                    + " XXº Reiteracion"
                     + "</td></tr></table></center>";
                string strCuerpo = "<p align=right>Vicente  L&oacute;pez, " + devolverFechaParaDocumento() + "</p>     <p>Señor Presidente del E.T.O.S.S<br />Dr. Carlos María Vilas<br /><u>S                      /                    D</u></p><h4>Ref. expte. DP 16427</h4><p>&nbsp;</p>"
                    + "<p>Ud. con  relación a un reclamo formulado por la señora Elba Haydee Pedemonte, con  domicilio en la calle Córdoba 2526 Dto 3, de Olivos, Pdo. de Vicente L&oacute;pez,  tel&eacute;fono 4790-2301, quien denuncia "
                    + "<table border=1><tr><td>"
                    + "“Son funciones del Defensor del Pueblo... inciso d) Solicitar informes referidos a las denuncias recibidas... Dichos informes, recomendaciones o sugerencias serán dirigidas directamente a las distintas dependencias de los organismos municipales mencionados en los artículos 1º y 2º de esta ordenanza, quienes deberán responder por escrito en un plazo no mayor a los (30) días...”"
                     + "</td></tr></table>"
                    + "<p>Atento a lo  precedentemente planteado agradecería vuestra intervención.</p><p>Saludo a Ud.  con mi mayor consideración.</p><p>&nbsp;</p>";
                string strPie = "</td></tr><tr><td><p align=center><strong>M. Pelliza  1401. (B1636FCS) Vicente López. Buenos Aires. Rep&uacute;blica Argentina</strong></p><p align=center><strong>Teléfono/fax: (54)-(011)-4799-5119/5127/5146</strong><br /><strong>e-mail: </strong><a name=_Hlt453383388 id=_Hlt453383388><strong>corre</strong></a><a name=_Hlt453384021 id=_Hlt453384021><strong>o</strong></a><strong>@de<a name=_Hlt453383826 id=_Hlt453383826>f</a>ensorvlopez.gov.ar</strong> <strong> </strong><br /><strong>Sitio Web: www.defensorvlopez.gov.ar</strong> </p></td></tr></table></body></html>";
                StreamWriter sw = new StreamWriter(carpeta + file);
                sw.WriteLine(strBody + strCuerpo + strPie);
                sw.Close();
                System.Diagnostics.Process.Start(carpeta + file);
                //NegocioDetalleMovimiento.ModificarArchivo(Convert.ToInt16(txtExpediente.Text), Convert.ToInt16(txtNumeroMovimiento.Text), 1);
            }
            if (tm == 31)
            {//Solicitud expediente MVL
                string file = "solicitud_exp_" + txtExpediente.Text + "_" + txtNumeroMovimiento.Text + ".doc";
                string strBody = "<html><body><table width=100% border=1><tr><td><u>Defensor del Pueblo de Vicente López</u><img src=Imagenes//logo.png width=223 height=127 /></td></tr><tr><td>";
                string strCuerpo = "<p align=right>Vicente  L&oacute;pez, " + devolverFechaParaDocumento() + "</p>     <p>Señor Presidente del E.T.O.S.S<br />Dr. Carlos María Vilas<br /><u>S                      /                    D</u></p><h4>Ref. expte. DP 16427</h4><p>&nbsp;</p><p>Ud. con  relación a un reclamo formulado por la señora Elba Haydee Pedemonte, con  domicilio en la calle Córdoba 2526 Dto 3, de Olivos, Pdo. de Vicente López,  tel&eacute;fono 4790-2301, <p>Atento a lo  precedentemente planteado agradecería vuestra intervención.</p><p>Saludo a Ud.  con mi mayor consideración.</p><p>&nbsp;</p>";
                string strPie = "</td></tr><tr><td><p align=center><strong>M. Pelliza  1401. (B1636FCS) Vicente López. Buenos Aires. Rep&uacute;blica Argentina</strong></p><p align=center><strong>Teléfono/fax: (54)-(011)-4799-5119/5127/5146</strong><br /><strong>e-mail: </strong><a name=_Hlt453383388 id=_Hlt453383388><strong>corre</strong></a><a name=_Hlt453384021 id=_Hlt453384021><strong>o</strong></a><strong>@de<a name=_Hlt453383826 id=_Hlt453383826>f</a>ensorvlopez.gov.ar</strong> <strong> </strong><br /><strong>Sitio Web: www.defensorvlopez.gov.ar</strong> </p></td></tr></table></body></html>";
                StreamWriter sw = new StreamWriter(carpeta + file);
                sw.WriteLine(strBody + strCuerpo + strPie);
                sw.Close();
                System.Diagnostics.Process.Start(carpeta + file);
                NegocioDetalleMovimiento.ModificarArchivo(Convert.ToInt16(txtExpediente.Text), Convert.ToInt16(txtNumeroMovimiento.Text), 1);
            }
            if (tm == 32)
            {//Solicitud informes MVL
                string file = "solicitud_inf_" + txtExpediente.Text + "_" + txtNumeroMovimiento.Text + ".doc";
                string strBody = "<html><body><table width=100% border=1><tr><td><u>Defensor del Pueblo de Vicente L&oacute;pez</u><img src=Imagenes//logo.png width=223 height=127 /></td></tr><tr><td>";
                string strCuerpo = "<p align=right>Vicente  L&oacute;pez, " + devolverFechaParaDocumento() + "</p>     <p>Señor Presidente del E.T.O.S.S<br />Dr. Carlos María Vilas<br /><u>S                      /                    D</u></p><h4>Ref. expte. DP 16427</h4><p>&nbsp;</p><p>Ud. con  relación a un reclamo formulado por la señora Elba Haydee Pedemonte, con  domicilio en la calle C&oacute;rdoba 2526 Dto 3, de Olivos, Pdo. de Vicente López,  teléfono 4790-2301, <p>Atento a lo  precedentemente planteado agradecería vuestra intervención.</p><p>Saludo a Ud.  con mi mayor consideración.</p><p>&nbsp;</p>";
                string strPie = "</td></tr><tr><td><p align=center><strong>M. Pelliza  1401. (B1636FCS) Vicente López. Buenos Aires. República Argentina</strong></p><p align=center><strong>Tel&eacute;fono/fax: (54)-(011)-4799-5119/5127/5146</strong><br /><strong>e-mail: </strong><a name=_Hlt453383388 id=_Hlt453383388><strong>corre</strong></a><a name=_Hlt453384021 id=_Hlt453384021><strong>o</strong></a><strong>@de<a name=_Hlt453383826 id=_Hlt453383826>f</a>ensorvlopez.gov.ar</strong> <strong> </strong><br /><strong>Sitio Web: www.defensorvlopez.gov.ar</strong> </p></td></tr></table></body></html>";
                StreamWriter sw = new StreamWriter(carpeta + file);
                sw.WriteLine(strBody + strCuerpo + strPie);
                sw.Close();
                System.Diagnostics.Process.Start(carpeta + file);
                //NegocioDetalleMovimiento.ModificarArchivo(Convert.ToInt16(txtExpediente.Text), Convert.ToInt16(txtNumeroMovimiento.Text), 1);
            }
            Session["generoArchivo"] = 1;
            guardarMovimiento();
        }   
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }
    }

    protected void btnSalir_Click(object sender, EventArgs e)
    {
        salirMovimientos();
    }

    private void salirMovimientos()
    {
        Session.Remove("camposTipoMovimiento");
        Session.Remove("listaExpedienteMVL");
        Session.Remove("listaDetalleMovimiento");
        Session.Remove("accion");
        Session.Remove("SSlistaMovimientos");
        Session.Remove("SSMov");
        Session.Remove("informante");
        Session.Remove("fechaArchivo");
        Session.Remove("idFin");
        Session.Remove("generoArchivo");

        String cadena;
        cadena = Convert.ToString(Session["pagina"]);
        if (cadena == "BuscarMovimientoNuevo")
            Response.Redirect("BuscarMovimiento.aspx");
        else
            Response.Redirect("ListarMovimientos.aspx?idExpediente=" + txtExpediente.Text);
    }

    #endregion

    #region navegacionMovimientos

    protected void btnPrimero_Click(object sender, EventArgs e)
    {
        try 
        {
            List<Movimiento> listaMovimientos = new List<Movimiento>();
            listaMovimientos = (List<Movimiento>)Session["SSlistaMovimientos"];
            Session["SSMov"] = listaMovimientos[0].idMovimiento;
            limpiarControles();
            cargarElementos();
            cambiarVista();
            cargarDatosAdicionales();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        
    }

    protected void btnAnterior_Click(object sender, EventArgs e)
    {
        try
        {
            Byte idmov;
            Int32 cantidad;
            List<Movimiento> listaMovimientos = new List<Movimiento>();
            listaMovimientos = (List<Movimiento>)Session["SSlistaMovimientos"];
            cantidad = listaMovimientos.Count;
            idmov = Convert.ToByte(Session["SSMov"]);
            if (idmov == listaMovimientos[0].idMovimiento) 
            {
                return;
            }
            for (int i = 0; i < listaMovimientos.Count; i++)
            {
                if (listaMovimientos[i].idMovimiento == idmov)
                {
                    idmov = listaMovimientos[i - 1].idMovimiento;
                    i = listaMovimientos.Count;
                }
            }
            Session["SSMov"] = idmov;
            limpiarControles();
            cargarElementos();
            cambiarVista();
            cargarDatosAdicionales();                
        }
        catch (Exception ex)
        {
            throw ex;
        }
        
    }

    protected void btnSiguiente_Click1(object sender, EventArgs e)
    {
        try 
        {
            Byte idmov;
            Int32 cantidad;
            List<Movimiento> listaMovimientos = new List<Movimiento>();
            listaMovimientos = (List<Movimiento>)Session["SSlistaMovimientos"];
            cantidad = listaMovimientos.Count;
            idmov = Convert.ToByte(Session["SSMov"]);
            if (idmov == listaMovimientos[cantidad - 1].idMovimiento)
            {
                return;
            }
            for (int i = 0; i < cantidad; i++)
            {
                if (listaMovimientos[i].idMovimiento == idmov)
                {
                    idmov = listaMovimientos[i + 1].idMovimiento;
                    i = cantidad;
                }
            }
            Session["SSMov"] = idmov;
            limpiarControles();
            cargarElementos();
            cambiarVista();
            cargarDatosAdicionales();                       
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    protected void btnUltimo_Click(object sender, EventArgs e)
    {
        try
        { 
            List<Movimiento> listaMovimientos = new List<Movimiento>();
            listaMovimientos = (List<Movimiento>)Session["SSlistaMovimientos"];
            int i = listaMovimientos.Count - 1;
            Session["SSMov"] = listaMovimientos[i].idMovimiento;
            limpiarControles();
            cargarElementos();            
            cambiarVista();
            cargarDatosAdicionales();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    #endregion

    #region Asignaciones

    private Movimiento asignarMovimiento() 
    {
        Movimiento movimiento = new Movimiento();
        try
        {
            movimiento.idExpediente = Convert .ToInt32(txtExpediente.Text);
            movimiento.idMovimiento = Convert.ToByte(txtNumeroMovimiento.Text);
            movimiento.idTipoMovimiento = Convert.ToByte(cboTipoMovimiento.SelectedValue);
            movimiento.fechaMovimiento = Convert.ToDateTime(txtFechaMovimiento.Text);
            movimiento.idPersona = Convert.ToByte(cboGenero.SelectedValue);
            movimiento.comentario = txtComentario.Text;
            movimiento.realizado =  Convert.ToByte(chkRespuesta.Checked);                    
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return movimiento;
    }

    private DetalleMovimiento asignarDetalleMovimiento(Movimiento movimiento)
    {
        DetalleMovimiento detalleMovimiento = new DetalleMovimiento(movimiento.idExpediente, movimiento.idMovimiento);
        try
        {
            if (Convert.ToInt32 (Session["generoArchivo"]) == 1) 
            {
                detalleMovimiento.nombreArchivo = "1";
            }         
            if (txtNumeroResolucion.Visible && txtNumeroResolucion.Text.CompareTo("") != 0)
            {
                detalleMovimiento.numeroResolucion = Convert.ToInt16(txtNumeroResolucion.Text);
            }
            if (cboDependencia.Visible && cboDependencia.SelectedIndex != 0)
            {
                detalleMovimiento.idDependencia = Convert.ToByte(cboDependencia.SelectedValue);
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return detalleMovimiento;
    }

    private ExpedienteMVL asignarExpedienteMVL()
    {
        ExpedienteMVL expedienteMVL = new ExpedienteMVL();
        try
        {
            List<ExpedienteMVL> listaExpedienteMVL = new List<ExpedienteMVL>();
            listaExpedienteMVL = (List<ExpedienteMVL>)Session["listaExpedienteMVL"];
            int i = 0;
            int cant = listaExpedienteMVL.Count;
            if (cboExpedientesGeneradosMVL.Visible)
            {                
                // Se verifica cada uno de los expedientes encontrados.
                while (i < cant)
                {
                    //Si es una recepción, se verifica que no este asociada dependiendo del movimiento de solicitud del
                    //expediente.
                    if (cboTipoMovimiento.SelectedValue == "24")
                    {
                        if (listaExpedienteMVL[i].idMovimiento == Convert.ToByte(cboExpedientesGeneradosMVL.SelectedValue))
                        {
                            if (listaExpedienteMVL[i].idMovimientoRecepcion != 0) 
                            {
                                if (!Session["accion"].Equals(Enum.Eliminar)) 
                                { 
                                    expedienteMVL.idExpediente = 0;
                                    return expedienteMVL;
                                }                                
                            }
                            expedienteMVL.idExpediente = listaExpedienteMVL[i].idExpediente;
                            expedienteMVL.idMovimiento = listaExpedienteMVL[i].idMovimiento;
                            expedienteMVL.idMovimientoRecepcion = Convert .ToByte(txtNumeroMovimiento.Text);
                            expedienteMVL.idMovimientoDevolucion = listaExpedienteMVL[i].idMovimientoDevolucion;
                            expedienteMVL.numeroExpedienteMVL = listaExpedienteMVL[i].numeroExpedienteMVL;
                            expedienteMVL.codigoExpedienteMVL = listaExpedienteMVL[i].codigoExpedienteMVL;
                            expedienteMVL.anioExpediente = listaExpedienteMVL[i].anioExpediente;
                            expedienteMVL.accion = ExpedienteMVL.eAccion.Modificar;
                        }                        
                    }
                    //Si es una devolución, se verifica que no este asociada dependiendo del movimiento de solicitud del
                    //expediente, y que también tenga una recepción asociada.
                    if (cboTipoMovimiento.SelectedValue == "9")
                    {
                        if (listaExpedienteMVL[i].idMovimiento == Convert.ToByte(cboExpedientesGeneradosMVL.SelectedValue))
                        {
                            if (listaExpedienteMVL[i].idMovimientoRecepcion == 0)
                            {
                                expedienteMVL.idExpediente = 0;
                                return expedienteMVL;
                            }
                            else
                            { 
                                if (listaExpedienteMVL[i].idMovimientoDevolucion != 0)
                                {
                                    if (!Session["accion"].Equals(Enum.Eliminar))
                                    {
                                        expedienteMVL.idExpediente = 0;
                                        return expedienteMVL;
                                    }
                                }
                                expedienteMVL.idExpediente = listaExpedienteMVL[i].idExpediente;
                                expedienteMVL.idMovimiento = listaExpedienteMVL[i].idMovimiento;
                                expedienteMVL.idMovimientoRecepcion = listaExpedienteMVL[i].idMovimientoRecepcion;
                                expedienteMVL.idMovimientoDevolucion = Convert.ToByte(txtNumeroMovimiento.Text);
                                expedienteMVL.numeroExpedienteMVL = listaExpedienteMVL[i].numeroExpedienteMVL;
                                expedienteMVL.codigoExpedienteMVL = listaExpedienteMVL[i].codigoExpedienteMVL;
                                expedienteMVL.anioExpediente = listaExpedienteMVL[i].anioExpediente;
                                expedienteMVL.accion = ExpedienteMVL.eAccion.Modificar;
                            }
                            
                        } 
                    }
                    i = i + 1;
                }
            }
            else
            {
                //Esto es un movimiento de solicitud, con el mismo se graba o modifica el expediente.
                while (i < cant) 
                {
                    if (listaExpedienteMVL[i].codigoExpedienteMVL == cboCodigoExpedienteMVL.SelectedValue &&
                        listaExpedienteMVL[i].numeroExpedienteMVL == txtNumeroExpedienteMVL.Text &&
                        listaExpedienteMVL[i].anioExpediente == Convert.ToInt16(txtAnioExpediente.Text)) 
                    {
                        if (listaExpedienteMVL[i].idMovimiento != Convert.ToByte(txtNumeroMovimiento.Text))
                        {
                            expedienteMVL.idExpediente = 0;
                            return expedienteMVL;
                        }
                    }
                    if (listaExpedienteMVL[i].idMovimiento == Convert.ToByte(txtNumeroMovimiento.Text))
                    {
                        expedienteMVL.idMovimientoRecepcion = listaExpedienteMVL[i].idMovimientoRecepcion;
                        expedienteMVL.idMovimientoDevolucion = listaExpedienteMVL[i].idMovimientoDevolucion;
                    }                    
                    i = i + 1;
                }
                expedienteMVL.idExpediente = Convert.ToInt32(txtExpediente.Text);
                expedienteMVL.idMovimiento = Convert.ToByte(txtNumeroMovimiento.Text);
                expedienteMVL.codigoExpedienteMVL = cboCodigoExpedienteMVL.SelectedValue;
                expedienteMVL.numeroExpedienteMVL = txtNumeroExpedienteMVL.Text;
                expedienteMVL.anioExpediente = Convert.ToInt16(txtAnioExpediente.Text);
                expedienteMVL.accion = ExpedienteMVL.eAccion.Nuevo;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return expedienteMVL;
    }

    #endregion

    private Boolean verificarCampos() 
    {
        try 
        {
            if (cboTipoMovimiento.SelectedIndex == 0)
            {
                MostrarMensaje("Seleccione el tipo de movimiento");
                return false;
            }
            if (cboGenero.SelectedIndex == 0)
            {
                MostrarMensaje("Seleccione la persona que lo generó");
                return false;
            }
            if (txtFechaMovimiento .Text.CompareTo("") == 0)
            {
                MostrarMensaje("Indique la fecha del movimiento");
                return false;
            }
            if (Convert.ToDateTime(txtFechaMovimiento.Text) > System.DateTime.Now) 
            {
                MostrarMensaje("La fecha del movimiento debe ser menor o igual a la fecha actual");
                return false;
            }
            if (cboDependencia.Visible && cboDependencia.SelectedIndex == 0)
            {
                MostrarMensaje("Seleccione la dependencia");
                return false;
            }
            if (txtFechaArchivo.Visible)
            {
                if (txtFechaArchivo.Text.CompareTo("") == 0) 
                {
                    MostrarMensaje("Indique la fecha de archivo");
                    return false;
                }
                if (Convert.ToDateTime(txtFechaArchivo.Text) > System.DateTime.Now)
                {
                    MostrarMensaje("La fecha de archivo debe ser menor o igual a la fecha actual");
                    return false;
                }                
            }
            if (cboPasar.Visible && cboPasar.SelectedIndex == 0)
            {
                MostrarMensaje("Seleccione a la persona que se le pasará el expediente");
                return false;
            }
            if (txtNumeroExpedienteMVL.Visible && txtNumeroExpedienteMVL.Text.CompareTo("") == 0)
            {
                MostrarMensaje("Indique el n° del expediente MVL!");
                return false;
            }
            if (txtAnioExpediente.Visible)
            {
                if (txtAnioExpediente.Text.CompareTo("") == 0) 
                {
                    MostrarMensaje("Indique el año del expediente MVL");
                    return false;
                }                
                if (Convert.ToInt32(txtAnioExpediente.Text) > System.DateTime.Now.Year)
                {
                    MostrarMensaje("El año del expediente MVL es incorrecto.");
                    return false;
                }
            }            
            if (cboFines.Visible && cboFines.SelectedIndex == 0)
            {
                MostrarMensaje("Seleccione el fin del expediente");
                return false;
            }
            if (cboExpedientesGeneradosMVL.Visible && cboExpedientesGeneradosMVL.SelectedIndex == 0) 
            {
                MostrarMensaje("Seleccione el tipo de expediente MVL");
                return false;
            }
        }
        catch (Exception ex)
        {
            throw ex;
        }
        return true;
    }

    private void cargarDatosAdicionales()
    {
        try {
            int i = 0;
            int tot;
            //Asignacion de datos de expedientesMVL
            if (cboCodigoExpedienteMVL.Visible && txtNumeroExpedienteMVL.Visible && txtAnioExpediente.Visible)
            {
                List<ExpedienteMVL> listaExpedienteMVL = new List<ExpedienteMVL>();
                listaExpedienteMVL = (List<ExpedienteMVL>)Session["listaExpedienteMVL"];
                tot = listaExpedienteMVL.Count;
                while (i < tot)
                {
                    if (Convert.ToInt16(listaExpedienteMVL[i].idMovimiento) == Convert.ToInt16(txtNumeroMovimiento.Text)) 
                    {
                        cboCodigoExpedienteMVL.SelectedValue = listaExpedienteMVL[i].codigoExpedienteMVL.ToString();
                        txtNumeroExpedienteMVL.Text = listaExpedienteMVL[i].numeroExpedienteMVL.ToString();
                        txtAnioExpediente.Text = Convert.ToString(listaExpedienteMVL[i].anioExpediente);
                        i = tot;
                    }
                    i = i + 1;
                }            
            }

            if (cboExpedientesGeneradosMVL.Visible)
            {
                List<ExpedienteMVL> listaExpedienteMVL = new List<ExpedienteMVL>();
                listaExpedienteMVL = (List<ExpedienteMVL>)Session["listaExpedienteMVL"];
                tot = listaExpedienteMVL.Count;
                while (i < tot)
                {
                    if ((Convert.ToInt16(listaExpedienteMVL[i].idMovimientoRecepcion) == Convert.ToInt16(txtNumeroMovimiento.Text))
                        || (Convert.ToInt16(listaExpedienteMVL[i].idMovimientoDevolucion) == Convert.ToInt16(txtNumeroMovimiento.Text)))
                    {
                        cboExpedientesGeneradosMVL.SelectedValue = Convert.ToString(listaExpedienteMVL[i].idMovimiento);
                        i = tot;
                    }
                    i = i + 1;
                }
            }

            //Asignacion de datos de detalleMovimientos
            i = 0;
            if (cboDependencia.Visible || txtNumeroResolucion.Visible)
            {
                List<DetalleMovimiento> listaDetalleMovimiento = new List<DetalleMovimiento>();
                listaDetalleMovimiento = (List<DetalleMovimiento>)Session["listaDetalleMovimiento"];
                tot = listaDetalleMovimiento.Count;
                while (i < tot)
                {
                    if (listaDetalleMovimiento[i].nombreArchivo == "1")
                    {
                        ibtVerEscrito.Visible = true;
                        lblVerEscrito.Visible = true;
                        ibtVerEscrito.Enabled = true;
                        lblVerEscrito.Enabled = true;


                        lblGenerarEscrito.Visible = false;
                        ibtGenerarEscrito.Visible = false;
                        //lblGenerarEscrito.Enabled = false;
                        //ibtGenerarEscrito.Enabled = false;
                    }
                    else
                    {
                        ibtVerEscrito.Visible = false;
                        ibtVerEscrito.Enabled = false;
                        lblVerEscrito.Visible = false;
                        lblVerEscrito.Enabled = false;

                        lblGenerarEscrito.Visible = true;
                        //lblGenerarEscrito.Enabled = true;
                        ibtGenerarEscrito.Visible = true;
                        //ibtGenerarEscrito.Enabled = true;
                    }
                    if (Convert.ToInt16(listaDetalleMovimiento[i].idMovimiento) == Convert.ToInt16(txtNumeroMovimiento.Text))
                    {
                        cboDependencia.SelectedValue = listaDetalleMovimiento[i].idDependencia.ToString();
                        txtNumeroResolucion .Text = listaDetalleMovimiento[i].numeroResolucion.ToString();

                        
                        i = tot;
                    }
                    i = i + 1;
                } 
            }

            if (txtFechaArchivo.Visible) 
            {
                txtFechaArchivo.Text = Convert.ToString(Session["fechaArchivo"]);
            }
            if (cboFines.Visible)
            {
                cboFines.SelectedValue = Convert.ToString(Session["idFin"]);
            }
            if (cboPasar.Visible)
            {
                cboPasar.SelectedValue = Convert.ToString(Session["informante"]);
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        } 
    }

    #region ActualizacionListas

    private void actualizarListaMovimientos(Movimiento movimiento) 
    {
        try
        {
            Byte idmov = Convert.ToByte(txtNumeroMovimiento.Text);
            List<Movimiento> listaMovimientos = new List<Movimiento>();
            listaMovimientos = (List<Movimiento>)Session["SSlistaMovimientos"];
            if (Session["accion"].Equals(Enum.Nuevo))            
                listaMovimientos.Add(movimiento);            
            else
            {
                for (Int32 i = 0; i < listaMovimientos.Count; i++)
                {
                    if (listaMovimientos[i].idMovimiento == movimiento.idMovimiento)
                    {
                        if (Session["accion"].Equals(Enum.Modificar))
                        {   listaMovimientos[i] = movimiento; }
                        else 
                        {
                            if (listaMovimientos.Count == 1) 
                            {
                                MostrarMensaje("Sin Movimientos para mostrar. Se redireccionará a la página anterior.");
                                salirMovimientos();
                            }
                            listaMovimientos.RemoveAt(i);
                            idmov = listaMovimientos[0].idMovimiento;
                        }                        
                        i = listaMovimientos.Count;
                    }
                }
            }
            Session["SSlistaMovimientos"] = listaMovimientos;
            Session["SSMov"] = idmov;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        
    }

    private void actualizarListaExpedientesMVL(ExpedienteMVL expedienteMVL)
    {
        try
        {
            Byte idmov = Convert.ToByte(txtNumeroMovimiento.Text);
            List<ExpedienteMVL> listaExpedienteMVL = new List<ExpedienteMVL>();
            listaExpedienteMVL = (List<ExpedienteMVL>)Session["listaExpedienteMVL"];
            if (expedienteMVL.accion == Movimiento.eAccion.Nuevo)
                listaExpedienteMVL.Add(expedienteMVL);
            else
            {
                for (Int32 i = 0; i < listaExpedienteMVL.Count; i++)
                {
                    if (listaExpedienteMVL[i].idMovimiento == expedienteMVL.idMovimiento)
                    {
                        if (expedienteMVL.accion == Movimiento.eAccion.Modificar)
                        {   
                            listaExpedienteMVL[i] = expedienteMVL;
                            //if (Session["accion"].Equals(Enum.Eliminar)) 
                            //{
                            //    //idmov = 1;
                            //}
                        }
                        else 
                        {
                            listaExpedienteMVL.RemoveAt(i);
                            //idmov = 1;
                        }                        
                        i = listaExpedienteMVL.Count;
                    }
                }
            }
            Session["listaExpedienteMVL"] = listaExpedienteMVL;
            //Session["SSMov"] = idmov;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    private void actualizarListaDetalleMovimientos(DetalleMovimiento detalleMovimiento)
    {
        try
        {
            Byte idmov = Convert.ToByte(txtNumeroMovimiento.Text);
            List<DetalleMovimiento> listaDetalleMovimientos = new List<DetalleMovimiento>();
            listaDetalleMovimientos = (List<DetalleMovimiento>)Session["listaDetalleMovimiento"];
            if (Session["accion"].Equals(Enum.Nuevo))
                listaDetalleMovimientos.Add(detalleMovimiento);
            else
            {
                for (Int32 i = 0; i < listaDetalleMovimientos.Count; i++)
                {
                    if (listaDetalleMovimientos[i].idMovimiento == detalleMovimiento.idMovimiento)
                    {
                        if (Session["accion"].Equals(Enum.Modificar))
                        {   listaDetalleMovimientos[i] = detalleMovimiento; }
                        else 
                        {
                            listaDetalleMovimientos.RemoveAt(i);
                            //idmov = 1;
                        }                        
                        i = listaDetalleMovimientos.Count;
                    }
                }
            }
            Session["listaDetalleMovimiento"] = listaDetalleMovimientos;
            //Session["SSMov"] = idmov;
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    #endregion

    private void MostrarMensaje(string strMensaje)
    {
        try
        {
            string str = "<script type=\"text/javascript\">";
            str = str + "alert('" + strMensaje + "');";
            str = str + "</script>";
            Page.ClientScript.RegisterStartupScript(Page.ClientScript.GetType(), "mostrarMensaje", str);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }
    }

    private String devolverFechaParaDocumento() 
    {
        String cadena;
        try 
        {            
            cadena = Convert.ToString(System.DateTime.Now.Day) + " de ";
            switch (System.DateTime.Now.Month) 
            { 
                case 1:
                    cadena = cadena + " Enero de ";
                    break;
                case 2:
                    cadena = cadena + " Febrero de ";
                    break;
                case 3:
                    cadena = cadena + " Marzo de ";
                    break;
                case 4:
                    cadena = cadena + " Abril de ";
                    break;
                case 5:
                    cadena = cadena + " Mayo de ";
                    break;
                case 6:
                    cadena = cadena + " Junio de ";
                    break;
                case 7:
                    cadena = cadena + " Julio de ";
                    break;
                case 8:
                    cadena = cadena + " Agosto de ";
                    break;
                case 9:
                    cadena = cadena + " Septiembre de ";
                    break;
                case 10:
                    cadena = cadena + " Octubre de ";
                    break;
                case 11:
                    cadena = cadena + " Noviembre de ";
                    break;
                case 12:
                    cadena = cadena + " Diciembre de ";
                    break;
            }
            cadena = cadena + System.DateTime.Now.Year;
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }
        return cadena;
    }

    protected void btnListar_Click(object sender, EventArgs e)
    {
        try 
        {
            string strBody = "<html>" + "<body>" + "<table style='width: 100%' border=0>" +
            "<tr>" +
                "<td>" + txtNumeroMovimiento.Text + "</td>" +
                "<td>" + cboTipoMovimiento.SelectedItem.ToString() + "</td>" +
                "<td>" + txtFechaMovimiento.Text + "</td>" +
            "</tr>" +
            "<tr>" +
                "<td colspan=3 >" + txtComentario.Text +
                "</td>" +
            "</tr>" +
            "</body>" + "</html>";
            Response.AppendHeader("Content-Type", "application/msword");
            Response.AppendHeader("Content-disposition", "attachment; filename=" + "Listar.doc");
            Response.Write(strBody);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }
    }
}
