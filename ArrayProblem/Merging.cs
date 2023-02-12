using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Merging
    {
        public void Merge()
        {
            int[] num = new int[5] { 23, 31, 53, 67, 69 };
            int[] num1 = new int[4] { 12, 13, 11, 36 };
            int[] num2 = new int[9];
            int data = 0;
            for (int i = 0; i < num.Length; i++)
            {
                num2[i] = num[i];
            }

            for (int i = 5; i < num2.Length; i++)
            {
                num2[i] = num1[data];
                data++;
            }
            for(int i= 0;i<num2.Length;i++)
            {
                Console.WriteLine(num2[i]);
            }
        }
    }
}
