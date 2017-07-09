using System.Collections.Generic;
using Xhub.Models;

namespace Xhub.ViewModels
{
	public class ProfileFormViewModel
	{
		public string Name { get; set; }
		public string Alias { get; set; }
		public string Ability { get; set; }
		public int Grade { get; set; }
		public IEnumerable<Grade> Grades { get; set; }
		public IEnumerable<Student.Origins> Origin { get; set; }
	}
}