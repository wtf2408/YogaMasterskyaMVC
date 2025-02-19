namespace YogaMasterskyaMVC.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Telegram { get; set; }
        public string PhotoUrl { get; set; }
        public List<string> Descriptions { get; set; }
        public List<string>? MainCourses { get; set; }
        public List<string>? AdditionalCourses { get; set; }
    }

}
