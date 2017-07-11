using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Xhub.Models;

namespace Xhub.ViewModels
{
	public class ProfileFormViewModel
	{
		public int Id { get; set; }

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

		// Heading for the page can be modified
		public string Heading { get; set; }

		// if the student id exists, go to the edit action. Otherwise, go to the create action
		public string Action
		{
			get { return (Id != 0) ? "EditProfile" : "CreateProfile"; }
		}
	}
}