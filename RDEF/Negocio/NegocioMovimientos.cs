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
    public class NegocioMovimientos
    {
        public static List<Movimiento> Listar(Int32 expediente)
    {
        OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
        
        OdbcParameter parametro = new OdbcParameter();
        parametro.ParameterName = "idexp";
        parametro.Value = expediente;
        parametro.OdbcType = OdbcType.Int;
        OdbcDataAdapter dataAdapter = new OdbcDataAdapter("Call SP_TraerMovimientosPorExpediente(?)", conexion);
        dataAdapter.SelectCommand.Parameters.Add(parametro);        
        conexion.Open();
       
        List<Movimiento> listaMovimientos = new List<Movimiento>();
        try
        {            
            OdbcDataReader drMovimientos = dataAdapter.SelectCommand.ExecuteReader();
            while (drMovimientos.Read()){
                Movimiento tmp = new Movimiento();
                tmp.idExpediente = drMovimientos.GetInt32(0);
                tmp.idMovimiento = drMovimientos.GetByte(1);
                tmp.idTipoMovimiento = drMovimientos.GetByte(2);
                tmp.fechaMovimiento = drMovimientos.GetDateTime(3);
                tmp.idPersona = drMovimientos.GetByte(4);
                tmp.comentario = drMovimientos.GetString(5);
                tmp.realizado = drMovimientos.GetByte(6);
                listaMovimientos.Add(tmp);
            }
            return listaMovimientos;
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

        public static Movimiento Traer(Int32 movimiento)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter("", conexion);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            OdbcParameter parametro = new OdbcParameter();
            parametro.Direction = ParameterDirection.Input;

            dataAdapter.SelectCommand.CommandText = "call SP_TraerMovimiento(?)";
            parametro.ParameterName = "pMovimiento";
            parametro.Value = movimiento;
            parametro.OdbcType = OdbcType.VarChar;
            parametro.Size = 50;
            dataAdapter.SelectCommand.Parameters.Add(parametro);

            Movimiento Movimiento = new Movimiento();
            try
            {
                conexion.Open();
                OdbcDataReader drMovimientos = dataAdapter.SelectCommand.ExecuteReader();

                Movimiento tmp = new Movimiento();
                while (drMovimientos.Read())
                {
                    tmp.idExpediente = drMovimientos.GetInt32(0);
                    tmp.idMovimiento = drMovimientos.GetByte(1);
                    tmp.idTipoMovimiento = drMovimientos.GetByte(2);
                    tmp.fechaMovimiento = drMovimientos.GetDateTime(3);
                    tmp.idPersona = drMovimientos.GetByte(4);
                    tmp.comentario = drMovimientos.GetString(5);
                    tmp.realizado = drMovimientos.GetByte(6);
                }
                return tmp;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (conexion.State == ConnectionState.Open)
                    conexion.Close();
            //listaExpediente.Clear();
            }
        }

        public static DataSet TraerDataset(Int32 expediente)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcParameter parametro = new OdbcParameter();
            //OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerMovimientosPorExpediente(?)", conexion);            
            OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerMovimientosPorExpedientePersonalizados(?)", conexion);            
            DataSet drMovimientos = new DataSet();
            parametro.ParameterName = "pExpediente";
            parametro.Value = expediente;
            parametro.OdbcType = OdbcType.Int;
            da.SelectCommand.Parameters.Add(parametro);
            conexion.Open();
            try
            {
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.Fill(drMovimientos);
            return drMovimientos;
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
        
        public static OdbcDataReader TraerDataset2(Int32 expediente)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter("call SP_TraerMovimientosPorExpediente(?)", conexion);
            OdbcParameter parametro = new OdbcParameter();

            parametro.ParameterName = "pExpediente";
            parametro.Value = expediente;
            parametro.OdbcType = OdbcType.Int;
            dataAdapter.SelectCommand.Parameters.Add(parametro);
            conexion.Open();
            try{
                OdbcDataReader drMovimientos = dataAdapter.SelectCommand.ExecuteReader();
                return drMovimientos;
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

        public static void Agregar(Movimiento movimiento, DetalleMovimiento detalleMovimiento, ExpedienteMVL expedienteMVL, Expediente expediente)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcParameter parametro = new OdbcParameter();
            OdbcTransaction transaccion;
            OdbcCommand comando = new OdbcCommand();
			try
			{
                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "call SP_InsertarMovimientos(?,?,?,?,?,?,?)";
                comando.Parameters.AddWithValue("_idExpediente", movimiento.idExpediente);
                comando.Parameters.AddWithValue("_idMovimiento", movimiento.idMovimiento);
                comando.Parameters.AddWithValue("_idTipoMovimiento", movimiento.idTipoMovimiento);
                comando.Parameters.AddWithValue("_fechaMovimiento", movimiento.fechaMovimiento);
                comando.Parameters.AddWithValue("_idPersona", movimiento.idPersona);
                comando.Parameters.AddWithValue("_comentario", movimiento.comentario);
                comando.Parameters.AddWithValue("_realizado", movimiento.realizado);

                conexion.Open();
                transaccion = conexion.BeginTransaction();
                comando.Transaction = transaccion;
                comando.ExecuteNonQuery();

                if (detalleMovimiento.idExpediente != 0) 
                {                    
                    comando.Parameters.Clear();
                    comando.CommandText = "call SP_InsertarDetalleMovimientos(?,?,?,?,?)";
                    comando.Parameters.AddWithValue("_idExpediente", detalleMovimiento.idExpediente);
                    comando.Parameters.AddWithValue("_idMovimiento", detalleMovimiento.idMovimiento);
                    comando.Parameters.AddWithValue("_nombreArchivo", detalleMovimiento.nombreArchivo);
                    comando.Parameters.AddWithValue("_numeroResolucion", detalleMovimiento.numeroResolucion);
                    comando.Parameters.AddWithValue("_idDependencia", detalleMovimiento.idDependencia);
                    comando.ExecuteNonQuery();
                }

                if (expedienteMVL.idExpediente != 0) 
                {
                    comando.Parameters.Clear();
                    comando.CommandText = "call SP_BorrarExpedienteMVL(?,?)";
                    comando.Parameters.AddWithValue("_idExpediente", expedienteMVL.idExpediente);
                    comando.Parameters.AddWithValue("_idMovimientoSolicitud", expedienteMVL.idMovimiento);
                    comando.ExecuteNonQuery();

                    comando.Parameters.Clear();
                    comando.CommandText = "call SP_InsertarExpedienteMVL(?,?,?,?,?,?,?)";
                    comando.Parameters.AddWithValue("_idExpediente", expedienteMVL.idExpediente);
                    comando.Parameters.AddWithValue("_idMovimientoSolicitud", expedienteMVL.idMovimiento);
                    comando.Parameters.AddWithValue("_idMovimientoRecepcion", expedienteMVL.idMovimientoRecepcion);
                    comando.Parameters.AddWithValue("_idMovimientoDevolucion", expedienteMVL.idMovimientoDevolucion);
                    comando.Parameters.AddWithValue("_codigoExpedienteMVL", expedienteMVL.codigoExpedienteMVL);
                    comando.Parameters.AddWithValue("_numeroExpedienteMVL", expedienteMVL.numeroExpedienteMVL);
                    comando.Parameters.AddWithValue("_anioExpediente", expedienteMVL.anioExpediente);
                    comando.ExecuteNonQuery();
                }

                //Agregado Nico

                if (expediente.informante.idPersona != 0)
                {
                    comando.Parameters.Clear();
                    comando.CommandText = "call SP_actualizarInformante(?,?)";
                    comando.Parameters.AddWithValue("_idExpediente", expediente.idExpediente);
                    comando.Parameters.AddWithValue("_idInformante", expediente.informante.idPersona);
                    comando.ExecuteNonQuery();
                }

                if (expediente.fin.idFin != 0 && expediente.fechaArchivo.CompareTo(System.DateTime.MinValue) != 0)
                {
                    comando.Parameters.Clear();
                    comando.CommandText = "call SP_actualizarExpedienteArchivoFin(?,?,?)";
                    comando.Parameters.AddWithValue("_idExpediente", expediente.idExpediente);
                    comando.Parameters.AddWithValue("_idFin", expediente.fin.idFin);
                    comando.Parameters.AddWithValue("_fechaArchivo", expediente.fechaArchivo);
                    comando.ExecuteNonQuery();
                }
  
                //
                
                transaccion.Commit();
                conexion .Close();
			}
			catch(Exception ex)
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

        public static void Modificar(Movimiento movimiento, DetalleMovimiento detalleMovimiento, ExpedienteMVL expedienteMVL, Expediente expediente)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcParameter parametro = new OdbcParameter();
            OdbcTransaction transaccion;
            OdbcCommand comando = new OdbcCommand();
            try
            {
                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "call SP_BorrarDetalleMovimiento(?,?)";
                comando.Parameters.AddWithValue("_idExpediente", detalleMovimiento.idExpediente);
                comando.Parameters.AddWithValue("_idMovimiento", detalleMovimiento.idMovimiento);

                conexion.Open();
                transaccion = conexion.BeginTransaction();
                comando.Transaction = transaccion;
                comando.ExecuteNonQuery();

                comando.Parameters.Clear();
                comando.CommandText = "call SP_BorrarExpedienteMVL(?,?)";
                comando.Parameters.AddWithValue("_idExpediente", expedienteMVL.idExpediente);
                comando.Parameters.AddWithValue("_idMovimientoSolicitud", expedienteMVL.idMovimiento);
                comando.ExecuteNonQuery();

                comando.Parameters.Clear();
                comando.CommandText = "call SP_BorrarMovimiento(?,?)";
                comando.Parameters.AddWithValue("_idExpediente", movimiento.idExpediente);
                comando.Parameters.AddWithValue("_idMovimiento", movimiento.idMovimiento);
                comando.ExecuteNonQuery();

                comando.Parameters.Clear();
                comando.CommandText = "call SP_InsertarMovimientos(?,?,?,?,?,?,?)";
                comando.Parameters.AddWithValue("_idExpediente", movimiento.idExpediente);
                comando.Parameters.AddWithValue("_idMovimiento", movimiento.idMovimiento);
                comando.Parameters.AddWithValue("_idTipoMovimiento", movimiento.idTipoMovimiento);
                comando.Parameters.AddWithValue("_fechaMovimiento", movimiento.fechaMovimiento);
                comando.Parameters.AddWithValue("_idPersona", movimiento.idPersona);
                comando.Parameters.AddWithValue("_comentario", movimiento.comentario);
                comando.Parameters.AddWithValue("_realizado", movimiento.realizado);
                comando.ExecuteNonQuery();

                if (detalleMovimiento.idExpediente != 0)
                {                    
                    comando.Parameters.Clear();
                    comando.CommandText = "call SP_InsertarDetalleMovimientos(?,?,?,?,?)";
                    comando.Parameters.AddWithValue("_idExpediente", detalleMovimiento.idExpediente);
                    comando.Parameters.AddWithValue("_idMovimiento", detalleMovimiento.idMovimiento);
                    comando.Parameters.AddWithValue("_nombreArchivo", detalleMovimiento.nombreArchivo);
                    comando.Parameters.AddWithValue("_numeroResolucion", detalleMovimiento.numeroResolucion);
                    comando.Parameters.AddWithValue("_idDependencia", detalleMovimiento.idDependencia);
                    comando.ExecuteNonQuery();
                }

                if (expedienteMVL.idExpediente != 0)
                {
                    comando.Parameters.Clear();
                    comando.CommandText = "call SP_InsertarExpedienteMVL(?,?,?,?,?,?,?)";
                    comando.Parameters.AddWithValue("_idExpediente", expedienteMVL.idExpediente);
                    comando.Parameters.AddWithValue("_idMovimientoSolicitud", expedienteMVL.idMovimiento);
                    comando.Parameters.AddWithValue("_idMovimientoRecepcion", expedienteMVL.idMovimientoRecepcion);
                    comando.Parameters.AddWithValue("_idMovimientoDevolucion", expedienteMVL.idMovimientoDevolucion);
                    comando.Parameters.AddWithValue("_codigoExpedienteMVL", expedienteMVL.codigoExpedienteMVL);
                    comando.Parameters.AddWithValue("_numeroExpedienteMVL", expedienteMVL.numeroExpedienteMVL);
                    comando.Parameters.AddWithValue("_anioExpediente", expedienteMVL.anioExpediente);
                comando.ExecuteNonQuery();
                }

                // Agregado Nico

                if (expediente.informante.idPersona != 0)
                {
                    comando.Parameters.Clear();
                    comando.CommandText = "call SP_actualizarInformante(?,?)";
                    comando.Parameters.AddWithValue("_idExpediente", expediente.idExpediente);
                    comando.Parameters.AddWithValue("_idInformante", expediente.informante.idPersona);
                    comando.ExecuteNonQuery();
                }

                if (expediente.fin.idFin != 0 || expediente.fechaArchivo.CompareTo(System.DateTime.MinValue)!=0)
                {
                    comando.Parameters.Clear();
                    comando.CommandText = "call SP_actualizarExpedienteArchivoFin(?,?,?)";
                    comando.Parameters.AddWithValue("_idExpediente", expediente.idExpediente);
                    comando.Parameters.AddWithValue("_idFin", expediente.fin.idFin);
                    comando.Parameters.AddWithValue("_fechaArchivo", expediente.fechaArchivo);
                    comando.ExecuteNonQuery();
                }

                //

                transaccion.Commit();
                conexion.Close();
            }
			catch(Exception ex)
			{
				throw ex;
			}

		}

        public static void Eliminar(Movimiento movimiento, DetalleMovimiento detalleMovimiento, ExpedienteMVL expedienteMVL)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcParameter parametro = new OdbcParameter();
            OdbcTransaction transaccion;
            OdbcCommand comando = new OdbcCommand();
            try
            {
                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                comando.CommandText = "call SP_BorrarDetalleMovimiento(?,?)";
                comando.Parameters.AddWithValue("_idExpediente", detalleMovimiento.idExpediente);
                comando.Parameters.AddWithValue("_idMovimiento", detalleMovimiento.idMovimiento);
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                comando.Transaction = transaccion;
                comando.ExecuteNonQuery();

                if (expedienteMVL.accion == ExpedienteMVL.eAccion.Eliminar) 
                {
                    comando.Parameters.Clear();
                    comando.CommandText = "call SP_BorrarExpedienteMVL(?,?)";
                    comando.Parameters.AddWithValue("_idExpediente", expedienteMVL.idExpediente);
                    comando.Parameters.AddWithValue("_idMovimientoSolicitud", expedienteMVL.idMovimiento);
                    comando.ExecuteNonQuery();
                }
                if (expedienteMVL.accion == ExpedienteMVL.eAccion.Modificar)
                {
                    comando.Parameters.Clear();
                    comando.CommandText = "call SP_ModificarExpedienteMVL(?,?,?,?,?,?,?)";                    
                    comando.Parameters.AddWithValue("_idExpediente", expedienteMVL.idExpediente);
                    comando.Parameters.AddWithValue("_idMovimientoSolicitud", expedienteMVL.idMovimiento);
                    comando.Parameters.AddWithValue("_idMovimientoRecepcion", expedienteMVL.idMovimientoRecepcion);
                    comando.Parameters.AddWithValue("_idMovimientoDevolucion", expedienteMVL.idMovimientoDevolucion);
                    comando.Parameters.AddWithValue("_codigoExpedienteMVL", expedienteMVL.codigoExpedienteMVL);
                    comando.Parameters.AddWithValue("_numeroExpedienteMVL", expedienteMVL.numeroExpedienteMVL);
                    comando.Parameters.AddWithValue("_anioExpediente", expedienteMVL.anioExpediente);
                    comando.ExecuteNonQuery();
                }

                comando.Parameters.Clear();
                comando.CommandText = "call SP_BorrarMovimiento(?,?)";                
                comando.Parameters.AddWithValue("_idExpediente", movimiento.idExpediente);
                comando.Parameters.AddWithValue("_idMovimiento", movimiento.idMovimiento);
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

        public static DataSet traerCamposPorTipoMovimiento()
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            DataSet dsCamposTipoMovimiento = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerCamposTipoMovimiento", conexion);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dsCamposTipoMovimiento);

                return dsCamposTipoMovimiento;

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

        public static List<Movimiento> TraerMovimientosPorIdExpediente(int idExpediente)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter("", conexion);
            OdbcParameter parametro = new OdbcParameter();

            dataAdapter.SelectCommand.CommandType = System.Data.CommandType.StoredProcedure;



            dataAdapter.SelectCommand.CommandText = "call sp_TraerMovimientosPorIdExpediente(?)";
            parametro.ParameterName = "_idExpediente";
            parametro.Value = idExpediente;
            parametro.OdbcType = OdbcType.Int;
            dataAdapter.SelectCommand.Parameters.Add(parametro);

            List<Movimiento> listaMovimientos = new List<Movimiento>();

            try
            {
                conexion.Open();
                OdbcDataReader dr;
                dr = dataAdapter.SelectCommand.ExecuteReader();

                while (dr.Read())
                {
                    Movimiento tmp = new Movimiento();

                    tmp.idExpediente = dr.GetInt32(0);
                    tmp.idMovimiento = dr.GetByte(1);
                    tmp.idTipoMovimiento = dr.GetByte(2);
                    tmp.fechaMovimiento = dr.GetDate(3);
                    tmp.idPersona = dr.GetByte(4);
                    if (!dr.IsDBNull(5))
                        tmp.comentario = dr.GetString(5);
                    else
                        tmp.comentario = "";

                    tmp.realizado = dr.GetByte(6);
                    listaMovimientos.Add(tmp);
                }

                dr.Close();
                return listaMovimientos;

            }
            catch
            {
                throw;
            }
            finally
            {
                if (conexion.State == System.Data.ConnectionState.Open)
                    conexion.Close();
            }
        }

    }
}
