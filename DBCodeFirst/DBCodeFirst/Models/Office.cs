using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBCodeFirst.Models
{
    public class Office
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OfficeId { get; set; }

        public string Title { get; set; }

        public string Location { get; set; }

        public List<Employee> Employees { get; set; } = new List<Employee>();
    }
}
