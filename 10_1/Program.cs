namespace _10_1;

internal class Program
{
    static void Main(string[] args)
    {
        Calc calc = new Calc();
        var result = ((ISum)calc).Sum();
        Console.WriteLine(result);
    }
}

public interface ISum
{
    public float Sum();
}

public class Calc : ISum
{
    float ISum.Sum()
    {
        try
        {
            Console.Write("Insert first number: ");
            var a = Console.ReadLine();
            Console.Write("Insert second number: ");
            var b = Console.ReadLine();
            float _a = float.Parse(a);
            float _b = float.Parse(b);
            return _a + _b;
        }
        catch (FormatException ex)
        {
            Console.WriteLine(ex.Message);
            return 0;
        }
    }
}
