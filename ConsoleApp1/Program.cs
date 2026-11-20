//DayTime dayTime = DayTime.Morning;
//if (dayTime == DayTime.Morning)
//    Console.WriteLine("Доброе утро!");
//else
//    Console.WriteLine("Привет!");

//DoOperation(10, 5, Operation.Add);          // 15
//DoOperation(10, 5, Operation.Sub);     // 5
//DoOperation(10, 5, Operation.Mult);     // 50
//DoOperation(10, 5, Operation.Div);       // 2
//void DoOperation(double x, double y, Operation op)
//{
//    double result = op switch
//    {
//        Operation.Add => x + y,
//        Operation.Sub => x - y,
//        Operation.Mult => x * y,
//        Operation.Div => x / y
//    };
//    Console.WriteLine(result);
//}
//enum DayTime
//{
//    Morning,
//    Afternoon,
//    Evening,
//    Night
//}

//enum Operation
//{
//    Add,
//    Sub,
//    Mult,
//    Div
//}

//Person Tom =new Person();

//Tom.Name = "Vasia";
//Tom.Age = 18;

//struct Person
//{
//    public string Name;
//    public int Age;
//}

//30 вариант    БЫСТРЕЙ!!!!!
//Comp[] comps = new Comp[5];
//for (int i = 0; i < comps.Length; i++)
//{
//    Console.Write("Введите название компьютера:");
//    comps[i].name = Console.ReadLine()!;
//    Console.Write("Введите частоту:");
//    comps[i].frequency = int.Parse(Console.ReadLine()!);
//    Console.Write("Введите память:");
//    comps[i].memory = int.Parse(Console.ReadLine()!);
//    Console.Write("Введите наличие DVD: Да/Нет?");
//    string dvd = Console.ReadLine()!;
//    if (dvd == "Да") comps[i].DVD = true;
//    else comps[i].DVD = false;
//    Console.Write("Введите цену:");
//    comps[i].price = decimal.Parse(Console.ReadLine()!);
//    Console.WriteLine();
//}
//for (int i = 0; i < comps.Length; i++)
//{
//    if (comps[i].DVD) comps[i].Print();
//}
//struct Comp
//{
//    public string name;
//    public int frequency;
//    public int memory;
//    public bool DVD;
//    public decimal price;
//    public void Print()
//    {
//        Console.WriteLine($"Название:{name}, частота:{frequency}, память {memory}, {((DVD) ? "DVD" : "")}, цена:{price}");
//    }

//}

