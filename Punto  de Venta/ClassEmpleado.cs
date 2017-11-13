using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta
{
    class ClassEmpleado
    {
        FrameBD Datos = new FrameBD("localhost", 3308, "root", "admin", "punto_venta");
        //FrameBD Datos = new FrameBD("localhost", 3308, "root", "12345", "punto_venta");

        public void FiltrarDatos(DataGridView Empleados, string BusquedaEmple)
        {
            //Busqueda de vista de datos
            string Busqueda = "SELECT id_empleado AS 'Codigo empleado', nombre AS Nombre, apellidos AS 'Apellidos', edad AS 'Edad', usuario AS Usuario, contrasenia AS Contraseña, nivel_trabajo AS 'Nivel de trabajo'" +
                " FROM empleados WHERE estado='1' AND nombre Like'" + BusquedaEmple + "%'";
            Empleados.DataSource = Datos.SQLSEL(Busqueda);
            Empleados.DataMember = "datos";
        }

        public void ActualizarEmplead(int id_empleado, string nombre, string apellidos, int edad, string usuario, string contrasenia, string nivel_trabajo)
        {
            string Actualiza = "UPDATE empleados SET nombre='" + nombre + "', apellidos='" + apellidos + "', edad='" + edad + "', usuario='" + usuario + "', contrasenia='" + contrasenia + "', nivel_trabajo='" + nivel_trabajo + "' WHERE id_empleado =" + id_empleado;

            Datos.SQLIDU(Actualiza);

        }

        public void AgregarEmple(string nombre, string apellidos, int edad, string usuario, string contrasenia, string nivel_trabajo)
        {
            string InsercioDatos = "INSERT INTO empleados(nombre,apellidos,edad,usuario,contrasenia,nivel_trabajo,estado) VALUES('" + nombre + "','" + apellidos + "','" + edad + "','" + usuario + "','" + contrasenia +"','"+ nivel_trabajo +"',1)";

            Datos.SQLSEL(InsercioDatos);


        }

        public void EliminarEmple(string Clave)
        {
            string Eliminar = "UPDATE empleados SET estado=1 WHERE id_empleado='"+ Clave + "'";
            Datos.SQLIDU(Eliminar);
        }

        public void FiltrarPersonalLogin(DataGridView DatosEmpleados)
        {
            string Buscar = "SELECT * FROM empleados";
            DatosEmpleados.DataSource = Datos.SQLSEL(Buscar);
            DatosEmpleados.DataMember = "datos";
        }
    }
}
