using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculotor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("калькулятор ");
            Console.WriteLine(@"Выберите действие:
            1. Сложить 2 числа
            2. Вычесть первое из второго
            3. Перемножить два числа
            4. Разделить первое на второе
            5. Возвести в степень N первое число
            6. Найти квадратный корень из числа
            7. Найти 1 процент от числа
            8. Найти факториал из числа
            9. Выйти из программы");




            while (true)




            {
                string q = Console.ReadLine();
                double firstValue, secondValue, thirdValue;

                {
                    if (q == "1")
                    {
                        Console.WriteLine("Введите первое значение");
                        firstValue = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе значение");
                        secondValue = double.Parse(Console.ReadLine());
                        Console.WriteLine("Результат сложения = {0}", firstValue + secondValue);
                        Console.WriteLine(' ');

                        Console.WriteLine("Ещё одну операцию?");
                        Console.WriteLine("Введите её номер");

                    }
                    if (q == "2")
                    {
                        Console.WriteLine("Введите первое значение");
                        firstValue = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе значение");
                        secondValue = double.Parse(Console.ReadLine());
                        Console.WriteLine("Результат вычитания = {0}", firstValue - secondValue);
                        Console.WriteLine(' ');

                        Console.WriteLine("Ещё одну операцию?");
                        Console.WriteLine("Введите её номер");

                    }
                    if (q == "3")
                    {
                        Console.WriteLine("Введите первое значение");
                        firstValue = float.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе значение");
                        secondValue = float.Parse(Console.ReadLine());
                        Console.WriteLine("Результат умножения = {0}", firstValue * secondValue);
                        Console.WriteLine(' ');

                        Console.WriteLine("Ещё одну операцию?");
                        Console.WriteLine("Введите её номер");

                    }
                    if (q == "4")
                    {
                        Console.WriteLine("Введите первое значение");
                        firstValue = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе значение");
                        secondValue = double.Parse(Console.ReadLine());
                        if (secondValue == 0)
                        {
                            Console.WriteLine("БРООО если ты забыл на 0 делить нельзя");
                        }
                        else
                            Console.WriteLine("Результат деления = {0}", firstValue / secondValue);
                        Console.WriteLine(' ');

                        Console.WriteLine("Ещё одну операцию?");
                        Console.WriteLine("Введите её номер");

                    }
                    if (q == "5")
                    {
                        Console.WriteLine("Введите первое значение");
                        firstValue = double.Parse(Console.ReadLine());
                        Console.WriteLine("Введите второе значение");
                        secondValue = double.Parse(Console.ReadLine());
                        Console.WriteLine("Результат возведения числа в степень = {0}", Math.Pow(firstValue, secondValue));
                        Console.WriteLine(' ');
                        Console.WriteLine("Ещё одну операцию?");
                        Console.WriteLine("Введите её номер");
                    }
                }
                if (q == "6")
                {
                    Console.WriteLine("Введите число из которого будет найден корень");
                    thirdValue = double.Parse(Console.ReadLine());
                    Console.WriteLine("квадратный корень = {0}", Math.Sqrt(thirdValue));
                    Console.WriteLine(' ');
                    Console.WriteLine("Ещё одну операцию?");
                    Console.WriteLine("Введите её номер");


                }
                if (q == "7")
                {
                    Console.WriteLine("Введите число от которого будет найден 1%");
                    thirdValue = double.Parse(Console.ReadLine());
                    Console.WriteLine(" 1 процент от числа = {0}", thirdValue / 100);
                    Console.WriteLine(' ');
                    Console.WriteLine("Ещё одну операцию?");
                    Console.WriteLine("Введите её номер");

                }
                if (q == "8")
                {
                }
                if (q == "9")
                {
                    Environment.Exit(0);
                }
                if (q != "123456789")
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("числа от 1 до 9");
                }

            }
            Console.ReadKey();
        }

    }
}