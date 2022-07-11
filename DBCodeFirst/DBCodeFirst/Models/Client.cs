using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DBCodeFirst.Models
{
    public class Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }

        [MaxLength(50)]
        public string FirtsName { get; set; }

        [MaxLength(50)]
        public string Lastname { get; set; }

        public long Telephone { get; set; }

        [MaxLength(100)]
        public string? Email { get; set; }

        public Project Project { get; set; }

    }
}