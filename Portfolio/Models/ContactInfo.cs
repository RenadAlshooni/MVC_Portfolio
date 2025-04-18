namespace Portfolio.Models
{
    public class ContactInfo:BaseModel
    {
        public string? Address { get; set; } 
        public string? Phone { get; set; }
        public string ?Email { get; set; }
    }
}
