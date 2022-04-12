using System;
using P128Abstract.Models;

namespace P128Abstract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Eagle eagle = new Eagle();
            eagle.Age = 15;
            eagle.CanFly = true;
            eagle.Name = "Elovset";
            eagle.Eat();
            eagle.Fly();

            Shark shark = new Shark();
            shark.Age = 50;
            shark.Name = "AKULA";
            shark.Eat();
        }
    }
}
