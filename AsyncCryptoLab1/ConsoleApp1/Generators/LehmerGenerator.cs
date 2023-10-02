namespace ConsoleApp1.Generators
{
    public static class LehmerGenerator
    {
        private static readonly int m = int.MaxValue;

        private static readonly int a = (int)Math.Pow(2, 16) + 1;

        private static readonly int c = 119;

        public static int GetPseudoRandomValue(int n)
        {
            var x0 = GetInitialValue();

            for (int i = 0; i < n; i++)
            {
                x0 = (x0 * a + c) % m;
            }

            if (x0 < 0)
            {
                x0 += m;
            }

            return x0;
        }

        private static int GetInitialValue() => new Random().Next(m);
    }
}
