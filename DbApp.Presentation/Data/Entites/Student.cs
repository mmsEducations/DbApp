namespace DbApp.Presentation.Data.Entites
{
    public class Student
    {
        public int StudentId { get; set; } //STUDENT_ID
        public string Name { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Photo { get; set; }
        public string? Info { get; set; }

        //Navigation property

        public Group Group { get; set; }

    }
}

