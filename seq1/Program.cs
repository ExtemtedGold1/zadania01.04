using System;

namespace seq1 {
    class Program {
        static void Main() {
            sbyte n1 = sbyte.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            sbyte[] numbers1 = Array.ConvertAll<string, sbyte>(input.Split(" "), sbyte.Parse);

            sbyte n2 = sbyte.Parse(Console.ReadLine());
            input = Console.ReadLine();
            sbyte[] numbers2 = Array.ConvertAll<string, sbyte>(input.Split(" "), sbyte.Parse);

            for (int i = 0; i < n1; i++) {
                for (int j = 0; j < n2; j++) {
                    if (numbers1[i] == numbers2[j]) {
                        break;
                    }

                    if (j == n2 - 1) {
                        Console.Write(numbers1[i]);
                        Console.Write(' ');
                    }
                }
            }
        }
    }
}
