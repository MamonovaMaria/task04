using NUnit.Framework;
using System;
using Calculator;

namespace CalculatorTests
{
	[TestFixture]
	public class SumTest
	{
		[Test]

		[TestCase("-1,1", 0)]
		[TestCase("_", 0)]
		[TestCase("+", 0)]
		[TestCase("-", 0)]
		[TestCase("12.5", 0)]
		[TestCase("7,7", 14)]
		[TestCase("-1,1-", 0)]
		public void Sum1(string str, int res)
		{
			Sum n = new Sum();
			int resultSum = n.Sum1(str);
			Assert.AreEqual(res, resultSum);
		}

		[TestCase("7,7", 14)]
		[TestCase("-1,1-", 0)]
		[TestCase("11.2-3", 0)]
		[TestCase("fgg,45", 0)]
		[TestCase("1,1,8", 10)]
		[TestCase("7,48,7,125,4", 191)]
		public void Sum2(string str, int res)
		{
			Sum n = new Sum();
			int resultSum = n.Sum2(str);
			Assert.AreEqual(res, resultSum);
		}

		[TestCase("7,7", 14)]
		[TestCase("-1,1-", 0)]
		[TestCase("11.2^3", 16)]
		[TestCase("fgg,45", 0)]
		[TestCase("1,1,8", 10)]
		[TestCase("7,48,7,125,4", 191)]
		[TestCase("7@48#7%125&4", 191)]
		public void Sum3(string str, int res)
		{
			Sum n = new Sum();
			int resultSum = n.Sum3(str);
			Assert.AreEqual(res, resultSum);
		}

		[TestCase("7,7", 14)]
		[TestCase("-1,1-", 0)]
		[TestCase("11.2^3", 16)]
		[TestCase("fgg,45", 0)]
		[TestCase("1,1,8", 10)]
		[TestCase("7,48,7,125,4", 191)]
		[TestCase("7@48#7%125&4", 191)]
		[TestCase("1,-1,8", 10)]
		public void Sum4(string str, int res)
		{
			Sum n = new Sum();
			int resultSum = n.Sum4(str);
			Assert.AreEqual(res, resultSum);
		}

		[TestCase("7,7", 14)]
		[TestCase("-1,1-", 0)]
		[TestCase("11.2^3", 16)]
		[TestCase("fgg,45", 0)]
		[TestCase("1,_1,8", 10)]
		[TestCase("7,%^48,7,@125,)4", 191)]
		[TestCase("7@48#7%125&4", 191)]
		[TestCase("7@48_7%125)4", 191)]
		[TestCase("1,-1,8", 10)]
		public void Sum5(string str, int res)
		{
			Sum n = new Sum();
			int resultSum = n.Sum5(str);
			Assert.AreEqual(res, resultSum);
		}
	}
}
