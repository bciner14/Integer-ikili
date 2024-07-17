using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the integers: ");
        string input = Console.ReadLine();
        List<int> numbers = input.Split(' ').Select(int.Parse).ToList();

        List<int> results = ProcessNumbers(numbers);

        foreach (int result in results)
        {
            Console.WriteLine(result);
        }
    }

    static List<int> ProcessNumbers(List<int> pairs)
    {
        List<int> results = new List<int>();
        for (int i = 0; i < pairs.Count; i += 2)
        {
            int num1 = pairs[i];
            int num2 = pairs[i + 1];
            if (num1 != num2)
            {
                results.Add(num1 + num2);
            }
            else
            {
                results.Add((num1 + num2) * (num1 + num2));
            }
        }
        return results;
    }
}
