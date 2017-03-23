using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	public class Program
	{
		public static void Main(string[] args)
		{
			List<string> emails = new List<string>();

			EmailGuard guard = new EmailGuard();

			string validEmail = "email";
			string invalidEmail = "123";
			string anotherValidEmail = "asd";
			string duplicatedEmail = "asd";

			guard.Inspect(validEmail, () => emails.Add(validEmail));
			guard.Inspect(invalidEmail, () => emails.Add(invalidEmail));
			guard.Inspect(anotherValidEmail, () => emails.Add(anotherValidEmail));
			guard.Inspect(duplicatedEmail, () => emails.Add(duplicatedEmail));

			Console.WriteLine();
			Console.WriteLine(string.Join(", ", emails));
			Console.ReadKey();
		}
	}
}
