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


public partial class Presentacion_Denunciados : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            this.btnAgregar.Attributes.Add("onClick", " return mostrarCampos('agregar');");
            this.btnCancelar.Attributes.Add("onClick", "return ocultarCampos();");
            this.btnModificar.Attributes.Add("onClick", "return mostrarCampos('modificar');");
            this.txtidDenunciado.ReadOnly = true;
            this.cboEstado.Enabled = false;

            if (!IsPostBack)
            {
                cboEstado.Items.Add("Activo");
                cboEstado.Items.Add("Inactivo");
                habilitarBotones(true);
                CargarGrillaDenunciados();
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void CargarGrillaDenunciados()
    {
        DataSet ds = NegocioMantenimiento.TraerDataSetDenunciados();
        try
        {
            this.GvDenunciados.DataSource = ds;
            //aca
            this.GvDenunciados.DataBind();
            Session.Remove("listadoDenunciados");
            Session.Add("listadoDenunciados", ds);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void GvDenunciados_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackClientHyperlink(GvDenunciados, "Select$" + e.Row.RowIndex.ToString()));
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void GvDenunciados_PageIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.GvDenunciados.SelectedIndex = -1;
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
            if (GvDenunciados.SelectedIndex != -1 && GvDenunciados.Rows.Count > 0)
            {
                int id = int.Parse(GvDenunciados.SelectedRow.Cells[1].Text);
                string mens = NegocioMantenimiento.EliminarDenunciado(id);
                if (mens != "")
                {
                    MostrarMensaje(mens);
                }
                else
                {
                    CargarGrillaDenunciados();
                }
                this.txtidDenunciado.Text = "";
                this.txtEntidad.Text = "";
                this.cboEstado.SelectedIndex = 0;
                this.GvDenunciados.SelectedIndex = -1;
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

    protected void GvDenunciados_SelectedIndexChanged(object sender, EventArgs e)
    {

        try
        {

            if (this.GvDenunciados.SelectedIndex != -1)
            {
                this.txtidDenunciado.Text = this.GvDenunciados.SelectedRow.Cells[1].Text;
                this.txtEntidad.Text = this.GvDenunciados.SelectedRow.Cells[2].Text;
                //this.cboEstado.Text = this.GvDenunciados.SelectedRow.Cells[3].Text;
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }


    }

    protected void btnRegresar_Click(object sender, EventArgs e)
    {
        Response.Redirect("menuMantenimiento.aspx");
    }

    protected void btnAgregar_Click(object sender, EventArgs e)
    {
       // this.txtidDenunciado.Enabled = true;
        this.txtEntidad.Enabled = true;
        this.cboEstado.Enabled = true;
        this.txtEntidad.Text = "";
        this.cboEstado.SelectedIndex = 0;
        habilitarBotones(false);        
        PonerFoco("txtEntidad");
        this.txtidDenunciado.Text = (NegocioMantenimiento.TraerIdDenunciado()).ToString();
    }

    protected void btnModificar_Click(object sender, EventArgs e)
    {
        try
        {
            this.txtidDenunciado.Enabled = true;
            this.txtEntidad.Enabled = true;
            if (GvDenunciados.SelectedIndex != -1 && GvDenunciados.Rows.Count > 0)
            {
                //this.txtidDenunciado.Enabled = true;
                this.txtEntidad.Enabled = true;
                this.cboEstado.Enabled = true;
                PonerFoco("txtEntidad");
                habilitarBotones(false);
            }
            else
            {
                MostrarMensaje("Por favor, seleccione el registro que desea modificar.");
                this.txtEntidad.Enabled = false;
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {      
        try
        {
            if (this.txtEntidad.Text.Trim() != "")
            {
                try
                {
                    Denunciado denunciado = new Denunciado();
                    denunciado.entidad = this.txtEntidad.Text.Trim();

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

                        denunciado.estado = Convert.ToBoolean(Est);
                        denunciado.idDenunciado = NegocioMantenimiento.TraerIdDenunciado();
                        this.cboEstado.Enabled = true;
                        NegocioMantenimiento.AgregarDenunciado(denunciado);
                        MostrarMensaje("Una nuevo denunciado ha sido agregado satisfactoriamente");
                        txtEntidad.Text = "";
                        cboEstado.SelectedIndex = 0;
                        txtEntidad.Enabled = false;
                    }

                    else
                    {
                        denunciado.idDenunciado = Convert.ToByte(int.Parse(GvDenunciados.SelectedRow.Cells[1].Text));
                        if (cboEstado.SelectedItem.Text == "Activo")
                        {
                            int Est = 1;
                            denunciado.estado = Convert.ToBoolean(Est);
                        }
                        else
                        {
                            int Est = 0;
                            denunciado.estado = Convert.ToBoolean(Est);
                        }
                        NegocioMantenimiento.ModificarDenunciado(denunciado);
                        MostrarMensaje("Usted ha modificado la Entidad:  " + denunciado.entidad + ", satisfactoriamente.");
                        txtEntidad.Text = "";
                        cboEstado.SelectedIndex = 0;
                        txtEntidad.Enabled = false;
                    }

                    CargarGrillaDenunciados();
                    this.txtidDenunciado.Text = "";
                    this.txtEntidad.Text = "";
                    this.cboEstado.Enabled = false;
                    this.GvDenunciados.SelectedIndex = -1;
                }
                catch (Exception ex)
                {
                    Response.Redirect("Errores.aspx?error=" + ex.Message);
                }

            }
            else
            {
                MostrarMensaje("Por Favor, complete todos los campos antes de realizar esta función.");
                this.txtEntidad.Text = "";
                this.txtidDenunciado.Text = "";
                this.txtEntidad.Enabled = false;
                this.cboEstado.Enabled = false;
                this.GvDenunciados.SelectedIndex = -1;
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);

        }
        habilitarBotones(true);
    }

    private int StringComparer(char p, string p_2)
    {
        throw new Exception("The method or operation is not implemented.");
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
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }
    }

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

    private void CargarGrillaDenunciadosInactivos()
    {
        DataSet ds = NegocioMantenimiento.TraerDenunciadosInactivos();
        try
        {
            this.GvDenunciados.DataSource = ds;
            //aca
            this.GvDenunciados.DataBind();
            Session.Remove("listadoDenunciados");
            Session.Add("listadoDenunciados", ds);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void CargarGrillaDenunciadosActivos()
    {
        DataSet ds = NegocioMantenimiento.TraerDenunciadosActivos();
        try
        {
            this.GvDenunciados.DataSource = ds;
            //aca
            this.GvDenunciados.DataBind();
            Session.Remove("listadoDenunciados");
            Session.Add("listadoDenunciados", ds);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }
    
    protected void btnTodos_Click(object sender, EventArgs e)
    {
        this.GvDenunciados.SelectedIndex = -1;
        CargarGrillaDenunciados();
        this.txtidDenunciado.Text = "";
        this.txtEntidad.Text = "";
        this.cboEstado.SelectedIndex = 0;     
    }

    protected void btnActivos_Click(object sender, EventArgs e)
    {
        this.GvDenunciados.SelectedIndex = -1;
        CargarGrillaDenunciadosActivos();
        this.txtidDenunciado.Text = "";
        this.txtEntidad.Text = "";
        this.cboEstado.SelectedIndex = 0;
    }

    protected void btnInactivos_Click(object sender, EventArgs e)
    {
        this.GvDenunciados.SelectedIndex = -1;
        CargarGrillaDenunciadosInactivos();
        this.txtidDenunciado.Text = "";
        this.txtEntidad.Text = "";
        this.cboEstado.SelectedIndex = 0;
    }

    protected void btnCancelar_Click(object sender, EventArgs e)
    {

        this.txtEntidad.Text = "";
        this.txtidDenunciado.Text = "";
        this.txtEntidad.Enabled = false;
        this.cboEstado.SelectedIndex = 0;
        this.btnAceptar.Enabled = true;
        this.GvDenunciados.SelectedIndex = -1;
        habilitarBotones(true);
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

    protected void GvDenunciados_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            DataSet ds = (DataSet)Session["listadoDenunciados"];
            this.GvDenunciados.PageIndex = e.NewPageIndex;
            this.GvDenunciados.DataSource = ds;
            this.GvDenunciados.DataBind();
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message.ToString());
        } 
    }
}

    
    


