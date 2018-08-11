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

public partial class webUserControl_ModuloConsultas_ucBuscarPorTextoDenuncia : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //Seteo de fechas
        //this.UcFechaDdFechaHh1.SelectedDateFechaDesde(Convert.ToDateTime("01/01/1999"));
        //this.UcFechaDdFechaHh1.SelectedDateFechaHasta(DateTime.Today);

    }
    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        
        String textoABuscar = "%" + this.txtTextoABuscar.Text.Trim() + "%";
        DateTime fechaDesde = this.UcFechaDdFechaHh1.SelectedDateFechaDesde();
        DateTime fechaHasta = this.UcFechaDdFechaHh1.SelectedDateFechaHasta();
        

        try
        {
            this.gvwDatos.DataSource = Negocio.NegocioExpedientes.ListarPorTextoDenuncia(textoABuscar, fechaDesde.AddHours(12), fechaHasta.AddHours(12));
            this.gvwDatos.DataBind();
            this.lblCantidadRegistros.Text = this.gvwDatos.Rows.Count.ToString();
        }
        catch (Exception ex) {
            throw ex;
        }

    }

    protected void gvwDatos_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackClientHyperlink(gvwDatos, "Select$" + e.Row.RowIndex.ToString()));
        }
    }

    public int obtenerIdExpedienteSeleccionado()
    {
        if (this.gvwDatos.SelectedIndex >= 0)
            return Convert.ToInt32(this.gvwDatos.SelectedRow.Cells[1].Text);

        return -1;
    }
}
