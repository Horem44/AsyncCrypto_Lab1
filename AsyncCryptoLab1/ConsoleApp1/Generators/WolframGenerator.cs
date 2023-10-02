namespace ConsoleApp1.Generators
{
    public static class WolframGenerator
    {
        public static string GetPseudoRandomValue(int n = 32)
        {
            var r = LehmerGenerator.GetPseudoRandomValue(1);
            var x = new int[n];

            for (int i = 0; i < n; i++)
            {
                x[i] = r % 2;

                if (x[i] < 0)
                {
                    x[i] += 2;
                }

                r = ROL(r, 1) ^ (r | ROR(r, 1));
            }

            return string.Join("", x);
        }

        private static int ROR(int x, int nbitsShift) =>
            (x >> nbitsShift) | (x << (32 - nbitsShift));

        private static int ROL(int x, int nbitsShift) =>
            (x << nbitsShift) | (x >> (32 - nbitsShift));
    }
}
