using System;

namespace ConsoleApp1
{
	public abstract class ChainedEmailRule : IEmailRule
	{
		private IEmailRule _next { get; }
		
		private readonly Action<string, Action> ForwardInspection;

		public ChainedEmailRule(IEmailRule next)
		{
			_next = next;

			ForwardInspection = (email, callback) => _next.Inspect(email, callback);
		}

		public void Inspect(string email, Action callback)
		{
			if (IsValid(email))
			{
				OnValid(email, callback);
			}
			else
			{
				OnInvalid(email);
			}
		}

		protected abstract bool IsValid(string email);

		private void OnValid(string email, Action callback)
		{
			ForwardInspection(email, callback);
		}

		protected abstract void OnInvalid(string email);
	}
}
