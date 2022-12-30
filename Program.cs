using System;

namespace Nums
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            var result = ConvertFromDecimalToBinary(input);
            Console.WriteLine(result);
        }

        private static int ConvertFromDecimalToBinary(int input)
        {
            int result = input % 2;
            int remainder = input / 2;
            if (remainder > 0)
            {
                result += ConvertFromDecimalToBinary(remainder) * 10;
            }

            return result;
        }
    }
}




Console.WriteLine("Введите начальное число M:");
int numberM = int.Parse(Console.ReadLine());

Console.WriteLine("Введите начальное число M:");
int numberN = int.Parse(Console.ReadLine());

///Метод нахождения суммы натуральных элементов в промежутке от M до N
void GapNumberSum (int numberM, int numberN, int sum)
{
    if (numberM > numberN) 
    {
        Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {sum}"); 
        return;
    }
    sum = sum + (numberM++);
    GapNumberSum(numberM, numberN, sum);
}

GapNumberSum(numberM, numberN, 0);