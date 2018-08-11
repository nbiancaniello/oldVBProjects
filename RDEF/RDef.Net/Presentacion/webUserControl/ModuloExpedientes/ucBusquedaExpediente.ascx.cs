using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Data.Odbc;
using Negocio;
using Entidades;


public partial class busquedaExpediente : System.Web.UI.UserControl
{


    protected void Page_Load(object sender, EventArgs e)
    {
        Page.Form.DefaultButton = this.btnBuscar.UniqueID;

        if (!IsPostBack)
        {
            this.ddlBuscarPor.SelectedValue = "0";
            this.txtConsulta.CssClass = "TextBoxNumero";
            this.cargarFiltroDdl(false);
            this.gvwDatos.Visible = false;
            this.gvwContactos.Visible = false;
        }
    }

    protected void gvwDatos_PageIndexChanging(object sender, GridViewPageEventArgs e)
    {
        DataTable ds = new DataTable();
        ds = (DataTable)Session["datos"];
        gvwDatos.PageIndex = e.NewPageIndex;
        gvwDatos.DataSource = ds;
        gvwDatos.DataBind();
    }

    protected void gvwDatos_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        if (e.Row.RowType == DataControlRowType.DataRow)
        {
            e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackClientHyperlink(gvwDatos, "Select$" + e.Row.RowIndex.ToString()));
        }
    }

    protected void gvwDatos_SelectedIndexChanged(object sender, EventArgs e)
    {
        Expediente exp = NegocioExpedientes.TraerExpedienteCompletoPorIdExpediente(Convert.ToInt32(gvwDatos.SelectedRow.Cells[1].Text));

        if (Session["Expediente"] == null)
            Session.Add("Expediente", exp);
        else
            Session["Expediente"] = exp;

        this.txtDetalleDeLaDenuncia.Text = exp.descDenuncia;

        this.gvwContactos.DataSource = NegocioExpedientes.TraerContactosDenunciante(exp.denunciante.idDenunciante);//TODO
        this.gvwContactos.DataBind();
    }

    protected void gvwDatos_PageIndexChanged(object sender, EventArgs e)
    {
        this.txtDetalleDeLaDenuncia.Text = "";
        this.gvwDatos.SelectedIndex = -1;
        this.gvwContactos.DataSource = null;
        this.gvwContactos.DataBind();
    }
    protected void ddlBuscarPor_SelectedIndexChanged(object sender, EventArgs e)
    {
        this.txtConsulta.Text = "";
        //this.CompareValidator1.Enabled = false;
        switch (ddlBuscarPor.SelectedValue)
        {
            case "0": //Numero
                cargarFiltroDdl(false);
                this.txtConsulta.MaxLength = 6;
                //agregado 15/8
                this.txtConsulta.CssClass = "TextBoxNumero";
                break;
            case "1": //Apellido
                cargarFiltroDdl(true);
                this.txtConsulta.MaxLength = 30;
                //agregado 15/8
                this.txtConsulta.CssClass = "TextBoxAlfaNumerico";
                break;
            case "2": //Calle
                cargarFiltroDdl(true);
                this.txtConsulta.MaxLength = 50;
                //agregado 15/8
                this.txtConsulta.CssClass = "TextBoxAlfaNumerico";
                break;
        }
    }

    private void cargarFiltroDdl(Boolean texto)
    {
        this.ddlFiltro.Items.Clear();

        this.ddlFiltro.Items.Add("Es igual a");
        if (texto)
        {
            this.ddlFiltro.Items.Add("Contiene");
        }
    }

    protected void btnBuscar_Click(object sender, EventArgs e)
    {
        DataTable listaExpedientes = new DataTable();
        //List<Expediente> listaExpedientes = new List<Expediente>();

        this.txtDetalleDeLaDenuncia.Text = "";
        this.gvwDatos.SelectedIndex = -1;
        try
        {
            if (this.txtConsulta.Text.Trim() != "")
            {
                switch (this.ddlBuscarPor.SelectedValue)
                {
                    case "0":
                        listaExpedientes = buscarExpedientesByIdExpediente(Convert.ToInt32(this.txtConsulta.Text.Trim()));
                        break;
                    case "1":
                        if (ddlFiltro.SelectedValue == "Es igual a")
                            listaExpedientes = buscarExpedientesByApellido(this.txtConsulta.Text.Trim(), false);
                        else
                            listaExpedientes = buscarExpedientesByApellido(this.txtConsulta.Text.Trim(), true);
                        break;
                    case "2":
                        if (ddlFiltro.SelectedValue == "Es igual a")
                            listaExpedientes = buscarExpedientesByCalle(this.txtConsulta.Text.Trim(), false);
                        else
                            listaExpedientes = buscarExpedientesByCalle(this.txtConsulta.Text.Trim(), true);
                        break;
                }
            }
            else
            {
                listaExpedientes = NegocioExpedientes.Listar();
            }

            cargarGrilla(listaExpedientes);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    /// <summary>
    /// Llama al negocio para buscar Expedientes por numeroExpediente
    /// </summary>
    /// <param name="idExpediente"></param>
    /// <returns></returns>
    private DataTable buscarExpedientesByIdExpediente(int idExpediente)
    //private List<Expediente> buscarExpedientesByIdExpediente(int idExpediente)
    {

        DataTable dataTableExpedientes = new DataTable();
        //List<Expediente> listaExpediente = new List<Expediente>();

        try
        {
            dataTableExpedientes = NegocioExpedientes.Listar(idExpediente, null, null);
            //listaExpediente = NegocioExpedientes.Listar(idExpediente, null, null);

            return dataTableExpedientes;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            //listaExpediente.Clear();
            dataTableExpedientes.Dispose();
        }

    }

    /// <summary>
    /// Llama al negocio para buscar Expedientes por apellido
    /// </summary>
    /// <param name="apellido"></param>
    /// <param name="isLike"></param>
    /// <returns></returns>
    private DataTable buscarExpedientesByApellido(String apellido, Boolean isLike)
    //private List<Expediente> buscarExpedientesByApellido(String apellido, Boolean isLike)
    {

        DataTable dataTableExpedientes = new DataTable();
        //List<Expediente> listaExpediente = new List<Expediente>();

        try
        {
            if (isLike)
                dataTableExpedientes = NegocioExpedientes.Listar(apellido, null);
                //listaExpediente = NegocioExpedientes.Listar(apellido, null);
            else
                dataTableExpedientes = NegocioExpedientes.Listar(null, apellido, null);
                //listaExpediente = NegocioExpedientes.Listar(null, apellido, null);

            return dataTableExpedientes;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            dataTableExpedientes.Dispose();
            //listaExpediente.Clear();
        }

    }

    /// <summary>
    /// Llama al negocio para buscar Expedientes por calle
    /// </summary>
    /// <param name="calle"></param>
    /// <param name="isLike"></param>
    /// <returns></returns>
    //private List<Expediente> buscarExpedientesByCalle(String calle, Boolean isLike)
    private DataTable buscarExpedientesByCalle(String calle, Boolean isLike)
    {

        DataTable dataTableExpedientes = new DataTable();
        //List<Expediente> listaExpediente = new List<Expediente>();
        try
        {
            if (isLike)
                dataTableExpedientes = NegocioExpedientes.Listar(null, calle);
                //listaExpediente = NegocioExpedientes.Listar(null, calle);
            else
                dataTableExpedientes = NegocioExpedientes.Listar(null, null, calle);
                //listaExpediente = NegocioExpedientes.Listar(null, null, calle);

            return dataTableExpedientes;
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            dataTableExpedientes.Dispose();
            //listaExpediente.Clear();
        }

    }

    /// <summary>
    /// Carga el gridView a partir del DataTable recibido como parámetro
    /// </summary>
    /// <param name="dataTableExpedientes"></param>
    private void cargarGrilla(DataTable dataTableExpedientes)
    //private void cargarGrilla(List<Expediente> listaExpedientes)
    {
        int cantidadRegistros = 0;
        this.gvwDatos.DataSource = dataTableExpedientes;
        //this.gvwDatos.DataSource = listaExpedientes;
        this.gvwDatos.DataBind();
        Session.Add("datos", dataTableExpedientes);

        //cantidadRegistros = listaExpedientes.Count;
        cantidadRegistros = dataTableExpedientes.Rows.Count;

        if (cantidadRegistros == 0)
        {
            this.lblCantidadRegistros.Text = "La búsqueda no ha devuelto resultados";
            this.gvwDatos.Visible = false;
            this.gvwContactos.Visible = false;
        }
        else
        {
            this.lblCantidadRegistros.Text = "Cantidad de registros encontrados: " + cantidadRegistros.ToString();
            this.gvwDatos.Visible = true;
            this.gvwContactos.Visible = true;


        }
    }


    protected void btnIr_Click(object sender, EventArgs e)
    {
        try
        {
                Response.Redirect("Expedientes.aspx");
        }
        catch (Exception ex)
        {
            throw ex;
        }

    }
}
