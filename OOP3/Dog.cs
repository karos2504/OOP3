using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Dog : Animal
    {
        public override void Name()
        {
            Console.WriteLine("Adam");
        }

        public override void Speak()
        {
            Console.WriteLine("Wolf wolf");
        }
    }
}
