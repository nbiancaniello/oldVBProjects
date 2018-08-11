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

public partial class Presentacion_Localidades : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            this.btnAgregar.Attributes.Add("onClick"," return mostrarCampos('agregar');");
            this.btncancelar.Attributes.Add("onClick","return ocultarCampos();");
            this.btnmodificar.Attributes.Add("onClick", "return mostrarCampos('modificar');");
            
            if (!IsPostBack)
            {
                if (Session["EsPopup"] != null)
                {
                    if (int.Parse(Session["EsPopup"].ToString()) == 1)
                    {
                        this.btnRegresar.Text = "Regresar";
                    }
                    else
                    {
                        this.btnRegresar.Text = "Volver";
                    }

                }
                else
                {
                    this.btnRegresar.Text = "Volver";
                }

                cboPartidos.DataSource = NegocioMantenimiento.TraerPartidos();
                cboPartidos.DataValueField = "codPartido";
                cboPartidos.DataTextField = "Nombre";
                cboPartidos.DataBind();

                cboPartidos.Items.Insert(0, new ListItem("<Seleccionar>","-1"));

                CargarGrillaLocalidades();

            }
        }        
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
        

    }

    protected void cboPartidos_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            int idPartidoSel = int.Parse(this.cboPartidos.SelectedValue);
            if (idPartidoSel == -1) return;
            hIdPartidoSel.Value = idPartidoSel.ToString();
            this.gvLocalidades.DataSource = NegocioMantenimiento.TraerLocalidadesPorPartido(idPartidoSel);
            this.gvLocalidades.DataBind();            
            this.lblPartido.Text = this.cboPartidos.SelectedItem.Text;
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }

    }
    protected void gvLocalidades_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.txtCP.Text = this.gvLocalidades.SelectedRow.Cells[2].Text;
            this.txtLoc.Text = this.gvLocalidades.SelectedRow.Cells[3].Text;
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }

    }
    protected void gvLocalidades_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        { 
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackClientHyperlink(gvLocalidades, "Select$" + e.Row.RowIndex.ToString()));
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }
    protected void gvLocalidades_PageIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.gvLocalidades.SelectedIndex = -1;
            this.gvLocalidades.DataSource = null;
            this.gvLocalidades.DataBind();         
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    private void CargarGrillaLocalidades()
    {
        try
        {
            int idPartidoSel = hIdPartidoSel.Value != "" ? int.Parse(hIdPartidoSel.Value) : int.Parse(cboPartidos.Items[0].Value);
            this.gvLocalidades.DataSource = NegocioMantenimiento.TraerLocalidadesPorPartido(idPartidoSel);
            this.gvLocalidades.DataBind();
            this.lblPartido.Text = this.cboPartidos.SelectedItem.Text;
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
            int idLocSel = int.Parse(gvLocalidades.SelectedRow.Cells[1].Text);
            string mens = NegocioMantenimiento.EliminarLocalidad(idLocSel);
            if (mens != "")
                MostrarMensaje(mens);
            else
            CargarGrillaLocalidades();
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }

    }
    protected void btnRegresar_Click(object sender, EventArgs e)
    {
        try
        {
            if (btnRegresar.Text == "Regresar")
            {

                if (gvLocalidades.SelectedIndex != -1)
                {
                    //Si se abrio como popup, estoy ingresando desde expedientes..solo busqueda!
                    string idDescOtraLoc;
                    idDescOtraLoc = gvLocalidades.SelectedRow.Cells[1].Text + "|" + gvLocalidades.SelectedRow.Cells[3].Text;
                    string retorno = "<script type='text/javascript'>" +
                        "window.returnValue = '" + idDescOtraLoc + "';window.close();</script>";

                    Page.ClientScript.RegisterStartupScript(Page.ClientScript.GetType(), "cerrar", retorno);
                }
            }
            else
            {
                Response.Redirect("MenuMantenimiento.aspx");
            }

            Session["EsPopup"] = 0;
        }
        catch (System.Threading.ThreadAbortException) { }
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
    protected void btnaceptar_Click1(object sender, EventArgs e)
    {

        try
        {
            Localidad localidad = new Localidad();
            localidad.idLocalidad = NegocioMantenimiento.TraerProxIDLoc();
            localidad.codigoPostal = int.Parse(this.txtCP.Text);
            localidad.descLocalidad = this.txtLoc.Text;
            localidad.idPartido = byte.Parse(this.cboPartidos.SelectedValue);

            if (hAccion.Value == "agregar")
                NegocioMantenimiento.AgregarLocalidad(localidad);
            else
            {
                localidad.idLocalidad = int.Parse(gvLocalidades.SelectedRow.Cells[1].Text);
                NegocioMantenimiento.ModificarLocalidad(localidad);
            }


            CargarGrillaLocalidades();

        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void btncancelar_Click(object sender, EventArgs e)
    {
        this.txtLoc.Text = "";
    }
}
