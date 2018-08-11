using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Localidad
    {

        private int _idLocalidad;
        private int _codigoPostal;
        private string _descLocalidad;
        private byte _idPartido;

        public int idLocalidad
        {
            set { this._idLocalidad = value; }
            get { return this._idLocalidad; } 
        }
        public int codigoPostal
        {
            set { this._codigoPostal = value; }
            get { return this._codigoPostal; }
        }

        public string descLocalidad
        {
            set { this._descLocalidad = value; }
            get { return this._descLocalidad; }
        }

        public byte idPartido
        {
            set { this._idPartido = value; }
            get { return this._idPartido; }
        }

    }
}
