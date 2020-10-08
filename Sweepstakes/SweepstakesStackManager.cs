using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
	class SweepstakesStackManager	: ISweepstakesManager
	{
		// Member Variables
		private Stack<Sweepstakes> stack;

		// Constructor
		public SweepstakesStackManager()
		{
			stack = new Stack<Sweepstakes>();
		}

		// Member Methods
		public void InsertSweepstakes(Sweepstakes sweepstakes)
		{
			stack.Push(sweepstakes);

		}
		//public Sweepstakes GetSweepstakes()
		//{
		//	return;
		//}
	}
}
