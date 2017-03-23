using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
	public class DuplicateEmailRule : ChainedEmailRule
	{
		private ISet<string> _inspectedEmails;

		public DuplicateEmailRule(ISet<string> inspectedEmails, IEmailRule next) : base(next)
		{
			_inspectedEmails = inspectedEmails;
		}

		protected override bool IsValid(string email)
		{
			return !_inspectedEmails.Contains(email);
		}

		protected override void OnInvalid(string email)
		{
			Utils.LogDuplicate(email);
		}
	}
}
