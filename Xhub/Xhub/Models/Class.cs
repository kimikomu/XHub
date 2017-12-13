using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Xhub.Models
{
    public class Class
	{
		public int Id { get; set; }

		[Required]
		[StringLength(255)]
		[DisplayName("Title")]
		public string ClassName { get; set; }

		public int TeacherId { get; set; }

		public Teacher Teacher { get; set; }

		[DisplayName("Times")]
		public DateTime FirstClass { get; set; }

		[DisplayName("")]
		public DateTime SecondClass { get; set; }

		[DisplayName("Length")]
		public int LengthInMinutes { get; set; }

		[Required]
		[StringLength(255)]
		[DisplayName("Location")]
		public string ClassLocation { get; set; }

		[StringLength(500)]
		[DisplayName("Description")]
		public string ClassDescription { get; set; }

	    public ICollection<Enrollment> Enrollments { get; private set; }

	    public Class()
	    {
	        Enrollments = new Collection<Enrollment>();
	    }
	}
}