using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBCodeFirst.Models
{
    public class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeId { get; set; }

        [MaxLength(50)]
        public string FirstName { get; set; }

        [MaxLength(50)]
        public string LastName { get; set; }

        public DateTime HiredDate { get; set; }

        public DateTime? DateOfBirth { get; set; }

        [ForeignKey("OfficeId")]
        public int OfficeId { get; set; }

        public Office Office { get; set; }

        [ForeignKey("TitleId")]
        public int TitleId { get; set; }

        public Title Title { get; set; }

        public List<EmployeeProject> Employees { get; set; } = new List<EmployeeProject>();
    }
}
