using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Denunciado
    {

        private byte _idDenunciado;
        private string _entidad;
        private bool  _estado;

        public byte idDenunciado
        {
            set { this._idDenunciado = value; }
            get { return this._idDenunciado; }
        }

        public string entidad
        {
            set { this._entidad = value; }
            get { return this._entidad; }
        }

        public bool estado
        {
            set { this._estado = value; }
            get{ return this._estado;}
        }
    }
}
