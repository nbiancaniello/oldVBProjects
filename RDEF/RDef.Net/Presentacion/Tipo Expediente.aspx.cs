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

public partial class Presentacion_Tipo_Expediente : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            this.btnAgregar.Attributes.Add("onClick", " return mostrarCampos('agregar');");
            this.btnCancelar.Attributes.Add("onClick", "return ocultarCampos();");
            this.btnModificar.Attributes.Add("onClick", "return mostrarCampos('modificar');");
            this.txttipoexpediente.ReadOnly = true;
            this.cboestado.Enabled = false;
        


            if (!IsPostBack)
            {
                cboestado.Items.Add("Activo");
                cboestado.Items.Add("Inactivo");
                txtdescripcion.Text = "";
                txttipoexpediente.Text = "";
                CargarGrillaTipoExpedientes();
                habilitarBotones(true);
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void CargarGrillaTipoExpedientes()
    {
        DataSet ds = NegocioMantenimiento.TraerTipoExpedientes();
        try
        {
            this.GvTipoExpedientes.DataSource = ds;
            //aca
            this.GvTipoExpedientes.DataBind();
            Session.Remove("listadoTipoExpedientes");
            Session.Add("listadoTipoExpedientes", ds);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    // ACCESO AL MENU PPAL PROVISORIO

    protected void btnagregar_Click(object sender, EventArgs e)
    {
        this.txttipoexpediente.Enabled = true;
        this.txtdescripcion.Enabled = true;
        this.cboestado.Enabled = true;
        this.txtdescripcion.Text = "";
        PonerFoco("txtdescripcion");
        this.txttipoexpediente.Text = (NegocioMantenimiento.TraerIdTipoExpediente()).ToString();
        habilitarBotones(false);
    }

    protected void btnmodificar_Click(object sender, EventArgs e)
    {
        try
        {
            this.txttipoexpediente.Enabled = true;
            this.txtdescripcion.Enabled = true;

            if (GvTipoExpedientes.SelectedIndex != -1 && GvTipoExpedientes.Rows.Count > 0)
            {
                this.txttipoexpediente.Enabled = true;
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

            if (GvTipoExpedientes.SelectedIndex != -1 && GvTipoExpedientes.Rows.Count > 0)
            {
                int id = int.Parse(GvTipoExpedientes.SelectedRow.Cells[1].Text);
                string mens = NegocioMantenimiento.EliminarTipoExpediente(id);
                if (mens != "")
                {

                    MostrarMensaje(mens);

                }


                else
                {
                    CargarGrillaTipoExpedientes();
                }

                this.txttipoexpediente.Text = "";
                this.txtdescripcion.Text = "";
                this.cboestado.SelectedIndex = 0;
                this.GvTipoExpedientes.SelectedIndex = -1;


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

    protected void GvTipoExpedientes_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackClientHyperlink(GvTipoExpedientes, "Select$" + e.Row.RowIndex.ToString()));
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }
 
    protected void btnaceptar_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.txtdescripcion.Text.Trim() != "")
            {
                try
                {
                    TipoExpediente tipoexpediente = new TipoExpediente();
                    tipoexpediente.descTipoExpediente = this.txtdescripcion.Text.Trim();



                    if (hAccion.Value == "agregar")
                    {
                        byte Est;
                        if (this.cboestado.SelectedIndex == 0)
                        {
                            Est = 1;

                        }
                        else
                        {
                            Est = 0;
                        }

                        tipoexpediente.estado = Convert.ToBoolean(Est);

                        tipoexpediente.idTipoExpediente = NegocioMantenimiento.TraerIdTipoExpediente();
                        this.cboestado.Enabled = true;
                        NegocioMantenimiento.AgregarTipoExpediente(tipoexpediente);

                        MostrarMensaje("Un nuevo Tipo de Expediente ha sido agregada satisfactoriamente");
                        txtdescripcion.Text = "";
                        cboestado.SelectedIndex = 0;
                        txtdescripcion.Enabled = false;
                    }

                    else
                    {
                        tipoexpediente.idTipoExpediente = Convert.ToByte(int.Parse(GvTipoExpedientes.SelectedRow.Cells[1].Text));


                        if (cboestado.SelectedItem.Text == "Activo")
                        {
                            byte Est = 1;

                            tipoexpediente.estado = Convert.ToBoolean(Est);

                          
                        }
                        else
                        {

                            byte Est = 0;

                            tipoexpediente.estado = Convert.ToBoolean(Est);
                        }

                        NegocioMantenimiento.ModificarTipoExpediente(tipoexpediente);

                        MostrarMensaje("Usted ha modificado el tipo de expediente:  " + tipoexpediente.descTipoExpediente + ", satisfactoriamente.");
                        txtdescripcion.Text = "";
                        cboestado.SelectedIndex = 0;


                        txtdescripcion.Enabled = false;
                    }




                    CargarGrillaTipoExpedientes();
                    this.txttipoexpediente.Text = "";
                    this.txtdescripcion.Text = "";
                    this.cboestado.Enabled = false;
                    this.GvTipoExpedientes.SelectedIndex = -1;

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
                this.txttipoexpediente.Text = "";
                this.txtdescripcion.Enabled = false;
                this.cboestado.Enabled = false;
                this.GvTipoExpedientes.SelectedIndex = -1;

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
        this.GvTipoExpedientes.SelectedIndex = -1;
        CargarGrillaTipoExpedientes();
        this.txttipoexpediente.Text = "";
        this.txtdescripcion.Text = "";
        this.cboestado.SelectedIndex = 0;
    }

    private void CargarGrillaTipoExpedientesActivos()
    {
        DataSet ds = NegocioMantenimiento.TraerTipoExpedienteActivos();
        try
        {
            this.GvTipoExpedientes.DataSource = ds;
            //aca
            this.GvTipoExpedientes.DataBind();
            Session.Remove("listadoTipoExpedientes");
            Session.Add("listadoTipoExpedientes", ds);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void CargarGrillaTipoExpedienteInactivos()
    {
        DataSet ds = NegocioMantenimiento.TraerTipoExpedienteInactivos();
        try
        {
            this.GvTipoExpedientes.DataSource = ds;
            //aca
            this.GvTipoExpedientes.DataBind();
            Session.Remove("listadoTipoExpedientes");
            Session.Add("listadoTipoExpedientes", ds);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void btnactivos_Click(object sender, EventArgs e)
    {
        this.GvTipoExpedientes.SelectedIndex = -1;
        CargarGrillaTipoExpedientes();
        this.txttipoexpediente.Text = "";
        this.txtdescripcion.Text = "";
        this.cboestado.SelectedIndex = 0;
    }

    protected void btninactivos_Click(object sender, EventArgs e)
    {
        this.GvTipoExpedientes.SelectedIndex = -1;
        CargarGrillaTipoExpedienteInactivos();
        this.txttipoexpediente.Text = "";
        this.txtdescripcion.Text = "";
        this.cboestado.SelectedIndex = 0;
    }

    protected void btncancelar_Click(object sender, EventArgs e)
    {
        this.txtdescripcion.Text = "";
        this.txttipoexpediente.Text = "";
        this.txtdescripcion.Enabled = false;
        this.GvTipoExpedientes.SelectedIndex = -1;
        habilitarBotones(true);
    }

    protected void GvTipoExpedientes_PageIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.GvTipoExpedientes.SelectedIndex = -1;
            this.GvTipoExpedientes.DataSource = null;
            this.GvTipoExpedientes.DataBind();
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void btnregresar_Click(object sender, EventArgs e)
    {
        Response.Redirect("MenuMantenimiento.aspx");
    }

    protected void GvTipoExpedientes_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.GvTipoExpedientes.SelectedIndex != -1)
            {
                this.txttipoexpediente.Text = this.GvTipoExpedientes.SelectedRow.Cells[1].Text;
                this.txtdescripcion.Text = this.GvTipoExpedientes.SelectedRow.Cells[2].Text;
                this.cboestado.Text = this.GvTipoExpedientes.SelectedRow.Cells[3].Text;
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
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

    protected void GvTipoExpedientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            DataSet ds = (DataSet)Session["listadoTipoExpedientes"];
            this.GvTipoExpedientes.PageIndex = e.NewPageIndex;
            this.GvTipoExpedientes.DataSource = ds;
            this.GvTipoExpedientes.DataBind();
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message.ToString());
        }
    }
}
