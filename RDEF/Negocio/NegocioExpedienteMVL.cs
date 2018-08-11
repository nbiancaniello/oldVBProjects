using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data.Odbc;
using Negocio;

// IMPORTANTE: Se utilizará al atributo de la clase Movimiento 'idMovimiento' como
// atributo 'idMovimientoSolicitud'.

namespace Negocio
{
    public class NegocioExpedienteMVL
    {
        public static List<ExpedienteMVL> Listar(Int32 expediente)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());

            OdbcParameter parametro = new OdbcParameter();
            parametro.ParameterName = "_idExpediente";
            parametro.Value = expediente;
            parametro.OdbcType = OdbcType.Int;
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter("Call SP_TraerExpedientesMVL(?)", conexion);
            dataAdapter.SelectCommand.Parameters.Add(parametro);
            conexion.Open();

            List<ExpedienteMVL> listaExpedienteMVL = new List<ExpedienteMVL>();
            try
            {
                OdbcDataReader drExpedienteMVL = dataAdapter.SelectCommand.ExecuteReader();
                while (drExpedienteMVL.Read())
                {
                    ExpedienteMVL tmp = new ExpedienteMVL();
                    tmp.idExpediente = drExpedienteMVL.GetInt32(0);
                    tmp.idMovimiento = drExpedienteMVL.GetByte(1);
                    tmp.idMovimientoRecepcion = drExpedienteMVL.GetByte(2);
                    tmp.idMovimientoDevolucion = drExpedienteMVL.GetByte(3);
                    tmp.codigoExpedienteMVL = drExpedienteMVL.GetString(4);
                    tmp.numeroExpedienteMVL = drExpedienteMVL.GetString(5);
                    tmp.anioExpediente = drExpedienteMVL.GetInt16(6);
                    listaExpedienteMVL.Add(tmp);
                }
                return listaExpedienteMVL;
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

        public static DataSet traerExpedientesMVL(Int32 idExpediente)
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            DataSet dsExpedientesMVL = new DataSet();
            try
            {
                OdbcParameter parametro = new OdbcParameter();
                parametro.ParameterName = "_idExpediente";
                parametro.Value = idExpediente;
                parametro.OdbcType = OdbcType.Int;
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerExpedientesMVL2(?)", cn);
                da.SelectCommand.Parameters.Add(parametro);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dsExpedientesMVL);
                return dsExpedientesMVL;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }
        }

        public static void Agregar(ExpedienteMVL expedienteMVL)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcParameter parametro = new OdbcParameter();
            OdbcTransaction transaccion;
            OdbcCommand comando = new OdbcCommand("call SP_InsertarExpedienteMVL(?,?,?,?,?,?,?)", conexion);
            try
            {
                comando.Parameters.AddWithValue("_idExpediente", expedienteMVL.idExpediente);
                comando.Parameters.AddWithValue("_idMovimientoSolicitud", expedienteMVL.idMovimiento);
                comando.Parameters.AddWithValue("_idMovimientoRecepcion", expedienteMVL.idMovimientoRecepcion);
                comando.Parameters.AddWithValue("_idMovimientoDevolucion", expedienteMVL.idMovimientoDevolucion);
                comando.Parameters.AddWithValue("_codigoExpedienteMVL", expedienteMVL.codigoExpedienteMVL);
                comando.Parameters.AddWithValue("_numeroExpedienteMVL", expedienteMVL.numeroExpedienteMVL );
                comando.Parameters.AddWithValue("_anioExpediente", expedienteMVL.anioExpediente);
                
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

        public static void Modificar(ExpedienteMVL expedienteMVL)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcParameter parametro = new OdbcParameter();
            OdbcTransaction transaccion;
            OdbcCommand comando = new OdbcCommand("call SP_ModificarExpedienteMVL(?,?,?,?,?,?,?)", conexion);
            try
            {
                comando.Parameters.AddWithValue("_idExpediente", expedienteMVL.idExpediente);
                comando.Parameters.AddWithValue("_idMovimientoSolicitud", expedienteMVL.idMovimiento);
                comando.Parameters.AddWithValue("_idMovimientoRecepcion", expedienteMVL.idMovimientoRecepcion);
                comando.Parameters.AddWithValue("_idMovimientoDevolucion", expedienteMVL.idMovimientoDevolucion);
                comando.Parameters.AddWithValue("_codigoExpedienteMVL", expedienteMVL.codigoExpedienteMVL);
                comando.Parameters.AddWithValue("_numeroExpedienteMVL", expedienteMVL.numeroExpedienteMVL);
                comando.Parameters.AddWithValue("_anioExpediente", expedienteMVL.anioExpediente);

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

        public static void Eliminar(ExpedienteMVL expedienteMVL)
        {
            try
            {
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
