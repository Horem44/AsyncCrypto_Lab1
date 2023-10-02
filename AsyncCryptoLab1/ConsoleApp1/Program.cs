using ConsoleApp1.Generators;

class Program
{
    static void Main()
    {
        Console.WriteLine(WolframGenerator.GetPseudoRandomValue());
        Console.WriteLine(L89Generator.GetPseudoRandomValue(90));
    }
}
