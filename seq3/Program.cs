using System;

namespace seq3 {
    class Program {
        static void Main() {
            sbyte n1 = sbyte.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            sbyte[] numbers1 = Array.ConvertAll<string, sbyte>(input.Split(" ", StringSplitOptions.RemoveEmptyEntries), sbyte.Parse);

            sbyte n2 = sbyte.Parse(Console.ReadLine());
            input = Console.ReadLine();
            sbyte[] numbers2 = Array.ConvertAll<string, sbyte>(input.Split(" ", StringSplitOptions.RemoveEmptyEntries), sbyte.Parse);

            sbyte x = n1 < n2 ? n1 : n2;

            for (int i = 0; i < x; i++) {
                if (numbers1[i] == numbers2[i]) {
                    Console.Write(i + 1);
                    Console.Write(' ');
                }
            }
        }
    }
}
