//*****************************************************
//* Практическая работа №12.2                         *
//* Выполнила: Корнеева В.Е., группа 2ИСП             *
//* Задание: Рекурсии                                 *                      
//*****************************************************

using System;

namespace PR_12._2
{
    internal class Program
    {
        static int F(int n)
        {
            // Базовый случай (условие для завершения рекурсии)
            if (n == 1)
                return 1;

            // Рекурсивный спуск (если n четное, вызываем F(n - 1))
            else if (n % 2 == 0)
                return n + F(n - 1);

            // Рекурсивный спуск (если n нечетное, вызываем F(n - 2))
            else
                return 3 * F(n - 2);
        }
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Title = "Практическая работа \t№12.2";
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Clear();
                Console.WriteLine("Здравствуйте!");
                try
                {
                    Console.ForegroundColor= ConsoleColor.Cyan;
                    Console.Write("Введите число: ");
                    int n = Int32.Parse(Console.ReadLine());
                    if (n <= 0) 
                    {
                        throw new Exception("Ваше введенное число не является натуральным");
                    }
                    int result = F(n); // Вызов функции F(n)
                    Console.WriteLine("F({0}) = {1}", n, result);
                    Console.ReadKey();
                }
                catch (FormatException fe)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Упс... что-то пошло не так: " + fe.Message);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Упс... что-то пошло не так: " + ex.Message);
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Хотите выполнить команду еще раз? \nНажмите Y для продолжение программы, иначе любую другую кнопку для завершения!");
                if (Console.ReadKey().Key == ConsoleKey.Y)
                {
                    Console.Clear();
                    continue;

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Программа завершена. \tДо свидания!");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}