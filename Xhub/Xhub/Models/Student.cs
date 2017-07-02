namespace Xhub.Models
{
	public class Student
	{
		public int Id { get; set; }

		public string Alias { get; set; }
		public string Ability { get; set; }
		public int Grade { get; set; }

		public enum Origin
		{
			Special,
			Mutant,
			Alein,
			Other
		}
	}
}