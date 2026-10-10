// 6.22
//try
//{
//    long n = long.Parse(Console.ReadLine());
//    int k3 = 0;
//    int kLast = 0;
//    int kOdd = 0;
//    long sum5 = 0;
//    long mult7 = 1;
//    int k05 = 0;
//    long last = n % 10;
//    int temp = 0;
//    while (n != 0)
//    {
//        if (temp == 3) k3++;
//        if (temp == last) kLast++;
//        if (temp % 2 == 0) kOdd++;
//        if (temp>5) sum5+=temp;
//        if (temp>7) mult7+=temp;
//        if (temp == 0 || temp == 5) k05++;
//        n /= 10;
//    }
//Console.WriteLine($"а) {k3}");
//Console.WriteLine($"б) {kLast}");
//Console.WriteLine($"в) {kOdd}");
//Console.WriteLine($"г) {sum5}");
//Console.WriteLine($"д) {mult7}");
//Console.WriteLine($"е) {k05}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//for(int i = 1; i <= 9; i++)
//{
//    for(int j = 1; j <= 9; j++)
//    {
//        Console.Write($"{i}*{j}={i*j}  ");
//    }
//    Console.WriteLine();
//}
//for(int i = 10; i <=50; i += 10)
//{
//    int c = i / 10;
//    for (int j = 0; j < c; j++)
//    {
//        Console.Write(i + " ");
//    }
//    Console.WriteLine("");
//}
//try
//{
//    Console.WriteLine("Введите: ");
//    int k = int.Parse(Console.ReadLine());
//    double A = 1;
//    for (int j = 1; j < k; j++)
//    {
//        if (j == 3 || j == 4) continue;
//        double s = 0;
//        for (int i = j; i <= k; i++)
//        {
//            if (i == 1) continue;
//            s += Math.Pow(i-5,1/3.0) / (i - 1);
//        }
//        A *= ((j - 4) * j / (j - 3)) * s;
//    }
//    Console.WriteLine($"S={A:F2}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    Console.WriteLine("Введите n: ");
//    int n = int.Parse(Console.ReadLine());
//    Console.WriteLine("Введите x: ");
//    double x = double.Parse(Console.ReadLine());
//    double s = 0;
//    for (int i = 1; i < n; i++)
//    {
//        s += Math.Sin((2 * i - 1) * Math.Pow(x, 2 * i - 1));
//    }
//    Console.WriteLine($"S={s:F2}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    double h = 0.2;
//    Console.WriteLine("|   x   |   y   |");
//    Console.WriteLine("-----------------");
//    for (double x = 1.1; x < 3.1; x =+ 0.2)
//    {
//        double y = 3 * x - 2 * Math.Log(x) - 5;
//        Console.WriteLine($"|   {x:f1}   |   {y:f2}   |");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    double h = 0.2;
//    Console.WriteLine("|   x   |   y   |");
//    Console.WriteLine("-----------------");
//    for (double x = -Math.PI/4; x <= 7*Math.PI/4; x = +0.2)
//    {
//        double y;
//        if (x > 2.5) y = Math.Cos(2.3 * x + 1);
//        else if (x >= 0 && x <= 2.5) y = 3 * Math.Log(Math.Abs(1-x*x*x));
//        else y = x*x;
//        Console.WriteLine($"|   {x:f1}   |   {y:f2}   |");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    double h = 0.2;
//    Console.WriteLine("|   x   |   y   |");
//    Console.WriteLine("-----------------");
//    for (double x = -1; x <= 2; x = +0.3)
//    {
//        double y;
//        if (x > 0)
//        {
//            y = 0;
//            for (int k = 1; k <= 5; k++)
//            {
//                y += Math.Pow(x, k) / (15 - k * k);
//            }
//        }
//        else y = Math.Exp(3.5 * x);
//        Console.WriteLine($"|   {x:f1}   |   {y:f2}   |");
//    }
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//21 Вариант, Высокий уровень. Операторы цикла с предусловием и постусловием
try
{
    for (int i = 1000; i <= 9999; i++)
    {
    int t = i / 1000;
    int s = (i / 100) % 10;
    int d = (i / 10) % 10;
    int e = i % 10;
    if (t != s && t != d && t != e && s != d && s != e && d != e)
    {
        Console.WriteLine(i);
    }
}
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

// 21 Вариант, базовый уровень. Оператор цикла for
try
{
    for (int n = 11; n <= 99; n++)
    {
        Console.WriteLine($"{n}^2 = {n * n}");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
// 21 вариант, Вычисление бесконечных сумм


// 21 вариант, средний уровень. Табулирование функций
try
{
    double h = 0.2;
    Console.WriteLine("|   x   |   y   |");
    Console.WriteLine("-----------------");

    for (double x = -1.5; x <= 1.5; x += h)
    {
        double y;
        if (x > 1)
        {
            y = x + Math.Sqrt(1 + Math.Abs(Math.Cos(x)));
        }
        else if (x >= -0.5)
        {
            y = x;
        }
        else y = Math.Pow(x, 2) - 2;
        Console.WriteLine($"|   {x:f1}   |   {y:f2}   |");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
