using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Appoiment_API.Data.Models
{
    public class Appoiment
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int Patient_id { get; set; }
        [Required]
        public int Med_id { get; set; }
        [Required]
        [Column(TypeName = "Date"), DisplayFormat(DataFormatString = "{dd/MM/yyyy}")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public int Especiality_id { get; set; }
        public int Cost { get; set; }  

        
    }
}
