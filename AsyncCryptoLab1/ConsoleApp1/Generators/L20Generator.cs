namespace ConsoleApp1.Generators
{
    public static class L20Generator
    {
        private static readonly Random _generator = new Random();

        public static string GetPseudoRandomValue(int t)
        {
            if (t < 20)
            {
                throw new ArgumentException(nameof(t));
            }

            int[] result = new int[t];

            for (int i = 0; i < t; i++)
            {
                if (i < 20)
                {
                    result[i] = _generator.Next(2);
                }
                else
                {
                    result[i] = result[i - 3] ^ result[i - 5] ^ result[i - 9] ^ result[i - 20];
                }
            }

            return string.Join("", result);
        }
    }
}
