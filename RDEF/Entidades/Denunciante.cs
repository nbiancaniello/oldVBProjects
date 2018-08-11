using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Denunciante
    {
        private int _idDenunciante;
        private string _nombre;
        private string _apellido;
        private string _domicilio; 
        private int _numero;
        private byte _piso;
        private string _dpto;
        private int _idLocalidad;
        private byte _idTipoDocumento;
        private int _nroDocumento;
        //private List<Contacto> _contactos;

        //public Denunciante()
        //{
        //    this._contactos = new List<Contacto>();
        //}

        //public List<Contacto> contactos
        //{
        //    set { this._contactos = value; }
        //    get { return this._contactos; }
        //}

        public int idDenunciante
        {
            set { this._idDenunciante = value; }
            get { return this._idDenunciante; }
        }

         public string nombre
        {
            set { this._nombre = value; }
            get { return this._nombre; }
        }

        public string apellido
        {
            set { this._apellido = value; }
            get { return this._apellido; }
        }
        
          public string domicilio
        {
            set { this._domicilio = value; }
            get { return this._domicilio; }
        }
        public int numero
        {
            set { this._numero= value; }
            get { return this._numero; }
        }
        public byte piso
        {
            set { this._piso= value; }
            get { return this._piso; }
        }

        public string dpto
        {
            set { this._dpto= value; }
            get { return this._dpto; }
        }

        public int idLocalidad
        {
            set { this._idLocalidad= value; }
            get { return this._idLocalidad  ; }
        }

        public byte idTipoDocumento
        {
            set { this._idTipoDocumento= value; }
            get { return this._idTipoDocumento  ; }
        }

        public int nroDocumento
        {
            set { this._nroDocumento= value; }
            get { return this._nroDocumento; }
        }
    
    
    }
}
