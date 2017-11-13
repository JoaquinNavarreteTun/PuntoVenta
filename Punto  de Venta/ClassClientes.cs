using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta
{
    class ClassClientes
    {
        FrameBD Datos = new FrameBD("localhost", 3308, "root", "admin", "punto_venta");
        //FrameBD Datos = new FrameBD("localhost", 3308, "root", "12345", "punto_venta");

        public void FiltrarDatos(DataGridView Clientes, string BusquedaProd)
        {
            //Busqueda de vista de datos
            string Busqueda = "SELECT id_clientes AS 'Codigo cliente', nombre AS Nombre, apellido_pa AS 'Apellido paterno', apellido_ma AS ' Apellido materno', direccion AS Direccion, municipio AS Municipio"+
                "FROM clientes WHERE Nombre Like'" + BusquedaProd + "%'";
            Clientes.DataSource = Datos.SQLSEL(Busqueda);
            Clientes.DataMember = "datos";
        }

        public void ActualizarClientes(int id_clientes, string nombre, string apellido_pa, string apellido_ma, string direccion, string municipio)
        {
            string Actualiza = "UPDATE clientes SET id_clientes='" + id_clientes + "', nombre='" + nombre + "', apellido_pa='" + apellido_pa + "', apellido_ma='" + apellido_ma + "', direccion='" + direccion + "', municipio=" + municipio + " WHERE id_clientes =" + id_clientes;

            Datos.SQLIDU(Actualiza);

        }

        public void AgregarClientes(int id_clientes, string nombre, string apellido_pa, string apellido_ma, string direccion, string municipio)
        {
            string InsercioDatos = "INSERT INTO clientes VALUES('" + id_clientes + "','" + nombre + "','" + apellido_pa + "','" + apellido_ma + "','" + direccion + "','" + municipio + "')";

            Datos.SQLSEL(InsercioDatos);


        }

        public void EliminarClientes(int Clave)
        {
            string Eliminar = "DELETE FROM clientes WHERE id_clientes='" + Clave + "'";
            Datos.SQLIDU(Eliminar);
        }

        //Llenar combobox
        public void LlenarClientes(ComboBox CmdClientes)
        {
            string consulta;

            consulta = "SELECT *" +
                          "FROM clientes";

            CmdClientes.DataSource = Datos.SQLCOMBO(consulta);
            CmdClientes.ValueMember = "id_clientes";
            CmdClientes.DisplayMember = "nombre";

        }
    }
}
