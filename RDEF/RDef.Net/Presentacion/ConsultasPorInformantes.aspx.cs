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
using System.Data.Odbc;
using Negocio;
using Entidades;
public partial class Presentacion_consultasPorInformantes : System.Web.UI.Page
{
    private NegocioConsultasPorInformantes negocio = new NegocioConsultasPorInformantes();
    private static int informante=-1;
    private static string evento = "nada";
    private static string estado = "nada";
    protected void Page_Load(object sender, System.EventArgs e) {
        try
        {
            if (IsPostBack == false)
            {
                negocio.CargarLista(Lista, "CALL SP_CI_VerInformantes");
                ControlPostBack(sender,e);
                Session.Remove("pagina");
                Session.Add("pagina", "ConsultasPorInformantes");
            }
        }
        catch(Exception ex)    
        {
            
            Response.Redirect("Errores_CI.aspx?error=" + ex.Message.ToString()+ "&pagina anterior="+HttpContext.Current.Request.Url.LocalPath);
        }
    }   
    protected void btnInformantes_Click(object sender, System.EventArgs e) {
        try
        {
            if (Lista.SelectedIndex != -1)
            {
                negocio.ColumnasMostrarPorInformantes_Todos(tabla);
                Session.Add("datatable_ci", negocio.MostrarPorInformantes(tabla, RbLista, Lista));
                Session.Add("VectorExpedientes", negocio.CargarVectorExpedientes((DataTable)Session["datatable_ci"]));
                evento = "informantes";
                estado = RbLista.SelectedValue;
                informante = Lista.SelectedIndex;
            }
            else
            {
                Response.Redirect("Errores_CI.aspx?error=No Seleccionó Informante" + "&pagina anterior=" + HttpContext.Current.Request.Url.LocalPath);
            }
        }
        catch (OdbcException ex)
        {
            Response.Redirect("Errores_CI.aspx?error=" + ex.Message.ToString() + "&pagina anterior=" + HttpContext.Current.Request.Url.LocalPath);
        }
    }  
    protected void btnUltMovimiento_Click(object sender, System.EventArgs e) {
        try
        {
            if (Lista.SelectedIndex != -1)
            {
                negocio.ColumnasUltimoMovimiento(tabla);
                Session.Add("datatable_ci", negocio.UltMovimiento(tabla, Lista, "call SP_CI_VerUltimoMovimiento(?)"));
                Session.Add("VectorExpedientes", negocio.CargarVectorExpedientes((DataTable)Session["datatable_ci"]));
                evento = "ultmovimiento";
                informante = Lista.SelectedIndex;
	        }
	        else
	        {
                Response.Redirect("Errores_CI.aspx?error=No Seleccionó Informante" + "&pagina anterior=" + HttpContext.Current.Request.Url.LocalPath);
	        }
        }
        catch (OdbcException ex)
        {
            Response.Redirect("Errores_CI.aspx?error=" + ex.Message.ToString() + "&pagina anterior=" + HttpContext.Current.Request.Url.LocalPath);
        }
    }   
    protected void btnPaseInterno_Click(object sender, System.EventArgs e) {
        try
        {
            if (Lista.SelectedIndex != -1)
            {
                negocio.ColumnasSoloPaseInterno(tabla);
                Session.Add("datatable_ci", negocio.SoloPaseInterno(tabla, Lista, "call SP_CI_VerSoloPaseInterno(?)"));
                Session.Add("VectorExpedientes", negocio.CargarVectorExpedientes((DataTable)Session["datatable_ci"]));
                evento = "solopaseinterno";
                informante = Lista.SelectedIndex;
            }
            else
            {
                Response.Redirect("Errores_CI.aspx?error=No Seleccionó Informante" + "&pagina anterior=" + HttpContext.Current.Request.Url.LocalPath);
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores_CI.aspx?error=" + ex.Message.ToString() + "&pagina anterior=" + HttpContext.Current.Request.Url.LocalPath);
        }
    }  
    protected void btnTodos_Click(object sender, System.EventArgs e) {
        try
        {
            negocio.ColumnasMostrarPorInformantes_Todos(tabla);
            Session.Add("datatable_ci", negocio.MostrarTodos(tabla, RbLista));
            Session.Add("VectorExpedientes", negocio.CargarVectorExpedientes((DataTable)Session["datatable_ci"]));
            evento = "todos";
            estado = RbLista.SelectedValue;
            informante = -2;
        }
        catch (OdbcException ex)
        {
            Response.Redirect("Errores_CI.aspx?error=" + ex.Message.ToString() + "&pagina anterior=" + HttpContext.Current.Request.Url.LocalPath);
        }
    }
    protected void ControlPostBack(object sender, EventArgs e)
    {
        if (informante != -1)
        {
            switch (evento)
            {
                case "todos":
                    RbLista.SelectedValue = estado;
                    btnTodos_Click(sender, e);
                    break;
                case "informantes":
                    RbLista.SelectedValue = estado;
                    Lista.SelectedIndex = informante;
                    btnInformantes_Click(sender, e);
                    break;
                case "solopaseinterno":
                    Lista.SelectedIndex = informante;
                    btnPaseInterno_Click(sender, e);
                    break;
                case "ultmovimiento":
                    Lista.SelectedIndex = informante;
                    btnUltMovimiento_Click(sender, e);
                    break;
            }
        }
        informante = -1;
    }


    protected void tabla_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        tabla.PageIndex = e.NewPageIndex;
        tabla.DataSource = (DataTable)Session["datatable_ci"];
        tabla.DataBind();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            informante = -1;
            Session.Remove("datatable_ci");
            Session.Remove("VectorExpedientes");
            Response.Redirect("Index.aspx");
        }
        catch (OdbcException ex)
        {
            Response.Redirect("Errores_CI.aspx?error=" + ex.Message.ToString() + "&pagina anterior=" + HttpContext.Current.Request.Url.LocalPath);
        }
    }
}
