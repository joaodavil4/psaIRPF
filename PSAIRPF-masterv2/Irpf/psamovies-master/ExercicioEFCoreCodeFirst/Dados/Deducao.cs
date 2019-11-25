using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEFCoreCodeFirst
{
    public class Deducao
    {
        public int DeducaoID { get; set; }
   
        public string TipoDeducao { get; set; }
        public double Valor { get; set; }

        public int DeclaracaoID { get; set; }
        public Declaracao Declaracao { get; set; }
    }
}
