using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblem
{
    public class FindMaxMin
    {
        public void MaxMin()
        {
            int max, min;
            int[] array = { 23, 12, 36, 52, 41, 93, 54, 67 };
            max = array[0];
            min = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                else if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine("Maximum among the array is " + max);
            Console.WriteLine("Minimum number in the array " + min);
        }
    }
}
