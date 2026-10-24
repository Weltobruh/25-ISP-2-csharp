//21 вариант. Средний уровень
try
{
    char[] inputElements = new char[12];
    Console.Write("Введите 12 символов строки: ");
    string input = Console.ReadLine();
    for (int k = 0; k < 12; k++)
    {
        if (k < input.Length)
            inputElements[k] = input[k];
        else
            inputElements[k] = ' ';
    }
    int i = 0;
    while (i < 12)
    {
        if (!char.IsLetterOrDigit(inputElements[i]))
        {
            i++;
            continue;
        }
        int wordStart = i;
        while (i < 12 && char.IsLetterOrDigit(inputElements[i]))
        {
            i++;
        }
        int wordEnd = i;
        int wordLength = wordEnd - wordStart;
        char[] wordSubArray = new char[wordLength];
        for (int j = 0; j < wordLength; j++)
        {
            wordSubArray[j] = inputElements[wordStart + j];
        }
        Console.Write("массив: [");
        for (int j = 0; j < wordSubArray.Length; j++)
        {
            Console.Write($"'{wordSubArray[j]}'");
            if (j < wordSubArray.Length - 1) Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}
catch (Exception ex)
{
    Console.WriteLine($"Ошибка: {ex.Message}");
}