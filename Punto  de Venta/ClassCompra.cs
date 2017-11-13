using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta
{
    class ClassCompra
    {
        FrameBD Datos = new FrameBD("localhost", 3308, "root", "admin", "punto_venta");
        //FrameBD Datos = new FrameBD("localhost", 3308, "root", "12345", "punto_venta");

        public void FiltrarDatos(DataGridView Compras, string BusquedaProd)
        {
            //Busqueda de vista de datos
            string Busqueda = "SELECT compra.id_compra AS 'Codigo compra', proveedor.nombre AS Proveedor, compra.nombre AS Producto, compra.precio, compra.cantidad, compra.total"+
            "FROM compra INNER JOIN proveedor ON compra.id_provedor=proveedor.id_provedor WHERE nombre Like'" + BusquedaProd + "%'";
            Compras.DataSource = Datos.SQLSEL(Busqueda);
            Compras.DataMember = "datos";
        }

        public void ActualizarClientes(string id_compras, string id_provedor, string nombre, float precio, int  cantidad, float total)
        {
            string Actualiza = "UPDATE compra SET id_compra='" + id_compras + "', id_provedor='" + id_provedor + "', nombre='"+ nombre +"', precio='" + precio + "', cantidad='" + cantidad + "', total=" + total + " WHERE id_producto =" + id_compras;

            Datos.SQLIDU(Actualiza);

        }

        public void AgregarClientes(string id_compras, string id_provedor, string nombre, float precio, int cantidad, float total)
        {
            string InsercioDatos = "INSERT INTO compra VALUES('" + id_compras + "','" + id_provedor + "','" + nombre + "','" + precio + "','" + cantidad + "','" + total + "')";

            Datos.SQLSEL(InsercioDatos);


        }

        public void EliminarClientes(string Clave)
        {
            string Eliminar = "DELETE FROM compra WHERE id_compra='" + Clave + "'";
            Datos.SQLIDU(Eliminar);
        }
    }
}
