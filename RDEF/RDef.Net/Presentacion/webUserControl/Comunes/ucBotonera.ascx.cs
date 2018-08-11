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

public partial class ucBotonera : System.Web.UI.UserControl
{
    //delegado para poder generar el evento
    public delegate void delegadoGenerico();

    //eventos para ejecutar desde otro wform
    public event delegadoGenerico eventoAceptar;
    public event delegadoGenerico eventoModificar;
    public event delegadoGenerico eventoEliminar;


    //llamadas a cada evento en particular
    protected void btnAgregar_Click(object sender, EventArgs e)
    {
        eventoAceptar.Invoke();
    }
    protected void btnModificar_Click(object sender, EventArgs e)
    {
        eventoModificar.Invoke();
    }
    protected void btnEliminar_Click(object sender, EventArgs e)
    {
        eventoEliminar.Invoke();
        

    }
}
