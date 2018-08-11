using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Collections.Generic;
using System.Text;
using System.Data.Odbc;
using Negocio;
using System.Web.UI.WebControls;
namespace Negocio
{
    public class NegocioConsultasPorInformantes
    {
        private OdbcConnection conexion = new OdbcConnection("DRIVER={MySQL ODBC 5.1 Driver};SERVER=localhost;PORT=3306;DATABASE=defensor;UID=root;PWD=;OPTION=3");
        private OdbcDataAdapter adaptador = new OdbcDataAdapter();
    public void CargarLista(ListBox lista, string procedimiento)
        {
            try
            {
                DataTable dt = SeleccionConReader(procedimiento);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    lista.Items.Add(dt.Rows[i].ItemArray[0].ToString());
                }
            }
            catch
            {
                throw;
            }
        }
    public DataTable MostrarPorInformantes(GridView tabla, RadioButtonList lista, ListBox informantes)
        {
            try
            {
                string consulta = "";
                if (lista.SelectedItem.Text == "Todos")
                {
                    consulta = "call SP_CI_VerTodos(?)";
                }
                else if (lista.SelectedItem.Text == "Archivados")
                {
                    consulta = "call SP_CI_VerArchivados(?)";
                }
                else
                {
                    consulta = "call SP_CI_VerNoArchivados(?)";
                }
                DataTable dt = this.SeleccionConReader("nombre", informantes.SelectedIndex + 1, consulta);
                tabla.DataSource = dt;
                tabla.DataBind();
                return dt;
            }
            catch
            {
                throw;
            }
        }
    public DataTable MostrarTodos(GridView tabla, RadioButtonList lista)
        {
            try
            {
                string consulta = "";
                if (lista.SelectedItem.Text == "Todos")
                {
                    consulta = "call SP_CI_VerTodosTodos";
                }
                else if (lista.SelectedItem.Text == "Archivados")
                {
                    consulta = "call SP_CI_VerArchivadosTodos";
                }
                else
                {
                    consulta = "call SP_CI_VerNoArchivadosTodos";
                }
                DataTable dt = this.SeleccionConReader(consulta); ;
                tabla.DataSource = dt;
                tabla.DataBind();
                return dt;
            }
            catch
            {
                throw;
            }
        }
    public DataTable SoloPaseInterno(GridView tabla, ListBox informantes, string consulta)
        {
            try
            {
                DataTable dt = this.SeleccionConReader("nombre", informantes.SelectedIndex + 1, consulta);
                tabla.DataSource = dt;
                tabla.DataBind();
                return dt;
            }
            catch
            {
                throw;
            }
        }
    public DataTable UltMovimiento(GridView tabla, ListBox informantes, string consulta)
        {
            try
            {
                DataTable dt = this.SeleccionConReader("nombre", informantes.SelectedIndex + 1, consulta);
                tabla.DataSource = dt;
                tabla.DataBind();
                return dt;
            }
            catch
            {
                throw;
            }
        }
    public int[] CargarVectorExpedientes(DataTable tabla)
        {
            try
            {
                int[] vector = new int[tabla.Rows.Count];
                for (int i = 0; i < tabla.Rows.Count; i++)
                {
                    vector.SetValue(Convert.ToInt16(tabla.Rows[i].ItemArray[0].ToString()), i);
                }
                return vector;
            }
            catch
            {
                throw;
            }
        }
    public int DeterminarPosicion(int [] vector, int expediente)
        {
            try
            {
                int posicion = 0;
                for (int i = 0; i < vector.Length; i++)
                {
                    int expediente1 = Convert.ToInt16(vector[i]);
                    if (expediente1 == expediente)
                    {
                        posicion = i;
                    }
                }
                return posicion;
            }
            catch
            {
                throw;
            }
        }
    public DataTable CargarPrincipalContactos(int expediente,string consulta)
        {
            try
            {
                return this.SeleccionConReader("expediente", expediente, consulta);
            }
            catch
            {
                throw;
            }
        }
    public DataTable CargarDataTableDenunciaContactos(int expediente,string consulta)
    {
        try
        {
            return this.SeleccionConReader("expediente", expediente, consulta);
        }
        catch
        {
            throw;
        }
    }
    public string CargarAreaInformante(int expediente, string consulta)
        {
            try
            {
                string area="";
                if (this.SeleccionConReader("expediente", expediente, consulta).Rows.Count > 0)
                {
                    area = this.SeleccionConReader("expediente", expediente, consulta).Rows[0].ItemArray[0].ToString();
                }              
                return area;
            }
            catch
            {
                throw;
            }
        }
    public void ColumnasMostrarPorInformantes_Todos( GridView tabla) 
    {
        try
        {
            tabla.Columns[8].Visible = false;
            tabla.Columns[3].Visible = true;
            tabla.Columns[4].Visible = true;
            tabla.Columns[5].Visible = true;
            tabla.Columns[7].Visible = true;
        }
        catch
        {
            throw;
        }
    }  
    public void ColumnasSoloPaseInterno( GridView tabla) 
    {
        try
        {
            tabla.Columns[8].Visible = false;
            tabla.Columns[3].Visible = false;
            tabla.Columns[4].Visible = false;
            tabla.Columns[5].Visible = false;
            tabla.Columns[7].Visible = false;
        }
        catch
        {
            throw;
        }
    }  
    public void ColumnasUltimoMovimiento( GridView tabla) 
    {
        try
        {
            tabla.Columns[8].Visible = true;
            tabla.Columns[3].Visible = false;
            tabla.Columns[4].Visible = false;
            tabla.Columns[5].Visible = false;
            tabla.Columns[7].Visible = false;
        }
        catch
        {
            throw;
        }
    }
    public DataTable SeleccionConReader(string nombreParametro,int expediente,string procedimiento)
        {
            try
            {
                OdbcDataAdapter dataAdapter = new OdbcDataAdapter(procedimiento, conexion);
                DataTable tabla = new DataTable();
                OdbcParameter parametro = new OdbcParameter();
                parametro.Direction = ParameterDirection.Input;
                parametro.ParameterName = nombreParametro;
                parametro.Value = expediente;
                parametro.OdbcType = OdbcType.Int;
                dataAdapter.SelectCommand.Parameters.Add(parametro);
                conexion.Open();
                OdbcDataReader reader = dataAdapter.SelectCommand.ExecuteReader();
                tabla.Load(reader);
                conexion.Close();
                return tabla;
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
    public DataTable SeleccionConReader(string procedimiento)
        {
            try
            {
                OdbcDataAdapter dataAdapter = new OdbcDataAdapter(procedimiento, conexion);
                DataTable tabla = new DataTable();
                conexion.Open();
                OdbcDataReader reader = dataAdapter.SelectCommand.ExecuteReader();
                tabla.Load(reader);
                conexion.Close();
                return tabla;
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
    public string ValorEscalar(string nombreParametro, int expediente, string procedimiento)
        {
            try
            {
                OdbcDataAdapter dataAdapter = new OdbcDataAdapter(procedimiento, conexion);
                OdbcParameter parametro = new OdbcParameter();
                parametro.Direction = ParameterDirection.Input;
                parametro.ParameterName = nombreParametro;
                parametro.Value = expediente;
                parametro.OdbcType = OdbcType.Int;
                dataAdapter.SelectCommand.Parameters.Add(parametro);
                conexion.Open();
                string valor = "";
                valor = dataAdapter.SelectCommand.ExecuteScalar().ToString();
                conexion.Close();
                return valor;
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
    }
}
