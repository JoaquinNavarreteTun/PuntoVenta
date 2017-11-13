using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace PuntodeVenta
{
   
  class FrameBD
    {
        //string ser;
        //string por;
        //string pas;
        //string use;
        //string db;
        MySqlConnection conex = new MySqlConnection();
       
        private string servidor;
        private uint puerto;
        private string usuario;
        private string password;
        private string bd;

      public FrameBD(string servidor, uint puerto, string usuario, string password, string bd)
        {
            // TODO: Complete member initialization
            this.servidor = servidor;
            this.puerto= puerto;
            this.usuario= usuario;
            this.password= password;
            this.bd= bd;


            conex.Close();
            MySqlConnectionStringBuilder conexs = new MySqlConnectionStringBuilder();
            conexs.Server = servidor;
            conexs.Port = puerto;//Convert.ToUInt32(por);
            conexs.Password = password; //pas;
            conexs.UserID = usuario; //use;
            conexs.Database = bd;

            //MySqlConnection conex = new MySqlConnection(conexs.ToString() );
            conex.ConnectionString = conexs.ConnectionString;
            //MySqlConnection conn = new MySqlConnection(builder.ToString());


            conex.Open(); 
            
        }
         
      public void conectar() 
        {
            conex.Close(); 
            conex.Open(); 
              
        }


      public  DataSet SQLSEL(string sql)
      {
          conectar();

          MySqlDataAdapter Adaptador = new MySqlDataAdapter(sql, conex);
          DataSet RsDatos = new DataSet();
          Adaptador.Fill(RsDatos, "datos");
          //SQLSEL = RsDatos;
          return (RsDatos);
          //conex.Close(); 
      }

      //TRABAJA CON COMBOBOX

      public DataTable SQLCOMBO(string sql) 
      {
          conectar();
          MySqlDataAdapter Adap = new MySqlDataAdapter(sql,conex);
          DataTable DT = new DataTable();
          Adap.Fill(DT);
          return DT;
 
      }

      //Permite ejecutar comandos INSERT, DELETE Y UPDATE
      // De ahi deriva el IDU
      public void SQLIDU(string sql) 
      {
          try
          {
              conectar();
              MySqlCommand comando = new MySqlCommand(sql, conex);
              comando.ExecuteNonQuery();
              //conex.Close();

          }
          catch (MySqlException) 
          {
              
              throw;
          }
          
      }

      public MySqlDataReader SQLReader(string sql) 
      {
          conectar();
          MySqlCommand comando = new MySqlCommand(sql, conex);
          
         MySqlDataReader Dr = comando.ExecuteReader();
          return Dr;


      }




      
      /*
       *Public Function SQLREADER(ByVal sql) As MySqlDataReader
        Try
            conectar()
            Dim comando As New MySqlCommand(sql, conex)
            Dim Dr As MySqlDataReader
            Dr = comando.ExecuteReader()
            Return Dr
            conex.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Function
       */

      


    }





}
