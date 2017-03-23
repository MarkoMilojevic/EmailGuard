using System;
using System.Linq;

namespace ConsoleApp1
{
	public class EmailPatternRule : ChainedEmailRule
	{
		public EmailPatternRule(IEmailRule next) : base(next)
		{

		}

		protected override bool IsValid(string email)
		{
			return email.All(Char.IsLetter);
		}

		protected override void OnInvalid(string email)
		{
			Utils.LogNotAlpha(email);
		}
	}
}
