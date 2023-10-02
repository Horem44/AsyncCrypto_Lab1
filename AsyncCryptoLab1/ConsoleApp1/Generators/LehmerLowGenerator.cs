namespace ConsoleApp1.Generators
{
    public static class LehmerLowGenerator
    {
        public static string GetPseudoRandomValue(int n)
        {
            var x = LehmerGenerator.GetPseudoRandomValue(n);
            var bytesString = Convert.ToString(x, 2);

            return bytesString.Substring(bytesString.Length - 8);
        }
    }
}
