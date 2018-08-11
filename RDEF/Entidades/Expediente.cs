using System;
using System.Collections.Generic;
using System.Text;
using Entidades;

namespace Entidades
{
    public class Expediente
    {
      
        private int _idExpediente;
        private Denunciante _denunciante;
        private DateTime _fechaIngreso;
        private DateTime _fechaArchivo;
        private byte _traeDocumentacion;   
        private string _descDocumentacion;
        private string _descDenuncia;
        private Denunciado _denunciado;
        private Persona _informante;
        private Persona _atendio;
        private byte _idTipoDenuncia;
        private Area _area;
        private Fin _fin;
        private List<Movimiento> _movimientos;

        public Expediente()
        {
            this._idExpediente = 0;
            this._denunciante = new Denunciante();
            this._fechaIngreso = DateTime.Today;
            this._fechaArchivo = new DateTime();
            this._traeDocumentacion = 0;
            this._descDocumentacion = "";
            this._descDenuncia = "";
            this._denunciado = new Denunciado();
            this._informante = new Persona();
            this._atendio = new Persona();
            this._idTipoDenuncia = 0;
            this._area = new Area();
            this._fin = new Fin();
            this._movimientos = new List<Movimiento>();
        }


        public List<Movimiento> movimientos
        {
            set { this._movimientos = value; }
            get { return this._movimientos; }
        }

        public int idExpediente
        {
            set { this._idExpediente = value; }
            get { return this._idExpediente; }
        }

        public Denunciante denunciante
        {
            set { this._denunciante = value; }
            get { return this._denunciante; }
        }

        public DateTime fechaIngreso
        {
            set { this._fechaIngreso = value; }
            get { return this._fechaIngreso; }
        }

        public DateTime fechaArchivo
        {
            set { this._fechaArchivo = value; }
            get { return this._fechaArchivo; }
        }

        public byte traeDocumentacion
        {
            set { this._traeDocumentacion= value; }
            get { return this._traeDocumentacion; }
        }

        public string descDocumentacion
        {
            set { this._descDocumentacion = value; }
            get { return this._descDocumentacion; }
        }

        public string descDenuncia
        {
            set { this._descDenuncia = value; }
            get { return this._descDenuncia; }
        }

        public Denunciado denunciado
        {
            set { this._denunciado = value; }
            get { return this._denunciado; }
        }

        public Persona informante
        {
            set { this._informante = value; }
            get { return this._informante; }
        }

        public Persona atendio
        {
            set { this._atendio = value; }
            get { return this._atendio; }
        }

        public byte idTipoDenuncia
        {
            set { this._idTipoDenuncia = value; }
            get { return this._idTipoDenuncia; }
        }

        public Area area
        {
            set { this._area= value; }
            get { return this._area; }
        }

        public Fin fin
        {
            set { this._fin = value; }
            get { return this._fin; }
        }
       
       
       

    }


}
