using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NI_Library_Project.Shared.Models
{
    public class Books
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Writer { get; set; } = string.Empty;

        [Required]
        public string Publisher { get; set; } = string.Empty;

        [Required]
        public int Year_of_Publication { get; set; }

        public override string ToString()
        {
            return $"{Name}, by {Writer} from {Year_of_Publication}, published by {Publisher}, and ID of {Id}";
        }
    }
}
