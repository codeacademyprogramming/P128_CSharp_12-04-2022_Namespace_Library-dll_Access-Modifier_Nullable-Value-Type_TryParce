using System;
using System.Collections.Generic;
using System.Text;

namespace P128DemoLibrary.Services
{
    class Calculator
    {
        //public int Sum(int a, int b)
        //{
        //    return a + b;
        //}

        //public int Sum(int a, int b, int c)
        //{
        //    return a + b + c;
        //}

        public int Sum(params int[] arr)
        {
            int result = 0;
            foreach (int item in arr)
            {
                result += item;
            }
            return result;
        }
    }
}
