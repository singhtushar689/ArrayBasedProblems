using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblem
{
    public class FrequencyOfElements
    {
        public void Frequency()
        {
            int[] array = { 23, 43, 25, 67, 53, 76, 89, 23 ,43 };
            int count = 0;
            foreach(int a in array)
            {
                Console.WriteLine("Elements in array is " + a);
            }
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        count++;
                    }
                   
                    //{
                    //    count = 0;
                    //} else 
                }               
            }
            Console.WriteLine("Number of duplicate element found is " + count);
        }
    }
}
