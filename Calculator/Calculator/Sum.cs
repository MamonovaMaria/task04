using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Calculator
{
	public class Sum
	{
		Regex r = new Regex(@"-?\d+");
		Regex r4_5 = new Regex(@"\d+");
		int res = 0;
		int num = 0;


		public int Sum1(string str)
		{
			Regex reg = new Regex(@"^[+-]?\d+,[+-]?\d+$");
			if (!reg.IsMatch(str))
				throw new ArgumentException("неверная строка");
			else
				foreach (Match el in r.Matches(str))
				{
					if (!Int32.TryParse(el.ToString(), out num))
						throw new ArgumentException("число не int");
					else
						res += Int32.Parse(num.ToString());
				}
			return res;
		}

		public int Sum2(string str)
		{
			Regex reg = new Regex(@"^([+-]?\d+,)+[+-]?\d+$");
			if (!reg.IsMatch(str))
				throw new ArgumentException("неверная строка");
			else
				foreach (Match el in r.Matches(str))
				{
					if (!Int32.TryParse(el.ToString(), out num))
						throw new ArgumentException("число не int");
					else
						res += Int32.Parse(num.ToString());
				}
			return res;
		}

		public int Sum3(string str)
		{
			Regex reg = new Regex(@"^([+-]?\d+[~!@#$%\^&*()_+-;\.,])+[+-]?\d+$");
			if (!reg.IsMatch(str))
				throw new ArgumentException("неверная строка");
			else
				foreach (Match el in r.Matches(str))
				{
					if (!Int32.TryParse(el.ToString(), out num))
						throw new ArgumentException("число не int");
					else
						res += Int32.Parse(num.ToString());
				}
			return res;
		}

		public int Sum4(string str)
		{
			Regex reg = new Regex(@"^([+]?\d+[~!@#$%\^&*()_+-;\.,])+[+]?\d+$");
			if (!reg.IsMatch(str))
				throw new ArgumentException("неверная строка");
			else
				foreach (Match el in r4_5.Matches(str))
				{
					if (!Int32.TryParse(el.ToString(), out num))
						throw new ArgumentException("число не int");
					else
						res += Int32.Parse(num.ToString());
				}
			return res;
		}

		public int Sum5(string str)
		{
			Regex reg = new Regex(@"^([+]?\d+[~!@#$%\^&*()_+;\.,-]{1,3})+[+]?\d+$");
			if (!reg.IsMatch(str))
				throw new ArgumentException("неверная строка");
			else
				foreach (Match el in r4_5.Matches(str))
				{
					if (!Int32.TryParse(el.ToString(), out num))
						throw new ArgumentException("число не int");
					else
						res += Int32.Parse(num.ToString());
				}
			return res;
		}
	}
}
