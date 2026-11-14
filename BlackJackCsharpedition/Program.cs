// Использование современных коллекций и генератора случайных чисел
int[] deck =; // Синтаксис коллекций C# 12

// Используем Random.Shared вместо создания нового экземпляра Random
List<int> playerHand = [.. Random.Shared.GetItems(deck, 2)];
List<int> dealerHand = [.. Random.Shared.GetItems(deck, 2)];

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
    string? choice = Console.ReadLine()?.ToLower();

    if (choice is "д" or "н")
    {
        playerHand.Add(Random.Shared.GetItems(deck, 1)[0]);
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
    dealerHand.Add(Random.Shared.GetItems(deck, 1)[0]);
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

// Локальная функция для подсчета очков (вместо статического метода класса)
int CalculateScore(List<int> hand)
{
    int score = 0;
    int acesCount = 0;

    foreach (int card in hand)
    {
        score += card;
        if (card == 11) acesCount++;
    }

    while (score > 21 && acesCount > 0)
    {
        score -= 10;
        acesCount--;
    }

    return score;
}
