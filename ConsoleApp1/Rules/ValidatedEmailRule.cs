using System;

namespace ConsoleApp1
{
	public class ValidatedEmailRule : IEmailRule
	{
		public void Inspect(string email, Action callback)
		{
			callback();
		}
	}
}
