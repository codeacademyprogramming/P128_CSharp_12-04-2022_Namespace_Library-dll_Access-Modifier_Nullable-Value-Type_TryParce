using System;
using System.Collections.Generic;
using System.Text;

namespace P128Abstract.Models
{
    class Eagle : Birds
    {
        public override void Eat()
        {
            Console.WriteLine("Eat As Eagle");
        }

        public override void Fly()
        {
            Console.WriteLine("Fly As Eagle");
        }
    }
}
