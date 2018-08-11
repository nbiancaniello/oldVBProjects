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
using Negocio;

public partial class Presentacion_Contactos : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        this.btnAgregar.Attributes.Add("onClick", " return mostrarCampos('agregar');");
        this.btnCancelar.Attributes.Add("onClick", "return ocultarCampos();");
        this.btnModificar.Attributes.Add("onClick", "return mostrarCampos('modificar');");
        this.btnEliminar.Attributes.Add("onClick","return Confirmar();");

        try
        {
                if (Request.QueryString.Count != 0)
                {
                    int idDenunciante = int.Parse(Request.QueryString["idDenunciante"].ToString());
                    Session.Add("idDen", idDenunciante);

                }

                
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error="+ex.Message);
        }
    }


    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        if (this.grdContactos.SelectedIndex == -1)        
            MostrarMensaje("Debe seleccionar el contacto a eliminar");        
        else
        {
            string[] ids = Session["ids"].ToString().Split(';');

            NegocioContactos.EliminarContacto(int.Parse(ids[grdContactos.SelectedIndex]));
            int idDen = int.Parse(Session["idDen"].ToString());
            CargarGrilla(idDen, DropDownList1.SelectedValue);
            txtTel.Text = "";
            grdContactos.SelectedIndex = -1;
            this.btnAplicar.Enabled = false;
            this.btnAplicar.CssClass = "ButtonBlue11pxDisable";
        }

    }


    private void MostrarMensaje(string strMensaje)
    {
        try
        {
            string str = "<script type=\"text/javascript\">";
            str = str + "alert('" + strMensaje + "');";
            str = str + "</script>";
            Page.ClientScript.RegisterStartupScript(Page.ClientScript.GetType(), "mostrarMensaje", str);
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
            throw;
        }
    }

    protected void btnAceptar_Click(object sender, EventArgs e)
    {
        try
        {
            if (this.txtTel.Text == "")
                MostrarMensaje("Debe ingresar el contacto");
            else
            {
                int idDen = int.Parse(Session["idDen"].ToString());
                if (hAccion.Value == "agregar")
                {
                    NegocioContactos.AgregarContacto(DropDownList1.SelectedValue, this.txtTel.Text.Trim(), idDen);
                    CargarGrilla(idDen, DropDownList1.SelectedValue);

                    txtTel.Text = "";
                    txtTel.Enabled = false;
                    btnAceptar.Enabled = false;
                    btnAceptar.CssClass = "ButtonBlue11pxDisable";
                    btnCancelar.Enabled = false;
                    btnCancelar.CssClass = "ButtonBlue11pxDisable";

                }
                else//modificar
                {
                    string[] ids = Session["ids"].ToString().Split(';');
                    int index = grdContactos.SelectedIndex;                    
                    NegocioContactos.ModificarContacto(DropDownList1.SelectedValue,this.txtTel.Text.Trim(), int.Parse(ids[index].ToString()));
                    CargarGrilla(idDen,DropDownList1.SelectedValue);
                
                }

                txtTel.Text = "";
                txtTel.Enabled = false;
                btnAceptar.Enabled = false;
                btnAceptar.CssClass = "ButtonBlue11pxDisable";
                btnCancelar.Enabled = false;
                btnCancelar.CssClass = "ButtonBlue11pxDisable";
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }
    
    private void CargarGrilla(int idDen,string tipo)
    {
        try
        {
            string ids;

            switch(tipo)
            {
                case "T":
                    txtTel.CssClass = "TextBoxTelefono";
                    DataSet dsTelefonos = NegocioContactos.TraerTelefonosDenunciante(idDen);
                    ids="";
                    foreach (DataRow r in dsTelefonos.Tables[0].Rows)
                    {
                        ids = ids + r["ID"].ToString() +  ";";
                    }
                    Session.Add("ids",ids);
                    dsTelefonos.Tables[0].Columns.Remove("ID");

                    this.grdContactos.DataSource = dsTelefonos;
                    this.grdContactos.DataBind();
                    break;
                case "C":
                    txtTel.CssClass = "TextBoxTelefono";
                    DataSet dsCelulares = NegocioContactos.TraerCelularesDenunciante(idDen);
                    ids = "";
                    foreach (DataRow r in dsCelulares.Tables[0].Rows)
                    {
                        ids = ids + r["ID"].ToString() + ";";
                    }
                    Session.Add("ids", ids);
                    dsCelulares.Tables[0].Columns.Remove("ID");

                    this.grdContactos.DataSource = dsCelulares;
                    this.grdContactos.DataBind();
                    break;

                case "E":
                    txtTel.CssClass = "TextBox";
                    DataSet dsEmails = NegocioContactos.TraerEmailsDenunciante(idDen);
                    ids = "";
                    foreach (DataRow r in dsEmails.Tables[0].Rows)
                    {
                        ids = ids + r["ID"].ToString() + ";";
                    }
                    Session.Add("ids", ids);
                    dsEmails.Tables[0].Columns.Remove("ID");

                    this.grdContactos.DataSource = dsEmails;
                    this.grdContactos.DataBind();
                    break;
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }

    protected void btnVolver_Click(object sender, EventArgs e)
    {

        string retorno = "";
        //retorno = hActivo.Value + "/" + hTelAct.Value + "|" + hCelAct.Value + "|" + hMailAct.Value;

        //    string str = "<script type='text/javascript'>" +
        //        "window.returnValue = '" + retorno + "';window.close();</script>";


            string str = "<script type='text/javascript'> window.close();</script>";

        Page.ClientScript.RegisterStartupScript(Page.ClientScript.GetType(), "cerrarVentana", str);      

    }
    
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        try
        {

            txtTel.Text = "";
            btnAgregar.Enabled = true;
            btnModificar.Enabled = true;
            btnEliminar.Enabled = true;

            btnAgregar.CssClass = "ButtonBlue11px";
            btnModificar.CssClass = "ButtonBlue11px";
            btnEliminar.CssClass = "ButtonBlue11px";

            grdContactos.Visible = true;

            if (DropDownList1.SelectedValue == "0")
            {                
                btnAgregar.Enabled = false;
                btnModificar.Enabled = false;
                btnEliminar.Enabled = false;
                btnAplicar.Enabled = false;

                btnAgregar.CssClass = "ButtonBlue11pxDisable";
                btnModificar.CssClass = "ButtonBlue11pxDisable";
                btnEliminar.CssClass = "ButtonBlue11pxDisable";
                btnAplicar.CssClass = "ButtonBlue11pxDisable";

                grdContactos.Visible = false;

            }
            else
            {
                int idDen = int.Parse(Session["idDen"].ToString());
                CargarGrilla(idDen, DropDownList1.SelectedValue);
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error="+ex.Message);
        }
    }

    protected void grdContactos_RowDataBound(object sender, GridViewRowEventArgs e)
    {
        try
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes.Add("onclick", Page.ClientScript.GetPostBackClientHyperlink(grdContactos, "Select$" + e.Row.RowIndex.ToString()));
            }
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }
    protected void grdContactos_SelectedIndexChanged(object sender, EventArgs e)
    {
        try        
        {
            this.btnAplicar.Enabled = true;
            btnAplicar.CssClass = "ButtonBlue11px";
            this.txtTel.Text = this.grdContactos.SelectedRow.Cells[1].Text;
        }
        catch (Exception ex)
        {
            Response.Redirect("Errores.aspx?error=" + ex.Message);
        }
    }


    protected void btnAplicar_Click(object sender, EventArgs e)
    {
        try
        {
            if (grdContactos.SelectedIndex != -1)
            {

                int index = grdContactos.SelectedIndex;

                string[] ids = Session["ids"].ToString().Split(';');
                
                NegocioContactos.ActivarContacto(Session["idDen"].ToString(),int.Parse(ids[index].ToString()),DropDownList1.SelectedValue);

                switch (DropDownList1.SelectedValue)
                {
                    case "T":
                        hTelAct.Value = grdContactos.SelectedRow.Cells[1].Text;
                        break;
                    case "C":
                        hCelAct.Value = grdContactos.SelectedRow.Cells[1].Text;
                        break;
                    case "E":
                        hMailAct.Value = grdContactos.SelectedRow.Cells[1].Text;
                        break;
                }


                MostrarMensaje("El contacto ha sido activado para ser mostrado en la pantalla principal del expediente.");

                hActivo.Value = hTelAct.Value;

            }
            else
            {
                MostrarMensaje("Debe seleccionar un telefono, o presionar Volver para regresar sin cambios.");
            }

        }
        catch (Exception ex)
        {
            Response.Write(ex);
        }

    }

}
