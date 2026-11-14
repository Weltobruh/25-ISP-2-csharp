//int n = int.Parse(Console.ReadLine());
//switch (n)
//{
//    case 1:
//        Console.WriteLine("Понеделmник");
//        break;
//    case 2:
//        Console.WriteLine("Вторник");
//        break;
//    case 3:
//        Console.WriteLine("Среда");
//        break;
//    case 4:
//        Console.WriteLine("Четверг");
//        break;
//    case 5:
//        Console.WriteLine("Пятница");
//        break;
//    case 6:
//        Console.WriteLine("Суббота");
//        break;
//    case 7:
//        Console.WriteLine("Воскресенmе");
//        break;
//}
//try
//{
//    Console.Write("Введите номер месяца");
//    int n = int.Parse(Console.ReadLine());
//    switch (n)
//    {
//        case 12: case 1: case 2:
//            Console.WriteLine("Зима");
//            break;
//        case 3:case 4:case 5:
//            Console.WriteLine("Весна");
//            break;
//        case 6:case 7:case 8:
//            Console.WriteLine("Лето");
//            break;
//        case 9:case 10:case 11:
//            Console.WriteLine("Осенm");
//            break;
//    }
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    Console.Write("Введите номер карты");
//    int n = int.Parse(Console.ReadLine());
//    int m = int.Parse(Console.ReadLine());
//    switch (n)
//    {
//        case 6:
//            Console.WriteLine("6");
//            break;
//        case 7:
//            Console.WriteLine("7");
//            break;
//        case 8:
//            Console.WriteLine("8");
//            break;
//        case 9:
//            Console.WriteLine("9");
//            break;
//        case 10:
//            Console.WriteLine("10");
//            break;
//        case 11:
//            Console.WriteLine("Валет");
//            break;
//        case 12:
//            Console.WriteLine("Дама");
//            break;
//        case 13:
//            Console.WriteLine("Королm");
//            break;
//        case 14:
//            Console.WriteLine("Туз");
//            break;
//        default:
//            Console.WriteLine("Ты тупой(");
//                break;
//    }
//    switch (m)
//    {
//        case 1:
//            Console.WriteLine("Трефы");
//            break;
//        case 2:
//            Console.WriteLine("Пики");
//            break;
//        case 3:
//            Console.WriteLine("Черви");
//            break;
//        case 4:
//            Console.WriteLine("Бубны");
//            break;
//        default:
//            Console.WriteLine("Ты тупой(");
//            break;
//    }

//}
//catch (Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}
//try
//{
//    Console.Write("Введите число рублей: ");
//    int n = int.Parse(Console.ReadLine());
//    int m = Math.Abs(n) % 100;
//    int x = Math.Abs(n) % 10;

//    switch (m)
//    {
//        case 11:case 12:case 13:case 14:
//            Console.WriteLine($"{n} рублей");
//            break;

//        default:
//            switch (x)
//            {
//                case 1:
//                    Console.WriteLine($"{n} рубль");
//                    break;
//                case 2:
//                case 3:
//                case 4:
//                    Console.WriteLine($"{n} рубля");
//                    break;
//                default:
//                    Console.WriteLine($"{n} рублей");
//                    break;
//            }
//            break;
//    }
//}
//catch( Exception ex )
//{
//    Console.WriteLine(ex.Message);

// 12 вариант. базовый уровень
try
{
    Console.Write("Введите число: ");
    double x = double.Parse(Console.ReadLine());
    double a = 0, b = 0, c = 0;

    switch (x)
    {
        case 1:
            {
                a = 45; b = 13; c = -23;
            }
            break;
        case 2:
            {
                a = -31; b = 65; c = 12;
            }
            break;
        case 3:
            {
                a = 52; b = -1; c = -33;
            }
            break;
    }

    double min = Math.Min(a, Math.Min(b, c));
    Console.WriteLine($"Наименьшее число: {min}");

}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

// 12 вариант. средний уровень
try
{
    Console.Write("Введите номер теста (1, 2 или 3): ");
    int test = int.Parse(Console.ReadLine());
    double k = 0, m = 0, n = 0;

    switch (test)
    {
        case 1:
            k = 4; m = -14.7; n = -0.6;
            break;
        case 2:
            k = 3; m = 6.5; n = 3.15;
            break;
        case 3:
            k = 5; m = -12; n = 0.45;
            break;
    }

    Console.Write("Введите значение x: ");
    double x = double.Parse(Console.ReadLine());
    double y;

    if (3 * x > Math.Abs(m + n))
    {
        y = Math.Log(Math.Abs(Math.Log10(Math.Abs(k * x + m * n))));
    }
    else if (3 * x == Math.Abs(m + n))
    {
        y = Math.Sin(k * m * x) + Math.Sqrt(Math.Abs(n * x));
    }
    else
    {
        y = Math.Exp(Math.Cos(x)) + Math.Exp(m + n);
    }
        Console.WriteLine($"Результат y = {y}");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}
