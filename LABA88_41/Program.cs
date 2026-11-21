//DateTime
//свойства
//DateTime data1 = new DateTime();
//Console.WriteLine(data1);
//DateTime dateNow = DateTime.Now;
//Console.WriteLine(dateNow);
//DateTime date2 = new DateTime(2026, 11, 21);
//Console.WriteLine(date2);
//DateTime date3 = new DateTime(2026, 11, 21, 12, 37, 45);
//Console.WriteLine(date3);
//Console.WriteLine(DateTime.Now);
//Console.WriteLine(DateTime.UtcNow);
//Console.WriteLine(DateTime.Today);
//Console.WriteLine(dateNow.Year);
//Console.WriteLine(dateNow.Month);
//Console.WriteLine(dateNow.Day);
//Console.WriteLine(dateNow.Date);
//Console.WriteLine(dateNow.Minute);
//Console.WriteLine(dateNow.Hour);
//Console.WriteLine(dateNow.Second);
//Console.WriteLine(dateNow.Millisecond);
//Console.WriteLine(dateNow.Microsecond);
//Console.WriteLine(dateNow.Nanosecond);
//Console.WriteLine(dateNow.Kind);
//DateTime date4 = DateTime.Parse("2027-5-09");
//Console.WriteLine(date4);

//операции
//Console.WriteLine(date4.Add(new TimeSpan(34, 12, 78)));
//Console.WriteLine(date4.AddDays(8));
//Console.WriteLine(date4.AddDays(-7));
//Console.WriteLine(date4.AddHours(80));
//Console.WriteLine(date4.AddTicks(85453543));
//Console.WriteLine(date4.Subtract(DateTime.Now));
//Console.WriteLine(date4.CompareTo(dateNow));
//Console.WriteLine(date4 == dateNow);
//Console.WriteLine(dateNow.Day);
//Console.WriteLine(dateNow.DayOfWeek);
//Console.WriteLine(dateNow.DayOfYear);
//Console.WriteLine(dateNow.ToLocalTime());
//Console.WriteLine(dateNow.ToUniversalTime());
//Console.WriteLine(dateNow.ToLongDateString());
//Console.WriteLine(dateNow.ToShortDateString());
//Console.WriteLine(dateNow.ToLongTimeString());
//Console.WriteLine(dateNow.ToShortTimeString());

//дата и время во всех форматах
//Console.WriteLine($"D:{dateNow.ToString("D")}");
//Console.WriteLine($"d:{dateNow.ToString("d")}");
//Console.WriteLine($"F:{dateNow.ToString("F")}");
//Console.WriteLine($"f:{dateNow.ToString("f")}");
//Console.WriteLine($"G:{dateNow.ToString("G")}");
//Console.WriteLine($"g:{dateNow.ToString("g")}");
//Console.WriteLine($"M:{dateNow.ToString("M")}");
//Console.WriteLine($"O:{dateNow.ToString("O")}");
//Console.WriteLine($"o:{dateNow.ToString("o")}");
//Console.WriteLine($"T:{dateNow.ToString("T")}");
//Console.WriteLine($"t:{dateNow.ToString("t")}");
//Console.WriteLine($"t:{dateNow.ToString("yyyy-MM-dd hh:mm:ss")}");

//DateOnly
//DateOnly dOnly = new DateOnly();
//Console.WriteLine(dOnly);
//DateOnly d3 = new DateOnly(2026, 11, 21);
//Console.WriteLine(d3);
//Console.WriteLine(d3.DayOfYear);
//Console.WriteLine(d3.Month);
//Console.WriteLine(d3.Year);
//Console.WriteLine(d3.Day);
//Console.WriteLine(DateOnly.MinValue);
//Console.WriteLine(DateOnly.MaxValue);

//TimeOnly
//TimeOnly time1 = new TimeOnly();
//Console.WriteLine(time1);
//TimeOnly time2 = TimeOnly.FromDateTime(DateTime.Now);
//Console.WriteLine(time2);
//Console.WriteLine(time2.Hour);
//Console.WriteLine(time2.Minute);
//Console.WriteLine(time2.Second);
//Console.WriteLine(time2.Ticks);

// 1 вариант средний
DateTime dateNow = DateTime.Now;
Console.WriteLine($"t: {dateNow.ToString("dd.MM.yyyy HH:mm:ss")}");
Efir[] efirs = new Efir[6];

for (int i = 0; i < efirs.Length; i++)
{
    Console.Write("Введите позывной: ");
    efirs[i].pozivnoj = Console.ReadLine()!;
    Console.Write("Введите частоту (целое число): ");
    efirs[i].chastota = int.Parse(Console.ReadLine()!);
    Console.Write("Введите дату сеанса (в формате гггг-мм-дд): ");
    efirs[i].data = DateOnly.Parse(Console.ReadLine()!);
    Console.Write("Введите время начала сеанса (в формате чч:мм:сс): ");
    efirs[i].start = TimeOnly.Parse(Console.ReadLine()!);
    Console.Write("Введите время окончания сеанса (в формате чч:мм:сс): ");
    efirs[i].finish = TimeOnly.Parse(Console.ReadLine()!);
    Console.Write("Введите количество переданных групп (целое число): ");
    efirs[i].group = int.Parse(Console.ReadLine()!);

    Console.WriteLine();
        }
        foreach (var efir in efirs)
        {
            Console.WriteLine($"Позывной: {efir.pozivnoj}, Частота: {efir.chastota}, Дата: {efir.data}, Время: {efir.start} - {efir.finish}, Групп: {efir.group}");
        }
struct Efir
{
    public string pozivnoj;
    public int chastota;
    public DateOnly data;
    public TimeOnly start;
    public TimeOnly finish;
    public int group;
}





