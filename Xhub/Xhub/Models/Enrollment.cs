using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Xhub.Models
{
    public class Enrollment
    {
        public Class Class { get; set; }
        public ApplicationUser Enrollee { get; set; }

        // Primary key is made of the joint foreign keys
        [Key, Column(Order = 1)]
        public int ClassId { get; set; }

        [Key, Column(Order = 2)]
        public string EnrolleeId { get; set; } 
    }
}