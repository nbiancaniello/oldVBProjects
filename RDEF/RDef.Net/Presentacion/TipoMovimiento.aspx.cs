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
using Negocio;
using Entidades;
public partial class Presentacion_TipoMovimiento : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            this.btnAgregar.Attributes.Add("onClick", " return mostrarCampos('agregar');");
            this.btnCancelar.Attributes.Add("onClick", "return ocultarCampos();");
            this.btnModificar.Attributes.Add("onClick", "return mostrarCampos('modificar');");
            this.txttipomovimiento.ReadOnly = true;
            this.cboestado.Enabled = false;
            this.txtdescripcion.Enabled = true;
            PonerFoco("txtdescripcion");           

            if (!IsPostBack)
            {
                cboestado.Items.Add("Activo");
                cboestado.Items.Add("Inactivo");
                txtdescripcion.Text = "";
                txttipomovimiento.Text = "";
                CargarGrillaTipoMovimientos();
                habilitarBotones(true);
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void CargarGrillaTipoMovimientos()
    {
        DataSet ds = NegocioMantenimiento.TraerTiposMovimientosEstado();
        try
        {
            this.GvTipoMovimientos.DataSource = ds;
            //aca
            this.GvTipoMovimientos.DataBind();
            Session.Remove("listadoMovimientos");
            Session.Add("listadoMovimientos", ds);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    // ACCESO AL MENU PPAL PROVISORIO   

    protected void btnagregar_Click(object sender, EventArgs e)
    {
        this.txttipomovimiento.Enabled = true;
        this.txtdescripcion.Enabled = true;
        this.cboestado.Enabled = true;
        this.txtdescripcion.Text = "";
        PonerFoco("txtdescripcion");
        this.txttipomovimiento.Text = (NegocioMantenimiento.TraerIdTipoMovimiento()).ToString();
        habilitarBotones(false);
    }

    protected void btnmodificar_Click(object sender, EventArgs e)
    {
        try
        {
            this.txttipomovimiento.Enabled = true;
            this.txtdescripcion.Enabled = true;

            if (GvTipoMovimientos.SelectedIndex != -1 && GvTipoMovimientos.Rows.Count > 0)
            {
                this.txttipomovimiento.Enabled = true;
                this.txtdescripcion.Enabled = true;
                this.cboestado.Enabled = true;
                PonerFoco("txtdescripcion");
                habilitarBotones(false);
            }
            else
            {
                MostrarMensaje("Por favor, seleccione el registro que desea modificar.");
                this.txtdescripcion.Enabled = false;
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }

    }

    protected void btneliminar_Click(object sender, EventArgs e)
    {
        try
        {

            if (GvTipoMovimientos.SelectedIndex != -1 && GvTipoMovimientos.Rows.Count > 0)

            {
                int id = int.Parse(GvTipoMovimientos.SelectedRow.Cells[1].Text);
            string mens = NegocioMantenimiento.EliminarTipoMovimiento(id);
            if (mens != "")
            {

                MostrarMensaje(mens);
            
            }
             

            else
            { 
                CargarGrillaTipoMovimientos(); 
            }

            this.txttipomovimiento.Text = "";
            this.txtdescripcion.Text = "";
            this.cboestado.SelectedIndex = 0;
            this.GvTipoMovimientos.SelectedIndex = -1;


        }
            else 
            {
             
                MostrarMensaje("Por favor, antes de realizar esta operación seleccione el campo que desea Eliminar");
            
            }
        }

        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }



    }

    protected void GvTipoMovimientos_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.GvTipoMovimientos.SelectedIndex >= 0)
            {
                this.txttipomovimiento.Text = this.GvTipoMovimientos.SelectedRow.Cells[1].Text;
                this.txtdescripcion.Text = this.GvTipoMovimientos.SelectedRow.Cells[2].Text;
                this.cboestado.Text = this.GvTipoMovimientos.SelectedRow.Cells[3].Text;
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void GvTipoMovimientos_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackClientHyperlink(GvTipoMovimientos, "Select$" + e.Row.RowIndex.ToString()));
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("MenuMantenimiento.aspx");

    }

    protected void btnaceptar_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.txtdescripcion.Text.Trim() != "")
            {
                try
                {
                    TipoMovimiento tipomovimiento = new TipoMovimiento();
                    tipomovimiento.descMovimiento = this.txtdescripcion.Text.Trim();

                    if (hAccion.Value == "agregar")
                    {
                        int Est;
                        if (this.cboestado.SelectedIndex == 0)
                        {
                            Est = 1;

                        }
                        else {
                               Est = 0;
                        }

                        
                        tipomovimiento.estado = Convert.ToBoolean(Est);
                        tipomovimiento.idTipoMovimiento = NegocioMantenimiento.TraerIdTipoMovimiento();
                        this.cboestado.Enabled = true;
                        NegocioMantenimiento.AgregarTipoMovimiento(tipomovimiento);

                        MostrarMensaje("Una nueva área ha sido agregada satisfactoriamente");
                        txtdescripcion.Text = "";
                        cboestado.SelectedIndex = 0;
                        txtdescripcion.Enabled = false;
                    }

                    else
                    {
                        tipomovimiento.idTipoMovimiento = int.Parse(GvTipoMovimientos.SelectedRow.Cells[1].Text);


                        if (cboestado.SelectedItem.Text == "Activo")
                        {
                            int Est = 1;

                            tipomovimiento.idTipoMovimiento = Convert.ToInt32(Est);

                        }
                        else
                        {

                            int Est = 0;

                            tipomovimiento.estado = Convert.ToBoolean(Est);
                        }




                        NegocioMantenimiento.ModificarTipoMovimiento(tipomovimiento);

                        MostrarMensaje("Usted ha modificado el tipo de movimiento:  " + tipomovimiento.descMovimiento + ", satisfactoriamente.");
                        txtdescripcion.Text = "";
                        cboestado.SelectedIndex = 0;


                        txtdescripcion.Enabled = false;
                    }




                    CargarGrillaTipoMovimientos();
                    this.txttipomovimiento.Text = "";
                    this.txtdescripcion.Text = "";
                    this.cboestado.Enabled = false;
                    this.GvTipoMovimientos.SelectedIndex = -1;

                }
                catch (Exception ex)
                {
                    Response.Redirect("Errores.aspx?error=" + ex.Message);
                }

            }
            else
            {

                MostrarMensaje("Por Favor, complete todos los campos antes de realizar esta función.");

                this.txtdescripcion.Text = "";
                this.txttipomovimiento.Text = ""; 
                this.txtdescripcion.Enabled = false;
                this.cboestado.Enabled = false;
                this.GvTipoMovimientos.SelectedIndex = -1;
           
            }
        }

        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);

        }
        habilitarBotones(true);
    }

    /* ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
     * 
     *                           Mensaje
     * 
     * ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////*/


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
   
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    //                                            Foco
                             

     //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    
    private void PonerFoco(string nombreControl)
    {

        try
        {

            string str = "<script type='text/javascript'>";
            str = str + "var control = document.getElementById('" + nombreControl + "');";
            str = str + "control.focus();</script>";
            Page.ClientScript.RegisterStartupScript(Page.ClientScript.GetType(), "ponerFoco", str);
        }

        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }


    }
    
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    protected void btntodos_Click(object sender, EventArgs e)
    {
        this.GvTipoMovimientos.SelectedIndex = -1;
        CargarGrillaTipoMovimientos();
        this.txttipomovimiento.Text = "";
        this.txtdescripcion.Text = "";
        this.cboestado.SelectedIndex = 0;
    }

    private void CargarGrillaTipoMovimientoActivos()
    {
        DataSet ds = NegocioMantenimiento.TraerTipoMovimientoActivos();
        try
        {
            this.GvTipoMovimientos.DataSource = ds;
            //aca
            this.GvTipoMovimientos.DataBind();
            Session.Remove("listadoMovimientos");
            Session.Add("listadoMovimientos", ds);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }
    
    private void CargarGrillaTipoMovimientoInactivos()
    {
        DataSet ds = NegocioMantenimiento.TraerTipoMovimientoInactivos();
        try
        {
            this.GvTipoMovimientos.DataSource = ds;
            //aca
            this.GvTipoMovimientos.DataBind();
            Session.Remove("listadoMovimientos");
            Session.Add("listadoMovimientos", ds);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void btnactivos_Click(object sender, EventArgs e)
    {
        this.GvTipoMovimientos.SelectedIndex = -1;
        CargarGrillaTipoMovimientoActivos();
        this.txttipomovimiento.Text = "";
        this.txtdescripcion.Text = "";
        this.cboestado.SelectedIndex = 0;
    }

    protected void btninactivos_Click(object sender, EventArgs e)
    {
        this.GvTipoMovimientos.SelectedIndex = -1;
        CargarGrillaTipoMovimientoInactivos();
        this.txttipomovimiento.Text = "";
        this.txtdescripcion.Text = "";
        this.cboestado.SelectedIndex = 0;
    }

    protected void btncancelar_Click(object sender, EventArgs e)
    {
        this.txtdescripcion.Text = "";
        this.txttipomovimiento.Text = "";
        this.txtdescripcion.Enabled = false;
        this.GvTipoMovimientos.SelectedIndex = -1;
        habilitarBotones(true);
    }

    protected void GvTipoMovimientos_PageIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.GvTipoMovimientos.SelectedIndex = -1;
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void GvTipoMovimientos_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            DataSet ds = (DataSet)Session["listadoMovimientos"];
            this.GvTipoMovimientos.PageIndex = e.NewPageIndex;
            this.GvTipoMovimientos.DataSource = ds;
            this.GvTipoMovimientos.DataBind();
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message.ToString());
        } 
    }

    protected void btnregresar_Click(object sender, EventArgs e)
    {
        Response.Redirect("menuMantenimiento.aspx");
    }

    private void habilitarBotones(Boolean val)
    {
        Boolean val2 = !val;
        try
        {
            btnAgregar.Enabled = val;
            btnAgregar.CssClass = btnAgregar.Enabled ? "ButtonBlue11px" : "ButtonBlue11pxDisable";
            btnModificar.Enabled = val;
            btnModificar.CssClass = btnModificar.Enabled ? "ButtonBlue11px" : "ButtonBlue11pxDisable";
            btnEliminar.Enabled = val;
            btnEliminar.CssClass = btnEliminar.Enabled ? "ButtonBlue11px" : "ButtonBlue11pxDisable";
            btnTodos.Enabled = val;
            btnTodos.CssClass = btnTodos.Enabled ? "ButtonBlue11px" : "ButtonBlue11pxDisable";
            btnActivos.Enabled = val;
            btnActivos.CssClass = btnActivos.Enabled ? "ButtonBlue11px" : "ButtonBlue11pxDisable";
            btnInactivos.Enabled = val;
            btnInactivos.CssClass = btnInactivos.Enabled ? "ButtonBlue11px" : "ButtonBlue11pxDisable";
            btnAceptar.Enabled = val2;
            btnAceptar.CssClass = btnAceptar.Enabled ? "ButtonBlue11px" : "ButtonBlue11pxDisable";
            btnCancelar.Enabled = val2;
            btnCancelar.CssClass = btnCancelar.Enabled ? "ButtonBlue11px" : "ButtonBlue11pxDisable";
            btnVolver.Enabled = val;
            btnVolver.CssClass = btnVolver.Enabled ? "ButtonBlue11px" : "ButtonBlue11pxDisable";
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }
    }
}
