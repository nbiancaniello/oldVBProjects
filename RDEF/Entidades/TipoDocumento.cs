using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class TipoDocumento
    {
        private int _idTipoDocumento;
        private string _descTipoDocumento;

        public int idTipoDocumento
        {
            set { this._idTipoDocumento = value; }
            get { return this._idTipoDocumento; }
        }
        //Modificado Hugo
        //public string desTipoDocumento
        public string descTipoDocumento
        {
            set { this._descTipoDocumento = value; }
            get { return this._descTipoDocumento; }
        }

    }
}
