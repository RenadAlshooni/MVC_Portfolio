using System.ComponentModel.DataAnnotations;

namespace Portfolio.Models
{
    public class About : ContactInfo
    {
        public string? Birthday { get; set; }
        [Url]
        public string? Website { get; set; }
        public string? City { get; set; }
        public string? Age { get; set; }
        public string? Degree { get; set; }
        public string? Freelance { get; set; }
    }
}
