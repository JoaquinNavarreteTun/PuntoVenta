using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta
{
    class ClassPromocion
    {
        FrameBD Datos = new FrameBD("localhost", 3308, "root", "admin", "punto_venta");
        //FrameBD Datos = new FrameBD("localhost", 3308, "root", "12345", "punto_venta");

        public void FiltrarDatos(DataGridView Promocion, string BusquedaProd)
        {
            //Busqueda de vista de datos
            string Busqueda = "SELECT id_promocion AS 'Codigo promocion',nom_paquete 'Nombre paquete', precio AS Precio, producto AS Producto,"+
                              " descuento AS Descuento, precio_descuento AS 'Precio descuento'"+
                              "FROM clientes WHERE Nombre Like'" + BusquedaProd + "%'";
            Promocion.DataSource = Datos.SQLSEL(Busqueda);
            Promocion.DataMember = "datos";
        }

        public void ActualizarPromocion(string id_promocion, string nom_paquete, int precio, string producto, float descuento, float precioDescuento)
        {
            string Actualiza = "UPDATE promocion SET id_promocion='" + id_promocion + "', nom_paquete='" + nom_paquete + "', precio='" + precio + "', producto='" + producto + "', descuento='" + descuento + "', precio_descuento=" + precioDescuento + " WHERE id_promocion =" + id_promocion;

            Datos.SQLIDU(Actualiza);

        }

        public void AgregarClientes(string id_promocion, string nom_paquete, int precio, string producto, float descuento, float precio_descuento)
        {
            string InsercioDatos = "INSERT INTO promocion VALUES('" + id_promocion + "','" + nom_paquete + "','" + precio + "','" + producto + "','" + descuento + "','" + precio_descuento + "')";

            Datos.SQLSEL(InsercioDatos);


        }

        public void EliminarClientes(string Clave)
        {
            string Eliminar = "DELETE FROM promocion WHERE id_promocion='" + Clave + "'";
            Datos.SQLIDU(Eliminar);
        }
    }
}
