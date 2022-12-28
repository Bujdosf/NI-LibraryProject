using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NI_Library_Project.Shared.Models
{
    public class Rental
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int BookId { get; set; }

        public DateTime rentalStart { get; set; }

        public DateTime rentalEnd { get; set; }
    }
}
