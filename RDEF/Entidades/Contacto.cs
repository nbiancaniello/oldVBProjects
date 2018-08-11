using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Contacto
    {
        private int _idDenunciante;
        private string _tipoContacto;
        private string  _contacto;
        private bool _activo;

        public bool activo
        {
            get { return _activo; }
            set { _activo = value; }
        }

        public int idDenunciante
        {
            set { this._idDenunciante = value; }
            get { return this._idDenunciante; }
        }

        public string tipoContacto
        {
            set { this._tipoContacto = value; }
            get { return this._tipoContacto; }
        }

        public string contacto
        {
            set { this._contacto = value; }
            get { return this._contacto; }
        }
    }
}
