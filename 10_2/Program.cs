namespace _10_2;

internal class Program
{
    static ILogger Logger { get; set; }

    static void Main(string[] args)
    {
        Logger = new Logger();

        var calc = new Calc(Logger); // жаль, что нельзя реализовывать интерфейсы статическими классами, чтоб можно было обходиться без создания экземпляров

        var result = calc.Sum();
        Console.WriteLine(result);
    }
}
