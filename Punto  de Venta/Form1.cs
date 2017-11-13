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
    public partial class Form1 : Form
    {
        ClassEmpleado Empleados = new ClassEmpleado();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Empleados.FiltrarPersonalLogin(DvgPersonal);
            Boton(DvgPersonal);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            Auth Verificar = new Auth("empleados", "usuario", "contrasenia", TxtUsuario.Text, TxtContraseña.Text);
            Verificar.DatosUser();
            if (Verificar.ExisteUsuario == true)
            {
                if (Verificar.PassOk == true)
                {
                    Form2 FormPrincipal = new Form2();
                    FormPrincipal.DatosAcceso(Verificar.QueUsuarioAccede, Verificar.QueNivelUsuarioAccede);
                    FormPrincipal.Show();
                    this.Hide();


                }

                else
                {
                    MessageBox.Show("La contraseña esta mal", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            else
            {
                MessageBox.Show("El usuario no esta registrado", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        public void Boton(DataGridView Dgv)
        {
            if (Dgv.RowCount == 0)
            {
                BtnRegistrar.Visible = true;

            }
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            FormAgregarEmpleados Agregar = new FormAgregarEmpleados();
            this.Hide();
            Agregar.Show();
        }

    }
}
