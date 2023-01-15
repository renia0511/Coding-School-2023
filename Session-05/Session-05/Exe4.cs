using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session_05
{
    internal class Exe4
    {
    public void mularrays()
    {
        int[] first_array = { 2, 4, 9, 12 };
        int[] second_array = { 1, 3, 7, 10 };
        int[] third_array = new int[16];
        int counter = 0;
        for (int i = 0; i < first_array.Length; i++)
        {

            for (int j = 0; j < second_array.Length; j++)
            {
                third_array[counter] = first_array[i] * second_array[j];
                Console.Write(third_array[counter]);
                counter++;

            }
        }


    }
}
}
