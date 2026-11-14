//double DoFunc(int x)
//{
//    return (Math.Sqrt(x) + x) / 2;
//}
//double y = DoFunc(6) + DoFunc(13) + DoFunc(21);
//Console.WriteLine($"y = {y:F2}");
//double Max(double a, double b)
//{
//    if (a > b) return a;
//    else return b;
//}
//try
//{
//    Console.Write("Введите a:");
//    double a = double.Parse(Console.ReadLine()!);
//    Console.Write("Введите b:");
//    double b = double.Parse(Console.ReadLine()!);
//    Console.WriteLine($"z={Max(a, 2 * b) * Max(2 * a - b, b):F2}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//int OddCount(int[] mas)
//{
//    int count = 0;
//    for (int i = 0; i < mas.Length; i++)
//    {
//        if (mas[i] % 2 == 0) count++;
//    }
//    return count;
//}
//int EvenCount(int[] mas)
//{
//    int count = 0;
//    for (int i = 0; i < mas.Length; i++)
//    {
//        if (mas[i] % 2 != 0) count++;
//    }
//    return count;
//}
//int[] GetMas(int[] mas)
//{
//    Random rand = new Random();
//    for(int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rand.Next(1, 10);
//    }
//    return mas;
//}
//void Print(int[] mas)
//{
//    for (int i = 0; i <= mas.Length; i++)
//    {
//        Console.Write($"{mas[i]} ");
//    }
//    Console.WriteLine();
//}
//int[] mas1 = new int[8];
//mas1 = GetMas(mas1);
//Print(mas1);
//int[] mas2 = new int[8];
//mas2 = GetMas(mas2);
//Print(mas2);

//void Increment(int n)
//{
//    Console.WriteLine($"Число в методе Increment: {n}");
//}
//void Swap(int a, int b)
//{
//    int temp = a;
//    a = b;
//    b = temp;
//}
//void SwapRef(ref int a, ref int b)
//{
//    int temp = a;
//    a = b;
//    b = temp;
//}
//int x = 7;
//int y = 6;
//Console.WriteLine($"x={x} y={y}");
//Swap(x, y);
//Console.WriteLine($"x={x} y={y}");
//SwapRef(ref x, ref y);
//Console.WriteLine($"x={x} y={y}");
//void Sum(int x, int y, out int result)
//{
//    result = x = y;
//}
//int number;
//Sum(15, 10, out number);
//Console.WriteLine(number);
//try
//{
//    int x = int.Parse(Console.ReadLine()!);
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//int x;
//int.TryParse(Console.ReadLine(), out x);
//void GetRevtangleData(in int width, in int height, out int rectArea, out int rectPerimetr)
//{
//    rectArea = width * height;
//    rectPerimetr = (width + height) * 2;
//}
//int w = 10;
//int h = 10;
//int area, perimetr;
//GetRevtangleData(w, h, out area, out perimetr);
//Console.WriteLine($"Площадь = {area}");
//Console.WriteLine($"Периметр = {perimetr}");
//void Summa(params int[] mas)
//{
//    int result = 0;
//    foreach (int i in mas) result += i;
//    Console.WriteLine(result);
//}
//int[] nums = { 1, 2, 3, 4, 5 };
//Summa(nums);


// 1 вариант средний уровень

try {
    string ConvertBinary(long a)
    {
        if (a == 0)
        {
            return "0";
        }

        bool negativ = a < 0;
        long num = Math.Abs(a);

        string binary = "";
        while (num > 0)
        {
            long ostatok = num % 2;
            binary = ostatok + binary;
            num /= 2;
        }

        return negativ ? "-" + binary : binary;
    }
    Console.Write("Введите десятичное число a: ");

    if (long.TryParse(Console.ReadLine(), out long a))
    {
        string result = ConvertBinary(a);

        Console.WriteLine($"Десятичное число: {a}");
        Console.WriteLine($"Двоичное число:   {result}");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}