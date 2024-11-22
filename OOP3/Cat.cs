using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Cat : Animal
    {
        public override void Name()
        {
            Console.WriteLine("Tom");
        }

        public override void Speak()
        {
            Console.WriteLine("Meow meow");
        }
    }
}
