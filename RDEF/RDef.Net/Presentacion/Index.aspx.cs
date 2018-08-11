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

public partial class Index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            //cambiar el color de la opcion que esta debajo del mouse
            this.lblExpedientes.Attributes.Add("onmouseover", "pintarEtiqueta(\"Expedientes\")");
            this.lblMovimientos.Attributes.Add("onmouseover", "pintarEtiqueta(\"BuscarMovimiento\")");
            this.lblConsultas.Attributes.Add("onmouseover", "pintarEtiqueta(\"Consultas\")");
            this.lblConsultasPorInformantes.Attributes.Add("onmouseover", "pintarEtiqueta(\"ConsultasPorInformantes\")");
            this.lblMantenimiento.Attributes.Add("onmouseover", "pintarEtiqueta(\"Mantenimiento\")");
            this.lblSalir.Attributes.Add("onmouseover", "pintarEtiqueta(\"Salir\")");

            //cambiar el color de la etiqueta, como se estuviese deseleccionada
            this.lblExpedientes.Attributes.Add("onmouseout", "blanquearEtiquetas(\"Expedientes\")");
            this.lblMovimientos.Attributes.Add("onmouseout", "blanquearEtiquetas(\"BuscarMovimiento\")");
            this.lblConsultas.Attributes.Add("onmouseout", "blanquearEtiquetas(\"Consultas\")");
            this.lblConsultasPorInformantes.Attributes.Add("onmouseout", "blanquearEtiquetas(\"ConsultasPorInformantes\")");
            this.lblMantenimiento.Attributes.Add("onmouseout", "blanquearEtiquetas(\"Mantenimiento\")");
            this.lblSalir.Attributes.Add("onmouseout", "blanquearEtiquetas(\"Salir\")");

            //redireccionar a las demas webs
            this.lblExpedientes.Attributes.Add("onClick", "redireccionar(\"Expedientes\")");
            this.lblMovimientos.Attributes.Add("onClick", "redireccionar(\"BuscarMovimiento\")");
            this.lblConsultas.Attributes.Add("onClick", "redireccionar(\"Consultas\")");
            this.lblConsultasPorInformantes.Attributes.Add("onClick", "redireccionar(\"ConsultasPorInformantes\")");
            this.lblMantenimiento.Attributes.Add("onClick", "redireccionar(\"Mantenimiento\")");
            this.lblSalir.Attributes.Add("onClick", "redireccionar(\"Salir\")");

            Session.Add("Expediente", null);
       
        }
    }
}
