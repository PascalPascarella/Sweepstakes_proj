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
		public void InsertSweepstakes(Sweepstakes sweepstakes)		// Add sweepstakes to top of stack
		{
			stack.Push(sweepstakes);

		}
		public Sweepstakes GetSweepstakes()		// Remove sweepstakes from top of stack
		{
			return stack.Pop();
		}
	}
}
