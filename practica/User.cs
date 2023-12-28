using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica
{
    public class User:PersonaIncapacitada,personaCpacitada
    {
        public void MetodoA()
        {
            Console.WriteLine("Implementación de MetodoA");
        }

        public void MetodoB()
        {
            Console.WriteLine("Implementación de MetodoB");
        }
    }
}
