using ExercicioEFCoreCodeFirst;
using System;
using System.Collections.Generic;
using System.Text;

namespace IrpfApp.BLL
{
    public class CalculoIrpfCompleto : CalculoIrpf
    {
        int cpf;

        public CalculoIrpfCompleto(int cpf)
        {
            this.cpf = cpf;
        }

        public double calculaImposto()
        {

            return (0);
        }


    }
}
