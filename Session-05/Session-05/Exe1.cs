﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Exe1
    {
        public void Reversestring()
        {
            Console.WriteLine("Write your name");
            String name = Console.ReadLine();
            char[] array = name.ToCharArray();
            Array.Reverse(array);
            String reversed = new string(array);
            Console.WriteLine(reversed);
        }
    }
}
