// Маленькие буквы "к" заменить большими буквами "К"
// Большие буквы "С" заменить маленькими буквами "с"

string text = "- Я думаю, - сказал князь, улыбаясь, - что,"
+"ужели вас послали вместо нашего милого Винценгероде,"
+"Вы так красноречивы. Вы дадите мне чаю";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

     int length = text.Length;
     for(int i = 0; i < length; i++)
     {
        if(text[i] == oldValue) result = $"{newValue}";
        else result = result + $"{text[i]}";
     }
     return result;
}
string newText = Replace(text,' ','|');
Console.WriteLine(newText);
// разобратся с текстом
