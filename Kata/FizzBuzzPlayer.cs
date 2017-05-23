namespace Kata
{
	public class FizzBuzzPlayer
	{
		public string Calculate(int input)
		{
			string result = "";

			result += Fizz(input);
			result += Buzz(input);
			if (string.IsNullOrWhiteSpace(result))
				result = input.ToString();

			return result;
		}

		private string Fizz(int input)
		{
			if (IsDivisibleBy(3, input))
				return "fizz";
			return "";
		}

		private string Buzz(int input)
		{
			if (IsDivisibleBy(5, input))
				return "buzz";
			return "";
		}

		private static bool IsDivisibleBy(int factor, int input)
		{
			return input % factor == 0;
		}
	}
}