using System;
using System.Collections.Generic;
using System.Text;

namespace labo4
{
    public class Beneficio
    {
        public class Incentivo
        {
            public string Nombre { get; set; }
            public int Valor { get; set; }
        }

        public List<Incentivo> ObtenerBeneficioEmpleado(string id)
        {
            return new List<Incentivo> ()
            {
                new Incentivo { Nombre = "Subsidio para hijos",Valor = 1000},
                new Incentivo { Nombre = "Capacitaciones", Valor = 500 }

            };
                
        }

    }
}
