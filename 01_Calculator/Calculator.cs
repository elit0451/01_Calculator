using System;

namespace _01_Calculator
{
    internal class Calculator
    {
        internal static int Add(int v1, int v2)
        {
            return v1 + v2;
        }

        internal static int Subtract(int v1, int v2)
        {
            return v1 - v2;
        }

        internal static int Sum(int[] numbers)
        {
            int allSum = 0;
            for (int i=0; i<numbers.Length;i++)
            {
                allSum = allSum + numbers[i];
            }
            return allSum;
            
        }

        internal static int Multiply(int v1, int v2)
        {
            return v1 * v2;
        }

        internal static int Power(int v1, int v2)
        {
            int allSum=1;
            for(int i =0; i<v2;i++)
            {
                allSum = allSum * v1;
            }
            return allSum;
        }

        internal static int Factorial(int v)
        {
            int allSum=1;
            for (int i = v; i > 0; i--)
            {
                allSum = allSum * i;
            }
            return allSum;
        }
    }
}