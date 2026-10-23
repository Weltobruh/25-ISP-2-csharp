//int[] mas1 = new int[5];
//int[] mas2 = { 1,4,2,9,3};
//int[] mas3 = mas2;
//mas3[3] = 12;
//Console.WriteLine(mas3[3]);
//Console.WriteLine(mas2[3]);

//ввод вручную
//int[] mas4= new int[5];
//for (int i = 0; i < mas4.Length; i++)
//    mas4[i] = int.Parse(Console.ReadLine());
//for (int i = 0;i < mas4.Length; i++)
//    Console.Write($"{mas4[i]} ");

//ввод по формуле
//int[] mas5 = new int[5];
//for (int i = 0; i < mas5.Length; i++)
//{
//    mas5[i] = 2 * i + 1;
//    Console.Write($"{mas5[i]} ");
//}
//Console.WriteLine();

//использование генератора случайных чисел
//Random rnd = new Random();
//int[] mas6 = new int[rnd.Next(5,15)];
//for (int i = 0; i < mas6.Length; i++)
//{
//    mas6[i] =rnd.Next(1,100);
//    Console.Write($"{mas6[i]} ");
//}

//Дан целочисленный массив состоящий из 10 элементов. Элементы массива принимают значения в интервале [-7; 7]. Найдите последнее вхождение в массив элемента n (n вводится с клавиатуры). Подсчитайте количество элементов массива меньших n.Дан целочисленный массив состоящий из 10 элементов. Элементы массива принимают значения в интервале [-7; 7]. Найдите последнее вхождение в массив элемента n (n вводится с клавиатуры). Подсчитайте количество элементов массива меньших n.
//try
//{
//    int[] mas = new int[10];
//    Random rnd = new Random();
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-7, 8);
//        Console.Write($"{mas[i]} ");
//    }
//    Console.WriteLine();
//    Console.Write("Введите n:");
//    int n = int.Parse(Console.ReadLine());
//    int index = -1;
//    int less_n = 0;
//    for (int i = 0; i < mas.Length; i++)
//    {
//        if(mas[i] == n) index = i;
//        if (mas[i] < n) less_n++;
//    }
//    Console.WriteLine($"Индекс последнего вхождения {n}={index}");
//    Console.WriteLine($"Количество элементов меньших {n}={less_n}");

//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}
//Дан целочисленный массив состоящий из n элементов. Элементы массива принимают значения в интервале [-10; 10]. Найдите максимальный элемент массиваДан целочисленный массив состоящий из n элементов. Элементы массива принимают значения в интервале [-10; 10]. Найдите максимальный элемент массива
//try
//{
//    Console.Write("Введите n:");
//    int n = int.Parse(Console.ReadLine());
//    Random rnd=new Random();
//    int[] mas = new int[n];
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-10, 11);
//        Console.Write($"{mas[i]} ");
//    }
//    Console.WriteLine();
//    int max = mas[0];
//    for (int i = 1; i < mas.Length; i++)
//    {
//        if( mas[i] > max ) max = mas[i];
//    }
//    Console.WriteLine($"max={max}");
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//отсортировать элементы массива по возрастанию
//Random rnd=new Random();
//int[] mas = new int[rnd.Next(10,20)];
//for(int i = 0; i < mas.Length; i++)
//{
//    mas[i] = rnd.Next(10,100);
//    Console.Write($"{mas[i]} ");
//}
//Console.WriteLine();
//for (int i = 0; i < mas.Length-1; i++)
//{
//    for (int j = i+1; j < mas.Length; j++)
//    {
//        if (mas[i] > mas[j])
//        {
//            int temp = mas[i];
//            mas[i]=mas[j];
//            mas[j]=temp;
//        }
//    }
//}
//foreach (int i in mas) Console.Write($"{i} ");
//Console.WriteLine();

//Найти сумму элементов одномерного массива, заданного случайным образом на интервале [-13;11]. Размерность вводится с клавиатуры. 
//try
//{
//    Console.Write("Введите размер массива:");
//    int n=int.Parse(Console.ReadLine());
//    int[] mas=new int[n];
//    Random rnd=new Random();
//    int s = 0;
//    for(int i=0; i<mas.Length; i++)
//    {
//        mas[i]=rnd.Next(-13,12);
//        Console.Write($"{mas[i]} ");
//        s += mas[i];
//    }
//    Console.Write($"s={s}");
//}
//catch(Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//Сформировать и вывести на экран массив, элементы которого заданы случайным образом на интервале [-19, 26] (размерность вводится с клавиатуры). Найти произведение элементов с нечетными номерами.
//try
//{
//    Console.Write("Введите размер массива:");
//    int n = int.Parse(Console.ReadLine()!);
//    int[] mas = new int[n];
//    Random rnd = new Random();
//    int p = 1;
//    for (int i = 0; i < mas.Length; i++)
//    {
//        mas[i] = rnd.Next(-13, 12);
//        Console.Write($"{mas[i]} ");
//        if (i % 2 != 0) p *= mas[i];
//    }
//    Console.Write($"s={p}");
//}
//catch (Exception e)
//{
//    Console.WriteLine(e.Message);
//}

//В заданном одномерном  массиве, состоящем из n целых чисел, подсчитать количество нулей.

//Random rnd = new Random();
//int[] mas = new int[rnd.Next(10,30)];
//int count = 0;
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = rnd.Next(-5, 5);
//    Console.Write($"{mas[i]} ");
//    if (mas[i]==0) count++;
//}
//Console.Write($"Количество нулей {count}");

//string? name = null;
//Console.WriteLine(name);
//int n = int.Parse(Console.ReadLine()!);
//Оператор!(null - forgiving operator) позволяет указать, что переменная ссылочного типа не равна null

//int? val = null;
//Console.WriteLine(val);

//int? x = 5;
////int z = x + 7;
//int? w = x + 7;
//int d = x.Value + 7;

//Оператор ??
//Оператор ?? называется оператором null-объединения. Он применяется для установки значений по умолчанию для типов, которые допускают значение null:
//левый_операнд ?? правый_операнд
//Оператор ?? возвращает левый операнд, если этот операнд не равен null. Иначе возвращается правый операнд. При этом левый операнд должен принимать null.
//string? text = "Sam";
//string name = text ?? "Tom";
//Console.WriteLine(name);

//int? id = null;
//int personId = id ?? 1;
//Console.WriteLine(personId);

//30 вариант Базовый уровень
//Random random=new Random();
//double[] mas=new double[12];
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.NextDouble() * 100;
//    Console.Write($"{mas[i]:F2} ");
//}
//Console.WriteLine();
//double min = mas[0];
//int index = 0;
//for (int i = 1; i < mas.Length; i++)
//{
//    if (mas[i] < min)
//    {
//        min= mas[i]; index = i;
//    }
//}
//Console.WriteLine($"Сумма мин.элемента {min:F2} и его индекса {index}:{min+index:f2}");
//30 вариант Средний уровень
//Random random = new Random();
//double[] mas1 = new double[random.Next(10, 20)];
//double[] mas2 = new double[random.Next(10, 20)];
//for (int i = 0; i < mas1.Length; i++)
//{
//    mas1[i] = random.NextDouble() * 100;
//    Console.Write($"{mas1[i]:F2} ");
//}
//Console.WriteLine();
//for (int i = 0; i < mas2.Length; i++)
//{
//    mas2[i] = random.NextDouble() * 100;
//    Console.Write($"{mas2[i]:F2} ");
//}
//Console.WriteLine();
//double min1 = mas1[0];
//int index1 = 0;
//for (int i = 1; i < mas1.Length; i++)
//{
//    if (mas1[i] < min1)
//    {
//        min1 = mas1[i]; index1 = i;
//    }
//}
//double min2 = mas2[0];
//int index2 = 0;
//for (int i = 1; i < mas2.Length; i++)
//{
//    if (mas2[i] < min2)
//    {
//        min2 = mas2[i]; index2 = i;
//    }
//}
//mas1[index1] = min2;
//mas2[index2] = min1;
//Console.WriteLine($"{min1:f2}-{index1}");
//Console.WriteLine($"{min2:f2}-{index2}");
//for (int i = 0; i < mas1.Length; i++)
//{
//    Console.Write($"{mas1[i]:F2} ");
//}
//Console.WriteLine();
//for (int i = 0; i < mas2.Length; i++)
//{
//    Console.Write($"{mas2[i]:F2} ");
//}
//Random random = new Random();
//int[] mas1 = new int[3];
//for (int i = 0; i < 3; i++)
//{
//    mas1[i] = random.Next(10, 100);
//    Console.Write($"{mas1[i]} ");
//}
//Console.WriteLine();
//string[] str = new string[3];
//for (int i = 0; i < str.Length; i++)
//{
//    str[i] = Convert.ToString(mas1[i], 2);
//    Console.WriteLine($"{str[i]} ");
//}

//Random random = new Random();
//double[] mas = new double[5];
//Console.Write("Массив: ");
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.NextDouble() * 100;
//    Console.Write($"{mas[i]:F2}  ");
//}
//Console.WriteLine();
//double R = random.NextDouble() * 100;
//Console.WriteLine($"Число R: {R:F2}");
//int index = 0;
//for (int i = 1; i < mas.Length; i++)
//{
//    if (Math.Abs(mas[i] - R) < Math.Abs(mas[index] - R))
//    {
//        index = i;
//    }
//}

//Console.WriteLine($"Ближайшее значение: {mas[index]:F2}; его индекс: {index}");

//Random random = new Random();
//int[] mas = new int[5];
//Console.Write("Массив: ");
//for (int i = 0; i < mas.Length; i++)
//{
//    mas[i] = random.Next(10, 100) * 100;
//    String binary = Convert.ToString(mas[i], 2);
//    Console.Write($"{binary:F2}  ");
//}
//Console.WriteLine();
//double R = random.NextDouble() * 100;
//Console.WriteLine($"Число R: {R:F2}");
//int index = 0;
//for (int i = 1; i < mas.Length; i++)
//{
//    if (Math.Abs(mas[i] - R) < Math.Abs(mas[index] - R))
//    {
//        index = i;
//    }
//}

//Console.WriteLine($"Ближайшее значение: {mas[index]:F2}; его индекс: {index}");
