using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class TipoMovimiento
    {
        private int _idTipoMovimiento;
        private string _descMovimiento;
        private bool _estado;

        public int idTipoMovimiento
        {
            set { this._idTipoMovimiento = value; }
            get { return this._idTipoMovimiento; }
        }

        public string descMovimiento
        {
            set { this._descMovimiento = value; }
            get { return this._descMovimiento; }
        }

        public bool estado
        {
            set { this._estado = value; }
            get { return this._estado; }
        }          
    }
}
