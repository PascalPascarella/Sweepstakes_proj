using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
	interface ISweepstakesManager
	{
		void InsertSweepstakes(Sweepstakes sweepstakes);		// Will be used to push/enqueue the sweepstakes onto stack/queue
		Sweepstakes GetSweepstakes();   // Will be used to pop/dequeue the sweepstakes from stack/queue
	}
}
