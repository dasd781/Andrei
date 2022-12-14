namespace ConsoleApplication2
{
class Laba1
{
public static void Main(string[] args)
{
int i;
int[] a = new int[10];
Console.WriteLine("Введите массив чисел: ");
for (i = 0; i < 10; i++)
{
a[i] = int.Parse(Console.ReadLine());
}
 
for (i = 0; i < 10; i++)
{
Console.WriteLine(a[i]);
}
}
}
}