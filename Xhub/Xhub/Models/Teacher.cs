using System.ComponentModel.DataAnnotations;

namespace Xhub.Models
{
	public class Teacher
	{
		public int Id { get; set; }

		[StringLength(255)]
		public string TeacherFirstName { get; set; }

		[StringLength(255)]
		public string TeacherLastName { get; set; }

		[StringLength(255)]
		public string TeacherAlias { get; set; }

	}
}