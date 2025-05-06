using System;

public class Novel
{
    static int currentIteration = 1;
    static int endingReached = 0; 

    public static void Main(string[] args)
    {
        Console.WriteLine("прив это новелла");

        while (currentIteration <= 20 && endingReached == 0)
        {
            Console.WriteLine($"\n--- Итерация {currentIteration} ---");
            RunIteration();
            currentIteration++;
        }

        if (endingReached > 0)
        {
            Console.WriteLine($"\n Концовка {endingReached}");
            ShowEnding(endingReached);
        }
        else
        {
            Console.WriteLine("\nИгра овер. Ни одна концовка не достигнута(лол).");
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
      
            default:
                Console.WriteLine("нет");
                endingReached = 1; 
                break;
        }
    }
    
    static void Iteration1()
    {
        Console.WriteLine("Вы находитесь в темной комнате. Что будете делать?");
        Console.WriteLine("1. Включить свет.");
        Console.WriteLine("2. Искать выход на ощупь.");

        string choice = Console.ReadLine();

        if (choice == "1")
        {
            Console.WriteLine("Вы включили свет и увидели, что находитесь в лаборатории.");
           
        }
        else if (choice == "2")
        {
            Console.WriteLine("Вы наткнулись на что-то и упали.");

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
        
            endingReached = 2; 
        }
        else if (choice == "2")
        {
            Console.WriteLine("Вы решили не трогать компьютер.");
            
        }
        else
        {
            Console.WriteLine("Неверный ввод.");
        }
    }

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
        
            default:
                Console.WriteLine("1 концовка.");
                break;
        }
    }
}
