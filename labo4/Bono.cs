using System;
using System.Collections.Generic;
using System.Text;

namespace labo4
{
    public class Bono
    {
        public class Incentivo
        {
            public string TipoBono { get; set; }
            public int Valor { get; set; }
        }
        public List<Incentivo> ObtenerBonoEmpleado(string id)
        {
            return new List<Incentivo>()
            {
                new Incentivo { TipoBono="Bono por trabajador del mes", Valor = 1000},
                new Incentivo { TipoBono="Bono por cumplimiento", Valor=500}
            };
        }
    }
}
