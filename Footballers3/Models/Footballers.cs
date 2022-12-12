using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Footballers3.Models
{
    public class Footballer
    {
        public int ID { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Gender { get; set; } = string.Empty;
        [Display(Name = "Date of birth")]
        [DataType(DataType.Date)]
        public DateTime Birth { get; set; }
        public string Team { get; set; } = string.Empty;
        public string Country { get; set; } = string.Empty;

    }
}
