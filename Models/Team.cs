using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VacationManager.Models
{
    public class Team
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 3)]
        [DisplayName("Team name")]
        public string Name { get; set; }

        [DisplayName("Leader")]
        public string LeaderId { get; set; }

        [DisplayName("Project")]
        public int? ProjectId { get; set; }

        public AppUser Leader { get; set; }

        public IEnumerable<AppUser> Members { get; set;}

        public Project Project { get; set; }
    }
}
