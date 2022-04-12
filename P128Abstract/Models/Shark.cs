using System;
using System.Collections.Generic;
using System.Text;

namespace P128Abstract.Models
{
    class Shark : Fish
    {
        public override void Eat()
        {
            Console.WriteLine($"Eat As Shark {Name} {Age}");
        }
    }
}
