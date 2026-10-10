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