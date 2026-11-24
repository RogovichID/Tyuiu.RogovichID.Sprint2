using Tyuiu.RogovichID.Sprint2.Task6.V1.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #2 | Выполнил: Рогович И.Д. | ИБКСб-26-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Получение результата из switch                                    *");
        Console.WriteLine("* Задание #6                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Рогович Иван Дмитриевич | ИБКСб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая использует сокращённую форму записи         *");
        Console.WriteLine("* оператора switch и вычисляет требуемое значение и возвращает            *");
        Console.WriteLine("* результат. По данному номеру месяца определить количество дней          *");
        Console.WriteLine("* в этом месяце.                                                          *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Напишите номер месяца (от 1 до 12): ");
        int value = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.FindMonthDaysCount(value));

        Console.ReadKey();
    }
}