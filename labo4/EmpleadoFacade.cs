using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace labo4
{
    public class EmpleadoFacade
    {
        public double ObtenerTotalIngresosEmpleado(string idEmpleado)
        {
            var nomina = new Nomina();
            var beneficio = new Beneficio();
            var incentivo = new Bono();

            var salario = nomina.ObtenerSalarioEmpleado(idEmpleado);
            var totalBeneficios = beneficio.ObtenerBeneficioEmpleado(idEmpleado).Sum(c => c.Valor);
            var totalBonos = incentivo.ObtenerBonoEmpleado(idEmpleado).Sum(c => c.Valor);

            return salario + totalBeneficios + totalBonos;
        }

    }
}
