using System;
using System.Collections.Generic;
using System.Text;

// IMPORTANTE: Se utilizará al atributo de la clase Movimiento 'idMovimiento' como
// atributo 'idMovimientoSolicitud'.

namespace Entidades
{
    public class ExpedienteMVL : Movimiento
    {
        private byte _idMovimientoRecepcion;
        private byte _idMovimientoDevolucion;
        private String _codigoExpedienteMVL;
        private String _numeroExpedienteMVL;
        private short _anioExpediente;

        public ExpedienteMVL()
        {
            this.idExpediente = 0;
            this.idMovimiento = 0;
            _idMovimientoRecepcion = 0;
            _idMovimientoDevolucion = 0;
            _codigoExpedienteMVL = "";
            _numeroExpedienteMVL = "";
            _anioExpediente = 0;
        }

        public byte idMovimientoRecepcion
        {
            set { this._idMovimientoRecepcion = value; }
            get { return this._idMovimientoRecepcion; }
        }

        public byte idMovimientoDevolucion
        {
            set { this._idMovimientoDevolucion = value; }
            get { return this._idMovimientoDevolucion; }
        }

        public String codigoExpedienteMVL
        {
            set { this._codigoExpedienteMVL = value; }
            get { return this._codigoExpedienteMVL; }
        }

        public String numeroExpedienteMVL
        {
            set { this._numeroExpedienteMVL = value; }
            get { return this._numeroExpedienteMVL; }
        }

        public short anioExpediente
        {
            set { this._anioExpediente = value; }
            get { return this._anioExpediente; }
        }
    }
}
