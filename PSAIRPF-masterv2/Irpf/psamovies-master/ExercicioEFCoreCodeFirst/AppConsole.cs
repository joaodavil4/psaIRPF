using IrpfApp.BLL;
using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEFCoreCodeFirst
{
    public class AppConsole
    {
        public static void Main()
        {
            IrpfFachada fachada = new IrpfFachada();

            Contribuinte contrib = fachada.buscarContribuinte(5);

            if (contrib == null) 
               Console.WriteLine("napo encontrado");
            else { 
                   Console.WriteLine(contrib.FirstName);
                   
            // decl.Status = true;
            // fachada.save(decl)

            Console.ReadKey();
        }
    }
}
