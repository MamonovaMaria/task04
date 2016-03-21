using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	class Menu
	{
		/// <summary>
		/// Предоставляет одну из функций сложения на выбор.
		/// Все следующие функции являются различными реализациями функции сложения
		/// (поддерживается только тип int).
		///Sum1: принимает строку из двух чисел, разделенных запятой;
		///Sum2: принимает строку произвольного количества чисел, разделенных запятой;
		///Sum3: принимает строку произвольного количества чисел, разделенных произвольными разделителями;
		///Sum4: принимает строку произвольного количества неотрицательных чисел, разделенных произвольными разделителями;
		///Sum5: принимает строку произвольного количества неотрицательных чисел, разделенных произвольными разделителями в количестве от 1 до 3 включительно.
		/// </summary>
		public void Choice()
		{
			Console.WriteLine("Какой метод сложения использовать?");
			Console.WriteLine("1.Sum1");
			Console.WriteLine("2.Sum2");
			Console.WriteLine("3.Sum3");
			Console.WriteLine("4.Sum4");
			Console.WriteLine("5.Sum5");
		}

		/// <summary>
		/// Данный метод отлавливает нажатие Escape для выхода, а также обрабатывает различного рода исключения.
		/// </summary>
		/// <returns></returns>
		public bool Check()
		{
			Choice();
			ConsoleKey key = Console.ReadKey(true).Key;
			if (key == ConsoleKey.Escape)
				return false;
			else
			{
				try
				{
					Console.WriteLine("Результат сложения:  {0}", Summary(key));

				}
				catch (ArgumentException ex)
				{
					switch (ex.Message)
					{
						case "неверная строка":		Console.WriteLine("Некорректный ввод");				  	 break;
						case "число не int":		Console.WriteLine("Некорректные данные");				 break;
						case "неверный пункт меню": Console.WriteLine("Вы ввели несуществующий пункт меню"); break;
					}
				}
				return true;
			}
		}

		/// <summary>
		/// Данный метод реализует вызов выбранной функции (выбор осуществляется с помощью Menu.Choice()). 
		/// Также выбрасывается исключение с том случае, если был совершён некорректный выбор.
		/// </summary>
		/// <param name="key"></param>
		/// <returns></returns>
		public int Summary(ConsoleKey key)
		{
			Sum sum = new Sum();
			Console.Clear();
			switch (key)
			{
				case ConsoleKey.D1: case ConsoleKey.NumPad1:
					{
						Console.WriteLine("Введите строку");
						return sum.Sum1(Console.ReadLine());
					};

				case ConsoleKey.D2: case ConsoleKey.NumPad2:
					{
						Console.WriteLine("Введите строку");
						return sum.Sum2(Console.ReadLine());
					};

				case ConsoleKey.D3: case ConsoleKey.NumPad3:
					{
						Console.WriteLine("Введите строку");
						return sum.Sum3(Console.ReadLine());
					};

				case ConsoleKey.D4: case ConsoleKey.NumPad4:
					{
						Console.WriteLine("Введите строку");
						return sum.Sum4(Console.ReadLine());
					};

				case ConsoleKey.D5: case ConsoleKey.NumPad5:
					{
						Console.WriteLine("Введите строку");
						return sum.Sum5(Console.ReadLine());
					};
				default: throw new ArgumentException("неверный пункт меню");
			}
		}
	}
}
