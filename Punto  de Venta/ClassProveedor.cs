using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta
{
    class ClassProveedor
    {
        //FrameBD Datos = new FrameBD("localhost", 3308, "root", "admin", "punto_venta");
        FrameBD Datos = new FrameBD("localhost", 3308, "root", "12345", "punto_venta");

        public void FiltrarDatos(DataGridView Proveedor, string BusquedaProve)
        {
            //Busqueda de vista de datos
            string Busqueda = "SELECT id_provedor AS 'Codigo provedor', nombre AS Nombre, rfc AS RFC, telefono AS Telefono, direccion AS Direccion, ciudad AS Ciudad, codigo_postal AS 'Codigo postal'" +
                "FROM proveedor WHERE nombre Like'" + BusquedaProve + "%'";
            Proveedor.DataSource = Datos.SQLSEL(Busqueda);
            Proveedor.DataMember = "datos";
        }

        public void ActualizarProve(string id_provedor, string nombre, string rfc, string telefono, string direccion, string ciudad, int codigo_postal)
        {
            string Actualiza = "UPDATE proveedor SET id_provedor='" + id_provedor + "', nombre='" + nombre + "', rfc='" + rfc + "', telefono='" + telefono + "', direccion='" + direccion + "', ciudad=" + ciudad +"', codigo_postal="+ codigo_postal + " WHERE id_provedor =" + id_provedor;

            Datos.SQLIDU(Actualiza);

        }

        public void AgregarClientes(string id_provedor, string nombre, string rfc, string telefono, string direccion, string ciudad, int codigo_postal)
        {
            string InsercioDatos = "INSERT INTO proveedor VALUES('" + id_provedor + "','" + nombre + "','" + rfc + "','" + telefono + "','" + direccion + "','" + ciudad + "','" + codigo_postal +"')";

            Datos.SQLSEL(InsercioDatos);


        }

        public void EliminarClientes(string Clave)
        {
            string Eliminar = "DELETE FROM proveedor WHERE id_provedor='" + Clave + "'";
            Datos.SQLIDU(Eliminar);
        }
    }
}
