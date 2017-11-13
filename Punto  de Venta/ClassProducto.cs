using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta
{
    class ClassProducto
    {
        //FrameBD Datos = new FrameBD("localhost", 3308, "root", "12345", "punto_venta");
        FrameBD Datos = new FrameBD("localhost", 3308, "root", "admin", "punto_venta");

        public void FiltrarDatos(DataGridView Productos, string BusquedaProd)
        {
            //Busqueda de vista de datos
            string Busqueda = "SELECT productos.id_producto AS 'Codigo producto', departamento.id_departamento as 'Codigo departamento', marca.id_marca as 'Codigo marca', departamento.departamento AS Despartamento, marca.tipo AS Tipo,"+
			 "productos.nombre AS Nombre, productos.descripcion AS Descripcion, productos.precio_compra AS 'Precio compra',"+
			 "productos.precio_venta AS 'Precio venta', productos.fecha AS Fecha, productos.stockmin AS Stockim"+
            " FROM productos INNER JOIN departamento ON productos.id_departamento=departamento.id_departamento "+
		    "INNER JOIN marca ON productos.id_marca=marca.id_marca " +
            "WHERE productos.Nombre Like'" + BusquedaProd + "%'";
            Productos.DataSource = Datos.SQLSEL(Busqueda);
            Productos.DataMember = "datos";
        }

        public void ActualizarProductos( int IdProducto, string idDepartamento, string IdMarca, string Nombre, string Descripcion, float PrecioCompra, float PrecioVenta, string Fecha, int stockmin)
        {
            string Actualiza = "UPDATE productos SET id_departamento='" + idDepartamento + "', id_marca='" + IdMarca + "', nombre='" + Nombre + "', descripcion='" + Descripcion + "', precio_compra='" + PrecioCompra +
                "', precio_venta='"+ PrecioVenta +"', fecha='"+ Fecha +"', stockmin="+ stockmin + " WHERE id_producto =" + IdProducto;

            Datos.SQLIDU(Actualiza);

        }

        public void AgregarProd(string idDepartamento, string IdCategoria, string Nombre, string Descripcion, float PrecioCompra, float PrecioVenta, string Fecha, int stockmin)
        {
            string InsercioDatos = "INSERT INTO productos(id_departamento,id_marca,nombre,descripcion,precio_compra,precio_venta,fecha,estado,stockmin)"+
            "VALUES('"+ idDepartamento + "','" + IdCategoria + "','" + Nombre + "','"+ Descripcion +"','"+ PrecioCompra +"','"+ PrecioVenta +"','"+ Fecha +"','"+ "1" +"','"+ stockmin +"')";

            Datos.SQLSEL(InsercioDatos);


        }

        public void EliminarProducto(string Clave)
        {
            string Eliminar = "DELETE FROM productos WHERE id_producto='" + Clave + "'";
            Datos.SQLIDU(Eliminar);
        }

    }
}
