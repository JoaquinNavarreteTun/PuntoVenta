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
    public partial class FormAgregarEmpleados : Form
    {
        ClassEmpleado Empleados = new ClassEmpleado();
        public FormAgregarEmpleados()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Empleados.AgregarEmple(TxtNombre.Text,TxtApellidos.Text,Convert.ToInt32(TxtEdad.Text),TxtUsuario.Text,TxtContra.Text,Convert.ToString(CmbPuesto.SelectedItem));
            LbMensaje.Text = "Datos Guardados";
            GruAlerta.Visible = true;
        }

        private void FormAgregarEmpleados_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            GruAlerta.Visible = false;
        }

        private void PicCloseEmple_Click(object sender, EventArgs e)
        {
            Form1 login = new Form1();
            this.Close();
            login.Show();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TxtNombre.Clear();
            TxtApellidos.Clear();
            TxtEdad.Clear();
            TxtUsuario.Clear();
            TxtContra.Clear();

            TxtNombre.Focus();
        }
    }
}
