using System.ComponentModel.DataAnnotations;

namespace Xhub.Models
{
	public class EventType
	{
		public byte Id { get; set; }

		[Required, StringLength(255)]
		public string Type { get; set; }	 // Either table or enum. Tables would allow more expasion oppertunities and ability to see the list of students associated with the Type

		// constructors?

		// public List<Student> Roster
	}
}
