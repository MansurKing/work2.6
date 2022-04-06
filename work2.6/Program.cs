using System;

namespace work2._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            float dollorToRub = 83.43f;
            float rubToDollor = 83.43f;
            float dollor, rub;
            float correncyCount;

            string userAction;
            string selectionConsoleColor;
            string selectionFontColor;
            string userExchanger;
            string message;

            while (true)
            {
                Console.WriteLine("\nВыберете один из предложенных команд, после чего введите название команды для ее выполнения.");
                Console.WriteLine("changeConsoleColor или 1 - изменить цвет консоли;");
                Console.WriteLine("changeFontColor или 2 - изменить цвет шрифта;");
                Console.WriteLine("thePowerOfRandomness или 3 - игра в которой существуют два гладиатора у которых рандомно выстовляются показатели брони, жизни и урона.");
                Console.WriteLine("currencyExchange или 4 - обмен денежной валюты в вашем кошельке");
                Console.WriteLine("exit или 5 - выход");
                userAction = Console.ReadLine();

                switch (userAction)
                {
                    case "1":
                    case "changeConsoleColor":
                        Console.WriteLine("\nИзменение цвнта консоли");
                        Console.WriteLine("Выберете один из предложенных вариантов и впишите номер:");
                        Console.WriteLine("1 - зеленый цвет");
                        Console.WriteLine("2 - красный цвет");
                        Console.WriteLine("3 - черный цвет");
                        Console.WriteLine("4 - белый цвет");
                        selectionConsoleColor = Console.ReadLine();

                        switch (selectionConsoleColor)
                        {
                            case "1":
                                Console.BackgroundColor = ConsoleColor.Green;
                                Console.Clear();
                                break;
                            case "2":
                                Console.BackgroundColor = ConsoleColor.Red;
                                Console.Clear();
                                break;
                            case "3":
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Clear();
                                break;
                            case "4":
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.Clear();
                                break;
                        }
                        break;

                    case "2":
                    case "changeFontColor":

                        Console.WriteLine("\nИзменение цвета шрифта");
                        Console.WriteLine("Выберете один из предложенных вариантов и впишите номер:");
                        Console.WriteLine("1 - зеленый цвет");
                        Console.WriteLine("2 - красный цвет");
                        Console.WriteLine("3 - черный цвет");
                        Console.WriteLine("4 - белый цвет");
                        selectionFontColor = Console.ReadLine();

                        switch (selectionFontColor)
                        {
                            case "1":
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Clear();
                                break;
                            case "2":
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.Clear();
                                break;
                            case "3":
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Clear();
                                break;
                            case "4":
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.Clear();
                                break;
                        }
                        break;

                    case "3":
                    case "thePowerOfRandomness":

                        while (true)
                        {
                            Console.Clear();
                            float health1 = rand.Next(100, 120);
                            float health2 = rand.Next(80, 300);
                            int armor1 = rand.Next(45, 100);
                            int armor2 = rand.Next(35, 100);
                            int damage1 = rand.Next(10, 50);
                            int damage2 = rand.Next(15, 20);

                            Console.WriteLine($"\nГладиатор 1: {health1} хп, {damage1} урона, {armor1} брони.");
                            Console.WriteLine($"Гладиатор 2: {health2} хп, {damage2} урона, {armor2} брони.");
                            Console.ReadKey();
                            while (health1 > 0 && health2 > 0)
                            {
                                health1 -= Convert.ToSingle(rand.Next(0, damage2)) / 100 * armor1;
                                health2 -= Convert.ToSingle(rand.Next(0, damage1)) / 100 * armor2;
                                Console.WriteLine($"Гладиатор 1: {health1}.");
                                Console.WriteLine($"Гладиатор 2: {health2}.");
                            }
                            if (health1 <= 0 && health2 <= 0)
                            {
                                Console.WriteLine("Ничья, оба мертвы.");
                            }
                            else if (health1 <= 0)
                            {
                                Console.WriteLine($"Гладиатор 1 погиб.");
                            }
                            else if (health2 <= 0)
                            {
                                Console.WriteLine($"Гладиатор 2 погиб.");
                            }
                            Console.WriteLine($"Для продолжения игры, нажмине на клавишу 'Enter'.\nДля окончания работы введите 'exit'");
                            message = Console.ReadLine();
                            Console.Clear();
                            if (message == "exit")
                            {
                                Console.Clear();
                                break;
                            }
                        }
                        break;

                    case "4":
                    case "currencyExchange":

                        Console.WriteLine($"\nДобрый день! На сегоднешний день в вашем кошельке находится: ");
                        Console.Write($"Введите кол-во доллоров в вашем кошельке: ");
                        dollor = Convert.ToSingle(Console.ReadLine());
                        Console.Write($"Введите кол-во рублей в вашем кошельке: ");
                        rub = Convert.ToSingle(Console.ReadLine());

                        while (true)
                        {
                            Console.WriteLine($"Вы можете обменять валюты, варианты будут описаны ниже.");
                            Console.WriteLine($"1 - Обменять рубли на доллары");
                            Console.WriteLine($"2 - Обменять доллары на рубли");
                            userExchanger = Console.ReadLine();

                            switch (userExchanger)
                            {
                                case "1":
                                    Console.WriteLine($"\nОбмен рублей на доллары");
                                    Console.Write("Cколько вы хотите обменять: ");
                                    correncyCount = Convert.ToSingle(Console.ReadLine());
                                    if (rub >= correncyCount)
                                    {
                                        rub -= correncyCount;
                                        dollor += correncyCount / rubToDollor;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nНедопустимое кол-во валюты!");
                                    }
                                    break;

                                case "2":
                                    Console.WriteLine($"\nОбмен долларов на рубли");
                                    Console.Write("Cколько вы хотите обменять: ");
                                    correncyCount = Convert.ToSingle(Console.ReadLine());
                                    if (dollor >= correncyCount)
                                    {
                                        dollor -= correncyCount;
                                        rub += correncyCount * dollorToRub;
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nНедопустимое кол-во валюты!");
                                    }
                                    break;
                            }
                            Console.WriteLine($"\nВаш баланс в кошельке: {rub} рублей и {dollor} долларов.");
                            Console.WriteLine($"\nДля продолжения обмена валют, нажмине на клавишу 'Enter'.\nДля окончания работы введите 'exit'");
                            message = Console.ReadLine();
                            if (message == "exit")
                            {
                                Console.Clear();
                                break;
                            }
                        }
                        break;
                }
                if (userAction == "exit" || userAction == "5")
                {
                    break;
                }
            }
        }
    }
}
