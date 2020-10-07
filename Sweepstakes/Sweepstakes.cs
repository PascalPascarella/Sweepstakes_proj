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
		public string Name;

		// Constructor
		public Sweepstakes(string name)
		{
			this.name = name;
		}

		// Member Methods
		public void RegisterContestant(Contestant contestant)
		{

		}
		public Contestant PickWinner()
		{

			return;
		}
		public void PrintContestantInfo(Contestant contestant)
		{

		}
	}
}
