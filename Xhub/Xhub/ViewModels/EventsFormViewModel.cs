using System;
using System.Collections.Generic;
using Xhub.Models;

namespace Xhub.ViewModels
{
	public class EventsFormViewModel
	{
		public string EventLocation { get; set; }
		public string Date { get; set; }									// Date and Time are seperate inputs in the Add form 
		public string Time { get; set; }
		public DateTime DateTime => DateTime.Parse($"{Date} {Time}");		// Date and Time are parsed together from the Add form input for the database 
		public byte EventType { get; set; }									// set to byte bc there won't be more than 255 types
		public IEnumerable<EventType> EventTypes { get; set; }
		public string Description { get; set; }
		public string EventName { get; set; }
	}
}