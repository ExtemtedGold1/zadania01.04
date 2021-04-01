using System;

namespace seq5 {
    class Program {
        static void Main() {
            string input = Console.ReadLine();
            sbyte n = sbyte.Parse(input);

            input = Console.ReadLine();
            sbyte[] numbers = Array.ConvertAll<string, sbyte>(input.Split(" ", StringSplitOptions.RemoveEmptyEntries), sbyte.Parse);

            bool decreasing = true;

            for (sbyte i = 0; i < n; i++) {
                if (i + 1 >= n) {
                    Console.WriteLine("Yes");
                    break;
                }

                if (!decreasing && numbers[i] >= numbers[i + 1]) {
                    Console.WriteLine("No");
                    break;
                }

                if (decreasing && numbers[i] <= numbers[i + 1]) {
                    decreasing = false;
                }
            }
        }
    }
}
