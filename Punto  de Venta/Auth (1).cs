using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace PuntodeVenta
{

    
    class Auth
    {
        private string tabla;
        private string campousuario;
        private string campopass;
        private string valoruser;
        private string valorpass;
        private Boolean statususer;
        private Boolean statuspass;
        private string UsuarioQueAccede;
        private string NivelUsuarioAccede;


        //FrameBD TablaUser = new FrameBD("localhost", 3308, "root", "12345", "punto_venta");
        FrameBD TablaUser = new FrameBD("localhost", 3308, "root", "admin", "punto_venta");
        
        //Constructor de la clase
        public Auth(string tabla, string campousuario, string campopass,string valoruser,string valorpass)
        {
            this.tabla = tabla;
            this.campousuario = campousuario;
            this.campopass = campopass;
            this.valoruser = valoruser;
            this.valorpass = valorpass;

        }

        public void DatosUser()
        {

            string GetDatos = "SELECT " + campousuario + "," + campopass + ",nombre,apellidos,nivel_trabajo "  +
                              " FROM " + tabla + 
                              " WHERE " + campousuario + "='" + valoruser + "'";

            MySqlDataReader Drus = TablaUser.SQLReader(GetDatos);


        if (Drus.HasRows== true)
            {
            ExisteUsuario=true;
                while (Drus.Read())
                {
                    string pass= Drus.GetString(1);
                    string usuario = Drus.GetString(2) + " " + Drus.GetString(3);
                    string nivel = Drus.GetString(4);
                    this.UsuarioQueAccede = usuario;
                    this.NivelUsuarioAccede = nivel;
                    
                    if (pass==valorpass)
                    
                        PassOk = true;
                    else
                        PassOk=false;

                    
                        


                }
         
            }

        else
            ExisteUsuario=false;


            

        }


        public Boolean ExisteUsuario
        {
            get
            {
                return this.statususer;
            }
            set
            {
                this.statususer =value;
            }
        }


        public Boolean PassOk
        {
            get
            {
                return this.statuspass;
            }
            set
            {
                this.statuspass = value;
            }
        }


        public String QueUsuarioAccede
        {
            get
            {
                return this.UsuarioQueAccede;
            }

            set
            {
                this.UsuarioQueAccede=value;
            }

            
        }


        public String QueNivelUsuarioAccede
        {
            get
            {
                return this.NivelUsuarioAccede;
            }

            set
            {
                this.NivelUsuarioAccede = value;
            }


        }






    }

    


}
