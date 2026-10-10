//int s = 0;
//int k = 0;
//int n = 0;
//Console.WriteLine("Введите число:");
//do
//{
//    try
//    {
//        n = int.Parse(Console.ReadLine());
//        s += n;
//        k++;
//    }
//    catch(Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//}
//while (n != 0);
//k--;
//Console.WriteLine($"Сумма чисел = {s}, количество чисел = {k}");
//int k = 6;
//Console.WriteLine(++k);
//Console.WriteLine(k);
//Console.WriteLine(++k*--k);
//Console.WriteLine(k);
//double s = 0;
//int k = 0;
//Console.Write("Введите число: ");
//do
//{
//    try
//    {
//        int n = int.Parse(Console.ReadLine());
//        if (n < 0) break;
//        s += n;
//        k++;
//    }
//    catch (Exception ex)
//    {
//        Console.WriteLine(ex.Message);
//    }
//}
//while (true);
//Console.WriteLine($"Среднее арифметическое: {s/k:F2}");
//int s = 0;
//int i = 0;
//while (i<100)
//{
//    i++;
//    if (i % 5 == 0) continue;
//    s += i;
//}
//Console.WriteLine($"S={s}");
//for (int i = 35; i <= 87; i++)
//{
//	if (i % 7 == 1 || i % 7 == 2 || i % 7 == 5) Console.Write(i+" ");
//}

try
{
    Console.Write("Введите число n: ");
    int n = int.Parse(Console.ReadLine());
    long F = 1;
    for (int i = 1; i <= n; i++) F *= i;
    Console.WriteLine($"Факториал {n}:{F}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
