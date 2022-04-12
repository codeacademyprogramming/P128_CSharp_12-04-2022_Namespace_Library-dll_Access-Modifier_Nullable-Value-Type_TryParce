using System;
using System.Collections.Generic;
using System.Text;

namespace P128Abstract.Models
{
    //Abstract Keywordune Sahib Class-in Diger Class-lardan Fer
    //1 - Abstrcat Keywordune Sahib Class-dan Instance(object) yaratmaq Olmur
    //2 - Abstract Methodu Yalniz Abstract Class-in Daxilinde Yaradilir
    abstract class Animal
    {
        public string Name;
        public byte Age { get; set; }
        //Abstract Method - Yalniz Abstract Classlarda Yaradilir ve Body Olmur
        //Polymrphysm
        public abstract void Eat();


        //public abstract void Eat(int a);
        //public abstract int Eat(int a, double c);
    }
}
