using System;

namespace labo4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el ID del empleado:");
            var id = Console.ReadLine();

            var empleadoFacade = new EmpleadoFacade();
            var salario = empleadoFacade.ObtenerTotalIngresosEmpleado(id);
            Console.Write("Los ingresos totales del empleado con identificación {0}, son: {1}", id, salario);
            Console.ReadLine();
        }
    }
}
