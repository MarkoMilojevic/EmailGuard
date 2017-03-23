using System;

namespace ConsoleApp1
{
	public class Utils
	{
		public static void LogNotAlpha(string email)
		{
			Console.WriteLine("Not all alpha - " + email);
		}

		public static void LogDuplicate(string email)
		{
			Console.WriteLine("Duplicate - " + email);
		}
	}
}
