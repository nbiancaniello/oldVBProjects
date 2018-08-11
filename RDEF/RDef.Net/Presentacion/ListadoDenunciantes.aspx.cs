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
using System.Text;


public partial class Presentacion_ListadoDenunciantes : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!Page.IsPostBack)
            {
                DataSet dsDenunciantes = NegocioExpedientes.TraerDenunciantes();
                gvDatoDenunciante.DataSource = dsDenunciantes;
                gvDatoDenunciante.DataBind();
                if (Session["datosDen"] == null)
                    Session.Add("datosDen", dsDenunciantes);
                else
                    Session["datosDen"] = dsDenunciantes;

                cmbFiltro.Enabled = true;
                cmbFiltro.Items.Clear();
                cmbFiltro.Items.Add("Es Igual a");
                cmbFiltro.Items.Add("Mayor Que");
                cmbFiltro.Items.Add("Menor Que");

                this.txtTexto.CssClass = "TextBoxNumero";
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        DataSet dsDenunciantes = new DataSet();
        string filtro = string.Empty;

        try
        {
            if (txtTexto.Text != "")
            {

                if (cmbEleccionFiltro.SelectedIndex == 0)
                {
                    if (cmbFiltro.SelectedIndex == 0)
                        filtro = "idDenunciante =" + txtTexto.Text;
                    if (cmbFiltro.SelectedIndex == 1)
                        filtro = "idDenunciante >" + txtTexto.Text;
                    if (cmbFiltro.SelectedIndex == 2)
                        filtro = "idDenunciante <" + txtTexto.Text;
                }

                if (cmbEleccionFiltro.SelectedIndex == 1)
                {
                    if (cmbFiltro.SelectedIndex == 0)
                        filtro = "apellido='" + txtTexto.Text + "'";
                    if (cmbFiltro.SelectedIndex == 1)
                        filtro = "apellido like '%" + txtTexto.Text + "%'";
                }

                if (cmbEleccionFiltro.SelectedIndex == 2)
                {
                    if (cmbFiltro.SelectedIndex == 0)
                        filtro = "nombre='" + txtTexto.Text + "'";
                    if (cmbFiltro.SelectedIndex == 1)
                        filtro = "nombre like '%" + txtTexto.Text + "%'";
                }

                if (cmbEleccionFiltro.SelectedIndex == 3)
                    filtro = "nroDocumento=" + txtTexto.Text;

                dsDenunciantes = NegocioExpedientes.TraerDenunciantesPorFiltro(filtro);

                gvDatoDenunciante.DataSource = dsDenunciantes;
                gvDatoDenunciante.DataBind();
                if (Session["datosDen"] == null)
                    Session.Add("datosDen", dsDenunciantes);
                else
                    Session["datosDen"] = dsDenunciantes;

            }
            else
            {
                string str = "<script type = text/javascript> alert('Ingrese Texto a Buscar'); </script>";
                Page.ClientScript.RegisterStartupScript(Page.ClientScript.GetType(),"mensaje",str);
            }

            
        }

        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void gvDatoDenunciante_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackClientHyperlink(gvDatoDenunciante, "Select$" + e.Row.RowIndex.ToString()));
        }
    }
    
    protected void btnRegresar_Click(object sender, EventArgs e)
    {
        Denunciante denunciante = new Denunciante();

        try
        {
            if (gvDatoDenunciante.SelectedIndex != -1)
            {

                denunciante = NegocioExpedientes.TraerDenuncianteCompletoPorID(Convert.ToInt32(gvDatoDenunciante.SelectedRow.Cells[1].Text));

                GuardarDenuncianteSession(denunciante);
            }

            string str = "<script type = text/javascript>";
            str = str + "window.close();</script>";

            Page.ClientScript.RegisterStartupScript(Page.ClientScript.GetType(),"cerrarVentana", str);
            
        }
        catch (Exception ex)
        {
            Response.Write(ex);
        }
    }

    protected void gvDatoDenunciante_SelectedIndexChange(object sender, EventArgs e)
    {

    }

    protected void cmbEleccionFiltro_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            if (cmbEleccionFiltro.SelectedIndex == 0)
            {
                cmbFiltro.Enabled = true;
                cmbFiltro.Items.Clear();
                cmbFiltro.Items.Add("Es Igual a");
                cmbFiltro.Items.Add("Mayor Que");
                cmbFiltro.Items.Add("Menor Que");
                this.txtTexto.CssClass = "TextBoxNumero";
            }
            if (cmbEleccionFiltro.SelectedIndex == 1 || cmbEleccionFiltro.SelectedIndex == 2)
            {
                cmbFiltro.Enabled = true;
                cmbFiltro.Items.Clear();
                cmbFiltro.Items.Add("Es Igual");
                cmbFiltro.Items.Add("Contiene");
                this.txtTexto.CssClass = "TextBoxLetras";
            }

            if (cmbEleccionFiltro.SelectedIndex == 3)
            {
                cmbFiltro.Enabled=false;
                this.txtTexto.CssClass = "TextBoxNumero";
            }
        }
        catch (Exception ex)
        {
            Response.Write(ex);
        }
    }

    protected void btnLimpiarBusqueda_Click(object sender, EventArgs e)
    {
        try
        {
            txtTexto.Text = "";

            DataSet dsDenunciantes = NegocioExpedientes.TraerDenunciantes();
            gvDatoDenunciante.DataSource = dsDenunciantes;
            gvDatoDenunciante.DataBind();
        }
        catch (Exception ex)
        {
            Response.Write(ex);
        }
    }

    private void GuardarDenuncianteSession(Denunciante denunciante)
    {
        if (this.Page.Session["Denunciante"] == null)
        {
            this.Page.Session.Add("Denunciante", denunciante);
        }
        else
        {
            this.Page.Session["Denunciante"] = denunciante;
        }
    }

    protected void gvDatoDenunciante_PageIndexChanged(object sender, EventArgs e)
    {
        this.gvDatoDenunciante.SelectedIndex = -1;
    }
    protected void gvDatoDenunciante_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        DataSet ds = new DataSet();
        ds = (DataSet)Session["datosDen"];
        gvDatoDenunciante.PageIndex = e.NewPageIndex;
        gvDatoDenunciante.DataSource = ds;
        gvDatoDenunciante.DataBind();
    }
    protected void gvDatoDenunciante_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}

