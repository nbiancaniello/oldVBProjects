using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class TipoDenuncia
    {
        private int _idTipoDenuncia;
        private string _descTipoDenuncia;
        private bool _estado;

        public int idTipoDenuncia
        {
            set { this._idTipoDenuncia = value; }
            get { return this._idTipoDenuncia; }
        }

        //modificado Hugo
        //public string desTipoDocumento
        public string descTipoDenuncia
        {
            set { this._descTipoDenuncia = value; }
            get { return this._descTipoDenuncia; }
        }

        public bool estado
        {
            set { this._estado = value; }
            get { return this._estado; }
        }

    }
}
