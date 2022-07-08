using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBCodeFirst.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }

        public string Name { get; set; }

        public decimal Budget { get; set; }

        public DateTime StartedDate { get; set; }

        public List<EmployeeProject> Employees { get; set; } = new List<EmployeeProject>();
    }
}
