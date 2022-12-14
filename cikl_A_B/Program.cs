double a;
double b;
double c;

Console.WriteLine("Вас приветствует программа возведения числа в степень");
Console.WriteLine("Пожалуйста, введите число, которое вы хотите возвести в степень:");
a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Спасибо, теперь введите степень, в которую хотите возвести число "+a+":");
b = Convert.ToDouble(Console.ReadLine());
c = Math.Pow(a, b);
Console.WriteLine("Готово! "+a+" в степени "+b+" равно "+c+"!");
Console.ReadLine();
