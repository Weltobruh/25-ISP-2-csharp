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
//try
//{
//    Console.Write("Введите x:");
//    double x = double.Parse(Console.ReadLine());
//    double y = double.Parse(Console.ReadLine());
//    double z = (x + ((2 + y) / x * x)) / (y + (1 / Math.Sqrt(x * x + 10)));
//    Console.Write($"z={z:F2}");
//    double q = 2.8 * Math.Sin(x) + Math.Abs(y);
//    Console.Write($"q={q:F2}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

// Сборник задач Златопольский
//2.2
//try
//{
//    Console.Write("Введите килограмы: ");
//    double kg = double.Parse(Console.ReadLine());
//    double c = kg / 10;
//    Console.WriteLine($"{kg}кг = {c}ц");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

////2.3
//try
//{
//    Console.Write("Введите килограмы: ");
//    double kg = double.Parse(Console.ReadLine());
//    double t = kg / 1000;
//    Console.WriteLine($"{kg}кг = {t}т");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

////2.4
//try
//{
//    Console.Write("Введите метры: ");
//    double m = double.Parse(Console.ReadLine());
//    double km = m / 1000;
//    Console.WriteLine($"{m}метров = {km}километров");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

////2.5
//try
//{
//    int d = 234;
//    int w = d / 7;
//    Console.WriteLine($"Прошло {w} недель");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

//2.6
//try {
//    Console.Write("Введите количество секунд: ");
//    int n = int.Parse(Console.ReadLine());
//    int hours = n / 3600;
//    Console.WriteLine($"а) Полных часов прошло: {hours}");

//    int minutes = (n % 3600) / 60;
//    Console.WriteLine($"б) Полных минут с начала часа: {minutes}");

//    int seconds = n % 60;
//    Console.WriteLine($"в) Полных секунд с начала минуты: {seconds}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
// ЗЗадание
//try
//{
//    Console.Write("Введите четырёхзначное число: ");
//    int n = int.Parse(Console.ReadLine());
//    int a = n % 10;
//    int b = n % 100 / 10;
//    int c = n % 1000 / 100;
//    int d = n / 1000;
//    Console.WriteLine($"{a + b + c + d}");
//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}

// Задание 3.6
try
{
    Console.Write("Введите номер места (от 1 до 36): ");
    int seat = int.Parse(Console.ReadLine());

    int coupe = (seat + 3) / 4;

    Console.WriteLine($"Номер купе: {coupe}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
