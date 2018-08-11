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

public partial class Presentacion_Personas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            this.btnAgregar.Attributes.Add("onClick", " return mostrarCampos('agregar');");
            this.btnCancelar.Attributes.Add("onClick", "return ocultarCampos();");
            this.btnModificar.Attributes.Add("onClick", "return mostrarCampos('modificar');");
            this.txtidpersona.ReadOnly = true;
            this.cboestado.Enabled = false;
            this.txtnombre.Enabled =false;
         


            if (!IsPostBack)
            {
                cboestado.Items.Add("Activo");
                cboestado.Items.Add("Inactivo");
                txtnombre.Text = "";
                txtidpersona.Text = "";
                habilitarBotones(true);
                CargarGrillaPersonas();
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
       
    }

    private void CargarGrillaPersonas()
    {
        DataSet ds = NegocioMantenimiento.TraerPersonasEstado();
        try
        {
            this.GvPersonas.DataSource = ds;
            //aca
            this.GvPersonas.DataBind();
            Session.Remove("listadoPersonas");
            Session.Add("listadoPersonas", ds);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }
    
    protected void BtnAgregar_Click(object sender, EventArgs e)
    {
        this.txtidpersona.Enabled = true;
        this.txtnombre.Enabled = true;
        this.cboestado.Enabled = true;
        habilitarBotones(false);
        PonerFoco("txtnombre");
        this.txtidpersona.Text = (NegocioMantenimiento.TraerIdPersona()).ToString();
    }

    protected void GvPersonas_PageIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.GvPersonas.SelectedIndex = -1;
            this.GvPersonas.DataSource = null;
            this.GvPersonas.DataBind();
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void GvPersonas_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackClientHyperlink(GvPersonas, "Select$" + e.Row.RowIndex.ToString()));
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
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

    protected void btnmodificar_Click(object sender, EventArgs e)
    {

        try
        {
            this.txtidpersona.Enabled = true;
            this.txtnombre.Enabled = true;

            if (GvPersonas.SelectedIndex != -1 && GvPersonas.Rows.Count > 0)
            {
                this.txtidpersona.Enabled = true;
                this.txtnombre.Enabled = true;
                this.cboestado.Enabled = true;
                PonerFoco("txtnombre");
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

    protected void btneliminar_Click(object sender, EventArgs e)
    {

        try
        {

            if (GvPersonas.SelectedIndex != -1 && GvPersonas.Rows.Count > 0)
            {
                int id = int.Parse(GvPersonas.SelectedRow.Cells[1].Text);
                string mens = NegocioMantenimiento.EliminarPersona(id);
                if (mens != "")
                {

                    MostrarMensaje(mens);

                }


                else
                {
                    CargarGrillaPersonas();
                }

                this.txtidpersona.Text = "";
                this.txtnombre.Text = "";
                this.cboestado.SelectedIndex = 0;
                this.GvPersonas.SelectedIndex = -1;

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

    protected void btnretornar_Click(object sender, EventArgs e)
    {
        Response.Redirect("MenuMantenimiento.aspx");
    }

    protected void btnaceptar_Click(object sender, EventArgs e)
    {

        try
        {
            if (this.txtidpersona.Text.Trim() != "")
            {
                try
                {

                    Persona persona = new Persona();
                    persona.nombrePersona = this.txtnombre.Text.Trim();
                    



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

                        persona.estado = Convert.ToBoolean(Est);
                        persona.idPersona = NegocioMantenimiento.TraerIdPersona();
                        this.cboestado.Enabled = true;
                        NegocioMantenimiento.AgregarPersona(persona);

                        MostrarMensaje("Una nueva Persona ha sido agregada satisfactoriamente");
                        txtnombre.Text = "";
                        cboestado.SelectedIndex = 0;
                        txtnombre.Enabled = false;
                    }

                    else
                    {
                        persona.idPersona= int.Parse(GvPersonas.SelectedRow.Cells[1].Text);


                        if (cboestado.SelectedItem.Text == "Activo")
                        {
                            int Est = 1;

                            persona.estado = Convert.ToBoolean(Est);

                        }
                        else
                        {

                            int Est = 0;

                            persona.estado = Convert.ToBoolean(Est);
                        }




                        NegocioMantenimiento.ModificarPersona(persona);

                        MostrarMensaje("Usted ha modificado la Persona:  " + persona.nombrePersona + ", satisfactoriamente.");
                        txtnombre.Text = "";
                        cboestado.SelectedIndex = 0;


                        txtnombre.Enabled = false;
                    }




                    CargarGrillaPersonas();
                    this.txtidpersona.Text = "";
                    this.txtnombre.Text = "";
                    this.cboestado.Enabled = false;
                    this.GvPersonas.SelectedIndex = -1;

                }
                catch (Exception ex)
                {
                    Response.Redirect("Errores.aspx?error=" + ex.Message);
                }

            }
            else
            {

                MostrarMensaje("Por Favor, complete todos los campos antes de realizar esta función.");

                this.txtnombre.Text = "";
                this.txtidpersona.Text = "";
                this.txtnombre.Enabled = false;
                this.cboestado.Enabled = false;

            }
        }

        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);

        }
        habilitarBotones(true);
    }

    protected void btncancelar_Click(object sender, EventArgs e)
    {        
        this.txtnombre.Text = "";
        this.txtidpersona.Text = "";
        this.txtnombre.Enabled = false;
        this.btnAceptar.Enabled = true;
        this.GvPersonas.SelectedIndex = -1;
        habilitarBotones(true);
    }

    protected void GvPersonas_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            txtidpersona.Text = this.GvPersonas.SelectedRow.Cells[1].Text;
            txtnombre.Text = this.GvPersonas.SelectedRow.Cells[2].Text;
            cboestado.Text = this.GvPersonas.SelectedRow.Cells[3].Text;
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void btntodos_Click(object sender, EventArgs e)
    {
        this.GvPersonas.SelectedIndex = -1;
        CargarGrillaPersonas();
        this.txtidpersona.Text = "";
        this.txtnombre.Text = "";
        this.cboestado.SelectedIndex = 0;
    }

    protected void btnactivos_Click(object sender, EventArgs e)
    {
        this.GvPersonas.SelectedIndex = -1;
        CargarGrillaPersonasActivas();
        this.txtidpersona.Text = "";
        this.txtnombre.Text = "";
        this.cboestado.SelectedIndex = 0;
    }

    protected void btninactivos_Click(object sender, EventArgs e)
    {

        this.GvPersonas.SelectedIndex = -1;
        CargarGrillaPersonasInactivas();
        this.txtidpersona.Text = "";
        this.txtnombre.Text = "";
        this.cboestado.SelectedIndex = 0;
    }

    private void CargarGrillaPersonasInactivas()
    {
        DataSet ds = NegocioMantenimiento.TraerPersonasInactivas();
        try
        {
            this.GvPersonas.DataSource = ds;
            //aca
            this.GvPersonas.DataBind();
            Session.Remove("listadoPersonas");
            Session.Add("listadoPersonas", ds);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void CargarGrillaPersonasActivas()
    {
        DataSet ds = NegocioMantenimiento.TraerPersonasActivas();
        try
        {
            this.GvPersonas.DataSource = ds;
            //aca
            this.GvPersonas.DataBind();
            Session.Remove("listadoPersonas");
            Session.Add("listadoPersonas", ds);
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

    protected void GvPersonas_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            DataSet ds = (DataSet)Session["listadoPersonas"];
            this.GvPersonas.PageIndex = e.NewPageIndex;
            this.GvPersonas.DataSource = ds;
            this.GvPersonas.DataBind();
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message.ToString());
        }
    }
}