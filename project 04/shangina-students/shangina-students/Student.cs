namespace StudentManager
{
    public class Student
    {
        public string LastName { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string MiddleName { get; set; } = string.Empty;
        public int Course { get; set; }
        public string Group { get; set; } = string.Empty;
        public DateTime BirthDate { get; set; }
        public string Email { get; set; } = string.Empty;
    }
} 