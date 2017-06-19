using System;
using System.ComponentModel.DataAnnotations;

namespace Xhub.Models
{
	public class Event
	{
		public int Id { get; set; }

		[Required]
		public ApplicationUser EventOwner { get; set; }

		public DateTime DateTime { get; set; }

		[Required, StringLength(255)]
		public string EventLocation { get; set; }

		[Required]
		public EventType EventType { get; set; }
	}
}