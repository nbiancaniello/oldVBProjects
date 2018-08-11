using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Fin
    {

        private byte _idFin;
        private string _descFin;
        private bool _estado;

        // Agregado Nico
        public Fin() 
        {
            _idFin = 0;
            _descFin = "";
            _estado = true;
        }
        //

        public byte idFin
        {
            set { this._idFin = value; }
            get { return this._idFin; }
        }

        public string descFin
        {
            set { this._descFin = value; }
            get { return this._descFin; }
        }

        public bool estado
        {
            set { this._estado = value; }
            get { return this._estado; }
        }


    }
}
