using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasedProblems
{
    public class FIndNegativeElements
    {
        public void FindNegativeElements()
        {
            int[] array = { 23, 42, -4, 8, -54, 39, 98 };
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    Console.WriteLine(array[i]);
                }
            }
        }
    }
}
