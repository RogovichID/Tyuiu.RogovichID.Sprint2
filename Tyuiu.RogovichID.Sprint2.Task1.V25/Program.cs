using Tyuiu.RogovichID.Sprint2.Task1.V25.Lib;
using Tyuiu.RogovichID.Sprint2.Task1.V25.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        int a = 247;
        int b = 155;
        int c = 325;
        int d = 857;
        bool[] res = new bool[6];
        res = ds.GetLogicOperations(a, b, c, d);

        Console.Title = "Спринт #2 | Выполнил: Рогович И.Д. | ИБКСб-26-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Логические операции                                               *");
        Console.WriteLine("* Задание #1                                                              *");
        Console.WriteLine("* Вариант #25                                                             *");
        Console.WriteLine("* Выполнил: Рогович Иван Дмитриевич | ИБКСб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу из операций сравнений (==, !=, <, >, <=, >=,         *");
        Console.WriteLine("* последовательность можно чередовать, но использовать один раз           *");
        Console.WriteLine("* в выражении) и логических операций (|, &, ||, &&, !, ^,                 *");
        Console.WriteLine("* последовательность операций не должна нарушаться), а такж               *");
        Console.WriteLine("* арифметических выражений, которая вернет логическую                     *");
        Console.WriteLine("* последовательность(массив): (True, False, True, False, True, False)     *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* a = 247, b = 155, c = 325, d = 857                                      *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        for (int i = 0; i < res.Length; i++)
        {
            Console.WriteLine(res[i]);
        }

        Console.ReadKey();
    }
}
