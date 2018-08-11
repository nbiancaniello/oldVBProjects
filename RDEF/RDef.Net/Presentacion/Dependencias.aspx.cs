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

public partial class Presentacion_Dependencias: System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            this.btnAgregar.Attributes.Add("onClick", "return mostrarCampos('agregar');");
            this.btnCancelar.Attributes.Add("onClick", "return ocultarCampos();");
            this.btnModificar.Attributes.Add("onClick", "return mostrarCampos('modificar');");
            this.txtidDependencia.ReadOnly = true;
            this.cboEstado.Enabled = false;
            this.txtdescripcion.Enabled =false;
            PonerFoco("txtdescripcion");     
           

            if (!IsPostBack)
            {
                habilitarBotones(true);
                cboEstado.Items.Add("Activo");
                cboEstado.Items.Add("Inactivo");
                txtdescripcion.Text = "";
                txtidDependencia.Text = "";
                CargarGrillaDependencias();
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void CargarGrillaDependencias()
    {
        DataSet ds = NegocioMantenimiento.TraerDependenciasEstado();
        try
        {
            this.GvDependencias.DataSource = ds;
            //aca
            this.GvDependencias.DataBind();
            Session.Remove("listadoDependencias");
            Session.Add("listadoDependencias", ds);
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

    protected void GvDependencias_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.txtidDependencia.Text = this.GvDependencias.SelectedRow.Cells[1].Text;
            this.txtdescripcion.Text = this.GvDependencias.SelectedRow.Cells[2].Text;
            this.cboEstado.Text = this.GvDependencias.SelectedRow.Cells[3].Text;
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void GvDependencias_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackClientHyperlink(GvDependencias, "Select$" + e.Row.RowIndex.ToString()));
            }
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
            this.GvDependencias.SelectedIndex = -1;
            CargarGrillaDependencias();
            this.txtidDependencia.Text = "";
            this.txtdescripcion.Text = "";
            this.cboEstado.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }        
    }

    private void CargarGrillaDependenciasActivas()
    {
        DataSet ds = NegocioMantenimiento.TraerDependenciasActivas();
        try
        {
            this.GvDependencias.DataSource = ds;
            //aca
            this.GvDependencias.DataBind();
            Session.Remove("listadoDependencias");
            Session.Add("listadoDependencias", ds);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void CargarGrillaDependenciasInactivas()
    {
        DataSet ds = NegocioMantenimiento.TraerDependenciasInactivas();
        try
        {
            this.GvDependencias.DataSource = ds;
            //aca
            this.GvDependencias.DataBind();
            Session.Remove("listadoDependencias");
            Session.Add("listadoDependencias", ds);
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
            this.GvDependencias.SelectedIndex = -1;
            CargarGrillaDependenciasActivas();
            this.txtidDependencia.Text = "";
            this.txtdescripcion.Text = "";
            this.cboEstado.SelectedIndex = 0;
        }        
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }  
    }

    protected void btnInactivos_Click(object sender, EventArgs e)
    {
        try 
        {
            this.GvDependencias.SelectedIndex = -1;
            CargarGrillaDependenciasInactivas();
            this.txtidDependencia.Text = "";
            this.txtdescripcion.Text = "";
            this.cboEstado.SelectedIndex = 0;
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }        
    }

    protected void BtnCancelar_Click(object sender, EventArgs e)
    {
        try
        {
            habilitarBotones(true);
            this.txtdescripcion.Text = "";
            this.txtidDependencia.Text = "";
            this.txtdescripcion.Enabled = false;
            this.GvDependencias.SelectedIndex = -1;
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void GvDependencias_PageIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.GvDependencias.SelectedIndex = -1;
            this.GvDependencias.DataSource = null;
            this.GvDependencias.DataBind();
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }
    
    protected void BtnAceptar_Click(object sender, EventArgs e)
    {

        try
        {
          
            if (this.txtdescripcion.Text.Trim() != "")
            {
                try
                {                  
                    Dependencia dependencia = new Dependencia();                                                          
                    dependencia.descDependencia = this.txtdescripcion.Text.Trim();
                    
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
                      
                        dependencia.estado = Convert.ToBoolean(Est);
                        dependencia.idDependencia= NegocioMantenimiento.TraerIdDependencia();
                        this.cboEstado.Enabled = true;
                        NegocioMantenimiento.AgregarDependencia(dependencia);
                        MostrarMensaje("Una nueva Dependencia ha sido agregada satisfactoriamente");
                        txtdescripcion.Text = "";
                        cboEstado.SelectedIndex = 0;
                        txtdescripcion.Enabled = false;
                    }

                    else
                    {

                       dependencia.idDependencia = Convert.ToByte(int.Parse(GvDependencias.SelectedRow.Cells[1].Text));
                        if (cboEstado.SelectedItem.Text == "Activo")
                        {
                            int Est = 1;
                           dependencia.estado = Convert.ToBoolean(Est);
                        }
                        else
                        {
                            int Est = 0;
                            dependencia.estado = Convert.ToBoolean(Est);
                        }
                        NegocioMantenimiento.ModificarDependencia(dependencia);
                        MostrarMensaje("Usted ha modificado el area:  " + dependencia.descDependencia + ", satisfactoriamente.");
                        txtdescripcion.Text = "";
                        cboEstado.SelectedIndex = 0;
                        txtdescripcion.Enabled = false;
                    }
                    CargarGrillaDependencias();
                    this.txtidDependencia.Text = "";
                    this.txtdescripcion.Text = "";
                    this.cboEstado.Enabled = false;

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
                this.txtidDependencia.Text = "";
                this.txtdescripcion.Enabled = false;
                this.cboEstado.Enabled = false;
            }
        }      
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);

        }
        habilitarBotones(true);
    }
    
    protected void btnModificar_Click(object sender, EventArgs e)
    {
        try
        {
            this.txtidDependencia.Enabled = true;
            this.txtdescripcion.Enabled = true;
            if (GvDependencias.SelectedIndex != -1 && GvDependencias.Rows.Count > 0)
            {
                this.txtidDependencia.Enabled = true;
                this.txtdescripcion.Enabled = true;
                this.cboEstado.Enabled = true;
                PonerFoco("txtDescripcion");
                habilitarBotones(false);
            }
            else
            {
                MostrarMensaje("Por favor, seleccione el registro que desea modificar.");

            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }

    }

    protected void btnvolver_Click(object sender, EventArgs e)
    {
     
        Response.Redirect("MenuMantenimiento.aspx");
        
    
    }

    protected void btnEliminar_Click(object sender, EventArgs e)
    {

        try
        {

            if (GvDependencias.SelectedIndex != -1 && GvDependencias.Rows.Count > 0)

            {
                int id = int.Parse(GvDependencias.SelectedRow.Cells[1].Text);
                string mens = NegocioMantenimiento.EliminarDependencia(id);
            if (mens != "")
            {

                MostrarMensaje(mens);
            
            }


            else
            {
                CargarGrillaDependencias(); 
            }

            this.txtidDependencia.Text = "";
            this.txtdescripcion.Text = "";
            this.cboEstado.SelectedIndex = 0;
            this.GvDependencias.SelectedIndex = -1;

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

    protected void GvDependencias_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            DataSet ds = (DataSet)Session["listadoDependencias"];
            this.GvDependencias.PageIndex = e.NewPageIndex;
            this.GvDependencias.DataSource = ds;
            this.GvDependencias.DataBind();
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message.ToString());
        } 
    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        try
        {
            this.txtidDependencia.Enabled = true;
            this.txtdescripcion.Enabled = true;
            this.cboEstado.Enabled = true;
            this.txtidDependencia.Text = "";
            this.txtdescripcion.Text = "";
            habilitarBotones(false);
            PonerFoco("txtdescripcion");
            this.txtidDependencia.Text = (NegocioMantenimiento.TraerIdDependencia()).ToString();
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }
}
