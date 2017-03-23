using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	public class EmailGuard
	{
		private ISet<string> _inspectedEmails;
		private IEmailRule _rules { get; }

		public EmailGuard()
		{
			_inspectedEmails = new HashSet<string>();

			_rules = 
				new EmailPatternRule(
					new DuplicateEmailRule(_inspectedEmails,
						new ValidatedEmailRule()
					)
				);
		}

		public void Inspect(string email, Action callback)
		{
			_rules.Inspect(email, callback);

			_inspectedEmails.Add(email);
		}
	}
}
