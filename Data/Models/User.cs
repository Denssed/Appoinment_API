using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appoiment_API.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Ci { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(40)")]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(40)")]
        public string SurName { get; set; }
        [Required]
        [Column(TypeName = "nvarchar(40)")]
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        [Column(TypeName = "nvarchar(40)")]
        public int Speciality_id { get; set; }
        [Required]
        public string Role { get; set; }
    }
}
