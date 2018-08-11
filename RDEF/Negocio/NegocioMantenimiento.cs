using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
using System.Data.Odbc;
using System.Collections;
using System.Data;
using System.Configuration;

namespace Negocio
{
    public class NegocioMantenimiento
    {

        #region Metodos Area
        public static void AgregarArea(Area area)
        { 

            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_InsertarAreas(?,?,?)", cn);

			try
			{
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idArea", area.idArea);
                cm.Parameters.AddWithValue("_descArea", area.descArea);
                cm.Parameters.AddWithValue("_estado", area.estado);
                cn.Open();

                if (cm.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Error al intentar guardar un Area");
                }
                
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public static Byte TraerId()
        {
            OdbcConnection cn = null;
            OdbcCommand cm = new OdbcCommand();
            Byte Cod;

			try
			{
                cn = new OdbcConnection(NegocioBase.getConnectionString());
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "call SP_TraerIdArea()";
                cm.Connection = cn;
                cn.Open();
                Cod =  Convert.ToByte(cm.ExecuteScalar() != DBNull.Value ? int.Parse(cm.ExecuteScalar().ToString())+1 : 1);
                return Cod;
                
			}
			catch(Exception ex)
			{
				throw ex;
			}
            finally 
            {

                if (cn.State == ConnectionState.Open)
                    cn.Close();
            
            }
		}

        
    

        public static void ModificarArea(Area area)
        { 

            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_ModificarArea(?,?,?)", cn);


			try
			{
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idArea", area.idArea);
                cm.Parameters.AddWithValue("_descArea", area.descArea);
                cm.Parameters.AddWithValue("_estado", Convert.ToByte( area.estado));
                
                cn.Open();
                if (cm.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Error al intentar Modificar Area");
                }  
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public static String EliminarArea(int idArea)
       
        { 
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_EliminarArea(?)", cn);

			try
        { 
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idArea", idArea);

                cn.Open();
			try
			{
                if (cm.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Error al intentar eliminar Area");
                }
			}
                catch (OdbcException oEx)
                {
                    return "No se puede Eliminar Area."; 
                }
                return "";
			}
			catch(Exception ex)
			{
				throw ex;
			}

        }

        public static DataSet TraerDataSetAreas()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());

            DataSet dsAreas = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerAreasEstado", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
               
                da.Fill(dsAreas);

                return dsAreas;

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

        public static DataSet TraerAreasActivas()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());

            DataSet dsAreas = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerActivosAreas", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dsAreas);

                return dsAreas;

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
        public static DataSet TraerAreasInactivas()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());

            DataSet dsAreas = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerInactivosAreas", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dsAreas);

                return dsAreas;

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

        //Agregado Hugo
        public static DataTable TraerAreas()
        {
            
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            DataSet dsAreas = new DataSet();

            try
            {
                OdbcDataAdapter dataAdapter = new OdbcDataAdapter("call SP_TraerAreas", cn);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.Fill(dsAreas);

                return dsAreas.Tables[0];

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

        #endregion

        #region Metodos Denunciado


        public static Byte TraerIdDenunciado()
        {
            OdbcConnection cn = null;
            OdbcCommand cm = new OdbcCommand();
            Byte Cod;

            try
            {
                cn = new OdbcConnection(NegocioBase.getConnectionString());
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "call SP_TraerIdDenunciado()";
                cm.Connection = cn;
                cn.Open();
                Cod = Convert .ToByte(cm.ExecuteScalar() != DBNull.Value ? int.Parse(cm.ExecuteScalar().ToString()) + 1 : 1);
                return Cod ;

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
        
       
        
        
        public static void AgregarDenunciado(Denunciado denunciado)
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_InsertarDenunciado(?,?,?)", cn);

			try
			{
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idDenunciado", denunciado.idDenunciado);
                cm.Parameters.AddWithValue("_entidad", denunciado.entidad);
                cm.Parameters.AddWithValue("_estado", denunciado.estado);
             
                cn.Open();
                if (cm.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Error al intentar guardar denunciado");
                }
			}
			catch(Exception ex)
			{
				throw ex;
			}
		
		}

        public static void ModificarDenunciado(Denunciado denunciado)
        { 
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_ModificarDenunciado(?,?,?)", cn);

			try
			{
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idDenunciado", denunciado.idDenunciado);
                cm.Parameters.AddWithValue("_entidad", denunciado.entidad);
                cm.Parameters.AddWithValue("_estado", denunciado.estado);


                cn.Open();
                if (cm.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Error al intentar modificar denunciado");
                }
			}
			catch(Exception ex)
			{
				throw ex;
			}

		}

        public static String EliminarDenunciado(int idDenunciado)
        { 
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_EliminarDenunciado(?)", cn);

            try
            {
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idDenunciado", idDenunciado);

                cn.Open();
			try
			{
                    if (cm.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Error al intentar eliminar Denunciado");
                    }
                }
                catch (OdbcException oEx)
                {
                    return "No se puede Eliminar Denunciado.";
                }
                return "";
			}
			catch(Exception ex)
			{
				throw ex;
			}

        }

        public static DataSet TraerDataSetDenunciados()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());

            DataSet dsDenunciados = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call sp_TraerDenunciados", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dsDenunciados);

                return dsDenunciados;

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

        public static DataSet TraerDenunciadosActivos()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());

            DataSet dsDenunciados = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerActivosDenunciados", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dsDenunciados);

                return dsDenunciados;

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

        public static DataSet TraerDenunciadosInactivos()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());

            DataSet dsDenunciados = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerDenunciadosInactivos", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dsDenunciados);

                return dsDenunciados;

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

        //Agregado Hugo
        public static DataTable TraerDenunciados()
        {
            
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            DataSet dsDenunciados = new DataSet();

            try
            {
                OdbcDataAdapter dataAdapter = new OdbcDataAdapter("call SP_TraerDenunciados", cn);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.Fill(dsDenunciados);

                return dsDenunciados.Tables[0];

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

        #endregion

        #region Metodos Dependencia

        public static DataSet TraerDependencias()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            DataSet dsDependencias = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerDependencias", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dsDependencias);

                return dsDependencias;
                
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

        public static DataSet TraerDependenciasEstado()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            DataSet dsDependencias = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerDependenciasEstado", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dsDependencias);

                return dsDependencias;

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

        public static void AgregarDependencia(Dependencia Dependencia)
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_InsertarDependencias(?,?,?)", cn);
            try
            {
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idDependencia", Dependencia.idDependencia);
                cm.Parameters.AddWithValue("_descDependencia", Dependencia.descDependencia);
                cm.Parameters.AddWithValue("_estado", Dependencia.estado);
                cn.Open();
                if (cm.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Error al intentar guardar una Dependencia");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static void ModificarDependencia(Dependencia Dependencia)
        {

            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_ModificarDependencia(?,?,?)", cn);


            try
            {
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idDependencia", Dependencia.idDependencia);
                cm.Parameters.AddWithValue("_descDependencia", Dependencia.descDependencia);
                cm.Parameters.AddWithValue("_estado", Convert.ToByte(Dependencia.estado));

                cn.Open();
                if (cm.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Error al intentar Modificar Dependencia");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static String EliminarDependencia(int idDependencia)
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_EliminarDependencia(?)", cn);

            try
            {
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idDependencia", idDependencia);

                cn.Open();
                try
                {
                    if (cm.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Error al intentar eliminar Dependencia");
                    }
                }
                catch (OdbcException oEx)
                {
                    return "No se puede Eliminar Dependencia.";
                }
                return "";
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }

        public static Byte TraerIdDependencia()
        {
            OdbcConnection cn = null;
            OdbcCommand cm = new OdbcCommand();
            Byte Cod;

            try
            {
                cn = new OdbcConnection(NegocioBase.getConnectionString());
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "call SP_TraerIdDependencia()";
                cm.Connection = cn;
                cn.Open();
                Cod = Convert.ToByte(cm.ExecuteScalar() != DBNull.Value ? int.Parse(cm.ExecuteScalar().ToString()) + 1 : 1);
                return Cod;
                
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

        public static DataSet TraerDependenciasActivas()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());

            DataSet dsDependencias = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerActivosDependencia", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dsDependencias);

                return dsDependencias;

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
        public static DataSet TraerDependenciasInactivas()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());

            DataSet dsDependencias = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerInactivosDependencia", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dsDependencias);

                return dsDependencias;

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

        #endregion

        #region Metodos Fin
        public static void AgregarFin(Fin fin)
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_InsertarFines(?,?,?)", cn);

            try
            {
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idFin", fin.idFin);
                cm.Parameters.AddWithValue("_descFin", fin.descFin);
                cm.Parameters.AddWithValue("_estado", fin.estado);
                cn.Open();

                if (cm.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Error al intentar guardar un Fin");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static Byte TraerIdFin()
        {
            OdbcConnection cn = null;
            OdbcCommand cm = new OdbcCommand();
            Byte Cod;

            try
            {
                cn = new OdbcConnection(NegocioBase.getConnectionString());
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "call SP_TraerIdFin()";
                cm.Connection = cn;
                cn.Open();
                Cod = Convert.ToByte(cm.ExecuteScalar() != DBNull.Value ? int.Parse(cm.ExecuteScalar().ToString()) + 1 : 1);
                return Cod;

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

        public static void ModificarFines(Fin fin)
        {

            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_ModificarFines(?,?,?)", cn);

            try
            {
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idFin", fin.idFin);
                cm.Parameters.AddWithValue("_descFin", fin.descFin);
                cm.Parameters.AddWithValue("_estado", Convert.ToByte(fin.estado));

                cn.Open();
                if (cm.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Error al intentar Modificar Fin");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static String EliminarFin(int idFin)
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_EliminarFin(?)", cn);

            try
            {
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idFin", idFin);

                cn.Open();
                try
                {
                    if (cm.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Error al intentar eliminar Fin");
                    }
                }
                catch (OdbcException oEx)
                {
                    return "No se puede Eliminar Fin.";
                }
                return "";
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static DataSet TraerFines()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            DataSet dsFines = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerFines", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dsFines);
                return dsFines;
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

        public static DataSet TraerFinesEstado()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            DataSet dsFines = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerFinesEstado", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dsFines);
                return dsFines;
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

        public static DataSet TraerFinesActivos()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());

            DataSet dsFines = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerFinesActivos", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dsFines);

                return dsFines;

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
        public static DataSet TraerFinesInactivos()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());

            DataSet dsFines = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerFinesInactivos", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dsFines);

                return dsFines;

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


        #endregion

        #region Metodos Partido

        public static void AgregarPartido(Partido partido)
        { 
			try
			{
			}
			catch(Exception ex)
			{
				throw ex;
			}

		}


        public static void ModificarPartido(Partido partido)
        { 
			try
			{
			}
			catch(Exception ex)
			{
				throw ex;
			}

		}

        public static void EliminarPartido(int idPartido)
        {
			try
			{
			}
			catch(Exception ex)
			{
				throw ex;
			}

        }

        public static DataSet TraerPartidos()
        {
              OdbcConnection cn = null;
                
			try
			{
             cn = new OdbcConnection(Negocio.NegocioBase.getConnectionString());
             DataSet dsPartidos = new DataSet();
             OdbcDataAdapter da = new OdbcDataAdapter("call SP_getPartidos", cn);
             da.SelectCommand.CommandType = CommandType.StoredProcedure;
             da.Fill(dsPartidos);

             return dsPartidos;

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

        #endregion

        #region Metodos Persona
        public static void AgregarPersona(Persona persona)
        { 

            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_InsertarPersonas(?,?,?)", cn);

			try
			{
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idPersona", persona.idPersona);
                cm.Parameters.AddWithValue("_nombre", persona.nombrePersona);
                cm.Parameters.AddWithValue("_estado", persona.estado);
                cn.Open();

                if (cm.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Error al intentar guardar una Persona");
                }

			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public static int TraerIdPersona()
        {
            OdbcConnection cn = null;
            OdbcCommand cm = new OdbcCommand();
            int Cod;

            try
            {
                cn = new OdbcConnection(NegocioBase.getConnectionString());
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "call SP_TraerIdPersona()";
                cm.Connection = cn;
                cn.Open();
                Cod = cm.ExecuteScalar() != DBNull.Value ? int.Parse(cm.ExecuteScalar().ToString()) + 1 : 1;
                return Cod;

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

        public static void ModificarPersona(Persona persona)
        {

            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_ModificarPersona(?,?,?)", cn);


			try
			{
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idPersona", persona.idPersona);
                cm.Parameters.AddWithValue("_nombre", persona.nombrePersona);
                cm.Parameters.AddWithValue("_estado", Convert.ToByte(persona.estado));

                cn.Open();
                if (cm.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Error al intentar Modificar Persona");
                }
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public static String EliminarPersona(int idPersona)
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_EliminarPersona(?)", cn);

            try
        {
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idPersona", idPersona);

                cn.Open();
			try
			{
                    if (cm.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Error al intentar eliminar Persona");
                    }
                }
                catch (OdbcException oEx)
                {
                    return "No se puede Eliminar Persona.";
                }
                return "";
			}
			catch(Exception ex)
			{
				throw ex;
			}

        }

        public static DataSet TraerPersonas()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            DataSet dsPersonas = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerPersonas", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dsPersonas);

                return dsPersonas;

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

        public static DataSet TraerPersonasEstado()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            DataSet dsPersonas = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerPersonasEstado", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dsPersonas);

                return dsPersonas;

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

        public static DataSet TraerPersonasActivas()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());

            DataSet dsPersonas = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerPersonasActivas", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dsPersonas);

                return dsPersonas;

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
        public static DataSet TraerPersonasInactivas()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());

            DataSet dsPersonas = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerPersonasInactivas", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dsPersonas);

                return dsPersonas;

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

        #endregion

        #region Metodos TipoDenuncia
        public static void AgregarTipoDenuncia(TipoDenuncia tipodenuncia)
        { 

            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_InsertarTipoDenuncia(?,?,?)", cn);

			try
			{
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idTipoDenuncia", tipodenuncia.idTipoDenuncia);
                cm.Parameters.AddWithValue("_descTipoDenuncia", tipodenuncia.descTipoDenuncia);
                cm.Parameters.AddWithValue("_estado", tipodenuncia.estado);
                cn.Open();

                if (cm.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Error al intentar guardar un tipo de denuncia");
                }

			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public static int TraerIdTipoDenuncia()
        {
            OdbcConnection cn = null;
            OdbcCommand cm = new OdbcCommand();
            int Cod;

            try
            {
                cn = new OdbcConnection(NegocioBase.getConnectionString());
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "call SP_TraerIdTipoDenuncia()";
                cm.Connection = cn;
                cn.Open();
                Cod = cm.ExecuteScalar() != DBNull.Value ? int.Parse(cm.ExecuteScalar().ToString()) + 1 : 1;
                return Cod;

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

        public static void ModificarTipoDenuncia(TipoDenuncia tipodenuncia)
        { 

            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_ModificarTiposDenuncias(?,?,?)", cn);


			try
			{
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idTipoDenuncia", tipodenuncia.idTipoDenuncia);
                cm.Parameters.AddWithValue("_descTipoDenuncia", tipodenuncia.descTipoDenuncia);
                cm.Parameters.AddWithValue("_estado", Convert.ToByte(tipodenuncia.estado));

                cn.Open();
                if (cm.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Error al intentar Modificar Tipo de Denuncia");
                }
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public static String EliminarTipoDenuncia(int idTipoDenuncia)
        { 
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_EliminarTipoDenuncia(?)", cn);
            
            try
            {
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idTipoDenuncia", idTipoDenuncia);

                cn.Open();
			try
			{
                    if (cm.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Error al intentar eliminar Tipo de Denuncia");
                    }
                }
                catch (OdbcException oEx)
                {
                    return "No se puede Eliminar este tipo de denuncia.";
                }
                return "";
			}
			catch(Exception ex)
			{
				throw ex;
			}

        }

        public static DataSet TraerTipoDenuncias()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());

            DataSet dsTipoDenuncias = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerTipoDenunciaEstado", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dsTipoDenuncias);

                return dsTipoDenuncias;

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

        public static DataSet TraerTipoDenunciaActivas()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());

            DataSet dsTipoDenuncias = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerActivosAreas", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dsTipoDenuncias);

                return dsTipoDenuncias;

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
        public static DataSet TraerTipoDenunciaInactivas()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());

            DataSet dsTiposDenuncias = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerTipoDenunciaInactivas", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dsTiposDenuncias);

                return dsTiposDenuncias;

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
        
        //Agregado Hugo
        public static TipoDenuncia TraerTipoDenunciaPorId(int idTipoDenuncia)
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            DataSet dsTipoDenuncia = new DataSet();

            OdbcParameter parametro = new OdbcParameter();
            parametro.Direction = ParameterDirection.Input;
            parametro.DbType = DbType.Int32;
            parametro.ParameterName = "_idTipoDenuncia";


            TipoDenuncia tipoDenuncia = new TipoDenuncia();
            tipoDenuncia.idTipoDenuncia = idTipoDenuncia;

            try
            {
                OdbcDataAdapter dataAdapter = new OdbcDataAdapter("call sp_TraerTipoDenunciaPorId(?)", cn);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                parametro.Value = idTipoDenuncia;
                dataAdapter.SelectCommand.Parameters.Add(parametro);
                
                cn.Open();
                
                dataAdapter.Fill(dsTipoDenuncia);

                if (dsTipoDenuncia.Tables.Count > 0)
                {
                    if (dsTipoDenuncia.Tables[0].Rows.Count > 0)
                    {
                        tipoDenuncia.descTipoDenuncia = dsTipoDenuncia.Tables[0].Rows[0][1].ToString();
                        tipoDenuncia.estado = Convert.ToBoolean(dsTipoDenuncia.Tables[0].Rows[0][2]);
                    }
                }


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

            return tipoDenuncia;
        }


        public static DataTable TraerTiposDenuncia()
        {

            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            DataSet dsTiposDenuncia = new DataSet();

            try
            {
                OdbcDataAdapter dataAdapter = new OdbcDataAdapter("call SP_TraerTiposDenuncia", cn);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.Fill(dsTiposDenuncia);

                return dsTiposDenuncia.Tables[0];

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

        #endregion

        #region Metodos TipoDocumento

        public static void AgregarTipoDocumento(TipoDocumento tipoDocumento)
        { 
			try
			{
			}
			catch(Exception ex)
			{
				throw ex;
			}

		}

        public static void ModificarTipoDocumento(TipoDocumento tipoDocumento)
        { 
			try
			{
			}
			catch(Exception ex)
			{
				throw ex;
			}

		}

        public static void EliminarTipoDocumento(int idTipoDocumento)
        { 
			try
			{
			}
			catch(Exception ex)
			{
				throw ex;
			}

        }

        public static DataSet TraerTiposDocumentos()
        {
            //Modificado Hugo
            //OdbcConnection cn = new OdbcConnection("DRIVER={MySQL ODBC 5.1 Driver};SERVER=localhost;PORT=3306;DATABASE=defensor;UID=root;PWD=;OPTION=3");
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            DataSet dsTiposDoc = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_ObtenerTiposDocumento", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dsTiposDoc);

                return dsTiposDoc;

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

        //Agregado Hugo
        public static TipoDocumento TraerTipoDocumentoPorId(int idTipoDocumento)
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            DataSet dsTipoDocumento = new DataSet();

            OdbcParameter parametro = new OdbcParameter();
            parametro.Direction = ParameterDirection.Input;
            parametro.DbType = DbType.Int32;
            parametro.ParameterName = "_idTipoDocumento";
            


            TipoDocumento tipoDocumento = new TipoDocumento();
            tipoDocumento.idTipoDocumento = idTipoDocumento;

            try
            {
                OdbcDataAdapter dataAdapter = new OdbcDataAdapter("call sp_TraerTipoDocumentoPorId(?)", cn);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                parametro.Value = idTipoDocumento;
                dataAdapter.SelectCommand.Parameters.Add(parametro);
                cn.Open();
                dataAdapter.Fill(dsTipoDocumento);

                if (dsTipoDocumento.Tables.Count > 0)
                {
                    if (dsTipoDocumento.Tables[0].Rows.Count > 0)
                    {
                        tipoDocumento.descTipoDocumento = dsTipoDocumento.Tables[0].Rows[0][1].ToString();
                    }
                }


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

            return tipoDocumento;
        
        }   

        #endregion

        #region Metodos TipoMovimiento
        public static void AgregarTipoMovimiento(TipoMovimiento tipomovimiento)
        { 

            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_InsertarTipoMovimiento(?,?,?)", cn);

			try
			{
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idTipoMovimiento", tipomovimiento.idTipoMovimiento);
                cm.Parameters.AddWithValue("_descTipoMovimiento", tipomovimiento.descMovimiento);
                cm.Parameters.AddWithValue("_estado", tipomovimiento.estado);
                cn.Open();

                if (cm.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Error al intentar guardar un Tipo Movimiento");
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static int TraerIdTipoMovimiento()
        {
            OdbcConnection cn = null;
            OdbcCommand cm = new OdbcCommand();
            int Cod;

            try
            {
                cn = new OdbcConnection(NegocioBase.getConnectionString());
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "call SP_TraerIdTipoMovimiento()";
                cm.Connection = cn;
                cn.Open();
                Cod = cm.ExecuteScalar() != DBNull.Value ? int.Parse(cm.ExecuteScalar().ToString()) + 1 : 1;
                return Cod;

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




        public static void ModificarTipoMovimiento(TipoMovimiento tipomovimiento)
        {

            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_ModificarTiposMovimientos(?,?,?)", cn);


            try
            {
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idTipoMovimiento", tipomovimiento.idTipoMovimiento);
                cm.Parameters.AddWithValue("_descTipoMovimiento", tipomovimiento.descMovimiento);
                cm.Parameters.AddWithValue("_estado", Convert.ToByte(tipomovimiento.estado));

                cn.Open();
                if (cm.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Error al intentar Modificar Tipo Movimiento");
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static String EliminarTipoMovimiento(int idTipoMovimiento)
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_EliminarTipoMovimiento(?)", cn);

            try
            {
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idTipoMovimiento", idTipoMovimiento);

                cn.Open();
                try
                {
                    if (cm.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Error al intentar eliminar el tipo de movimiento");
                    }
                }
                catch (OdbcException oEx)
                {
                    return "No se puede Eliminar Tipo de movimiento.";
                }
                return "";
			}
			catch(Exception ex)
			{
				throw ex;
			}


        }
        public static DataSet TraerTiposMovimientosEstado()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());

            DataSet dsTipoMovimiento = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerTipoMovimientoEstado", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dsTipoMovimiento);

                return dsTipoMovimiento;

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

        public static DataSet TraerTipoMovimientoActivos()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());

            DataSet dsTipoMovimiento = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerTipoMovimientoActivos", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dsTipoMovimiento);

                return dsTipoMovimiento;

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
        public static DataSet TraerTipoMovimientoInactivos()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());

            DataSet dsTipoMovimientos = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerTipoMovimientoInactivos", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dsTipoMovimientos);

                return dsTipoMovimientos;

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

        public static DataSet TraerTiposMovimientos()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            DataSet dsTiposMovimientos = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerTipoMovimientos", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dsTiposMovimientos);

                return dsTiposMovimientos;

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

        #endregion

        #region Metodos TipoExpediente
        public static void AgregarTipoExpediente(TipoExpediente tipoexpediente)
        {

            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_InsertarTiposExpedientes(?,?,?)", cn);

			try
			{
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idTipoExpediente", tipoexpediente.idTipoExpediente);
                cm.Parameters.AddWithValue("_descTipoExpediente", tipoexpediente.descTipoExpediente);
                cm.Parameters.AddWithValue("_estado", tipoexpediente.estado);
                cn.Open();

                if (cm.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Error al intentar guardar un Tipo de Expediente");
                }

			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public static Byte TraerIdTipoExpediente()
        {
            OdbcConnection cn = null;
            OdbcCommand cm = new OdbcCommand();
            Byte Cod;

            try
            {
                cn = new OdbcConnection(NegocioBase.getConnectionString());
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "call SP_TraerIdTipoExpediente()";
                cm.Connection = cn;
                cn.Open();
                Cod = Convert.ToByte(cm.ExecuteScalar() != DBNull.Value ? int.Parse(cm.ExecuteScalar().ToString()) + 1 : 1);
                return Cod;

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

        public static void ModificarTipoExpediente(TipoExpediente tipoexpediente)
        { 

            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_ModificarTipoExpediente(?,?,?)", cn);


			try
			{
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idTipoExpediente",tipoexpediente.idTipoExpediente);
                cm.Parameters.AddWithValue("_descTipoExpediente",tipoexpediente.descTipoExpediente);
                cm.Parameters.AddWithValue("_estado", Convert.ToByte(tipoexpediente.estado));

                cn.Open();
                if (cm.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Error al intentar Modificar el tipo de expediente");
                }
			}
			catch(Exception ex)
			{
				throw ex;
			}
		}

        public static String EliminarTipoExpediente(int idTipoExpediente)
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_BorrarTipoExpediente(?)", cn);

            try
            {
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idTipoExpediente", idTipoExpediente);

                cn.Open();
                try
                {
                    if (cm.ExecuteNonQuery() == 0)
                    {
                        throw new Exception("Error al intentar eliminar El tipo de expediente");
                    }
                }
                catch (OdbcException oEx)
                {
                    return "No se puede Eliminar el tipo de expediente.";
                }
                return "";
            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
        public static DataSet TraerTipoExpedientes()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());

            DataSet dsTipoExpedientes = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerTipoExpedienteEstado", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dsTipoExpedientes);

                return dsTipoExpedientes;

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

        public static DataSet TraerTipoExpedienteActivos()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());

            DataSet dsTipoExpedientes = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerTipoExpedienteActivos", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dsTipoExpedientes);

                return dsTipoExpedientes;

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
        public static DataSet TraerTipoExpedienteInactivos()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());

            DataSet dsTipoExpedientes = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TipoExpedienteInactivos", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                da.Fill(dsTipoExpedientes);

                return dsTipoExpedientes;

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

        #endregion

        #region Metodos Localidad

        public static void AgregarLocalidad(Localidad localidad)
        { 
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_InsertarLocalidad(?,?,?,?)", cn);

			try
			{
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idLocalidad", localidad.idLocalidad);                
                cm.Parameters.AddWithValue("_codigoPostal", localidad.codigoPostal);
                cm.Parameters.AddWithValue("_desLocalidad", localidad.descLocalidad);
                cm.Parameters.AddWithValue("_idPartido", localidad.idPartido);

                cn.Open();
                if (cm.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Error al intentar guardar localidad");
                }
			}
			catch(Exception ex)
			{
				throw ex;
			}

		}

        public static void ModificarLocalidad(Localidad localidad)
        { 
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_ModificarLocalidad(?,?,?)", cn);

			try
			{
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idLocalidad", localidad.idLocalidad);
                cm.Parameters.AddWithValue("_codigoPostal", localidad.codigoPostal);
                cm.Parameters.AddWithValue("_desLocalidad", localidad.descLocalidad);
                
                cn.Open();
                if (cm.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Error al intentar modificar localidad");
                }
			}
			catch(Exception ex)
			{
				throw ex;
			}

		}

        public static string EliminarLocalidad(int idLocalidad)
        { 
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("call SP_EliminarLocalidad(?)", cn);

			try
			{
                cm.CommandType = CommandType.StoredProcedure;
                cm.Parameters.Clear();
                cm.Parameters.AddWithValue("_idLocalidad", idLocalidad);

                cn.Open();
                try
                {
                if (cm.ExecuteNonQuery() == 0)
                {
                    throw new Exception("Error al intentar eliminar localidad");
                }
			}
                catch (OdbcException oEx)
                {
                    return "No se puede Eliminar la Localidad."; 
                }
                return "";
            }
			catch(Exception ex)
			{
				throw ex;
			}

        }

        //Agregado Hugo
        public static DataTable TraerLocalidades()
        {
            //sp_TraerLocalidades
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            DataSet dsLocalidades = new DataSet();
            
            try
            {
                OdbcDataAdapter dataAdapter = new OdbcDataAdapter("call SP_TraerLocalidades", cn);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.Fill(dsLocalidades);

                return dsLocalidades.Tables[0];

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

        public static DataSet TraerLocalidadesPorPartido(int idPartido)
        {
            OdbcConnection cn = null;
            try
            {
                cn = new OdbcConnection(NegocioBase.getConnectionString());
                DataSet dsLocalidades = new DataSet();
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_TraerLocalidadesPorPartido(?)", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.SelectCommand.Parameters.AddWithValue("_idPartido",idPartido);
                da.Fill(dsLocalidades);

                return dsLocalidades;
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


        public static int TraerProxIDLoc()
        {
            OdbcConnection cn = null;
            OdbcCommand cm = new OdbcCommand();
            int idLoc;
            try
            {
                cn = new OdbcConnection(NegocioBase.getConnectionString());
                cm.CommandType = CommandType.StoredProcedure;
                cm.CommandText = "call SP_TraerProxIDLoc()";
                cm.Connection = cn;
                cn.Open();
                idLoc = int.Parse(cm.ExecuteScalar().ToString());
                return idLoc;
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

        //Agregado Hugo
        public static Localidad TraerLocalidadPorId(int idLocalidad)
        {
            //sp_TraerLocalidadPorId
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            DataSet dsLocalidades = new DataSet();
            OdbcParameter parametro = new OdbcParameter("_idLocalidad", idLocalidad);
            Localidad localidad = new Localidad();
            localidad.idLocalidad = idLocalidad;

            try
            {
                OdbcDataAdapter dataAdapter = new OdbcDataAdapter("call sp_TraerLocalidadPorId(?)", cn);
                dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
                dataAdapter.SelectCommand.Parameters.Add(parametro);
                
                cn.Open();
                dataAdapter.Fill(dsLocalidades);

                if (dsLocalidades.Tables.Count > 0)
                {
                    if (dsLocalidades.Tables[0].Rows.Count > 0)
                    {
                        localidad.codigoPostal = Convert.ToInt32(dsLocalidades.Tables[0].Rows[0][1]);
                        localidad.descLocalidad = dsLocalidades.Tables[0].Rows[0][2].ToString();
                        localidad.idPartido = Convert.ToByte(dsLocalidades.Tables[0].Rows[0][3]);
                    }
                }

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

            return localidad;
        }



        public static DataSet TraerLocalidadesVteLopez()
        {
            OdbcConnection cn = new OdbcConnection(NegocioBase.getConnectionString());
            DataSet dsLocalidades = new DataSet();
            try
            {
                OdbcDataAdapter da = new OdbcDataAdapter("call SP_ObtenerLocalidadesVteLopez", cn);
                da.SelectCommand.CommandType = CommandType.StoredProcedure;
                da.Fill(dsLocalidades);

                return dsLocalidades;

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

        #endregion  

    }
}
