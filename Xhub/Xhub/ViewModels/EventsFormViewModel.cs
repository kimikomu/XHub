using System.Collections.Generic;
using Xhub.Models;

namespace Xhub.ViewModels
{
	public class EventsFormViewModel
	{
		public string EventLocation { get; set; }
		public string Date { get; set; }
		public string Time { get; set; }
		public byte EventType { get; set; }						// set to byte bc there won't be more than 255 types
		public IEnumerable<EventType> EventTypes { get; set; }
	}
}