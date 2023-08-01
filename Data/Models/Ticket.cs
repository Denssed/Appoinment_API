using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Appoiment_API.Data.Models
{
    public class Ticket
    {
       
        public string Patient { get; set; }
        public string Med { get; set; }
        public string Date { get; set; }
        public string Speciality { get; set; }
        public int Cost { get; set; }

    }
}
