//int[] mas1 = new int[5];
//int[] mas2 = {1,4,2,9,3};
//int[] mas3 = mas2;
//mas3[3] = 12;
//Console.WriteLine(mas3[3]);
//Console.WriteLine(mas2[3]);
//ввод в ручную
//int[] mas4 = new int[5];
//for (int i = 0; i < mas4.Length; i++)
//    mas4[i] = int.Parse(Console.ReadLine());
//for (int i = 0; i < mas4.Length; i++)
//    Console.Write($"{mas4[i]} ");
//ввод по формуле
//int[] mas5 = new int[5];
//for (int i = 0; i < mas5.Length; i++)
//{
//    mas5[i] = 2 * i + 1;
//    Console.Write($"{mas5[i]} ");
//}
//генератор случ. чисел
//Random rnd = new Random();
//int[] mas6 = new int[rnd.Next(1, 9999)];
//for (int i = 0; i < mas6.Length; i++)
//{
//    mas6[i] =rnd.Next(1, 100);
//    Console.Write($"{mas6[i]} ");
//}
//try
//{
//    int[] mas = new int[10];
//    Random rnd = new Random();
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-7, 8);
//        Console.Write($"{mas[i]} ");
//    }
//    Console.WriteLine();
//    Console.Write("Введите n:");
//    int n = int.Parse(Console.ReadLine());
//    int index = -1;
//    int less_n = 0;
//    for(int i = 0; i < mas.Length; i++)
//    {
//        if (mas[i] == n) index = i;
//        if (mas[i] < n) less_n++;
//    }
//    Console.WriteLine($"Индекс последнего вхождения {n} = {index}");
//    Console.WriteLine($"Кол-во элементов меньших {n} = {less_n}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

try
{
    Console.Write("Введите n");
    int n = int.Parse(Console.ReadLine());
    Random rnd = new Random();
    int[] mas = new int[n];
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = rnd.Next(-10, 11);
        Console.Write($"{mas[i]} ");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}