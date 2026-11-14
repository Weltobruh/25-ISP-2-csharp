//30 вариант базовый уровень
//Random rnd = new Random();
//int[,] mas = new int[rnd.Next(4,9),rnd.Next(4,9)];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = rnd.Next(-3, 4);
//        Console.Write($"{mas[i, j]} ");
//    }
//    Console.WriteLine();
//}
//int count = 0;
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    if (mas[i, 1] >= 0) count++;
//}
//Console.WriteLine($"Количество отрицательных элементов во втором столбце {count}");

//30 вариант средний уровень
//try
//{
//    Random rnd = new Random();
//    Console.Write("Введите количество строк:");
//    int n = int.Parse(Console.ReadLine()!);
//    Console.Write("Введите количество столбцов:");
//    int m = int.Parse(Console.ReadLine()!);
//    int[,] mas = new int[n, m];
//    for (int i = 0; i < mas.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas.GetLength(1); j++)
//        {
//            mas[i, j] = rnd.Next(1, 10);
//            Console.Write($"{mas[i, j]} ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//    for (int i = 0; i < mas.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas.GetLength(1) - 1; j++)
//        {
//            for (int k = j + 1; k < mas.GetLength(1); k++)
//            {
//                if (mas[i, j] > mas[i, k])
//                {
//                    int temp = mas[i, j];
//                    mas[i, j] = mas[i, k];
//                    mas[i, k] = temp;
//                }
//            }
//        }
//    }
//    Console.WriteLine();
//    for (int i = 0; i < mas.GetLength(0); i++)
//    {
//        for (int j = 0; j < mas.GetLength(1); j++)
//        {
//            Console.Write($"{mas[i, j]} ");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();
//    int max = -1;
//    int row = -1;
//    for (int i = 0; i < mas.GetLength(0); i++)
//    {
//        int k = 1;
//        int maxk = 0;
//        for (int j = 1; j < mas.GetLength(1); j++)
//        {
//            if (mas[i, j - 1] == mas[i, j]) k++;
//            else
//            {
//                int temp = k;
//                if (temp > maxk) maxk = temp;
//                k = 1;
//            }
//        }
//        Console.WriteLine(maxk);
//        if (maxk > max)
//        {
//            max = maxk;
//            row = i;
//        }
//    }
//    Console.WriteLine();
//    Console.WriteLine(row);
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//30 вариант высокий уровень
//int[,] mas = new int[5, 5];
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        mas[i, j] = 1;
//        Console.Write($"{mas[i, j]} ");
//    }
//    Console.WriteLine();
//}
//Console.WriteLine();
//mas[1, 2] = 0;
//mas[3, 2] = 0;
//mas[2, 1] = 0;
//mas[2, 3] = 0;
//for (int i = 0; i < mas.GetLength(0); i++)
//{
//    for (int j = 0; j < mas.GetLength(1); j++)
//    {
//        Console.Write($"{mas[i, j]} ");
//    }
//    Console.WriteLine();
//}


// 27 вариант Высокий уровень
Random rnd = new Random();
Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите количество столбцов: ");
int m = int.Parse(Console.ReadLine()!);
int[,] mas = new int[n, m];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        mas[i, j] = rnd.Next(1, 5);
        Console.Write($"{mas[i, j]}\t");
    }
    Console.WriteLine();
}int count = 0;

for (int i = 1; i < n; i++)
{
    bool nPohoz = true;
    for (int j = 0; j < m && nPohoz; j++)
    {
        bool found = false;
        for (int k = 0; k < m; k++)
        {
            if (mas[0, j] == mas[i, k])
            {
                found = true; break;
            }
        }
        if (!found) nPohoz = false;
    }
    for (int j = 0; j < m && nPohoz; j++)
    {
        bool found = false;
        for (int k = 0; k < m; k++)
        {
            if (mas[i, j] == mas[0, k])
            {
                found = true; break;
            }
        }
        if (!found) nPohoz = false;
    }

    if (nPohoz) count++;
}
Console.WriteLine($"Количество строк, похожих на первую: {count}");

