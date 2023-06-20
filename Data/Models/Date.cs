using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appoiment_API.Data.Models
{
    public class Date
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "Date"), DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Date_Appoiment { get; set; }

        
    }
}
