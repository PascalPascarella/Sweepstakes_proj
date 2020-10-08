using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
	static class UI
	{
		public static string GetUserInputFor(string stringPrompt)
		{
			Console.WriteLine(stringPrompt);
			return Console.ReadLine();

		}
	}
}
