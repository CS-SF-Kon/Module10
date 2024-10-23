using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2;

/// <summary>
/// Класс, наследующий суммирующий интерфейс
/// </summary>
public class Calc : ISum
{
    ILogger Logger { get; set; }

    public Calc(ILogger logger)
    {
        Logger = logger;
    }
    public float Sum()
    {
        try
        {
            Logger.Event("Insert first number: ");
            var a = Console.ReadLine();
            Logger.Event("Insert second number: ");
            var b = Console.ReadLine();
            float _a = float.Parse(a);
            float _b = float.Parse(b);
            return _a + _b;
        }
        catch (FormatException ex)
        {
            Logger.Error("Something went wrong: " + ex.Message);
            return 0;
        }
    }
}

/// <summary>
/// Класс логгера
/// </summary>
public class Logger : ILogger
{
    public void Error(string message)
    {
        Console.WriteLine(message);
    }

    public void Event(string message)
    {
        Console.WriteLine(message);
    }
}
