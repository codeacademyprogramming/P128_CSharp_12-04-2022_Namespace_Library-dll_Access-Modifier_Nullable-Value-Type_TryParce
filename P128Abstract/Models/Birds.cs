using System;
using System.Collections.Generic;
using System.Text;

namespace P128Abstract.Models
{
    abstract class Birds : Animal
    {
        public bool CanFly { get; set; }
        public abstract void Fly();
    }
}
