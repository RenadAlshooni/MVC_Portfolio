namespace Portfolio.Models
{
    public class Projects:BaseModel
    {
        public string? projectName { get; set; }
        public string? projectBrief { get; set; }
        public string? imagePath { get; set; }
        public string? gitHubLink { get; set; }
    }
}
