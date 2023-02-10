using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayBasedProblems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any Option \n 1. FindArrayLength \n2. FindMaxAndMin" +
                " \n3. FindNegativeElements \n 4. FindSumOfAllElements \n 5. Find the Frequency of elements in array ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FindArray arr = new FindArray();
                    arr.FindLengthOfArray();
                    break;
                case 2:
                    FIndMaxMin max = new FIndMaxMin();
                    max.FindMaxAndMin();
                    break;
                case 3:
                    FIndNegativeElements negative = new FIndNegativeElements();
                    negative.FindNegativeElements();
                    break;
                case 4:
                    FIndSumOfAllElementsInArray sum = new FIndSumOfAllElementsInArray();
                    sum.SumOfArray();
                    break;
                case 5:
                    FindFrequencyOfElement frequency = new FindFrequencyOfElement();
                    frequency.FrequencyOfElement();
                    break;
                default: 
                    break;
            }
            Console.ReadLine();
        }
    }
}
