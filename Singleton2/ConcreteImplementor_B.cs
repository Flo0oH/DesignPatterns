using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton2
{
    internal class ConcreteImplementor_B:IImplementor
    {
        public void Methode_A()
        {
            Console.WriteLine("\tThis is Method_A from Implementor_A");
        }

        public void Methode_B()
        {
            Console.WriteLine("\tThis is Method_B from Implementor_B");
        }
    }
}
