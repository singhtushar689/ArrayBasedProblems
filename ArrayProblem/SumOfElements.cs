using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblem
{
    public class SumOfElements
    {
        public void Sum()
        {
            int[] array = { 23, 57, -46, 73, -15, 98, 68 };
            int sum = 0;
            foreach(int elements in array)
            {
                Console.WriteLine("The Elements are " + elements);
            }
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            Console.WriteLine("Sum of all Elements of Array is " + sum);
        }
    }
}
