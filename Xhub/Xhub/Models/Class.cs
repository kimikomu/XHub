using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Xhub.Models
{
	public class Class
	{
		public int Id { get; set; }

		[Required]
		[StringLength(255)]
		[DisplayName("Class Name")]
		public string ClassName { get; set; }

		public int TeacherId { get; set; }

		[DisplayName("First Day of Class")]
		public DateTime FirstClass { get; set; }

		public DateTime LastClass { get; set; }

		[DisplayName("Class Length")]
		public int LengthInMinutes { get; set; }

		[Required]
		[StringLength(255)]
		[DisplayName("Class Location")]
		public string ClassLocation { get; set; }

		[StringLength(500)]
		[DisplayName("Class Description")]
		public string ClassDescription { get; set; }
	}
}