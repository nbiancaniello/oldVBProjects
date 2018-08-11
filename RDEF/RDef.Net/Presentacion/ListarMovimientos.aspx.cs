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
using System.Collections.Generic;
using Negocio;
using Entidades;
public partial class Presentacion_ListarMovimientos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        int idExpediente = 0;
        if (Request.QueryString.Count > 0)
        {
            idExpediente = Convert.ToInt32(Request.QueryString.Get("idExpediente"));
        }
        lblIdExpediente.Text = Convert.ToString(idExpediente);
        DataSet ds = NegocioMovimientos.TraerDataset(idExpediente);
        if (ds.Tables[0].Rows.Count == 0) 
        {
            MostrarMensaje("No hay movimientos para este expediente");
        }
        gvMovimientos.DataSource = ds;
        gvMovimientos.DataBind();
        Session.Add("listarVer", ds);
    }

    protected void gvMovimientos_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {
            // Pregunta agregada por Nico.
            if (this.gvMovimientos.SelectedIndex >= 0)
            {
                string split = gvMovimientos.SelectedRow.Cells[1].Text;
                Session["ListarMovimientosid"] = Convert.ToInt32(split);
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message.ToString());
        }
                        
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {
        String cadena;
        cadena = Convert.ToString(Session["pagina"]);
        switch (cadena) 
        {
            case "BuscarMovimientoVer":
                Response.Redirect("BuscarMovimiento.aspx");
                break;
            case "Expedientes":
                Response.Redirect("Expedientes.aspx");
                break;
            case "ConsultasPorInformantes":
                Response.Redirect("ConsultasPorInformantes.aspx");
                break;
        }              
    }

    protected void btnVer_Click(object sender, EventArgs e)
    {
        if (this.gvMovimientos.SelectedIndex >= 0)
        {
            Byte idMovimiento = Convert.ToByte(Session["ListarMovimientosid"]);
            String cadena;
            cadena = "Movimientos.aspx?accion=ver&idExpediente=" + lblIdExpediente.Text;
            cadena = cadena + "&idMovimiento=" + Convert.ToString(idMovimiento);
            Response.Redirect(cadena);
        }
        else 
        {
            MostrarMensaje("Debe seleccionar un registro de la lista");
        }
    }

    protected void btnNuevoMovimiento_Click(object sender, EventArgs e)
    {
        String cadena;
        cadena = "Movimientos.aspx?accion=nuevo&idExpediente=" + lblIdExpediente.Text + "&idMovimiento=0";
        Response.Redirect(cadena);
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

    protected void gvMovimientos_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        try
        {
            DataSet ds = (DataSet)Session["listarVer"];
            gvMovimientos.PageIndex = e.NewPageIndex;
            gvMovimientos.DataSource = ds;
            gvMovimientos.DataBind();
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message.ToString());
        } 
    }

    protected void gvMovimientos_PageIndexChanged(object sender, EventArgs e)
    {
        try
        {
            this.gvMovimientos.SelectedIndex = -1;
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message.ToString());
        }
    }

    protected void gvMovimientos_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackClientHyperlink(gvMovimientos, "Select$" + e.Row.RowIndex.ToString()));
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

}
