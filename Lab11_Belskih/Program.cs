////БАЗОВЫЙ 30
//Console.Write("Введите у:");
//double y = double.Parse(Console.ReadLine());
//Console.Write("Введите r:");
//double r = double.Parse(Console.ReadLine());
//double W = Math.Exp(y + r) + 7.2 * Math.Sin(r);
//Console.WriteLine($"W={W:F2}");
//// СРЕДНИЙ 30
//Console.Write("Введите у:");
//double y = double.Parse(Console.ReadLine());
//Console.Write("Введите p:");
//double p = double.Parse(Console.ReadLine());
//double N = (3 * y * y + Math.Sqrt(y + 1))/(Math.Log(p+y)+Math.Exp(p));
//// ВЫСОКИЙ 30
//Console.Write("Введите x:");
//double x= double.Parse(Console.ReadLine());
//double K = (Math.Sqrt(Math.Pow(3 + x,6) - Math.Log(x))) / (Math.Exp(0) + Math.Asin(6*x*x));
//Console.WriteLine($"K={K:F2}");
//// ВЫСОКИЙ 14
//Console.Write("Введите x:");
//double x = double.Parse(Console.ReadLine());
//double R = Math.Sin(Math.Pow(Math.Pow(x, 2) + 4, 3)) + 4.3 / Math.Pow(Math.Sin(Math.Pow(x, 4)), 3);
//Console.WriteLine($"R={R:F2}");

// Высокий (Лабораторная 1, 21 Вариант)
Console.Write("Введите a:");
double a = double.Parse(Console.ReadLine());
Console.Write("Введите x:");
double x = double.Parse(Console.ReadLine());
Console.Write("Введите z:");
double z = double.Parse(Console.ReadLine());

double N = (Math.Pow(z + Math.Sqrt(z * x), 1.0 / 5.0)) / (Math.Exp(x) + Math.Pow(a, 5) * Math.Atan(x));
Console.Write($"Результат N = {N:F2}");
