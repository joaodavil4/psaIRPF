using System;
using System.Collections.Generic;
using System.Text;

namespace ExercicioEFCoreCodeFirst
{
    public class Contribuinte
    {
        public int ContribuinteID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }

       
        public Declaracao Declaracao { get; set; }

    }
}
