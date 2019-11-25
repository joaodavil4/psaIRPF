using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEFCoreCodeFirst
{
    public class Declaracao
    {
        public int DeclaracaoID { get; set; }
        public double RendimentoTrib { get; set; }
        public int NmroDependentes { get; set; }
        public double Previdencia { get; set; }
        public bool Status { get; set; }
        public string Data { get; set; }
       


        public int ContribuinteID { get; set; }
        public Contribuinte Contribuinte { get; set; }

        public virtual IEnumerable<Deducao> Deducoes { get; set; }
    }
}
