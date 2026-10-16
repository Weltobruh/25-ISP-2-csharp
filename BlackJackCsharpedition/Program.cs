using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();

        // Карты в колоде (от 2 до 11 очков). Для простоты используем только номиналы очков.
        // Туз изначально весит 11.
        int[] deck = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10, 11 };

        List<int> playerHand = new List<int>();
        List<int> dealerHand = new List<int>();

        // Раздача первых двух карт игроку и дилеру
        playerHand.Add(deck[rnd.Next(deck.Length)]);
        playerHand.Add(deck[rnd.Next(deck.Length)]);

        dealerHand.Add(deck[rnd.Next(deck.Length)]);
        dealerHand.Add(deck[rnd.Next(deck.Length)]);

        Console.WriteLine("=== ДОБРО ПОЖАЛОВАТЬ В БЛЭКДЖЕК ===");

        // --- Ход Игрока ---
        while (true)
        {
            int playerScore = CalculateScore(playerHand);
            Console.WriteLine($"\nВаши карты: {string.Join(", ", playerHand)} (Всего очков: {playerScore})");
            Console.WriteLine($"Первая карта дилера: {dealerHand[0]}");

            if (playerScore == 21)
            {
                Console.WriteLine("Блэкджек! Отличный результат.");
                break;
            }
            if (playerScore > 21)
            {
                Console.WriteLine("Перебор! Вы проиграли.");
                return; // Завершаем программу
            }

            Console.Write("Хотите взять карту? (д/н): ");
            string choice = Console.ReadLine()?.ToLower();

            if (choice == "д" || choice == "y")
            {
                playerHand.Add(deck[rnd.Next(deck.Length)]);
            }
            else
            {
                break;
            }
        }

        // --- Ход Дилера ---
        int dealerScore = CalculateScore(dealerHand);
        Console.WriteLine($"\n--- Ход Дилера ---");
        Console.WriteLine($"Карты дилера: {string.Join(", ", dealerHand)} (Всего очков: {dealerScore})");

        // Дилер обязан брать карты, пока у него меньше 17 очков
        while (dealerScore < 17)
        {
            Console.WriteLine("Дилер берет карту...");
            dealerHand.Add(deck[rnd.Next(deck.Length)]);
            dealerScore = CalculateScore(dealerHand);
            Console.WriteLine($"Карты дилера: {string.Join(", ", dealerHand)} (Всего очков: {dealerScore})");
        }

        // --- Определение победителя ---
        int finalPlayerScore = CalculateScore(playerHand);

        Console.WriteLine("\n=== ИТОГ ИГРЫ ===");
        Console.WriteLine($"Ваши очки: {finalPlayerScore}");
        Console.WriteLine($"Очки дилера: {dealerScore}");

        if (dealerScore > 21)
        {
            Console.WriteLine("У дилера перебор! Вы выиграли! 🎉");
        }
        else if (finalPlayerScore > dealerScore)
        {
            Console.WriteLine("Вы набрали больше очков и выиграли! 🏆");
        }
        else if (finalPlayerScore < dealerScore)
        {
            Console.WriteLine("Дилер выиграл. Повезет в следующий раз! 🤖");
        }
        else
        {
            Console.WriteLine("Ничья (Пуш)!");
        }
    }

    // Метод для подсчета очков с учетом правил для Туза (11 или 1)
    static int CalculateScore(List<int> hand)
    {
        int score = 0;
        int acesCount = 0;

        foreach (int card in hand)
        {
            score += card;
            if (card == 11) acesCount++;
        }

        // Если перебор, но есть тузы, считаем туз за 1 очко вместо 11
        while (score > 21 && acesCount > 0)
        {
            score -= 10;
            acesCount--;
        }

        return score;
    }
}
