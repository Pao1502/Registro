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
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.AccessibleName = "txtbNombre";
            textBox1.Location = new Point(88, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox3
            // 
            textBox3.AccessibleName = "txtbApellido";
            textBox3.Location = new Point(88, 69);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(200, 23);
            textBox3.TabIndex = 0;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.AccessibleName = "dtpFecha";
            dateTimePicker1.Location = new Point(132, 112);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(156, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            numericUpDown1.AccessibleName = "npickerEdad";
            numericUpDown1.Location = new Point(88, 152);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(200, 23);
            numericUpDown1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.AccessibleName = "cmbbCargo";
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(88, 194);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(201, 23);
            comboBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.AccessibleName = "txtbSueldo";
            textBox2.Location = new Point(88, 238);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(200, 23);
            textBox2.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.AccessibleName = "cmbbTipo";
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(88, 282);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(201, 23);
            comboBox2.TabIndex = 5;
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
            // listBox1
            // 
            listBox1.AccessibleName = "lstbEmpleados";
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(351, 69);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(189, 229);
            listBox1.TabIndex = 12;
            // 
            // button1
            // 
            button1.AccessibleName = "btnGuardar";
            button1.Location = new Point(88, 343);
            button1.Name = "button1";
            button1.Size = new Size(69, 32);
            button1.TabIndex = 13;
            button1.Text = "GUARDAR";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.AccessibleName = "btnNuevo";
            button2.Location = new Point(172, 343);
            button2.Name = "button2";
            button2.Size = new Size(69, 32);
            button2.TabIndex = 14;
            button2.Text = "NUEVO";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.AccessibleName = "btnSalir";
            button3.BackColor = Color.IndianRed;
            button3.ForeColor = SystemColors.ControlText;
            button3.Location = new Point(471, 343);
            button3.Name = "button3";
            button3.Size = new Size(69, 32);
            button3.TabIndex = 15;
            button3.Text = "SALIR";
            button3.UseVisualStyleBackColor = false;
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
            // AgregarEmpleado
            // 
            AccessibleName = "AgregarEmpleado";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(559, 409);
            Controls.Add(label8);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox2);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox3);
            Controls.Add(textBox1);
            Name = "AgregarEmpleado";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label8;
    }
}
