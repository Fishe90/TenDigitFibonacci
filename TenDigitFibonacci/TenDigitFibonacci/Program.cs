using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TenDigitFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal firstNum = 1; //First number in the sequence
            decimal secondNum = 0; //Second number in the sequence            
            decimal nextNum = firstNum + secondNum; //Next number in the sequence
            decimal indexNum = 0; //Keeps a running count of the current index of the sequence

            while (nextNum.ToString().Length < 10)
            {
                indexNum += 1;
                firstNum = nextNum - firstNum;
                secondNum = nextNum;
                nextNum = firstNum + secondNum;
            }
               
            Console.WriteLine("Index of the Fibonacci Sequence that contains 10-digits: " + indexNum);
            Console.WriteLine(nextNum);

            Console.WriteLine();
            int maxDigit = 1;
            while (maxDigit < 30)
            {                
                CalcIndexOfFib(maxDigit);
                maxDigit += 1;
            }
        }

        //Finds the Index of the Fibonacci Sequence UP-TO the inputted maxDigit < 30
        public static void CalcIndexOfFib(decimal maxDigit)
        {
            decimal firstNum = 1; //First number in the sequence
            decimal secondNum = 0; //Second number in the sequence            
            decimal nextNum = firstNum + secondNum; //Next number in the sequence
            decimal indexNum = 0; //Keeps a running count of the current index of the sequence

            while (nextNum.ToString().Length < maxDigit)
            {
                indexNum += 1;
                firstNum = nextNum - firstNum;
                secondNum = nextNum;
                nextNum = firstNum + secondNum;
            }
            
            Console.WriteLine($"Index of the Fibonacci Sequence that contains {maxDigit}-digits: {indexNum}");
            Console.WriteLine(nextNum);
        }
    }
}
