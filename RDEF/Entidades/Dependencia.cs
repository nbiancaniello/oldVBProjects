using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Dependencia
    {

        private byte _idDependencia;
        private string _descDependencia;
        private bool  _estado;

        public byte idDependencia
        {
            set { this._idDependencia = value; }
            get { return this._idDependencia; }
        }

        public string descDependencia
        {
            set { this._descDependencia = value; }
            get { return this._descDependencia; }
        }

        public bool estado
        {
            set { this._estado = value; }
            get{ return this._estado;}
        }

        
            
            
    }
}
