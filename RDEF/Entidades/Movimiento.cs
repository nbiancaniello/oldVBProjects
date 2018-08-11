using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Movimiento
    {
        public  enum eAccion
        {
            Nuevo =1,
            Modificar=2,
            Eliminar=3,
            Ver=4
        }

        private int _idExpediente;
        private byte _idMovimiento;
        private byte _idTipoMovimiento;
        private DateTime _fechaMovimiento;
        private byte _idPersona;
        private string _comentario;
        private byte _realizado;
        private eAccion _accion;

        public Movimiento() 
        {
            _idExpediente = 0;
            _idMovimiento = 0;
            _idTipoMovimiento = 0;
            _fechaMovimiento = DateTime .MinValue;
            _idPersona = 0;
            _comentario = "";
            _realizado = 0;
        }

        public eAccion accion
        {
            set { this._accion = value; }
            get { return this._accion; }
        }

        public int idExpediente
        {
            set { this._idExpediente = value; }
            get { return this._idExpediente; }
        }

        public byte idMovimiento
        {
            set { this._idMovimiento = value; }
            get { return this._idMovimiento; }
        }

        public byte idTipoMovimiento
        {
            set { this._idTipoMovimiento = value; }
            get { return this._idTipoMovimiento; }
        }

        public DateTime fechaMovimiento
        {
            set { this._fechaMovimiento = value; }
            get { return this._fechaMovimiento; }
        }

        public byte idPersona
        {
            set { this._idPersona = value; }
            get { return this._idPersona; }
        }

        public string comentario
        {
            set { this._comentario = value; }
            get { return this._comentario; }
        }

        public byte realizado
        {
            set { this._realizado = value; }
            get { return this._realizado; }
        }
    }
}
