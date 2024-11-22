using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class Animal
    {
        public virtual void Name()
        {
            Console.Write("Animal name is: ");
        }

        public virtual void Speak()
        {
            Console.Write("Animal speak is: ");
        }
    }
}
