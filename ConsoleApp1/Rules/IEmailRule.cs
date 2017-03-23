using System;

namespace ConsoleApp1
{
	public interface IEmailRule
	{
		void Inspect(string email, Action callback);
	}
}
