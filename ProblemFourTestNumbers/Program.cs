using System.Diagnostics.CodeAnalysis;

namespace ProblemFourTestNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var maxSum = int.Parse(Console.ReadLine());
            var sum = 0; 
            var totalCombinations = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    var number = (i * j) * 3;
                    sum += number;
                    totalCombinations++;
                    if(sum >= maxSum)
                    {
                        Console.WriteLine($"{totalCombinations} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maxSum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{totalCombinations} combinations");
            Console.WriteLine($"Sum: {sum} ");




        }
    }
}