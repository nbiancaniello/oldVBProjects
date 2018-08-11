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
//using AjaxControlToolkit;
//using AjaxControlToolkit;
//<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajdax" %>


public partial class Consultas : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            this.lblPorTextoDenuncia.Attributes.Add("onClick", "mostrarTab(\"divPorTextoDenuncia\")");
            this.lblPorFecha.Attributes.Add("onClick", "mostrarTab(\"divPorFecha\")");
            this.lblPorLocalidad.Attributes.Add("onClick", "mostrarTab(\"divPorLocalidad\")");
            this.lblPorArea.Attributes.Add("onClick", "mostrarTab(\"divPorArea\")");
            this.lblPorEmpresa.Attributes.Add("onClick", "mostrarTab(\"divPorEmpresa\")");
            
            //Por default, esta es la primer pestaña seleccionada
            this.controlOculto.Value = "divPorTextoDenuncia";
            
        }
        //Page.ClientScript.RegisterStartupScript(this.GetType(), "onUnload", "alert(\"mensaje\");"); //"mostrarTabSeleccionado();");
        //else
        //{
        //    System.Web.UI.WebControls.Label lblMsg = new System.Web.UI.WebControls.Label();
        //    //lblMsg.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + "mi mensaje" + "')</script>"; Page.Controls.Add(lblMsg);
        //    lblMsg.Text = "<script language='javascript'>" + Environment.NewLine + "document.getElementById(document.getElementById(\"controlOculto\").value).style.display=\"block\"; </script>"; Page.Controls.Add(lblMsg);
        //}
    }
    protected void btnVerDetalle_Click(object sender, EventArgs e)
    {
        int id_expediente = -1;
        
        switch (this.controlOculto.Value)
        { 
            case "divPorTextoDenuncia":
                id_expediente = this.UcBuscarPorTextoDenuncia1.obtenerIdExpedienteSeleccionado();
                break;
            case "divPorFecha":
                id_expediente = this.UcBuscarPorFecha1.obtenerIdExpedienteSeleccionado();
                break;
            case "divPorLocalidad":
                id_expediente = this.UcBuscarPorLocalidad1.obtenerIdExpedienteSeleccionado();
                break;
            case "divPorArea":
                id_expediente = this.UcBuscarPorArea1.obtenerIdExpedienteSeleccionado();
                break;
            case "divPorEmpresa":
                id_expediente = this.UcBuscarPorEmpresa1.obtenerIdExpedienteSeleccionado();
                break;        
        }

        if (id_expediente != -1)
            Response.Redirect("DetalleDenuncia.aspx?idExpediente=" + id_expediente.ToString());



    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect("Index.aspx");
    }
}
