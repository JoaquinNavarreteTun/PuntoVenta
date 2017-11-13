namespace PuntodeVenta
{
    partial class FormEmpleados
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmpleados));
            this.DvgEmpleados = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtEmpleados = new System.Windows.Forms.TextBox();
            this.TxtCodigoEmpleados = new System.Windows.Forms.TextBox();
            this.TxtNombreEmpleados = new System.Windows.Forms.TextBox();
            this.GruAlerta = new System.Windows.Forms.GroupBox();
            this.LbMensaje = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GrbEmpleados = new System.Windows.Forms.GroupBox();
            this.CmbPuestoEmpleado = new System.Windows.Forms.ComboBox();
            this.TxtApellidosEmpleados = new System.Windows.Forms.TextBox();
            this.TxtNombreEmpleado = new System.Windows.Forms.TextBox();
            this.PicCloseEmple = new System.Windows.Forms.PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnModificarDatos = new System.Windows.Forms.Button();
            this.BtnGuardarDatos = new System.Windows.Forms.Button();
            this.BtnCancelarProd = new System.Windows.Forms.Button();
            this.label24 = new System.Windows.Forms.Label();
            this.TxtContraEmpleado = new System.Windows.Forms.TextBox();
            this.TxtUsuarioEmpleado = new System.Windows.Forms.TextBox();
            this.TxtEdadEmpleado = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.BtnActualizarEmpleados = new System.Windows.Forms.Button();
            this.BtnEliminarEmpleado = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DvgEmpleados)).BeginInit();
            this.GruAlerta.SuspendLayout();
            this.GrbEmpleados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCloseEmple)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DvgEmpleados
            // 
            this.DvgEmpleados.AllowUserToAddRows = false;
            this.DvgEmpleados.AllowUserToDeleteRows = false;
            this.DvgEmpleados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DvgEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DvgEmpleados.Location = new System.Drawing.Point(12, 102);
            this.DvgEmpleados.Name = "DvgEmpleados";
            this.DvgEmpleados.ReadOnly = true;
            this.DvgEmpleados.Size = new System.Drawing.Size(682, 505);
            this.DvgEmpleados.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empleados";
            // 
            // TxtEmpleados
            // 
            this.TxtEmpleados.Location = new System.Drawing.Point(12, 70);
            this.TxtEmpleados.Multiline = true;
            this.TxtEmpleados.Name = "TxtEmpleados";
            this.TxtEmpleados.Size = new System.Drawing.Size(620, 26);
            this.TxtEmpleados.TabIndex = 49;
            this.TxtEmpleados.TextChanged += new System.EventHandler(this.TxtEmpleados_TextChanged);
            // 
            // TxtCodigoEmpleados
            // 
            this.TxtCodigoEmpleados.Location = new System.Drawing.Point(12, 624);
            this.TxtCodigoEmpleados.Name = "TxtCodigoEmpleados";
            this.TxtCodigoEmpleados.Size = new System.Drawing.Size(100, 20);
            this.TxtCodigoEmpleados.TabIndex = 55;
            // 
            // TxtNombreEmpleados
            // 
            this.TxtNombreEmpleados.Location = new System.Drawing.Point(128, 624);
            this.TxtNombreEmpleados.Name = "TxtNombreEmpleados";
            this.TxtNombreEmpleados.Size = new System.Drawing.Size(100, 20);
            this.TxtNombreEmpleados.TabIndex = 56;
            // 
            // GruAlerta
            // 
            this.GruAlerta.BackColor = System.Drawing.Color.Black;
            this.GruAlerta.Controls.Add(this.LbMensaje);
            this.GruAlerta.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GruAlerta.Location = new System.Drawing.Point(694, 579);
            this.GruAlerta.Name = "GruAlerta";
            this.GruAlerta.Size = new System.Drawing.Size(207, 65);
            this.GruAlerta.TabIndex = 57;
            this.GruAlerta.TabStop = false;
            this.GruAlerta.Text = "Informacion";
            this.GruAlerta.Visible = false;
            // 
            // LbMensaje
            // 
            this.LbMensaje.AutoSize = true;
            this.LbMensaje.BackColor = System.Drawing.Color.Transparent;
            this.LbMensaje.Font = new System.Drawing.Font("Arial Narrow", 17F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbMensaje.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LbMensaje.Location = new System.Drawing.Point(24, 17);
            this.LbMensaje.Name = "LbMensaje";
            this.LbMensaje.Size = new System.Drawing.Size(0, 27);
            this.LbMensaje.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // GrbEmpleados
            // 
            this.GrbEmpleados.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GrbEmpleados.Controls.Add(this.CmbPuestoEmpleado);
            this.GrbEmpleados.Controls.Add(this.TxtApellidosEmpleados);
            this.GrbEmpleados.Controls.Add(this.TxtNombreEmpleado);
            this.GrbEmpleados.Controls.Add(this.PicCloseEmple);
            this.GrbEmpleados.Controls.Add(this.label11);
            this.GrbEmpleados.Controls.Add(this.label8);
            this.GrbEmpleados.Controls.Add(this.BtnModificarDatos);
            this.GrbEmpleados.Controls.Add(this.BtnGuardarDatos);
            this.GrbEmpleados.Controls.Add(this.BtnCancelarProd);
            this.GrbEmpleados.Controls.Add(this.label24);
            this.GrbEmpleados.Controls.Add(this.TxtContraEmpleado);
            this.GrbEmpleados.Controls.Add(this.TxtUsuarioEmpleado);
            this.GrbEmpleados.Controls.Add(this.TxtEdadEmpleado);
            this.GrbEmpleados.Controls.Add(this.label25);
            this.GrbEmpleados.Controls.Add(this.label26);
            this.GrbEmpleados.Controls.Add(this.label28);
            this.GrbEmpleados.Controls.Add(this.label29);
            this.GrbEmpleados.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GrbEmpleados.Location = new System.Drawing.Point(111, 118);
            this.GrbEmpleados.Name = "GrbEmpleados";
            this.GrbEmpleados.Size = new System.Drawing.Size(466, 427);
            this.GrbEmpleados.TabIndex = 58;
            this.GrbEmpleados.TabStop = false;
            this.GrbEmpleados.Visible = false;
            // 
            // CmbPuestoEmpleado
            // 
            this.CmbPuestoEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbPuestoEmpleado.FormattingEnabled = true;
            this.CmbPuestoEmpleado.Items.AddRange(new object[] {
            "Gerente",
            "Empleado"});
            this.CmbPuestoEmpleado.Location = new System.Drawing.Point(169, 296);
            this.CmbPuestoEmpleado.Name = "CmbPuestoEmpleado";
            this.CmbPuestoEmpleado.Size = new System.Drawing.Size(280, 21);
            this.CmbPuestoEmpleado.TabIndex = 41;
            // 
            // TxtApellidosEmpleados
            // 
            this.TxtApellidosEmpleados.Location = new System.Drawing.Point(169, 81);
            this.TxtApellidosEmpleados.Multiline = true;
            this.TxtApellidosEmpleados.Name = "TxtApellidosEmpleados";
            this.TxtApellidosEmpleados.Size = new System.Drawing.Size(280, 27);
            this.TxtApellidosEmpleados.TabIndex = 40;
            // 
            // TxtNombreEmpleado
            // 
            this.TxtNombreEmpleado.Location = new System.Drawing.Point(169, 31);
            this.TxtNombreEmpleado.Multiline = true;
            this.TxtNombreEmpleado.Name = "TxtNombreEmpleado";
            this.TxtNombreEmpleado.Size = new System.Drawing.Size(280, 27);
            this.TxtNombreEmpleado.TabIndex = 39;
            // 
            // PicCloseEmple
            // 
            this.PicCloseEmple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PicCloseEmple.Image = ((System.Drawing.Image)(resources.GetObject("PicCloseEmple.Image")));
            this.PicCloseEmple.Location = new System.Drawing.Point(441, 0);
            this.PicCloseEmple.Name = "PicCloseEmple";
            this.PicCloseEmple.Size = new System.Drawing.Size(26, 22);
            this.PicCloseEmple.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicCloseEmple.TabIndex = 38;
            this.PicCloseEmple.TabStop = false;
            this.PicCloseEmple.Click += new System.EventHandler(this.PicCloseEmple_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(72, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 18);
            this.label11.TabIndex = 30;
            this.label11.Text = "Apellido(s)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(87, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "Nombre";
            // 
            // BtnModificarDatos
            // 
            this.BtnModificarDatos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnModificarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnModificarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnModificarDatos.Location = new System.Drawing.Point(124, 350);
            this.BtnModificarDatos.Name = "BtnModificarDatos";
            this.BtnModificarDatos.Size = new System.Drawing.Size(141, 46);
            this.BtnModificarDatos.TabIndex = 26;
            this.BtnModificarDatos.Text = "Modificar";
            this.BtnModificarDatos.UseVisualStyleBackColor = true;
            this.BtnModificarDatos.Visible = false;
            this.BtnModificarDatos.Click += new System.EventHandler(this.BtnModificarProducto_Click);
            // 
            // BtnGuardarDatos
            // 
            this.BtnGuardarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnGuardarDatos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnGuardarDatos.Location = new System.Drawing.Point(124, 350);
            this.BtnGuardarDatos.Name = "BtnGuardarDatos";
            this.BtnGuardarDatos.Size = new System.Drawing.Size(141, 46);
            this.BtnGuardarDatos.TabIndex = 19;
            this.BtnGuardarDatos.Text = "Guardar";
            this.BtnGuardarDatos.UseVisualStyleBackColor = true;
            this.BtnGuardarDatos.Click += new System.EventHandler(this.BtnGuardarDatos_Click);
            // 
            // BtnCancelarProd
            // 
            this.BtnCancelarProd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnCancelarProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarProd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnCancelarProd.Location = new System.Drawing.Point(308, 350);
            this.BtnCancelarProd.Name = "BtnCancelarProd";
            this.BtnCancelarProd.Size = new System.Drawing.Size(141, 46);
            this.BtnCancelarProd.TabIndex = 20;
            this.BtnCancelarProd.Text = "Cancelar";
            this.BtnCancelarProd.UseVisualStyleBackColor = true;
            this.BtnCancelarProd.Click += new System.EventHandler(this.BtnCancelarProd_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(26, 116);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(0, 18);
            this.label24.TabIndex = 10;
            // 
            // TxtContraEmpleado
            // 
            this.TxtContraEmpleado.Location = new System.Drawing.Point(169, 233);
            this.TxtContraEmpleado.Multiline = true;
            this.TxtContraEmpleado.Name = "TxtContraEmpleado";
            this.TxtContraEmpleado.Size = new System.Drawing.Size(280, 27);
            this.TxtContraEmpleado.TabIndex = 8;
            // 
            // TxtUsuarioEmpleado
            // 
            this.TxtUsuarioEmpleado.Location = new System.Drawing.Point(169, 182);
            this.TxtUsuarioEmpleado.Multiline = true;
            this.TxtUsuarioEmpleado.Name = "TxtUsuarioEmpleado";
            this.TxtUsuarioEmpleado.Size = new System.Drawing.Size(280, 27);
            this.TxtUsuarioEmpleado.TabIndex = 7;
            // 
            // TxtEdadEmpleado
            // 
            this.TxtEdadEmpleado.Location = new System.Drawing.Point(169, 132);
            this.TxtEdadEmpleado.Multiline = true;
            this.TxtEdadEmpleado.Name = "TxtEdadEmpleado";
            this.TxtEdadEmpleado.Size = new System.Drawing.Size(280, 27);
            this.TxtEdadEmpleado.TabIndex = 5;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(94, 296);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 18);
            this.label25.TabIndex = 4;
            this.label25.Text = "Puesto";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(64, 242);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(85, 18);
            this.label26.TabIndex = 3;
            this.label26.Text = "Contraseña";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(89, 191);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(60, 18);
            this.label28.TabIndex = 1;
            this.label28.Text = "Usuario";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(107, 132);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(42, 18);
            this.label29.TabIndex = 0;
            this.label29.Text = "Edad";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PuntodeVenta.Properties.Resources._2369;
            this.pictureBox1.Location = new System.Drawing.Point(128, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Image = global::PuntodeVenta.Properties.Resources.add;
            this.BtnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAgregar.Location = new System.Drawing.Point(742, 263);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(123, 37);
            this.BtnAgregar.TabIndex = 53;
            this.BtnAgregar.Text = "Agregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // BtnActualizarEmpleados
            // 
            this.BtnActualizarEmpleados.Image = global::PuntodeVenta.Properties.Resources.file_edit;
            this.BtnActualizarEmpleados.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnActualizarEmpleados.Location = new System.Drawing.Point(742, 206);
            this.BtnActualizarEmpleados.Name = "BtnActualizarEmpleados";
            this.BtnActualizarEmpleados.Size = new System.Drawing.Size(123, 37);
            this.BtnActualizarEmpleados.TabIndex = 52;
            this.BtnActualizarEmpleados.Text = "Actualizar";
            this.BtnActualizarEmpleados.UseVisualStyleBackColor = true;
            this.BtnActualizarEmpleados.Click += new System.EventHandler(this.BtnActualizarEmpleados_Click);
            // 
            // BtnEliminarEmpleado
            // 
            this.BtnEliminarEmpleado.Image = global::PuntodeVenta.Properties.Resources.delete;
            this.BtnEliminarEmpleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnEliminarEmpleado.Location = new System.Drawing.Point(742, 145);
            this.BtnEliminarEmpleado.Name = "BtnEliminarEmpleado";
            this.BtnEliminarEmpleado.Size = new System.Drawing.Size(123, 37);
            this.BtnEliminarEmpleado.TabIndex = 51;
            this.BtnEliminarEmpleado.Text = "Eliminar";
            this.BtnEliminarEmpleado.UseVisualStyleBackColor = true;
            this.BtnEliminarEmpleado.Click += new System.EventHandler(this.BtnEliminarEmpleado_Click);
            // 
            // button21
            // 
            this.button21.ForeColor = System.Drawing.Color.Black;
            this.button21.Image = ((System.Drawing.Image)(resources.GetObject("button21.Image")));
            this.button21.Location = new System.Drawing.Point(655, 70);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(39, 26);
            this.button21.TabIndex = 50;
            this.button21.UseVisualStyleBackColor = true;
            // 
            // FormEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 656);
            this.Controls.Add(this.GrbEmpleados);
            this.Controls.Add(this.GruAlerta);
            this.Controls.Add(this.TxtNombreEmpleados);
            this.Controls.Add(this.TxtCodigoEmpleados);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.BtnActualizarEmpleados);
            this.Controls.Add(this.BtnEliminarEmpleado);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.TxtEmpleados);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DvgEmpleados);
            this.Name = "FormEmpleados";
            this.Text = "Empleados";
            this.Load += new System.EventHandler(this.FormEmpleados_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DvgEmpleados)).EndInit();
            this.GruAlerta.ResumeLayout(false);
            this.GruAlerta.PerformLayout();
            this.GrbEmpleados.ResumeLayout(false);
            this.GrbEmpleados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicCloseEmple)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DvgEmpleados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.TextBox TxtEmpleados;
        private System.Windows.Forms.Button BtnEliminarEmpleado;
        private System.Windows.Forms.Button BtnActualizarEmpleados;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TxtCodigoEmpleados;
        private System.Windows.Forms.TextBox TxtNombreEmpleados;
        private System.Windows.Forms.GroupBox GruAlerta;
        private System.Windows.Forms.Label LbMensaje;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox GrbEmpleados;
        private System.Windows.Forms.TextBox TxtApellidosEmpleados;
        private System.Windows.Forms.TextBox TxtNombreEmpleado;
        private System.Windows.Forms.PictureBox PicCloseEmple;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnModificarDatos;
        private System.Windows.Forms.Button BtnGuardarDatos;
        private System.Windows.Forms.Button BtnCancelarProd;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox TxtContraEmpleado;
        private System.Windows.Forms.TextBox TxtUsuarioEmpleado;
        private System.Windows.Forms.TextBox TxtEdadEmpleado;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox CmbPuestoEmpleado;
    }
}