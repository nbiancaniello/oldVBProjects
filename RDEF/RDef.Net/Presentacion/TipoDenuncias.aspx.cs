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
public partial class Presentacion_TipoDenuncias : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            this.btnAgregar.Attributes.Add("onClick", " return mostrarCampos('agregar');");
            this.btnCancelar.Attributes.Add("onClick", "return ocultarCampos();");
            this.btnModificar.Attributes.Add("onClick", "return mostrarCampos('modificar');");
            this.txttipodenuncia.ReadOnly = true;
            this.cboestado.Enabled = false;
            this.txttipodenuncia.Enabled = false;


            if (!IsPostBack)
            {
                cboestado.Items.Add("Activo");
                cboestado.Items.Add("Inactivo");
                txtdescripcion.Text = "";
                txttipodenuncia.Text = "";
                CargarGrillaTipoDenuncias();
                habilitarBotones(true);
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void CargarGrillaTipoDenuncias()
    {
        DataSet ds = NegocioMantenimiento.TraerTipoDenuncias();
        try
        {
            this.GvTipoDenuncias.DataSource = ds;
            //aca
            this.GvTipoDenuncias.DataBind();
            Session.Remove("listadoAreas");
            Session.Add("listadoAreas", ds);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

  // ACCESO AL MENU PPAL PROVISORIO

    protected void btnagregar_Click(object sender, EventArgs e)
    {
        this.txttipodenuncia.Enabled = true;
        this.txtdescripcion.Enabled = true;
        this.cboestado.Enabled = true;
        this.txtdescripcion.Text = "";
        PonerFoco("txtdescripcion");
        this.txttipodenuncia.Text = (NegocioMantenimiento.TraerIdTipoDenuncia()).ToString();
        habilitarBotones(false);
    }

    protected void btnmodificar_Click(object sender, EventArgs e)
    {
        try
        {
            this.txttipodenuncia.Enabled = true;
            this.txtdescripcion.Enabled = true;

            if (GvTipoDenuncias.SelectedIndex != -1 && GvTipoDenuncias.Rows.Count > 0)
            {
                this.txttipodenuncia.Enabled = true;
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
           
            if (GvTipoDenuncias.SelectedIndex != -1 && GvTipoDenuncias.Rows.Count > 0)

            {
            int id = int.Parse(GvTipoDenuncias.SelectedRow.Cells[1].Text);
            string mens = NegocioMantenimiento.EliminarTipoDenuncia(id);
            if (mens != "")
            {

                MostrarMensaje(mens);
            
            }
             

            else
            { 
                CargarGrillaTipoDenuncias(); 
            }

            this.txttipodenuncia.Text = "";
            this.txtdescripcion.Text = "";
            this.cboestado.SelectedIndex = 0;
            this.GvTipoDenuncias.SelectedIndex = -1;


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
   
    protected void GvTipoDenuncias_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (this.GvTipoDenuncias.SelectedIndex != -1)
            {
                this.txttipodenuncia.Text = this.GvTipoDenuncias.SelectedRow.Cells[1].Text;
                this.txtdescripcion.Text = this.GvTipoDenuncias.SelectedRow.Cells[2].Text;
                this.cboestado.Text = this.GvTipoDenuncias.SelectedRow.Cells[3].Text;
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void GvTipoDenuncias_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackClientHyperlink(GvTipoDenuncias, "Select$" + e.Row.RowIndex.ToString()));
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
                    TipoDenuncia tipodenuncia = new TipoDenuncia();
                    tipodenuncia.descTipoDenuncia = this.txtdescripcion.Text.Trim();
                    



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

                        tipodenuncia.estado = Convert.ToBoolean(Est);
                        tipodenuncia.idTipoDenuncia = NegocioMantenimiento.TraerIdTipoDenuncia();
                        
                        
                        this.cboestado.Enabled = true;
                        NegocioMantenimiento.AgregarTipoDenuncia(tipodenuncia);

                        MostrarMensaje("Un nuevo Tipo de Denuncia ha sido agregada satisfactoriamente");
                        txtdescripcion.Text = "";
                        cboestado.SelectedIndex = 0;
                        txtdescripcion.Enabled = false;
                    }

                    else
                    {
                        tipodenuncia.idTipoDenuncia = int.Parse(GvTipoDenuncias.SelectedRow.Cells[1].Text);


                        if (cboestado.SelectedItem.Text == "Activo")
                        {
                            int Est = 1;

                            tipodenuncia.estado = Convert.ToBoolean(Est);

                        }
                        else
                        {

                            int Est = 0;

                            tipodenuncia.estado = Convert.ToBoolean(Est);
                        }




                        NegocioMantenimiento.ModificarTipoDenuncia(tipodenuncia);

                        MostrarMensaje("Usted ha modificado el Tipo de denuncia:  " + tipodenuncia.descTipoDenuncia + ", satisfactoriamente.");
                        txtdescripcion.Text = "";
                        cboestado.SelectedIndex = 0;


                        txtdescripcion.Enabled = false;
                    }




                    CargarGrillaTipoDenuncias();
                    this.txttipodenuncia.Text = "";
                    this.txtdescripcion.Text = "";
                    this.cboestado.Enabled = false;
                    this.GvTipoDenuncias.SelectedIndex = -1;

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
                this.txttipodenuncia.Text = ""; 
                this.txtdescripcion.Enabled = false;
                this.cboestado.Enabled = false;
                this.GvTipoDenuncias.SelectedIndex = -1;
           
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
        this.GvTipoDenuncias.SelectedIndex = -1;
        CargarGrillaTipoDenuncias();
        this.txttipodenuncia.Text = "";
        this.txtdescripcion.Text = "";
        this.cboestado.SelectedIndex = 0;
    }

    private void CargarGrillaTipoDenunciasActivas()
    {
        DataSet ds = NegocioMantenimiento.TraerTipoDenunciaActivas();
        try
        {
            this.GvTipoDenuncias.DataSource = ds;
            //aca
            this.GvTipoDenuncias.DataBind();
            Session.Remove("listadoAreas");
            Session.Add("listadoAreas", ds);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void CargarGrillaTipoDenunciasInactivas()
    {
        DataSet ds = NegocioMantenimiento.TraerTipoDenunciaInactivas();
        try
        {
            this.GvTipoDenuncias.DataSource = ds;
            //aca
            this.GvTipoDenuncias.DataBind();
            Session.Remove("listadoAreas");
            Session.Add("listadoAreas", ds);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void btnactivos_Click(object sender, EventArgs e)
    {
        this.GvTipoDenuncias.SelectedIndex = -1;
        CargarGrillaTipoDenunciasActivas();
        this.txttipodenuncia.Text = "";
        this.txtdescripcion.Text = "";
        this.cboestado.SelectedIndex = 0;
    }

    protected void btninactivos_Click(object sender, EventArgs e)
    {
        this.GvTipoDenuncias.SelectedIndex = -1;
        CargarGrillaTipoDenunciasInactivas();
        this.txttipodenuncia.Text = "";
        this.txtdescripcion.Text = "";
        this.cboestado.SelectedIndex = 0;
    }

    protected void btncancelar_Click(object sender, EventArgs e)
    {
        this.txtdescripcion.Text = "";
        this.txttipodenuncia.Text = "";
        this.txtdescripcion.Enabled = false;
        this.GvTipoDenuncias.SelectedIndex = -1;
        habilitarBotones(true);
    }

    protected void GvTipoDenuncias_PageIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.GvTipoDenuncias.SelectedIndex = -1;
            this.GvTipoDenuncias.DataSource = null;
            this.GvTipoDenuncias.DataBind();
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

    protected void GvTipoDenuncias_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            DataSet ds = (DataSet)Session["listadoTipoDenuncias"];
            this.GvTipoDenuncias.PageIndex = e.NewPageIndex;
            this.GvTipoDenuncias.DataSource = ds;
            this.GvTipoDenuncias.DataBind();
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message.ToString());
        }
    }
}

