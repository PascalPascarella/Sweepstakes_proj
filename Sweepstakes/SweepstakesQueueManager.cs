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
		public void InsertSweepstakes(Sweepstakes sweepstakes)		// Add new sweepstakes to end of queue
		{
			queue.Enqueue(sweepstakes);
		}
		public Sweepstakes GetSweepstakes()		// Remove oldest sweepstakes from front of queue
		{
			return queue.Dequeue();
		}
	}
}
