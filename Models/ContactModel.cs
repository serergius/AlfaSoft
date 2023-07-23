using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Alfasoft.Models
{
    [Table("Contacts")]
    public class ContactModel
    {
        [Display(Name = "Id")]
        [Column("Id")]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [Column("Name")]
        public string Name { get; set; }

        [Display(Name = "Contact")]
        [Column("Contact")]
        [StringLength(9, MinimumLength = 9, ErrorMessage = "Contact must to be 9 digits!")]
        public string Contact { get; set; }

        [Display(Name = "Email")]
        [Column("Email")]
        [EmailAddress(ErrorMessage = "Invalid Email Address!")]
        public string Email { get; set; }
    }
}
