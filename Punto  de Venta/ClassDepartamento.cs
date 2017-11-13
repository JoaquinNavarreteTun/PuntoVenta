using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta
{
    class ClassDepartamento
    {
        //FrameBD Datos = new FrameBD("localhost", 3308, "root", "12345", "punto_venta");
        FrameBD Datos = new FrameBD("localhost", 3308, "root", "admin", "punto_venta");

        public void FiltrarDatos(DataGridView Departamento, string BusquedaDepa)
        {
            //Busqueda de vista de datos
            string Busqueda = "SELECT * FROM departamento WHERE departamento Like'" + BusquedaDepa + "%'";
            Departamento.DataSource = Datos.SQLSEL(Busqueda);
            Departamento.DataMember = "datos";
        }

        public void ActualizarDepa(int Id_depa, string departamento, string descripcion)
        {
            string Actualiza = "UPDATE departamento SET departamento='" + departamento + "', descripcion='" + descripcion + "' WHERE id_departamento =" + Id_depa;

            Datos.SQLIDU(Actualiza);

        }

        public void AgregarDepa(string departamento, string descripcion)
        {
            string InsercioDatos = "INSERT INTO departamento(departamento,descripcion) VALUES('" + departamento + "','" + descripcion + "')";

            Datos.SQLSEL(InsercioDatos);


        }

        public void EliminarDepa(string Clave)
        {
            string Eliminar = "DELETE FROM departamento WHERE id_departamento='" + Clave + "'";
            Datos.SQLIDU(Eliminar);
        }

        //Llenar combobox
        public void LlenarDepa(ComboBox CmbDepa)
        {
            string consulta;

            consulta = "SELECT *" +
                          "FROM departamento";

            CmbDepa.DataSource = Datos.SQLCOMBO(consulta);
            CmbDepa.ValueMember = "id_departamento";
            CmbDepa.DisplayMember = "departamento";

        }
    }
}
