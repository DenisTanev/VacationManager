using Microsoft.AspNetCore.Identity;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VacationManager.Models
{
    public class AppUser : IdentityUser
    {
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }



        /*[DisplayName("Team")]
        public int? TeamId { get; set; }
        public Team Team { get; set; }

        [DisplayName("Team led")]
        public int? TeamLedId { get; set; }
        public Team TeamLed { get; set; }



        public IEnumerable<Holiday> RequestedHolidays { get; set; }*/

        [DisplayName("Main role")]
        [NotMapped]
        public string MainRole { get; set; }
    }
}
