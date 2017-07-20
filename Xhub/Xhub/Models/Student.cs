using System.ComponentModel.DataAnnotations;

namespace Xhub.Models
{
	public partial class Student
	{
		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string Name { get; set; }

		[Required]
		[StringLength(100)]
		public string Alias { get; set; }

		[Required]
		[StringLength(255)]
		public string Ability { get; set; }

		public Grades Grade { get; set; }

		public Origins Origin { get; set; }

		public ApplicationUser StudentUser { get; set; }

		public string StudentUserId { get; set; }
	}
}