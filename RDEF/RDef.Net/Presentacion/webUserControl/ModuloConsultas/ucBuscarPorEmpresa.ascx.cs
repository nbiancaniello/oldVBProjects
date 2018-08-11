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

public partial class webUserControl_ucBuscarPorEmpresa : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                DataTable tmp = Negocio.NegocioMantenimiento.TraerDenunciados();

                this.lstEmpresas.Items.Clear();

                foreach (DataRow fila in tmp.Rows)
                {
                    this.lstEmpresas.Items.Add(fila[1].ToString());

                }
                tmp.Dispose();
            }

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

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.lstEmpresas.SelectedIndex >= 0)
            {
                gvwDatos.DataSource = Negocio.NegocioExpedientes.ListarPorDenunciado(this.lstEmpresas.SelectedItem.Text, this.UcFechaDdFechaHh1.SelectedDateFechaDesde().AddHours(12), this.UcFechaDdFechaHh1.SelectedDateFechaHasta().AddHours(12));
                gvwDatos.DataBind();

            }

            this.lblCantidadRegistros.Text = gvwDatos.Rows.Count.ToString();
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    public int obtenerIdExpedienteSeleccionado()
    {
        if (this.gvwDatos.SelectedIndex >= 0)
            return Convert.ToInt32(this.gvwDatos.SelectedRow.Cells[1].Text);

        return -1;
    }
}
