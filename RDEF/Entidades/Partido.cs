using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Partido
    {
        private int _idPartido;
        private string _descPartido;

        public int idPartido
        {
            set { this._idPartido = value; }
            get { return this._idPartido; }
        }

        public string desPartido
        {
            set { this._descPartido = value; }
            get { return this._descPartido; }
        }

    }
}
