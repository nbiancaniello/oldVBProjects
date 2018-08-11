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

public partial class DetalleDenuncia : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        try
        {
            int idExpediente = Convert.ToInt32(Request.QueryString.Get("idExpediente"));

            Entidades.Expediente expediente = new Entidades.Expediente();

            expediente = Negocio.NegocioExpedientes.TraerExpedienteCompletoPorIdExpediente(idExpediente);

            cargarDatos(expediente);


        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    private void cargarDatos(Entidades.Expediente expediente)
    {
        try
        {
            this.txtNroExpediente.Text = expediente.idExpediente.ToString();
            this.txtIngreso.Text = expediente.fechaIngreso.ToShortDateString();
            
            if (expediente.fechaArchivo != DateTime.MinValue)
                this.txtArchivo.Text = expediente.fechaArchivo.ToShortDateString();

            this.txtApellido.Text = expediente.denunciante.apellido;
            this.txtNombre.Text = expediente.denunciante.nombre;
            this.txtDomicilio.Text = expediente.denunciante.domicilio;

            Entidades.Localidad localidad = new Entidades.Localidad();
            localidad = Negocio.NegocioMantenimiento.TraerLocalidadPorId(expediente.denunciante.idLocalidad);

            this.txtLocalidad.Text = localidad.descLocalidad;
            this.txtCP.Text = localidad.codigoPostal.ToString();
            this.txtNumero.Text = expediente.denunciante.numero.ToString();

            this.txtNroDocumento.Text = expediente.denunciante.nroDocumento.ToString();

            Entidades.TipoDocumento tipoDocumento = new Entidades.TipoDocumento();
            tipoDocumento = Negocio.NegocioMantenimiento.TraerTipoDocumentoPorId(expediente.denunciante.idTipoDocumento);
            this.txtTipoDocumento.Text = tipoDocumento.descTipoDocumento;

            this.gvwContactos.DataSource = Negocio.NegocioExpedientes.TraerContactosDenunciante(expediente.denunciante.idDenunciante);
            this.gvwContactos.DataBind();

            this.txtEnte.Text = expediente.denunciado.entidad;
            //this.txtTema.Text

            this.txtArea.Text = expediente.area.descArea;
            Entidades.TipoDenuncia tipoDenuncia = new Entidades.TipoDenuncia();
            tipoDenuncia = Negocio.NegocioMantenimiento.TraerTipoDenunciaPorId(expediente.idTipoDenuncia);
            this.txtTipoDenuncia.Text = tipoDenuncia.descTipoDenuncia;

            this.txtDenuncia.Text = expediente.descDenuncia;

            this.txtInformante.Text = expediente.informante.nombrePersona;

            //this.txtInicio.Text = ¿?

        }
        catch (Exception ex)
        {
            throw ex;
        }

    
    }

}
