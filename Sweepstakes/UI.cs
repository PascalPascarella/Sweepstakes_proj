using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
	static class UI
	{
		// Member Variables

		// Member Methods
		public static string GetUserInputFor(string stringPrompt)
		{
			Console.WriteLine(stringPrompt);
			return Console.ReadLine();
		}
		public static void PrintRegisNumber(int registrationNumber, string sweepstakesName)
		{
			Console.WriteLine($"You have been entered into our {sweepstakesName} sweepstakes! Your registration number is {registrationNumber}");
		}
		public static void PrintContestantInfo(Contestant contestant)
		{
			Console.WriteLine($"Contestant name: {contestant.FirstName} {contestant.LastName}" +
			$"\n Contestant Email: {contestant.EmailAddress}" +
			$"\n Contestant #: {contestant.RegistrationNumber}");
		}

	}
}
