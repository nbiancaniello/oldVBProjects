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

public partial class webUserControl_ucBuscarPorArea : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                DataTable tmp = Negocio.NegocioMantenimiento.TraerAreas();

                this.lstAreas.Items.Clear();

                foreach (DataRow fila in tmp.Rows)
                {
                    this.lstAreas.Items.Add(fila[1].ToString());

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
            //Si se selecciono alguna area
            if (this.lstAreas.SelectedIndex >= 0)
            {

                gvwDatos.DataSource = Negocio.NegocioExpedientes.ListarPorArea(this.lstAreas.SelectedItem.Text);
                gvwDatos.DataBind();



            }
            else //sino trae todos los registros
            {
                gvwDatos.DataSource = Negocio.NegocioExpedientes.Listar();
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
