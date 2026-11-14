Console.Write("Введите текст предложения: ");
        string input = Console.ReadLine();
        char[] textArray = input.ToCharArray();
        int totalWords = 0;
        bool inWord = false;
        for (int i = 0; i < textArray.Length; i++)
        {
            if (textArray[i] != ' ')
            {
                if (!inWord)
                {
                    totalWords++;
                    inWord = true;
                }
            }
            else
            {
                inWord = false;
            }
        }
        if (totalWords == 0)
        {
            Console.WriteLine("Слова в тексте не найдены.");
            return;
        }
        Console.WriteLine("\nРезультат обработки:");

        int wordIndex = 0;
        int idx = 0;

        while (idx < textArray.Length)
        {
            if (textArray[idx] == ' ')
            {
                idx++;
                continue;
            }
            int start = idx;
            while (idx < textArray.Length && textArray[idx] != ' ')
            {
                idx++;
            }
            int length = idx - start;
            wordIndex++;
            if (wordIndex % 2 == 0)
            {
                char[] word = new char[length];
                for (int k = 0; k < length; k++)
                {
                    word[k] = textArray[start + k];
                }

                for (int k = 0; k < length / 2; k++)
                {
                    char temp = word[k];
                    word[k] = word[length - 1 - k];
                    word[length - 1 - k] = temp;
                }

                for (int k = 0; k < length; k++)
                {
                    Console.Write(word[k]);
                }
                Console.Write(" ");
            }
        }
Console.WriteLine();