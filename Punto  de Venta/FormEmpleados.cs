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
    public partial class FormEmpleados : Form
    {
        ClassEmpleado Empleados = new ClassEmpleado();

        public FormEmpleados()
        {
            InitializeComponent();
        }

        private void TxtEmpleados_TextChanged(object sender, EventArgs e)
        {
            Empleados.FiltrarDatos(DvgEmpleados, TxtEmpleados.Text);
        }

        private void FormEmpleados_Load(object sender, EventArgs e)
        {
            Empleados.FiltrarDatos(DvgEmpleados, TxtEmpleados.Text);

            timer1.Enabled = true;
        }

        private void BtnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            TxtNombreEmpleados.Text = Convert.ToString(DvgEmpleados[1, DvgEmpleados.CurrentCellAddress.Y].Value);

            if(MessageBox.Show("Desea desactivar al empleado "+TxtNombreEmpleados.Text+"","Warning",MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                Empleados.EliminarEmple(TxtCodigoEmpleados.Text);
                Empleados.FiltrarDatos(DvgEmpleados, DvgEmpleados.Text);
                LbMensaje.Text = "Dato eliminado";
                GruAlerta.Visible = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GruAlerta.Visible = false;
        }

        private void BtnActualizarEmpleados_Click(object sender, EventArgs e)
        {
            GrbEmpleados.Text = "Modificar datos";
            GrbEmpleados.Visible = true;
            BtnModificarDatos.Visible = true;
            BtnGuardarDatos.Visible=false;

            TxtCodigoEmpleados.Text = Convert.ToString(DvgEmpleados[0, DvgEmpleados.CurrentCellAddress.Y].Value);
            TxtNombreEmpleado.Text = Convert.ToString(DvgEmpleados[1, DvgEmpleados.CurrentCellAddress.Y].Value);
            TxtApellidosEmpleados.Text = Convert.ToString(DvgEmpleados[2, DvgEmpleados.CurrentCellAddress.Y].Value);
            TxtEdadEmpleado.Text = Convert.ToString(DvgEmpleados[3, DvgEmpleados.CurrentCellAddress.Y].Value);
            TxtUsuarioEmpleado.Text = Convert.ToString(DvgEmpleados[4, DvgEmpleados.CurrentCellAddress.Y].Value);
            TxtContraEmpleado.Text = Convert.ToString(DvgEmpleados[5, DvgEmpleados.CurrentCellAddress.Y].Value);
            CmbPuestoEmpleado.SelectedItem = Convert.ToString(DvgEmpleados[6, DvgEmpleados.CurrentCellAddress.Y].Value);

        }

        private void PicCloseEmple_Click(object sender, EventArgs e)
        {
            GrbEmpleados.Visible = false;
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            TxtNombreEmpleado.Clear();
            TxtApellidosEmpleados.Clear();
            TxtEdadEmpleado.Clear();
            TxtUsuarioEmpleado.Clear();
            TxtContraEmpleado.Clear();


            LbMensaje.Text = "Agregar empleado";
            GrbEmpleados.Visible = true;
            BtnModificarDatos.Visible = false;
            BtnGuardarDatos.Visible = true;
        }

        private void BtnModificarProducto_Click(object sender, EventArgs e)
        {
            Empleados.ActualizarEmplead(Convert.ToInt32(TxtCodigoEmpleados.Text), TxtNombreEmpleado.Text, TxtApellidosEmpleados.Text, Convert.ToInt32(TxtEdadEmpleado.Text), TxtUsuarioEmpleado.Text, TxtContraEmpleado.Text, Convert.ToString(CmbPuestoEmpleado.SelectedValue));
            Empleados.FiltrarDatos(DvgEmpleados, TxtEmpleados.Text);
            LbMensaje.Text = "Datos modificados";
            GruAlerta.Visible = true;
        }

        private void BtnGuardarDatos_Click(object sender, EventArgs e)
        {
            Empleados.AgregarEmple(TxtNombreEmpleado.Text, TxtApellidosEmpleados.Text, Convert.ToInt32(TxtEdadEmpleado.Text), TxtUsuarioEmpleado.Text, TxtContraEmpleado.Text, Convert.ToString(CmbPuestoEmpleado.SelectedValue));
            Empleados.FiltrarDatos(DvgEmpleados, TxtEmpleados.Text);
            LbMensaje.Text = "Datos agregados";
            GruAlerta.Visible = true;
        }

        private void BtnCancelarProd_Click(object sender, EventArgs e)
        {
            GrbEmpleados.Visible = false;
        }
    }
}
