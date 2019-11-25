using ExercicioEFCoreCodeFirst;
using System;
using System.Collections.Generic;

namespace IrpfApp.BLL

{
    public interface ContribuinteDAO
    {
        Declaracao adicionarDec(Declaracao d);
        Declaracao buscarCPF(int cpf);
        Contribuinte BuscarCPFContribuinte(int cpf);
        Contribuinte CadastrarContribuinte(Contribuinte c);
        Deducao LancarDeducao(Deducao ded);
        Declaracao AlterarStatus(bool status);
    }

}
