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

public partial class Presentacion_Fines : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            this.btnAgregar.Attributes.Add("onClick", " return mostrarCampos('agregar');");
            this.btnCancelar.Attributes.Add("onClick", "return ocultarCampos();");
            this.btnModificar.Attributes.Add("onClick", "return mostrarCampos('modificar');");
            this.txtidfin.ReadOnly = true;
            this.cboestado.Enabled = false;
            this.txtdescripcion.Enabled = false;
          


            if (!IsPostBack)
            {
                cboestado.Items.Add("Activo");
                cboestado.Items.Add("Inactivo");
                habilitarBotones(true);
                txtdescripcion.Text = "";
                txtidfin.Text = "";

                CargarGrillaFines();
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void CargarGrillaFines()
    {
        DataSet ds = NegocioMantenimiento.TraerFinesEstado();
        try
        {
            this.GvFines.DataSource = ds;
            //aca
            this.GvFines.DataBind();
            Session.Remove("listadoFines");
            Session.Add("listadoFines", ds);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }
    
    // ACCESO AL MENU PPAL PROVISORIO   

    protected void btnagregar_Click(object sender, EventArgs e)
    {
        this.txtidfin.Enabled = true;
        this.txtdescripcion.Enabled = true;
        this.cboestado.Enabled = true;
        this.txtdescripcion.Text = "";
        habilitarBotones(false);
        PonerFoco("txtdescripcion");
        this.txtidfin.Text = (NegocioMantenimiento.TraerIdFin()).ToString();
    }

    protected void btnmodificar_Click(object sender, EventArgs e)
    {
        try
        {
            this.txtidfin.Enabled = true;
            this.txtdescripcion.Enabled = true;

            if (GvFines.SelectedIndex != -1 && GvFines.Rows.Count > 0)
            {
                this.txtidfin.Enabled = true;
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

            if (GvFines.SelectedIndex != -1 && GvFines.Rows.Count > 0)
            {
                int id = int.Parse(GvFines.SelectedRow.Cells[1].Text);
                string mens = NegocioMantenimiento.EliminarFin(id);
                if (mens != "")
                {

                    MostrarMensaje(mens);

                }


                else
                {
                    CargarGrillaFines();
                }

                this.txtidfin.Text = "";
                this.txtdescripcion.Text = "";
                this.cboestado.SelectedIndex = 0;
                this.GvFines.SelectedIndex = -1;


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

    protected void GvFines_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.GvFines.SelectedIndex != -1)
            {
                this.txtidfin.Text = this.GvFines.SelectedRow.Cells[1].Text;
                this.txtdescripcion.Text = this.GvFines.SelectedRow.Cells[2].Text;
                this.cboestado.Text = this.GvFines.SelectedRow.Cells[3].Text;
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void GvFines_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackClientHyperlink(GvFines, "Select$" + e.Row.RowIndex.ToString()));
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
                    Fin fin = new Fin();
                    fin.descFin = this.txtdescripcion.Text.Trim();




                    if (hAccion.Value == "agregar")
                    {
                        int Est;
                        if (this.cboestado.SelectedIndex == 0)
                        {
                            Est = 1;

                        }
                        else
                        {
                            Est = 0;
                        }

                        fin.estado = Convert.ToBoolean(Est);
                        fin.idFin = NegocioMantenimiento.TraerIdFin();
                        this.cboestado.Enabled = true;
                        NegocioMantenimiento.AgregarFin(fin);

                        MostrarMensaje("Un nuevo Fin ha sido agregada satisfactoriamente");
                        txtdescripcion.Text = "";
                        cboestado.SelectedIndex = 0;
                        txtdescripcion.Enabled = false;
                    }

                    else
                    {
                        fin.idFin = byte.Parse(GvFines.SelectedRow.Cells[1].Text);


                        if (cboestado.SelectedItem.Text == "Activo")
                        {
                            int Est = 1;

                            fin.estado = Convert.ToBoolean(Est);

                        }
                        else
                        {

                            int Est = 0;

                            fin.estado = Convert.ToBoolean(Est);
                        }




                        NegocioMantenimiento.ModificarFines(fin);

                        MostrarMensaje("Usted ha modificado el Fin:  " + fin.descFin + ", satisfactoriamente.");
                        txtdescripcion.Text = "";
                        cboestado.SelectedIndex = 0;


                        txtdescripcion.Enabled = false;
                    }




                    CargarGrillaFines();
                    this.txtidfin.Text = "";
                    this.txtdescripcion.Text = "";
                    this.cboestado.Enabled = false;
                    this.GvFines.SelectedIndex = -1;

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
                this.txtidfin.Text = "";
                this.txtdescripcion.Enabled = false;
                this.cboestado.Enabled = false;
                this.GvFines.SelectedIndex = -1;

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
        this.GvFines.SelectedIndex = -1;
        CargarGrillaFines();
        this.txtidfin.Text = "";
        this.txtdescripcion.Text = "";
        this.cboestado.SelectedIndex = 0;
    }

    private void CargarGrillaFinesActivos()
    {
        DataSet ds = NegocioMantenimiento.TraerFinesActivos();
        try
        {
            this.GvFines.DataSource = ds;
            //aca
            this.GvFines.DataBind();
            Session.Remove("listadoFines");
            Session.Add("listadoFines", ds);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void CargarGrillaFinesInactivos()
    {
        DataSet ds = NegocioMantenimiento.TraerFinesInactivos();
        try
        {
            this.GvFines.DataSource = ds;
            //aca
            this.GvFines.DataBind();
            Session.Remove("listadoFines");
            Session.Add("listadoFines", ds);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void btnactivos_Click(object sender, EventArgs e)
    {
        this.GvFines.SelectedIndex = -1;
        CargarGrillaFinesActivos();
        this.txtidfin.Text = "";
        this.txtdescripcion.Text = "";
        this.cboestado.SelectedIndex = 0;
    }

    protected void btninactivos_Click(object sender, EventArgs e)
    {
        this.GvFines.SelectedIndex = -1;
        CargarGrillaFinesInactivos();
        this.txtidfin.Text = "";
        this.txtdescripcion.Text = "";
        this.cboestado.SelectedIndex = 0;
    }

    protected void btncancelar_Click(object sender, EventArgs e)
    {
        this.txtdescripcion.Text = "";
        this.txtidfin.Text = "";
        this.txtdescripcion.Enabled = false;
        this.GvFines.SelectedIndex = -1;
        habilitarBotones(true);
    }

    protected void GvFines_PageIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.GvFines.SelectedIndex = -1;
            this.GvFines.DataSource = null;
            this.GvFines.DataBind();
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
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

    protected void GvFines_SelectedIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            DataSet ds = (DataSet)Session["listadoFines"];
            this.GvFines.PageIndex = e.NewPageIndex;
            this.GvFines.DataSource = ds;
            this.GvFines.DataBind();
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message.ToString());
        }
    }
}
