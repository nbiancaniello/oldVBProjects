using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Area
    {
     
        private byte _idArea;
        private string _descArea;
        private bool _estado;

        public byte idArea
        {
            set { this._idArea = value; }
            get { return this._idArea; }
        }

        public string descArea
        {
            set { this._descArea = value; }
            get { return this._descArea; }
        }

        public bool estado
        {
            set { this._estado = value; }
            get{ return this._estado;   }
        }
    }
}
