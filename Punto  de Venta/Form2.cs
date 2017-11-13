using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuntodeVenta
{
    public partial class Form2 : Form
    {
        ClassProducto Productos = new ClassProducto();
        ClassDepartamento Departamento = new ClassDepartamento();
        ClassMarca Marca = new ClassMarca();
        ClassEmpleado Empleados = new ClassEmpleado();
        ClassVentas Ventas = new ClassVentas();
        ClassClientes Clientes = new ClassClientes();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            //Filtreo de datos
            Productos.FiltrarDatos(DgvProductos, TxtBuscarProductos.Text);
            Departamento.FiltrarDatos(Dgvdepartamentos, TxtBuscarDepartamento.Text);
            Marca.FiltrarDatos(DgvMarca, TxtBuscarmarca.Text);
            

            //Obteniendo folio y nombre de usuario
            Empleados.FiltrarDatos(DvgEmpleados, TxtFolioCajero.Text);
            TxtFolioCajero.Text = Convert.ToString(DvgEmpleados[0, DvgEmpleados.CurrentCellAddress.Y].Value);
            TxtClaveCajero.Text = Convert.ToString(DvgEmpleados[4, DvgEmpleados.CurrentCellAddress.Y].Value);

            //Llenando combobox de clientes
            Clientes.LlenarClientes(CmbClientes);

           
        }

        public void DatosAcceso(string user, string nivel)
        {
            this.TxtNombreCajero.Text = user;
            this.LblPuesto.Text = nivel;
        }

        private void BtnModificarProducto_Click(object sender, EventArgs e)
        {

        }

        private void BtnElimin_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void BtnModificarProd_Click(object sender, EventArgs e)
        {
            
            GrbProductos.Visible = true;
            BtnModificarProducto.Visible = true;
            GrbProductos.Text = "Modificar producto";

            TxtCodigoProductos.Text = Convert.ToString(DgvProductos[0, DgvProductos.CurrentCellAddress.Y].Value);
            CmbDepartamento.SelectedItem = Convert.ToString(DgvProductos[1, DgvProductos.CurrentCellAddress.Y].Value);
            CmbMarca.SelectedText = Convert.ToString(DgvProductos[2, DgvProductos.CurrentCellAddress.Y].Value);
            TxtNombreProd.Text=Convert.ToString(DgvProductos[5,DgvProductos.CurrentCellAddress.Y].Value);
            TxtDescripcion.Text = Convert.ToString(DgvProductos[6, DgvProductos.CurrentCellAddress.Y].Value);
            TxtPrecioC.Text = Convert.ToString(DgvProductos[7, DgvProductos.CurrentCellAddress.Y].Value);
            TxtPrecioV.Text = Convert.ToString(DgvProductos[8, DgvProductos.CurrentCellAddress.Y].Value);
            DtaFechaProducto.Value = Convert.ToDateTime(DgvProductos[9, DgvProductos.CurrentCellAddress.Y].Value);
            TxtCantidadProducto.Text = Convert.ToString(DgvProductos[10, DgvProductos.CurrentCellAddress.Y].Value);

            
            
        }

        private void BtnEliminarProd_Click(object sender, EventArgs e)
        {
            TxtNombreProducto.Text=Convert.ToString(DgvProductos[3,DgvProductos.CurrentCellAddress.Y].Value);
            TxtCodigoProductos.Text = Convert.ToString(DgvProductos[0, DgvProductos.CurrentCellAddress.Y].Value);

            if (MessageBox.Show("Desea eliminar el producto "+TxtNombreProducto.Text+"","Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Productos.EliminarProducto(TxtCodigoProductos.Text);
                Productos.FiltrarDatos(DgvProductos, TxtBuscarProductos.Text);
                LbMensaje.Text = "Dato eliminado";
                GruAlerta.Visible = true;
            }
        }

        private void BtnAgregarProd_Click(object sender, EventArgs e)
        {
            Marca.LlenarMarca(CmbMarca);
            Departamento.LlenarDepa(CmbDepartamento);

            TxtNombreProd.Clear();
            TxtDescripcion.Clear(); 
            TxtPrecioC.Clear();
            TxtPrecioV.Clear();
            TxtCantidadProducto.Clear();

            GrbProductos.Visible = true;
            BtnModificarProducto.Visible = false;
            GrbProductos.Text = "Agregar producto";

        }

        private void TxtClaveC_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnAgregarCliente_Click(object sender, EventArgs e)
        {
            GrbClientes.Visible = true;
            GrbClientes.Text = "Agregar cliente";
            BtnModificarCliente.Visible = false;
            TxtIdCliente.ReadOnly = false;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            GrbClientes.Visible = false;
            BtnModificarCliente.Visible = false;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            GrbClientes.Visible = true;
            BtnModificarCliente.Visible = true;
            GrbClientes.Text = "Modificar cliente";
            TxtIdCliente.ReadOnly = true;

        }

        private void TxtClaveProd_TextChanged(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnCancelarProd_Click(object sender, EventArgs e)
        {
            GrbProductos.Visible = false;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnGuardarProducto_Click(object sender, EventArgs e)
        {
            Productos.AgregarProd(Convert.ToString(CmbDepartamento.SelectedValue), Convert.ToString(CmbMarca.SelectedValue), TxtNombreProd.Text, TxtDescripcion.Text, Convert.ToSingle(TxtPrecioC.Text), Convert.ToSingle(TxtPrecioV.Text), DtaFechaProducto.Value.ToString("yyyy-MM-dd"), Convert.ToInt32(TxtCantidadProducto.Text));
            LbMensaje.Text = "Datos guardados";
            GruAlerta.Visible = true;
            Productos.FiltrarDatos(DgvProductos, TxtBuscarProductos.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GruAlerta.Visible = false;
        }

        private void BtnModificarProducto_Click_1(object sender, EventArgs e)
        {
            Productos.ActualizarProductos(Convert.ToInt32(TxtCodigoProductos.Text),Convert.ToString(CmbDepartamento.SelectedValue), Convert.ToString(CmbMarca.SelectedValue), TxtNombreProd.Text, TxtDescripcion.Text, Convert.ToSingle(TxtPrecioC.Text), Convert.ToSingle(TxtPrecioV.Text), DtaFechaProducto.Value.ToString("yyyy-MM-dd"), Convert.ToInt32(TxtCantidadProducto.Text));
            LbMensaje.Text = "Datos modificados";
            GruAlerta.Visible = true;
            Productos.FiltrarDatos(DgvProductos, TxtBuscarProductos.Text);
        }

        private void TxtBuscarProductos_TextChanged(object sender, EventArgs e)
        {
            Productos.FiltrarDatos(DgvProductos, TxtBuscarProductos.Text);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void PicClose_Click(object sender, EventArgs e)
        {
            GrbProductos.Visible = false;
        }

        private void TxtCodigoDepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtNombreDepartamento_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnNuevoDepa_Click(object sender, EventArgs e)
        {
            GrupDepartamento.Text = "Agregar nuevo departamento";
            GrupDepartamento.Visible = true;
            BtnModificarDepa.Visible = false;
            BtnGuardarDepa.Visible = true;

            TxtNombreDepa.Clear();
            TxtDescripcionDepa.Clear();
        }

        private void BtnGuardarDepa_Click(object sender, EventArgs e)
        {
            Departamento.AgregarDepa(TxtNombreDepa.Text, TxtDescripcionDepa.Text);
            LbMensaje.Text = "Departamento guardado";
            Departamento.FiltrarDatos(Dgvdepartamentos, TxtBuscarDepartamento.Text);
            GruAlerta.Visible = true;
            
        }

        private void BtnEliminarDepa_Click(object sender, EventArgs e)
        {
            TxtCodigoDepartamento.Text = Convert.ToString(Dgvdepartamentos[0, Dgvdepartamentos.CurrentCellAddress.Y].Value);
            TxtNombreDepartamento.Text = Convert.ToString(Dgvdepartamentos[1, Dgvdepartamentos.CurrentCellAddress.Y].Value);

            if (MessageBox.Show("Desea eliminar el departamento " + TxtNombreDepartamento.Text + "", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Departamento.EliminarDepa(TxtCodigoDepartamento.Text);
                Departamento.FiltrarDatos(Dgvdepartamentos, TxtBuscarDepartamento.Text);
                LbMensaje.Text = "Dato eliminado";
                GruAlerta.Visible = true;
            }
        }

        private void TxtBuscarDepartamento_TextChanged(object sender, EventArgs e)
        {
            Departamento.FiltrarDatos(Dgvdepartamentos, TxtBuscarDepartamento.Text);
        }

        private void BtnModificarDepartamento_Click(object sender, EventArgs e)
        {
            TxtCodigoDepartamento.Text = Convert.ToString(Dgvdepartamentos[0, Dgvdepartamentos.CurrentCellAddress.Y].Value);
            TxtNombreDepa.Text = Convert.ToString(Dgvdepartamentos[1, Dgvdepartamentos.CurrentCellAddress.Y].Value);
            TxtDescripcionDepa.Text = Convert.ToString(Dgvdepartamentos[2, Dgvdepartamentos.CurrentCellAddress.Y].Value);

            GrupDepartamento.Text = "Modificar departamento";
            GrupDepartamento.Visible = true;
            BtnModificarDepa.Visible = true;
            BtnGuardarDepa.Visible = false;

        }

        private void BtnModificarDepa_Click(object sender, EventArgs e)
        {
            Departamento.ActualizarDepa(Convert.ToInt32(TxtCodigoDepartamento.Text),TxtNombreDepa.Text, TxtDescripcionDepa.Text);
            Departamento.FiltrarDatos(Dgvdepartamentos, TxtBuscarDepartamento.Text);
            LbMensaje.Text = "Datos modificados";
            GruAlerta.Visible = true;
        }

        private void PicCloseDepa_Click(object sender, EventArgs e)
        {
            GrupDepartamento.Visible = false;
        }

        private void BtnCancelarDepa_Click(object sender, EventArgs e)
        {
            GrupDepartamento.Visible = false;
        }

        private void PicCloseMarca_Click(object sender, EventArgs e)
        {
            GrupMarca.Visible = false;
        }

        private void BtnCancelarMarca_Click(object sender, EventArgs e)
        {
            GrupMarca.Visible = false;
        }

        private void BtnModificarMarca_Click(object sender, EventArgs e)
        {
            TxtCodigoMarc.Text = Convert.ToString(DgvMarca[0, DgvMarca.CurrentCellAddress.Y].Value);
            TxtNombreMarca.Text = Convert.ToString(DgvMarca[1, DgvMarca.CurrentCellAddress.Y].Value);
            TxtDescripMarca.Text = Convert.ToString(DgvMarca[2, DgvMarca.CurrentCellAddress.Y].Value);

            GrupMarca.Text = "Modificar marca";
            GrupMarca.Visible = true;
            BtnModificarSaveMarca.Visible = true;
            BtnGuardarMarca.Visible = false;
            TxtCodigoMarc.ReadOnly = false;
        }

        private void BtnNuevoMarca_Click(object sender, EventArgs e)
        {
            GrupMarca.Text = "Agregar nueva marca";
            GrupMarca.Visible = true;
            BtnModificarSaveMarca.Visible = false;
            BtnGuardarMarca.Visible = true;

            TxtCodigoMarc.Clear();
            TxtNombreMarca.Clear();
            TxtDescripMarca.Clear();
        }

        private void BtnGuardarMarca_Click(object sender, EventArgs e)
        {
            Marca.AgregarMarca(TxtNombreMarca.Text, TxtDescripMarca.Text);
            Marca.FiltrarDatos(DgvMarca, TxtBuscarmarca.Text);
            LbMensaje.Text = "Datos agregados";
            GruAlerta.Visible = true;
        }

        private void BtnModificarSaveMarca_Click(object sender, EventArgs e)
        {
            Marca.ActualizarMarca(Convert.ToInt32(TxtCodigoMarc.Text), TxtNombreMarca.Text, TxtDescripMarca.Text);
            Marca.FiltrarDatos(DgvMarca, TxtBuscarmarca.Text);
            LbMensaje.Text = "Dato modificado";
            GruAlerta.Visible = true;
        }

        private void TxtBuscarmarca_TextChanged(object sender, EventArgs e)
        {
            Marca.FiltrarDatos(DgvMarca, TxtBuscarmarca.Text);
        }

        private void BtnEliminarMarca_Click(object sender, EventArgs e)
        {
            TxtCodigoMarc.Text = Convert.ToString(DgvMarca[0, DgvMarca.CurrentCellAddress.Y].Value);
            TxtNombreMarc.Text = Convert.ToString(DgvMarca[1, DgvMarca.CurrentCellAddress.Y].Value);

            if (MessageBox.Show("El dato " + TxtNombreMarc.Text + " se eliminara", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Marca.EliminarMarca(TxtCodigoMarc.Text);
                Marca.FiltrarDatos(DgvMarca, TxtBuscarmarca.Text);
                LbMensaje.Text = "Datos eliminados";
                GruAlerta.Visible = true;
            }
        }

        private void CmbDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void CmbMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void tabDepartamentoProd_Click(object sender, EventArgs e)
        {

        }

        private void PicBucarVentas_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TxtNombreCajero_TextChanged(object sender, EventArgs e)
        {
            Empleados.FiltrarDatos(DvgEmpleados, TxtFolioCajero.Text);
        }

        private void ventaEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmpleados Empleado = new FormEmpleados();
            Empleado.Show();
        }

        private void PicCloseClientes_Click(object sender, EventArgs e)
        {
            GrbClientes.Visible = false;
        }

        private void BtnBuscarFechas_Click(object sender, EventArgs e)
        {
            TxtMesInicio.Text = dateTimeInicio.Value.ToString("yyyy-MM-dd");
            TxtMesFin.Text = dateTimeFinal.Value.ToString("yyyy-MM-dd");
            Ventas.FiltrarPorFecha(DvgVentasPorMeses, TxtMesInicio.Text, TxtMesFin.Text);
        }

        private void TxtMesInicio_TextChanged(object sender, EventArgs e)
        {
     
            Ventas.FiltrarPorFecha(DvgVentasPorMeses, TxtMesInicio.Text, TxtMesFin.Text);
        }

        private void TxtMesFin_TextChanged(object sender, EventArgs e)
        {
            Ventas.FiltrarPorFecha(DvgVentasPorMeses, TxtMesInicio.Text, TxtMesFin.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtMesInicio.Clear();
            TxtMesFin.Clear();
        }

        private void BtnGenerarInforme_Click(object sender, EventArgs e)
        {
            if (DvgVentasPorMeses.RowCount > 0)
            {
                string[] NombreProd = new string[DvgVentasPorMeses.RowCount];
                int[] VentaTotal = new int[DvgVentasPorMeses.RowCount];


                for (int i = 0; i < DvgVentasPorMeses.RowCount; i++)
                {
                    TxtProductoVendidos.Text = Convert.ToString(DvgVentasPorMeses[1, i].Value);
                    NombreProd[i] = TxtNombreProd.Text;

                    TxtDinero.Text = Convert.ToString(DvgVentasPorMeses[3, i].Value);
                    VentaTotal[i] = Convert.ToInt32(textBox1.Text);


                }
            }

            else
            {
                MessageBox.Show("Seleccione alguna fecha para calcular", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
