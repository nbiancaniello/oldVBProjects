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

public partial class webUserControl_ucBuscarPorFecha : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        try
        {
            DateTime fechaDesde = this.UcFechaDdFechaHh1.SelectedDateFechaDesde();
            DateTime fechaHasta = this.UcFechaDdFechaHh1.SelectedDateFechaHasta();

            this.gvwDatos.DataSource = Negocio.NegocioExpedientes.ListarPorFecha(fechaDesde.AddHours(12), fechaHasta.AddHours(12));
            this.gvwDatos.DataBind();

            this.lblCantidadRegistros.Text = gvwDatos.Rows.Count.ToString();
        }
        catch (Exception ex)
        {
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
