using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NI_Library_Project.Shared.Models
{
    public class Users
    {
        [Key]
        public long Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        public string Address { get; set; } = string.Empty!;

        [Required]
        public DateTime DateOfBirth { get; set; }
    }
}
