using Tyuiu.RogovichID.Sprint2.Task4.V6.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Рогович И.Д. | ИБКСб-26-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Тернарный оператор                                                *");
        Console.WriteLine("* Задание #4                                                              *");
        Console.WriteLine("* Вариант #6                                                              *");
        Console.WriteLine("* Выполнил: Рогович Иван Дмитриевич | ИБКСб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая вычисляет требуемое значение                *");
        Console.WriteLine("* с использованием тернарного оператора, где пользователь                 *");
        Console.WriteLine("* вводит значение переменной X и У с клавиатуры. Округлить полученное     *");
        Console.WriteLine("* значение до трех знаков после запятой                                   *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Напишите число x: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Напишите число y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.Calculate(x, y));
        
        Console.ReadKey();
    }
}