// Высокий (Лабораторная 2, 21 Вариант)
//Console.WriteLine($"{Math.PI:F2}");
//Console.WriteLine($"{Math.E:F1}");
//int a = int.Parse(Console.ReadLine());
//Console.WriteLine($"Вы ввели число {a}");
//int x = int.Parse(Console.ReadLine());
//Console.WriteLine($"{x} - вот такое число вы ввели");
//Console.WriteLine("1 13 49");
//Console.WriteLine("7  15  100");
//try
//{
//    double a = double.Parse(Console.ReadLine());
//    double b = double.Parse(Console.ReadLine());
//    double c = double.Parse(Console.ReadLine());
//    double d = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
//    Console.WriteLine($"D = {d}");
//}
//catch(Exception ex){
//    Console.WriteLine(ex.Message);
//}
try
{
    Console.Write("Введите x:");
    double x = double.Parse(Console.ReadLine());
    double y = double.Parse(Console.ReadLine());
    double z = (x + ((2 + y) / x * x)) / (y + (1 / Math.Sqrt(x * x + 10)));
    Console.Write($"z={z:F2}");
    double q = 2.8 * Math.Sin(x) + Math.Abs(y);
    Console.Write($"q={q:F2}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}