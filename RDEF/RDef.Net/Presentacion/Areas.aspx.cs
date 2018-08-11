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

public partial class Presentacion_Areas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            this.btnAgregar.Attributes.Add("onClick", " return mostrarCampos('agregar');");
            this.btnCancelar.Attributes.Add("onClick", "return ocultarCampos();");
            this.btnModificar.Attributes.Add("onClick", "return mostrarCampos('modificar');");
            this.txtCod.ReadOnly = true;
            this.cboEstado.Enabled = false;
            //this.txtDesc.Enabled = true;
            //PonerFoco("txtDesc");          

            if (!IsPostBack)
            {
                habilitarBotones(true);
                cboEstado.Items.Add("Activo");
                cboEstado.Items.Add("Inactivo");
                txtDesc.Text = "";
                txtCod.Text = "";
                CargarGrillaAreas();
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void CargarGrillaAreas()
    {
        DataSet ds = NegocioMantenimiento.TraerDataSetAreas();
        try
        {
            this.GvAreas.DataSource = ds;
            //aca
            this.GvAreas.DataBind();
            Session.Remove("listadoAreas");
            Session.Add("listadoAreas", ds);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    // ACCESO AL MENU PPAL PROVISORIO

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("menuMantenimiento.aspx");
    }
    
    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        try
        {
            this.txtCod.Enabled = true;
            this.txtDesc.Enabled = true;
            this.cboEstado.Enabled = true;
            habilitarBotones(false);
            this.txtDesc.Text = "";
            PonerFoco("txtDesc");
            this.txtCod.Text = (NegocioMantenimiento.TraerId()).ToString();
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }
    
    protected void BtnModificar_Click(object sender, EventArgs e)
    {
        try
        {
            this.txtCod.Enabled = true;
            this.txtDesc.Enabled = true;
            if (GvAreas.SelectedIndex != -1 && GvAreas.Rows.Count > 0)
            {
                this.txtCod.Enabled = true;
                this.txtDesc.Enabled = true;
                this.cboEstado.Enabled = true;
                PonerFoco("txtDesc");
                habilitarBotones(false);
            }
            else
            {
                MostrarMensaje("Por favor, seleccione el registro que desea modificar.");
                this.txtDesc.Enabled = false;
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        try
        {           
            if (GvAreas.SelectedIndex != -1 && GvAreas.Rows.Count > 0)
            {
            int id = int.Parse(GvAreas.SelectedRow.Cells[1].Text);
            string mens = NegocioMantenimiento.EliminarArea(id);
            if (mens != "")
            {
                MostrarMensaje(mens);            
            }
            else
            { 
                CargarGrillaAreas(); 
            }
            this.txtCod.Text = "";
            this.txtDesc.Text = "";
            this.cboEstado.SelectedIndex = 0;
            this.GvAreas.SelectedIndex = -1;
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

    protected void GvAreas_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.GvAreas.SelectedIndex != -1)
            {
                this.txtCod.Text = this.GvAreas.SelectedRow.Cells[1].Text;
                this.txtDesc.Text = this.GvAreas.SelectedRow.Cells[2].Text;
                this.cboEstado.Text = this.GvAreas.SelectedRow.Cells[3].Text;
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void GvAreas_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackClientHyperlink(GvAreas, "Select$" + e.Row.RowIndex.ToString()));
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

    protected void BtnAceptar_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.txtDesc.Text.Trim() != "")
            {
                Area area = new Area();
                area.descArea = this.txtDesc.Text.Trim();

                if (hAccion.Value == "agregar")
                {
                    int Est;
                    if (this.cboEstado.SelectedIndex == 0)
                    {
                        Est = 1;

                    }
                    else
                    {
                        Est = 0;
                    }

                    area.estado = Convert.ToBoolean(Est);
                    area.idArea = NegocioMantenimiento.TraerId();
                    this.cboEstado.Enabled = true;
                    NegocioMantenimiento.AgregarArea(area);
                    MostrarMensaje("Una nueva área ha sido agregada satisfactoriamente");
                    txtDesc.Text = "";
                    cboEstado.SelectedIndex = 0;
                    txtDesc.Enabled = false;
                }
                else
                {
                    area.idArea = byte.Parse(GvAreas.SelectedRow.Cells[1].Text);
                    if (cboEstado.SelectedItem.Text == "Activo")
                    {
                        int Est = 1;
                        area.estado = Convert.ToBoolean(Est);
                    }
                    else
                    {
                        int Est = 0;
                        area.estado = Convert.ToBoolean(Est);
                    }
                    NegocioMantenimiento.ModificarArea(area);
                    MostrarMensaje("Usted ha modificado el area:  " + area.descArea + ", satisfactoriamente.");
                    txtDesc.Text = "";
                    cboEstado.SelectedIndex = 0;
                    txtDesc.Enabled = false;
                }
                CargarGrillaAreas();
                this.txtCod.Text = "";
                this.txtDesc.Text = "";
                this.cboEstado.Enabled = false;
                this.GvAreas.SelectedIndex = -1;
            }
            else
            {
                MostrarMensaje("Por Favor, complete todos los campos antes de realizar esta función.");
                this.txtDesc.Text = "";
                this.txtCod.Text = ""; 
                this.txtDesc.Enabled = false;
                this.cboEstado.Enabled = false;
                this.GvAreas.SelectedIndex = -1;           
            }
            habilitarBotones(true);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);

        }
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
    
    protected void btnTodos_Click(object sender, EventArgs e)
    {
        try
        {
            this.GvAreas.SelectedIndex = -1;
            CargarGrillaAreas();
            this.txtCod.Text = "";
            this.txtDesc.Text = "";
            this.cboEstado.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }
    }

    private void CargarGrillaAreasActivas()
    {
        DataSet ds = NegocioMantenimiento.TraerAreasActivas();
        try
        {
            this.GvAreas.DataSource = ds;
            //aca
            this.GvAreas.DataBind();
            Session.Remove ("listadoAreas");
            Session.Add("listadoAreas", ds);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void CargarGrillaAreasInactivas()
    {
        DataSet ds = NegocioMantenimiento.TraerAreasInactivas();
        try
        {
            this.GvAreas.DataSource = ds;
            //aca
            this.GvAreas.DataBind();
            Session.Remove("listadoAreas");
            Session.Add("listadoAreas", ds);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void btnActivos_Click(object sender, EventArgs e)
    {
        try
        {
            this.GvAreas.SelectedIndex = -1;
            CargarGrillaAreasActivas();
            this.txtCod.Text = "";
            this.txtDesc.Text = "";
            this.cboEstado.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }
    }

    protected void btnInactivos_Click(object sender, EventArgs e)
    {
        try
        {
            this.GvAreas.SelectedIndex = -1;
            CargarGrillaAreasInactivas();
            this.txtCod.Text = "";
            this.txtDesc.Text = "";
            this.cboEstado.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }
    }

    protected void BtnCancelar_Click(object sender, EventArgs e)
    {
        try
        {
            habilitarBotones(true);
            this.txtDesc.Text = "";
            this.txtCod.Text = "";
            this.txtDesc.Enabled = false;
            this.GvAreas.SelectedIndex = -1;
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }
    }

    protected void GvAreas_PageIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.GvAreas.SelectedIndex = -1;
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

    protected void GvAreas_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            DataSet ds = (DataSet)Session["listadoAreas"];
            this.GvAreas.PageIndex = e.NewPageIndex;
            this.GvAreas.DataSource = ds;
            this.GvAreas.DataBind();
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message.ToString());
        } 
    }
}
    