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

public partial class webUserControl_ucFechaDdFechaHh : System.Web.UI.UserControl
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    /// <summary>
    /// Establece la fecha mostrada/seleccionada en el control FechaDesde
    /// </summary>
    /// <param name="datetime"></param>
    public void SelectedDateFechaDesde(DateTime datetime)
    {
        //this.calendarDesde.SelectedDate = datetime;
        ////this.calendarDesde.VisibleDate = datetime;
        ////this.calendarDesde.PostedDate = datetime.ToShortDateString();
    }

    /// <summary>
    /// Obtiene la fecha mostrada/seleccionada en el control FechaDesde
    /// </summary>
    /// <param name="datetime"></param>
    public DateTime SelectedDateFechaDesde()
    {
        return this.calendarDesde.SelectedDate;
    }

    /// <summary>
    /// Establece la fecha mostrada/seleccionada en el control FechaHasta
    /// </summary>
    /// <param name="datetime"></param>
    public void SelectedDateFechaHasta(DateTime datetime)
    {
        //this.calendarHasta.SelectedDate = datetime;
        ////this.calendarHasta.VisibleDate = datetime;
        ////this.calendarHasta.PostedDate = datetime.ToShortDateString();
    }

    /// <summary>
    /// Obtiene la fecha mostrada/seleccionada en el control FechaHasta
    /// </summary>
    /// <param name="datetime"></param>
    public DateTime SelectedDateFechaHasta()
    {
        return this.calendarHasta.SelectedDate;
    }



}
