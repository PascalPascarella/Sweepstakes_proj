using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
	class Sweepstakes
	{
		// Member Variables
		private Dictionary<int, Contestant> contestants;
		private string name;
		public string Name { get { return name; } }
		public Contestant winnerContest;

		// Constructor
		public Sweepstakes(string name)
		{
			this.name = name;
			contestants = new Dictionary<int, Contestant>();
		}

		// Member Methods
		public void RegisterContestant(Contestant contestant)		// Assigns contestant object an int Key and adds to Dictionary
		{
			int regisNumber = contestants.Count + 1;
			contestant.FirstName = UI.GetUserInputFor("Please enter your first name.");
			contestant.LastName = UI.GetUserInputFor("Please enter your last name.");
			contestant.EmailAddress = UI.GetUserInputFor("Please enter your email address.");
			contestant.RegistrationNumber = regisNumber;
			UI.PrintRegisNumber(regisNumber,Name);
			contestants.Add(regisNumber, contestant);
			PrintContestantInfo(contestant);
		}
		public Contestant PickWinner()
		{

			int winnerKey = GetRandomNumber(contestants.Count + 1);
			foreach (KeyValuePair<int, Contestant> winner in contestants)
			{
				if(winnerKey == winner.Key)
				{
					winnerContest = winner.Value;
				}
			}
			return winnerContest;
		}
	public void PrintContestantInfo(Contestant contestant)
		{
			UI.PrintContestantInfo(contestant);
		}
		public int GetRandomNumber(int max)
		{
			Random random = new Random();
			int randomResult = random.Next(max);
			return randomResult;
		}

	}
}
