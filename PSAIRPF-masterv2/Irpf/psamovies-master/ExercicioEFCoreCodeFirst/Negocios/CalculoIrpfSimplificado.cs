using ExercicioEFCoreCodeFirst;
using System;
using System.Collections.Generic;
using System.Text;

namespace IrpfApp.BLL
{
    public class CalculoIrpfSimplificado: CalculoIrpf
    {
        int cpf;

        public CalculoIrpfSimplificado(int cpf)
        {
            this.cpf = cpf;
        }


        public double calculaImposto()
    {
            ContribuinteDAO contribuintes = new BaseDados();
            Declaracao decl = contribuintes.buscarCPF(cpf);

            if (decl == null)
                // gerar exception
                return -2;
            
            return -1;

    }
}

}
