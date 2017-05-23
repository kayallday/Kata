using FakeItEasy;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

namespace Kata
{
	[TestFixture]
	public class TheFizzBuzzPlayer
	{
		FizzBuzzPlayer _game;
		ILogger _logger;

		[TestCase(1, ExpectedResult = "1", TestName = "Given 1 returns 1.")]
		[TestCase(2, ExpectedResult = "2", TestName = "Given 2 returns 2.")]
		[TestCase(3, ExpectedResult = "fizz", TestName = "Given 3 returns fizz.")]
		[TestCase(5, ExpectedResult = "buzz", TestName = "Given 5 returns buzz.")]
		[TestCase(6, ExpectedResult = "fizz", TestName = "Given 6 returns fizz.")]
		[TestCase(10, ExpectedResult = "buzz", TestName = "Given 10 returns buzz. ")]
		[TestCase(15, ExpectedResult = "fizzbuzz", TestName = "Given 15 returns fizzbuzz. ")]
		public string Calculate(int input)
		{
			ArrangeGame();
			return _game.Calculate(input);
		}

		[Test]
		public void LogsTheInputAndOutput()
		{
			ArrangeGame();
			_game.Calculate(3);
			A.CallTo(() => _logger.Log("The input was: 3\nThe output was: fizz\n")).MustHaveHappened();
		}
		[Test]
		public void ReallyLogsTheInputAndOutput()
		{
			ArrangeGame();
			_game.Calculate(5);
			A.CallTo(() => _logger.Log("The input was: 5\nThe output was: buzz\n")).MustHaveHappened();
		}

		private void ArrangeGame()
		{
			_logger = A.Fake<ILogger>();
			_game = new FizzBuzzPlayer(_logger);
		}
	}
}
