using System;

namespace Lab1
{
    public class Program
    {
        private const int Min = -1000000;
        private const int Max = 1000000;

        public static void Main()
        {
            Console.WriteLine("Задание 1: Большая буква");
            char letter = ReadChar();
            Console.WriteLine($"Результат: {IsUpperCase(letter)}");

            Console.WriteLine();

            Console.WriteLine("Задание 2: Тройная сумма");
            int x = ReadNumber("x");
            int y = ReadNumber("y");
            int z = ReadNumber("z");
            Console.WriteLine($"Результат: {Sum3(x, y, z)}");

            Console.WriteLine();

            Console.WriteLine("Задание 3: Одинаковость");
            int number = ReadNumber("число");
            Console.WriteLine($"Результат: {EqualNum(number)}");
        }

        public static char ReadChar()
        {
            Console.Write("Введите один символ: ");
            string input = Console.ReadLine();

            while (input == null || input.Length != 1)
            {
                Console.Write("Ошибка! Нужно ввести ровно один символ. Повторите: ");
                input = Console.ReadLine();
            }

            return input[0];
        }

        public static int ReadNumber(string name)
        {
            int number;

            Console.Write($"Введите {name} (от {Min} до {Max}): ");

            while (!int.TryParse(Console.ReadLine(), out number) || number < Min || number > Max)
            {
                Console.Write($"Ошибка! Введите целое число от {Min} до {Max}: ");
            }

            return number;
        }

        public static bool IsUpperCase(char x)
        {
            return x >= 'A' && x <= 'Z';
        }

        public static bool Sum3(int x, int y, int z)
        {
            return x + y == z || x + z == y || y + z == x;
        }

        public static bool EqualNum(int x)
        {
            // Берём модуль, чтобы минус не мешал (-111 тоже true)
            int n = Math.Abs(x);
            int digit = n % 10; // последняя цифра

            while (n > 0)
            {
                if (n % 10 != digit)
                {
                    return false;
                }

                n = n / 10; // отбрасываем последнюю цифру
            }

            return true;
        }
    }
}