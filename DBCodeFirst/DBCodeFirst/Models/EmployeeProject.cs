using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBCodeFirst.Models
{
    public class EmployeeProject
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EmployeeProjectId { get; set; }

        public decimal Rate { get; set; }

        public DateTime StartedDate { get; set; }

        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }

        public Employee Employee { get; set; }

        [ForeignKey("ProjectId")]
        public int ProjectId { get; set; }

        public Project Project { get; set; }
    }
}
