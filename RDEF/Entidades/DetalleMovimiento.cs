using System;
using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class DetalleMovimiento : Movimiento 
    {
        private string _nombreArchivo;
        private short _numeroResolucion;
        private byte _idDependencia;

        public DetalleMovimiento() 
        {
            _nombreArchivo = "";
            _numeroResolucion = 0;
            _idDependencia = 0;
        }

        public DetalleMovimiento(int pIdExpediente, byte pIdMovimiento)
        {
            idExpediente = pIdExpediente;
            idMovimiento = pIdMovimiento;
            _nombreArchivo = "";
            _numeroResolucion = 0;
            _idDependencia = 0;
        }

        public String nombreArchivo
        {
            set { this._nombreArchivo = value; }
            get { return this._nombreArchivo; }
        }

        public short numeroResolucion
        {
            set { this._numeroResolucion  = value; }
            get { return this._numeroResolucion ; }
        }

        public byte idDependencia
        {
            set { this._idDependencia = value; }
            get { return this._idDependencia; }
        }
    }
}
