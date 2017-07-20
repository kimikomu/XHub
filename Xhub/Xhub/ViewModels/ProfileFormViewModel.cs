using System.ComponentModel.DataAnnotations;
using Xhub.Models;

namespace Xhub.ViewModels
{
	public class ProfileFormViewModel
	{
		public int Id { get; set; }

		[Required]
		[StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters.")]
		public string Name { get; set; }

		[Required]
		[StringLength(100, ErrorMessage = "Alias cannot be longer than 100 characters.")]
		public string Alias { get; set; }

		[Required]
		[StringLength(255, ErrorMessage = "Ability cannot be longer than 255 characters.")]
		public string Ability { get; set; }

		[Required]
		public Student.Grades Grade { get; set; }

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