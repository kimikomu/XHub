using System;
using System.ComponentModel.DataAnnotations;

namespace Xhub.Models
{
	public class Event
	{
		public int Id { get; set; }

		public ApplicationUser EventOwner { get; set; }

		[Required]
		public string EventOwnerId { get; set; }	

		public DateTime DateTime { get; set; }

		[Required]
		[StringLength(255)]
		public string EventLocation { get; set; }

		public EventType EventType { get; set; }

		[Required]
		public byte EventTypeId { get; set; }

		[Required]
		[StringLength(255)]
		public string EventName { get; set; }

		[StringLength(255)]
		public string Description { get; set; }
	}
}