using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{

    class Program
    {
        static void Main()
        {
            var input = File.ReadAllLines("input.txt");
            var nk = input[0].Split().Select(int.Parse).ToArray();
            int N = nk[0];
            int K = nk[1];
            var arrangement = input[1].Split().Select(int.Parse).ToList();

            int result = FindLength.CalculatePosition(N, K, arrangement);
            Console.WriteLine("Calculated position: " + result);
            string outputPath = "output1.txt";  
            File.WriteAllText(outputPath, "Calculated position: " + result);
        }
    }
}
