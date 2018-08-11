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


public partial class Presentacion_DetallesConsultasPorInformante : System.Web.UI.Page
{
    public NegocioConsultasPorInformantes negocio = new NegocioConsultasPorInformantes();
    public DataTable principal=new DataTable();
    public DataTable contactos = new DataTable();
    public static int posicion;
    public static int[] vector;
    
    protected void Page_Load(object sender, System.EventArgs e)
    {
        try
        {
            if (IsPostBack == false)
            {
                vector = (int[])Session["VectorExpedientes"];
                posicion = negocio.DeterminarPosicion(vector, Convert.ToInt16(Request.QueryString[0]));
                MostrarDetalles(posicion, principal, contactos);
            }
        }
        catch (OdbcException ex)
        {
            Response.Redirect("Errores_CI.aspx?error=" + ex.Message.ToString() + "&pagina anterior=" + HttpContext.Current.Request.Url.LocalPath);
        }
    }
    protected void BtnAtras_Click(object sender, System.EventArgs e)
    {
        try
        {
            if (posicion != 0)
            {
                posicion = posicion - 1;
                MostrarDetalles(posicion, principal, contactos);
            }
        }
        catch (OdbcException ex)
        {
            Response.Redirect("Errores_CI.aspx?error=" + ex.Message.ToString() + "&pagina anterior=" + HttpContext.Current.Request.Url.LocalPath);
        }      
    }
    protected void MostrarDetalles(int posicion,DataTable principal,DataTable contactos)
    {
        try
        {
            principal = negocio.CargarPrincipalContactos(vector[posicion],"call SP_CI_VerPrincipal(?)");
            contactos = negocio.CargarPrincipalContactos(vector[posicion], "call SP_CI_VerContactos(?)");       
            txtExpediente.Text = principal.Rows[0].ItemArray[0].ToString();
            txtNombre.Text = principal.Rows[0].ItemArray[1].ToString();
            txtApellido.Text = principal.Rows[0].ItemArray[2].ToString();
            txtFechaIngreso.Text = principal.Rows[0].ItemArray[3].ToString();
            txtFechaArchivo.Text = principal.Rows[0].ItemArray[4].ToString();
            txtCalle.Text = principal.Rows[0].ItemArray[5].ToString();
            txtNro.Text = principal.Rows[0].ItemArray[6].ToString();
            txtPiso.Text = principal.Rows[0].ItemArray[7].ToString();
            txtDpto.Text = principal.Rows[0].ItemArray[8].ToString();
            txtNroDoc.Text = principal.Rows[0].ItemArray[9].ToString();
            txtTipoDoc.Text = principal.Rows[0].ItemArray[10].ToString();
            txtDenunciado.Text = principal.Rows[0].ItemArray[11].ToString();
            txtTipoDenuncia.Text = principal.Rows[0].ItemArray[12].ToString();
            txtInicio.Text= principal.Rows[0].ItemArray[13].ToString();
            txtDetalleDenuncia.Text = principal.Rows[0].ItemArray[14].ToString();
            txtLocalidad.Text = principal.Rows[0].ItemArray[15].ToString();
            txtInformante.Text = negocio.CargarAreaInformante(vector[posicion], "call SP_CI_VerInformante(?)");
            txtArea.Text = negocio.CargarAreaInformante(vector[posicion], "call SP_CI_VerArea(?)");
            txtCelular.Text = "";
            txtTelefono.Text = "";
            txtEmail.Text = "";
            for (int i = 0; i < contactos.Rows.Count; i++)
            {
                if (contactos.Rows[i].ItemArray[0].ToString() == "C")
                {
                    txtCelular.Text = contactos.Rows[i].ItemArray[1].ToString() + " ";
                }
                else if (contactos.Rows[i].ItemArray[0].ToString() == "T")
                {
                    txtTelefono.Text = contactos.Rows[i].ItemArray[1].ToString() + " ";
                }
                else if (contactos.Rows[i].ItemArray[0].ToString() == "M" || contactos.Rows[i].ItemArray[0].ToString() == "E")
                {
                    txtEmail.Text = contactos.Rows[i].ItemArray[1].ToString() + " ";
                }
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores_CI.aspx?error=" + ex.Message.ToString() + "&pagina anterior=" + HttpContext.Current.Request.Url.LocalPath);
        }
    }
    protected void BtnAdelante_Click1(object sender, EventArgs e)
    {
        try
        {
            if (posicion < vector.Length - 1)
            {
                posicion = posicion + 1;
                MostrarDetalles(posicion, principal,  contactos);
            }
        }
        catch (OdbcException ex)
        {
            Response.Redirect("Errores_CI.aspx?error=" + ex.Message.ToString() + "&pagina anterior=" + HttpContext.Current.Request.Url.LocalPath);
        }
    }
    protected void btnUltimo_Click(object sender, EventArgs e)
    {
        try
        {
                posicion = vector.Length-1;
                MostrarDetalles(posicion, principal, contactos);
        }
        catch (OdbcException ex)
        {
            Response.Redirect("Errores_CI.aspx?error=" + ex.Message.ToString() + "&pagina anterior=" + HttpContext.Current.Request.Url.LocalPath);
        }
    }
    protected void btnPrimero_Click(object sender, EventArgs e)
    {
        try
        {
            posicion = 0;
            MostrarDetalles(posicion, principal,  contactos);
        }
        catch (OdbcException ex)
        {
            Response.Redirect("Errores_CI.aspx?error=" + ex.Message.ToString() + "&pagina anterior=" + HttpContext.Current.Request.Url.LocalPath);
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {

            Session.Remove("VectorExpedientes");
            Response.Redirect("ConsultasPorInformantes.aspx");
        }
        catch (OdbcException ex)
        {
            Response.Redirect("Errores_CI.aspx?error=" + ex.Message.ToString() + "&pagina anterior=" + HttpContext.Current.Request.Url.LocalPath);
        }
    }
}
