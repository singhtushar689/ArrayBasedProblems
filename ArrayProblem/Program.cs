using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Option \n 1.ArrayLength \n 2.FindMaxMinInElements " +
                "\n 3.Showing Negative Elements \n 4.SumOfAllElements " +
                "\n 5.FindAndCountDuplicateElements");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                   FindLengthOfArray arr = new FindLengthOfArray(); 
                    arr.ArrayLength();
                    break;
                case 2:
                    FindMaxMin max = new FindMaxMin();
                    max.MaxMin();
                    break;
                case 3:
                    NegativeElements negative = new NegativeElements();
                    negative.Negative();
                    break;
                case 4:
                    SumOfElements sum = new SumOfElements();
                    sum.Sum();
                    break;
                case 5:
                    FrequencyOfElements frequency = new FrequencyOfElements();
                    frequency.Frequency();
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
    

