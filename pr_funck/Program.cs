/Возвращает выводит на консоль 
void Metod1()
{
    Console.WriteLine( "Автор");
}
Metod1(); // Так вызывается метод



void Metod2(string msg) // Ничего не отдает
{
    Console.WriteLine(msg);
}
Metod2(msg : "Текст сообщения");//Так вызывается метод




void Method21 (string msg, int count)
{
    int i = 0; // Обозначае счетчик начинащийся с 0
    while (i < count) // Условие счетчика
    {
        Console.WriteLine(msg);
        i++;// После вывода в консол прибавляет 1
    }
}
Method21("Текст", 4); // Указание аргумента и количество раз сколько мы хотим вывести



int Method3() // Не принемает но возвращает
{
    return DateTime.Now.Year;  //тело метода вызывает текущий год
}

int year = Method3();
Console.WriteLine(year); // Вывод в консоль




string Method4(int count, string c)  // строку "с" друг за дружкой компановать count раз
{
int i = 0; // цикл
string result = String.Empty; // пустая строка

whele (i < count) // Пока "i" меньше чем "cout" мы деаем тело в скобках
{
    result = result + C;
    i++
}
 return result;
}

string res = Method4(10,"Text"); // 10 раз мы хотим вызвать текст 
Console.WriteLine(res); // Выводим в консол то что хотели вызвать в предыдущей строке


// Компактный метод счетчика "for"
// соберает все в одной строке внутри скобок
strig Method5(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = reslt + text;
    }
    return result;
}
string res = Method4(10, "z");
Console.WriteLine(res);


