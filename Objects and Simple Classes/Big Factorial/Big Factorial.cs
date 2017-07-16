﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Big_Factorial
{
    class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            BigInteger factorial = 1;

            for (int i = n; i > 1; i--)
            {
                factorial *= i;
            }

            Console.WriteLine(factorial);
        }
    }
}
