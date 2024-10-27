using Tyuiu.ChelolyanAE.Sprint3.Task3.V3.Lib;

namespace Tyuiu.ChelolyanAE.Sprint3.Task3.V3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.Title = "Спринт #3 |Выполнила: Челольян А. Е. | ИИПБ-24-2";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #3                                                               *");
            Console.WriteLine("* Тема:Оператор цикла foreach                                             *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #3                                                              *");
            Console.WriteLine("* Выполнила: Челольян Анжела Евгеньевна | ИИПБ-24-2                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Используя цикл foreach подсчитать минимальное количество букв f         *");
            Console.WriteLine("* находящихся на соседних позициях в строке cvbmzff orffgtrr dkfvfffdr    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            string value = "cvbmzff orffgtrr dkfvfffdr";
            char chr = 'f';
            Console.WriteLine($"Исхидная строка {value}");
            Console.WriteLine($"Искомый символ {chr}");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine($"Минимальное количество букв f {ds.GetMinCharCount(value,chr)}");
            Console.ReadKey();

        }
    }
}
