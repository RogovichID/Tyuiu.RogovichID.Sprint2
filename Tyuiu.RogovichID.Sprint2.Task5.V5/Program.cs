using Tyuiu.RogovichID.Sprint2.Task5.V5.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataSerivce ds = new DataSerivce();

        Console.Title = "Спринт #2 | Выполнил: Рогович И.Д. | ИБКСб-26-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #2                                                               *");
        Console.WriteLine("* Тема: Оператор switch                                                   *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #5                                                              *");
        Console.WriteLine("* Выполнил: Рогович Иван Дмитриевич | ИБКСб-26-1                          *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая использует оператор switch и вычисляет      *");
        Console.WriteLine("* требуемое значение и возвращает результат. Игральным картам условно     *");
        Console.WriteLine("* присвоены порядковые номера: «валету» — 11, «даме» — 12, «королю» —     *");
        Console.WriteLine("* 13, «тузу» — 14. Порядковые номера остальных карт соответствуют их      *");
        Console.WriteLine("* названиям. По заданному номеру карты k определить достоинство карты     *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Напишите номер карты (от 6 до 14): ");
        int k = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine(ds.FindCardValue(k));

        Console.ReadKey();
    }
}