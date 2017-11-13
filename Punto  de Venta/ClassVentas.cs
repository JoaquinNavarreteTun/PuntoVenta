using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta
{
    class ClassVentas
    {
        FrameBD Datos = new FrameBD("localhost", 3308, "root", "admin", "punto_venta");
        //FrameBD Datos = new FrameBD("localhost", 3308, "root", "12345", "punto_venta");

        public void FiltrarDatos(DataGridView Clientes, string BusquedaProd)
        {
            //Busqueda de vista de datos
            string Busqueda = "SELECT ventas.id_venta AS 'Codigo venta', promocion.nom_paquete AS 'Nombre paquete', clientes.nombre AS 'Nombre cliente',"+ 
                            "empleados.nombre AS 'Nombre empleado',"+
			                "ventas.fecha AS 'Fecha venta', ventas.cantidad AS Cantidad, ventas.total AS Total"+ 
                            " FROM ventas INNER JOIN promocion ON ventas.id_promocion=promocion.id_promocion"+ 
	       	                " INNER JOIN clientes ON clientes.id_clientes=ventas.id_clientes"+
                            " INNER JOIN empleados ON empleados.id_empleado=ventas.id_empleado WHERE ventas.nom_paquete Like'" + BusquedaProd + "%'";
            Clientes.DataSource = Datos.SQLSEL(Busqueda);
            Clientes.DataMember = "datos";
        }

        public void FiltrarPorFecha(DataGridView Clientes, string FechaIncio, string FechaFin)
        {
            //Busqueda de vista de datos
            string Busqueda = "SELECT ventas.id_venta AS 'Codigo venta', promocion.nom_paquete AS 'Nombre paquete', clientes.nombre AS 'Nombre cliente'," +
                            "empleados.nombre AS 'Nombre empleado'," +
                            "ventas.fecha AS 'Fecha venta', ventas.cantidad AS Cantidad, ventas.total AS Total" +
                            " FROM ventas INNER JOIN promocion ON ventas.id_promocion=promocion.id_promocion" +
                            " INNER JOIN clientes ON clientes.id_clientes=ventas.id_clientes" +
                            " INNER JOIN empleados ON empleados.id_empleado=ventas.id_empleado"+
                            " WHERE ventas.fecha BETWEEN '" + FechaIncio + "' AND '"+ FechaFin +"'";
            Clientes.DataSource = Datos.SQLSEL(Busqueda);
            Clientes.DataMember = "datos";
        }

        public void ActualizarVentas(string id_venta, string id_promocion, string id_clientes, string id_empleados, string fecha, int cantidad, float total)
        {
            string Actualiza = "UPDATE ventas SET id_venta='" + id_venta + "', nombre='" + id_promocion + "', apellido_pa='" + id_clientes + "', apellido_ma='" + id_empleados + "', direccion='" + fecha + "', municipio='" + cantidad + "', total=" + total + "WHERE id_venta =" + id_venta;

            Datos.SQLIDU(Actualiza);

        }

        public void AgregarVentas(string id_venta, string id_promocion, string id_clientes, string id_empleados, string fecha, int cantidad, float total)
        {
            string InsercioDatos = "INSERT INTO ventas VALUES('" + id_venta + "','" + id_promocion + "','" + id_clientes + "','" + id_empleados + "','" + fecha + "','" + cantidad + "','"+ total +"')";

            Datos.SQLSEL(InsercioDatos);


        }

        public void EliminarVentas(string Clave)
        {
            string Eliminar = "DELETE FROM ventas WHERE id_venta='" + Clave + "'";
            Datos.SQLIDU(Eliminar);
        }
    }
}
