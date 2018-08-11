using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Odbc;
using Entidades;
using System.Configuration;


namespace Negocio
{
    public class NegocioContactos
    {
        public static DataSet TraerTelefonosDenunciante(int idDenunciante)
        {
                OdbcConnection cnn = new OdbcConnection(NegocioBase.getConnectionString());
                OdbcDataAdapter da = new OdbcDataAdapter("", cnn);                
                try
                {

                    DataSet dsTel = new DataSet();
                    
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.SelectCommand.CommandText = "SELECT ID,CONTACTO FROM CONTACTOS WHERE TIPOCONTACTO = 'T' AND IDDENUNCIANTE ="+idDenunciante;
                    
                    cnn.Open();
                    
                    da.Fill(dsTel);

                    return dsTel;
                                    

            }
            catch(Exception ex)
            {
                throw new Exception("Error al cargar telefonos");
            }
            
       }

        public static DataSet TraerCelularesDenunciante(int idDenunciante)
        {
            OdbcConnection cnn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcDataAdapter da = new OdbcDataAdapter("", cnn);
            try
            {

                DataSet dsCel = new DataSet();

                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.CommandText = "SELECT ID,CONTACTO FROM CONTACTOS WHERE TIPOCONTACTO = 'C' AND IDDENUNCIANTE =" + idDenunciante;

                cnn.Open();

                da.Fill(dsCel);


                return dsCel;


            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar celulares");
            }

        }

        public static DataSet TraerEmailsDenunciante(int idDenunciante)
        {
            OdbcConnection cnn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcDataAdapter da = new OdbcDataAdapter("", cnn);
            try
            {

                DataSet dsMails = new DataSet();

                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.CommandText = "SELECT ID,CONTACTO FROM CONTACTOS WHERE TIPOCONTACTO = 'E' AND IDDENUNCIANTE =" + idDenunciante;

                cnn.Open();

                da.Fill(dsMails);


                return dsMails;


            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar Mails");
            }

        }


        public static string TraerTelefonoActivo(int idDenunciante)
        {
            OdbcConnection cnn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("", cnn);
            string Tel = "";
            
            try
            {

                cm.CommandType = CommandType.Text;
                cm.CommandText = "SELECT CONTACTO FROM CONTACTOS WHERE TIPOCONTACTO = 'T' AND ACTIVO = 1 AND IDDENUNCIANTE =" + idDenunciante.ToString();

                cnn.Open();

                if(cm.ExecuteScalar() != null)
                    Tel = cm.ExecuteScalar().ToString();

                return Tel;


            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer el telefono activo");
            }

        }

        public static string TraerCelularActivo(int idDenunciante)
        {
            OdbcConnection cnn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("", cnn);
            string Cel = "";

            try
            {

                cm.CommandType = CommandType.Text;
                cm.CommandText = "SELECT CONTACTO FROM CONTACTOS WHERE TIPOCONTACTO = 'C' AND ACTIVO = 1 AND IDDENUNCIANTE =" + idDenunciante.ToString();

                cnn.Open();

                if(cm.ExecuteScalar() != null)
                    Cel = cm.ExecuteScalar().ToString();

                return Cel;


            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer el Celular activo");
            }

        }


        public static string TraerMailActivo(int idDenunciante)
        {
            OdbcConnection cnn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("", cnn);
            string Mail = "";

            try
            {

                cm.CommandType = CommandType.Text;
                cm.CommandText = "SELECT CONTACTO FROM CONTACTOS WHERE TIPOCONTACTO = 'E' AND ACTIVO = 1 AND IDDENUNCIANTE =" + idDenunciante.ToString();

                cnn.Open();

                if(cm.ExecuteScalar() != null)
                    Mail = cm.ExecuteScalar().ToString();

                return Mail;


            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer el Mail activo");
            }

        }

        public static void AgregarContacto(string tipo,string newTel,int idDen)
        {
            OdbcConnection cnn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("", cnn);

            try
            {
                cm.CommandType = CommandType.Text;
                cnn.Open();

                cm.CommandText = "SELECT COUNT(*) FROM CONTACTOS WHERE TIPOCONTACTO ='"+ tipo  +"' AND IDDENUNCIANTE =" + idDen.ToString();
                string act = cm.ExecuteScalar().ToString() == "0" ? "1" : "0";  

                cm.CommandText = "INSERT INTO CONTACTOS VALUES(" + TraerProxId() + "," + idDen + ",'"+tipo+ "','" + newTel + "',"+ act +")";                

                cm.ExecuteNonQuery();                


            }
            catch(Exception ex)
            {
                throw new Exception("Error al insertar telefono");
            }

        }



        public static void ModificarContacto(string tipo,string newTel, int id)
        {
            OdbcConnection cnn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("", cnn);

            try
            {

                cm.CommandType = CommandType.Text;
                cm.CommandText = "UPDATE CONTACTOS SET CONTACTO ='" + newTel + "' WHERE ID =" + id.ToString() ;

                cnn.Open();

                cm.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception("Error al modificar el contacto");
            }

        }


        public static int TraerProxId()
        {
            OdbcConnection cnn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("", cnn);
            int id =0;

            try
            {

                cm.CommandType = CommandType.Text;
                cm.CommandText = "SELECT MAX(ID) FROM CONTACTOS";

                cnn.Open();

                if(cm.ExecuteScalar() != null)
                    id = int.Parse(cm.ExecuteScalar().ToString());

                return id + 1;


            }
            catch (Exception ex)
            {
                throw new Exception("Error al traer proximo id de contactos");
            }

        }


        public static void ActivarContacto(string idDen,int id,string tipo)
        {
            OdbcConnection cnn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("", cnn);

            try
            {
                cnn.Open();
                cm.CommandType = CommandType.Text;

                cm.CommandText = "UPDATE CONTACTOS SET ACTIVO = 0 WHERE IDDENUNCIANTE ='" + idDen + "'AND ACTIVO = 1 AND TIPOCONTACTO ='" + tipo + "'";
                cm.ExecuteNonQuery();

                cm.CommandText = "UPDATE CONTACTOS SET ACTIVO = 1 WHERE ID="+id.ToString();
                cm.ExecuteNonQuery();
                

            }
            catch (Exception ex)
            {
                throw new Exception("Error al activar telefono");
            }

        }

        public static void EliminarContacto(int id)
        {
            OdbcConnection cnn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("", cnn);

            try
            {
                cm.CommandType = CommandType.Text;
                cnn.Open();


                cm.CommandText = "DELETE FROM CONTACTOS WHERE ID=" + id.ToString(); 
                cm.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                throw new Exception("Error al eliminar telefono");
            }

        }


        public static bool VerificarTelActivo(int id)
        {
            OdbcConnection cnn = new OdbcConnection(NegocioBase.getConnectionString());
            OdbcCommand cm = new OdbcCommand("", cnn);

            try
            {
                cm.CommandType = CommandType.Text;
                cnn.Open();


                cm.CommandText = "SELECT ID FROM CONTACTOS WHERE TIPOCONTACTO = 'T' AND ACTIVO = 1";
                if (int.Parse(cm.ExecuteScalar().ToString()) == id)
                    return false;

                return true;

            }
            catch (Exception ex)
            {
                throw new Exception("Error al verificar telefono activo");
            }

        }





    }
}
