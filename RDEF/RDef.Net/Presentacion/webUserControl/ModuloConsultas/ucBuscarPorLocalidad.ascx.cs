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

public partial class webUserControl_ucBuscarPorLocalidad : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            if (!IsPostBack)
            {
                DataTable tmp = Negocio.NegocioMantenimiento.TraerLocalidades();

                this.lstLocalidades.Items.Clear();

                foreach (DataRow fila in tmp.Rows)
                {
                    this.lstLocalidades.Items.Add(fila[2].ToString());

                }
                tmp.Dispose();
            }
           
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }
    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        try
        {
            if (lstLocalidades.SelectedIndex >= 0)
            {
                gvwDatos.DataSource = Negocio.NegocioExpedientes.ListarPorLocalidad(lstLocalidades.SelectedItem.Text);
                gvwDatos.DataBind();
            }

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
