using System;

namespace Cows_and_bulls
{
    class Program
    {
        /// <summary>
        /// Метод получающий 3-х или 4-х значное рандомное число.
        /// </summary>
        /// <param name="number">Количество цифр в числе</param>
        /// <param name="randnum">Рандомное число</param>
        /// <returns>Метод возвращает рандомное число</returns>
        public static int Randomnum(int number, ref int randnum)
        {
            if (number == 3)
            {
                Random rand = new Random();
                randnum = rand.Next(100, 999);
            }
            if (number == 4)
            {
                Random rand = new Random();
                randnum = rand.Next(1000, 9999);
            }
            return randnum;
        }
        /// <summary>
        /// Проверка рандомного числа на соответствие условию задачи.
        /// </summary>
        /// <param name="randnum">рандомное число</param>
        /// <param name="number">число цифр</param>
        /// <returns>True,если соответствует условию.False,если не соответствует.</returns>
        public static bool Conditioncheck(int randnum, int number)
        {
            bool letter = false;
            int a, b, c, d;
            if (number == 3)
            {
                a = randnum / 100;
                b = (randnum % 100) / 10;
                c = randnum % 10;
                if (a != b && b != c && a != c)
                {
                    letter = true;
                }
            }
            if (number == 4)
            {
                a = randnum / 1000;
                b = (randnum % 1000) / 100;
                c = (randnum % 100) / 10;
                d = (randnum % 10);
                if (a != b && b != c && a != c && a != d && d != b && d != c)
                {
                    letter = true;
                }
            }
            return letter;
        }
        /// <summary>
        /// Проверка введенного числа на правильность ввода.
        /// </summary>
        /// <param name="number">число цифр</param>
        /// <param name="yournum">число введенное с консоли</param>
        /// <returns>Число введенное с консоли,соответствующее требованиям.</returns>
        private static int Consolenumcheck(int number, ref int yournum)
        {
            if (number == 3)
            {
                Console.WriteLine("\nВведи трехзначное число:");
                do
                {
                    if (!int.TryParse(Console.ReadLine(), out yournum))
                    {
                        Console.WriteLine("\n\aТы ввел недопустимое значение!");
                    }
                    if (yournum < 99 || yournum > 999)
                    {
                        Console.WriteLine("\n\aВведи число еще раз:");
                    }

                } while (yournum < 99 || yournum > 999);
            }
            if (number == 4)
            {
                Console.WriteLine("\nВведи четырехзначное число:");
                do
                {
                    if (!int.TryParse(Console.ReadLine(), out yournum))
                    {
                        Console.WriteLine("\n\aТы ввел недопустимое значение!");
                    }
                    if (yournum < 999 || yournum > 9999)
                    {
                        Console.WriteLine("\n\aВведи число еще раз:");
                    }

                } while (yournum < 999 || yournum > 9999);
            }
            return yournum;
        }
        /// <summary>
        /// Вызов методов, соответствуя числу цифр и вывод угаданного числа.
        /// </summary>
        /// <param name="randnum">рандомное число</param>
        /// <param name="yournum">введенное число с консоли</param>
        /// <param name="number">число цифр</param>
        /// <returns>Угаданное число</returns>
        public static int Cowsandbulls(int randnum, int yournum, int number)
        {
            do
            {
                if (number == 3)
                {
                    yournum = Cowsbullsfor3(randnum, yournum, number);
                }
                if (number == 4)
                {
                    yournum = Cowsbullsfor4(randnum, yournum, number);
                }
            } while (randnum != yournum);

            Console.WriteLine("\n                 ПОЗДРАВЛЯЕМ!!! Ты угадал загаданное число!!\a\a\a\a");
            return yournum;
        }
        /// <summary>
        /// Вычисление и сравнение цифр(получение коров и быков)для трехзначного числа.
        /// </summary>
        /// <param name="randnum">рандомное число</param>
        /// <param name="yournum">консольное число</param>
        /// <param name="number">число цифр</param>
        /// <returns>Вычисленное число</returns>
        public static int Cowsbullsfor3(int randnum, int yournum, int number)
        {
            int x, y, z, a, b, c;
            int bulls = 0;
            int cows = 0;
            Consolenumcheck(number, ref yournum);

            a = randnum / 100;
            b = (randnum % 100) / 10;
            c = randnum % 10;

            x = yournum / 100;
            y = (yournum % 100) / 10;
            z = yournum % 10;
            if (x == a)
            {
                bulls++;
            }
            if (y == b)
            {
                bulls++;
            }
            if (z == c)
            {
                bulls++;
            }
            if (x == b || x == c)
            {
                cows++;
            }
            if (y == a || y == c)
            {
                cows++;
            }
            if (z == a || z == b)
            {
                cows++;
            }
            Console.WriteLine("___________________");
            Console.WriteLine($"|Угаданно Быков:{bulls} |");
            Console.WriteLine("|                 |");
            Console.WriteLine($"|Угаданно Коров:{cows} |");
            Console.WriteLine("|_________________|");
            return yournum;
        }
        /// <summary>
        /// Вычисление и сравнение цифр(получение коров и быков)для четрыехзначного числа.
        /// </summary>
        /// <param name="randnum">рандомное число</param>
        /// <param name="yournum">консольное число</param>
        /// <param name="number">число цифр</param>
        /// <returns>Вычисленное число</returns>
        private static int Cowsbullsfor4(int randnum, int yournum, int number)
        {
            int x, y, z, k, a, b, c, d;
            int bulls = 0;
            int cows = 0;
            Consolenumcheck(number, ref yournum);

            a = randnum / 1000;
            b = (randnum % 1000) / 100;
            c = (randnum % 100) / 10;
            d = (randnum % 10);

            x = yournum / 1000;
            y = (yournum % 1000) / 100;
            z = (yournum % 100) / 10;
            k = (yournum % 10);

            if (x == a)
            {
                bulls++;
            }
            if (y == b)
            {
                bulls++;
            }
            if (z == c)
            {
                bulls++;
            }
            if (k == d)
            {
                bulls++;
            }
            if (x == b || x == c || x == d)
            {
                cows++;
            }
            if (y == a || y == c || y == d)
            {
                cows++;
            }
            if (z == a || z == b || z == d)
            {
                cows++;
            }
            if (k == a || k == b || k == c)
            {
                cows++;
            }
            Console.WriteLine("___________________");
            Console.WriteLine($"|Угаданно Быков:{bulls} |");
            Console.WriteLine("|                 |");
            Console.WriteLine($"|Угаданно Коров:{cows} |");
            Console.WriteLine("|_________________|");
            return yournum;
        }

        static void Main(string[] args)
        {
            int number, randnum, yournum;
            randnum = 0;
            yournum = 0;

            Console.WriteLine("Привет, ты зашел в игру \"BULLS AND COWS\"");
            Console.WriteLine("\n                             \"Правила игры\"  ");
            Console.WriteLine("\n1)Ты можешь ввести количество цифр в загаданном числе. \n 3 цифры-легкий уровень.\n 4 цифры-сложный.\n" +
                "2)В это время компьютер загадывает случайное число.\n" +
                "3)Теперь ты должен угадать число, которое загадал компьютер.При вводе в коносль " +
                "числа игра покажет тебе сколько цифр на своем месте.Эти цифры называются Быками." +
                "А также игра тебе покажет сколько цифр ты угадал,но они не на своем месте. " +
                "\nИх называют Коровами." +
                "\n4)Игра продолжается до тех пор по игрок не угадает число." +
                "\n\n                            ХОРОШЕЙ ИГРЫ!!!" +
                "\n\nP.S. В игре есть звуковые сигналы. Советую включить звук)");
            // Работа программы начнется с нажатия кнопки "Enter".
            do
            {
                Console.WriteLine("\nTap Enter to start!");
            } while (Console.ReadKey(true).Key != ConsoleKey.Enter);
            do
            {
                do
                {
                    Console.WriteLine("\nВведи количество цифр в случайном числе(3 или 4)");
                    // Проверка введенной цифры на соответствие условию. 
                    if (!int.TryParse(Console.ReadLine(), out number))
                    {
                        Console.WriteLine("\aТы ввел недопустимое значение!");
                    }

                } while (number < 3 || number > 4);
                // Получение рандомного числа, соответствующего условию.
                do
                {
                    Randomnum(number, ref randnum);

                } while (Conditioncheck(randnum, number) == false);

                Cowsandbulls(randnum, yournum, number);

                // Организация повторного решения.
                Console.WriteLine("\nНажми любую клавишу для начала новой игры!!");
                // Организация выхода из программы.
                Console.WriteLine("\nДля выхода нажми \"Escape\"");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }
    }
}
