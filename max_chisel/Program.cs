int a = int.Parse(Console.ReadLine());
int b = int.Parse(Console.ReadLine());
int c = int.Parse(Console.ReadLine());
int max = Math.Max(a, b);
max = Math.Max(max, c);
Console.WriteLine("max=" + max);
Console.ReadLine();