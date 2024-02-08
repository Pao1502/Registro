using Registro.Clases;

namespace Registro
{
    public partial class AgregarEmpleado : Form
    {
        int contador = 1;
        List<Empleado> empleados = new List<Empleado>();
        public AgregarEmpleado()
        {
            
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }



       

        private void txtbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Empleado nuevoEmpleado = new Empleado();

            nuevoEmpleado.Nombre = txtbNombre.Text;
            nuevoEmpleado.Apellido = txtbApellido.Text;
            nuevoEmpleado.Edad = (int)nudEdad.Value;
            nuevoEmpleado.fecha_Ingreso = dtpFechaIngreso.Value;
            nuevoEmpleado.Sueldo = (double)nudSueldo.Value;
            nuevoEmpleado.Cargo = cmbbCargo.SelectedText;
            nuevoEmpleado.Tipo = cmbbTipo.SelectedText;
            empleados.Add(nuevoEmpleado);
            contador = 1;
            lstbEmpleados.Items.Clear();
            foreach (var empleado in empleados)
            {

                lstbEmpleados.Items.Add($"Empleado: {contador}");
                lstbEmpleados.Items.Add($"");

                lstbEmpleados.Items.Add($"Nombre: {empleado.Nombre}");
                lstbEmpleados.Items.Add($"Apellido: {empleado.Apellido}");
                lstbEmpleados.Items.Add($"Edad: {empleado.Edad}");
                lstbEmpleados.Items.Add($"Ingreso: {empleado.fecha_Ingreso.ToString("dd 'de' MMMM 'de' yyyy")}");
                lstbEmpleados.Items.Add($"Sueldo: RD$ {empleado.Sueldo}");
                lstbEmpleados.Items.Add($"Cargo: {empleado.Cargo}");
                lstbEmpleados.Items.Add($"Tipo {empleado.Tipo}");
                lstbEmpleados.Items.Add($"-------------------------------");





                contador++;
            }
         

        }
    }
}
