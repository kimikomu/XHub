using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Xhub.Models
{
    public class Attendance
	{
		public Event Event { get; set; }
		public ApplicationUser Attendee { get; set; }

		// Primary key is made of the joint foreign keys
		[Key, Column(Order = 1)]
		public int EventId { get; set; }

		[Key, Column(Order = 2)]
		public string AttendeeId { get; set; }
	}
}