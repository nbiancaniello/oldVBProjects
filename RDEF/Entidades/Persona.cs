using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Persona
    {
        private int _idPersona;
        private string _nombrePersona;
        private bool  _estado;

        //Agregado Nico
        public Persona() 
        {
            _idPersona = 0;
            _nombrePersona = "";
            _estado = true;
        }
        //

        public int idPersona
        {
            set { this._idPersona = value; }
            get { return this._idPersona; }
        }

        public string nombrePersona
        {
            set { this._nombrePersona = value; }
            get { return this._nombrePersona; }
        }

        public bool estado
        {
            set { this._estado = value; }
            get{ return this._estado;}
        }

    }
}
