// 30 вариант базовый
//Console.Write("Введите массу: ");
//double m = double.Parse(Console.ReadLine()!);
//Console.Write("Введите скорость: ");
//double s = double.Parse(Console.ReadLine()!);

//Body body = new Body(m, s);
//body.Print();
//class Body
//{

//    private double weight;
//    public double Weight
//    {
//        private get { return weight; }
//        private set { if(weight > 0) weight = value; }
//    }

//    private double speed;
//    public double Speed
//    {
//        private get { return speed; }
//        private set { if (weight > 0) speed = value; }
//    }
//    public Body(double weight, double speed)
//    {
//        Weight = _w;
//        Speed = _s;
//    }
//    private double getEnergy()
//    {
//        return weight * speed * speed / 2;
//    }
//    public void Print()
//    {
//        Console.WriteLine($"Кинетическая энергия: {getEnergy()} Дж");
//    }
//}


// 1 вариант средний
Date defaultDate = new Date();
Console.WriteLine("Объект по умолчанию:");
defaultDate.Print();
Date constDate = new Date(28, 2, 2024);
Console.WriteLine("\nОбъект с константами:");
constDate.Print();

Console.Write("\nВведите день: ");
int d = int.Parse(Console.ReadLine()!);

Console.Write("Введите месяц: ");
int m = int.Parse(Console.ReadLine()!);

Console.Write("Введите год: ");
int y = int.Parse(Console.ReadLine()!);

Date userDate = new Date(d, m, y);
userDate.Print();

class Date
{
    private int day;
    public int Day
    {
        get { return day; }
        private set { if (value >= 1 && value <= 31) day = value; }
    }

    private int month;
    public int Month
    {
        get { return month; }
        private set { if (value >= 1 && value <= 12) month = value; }
    }

    private int year;
    public int Year
    {
        get { return year; }
        private set { if (value > 0) year = value; }
    }

    public Date()
    {
        day = 1;
        month = 1;
        year = 2000;
    }

    public Date(int day, int month, int year)
    {
        Year = year;
        Month = month;
        Day = day;
    }

    private bool IsLeapYear()
    {
        return year % 4 == 0;
    }

    private int GetDaysInMonth()
    {
        if (month == 2)
        {
            if (IsLeapYear())
            {
                return 29;
            }
            else
            {
                return 28;
            }
        }

        if (month == 4 || month == 6 || month == 9 || month == 11)
        {
            return 30;
        }

        return 31;
    }

    private void AddFiveDays()
    {
        day += 5;
        while (day > GetDaysInMonth())
        {
            day -= GetDaysInMonth();
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
        }
    }

    private string GetInfo()
    {
        string status;
        if (IsLeapYear())
        {
            status = "високосный";
        }
        else
        {
            status = "не високосный";
        }

        return $"{day}.{month}.{year} (год {status})";
    }

    public void Print()
    {
        Console.WriteLine($"Исходная дата: {GetInfo()}");
        AddFiveDays();
        Console.WriteLine($"После увеличения на 5 дней: {GetInfo()}");
    }
}
