using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta
{
    class ClassDetalle_venta
    {
        //FrameBD Datos = new FrameBD("localhost", 3308, "root", "12345", "punto_venta");
        FrameBD Datos = new FrameBD("localhost", 3308, "root", "admin", "punto_venta");

        public void FiltrarDatos(DataGridView Detalle, string BusquedaDetalle)
        {
            //Busqueda de vista de datos
            string Busqueda = "SELECT * FROM marca WHERE tipo Like'" + BusquedaDetalle + "%'";
            Detalle.DataSource = Datos.SQLSEL(Busqueda);
            Detalle.DataMember = "datos";
        }

        public void ActualizarMarca(int Id_Marca, string tipo, string descripcion)
        {
            string Actualiza = "UPDATE marca SET id_marca='" + Id_Marca + "', tipo='" + tipo + "', descripcion='" + descripcion + "' WHERE id_marca=" + Id_Marca;

            Datos.SQLIDU(Actualiza);

        }

        public void AgregarMarca(string tipo, string descripcion)
        {
            string InsercioDatos = "INSERT INTO marca(tipo,descripcion) VALUES('" + tipo + "','" + descripcion + "')";

            Datos.SQLSEL(InsercioDatos);


        }

        public void EliminarMarca(string Clave)
        {
            string Eliminar = "DELETE FROM marca WHERE id_marca='" + Clave + "'";
            Datos.SQLIDU(Eliminar);
        }
    }
}
