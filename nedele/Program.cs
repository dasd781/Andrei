using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			      Console.WriteLine ("Скалерозник");
      Console.WriteLine ("Введите день недели...");
      int dayofweek = int.Parse (Console.ReadLine());
      if (dayofweek == 6 || dayofweek == 7) Console.WriteLine ("Ответ: Выходной день можно выпить.");
      else if (dayofweek <= 5) Console.WriteLine ("Ответ: Будний день.");
      else if (dayofweek > 7) Console.WriteLine ("Ошибка: В неделе всего 7 дней!");
		}
	}
}