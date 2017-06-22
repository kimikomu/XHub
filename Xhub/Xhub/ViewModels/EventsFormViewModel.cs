using System.Collections.Generic;
using Xhub.Models;

namespace Xhub.ViewModels
{
	public class EventsFormViewModel
	{
		public string EventLocation { get; set; }
		public string Date { get; set; }
		public string Time { get; set; }
		public int EventType { get; set; }
		public IEnumerable<EventType> EventTypes { get; set; }
	}
}