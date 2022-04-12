using System;

namespace P128HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("User Name Deyerini Daxil Et");
            Console.WriteLine("Password Deyerini Daxil Et");
            User user = new User("UserName", Console.ReadLine());
        }
    }
}
