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

public partial class Presentacion_MenuMantenimiento : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //cambiar el color de la opcion que esta debajo del mouse
            this.lblAreas.Attributes.Add("onmouseover", "pintarEtiqueta(\"areas\")");
            this.lblDenunciados.Attributes.Add("onmouseover", "pintarEtiqueta(\"Denunciados\")");
            this.lblDependencias.Attributes.Add("onmouseover", "pintarEtiqueta(\"dependencias\")");
            this.lblFines.Attributes.Add("onmouseover", "pintarEtiqueta(\"fines\")");
            this.lblLocalidades.Attributes.Add("onmouseover", "pintarEtiqueta(\"localidades\")");
            this.lblPersonas.Attributes.Add("onmouseover", "pintarEtiqueta(\"personas\")");
            this.lblTiposDenuncia.Attributes.Add("onmouseover", "pintarEtiqueta(\"tipodenuncias\")");
            this.lblTiposExpediente.Attributes.Add("onmouseover", "pintarEtiqueta(\"tipo Expediente\")");
            this.lblTiposMovimiento.Attributes.Add("onmouseover", "pintarEtiqueta(\"TipoMovimiento\")");

            //cambiar el color de la etiqueta, como se estuviese deseleccionada
            this.lblAreas.Attributes.Add("onmouseout", "blanquearEtiquetas(\"areas\")");
            this.lblDenunciados.Attributes.Add("onmouseout", "blanquearEtiquetas(\"Denunciados\")");
            this.lblDependencias.Attributes.Add("onmouseout", "blanquearEtiquetas(\"dependencias\")");
            this.lblFines.Attributes.Add("onmouseout", "blanquearEtiquetas(\"fines\")");
            this.lblLocalidades.Attributes.Add("onmouseout", "blanquearEtiquetas(\"localidades\")");
            this.lblPersonas.Attributes.Add("onmouseout", "blanquearEtiquetas(\"personas\")");
            this.lblTiposDenuncia.Attributes.Add("onmouseout", "blanquearEtiquetas(\"tipodenuncias\")");
            this.lblTiposExpediente.Attributes.Add("onmouseout", "blanquearEtiquetas(\"tipo Expediente\")");
            this.lblTiposMovimiento.Attributes.Add("onmouseout", "blanquearEtiquetas(\"TipoMovimiento\")");

            //redireccionar a las demas webs
            this.lblAreas.Attributes.Add("onClick", "redireccionar(\"areas\")");
            this.lblDenunciados.Attributes.Add("onClick", "redireccionar(\"Denunciados\")");
            this.lblDependencias.Attributes.Add("onClick", "redireccionar(\"dependencias\")");
            this.lblFines.Attributes.Add("onClick", "redireccionar(\"fines\")");
            this.lblLocalidades.Attributes.Add("onClick", "redireccionar(\"localidades\")");
            this.lblPersonas.Attributes.Add("onClick", "redireccionar(\"personas\")");
            this.lblTiposDenuncia.Attributes.Add("onClick", "redireccionar(\"tipodenuncias\")");
            this.lblTiposExpediente.Attributes.Add("onClick", "redireccionar(\"tipo Expediente\")");
            this.lblTiposMovimiento.Attributes.Add("onClick", "redireccionar(\"TipoMovimiento\")");

        }
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }
}
