using System.ComponentModel.DataAnnotations;

namespace Xhub.Models
{
	public class Grade
	{
		public int Id { get; set; }

		[Required]
		[StringLength(100)]
		public string GradeLevel { get; set; }
	}
}