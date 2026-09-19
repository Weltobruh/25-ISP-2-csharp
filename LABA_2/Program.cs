// Высокий (Лабораторная 2, 21 Вариант)
try
{
    Console.Write("Укажи х:");
    double x = double.Parse(Console.ReadLine());

    double ch = (Math.Exp(x) - Math.Exp(-x)) / 2.0;
    double chn = (Math.Exp(x - 1) - Math.Exp(-(x - 1))) / 2.0;

    double y = (ch * Math.Tan(x + 1)) - Math.Pow(Math.Tan(2 + chn), 2);

    Console.Write($"Значение функции y = {y:F2}");
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}