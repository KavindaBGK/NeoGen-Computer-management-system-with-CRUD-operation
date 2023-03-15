using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NeoGen.Model
{
    public class Seller
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string IdCardNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int ContactNumber { get; set; }
        public string Address { get; set; }
    }
}
