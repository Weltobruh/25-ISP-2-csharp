Console.WriteLine("n: ");
int n = int.Parse(Console.ReadLine());
int i = 1;
int s = 1;
while (i <= n)
{
	s = s * i;
	i = i + 1;
}
Console.WriteLine($"Факториал: {s}");