using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xhub.Models;

namespace Xhub.ViewModels
{
	public class ProfileFormViewModel
	{
		[Required]
		public string Name { get; set; }

		[Required]
		public string Alias { get; set; }

		[Required]
		public string Ability { get; set; }

		[Required]
		public int Grade { get; set; }

		public IEnumerable<Grade> Grades { get; set; }

		[Required]
		public Student.Origins Origin { get; set; }
	}
}