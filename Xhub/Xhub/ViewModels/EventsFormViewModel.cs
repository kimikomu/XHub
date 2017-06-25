using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xhub.Models;

namespace Xhub.ViewModels
{
	public class EventsFormViewModel
	{
		[Required]
		public string EventLocation { get; set; }

		[Required]
		public string Date { get; set; }                                // Date and Time are seperate inputs in the Add form 

		[Required]
		public string Time { get; set; }

		[Required]
		public byte EventType { get; set; }                             // set to byte bc there won't be more than 255 types

		public IEnumerable<EventType> EventTypes { get; set; }

		public string Description { get; set; }

		public string EventName { get; set; }

		public DateTime GetDateTime()                                   // Date and Time are parsed together from the Add form input for the database
		{
			return DateTime.Parse($"{Date} {Time}");
		}

		// Validate Date and Time input
		public bool DateTimeAvailable()
		{
			if (Date == null || Time == null) {return false;}

			if (!(GetDateTime() > DateTime.Now)) {return false;}

			return true;
		}
	}
}
