using System.ComponentModel.DataAnnotations;

namespace Xhub.Models
{
	public class Student
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

		public Grade Grade { get; set; }

		public int GradeId { get; set; }

		public Origins Origin { get; set; }

		public enum Origins
		{
			Mutant = 0,
			Mutate = 1,
			Alein = 2,
			Other = 3
		}

		public int OriginId
		{
			get { return (int)this.Origin; }
			set { Origin = (Origins) value; }
		}
	}
}