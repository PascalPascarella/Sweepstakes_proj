using System;
using System.Collections.Generic;
using System.Text;

namespace Sweepstakes
{
	class Contestant
	{
		// Member Variables
		public string FirstName;
		public string LastName;
		public string EmailAddress;
		public int RegistrationNumber;

		// Constructor
		public Contestant(string FirstName, string LastName, string EmailAddress, int RegistrationNumber)
		{
			this.FirstName = FirstName;
			this.LastName = LastName;
			this.EmailAddress = EmailAddress;
			this.RegistrationNumber = RegistrationNumber;
		}
	}
}
