using System.Reflection.Emit;

namespace ConsoleApp1.Generators
{
    public static class L89Generator
    {
        private static readonly Random _generator = new Random();

        public static string GetPseudoRandomValue(int t)
        {
            if (t < 89)
            {
                throw new ArgumentException(nameof(t));
            }

            int[] result = new int[t];

            for (int i = 0; i < t; i++)
            {
                if (i < 89)
                {
                    result[i] = _generator.Next(2);
                }
                else
                {
                    result[i] = result[i - 38] ^ result[i - 89];
                }
            }

            return string.Join("", result);
        }
    }
}
