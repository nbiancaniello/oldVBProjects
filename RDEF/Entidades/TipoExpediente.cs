using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class TipoExpediente
    {
        private byte _idTipoExpediente;
        private String _descTipoExpediente;
        private Boolean _estado;

        public byte idTipoExpediente
        {
            set { this._idTipoExpediente = value; }
            get { return this._idTipoExpediente; }
        }

        public String descTipoExpediente
        {
            set { this._descTipoExpediente = value; }
            get { return this._descTipoExpediente; }
        }

        public Boolean estado
        {
            set { this._estado = value; }
            get { return this._estado; }
        }
    }
}
