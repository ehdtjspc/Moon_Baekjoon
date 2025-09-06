using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] b = new int[10];
            int result = 0;
            for (int i = 0; i < 10; i++)
            {
                string input = Console.ReadLine();
                int d = int.Parse(input) % 42;
                b[i] = d;
            }

            for (int i = 0; i < 10; i++)
            {
                bool isDuplicate = false;

                for (int j = i+1; j < 10; j++)
                {
                    if (b[i] == b[j])
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    result++;
                }
            }
            Console.WriteLine(result);
        }
    }
}