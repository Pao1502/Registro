using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro.Clases
{
    internal class Empleado
    {

        public string Nombre { get; set; } = "";

        public string Apellido { get; set; } = "";


        public int Edad { get; set; } = 0;


        public DateTime fecha_Ingreso { get; set; }


        public string Cargo { get; set; } = "";


        public double Sueldo { get; set; }

        public string Tipo { get; set; } = "";
    }
}
