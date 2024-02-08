namespace Registro
{
    partial class AgregarEmpleado
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtbNombre = new TextBox();
            txtbApellido = new TextBox();
            dtpFechaIngreso = new DateTimePicker();
            nudEdad = new NumericUpDown();
            cmbbCargo = new ComboBox();
            cmbbTipo = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lstbEmpleados = new ListBox();
            btnGuardar = new Button();
            btnNuevo = new Button();
            btnSalir = new Button();
            label8 = new Label();
            nudSueldo = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudEdad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudSueldo).BeginInit();
            SuspendLayout();
            // 
            // txtbNombre
            // 
            txtbNombre.AccessibleDescription = "txtbNombre";
            txtbNombre.AccessibleName = "txtbNombre";
            txtbNombre.Location = new Point(88, 31);
            txtbNombre.Name = "txtbNombre";
            txtbNombre.Size = new Size(200, 23);
            txtbNombre.TabIndex = 0;
            txtbNombre.TextChanged += txtbNombre_TextChanged;
            // 
            // txtbApellido
            // 
            txtbApellido.AccessibleName = "txtbApellido";
            txtbApellido.Location = new Point(88, 69);
            txtbApellido.Name = "txtbApellido";
            txtbApellido.Size = new Size(200, 23);
            txtbApellido.TabIndex = 0;
            // 
            // dtpFechaIngreso
            // 
            dtpFechaIngreso.AccessibleName = "dtpFecha";
            dtpFechaIngreso.Location = new Point(132, 112);
            dtpFechaIngreso.Name = "dtpFechaIngreso";
            dtpFechaIngreso.Size = new Size(156, 23);
            dtpFechaIngreso.TabIndex = 1;
            // 
            // nudEdad
            // 
            nudEdad.AccessibleName = "npickerEdad";
            nudEdad.Location = new Point(88, 152);
            nudEdad.Name = "nudEdad";
            nudEdad.Size = new Size(200, 23);
            nudEdad.TabIndex = 2;
            // 
            // cmbbCargo
            // 
            cmbbCargo.AccessibleName = "cmbbCargo";
            cmbbCargo.FormattingEnabled = true;
            cmbbCargo.Items.AddRange(new object[] { "Administrador", "Comun" });
            cmbbCargo.Location = new Point(88, 194);
            cmbbCargo.Name = "cmbbCargo";
            cmbbCargo.Size = new Size(201, 23);
            cmbbCargo.TabIndex = 3;
            // 
            // cmbbTipo
            // 
            cmbbTipo.AccessibleName = "cmbbTipo";
            cmbbTipo.FormattingEnabled = true;
            cmbbTipo.Items.AddRange(new object[] { "Permanente", "Nomina", "Temporal" });
            cmbbTipo.Location = new Point(88, 282);
            cmbbTipo.Name = "cmbbTipo";
            cmbbTipo.Size = new Size(201, 23);
            cmbbTipo.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 34);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 72);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 6;
            label2.Text = "Apellido";
            label2.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 118);
            label3.Name = "label3";
            label3.Size = new Size(96, 15);
            label3.TabIndex = 7;
            label3.Text = "Fecha de Ingreso";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 152);
            label4.Name = "label4";
            label4.Size = new Size(33, 15);
            label4.TabIndex = 8;
            label4.Text = "Edad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 197);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 9;
            label5.Text = "Cargo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 241);
            label6.Name = "label6";
            label6.Size = new Size(43, 15);
            label6.TabIndex = 10;
            label6.Text = "Sueldo";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(33, 285);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 11;
            label7.Text = "Tipo";
            // 
            // lstbEmpleados
            // 
            lstbEmpleados.AccessibleName = "lstbEmpleados";
            lstbEmpleados.FormattingEnabled = true;
            lstbEmpleados.ItemHeight = 15;
            lstbEmpleados.Location = new Point(351, 69);
            lstbEmpleados.Name = "lstbEmpleados";
            lstbEmpleados.Size = new Size(189, 229);
            lstbEmpleados.TabIndex = 12;
            // 
            // btnGuardar
            // 
            btnGuardar.AccessibleName = "btnGuardar";
            btnGuardar.Location = new Point(88, 343);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(69, 32);
            btnGuardar.TabIndex = 13;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.AccessibleName = "btnNuevo";
            btnNuevo.Location = new Point(172, 343);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(69, 32);
            btnNuevo.TabIndex = 14;
            btnNuevo.Text = "NUEVO";
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.AccessibleName = "btnSalir";
            btnSalir.BackColor = Color.IndianRed;
            btnSalir.ForeColor = SystemColors.ControlText;
            btnSalir.Location = new Point(471, 343);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(69, 32);
            btnSalir.TabIndex = 15;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(351, 31);
            label8.Name = "label8";
            label8.Size = new Size(129, 15);
            label8.TabIndex = 16;
            label8.Text = "Empleados Registrados";
            // 
            // nudSueldo
            // 
            nudSueldo.AccessibleName = "nudSueldo";
            nudSueldo.Location = new Point(88, 239);
            nudSueldo.Name = "nudSueldo";
            nudSueldo.Size = new Size(200, 23);
            nudSueldo.TabIndex = 17;
            // 
            // AgregarEmpleado
            // 
            AccessibleName = "AgregarEmpleado";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 409);
            Controls.Add(nudSueldo);
            Controls.Add(label8);
            Controls.Add(btnSalir);
            Controls.Add(btnNuevo);
            Controls.Add(btnGuardar);
            Controls.Add(lstbEmpleados);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbbTipo);
            Controls.Add(cmbbCargo);
            Controls.Add(nudEdad);
            Controls.Add(dtpFechaIngreso);
            Controls.Add(txtbApellido);
            Controls.Add(txtbNombre);
            Name = "AgregarEmpleado";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudEdad).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudSueldo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbNombre;
        private TextBox txtbApellido;
        private DateTimePicker dtpFechaIngreso;
        private NumericUpDown nudEdad;
        private ComboBox cmbbCargo;
        private ComboBox cmbbTipo;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListBox lstbEmpleados;
        private Button btnGuardar;
        private Button btnNuevo;
        private Button btnSalir;
        private Label label8;
        private NumericUpDown nudSueldo;
    }
}
