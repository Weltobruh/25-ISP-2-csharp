//Random random = new Random();
//int[] mas = new int[random.Next(10, 30)];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10, 50);
//    Console.WriteLine(mas[i] + " ");
//}
//Console.WriteLine();
//Console.WriteLine($"{Class0001.MultiMatrix(mas)}");



using BIBLIA;

int[,] mas = new int[7, 4];

for (int i = 0; i < 7; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write($"mas[{i},{j}] = ");
        mas[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

Console.WriteLine();

for (int i = 0; i < 7; i++)
{
    for (int j = 0; j < 4; j++)
    {
        Console.Write(mas[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine($"{Class22.Alikhafaman(mas)}");
