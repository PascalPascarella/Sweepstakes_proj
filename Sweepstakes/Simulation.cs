using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
	class Simulation
	{
		// Member Variables


		// Constructor
		public Simulation()
		{
		}

		// Member Methods
		public void CreateMarketingFirmWithManager(ISweepstakesManager manager)		// Injection of interface type manager allows for either stack or queue manager creation (method injection)
		{
			MarketingFirm marketingFirm1 = new MarketingFirm(manager);
		}
	}
}
