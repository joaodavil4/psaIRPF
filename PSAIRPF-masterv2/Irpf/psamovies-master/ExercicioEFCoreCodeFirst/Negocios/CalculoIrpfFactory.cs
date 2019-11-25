using ExercicioEFCoreCodeFirst;
using System;
using System.Collections.Generic;
using System.Text;

namespace IrpfApp.BLL
{
    public class CalculoIrpfFactory
    {
        public static CalculoIrpf createInstance(TipoCalculo t, int cpf)
        {
            switch (t)
            {
                case TipoCalculo.SIMPLIFICADO:
                    return new CalculoIrpfSimplificado(cpf);
                case TipoCalculo.COMPLETO:
                    return new CalculoIrpfCompleto(cpf);
            }
            return null;
        }

        internal static CalculoIrpf createInstance(TipoCalculo t)
        {
            throw new NotImplementedException();
        }
    }
}
