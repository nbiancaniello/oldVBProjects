using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data.Odbc;
using Negocio;

namespace Negocio
{
    public class NegocioDetalleMovimiento
    {
        public static List<DetalleMovimiento> Listar(Int32 expediente)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());

            OdbcParameter parametro = new OdbcParameter();
            parametro.ParameterName = "idexp";
            parametro.Value = expediente;
            parametro.OdbcType = OdbcType.Int;
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter("Call SP_TraerDetalleMovimientosPorExpediente(?)", conexion);
            dataAdapter.SelectCommand.Parameters.Add(parametro);
            conexion.Open();

            List<DetalleMovimiento> listaDetalleMovimientos = new List<DetalleMovimiento>();
            try
            {
                OdbcDataReader drDetalleMovimientos = dataAdapter.SelectCommand.ExecuteReader();
                while (drDetalleMovimientos.Read())
                {
                    DetalleMovimiento tmp = new DetalleMovimiento();
                    tmp.idExpediente = drDetalleMovimientos.GetInt32(0);
                    tmp.idMovimiento = drDetalleMovimientos.GetByte(1);
                    tmp.nombreArchivo = drDetalleMovimientos.GetString(2);
                    tmp.numeroResolucion = drDetalleMovimientos.GetInt16(3);
                    tmp.idDependencia = drDetalleMovimientos.GetByte(4);
                    listaDetalleMovimientos.Add(tmp);
                }
                return listaDetalleMovimientos;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }

        //public static Movimiento Traer(Int32 movimiento)
        //{
        //    OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
        //    OdbcDataAdapter dataAdapter = new OdbcDataAdapter("", conexion);
        //    dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

        //    OdbcParameter parametro = new OdbcParameter();
        //    parametro.Direction = ParameterDirection.Input;

        //    dataAdapter.SelectCommand.CommandText = "call SP_TraerMovimiento(?)";
        //    parametro.ParameterName = "pMovimiento";
        //    parametro.Value = movimiento;
        //    parametro.OdbcType = OdbcType.VarChar;
        //    parametro.Size = 50;
        //    dataAdapter.SelectCommand.Parameters.Add(parametro);

        //    Movimiento Movimiento = new Movimiento();
        //    try
        //    {
        //        conexion.Open();
        //        OdbcDataReader drMovimientos = dataAdapter.SelectCommand.ExecuteReader();

        //        Movimiento tmp = new Movimiento();
        //        while (drMovimientos.Read())
        //        {
        //            tmp.idExpediente = drMovimientos.GetInt32(0);
        //            tmp.idMovimiento = drMovimientos.GetByte(1);
        //            tmp.idTipoMovimiento = drMovimientos.GetByte(2);
        //            tmp.fechaMovimiento = drMovimientos.GetDateTime(3);
        //            tmp.fechaArchivo = drMovimientos.GetDateTime(4);
        //            tmp.idPersona = drMovimientos.GetByte(5);
        //            tmp.comentario = drMovimientos.GetString(6);
        //            tmp.realizado = drMovimientos.GetByte(7);
        //            tmp.nombreArchivo = drMovimientos.GetString(8);
        //            tmp.numeroResolucion = drMovimientos.GetInt16(9);
        //            tmp.idDependencia = drMovimientos.GetByte(10);
        //            tmp.idFin = drMovimientos.GetByte(11);
        //            // listaMovimientos.Add(tmp);


        //        }
        //        return tmp;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (conexion.State == ConnectionState.Open)
        //            conexion.Close();
        //        //listaExpediente.Clear();
        //    }
        //}

        //public static List<Movimiento> TraerDataset(Int32 expediente)
        //{
        //    OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
        //    OdbcDataAdapter dataAdapter = new OdbcDataAdapter("call SP_TraerMovimientosPorExpediente(?)", conexion);
        //    OdbcParameter parametro = new OdbcParameter();

        //    parametro.ParameterName = "pExpediente";
        //    parametro.Value = expediente;
        //    parametro.OdbcType = OdbcType.Int;
        //    dataAdapter.SelectCommand.Parameters.Add(parametro);

        //    conexion.Open();
        //    List<Movimiento> listaMovimientos = new List<Movimiento>();
        //    try
        //    {

        //        OdbcDataReader drMovimientos = dataAdapter.SelectCommand.ExecuteReader();
        //        while (drMovimientos.Read())
        //        {
        //            Movimiento tmp = new Movimiento();
        //            tmp.idExpediente = drMovimientos.GetInt32(0);
        //            tmp.idMovimiento = drMovimientos.GetByte(1);
        //            tmp.idTipoMovimiento = drMovimientos.GetByte(2);
        //            tmp.fechaMovimiento = drMovimientos.GetDateTime(3);
        //            tmp.fechaArchivo = drMovimientos.GetDateTime(4);
        //            tmp.idPersona = drMovimientos.GetByte(5);
        //            tmp.comentario = drMovimientos.GetString(6);
        //            tmp.realizado = drMovimientos.GetByte(7);
        //            tmp.nombreArchivo = drMovimientos.GetString(8);
        //            tmp.numeroResolucion = drMovimientos.GetInt16(9);
        //            tmp.idDependencia = drMovimientos.GetByte(10);
        //            tmp.idFin = drMovimientos.GetByte(11);
        //            listaMovimientos.Add(tmp);
        //        }
        //        return listaMovimientos;
        //    }
        //    catch
        //    {
        //        throw;
        //    }
        //    finally
        //    {
        //        if (conexion.State == ConnectionState.Open)
        //            conexion.Close();
        //        listaMovimientos.Clear();
        //    }
        //}

        public static void Agregar(DetalleMovimiento detalleMovimiento)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcParameter parametro = new OdbcParameter();
            OdbcTransaction transaccion;
            OdbcCommand comando = new OdbcCommand("call SP_InsertarDetalleMovimientos(?,?,?,?,?)", conexion);
            try
            {
                comando.Parameters.AddWithValue("_idExpediente", detalleMovimiento.idExpediente);
                comando.Parameters.AddWithValue("_idMovimiento", detalleMovimiento.idMovimiento);
                comando.Parameters.AddWithValue("_nombreArchivo", detalleMovimiento.nombreArchivo);
                comando.Parameters.AddWithValue("_numeroResolucion", detalleMovimiento.numeroResolucion);
                comando.Parameters.AddWithValue("_idDependencia", detalleMovimiento.idDependencia);

                comando.Connection = conexion;
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                comando.Transaction = transaccion;
                comando.ExecuteNonQuery();
                transaccion.Commit();
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open) 
                {   
                    conexion.Close();
                }
                    
            }
        }

        public static void Modificar(DetalleMovimiento detalleMovimiento)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcParameter parametro = new OdbcParameter();
            OdbcTransaction transaccion;
            OdbcCommand comando = new OdbcCommand("call SP_ModificarDetalleMovimientos(?,?,?,?,?)", conexion);
            try
            {
                comando.Parameters.AddWithValue("_idExpediente", detalleMovimiento.idExpediente);
                comando.Parameters.AddWithValue("_idMovimiento", detalleMovimiento.idMovimiento);
                comando.Parameters.AddWithValue("_nombreArchivo", detalleMovimiento.nombreArchivo);
                comando.Parameters.AddWithValue("_numeroResolucion", detalleMovimiento.numeroResolucion);
                comando.Parameters.AddWithValue("_idDependencia", detalleMovimiento.idDependencia);

                comando.Connection = conexion;
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                comando.Transaction = transaccion;
                comando.ExecuteNonQuery();
                transaccion.Commit();
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void Eliminar(DetalleMovimiento detalleMovimiento)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcParameter parametro = new OdbcParameter();
            OdbcTransaction transaccion;
            OdbcCommand comando = new OdbcCommand("call SP_BorrarDetalleMovimiento(?,?)", conexion);
            try
            {
                comando.Parameters.AddWithValue("_idExpediente", detalleMovimiento.idExpediente);
                comando.Parameters.AddWithValue("_idMovimiento", detalleMovimiento.idMovimiento);
                comando.Connection = conexion;
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                comando.Transaction = transaccion;
                comando.ExecuteNonQuery();
                transaccion.Commit();
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            }
        }
        public static void ModificarArchivo(int idExpediente, int idMovimiento, int nombreArchivo)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcParameter parametro = new OdbcParameter();
            OdbcCommand comando = new OdbcCommand();
            try
            {
                comando.Connection = conexion;
                conexion.Open();
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "call SP_ModificarArchivo(?,?,?)";
                comando.Parameters.AddWithValue("_idExpediente", idExpediente);
                comando.Parameters.AddWithValue("_idMovimiento", idMovimiento);
                comando.Parameters.AddWithValue("_nombreArchivo", nombreArchivo);
                comando.ExecuteNonQuery();
                conexion.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
