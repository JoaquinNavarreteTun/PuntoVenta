using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta
{
    class ClassMarca
    {
        //FrameBD Datos = new FrameBD("localhost", 3308, "root", "12345", "punto_venta");
        FrameBD Datos = new FrameBD("localhost", 3308, "root", "admin", "punto_venta");

        public void FiltrarDatos(DataGridView Departamento, string BusquedaMarca)
        {
            //Busqueda de vista de datos
            string Busqueda = "SELECT * FROM marca WHERE tipo Like'" + BusquedaMarca + "%'";
            Departamento.DataSource = Datos.SQLSEL(Busqueda);
            Departamento.DataMember = "datos";
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

        //Llenar combobox
        public void LlenarMarca(ComboBox CmdMarca)
        {
            string consulta;

            consulta = "SELECT *" +
                          "FROM marca";

            CmdMarca.DataSource = Datos.SQLCOMBO(consulta);
            CmdMarca.ValueMember = "id_marca";
            CmdMarca.DisplayMember = "tipo";
            
        }
    }
}
