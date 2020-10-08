using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
	class SweepstakesQueueManager : ISweepstakesManager
	{
		// Member Variables
		private Queue<Sweepstakes> queue;

		// Constructor
		public SweepstakesQueueManager()
		{
			queue = new Queue<Sweepstakes>();
		}

		// Member Methods
		public void InsertSweepstakes(Sweepstakes sweepstakes)
		{
			queue.Enqueue(sweepstakes);
		}
		//public Sweepstakes GetSweepstakes()
		//{
		//	return;
		//}
	}
}
