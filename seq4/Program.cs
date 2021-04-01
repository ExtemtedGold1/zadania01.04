using System;

namespace seq4 {
    class Program {
        static void Main() {
            string input = Console.ReadLine();
            sbyte n = sbyte.Parse( input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[0] );
            sbyte x = sbyte.Parse( input.Split(" ", StringSplitOptions.RemoveEmptyEntries)[1] );

            input = Console.ReadLine();
            sbyte[] numbers1 = Array.ConvertAll<string, sbyte>(input.Split(" ", StringSplitOptions.RemoveEmptyEntries), sbyte.Parse);
            input = Console.ReadLine();
            sbyte[] numbers2 = Array.ConvertAll<string, sbyte>(input.Split(" ", StringSplitOptions.RemoveEmptyEntries), sbyte.Parse);

            for (sbyte i = 0; i < n; i++) {
                for (sbyte y = (sbyte)-x; y <= x; y++) {
                    if (i + y < 0 || i + y >= n) continue;
                    if (numbers1[i] == numbers2[i + y]) {
                        Console.Write(i + 1);
                        Console.Write(' ');
                    }
                }
            }
        }
    }
}
