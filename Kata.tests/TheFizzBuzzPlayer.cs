using NUnit.Framework;

namespace Kata
{
	[TestFixture]
	public class TheFizzBuzzPlayer
	{
		[TestCase(1, ExpectedResult = "1", TestName = "Given 1 returns 1.")]
		[TestCase(2, ExpectedResult = "2", TestName = "Given 2 returns 2.")]
		[TestCase(3, ExpectedResult = "fizz", TestName = "Given 3 returns fizz.")]
		[TestCase(5, ExpectedResult = "buzz", TestName = "Given 5 returns buzz.")]
		[TestCase(6, ExpectedResult = "fizz", TestName = "Given 6 returns fizz.")]
		[TestCase(10, ExpectedResult = "buzz", TestName = "Given 10 returns buzz. ")]
		[TestCase(15, ExpectedResult = "fizzbuzz", TestName = "Given 15 returns fizzbuzz. ")]
		public string Calculate(int input)
		{
			var game = new FizzBuzzPlayer();
			return game.Calculate(input);
		}
	}
}
