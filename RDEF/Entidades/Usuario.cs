using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Usuario
    {
        private string _usuario;
        private string _clave;
        private string _nombreCuenta;
        private bool _estado;

        public string usuario
        {
            set { this._usuario = value; }
            get { return this._usuario; }
        }

        public string clave
        {
            set { this._clave = value; }
            get { return this._clave; }
        }

        public string nombreCuenta
        {
            set { this._nombreCuenta = value; }
            get { return this._nombreCuenta; }
        }

        public bool estado
        {
            set { this._estado = value; }
            get { return this._estado; }
        }

    }
}
