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

public partial class Presentacion_Errores_CI : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString.Count > 0)
        {
            this.lblError.Text = this.lblError.Text + Request.QueryString["error"];
        }
    }
    protected void btnVolver_Click(object sender, EventArgs e)
    {
        Response.Redirect(Request.QueryString[1]);


    }
}
