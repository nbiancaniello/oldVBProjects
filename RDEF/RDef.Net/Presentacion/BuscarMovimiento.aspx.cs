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

public partial class Presentacion_BuscarMovimiento : System.Web.UI.Page
{
    protected void btnVer_Click(object sender, EventArgs e)
    {
        if (txtExpediente.Text == "")
        {
            MostrarMensaje("Debe ingresar un n° de expediente");
            return;
        }

        if (Convert.ToInt64(txtExpediente.Text) > 32000) //CHONA 11/8
        {
            MostrarMensaje("El n° de expediente ingresado es muy grande");
            txtExpediente.Text = "";
            return;
        }

        if (!NegocioExpedientes.TraerExpedienteExistente(Convert.ToInt32(txtExpediente.Text))) 
        {
            MostrarMensaje("El expediente ingresado es inexistente");
            txtExpediente.Text = "";
            return;
        }
        Session.Remove("pagina");
        Session.Add("pagina","BuscarMovimientoVer");
        Response.Redirect("ListarMovimientos.aspx?idExpediente=" + txtExpediente.Text.Trim());         
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }

    protected void btnNuevo_Click(object sender, EventArgs e)
    {
        if (txtExpediente.Text == "")
        {
            MostrarMensaje("Debe ingresar un n° de expediente");
            return;
        }

        if (!NegocioExpedientes.TraerExpedienteExistente(Convert.ToInt32(txtExpediente.Text)))
        {
            MostrarMensaje("El expediente ingresado es inexistente");
            return;
        }
        String cadena;
        cadena = "Movimientos.aspx?accion=nuevo&idExpediente=" + txtExpediente.Text.Trim() + "&idMovimiento=0";
        Session.Remove("pagina");
        Session.Add("pagina", "BuscarMovimientoNuevo");
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
}
