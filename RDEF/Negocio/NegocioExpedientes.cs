using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Odbc;
using Entidades;
using System.Configuration;

namespace Negocio
{
    public class NegocioExpedientes
    {
        private static String connectionString;

        public NegocioExpedientes()
        {
            AppSettingsReader connectionConfig = new AppSettingsReader();
            connectionString = (string)connectionConfig.GetValue("connectionStringODBC", typeof(string));
        }


        //Acciones para  Expediente
        public static void Agregar(Expediente expediente)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand comando = new OdbcCommand("call SP_InsertarExpediente(?,?,?,?,?,?,?,?,?,?,?,?,?)", conexion);
            try
            {
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("_idExpediente", expediente.idExpediente);
                comando.Parameters.AddWithValue("_idDenunciante", expediente.denunciante.idDenunciante);
                comando.Parameters.AddWithValue("_fechaIngreso", expediente.fechaIngreso);
                if(expediente.fechaArchivo == DateTime.MinValue)
                    comando.Parameters.AddWithValue("_fechaArchivo", DBNull.Value);
                else
                comando.Parameters.AddWithValue("_fechaArchivo", expediente.fechaArchivo);

                comando.Parameters.AddWithValue("_traeDocumentacion", expediente.traeDocumentacion);
                comando.Parameters.AddWithValue("_descDocumentacion", expediente.descDocumentacion);
                comando.Parameters.AddWithValue("_descDenuncia", expediente.descDenuncia);
                comando.Parameters.AddWithValue("_idDenunciado", expediente.denunciado.idDenunciado);

                if(expediente.informante.idPersona != 0)
                    comando.Parameters.AddWithValue("_idInformante", expediente.informante.idPersona);
                else
                    comando.Parameters.AddWithValue("_idInformante",DBNull.Value);

                if (expediente.idTipoDenuncia != 0)
                    comando.Parameters.AddWithValue("_idTipoDenuncia", expediente.idTipoDenuncia);
                else
                    comando.Parameters.AddWithValue("_idTipoDenuncia", DBNull.Value);

                comando.Parameters.AddWithValue("_idArea", expediente.area.idArea);

                if (expediente.fin.idFin != 0)
                    comando.Parameters.AddWithValue("_idFin", expediente.fin.idFin);
                else
                    comando.Parameters.AddWithValue("_idFin", DBNull.Value);
                
                comando.Parameters.AddWithValue("_idPersona", expediente.atendio.idPersona);

                conexion.Open();
                comando.Connection = conexion; 
                comando.ExecuteNonQuery();
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

        public static void Modificar(Expediente expediente)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand comando = new OdbcCommand("call SP_ModificarExpediente(?,?,?,?,?,?,?)", conexion);
            try
            {
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("_idExpediente", expediente.idExpediente);
                comando.Parameters.AddWithValue("_traeDocumentacion", expediente.traeDocumentacion);
                comando.Parameters.AddWithValue("_descDocumentacion", expediente.descDocumentacion);
                comando.Parameters.AddWithValue("_descDenuncia", expediente.descDenuncia);

                if (expediente.informante.idPersona != 0)
                    comando.Parameters.AddWithValue("_idInformante", expediente.informante.idPersona);
                else
                    comando.Parameters.AddWithValue("_idInformante", DBNull.Value);

                comando.Parameters.AddWithValue("_idTipoDenuncia", expediente.idTipoDenuncia);
                comando.Parameters.AddWithValue("_idArea", expediente.area.idArea);

                conexion.Open();
                comando.Connection = conexion;
                comando.ExecuteNonQuery();
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

        public static void Eliminar(Expediente expediente)
        { }

        /// <summary>
        /// Lista todos los Expedientes existentes en la base de datos
        /// </summary>
        /// <returns></returns>
        //public static List<Expediente> Listar()
        public static DataTable Listar()
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter("call SP_TraerExpediente", conexion);

            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataSet dsTemporal = new DataSet();
            try
            {
                conexion.Open();

                dataAdapter.Fill(dsTemporal, "listaExpediente");
                
                return dsTemporal.Tables[0];
                
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

        /// <summary>
        /// Lista los Expedientes filtrando por la descripcion de la denuncia
        /// </summary>
        /// <param name="textoDeLaDenuncia"></param>
        /// <returns></returns>
        public static DataTable ListarPorTextoDenuncia(String textoDeLaDenuncia, DateTime fechaDesde, DateTime fechaHasta)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter("call SP_TraerExpedientePorTextoDenuncia(?,?,?)", conexion);
            OdbcParameter p_textoDenuncia = new OdbcParameter();
            OdbcParameter p_fechaDesde = new OdbcParameter();
            OdbcParameter p_fechaHasta = new OdbcParameter();

            
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            p_textoDenuncia.OdbcType = OdbcType.Text;
            p_textoDenuncia.Direction = ParameterDirection.Input;
            p_textoDenuncia.ParameterName = "_textoDenuncia";
            p_textoDenuncia.Value = textoDeLaDenuncia;

            p_fechaDesde.OdbcType = OdbcType.Date;
            p_fechaDesde.Direction = ParameterDirection.Input;
            p_fechaDesde.ParameterName = "_fechaDesde";
            p_fechaDesde.Value = fechaDesde;

            p_fechaHasta.OdbcType = OdbcType.Date;
            p_fechaHasta.Direction = ParameterDirection.Input;
            p_fechaHasta.ParameterName = "_fechaHasta";
            p_fechaHasta.Value = fechaHasta;


            DataSet dsTemporal = new DataSet();
            try
            {
                conexion.Open();
                dataAdapter.SelectCommand.Parameters.Add(p_textoDenuncia);
                dataAdapter.SelectCommand.Parameters.Add(p_fechaDesde);
                dataAdapter.SelectCommand.Parameters.Add(p_fechaHasta);
                dataAdapter.Fill(dsTemporal, "listaExpediente");

                return dsTemporal.Tables[0];

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

        /// <summary>
        /// Lista los Expedientes filtrando por FechaIngreso
        /// </summary>
        /// <param name="fechaDesde"></param>
        /// <param name="fechaHasta"></param>
        /// <returns></returns>
        public static DataTable ListarPorFecha(DateTime fechaDesde, DateTime fechaHasta)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter("call SP_TraerExpedientePorFecha(?,?)", conexion);
            OdbcParameter p_fechaDesde = new OdbcParameter();
            OdbcParameter p_fechaHasta = new OdbcParameter();

            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            p_fechaDesde.OdbcType = OdbcType.Date;
            p_fechaDesde.Direction = ParameterDirection.Input;
            p_fechaDesde.ParameterName = "_fechaDesde";
            p_fechaDesde.Value = fechaDesde;

            p_fechaHasta.OdbcType = OdbcType.Date;
            p_fechaHasta.Direction = ParameterDirection.Input;
            p_fechaHasta.ParameterName = "_fechaHasta";
            p_fechaHasta.Value = fechaHasta;

            DataSet dsTemporal = new DataSet();
            try
            {
                conexion.Open();
                dataAdapter.SelectCommand.Parameters.Add(p_fechaDesde);
                dataAdapter.SelectCommand.Parameters.Add(p_fechaHasta);

                dataAdapter.Fill(dsTemporal, "listaExpediente");

                return dsTemporal.Tables[0];

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

        /// <summary>
        /// Lista los Expedientes filtrando por Localidad
        /// </summary>
        /// <param name="localidad"></param>
        /// <returns></returns>
        public static DataTable ListarPorLocalidad(String localidad)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter("call SP_TraerExpedientePorLocalidad(?)", conexion);
            OdbcParameter p_localidad = new OdbcParameter();

            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            p_localidad.OdbcType = OdbcType.Text;
            p_localidad.Direction = ParameterDirection.Input;
            p_localidad.ParameterName = "_localidad";
            p_localidad.Value = localidad;

            DataSet dsTemporal = new DataSet();
            try
            {
                conexion.Open();
                dataAdapter.SelectCommand.Parameters.Add(p_localidad);
                dataAdapter.Fill(dsTemporal, "listaExpediente");

                return dsTemporal.Tables[0];

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

        /// <summary>
        /// Lista los Expedientes filtrando por Area
        /// </summary>
        /// <param name="area"></param>
        /// <returns></returns>
        public static DataTable ListarPorArea(String area)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter("call SP_TraerExpedientePorArea(?)", conexion);
            OdbcParameter p_area = new OdbcParameter();

            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            p_area.OdbcType = OdbcType.Text;
            p_area.Direction = ParameterDirection.Input;
            p_area.ParameterName = "_area";
            p_area.Value = area;

            DataSet dsTemporal = new DataSet();
            try
            {
                conexion.Open();
                dataAdapter.SelectCommand.Parameters.Add(p_area);
                dataAdapter.Fill(dsTemporal, "listaExpediente");

                return dsTemporal.Tables[0];

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

        /// <summary>
        /// Lista los Expedientes filtrando por Denunciado (ex Empresas)
        /// </summary>
        /// <param name="fechaDesde"></param>
        /// <param name="fechaHasta"></param>
        /// <returns></returns>
        public static DataTable ListarPorDenunciado(String denunciado, DateTime fechaDesde, DateTime fechaHasta)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter("call SP_TraerExpedientePorDenunciado(?,?,?)", conexion);
            
            OdbcParameter p_denunciado = new OdbcParameter();
            OdbcParameter p_fechaDesde = new OdbcParameter();
            OdbcParameter p_fechaHasta = new OdbcParameter();

            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            p_denunciado.OdbcType = OdbcType.VarChar;
            p_denunciado.Direction = ParameterDirection.Input;
            p_denunciado.ParameterName = "_denunciado";
            p_denunciado.Value = denunciado;

            p_fechaDesde.OdbcType = OdbcType.Date;
            p_fechaDesde.Direction = ParameterDirection.Input;
            p_fechaDesde.ParameterName = "_fechaDesde";
            p_fechaDesde.Value = fechaDesde;

            p_fechaHasta.OdbcType = OdbcType.Date;
            p_fechaHasta.Direction = ParameterDirection.Input;
            p_fechaHasta.ParameterName = "_fechaHasta";
            p_fechaHasta.Value = fechaHasta;

            DataSet dsTemporal = new DataSet();
            try
            {
                conexion.Open();
                dataAdapter.SelectCommand.Parameters.Add(p_denunciado);
                dataAdapter.SelectCommand.Parameters.Add(p_fechaDesde);
                dataAdapter.SelectCommand.Parameters.Add(p_fechaHasta);

                dataAdapter.Fill(dsTemporal, "listaExpediente");

                return dsTemporal.Tables[0];

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

        /// <summary>
        /// Lista Expedientes por número, apellido o calle exactos
        /// </summary>
        /// <param name="idExpediente"></param>
        /// <param name="apellido"></param>
        /// <param name="calle"></param>
        /// <returns></returns>
        public static DataTable Listar(int? idExpediente, string apellido, string calle)
        //public static List<Expediente> Listar(int? idExpediente, string apellido, string calle)
        {

            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter("", conexion);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            OdbcParameter parametro = new OdbcParameter();
            parametro.Direction = ParameterDirection.Input;

            if (idExpediente != null)
            {
                //dataAdapter.SelectCommand.CommandText = "call getExpedienteById(?)";
                dataAdapter.SelectCommand.CommandText = "call SP_TraerExpedientePorId(?)";
                parametro.ParameterName = "_idExpediente";
                parametro.Value = idExpediente;

                parametro.OdbcType = OdbcType.Int;
                dataAdapter.SelectCommand.Parameters.Add(parametro);
            }
            else if (apellido != null)
            {
                //dataAdapter.SelectCommand.CommandText = "call getExpedienteByApellido(?)";
                dataAdapter.SelectCommand.CommandText = "call SP_TraerExpedientePorApellido(?)";
                parametro.ParameterName = "_apellido";
                parametro.Value = apellido;

                parametro.OdbcType = OdbcType.VarChar;
                parametro.Size = 30;
                dataAdapter.SelectCommand.Parameters.Add(parametro);
            }
            else
            {
                //dataAdapter.SelectCommand.CommandText = "call getExpedienteByCalle(?)";
                dataAdapter.SelectCommand.CommandText = "call SP_TraerExpedientePorCalle(?)";
                parametro.ParameterName = "_calle";
                parametro.Value = calle;

                parametro.OdbcType = OdbcType.VarChar;
                parametro.Size = 50;
                dataAdapter.SelectCommand.Parameters.Add(parametro);
            }

            //List<Expediente> listaExpediente = new List<Expediente>();
            DataSet dsTemporal = new DataSet();
            try
            {
                conexion.Open();

                //OdbcDataReader drExpedientes = dataAdapter.SelectCommand.ExecuteReader();

                dataAdapter.Fill(dsTemporal, "listaExpediente");

                return dsTemporal.Tables[0];
                //return listaExpediente;
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

        /// <summary>
        /// Lista Expedientes que contengan apellido o calle, utilizando LIKE
        /// </summary>
        /// <param name="apellido"></param>
        /// <param name="calle"></param>
        /// <returns></returns>
        //public static List<Expediente> Listar(string apellido, string calle)
        public static DataTable Listar(string apellido, string calle)
        {

            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter("", conexion);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            OdbcParameter parametro = new OdbcParameter();
            parametro.Direction = ParameterDirection.Input;

            if (apellido != null)
            {
                //dataAdapter.SelectCommand.CommandText = "call getExpedienteLikeApellido(?)";
                dataAdapter.SelectCommand.CommandText = "call SP_TraerExpedienteLikeApellido(?)";
                parametro.ParameterName = "_apellido";
                apellido = "%" + apellido + "%";
                parametro.Value = apellido;
                parametro.OdbcType = OdbcType.VarChar;
                parametro.Size = 30;
                dataAdapter.SelectCommand.Parameters.Add(parametro);
            }
            else
            {
                //dataAdapter.SelectCommand.CommandText = "call getExpedienteLikeCalle(?)";
                dataAdapter.SelectCommand.CommandText = "call SP_TraerExpedienteLikeCalle(?)";
                parametro.ParameterName = "_calle";
                calle = "%" + calle + "%";
                parametro.Value = calle;
                parametro.OdbcType = OdbcType.VarChar;
                parametro.Size = 50;
                dataAdapter.SelectCommand.Parameters.Add(parametro);
            }


            DataSet dsTemporal = new DataSet();
            //List<Expediente> listaExpediente = new List<Expediente>();
            try
            {
                conexion.Open();
                dataAdapter.Fill(dsTemporal, "listaExpediente");

                return dsTemporal.Tables[0];
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

        public static Expediente TraerExpedienteCompletoPorIdExpediente(Int32 idExpediente)
        {
            Expediente expedienteTemporal = new Expediente();
            
            #region Conexion y Parametro 
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter("call sp_TraerExpedienteCompletoPorIdExpediente(?)", conexion);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            OdbcParameter parametro = new OdbcParameter();
            parametro.Direction = ParameterDirection.Input;
            #endregion

            expedienteTemporal.idExpediente = idExpediente;
            try
            {
                parametro.Value = idExpediente;
                dataAdapter.SelectCommand.Parameters.Add(parametro);

                conexion.Open();
                OdbcDataReader dr = dataAdapter.SelectCommand.ExecuteReader();
                if (dr.HasRows)
                {
                while (dr.Read())
                {
                    #region Denunciante 
                    /*
                    denunciante.nombre,
                    denunciante.apellido,
                    denunciante.domicilio,
                    denunciante.numero,
                    denunciante.piso,
                    denunciante.dpto,
                    denunciante.idLocalidad,
                    denunciante.idTipoDocumento,
                    denunciante.nroDocumento,
                    */
                    expedienteTemporal.denunciante.idDenunciante = dr.GetInt32(1);
                    expedienteTemporal.denunciante.nombre = dr.GetString(2);
                    expedienteTemporal.denunciante.apellido = dr.GetString(3);
                    expedienteTemporal.denunciante.domicilio = dr.GetString(4);
                    expedienteTemporal.denunciante.numero = dr.GetInt16(5);

                    if (!dr.IsDBNull(6))
                        expedienteTemporal.denunciante.piso = (Byte) dr.GetInt16(6);
                    //else
                    //    expedienteTemporal.denunciante.piso = 0;

                    if (!dr.IsDBNull(7))
                        expedienteTemporal.denunciante.dpto = dr.GetString(7);
                    else
                        expedienteTemporal.denunciante.dpto = "";



                    expedienteTemporal.denunciante.idLocalidad = dr.GetInt16(8);
                    expedienteTemporal.denunciante.idTipoDocumento = dr.GetByte(9);
                    expedienteTemporal.denunciante.nroDocumento = dr.GetInt32(10);

                    #endregion

                    #region Expediente 
                    /*               
                    expe.fechaIngreso,
                    expe.fechaArchivo,
                    expe.traeDocumentacion,
                    expe.descDocumentacion,
                    expe.descDenuncia,
                    */

                    expedienteTemporal.fechaIngreso = dr.GetDate(11);
                    if (!dr.IsDBNull(12))
                        expedienteTemporal.fechaArchivo = dr.GetDate(12);
                    else
                        expedienteTemporal.fechaArchivo = DateTime.MinValue;

                    expedienteTemporal.traeDocumentacion = dr.GetByte(13);

                    if (!dr.IsDBNull(14))
                        expedienteTemporal.descDocumentacion = dr.GetString(14);
                    else
                        expedienteTemporal.descDocumentacion = "";

                    if (!dr.IsDBNull(15))
                        expedienteTemporal.descDenuncia = dr.GetString(15);
                    else
                        expedienteTemporal.descDenuncia = "";

                    #endregion

                    #region Denunciado 
                    /*
                    expe.idDenunciado,
                    denunciado.entidad,
                    */

                    expedienteTemporal.denunciado.idDenunciado = dr.GetByte(16);

                    if (!dr.IsDBNull(17))
                        expedienteTemporal.denunciado.entidad = dr.GetString(17);
                    else
                        expedienteTemporal.denunciado.entidad = "";

                    #endregion

                    #region Informante 
                    /*
                    expe.idInformante,
                    informante.nombre,
                    */

                    if (!dr.IsDBNull(18))
                    {
                        expedienteTemporal.informante.idPersona = dr.GetInt16(18);
                    expedienteTemporal.informante.nombrePersona = dr.GetString(19);
                    }
                    else
                    {
                        expedienteTemporal.informante.idPersona = 0;
                        expedienteTemporal.informante.nombrePersona = ""; 
                    }

                    #endregion

                    #region TipoDenuncia 
                    /*
                    expe.idTipoDenuncia,
                    tipoDenuncia.descTipoDenuncia,
                    */

                    expedienteTemporal.idTipoDenuncia = dr.GetByte(20);
                    //falta descTipoDenuncia

                    #endregion

                    #region Area 
                    /*
                    expe.idArea,
                    areas.descArea,
                    */
                    if (!dr.IsDBNull(22))
                        expedienteTemporal.area.idArea = (Byte)dr.GetInt16(22);
                    else
                        expedienteTemporal.area.idArea = 0;
                                                          
                    if (!dr.IsDBNull(23))
                        expedienteTemporal.area.descArea = dr.GetString(23);
                    else
                        expedienteTemporal.area.descArea = "";

                    #endregion

                    #region Fines 

                    /*
                    expe.idFin,
                    fin.descFin 
                    */
                    if (!dr.IsDBNull(24))
                        expedienteTemporal.fin.idFin = (Byte)dr.GetInt16(24);
                    else
                        expedienteTemporal.fin.idFin = 0;

                    if (!dr.IsDBNull(25))
                        expedienteTemporal.fin.descFin = dr.GetString(25);
                    else
                        expedienteTemporal.fin.descFin = "";

                    #endregion

                    #region Persona
                    /*
                    expe.idPersona,
                    persona.nombre,
                    */

                    expedienteTemporal.atendio.idPersona = dr.GetInt16(26);
                    expedienteTemporal.atendio.nombrePersona = dr.GetString(27);

                    #endregion
                }

                #region Movimientos del Expediente 

                expedienteTemporal.movimientos = NegocioMovimientos.TraerMovimientosPorIdExpediente(expedienteTemporal.idExpediente);

                #endregion
                }
                else
                    return null;

                dr.Close();
                return expedienteTemporal;
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

        public static String TraerDetalleDenuncia(Int32 idExpediente)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter("call SP_TraerExpediente", conexion);
            OdbcParameter parametro = new OdbcParameter();

            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;

            dataAdapter.SelectCommand.CommandText = "call SP_TraerDetalleDenuncia(?)";
            parametro.ParameterName = "_idExpediente";
            parametro.Value = idExpediente;
            parametro.OdbcType = OdbcType.Int;
            dataAdapter.SelectCommand.Parameters.Add(parametro);

            try
            {
                conexion.Open();

                OdbcDataReader dr;

                dr = dataAdapter.SelectCommand.ExecuteReader();

                String tmp = "";
                while (dr.Read())
                {
                    if (!dr.IsDBNull(0))
                        tmp = dr.GetString(0);

                }

                dr.Close();
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
            }

        }

        public static Denunciante TraerDenunciantePorNroDoc(int nroDoc)
        {
            OdbcConnection cnn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcDataAdapter da = new OdbcDataAdapter("", cnn);
            OdbcDataReader dr;
            Denunciante denunciante = null;
            try
            {


                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.CommandText = "call SP_TraerDenuncianteCompletoPorDOC(?)";
                da.SelectCommand.Parameters.Clear();
                OdbcParameter parametro = new OdbcParameter();
                parametro.ParameterName = "_nroDoc";
                parametro.Value = nroDoc;
                parametro.DbType = DbType.Int32;
                parametro.Direction = ParameterDirection.Input;
                da.SelectCommand.Parameters.Add(parametro);

                cnn.Open();

                dr = da.SelectCommand.ExecuteReader();

                if (!dr.HasRows)
                {
                    return denunciante;
                }

                dr.Read();

                denunciante = new Denunciante();
                denunciante.idDenunciante = dr.GetInt32(0);
                denunciante.nombre = dr.GetString(1);
                denunciante.apellido = dr.GetString(2);
                denunciante.domicilio = dr.GetString(3);
                denunciante.numero = dr.GetInt32(4);
                denunciante.piso = dr.GetByte(5);
                denunciante.dpto = dr.GetString(6);
                denunciante.idLocalidad = dr.GetInt32(7);
                denunciante.idTipoDocumento = dr.GetByte(8);
                denunciante.nroDocumento = dr.GetInt32(9);

                //denunciante.contactos = TraerContactoDenunciante(denunciante.idDenunciante);

                return denunciante;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static List<Contacto> TraerContactoDenunciante(int idDenunciante)
        {
            OdbcConnection cnn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcDataAdapter da = new OdbcDataAdapter("", cnn);
            OdbcDataReader dr;
            List<Contacto> ListaContactos = new List<Contacto>();
            Contacto contacto;
            try
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.CommandText = "call SP_TraerContactosDenunciante(?)";
                da.SelectCommand.Parameters.Clear();
                OdbcParameter parametro = new OdbcParameter();
                parametro.ParameterName = "_idDenunciante";
                parametro.Value = idDenunciante;
                parametro.DbType = DbType.Int32;
                parametro.Direction = ParameterDirection.Input;
                da.SelectCommand.Parameters.Add(parametro);

                cnn.Open();

                dr = da.SelectCommand.ExecuteReader();

                if (dr.HasRows)
                {

                    while (dr.Read())
                    {
                        contacto = new Contacto();
                        contacto.idDenunciante = idDenunciante;
                        contacto.tipoContacto = dr.GetChar(1).ToString();
                        contacto.contacto = dr.GetString(2);
                        ListaContactos.Add(contacto);
                    }

                }
                else
                {
                    contacto = new Contacto();
                    contacto.idDenunciante = idDenunciante;
                    contacto.tipoContacto = "";
                    contacto.contacto = "";
                    ListaContactos.Add(contacto);
                    
                }

                return ListaContactos;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }


        public static DataSet TraerContactosDenunciante(int idDenunciante)
        {
            OdbcConnection cnn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcDataAdapter da = new OdbcDataAdapter("", cnn);
            DataSet dsContactos = new DataSet();
            try
            {
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.CommandText = "call SP_TraerContactosPorId(?)";
                da.SelectCommand.Parameters.Clear();
                OdbcParameter parametro = new OdbcParameter();
                parametro.ParameterName = "_idDenunciante";
                parametro.Value = idDenunciante;
                parametro.DbType = DbType.Int32;
                parametro.Direction = ParameterDirection.Input;
                da.SelectCommand.Parameters.Add(parametro);

                cnn.Open();

                da.Fill(dsContactos);

                return dsContactos;
                
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        // CHONA

        public static DataSet TraerDenunciantes()
        {
            OdbcConnection cn = null;
            DataSet dsDenunciantes = new DataSet();

            try
            {
                cn = new OdbcConnection(Negocio.NegocioBase.getConnectionString());

                OdbcDataAdapter da = new OdbcDataAdapter("call SP_getDenunciantes", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dsDenunciantes);

                return dsDenunciantes;
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


        public static DataSet TraerDenunciantesPorFiltro(string filtro)
        {

            OdbcConnection cn = null;
            DataSet dsDenunciantes = new DataSet();
            string query = "SELECT idDenunciante as ID,nombre as Nombre,apellido as Apellido,";
            query = query + "descTipoDocumento as Documento,nroDocumento as Nro,domicilio as Calle,";
            query = query + "numero as Nro,descLocalidad as Localidad ";            
            query = query + "FROM denunciantes denun INNER JOIN localidades loc ON denun.idLocalidad = loc.IdLocalidad ";
            query = query + "INNER JOIN partidos part ON loc.idPartido = part.idPartido INNER JOIN tipos_documentos td ";
            query = query + "ON denun.idTipoDocumento = td.idTipoDocumento WHERE " + filtro;

            try
            {
                cn = new OdbcConnection(Negocio.NegocioBase.getConnectionString());

                OdbcDataAdapter da = new OdbcDataAdapter("", cn);
                da.SelectCommand.CommandType = CommandType.Text;

                da.SelectCommand.CommandText = query;

                da.Fill(dsDenunciantes);

                return dsDenunciantes;
                
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

        public static void TraerIniciadorExpediente(Expediente expediente)
        {
            OdbcConnection cn = null;
            DataSet dsIniciador = new DataSet();
            Persona persona = new Persona();
            try
            {
                cn = new OdbcConnection(Negocio.NegocioBase.getConnectionString());


                OdbcDataAdapter da = new OdbcDataAdapter("", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.SelectCommand.CommandText = "call SP_TraerIniciadorExpediente(?)";
                da.SelectCommand.Parameters.Clear();
                da.SelectCommand.Parameters.AddWithValue("pIdExpediente",expediente.idExpediente);
                cn.Open();
                da.Fill(dsIniciador);                
                
                persona.idPersona = int.Parse(dsIniciador.Tables[0].Rows[0]["idPersona"].ToString());
                persona.nombrePersona = dsIniciador.Tables[0].Rows[0]["nombre"].ToString();

                expediente.atendio = persona;

                
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

        public static int TraerProxIdExpediente()
        {
            OdbcConnection cn = null;
            OdbcCommand cm = new OdbcCommand();
            int idProx;            
            
            try
            {
                cn = new OdbcConnection(Negocio.NegocioBase.getConnectionString());
                cn.Open();
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "call SP_TraerProxIDExpediente";
                cm.Connection = cn;

                idProx = cm.ExecuteScalar() != DBNull.Value ? int.Parse(cm.ExecuteScalar().ToString()) + 1 : 1;

                return idProx;
                
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

        public static int TraerProxIdDenunciante()
        {
            OdbcConnection cn = null;
            OdbcCommand cm = new OdbcCommand();
            int idProx;            
            
            try
            {
                cn = new OdbcConnection(Negocio.NegocioBase.getConnectionString());
                cn.Open();
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "call SP_TraerProxIdDenunciante";
                cm.Connection = cn;

                //idProx= Convert.ToInt32( cm.ExecuteScalar());
                idProx = cm.ExecuteScalar() != DBNull.Value ? int.Parse(cm.ExecuteScalar().ToString()) + 1 : 1;

                return idProx;
                
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



        public static Denunciante TraerDenuncianteCompletoPorID(int idDenunciante)
        {
            OdbcConnection cnn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcDataAdapter da = new OdbcDataAdapter("", cnn);
            OdbcDataReader dr;
            Denunciante denunciante = null;
            try
            {

                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.CommandText = "call SP_TraerDenuncianteCompletoPorID(?)";
                da.SelectCommand.Parameters.Clear();
                OdbcParameter parametro = new OdbcParameter();
                parametro.ParameterName = "_idDenunciante";
                parametro.Value = idDenunciante;
                parametro.DbType = DbType.Int32;
                parametro.Direction = ParameterDirection.Input;
                da.SelectCommand.Parameters.Add(parametro);

                cnn.Open();

                dr = da.SelectCommand.ExecuteReader();

                if (!dr.HasRows)
                {
                    return denunciante;
                }

                dr.Read();

                denunciante = new Denunciante();
                denunciante.idDenunciante = dr.GetInt32(0);
                denunciante.nombre = dr.GetString(1);
                denunciante.apellido = dr.GetString(2);
                denunciante.domicilio = dr.GetString(3);
                denunciante.numero = dr.GetInt32(4);
                denunciante.piso = dr.GetByte(5);
                denunciante.dpto = dr.GetString(6);
                denunciante.idLocalidad = dr.GetInt32(7);
                denunciante.idTipoDocumento = dr.GetByte(8);
                denunciante.nroDocumento = dr.GetInt32(9);

                //denunciante.contactos = TraerContactoDenunciante(denunciante.idDenunciante);

                return denunciante;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


        public static void AgregarDenunciante(Denunciante denunciante)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcParameter parametro = new OdbcParameter();            
            OdbcCommand comando = new OdbcCommand("call SP_InsertarDenunciante(?,?,?,?,?,?,?,?,?,?)", conexion);
            try
            {
                comando.Parameters.AddWithValue("_idDenunciante", denunciante.idDenunciante);
                comando.Parameters.AddWithValue("_nombre", denunciante.nombre);
                comando.Parameters.AddWithValue("_apellido", denunciante.apellido);
                comando.Parameters.AddWithValue("_domicilio", denunciante.domicilio);
                comando.Parameters.AddWithValue("_numero", denunciante.numero);
                comando.Parameters.AddWithValue("_piso", denunciante.piso);
                comando.Parameters.AddWithValue("_dpto", denunciante.dpto);
                comando.Parameters.AddWithValue("_idLocalidad", denunciante.idLocalidad);
                comando.Parameters.AddWithValue("_idTipoDocumento", denunciante.idTipoDocumento);
                comando.Parameters.AddWithValue("_nroDocumento", denunciante.nroDocumento);
                
                comando.Connection = conexion;
                conexion.Open();              
                comando.ExecuteNonQuery();                
                conexion.Close();

                //Agrego contactos
                //GuardarContactosDenunciante(denunciante.contactos);
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public static void ModificarDenunciante(Denunciante denunciante)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcParameter parametro = new OdbcParameter();
            OdbcCommand comando = new OdbcCommand("call SP_ModificarDenunciante(?,?,?,?,?,?,?,?,?,?)", conexion);
            try
            {
                comando.Parameters.AddWithValue("_idDenunciante", denunciante.idDenunciante);
                comando.Parameters.AddWithValue("_nombre", denunciante.nombre);
                comando.Parameters.AddWithValue("_apellido", denunciante.apellido);
                comando.Parameters.AddWithValue("_domicilio", denunciante.domicilio);
                comando.Parameters.AddWithValue("_numero", denunciante.numero);
                comando.Parameters.AddWithValue("_piso", denunciante.piso);
                comando.Parameters.AddWithValue("_dpto", denunciante.dpto);
                comando.Parameters.AddWithValue("_idLocalidad", denunciante.idLocalidad);
                comando.Parameters.AddWithValue("_idTipoDocumento", denunciante.idTipoDocumento);
                comando.Parameters.AddWithValue("_nroDocumento", denunciante.nroDocumento);

                comando.Connection = conexion;
                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();

                //Modifico Contactos
                //foreach (Contacto contacto in denunciante.contactos)
                //{
                //    bool existe = ExisteTipoContacto(contacto);
                //    if (contacto.contacto != "")
                //    {
                //        if (existe)
                //            ModificarContactoDenunciante(contacto);
                //        else
                //        {
                //            List<Contacto> contactos = new List<Contacto>();
                //            contactos.Add(contacto);
                //            GuardarContactosDenunciante(contactos);
                //        }
                //    }
                //    else
                //        if(existe)
                //            EliminarContactoDenunciante(contacto);
                    
                //}
            }
            catch (Exception ex)
            {
                throw ex;
            }
        
        }

        private static bool ExisteTipoContacto(Contacto cont)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcParameter parametro = new OdbcParameter();
            OdbcCommand comando = new OdbcCommand("call SP_ExisteTipoContacto(?,?)", conexion);
            try
            {
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("_idDenunciante", cont.idDenunciante);
                comando.Parameters.AddWithValue("_tipoContacto", cont.tipoContacto);

                comando.Connection = conexion;
                comando.CommandType = CommandType.StoredProcedure;
                conexion.Open();

                int cant = int.Parse(comando.ExecuteScalar().ToString());
                if (cant > 0)
                    return true;
                
                return false;

            }
            catch(Exception ex)
            {
                throw ex;
            }
        }

        public static void GuardarContactosDenunciante(List<Contacto> contactos)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcParameter parametro = new OdbcParameter();                    
            OdbcCommand comando = new OdbcCommand("call SP_InsertarContactoDenunciante(?,?,?,?)", conexion);
            OdbcTransaction transaccion;
            try
            {

                comando.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                transaccion = conexion.BeginTransaction();
                comando.Transaction = transaccion;
                foreach (Contacto contacto in contactos)
                {
                    comando.Parameters.Clear();
                    comando.Parameters.AddWithValue("_idDenunciante", contacto.idDenunciante);
                    comando.Parameters.AddWithValue("_tipoContacto", contacto.tipoContacto);
                    comando.Parameters.AddWithValue("_contacto", contacto.contacto);
                    comando.Parameters.AddWithValue("_activo", contacto.activo);
                    if (comando.ExecuteNonQuery() == 0)
                    {
                        transaccion.Rollback();
                        throw new Exception("Error al guardar Contacto del denunciante.");                        
                    }
                }
                transaccion.Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
                comando.Dispose();
            }

        }

        public static void ModificarContactoDenunciante(Contacto contacto)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcParameter parametro = new OdbcParameter();            
            OdbcCommand comando = new OdbcCommand("call SP_ModificarContactoDenunciante(?,?,?)", conexion);
            try
            {
                comando.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("_idDenunciante", contacto.idDenunciante);
                comando.Parameters.AddWithValue("_tipoContacto", contacto.tipoContacto);
                comando.Parameters.AddWithValue("_contacto", contacto.contacto);
                comando.ExecuteNonQuery();               
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
                comando.Dispose();
            }

        }

        public static void EliminarContactoDenunciante(Contacto contacto)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcParameter parametro = new OdbcParameter();
            OdbcCommand comando = new OdbcCommand("call SP_EliminarContactoDenunciante(?,?)", conexion);
            try
            {
                comando.CommandType = CommandType.StoredProcedure;
                conexion.Open();
                comando.Parameters.Clear();
                comando.Parameters.AddWithValue("_idDenunciante", contacto.idDenunciante);
                comando.Parameters.AddWithValue("_tipoContacto", contacto.tipoContacto);
                comando.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conexion.Close();
                comando.Dispose();
            }

        }

        // Agregado Nico B.
        public static Boolean TraerExpedienteExistente(int idExpediente)
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());

            OdbcParameter parametro = new OdbcParameter();
            parametro.ParameterName = "idExpediente";
            parametro.Value = idExpediente;
            parametro.OdbcType = OdbcType.Int;
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter("Call SP_TraerExpedienteExistente(?)", conexion);
            dataAdapter.SelectCommand.Parameters.Add(parametro);
            conexion.Open();

            try
            {
                OdbcDataReader drExpediente = dataAdapter.SelectCommand.ExecuteReader();
                Expediente tmp = new Expediente();
                while (drExpediente.Read())
                {
                    if (drExpediente.GetInt32(0) == 0)
                    { 
                        drExpediente.Close();
                        return false;                    
                    }
                        
                }
                drExpediente.Close();
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

            return true;
        }

        public static String TraerIniciadorMovimientos(int idExpediente) 
        {
            OdbcConnection conexion = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcParameter parametro = new OdbcParameter();
            String iniciador = "";
            parametro.ParameterName = "idExpediente";
            parametro.Value = idExpediente;
            parametro.OdbcType = OdbcType.Int;
            OdbcDataAdapter dataAdapter = new OdbcDataAdapter("Call SP_TraerIniciadorMovimientos(?)", conexion);
            dataAdapter.SelectCommand.Parameters.Add(parametro);
            conexion.Open();
            try
            {
                OdbcDataReader drExpediente = dataAdapter.SelectCommand.ExecuteReader();
                while (drExpediente.Read())
                {
                    iniciador = drExpediente.GetString(0);
                }
                drExpediente.Close();
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

            return iniciador;
        }

    }
}
