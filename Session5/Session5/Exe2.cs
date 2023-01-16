using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session5
{
   public  class Exe2
    {
        public int sumproduct()
        {
            Console.WriteLine("Write a number");
            int a = Convert.ToInt32(Console.ReadLine());
            int s = 0;

            Console.WriteLine("Choose 1 for sum and 2 for product");
           int b = Convert.ToInt32(Console.ReadLine());
            if (b == 1)
            {

                for (int i = 1; i <= a; i++)
                {
                   s += i;

                }

            }
            else if(b == 2)
            {
                for (int i = 1; i<= a; i++)
                {
                    s *= i;
                }
            }
            return s;

        }
    }

}
