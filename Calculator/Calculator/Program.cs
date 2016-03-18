using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Calculator
{
	class Program
	{
		static void Main(string[] args)
		{
			Menu m = new Menu();
			while (m.Check())
			{
				m.Check();
			}
			return;
		}
	}
}
