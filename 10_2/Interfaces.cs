using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_2; // очень удобно, что есть возможность разбить классы и интерфейсы по разным файлам

/// <summary>
/// Интерфейс, отвечающий за сумму
/// </summary>
public interface ISum
{
    float Sum();
}

/// <summary>
/// Интерфейс логгера
/// </summary>
public interface ILogger
{
    void Event(string message);
    void Error(string message);
}