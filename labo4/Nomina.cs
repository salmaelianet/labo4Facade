using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace labo4
{
    public class Nomina
    {
        public class Empleado
        {
            public string Id { get; set; }
            public string Nombre { get; set; }
            public int Salario { get; set; }

        }
        public int ObtenerSalarioEmpleado(string id)
        {
            var empleados = new List<Empleado>() {
                new Empleado() { Id = "1", Nombre = "Salma Claure", Salario = 20000 },
                new Empleado() { Id = "2", Nombre = "Carlos Lozada", Salario = 10000 },
                new Empleado() { Id = "3", Nombre = "Teresa Morris", Salario = 30000 },
                new Empleado() { Id = "4", Nombre = "Nicolas Perez", Salario = 20000 },
            };


            return empleados.First(e => e.Id.Equals(id)).Salario;
        }
    }
}
