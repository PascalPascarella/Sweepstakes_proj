using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
	class MarketingFirm
	{
		// Member Variables
		private ISweepstakesManager _manager;

		// Constructor
		public MarketingFirm(ISweepstakesManager manager)
		{
			_manager = manager;

		}
		// Member Methods
		public void CreateSweepstake(string name)		// Factory??
		{
			// -->TODO: UI
			Sweepstakes sweepstakes = new Sweepstakes(name);		// Create new sweepstakes
			_manager.InsertSweepstakes(sweepstakes);		// Add to stack/queue depending on manager type

		}
	}
}
