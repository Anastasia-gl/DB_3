using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBCodeFirst.Models
{
    public class Project
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProjectId { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public decimal Budget { get; set; }

        public DateTime StartedDate { get; set; }

        public List<EmployeeProject> Employees { get; set; } = new List<EmployeeProject>();

        [ForeignKey("ClientId")]
        public int ClientId { get; set; }

        public Client Client { get; set; }
    }
}
