//try
//{
//    Console.Write("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    Console.Write("Введите y:");
//    double y = double.Parse(Console.ReadLine());
//    double max, min;
//    if (x > y)
//    {
//        max = x; min = y;
//    }
//    else
//    {
//        max = y; min = x;
//    }
//    Console.WriteLine($"max = {max}, min = {min}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    Console.Write("Введите a:");
//    double a = double.Parse(Console.ReadLine());
//    Console.Write("Введите b:");
//    double b = double.Parse(Console.ReadLine());
//    Console.Write("Введите c:");
//    double c = double.Parse(Console.ReadLine());
//    double max, min;
//    if((a<b)&&(b<c)) Console.WriteLine($"{a}<{b}<{c}");
//    else Console.WriteLine("НЕ ВЫПОЛНЯЕТСЯ!!!!!!!!!");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    Console.Write("Введите a:");
//    int m = int.Parse(Console.ReadLine());
//    int a = m / 100;
//    int b = m /10 % 10;
//    int c = m % 10;
//    if ((a == 4 || b == 4 || c == 4)||
//        (a == 7 || b == 7 || c == 7)) Console.WriteLine("Yes");
//    else Console.WriteLine("No");

//    if ((a == 6 || b == 6 || c == 6)||
//        (a == 9 || b == 9 || c == 9)) Console.WriteLine("Yes");
//    else Console.WriteLine("No");

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

// 12 вариант. базовый уровень
try
{
    Console.Write("Введите число: ");
    double x = double.Parse(Console.ReadLine());
    switch (x)
    {
        case 1:
            {
                double a = 45, b = 13, c = -23;
                double min = Math.Min(a, Math.Min(b, c));
                Console.WriteLine($"Наименьшее число: {min}");
            }
            break;
        case 2:
            {
                double a = -31, b = 65, c = 12;
                double min = Math.Min(a, Math.Min(b, c));
                Console.WriteLine($"Наименьшее число: {min}");
            }
            break;
        case 3:
            {
                double a = 52, b = -1, c = -33;
                double min = Math.Min(a, Math.Min(b, c));
                Console.WriteLine($"Наименьшее число: {min}");
            }
            break;
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message); 
}
