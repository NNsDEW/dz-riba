using System;

public class ConsoleNovel
{
    static int currentIteration = 1;
    static int endingReached = 0; // 0 - нет, 1-10 - номер концовки

    public static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в консольную новеллу!");

        while (currentIteration <= 20 && endingReached == 0)
        {
            Console.WriteLine($"\n--- Итерация {currentIteration} ---");
            RunIteration();
            currentIteration++;
        }

        if (endingReached > 0)
        {
            Console.WriteLine($"\n--- Концовка {endingReached} ---");
            ShowEnding(endingReached);
        }
        else
        {
            Console.WriteLine("\nИгра окончена. Ни одна концовка не достигнута.");
        }

        Console.WriteLine("\nСпасибо за игру!");
    }

    static void RunIteration()
    {
        switch (currentIteration)
        {
            case 1:
                Iteration1();
                break;
            case 2:
                Iteration2();
                break;
            // ... (до 20 итераций)
            default:
                Console.WriteLine("Вы достигли конца доступного контента.");
                endingReached = 1; // Пример достижения концовки
                break;
        }
    }

    //  Далее идут функции для каждой итерации, например:
    static void Iteration1()
    {
        Console.WriteLine("Вы находитесь в темной комнате. Что делаете?");
        Console.WriteLine("1. Включить свет.");
        Console.WriteLine("2. Искать выход на ощупь.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Вы включили свет и увидели, что находитесь в лаборатории.");
            // Дальнейшие варианты выбора и последствия
        }
        else if (choice == "2")
        {
            Console.WriteLine("Вы наткнулись на что-то и упали.");
            // Дальнейшие варианты выбора и последствия
        }
        else
        {
            Console.WriteLine("Неверный ввод.");
        }
    }

    static void Iteration2()
    {
        Console.WriteLine("Вы нашли старый компьютер. Что делаете?");
        Console.WriteLine("1. Попытаться его включить.");
        Console.WriteLine("2. Оставить его в покое.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Компьютер включился, но на экране только текст.");
            // Дальнейшие варианты выбора и последствия
            endingReached = 2; // Пример достижения другой концовки
        }
        else if (choice == "2")
        {
            Console.WriteLine("Вы решили не трогать компьютер.");
            // Дальнейшие варианты выбора и последствия
        }
        else
        {
            Console.WriteLine("Неверный ввод.");
        }
    }

    // Функции для показа концовок:
    static void ShowEnding(int endingNumber)
    {
        switch (endingNumber)
        {
            case 1:
                Console.WriteLine("Вы нашли выход из лаборатории и вернулись домой. Конец.");
                break;
            case 2:
                Console.WriteLine("Текст на компьютере гласит: 'Вы - часть эксперимента'. Конец.");
                break;
            // ... (до 10 концовок)
            default:
                Console.WriteLine("Неизвестная концовка.");
                break;
        }
    }
}
