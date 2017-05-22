namespace Kata
{
	public class FizzBuzzPlayer
	{
		public string Calculate(int input)
		{
			if (input % 3 == 0)
				return "fizz";
			if (input == 5)
				return "buzz";
			return input.ToString();
		}
	}
}
