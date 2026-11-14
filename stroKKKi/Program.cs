//21 вариант. Средний уровень
//try
//{
//    char[] inputElements = new char[12];
//    Console.Write("Введите 12 символов строки: ");
//    string input = Console.ReadLine();
//    for (int k = 0; k < 12; k++)
//    {
//        if (k < input.Length)
//            inputElements[k] = input[k];
//        else
//            inputElements[k] = ' ';
//    }
//    int i = 0;
//    while (i < 12)
//    {
//        if (!char.IsLetterOrDigit(inputElements[i]))
//        {
//            i++;
//            continue;
//        }
//        int wordStart = i;
//        while (i < 12 && char.IsLetterOrDigit(inputElements[i]))
//        {
//            i++;
//        }
//        int wordEnd = i;
//        int wordLength = wordEnd - wordStart;
//        char[] wordSubArray = new char[wordLength];
//        for (int j = 0; j < wordLength; j++)
//        {
//            wordSubArray[j] = inputElements[wordStart + j];
//        }
//        Console.Write("массив: [");
//        for (int j = 0; j < wordSubArray.Length; j++)
//        {
//            Console.Write($"'{wordSubArray[j]}'");
//            if (j < wordSubArray.Length - 1) Console.Write(", ");
//        }
//        Console.WriteLine("]");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine($"Ошибка: {ex.Message}");
//}

//int[] a =new int[5];
//Random r = new Random();
//for (int i = 0; i < a.Length; i++)
//{
//    a[i] = r.Next(1, 10);
//    Console.Write(a[i]+" ");
//}
//Console.WriteLine();
//Array.Clear(a);
//for (int i = 0; i < a.Length; i++)
//{
//    Console.Write(a[i] + " ");
//}
//Console.WriteLine();
//int[] b = new int[5];
//a.CopyTo(b, 0);
//for (int i = 0; i < b.Length; i++)
//{
//    Console.Write(b[i] + " ");
//}
//Console.WriteLine();
//Array.Sort(b);
//for (int i = 0; i < b.Length; i++)
//{
//    Console.Write(b[i] + " ");
//}
//Console.WriteLine();
//using System.Text.RegularExpressions;
//string s = "Бык тупогуб, тупогубенький бычок, у быка губа бела была тупа";
//Regex regex = new Regex(@"туп(\w*)");
//MatchCollection matches = regex.Matches(s);
//if (matches.Count > 0)
//{
//    foreach (Match match in matches)
//        Console.WriteLine(match.Value);
//}
//else Console.WriteLine("Нет совпадений");
//using System.Text.RegularExpressions;
//string s = "456-435-2318";
//string pattern = "^[0-9]{3}-[0-9]{3}-[0-9]{4}$";
//if (Regex.IsMatch(s, pattern, RegexOptions.IgnoreCase))
//    Console.WriteLine("OK");
//else Console.WriteLine("No");

// Средний уровень 22 вариант
using System.Text;

Console.Write("Введите строку: "); // Ifmmp!Xpsme
string str = Console.ReadLine()!;
StringBuilder sb = new StringBuilder(str);

for (int i = 0; i < sb.Length; i++)
{
    sb[i] = (char)(sb[i] - 1);
}
Console.WriteLine($"Результат обработки: {sb.ToString()}"); // Ifmmp!Xpsme = Hello World