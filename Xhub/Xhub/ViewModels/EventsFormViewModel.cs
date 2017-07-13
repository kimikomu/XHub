using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xhub.Models;

namespace Xhub.ViewModels
{
	public class EventsFormViewModel
	{
		public int Id { get; set; }

		public string Heading { get; set; }

		[Required(ErrorMessage = "The Event Name field is required.")]
		public string EventName { get; set; }

		[Required(ErrorMessage = "The Location field is required.")]
		public string EventLocation { get; set; }

		[Required]
		public string Date { get; set; }                                // Date and Time are seperate inputs in the Add form 

		[Required]
		public string Time { get; set; }

		public string Description { get; set; }

		[Required(ErrorMessage = "The Type field is required.")]
		public byte EventType { get; set; }                             // set to byte bc there won't be more than 255 types

		public IEnumerable<EventType> EventTypes { get; set; }

		public string Action
		{
			get { return (Id != 0) ? "Edit" : "Add"; }
		}

		public DateTime GetDateTime()                                   // Date and Time are parsed together from the Add form input for the database
		{
			return DateTime.Parse($"{Date} {Time}");
		}

		// Validate Date and Time input
		public bool DateTimeAvailable()
		{
			if (!(GetDateTime() > DateTime.Now)) return false;

			return true;
		}
	}
}
